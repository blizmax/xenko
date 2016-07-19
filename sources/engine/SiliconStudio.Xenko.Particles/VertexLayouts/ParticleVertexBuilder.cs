﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Graphics;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace SiliconStudio.Xenko.Particles.VertexLayouts
{
    public struct ParticleBufferState
    {
        public readonly IntPtr VertexBufferOrigin;
        private readonly ParticleVertexBuilder vertexBuilder;

        public IntPtr VertexBuffer;
        public int CurrentParticleIndex;
        public int CurrentVertex;
        public int VertexStride;

        public int VerticesPerSegCurrent;

        public ParticleBufferState(IntPtr vertexBufferPtr, ParticleVertexBuilder builder)
        {
            VertexBuffer        = vertexBufferPtr;
            VertexBufferOrigin  = vertexBufferPtr;

            vertexBuilder       = builder;

            VertexStride        = builder.VertexDeclaration.VertexStride;
            CurrentParticleIndex = 0;
            CurrentVertex       = 0;

            VerticesPerSegCurrent = vertexBuilder.VerticesPerSegFirst;
        }

        /// <summary>
        /// Advances the pointer to the next vertex in the buffer, so that it can be written
        /// </summary>
        public void NextVertex()
        {
            if (++CurrentVertex >= (vertexBuilder.MaxParticles * vertexBuilder.VerticesPerParticle))
                CurrentVertex = (vertexBuilder.MaxParticles * vertexBuilder.VerticesPerParticle) - 1;

            VertexBuffer = VertexBufferOrigin + VertexStride * CurrentVertex;
        }

        /// <summary>
        /// Advances the pointer to the next particle in the buffer, so that its first vertex can be written
        /// </summary>
        public void NextParticle()
        {
            if (++CurrentParticleIndex >= vertexBuilder.MaxParticles)
                CurrentParticleIndex = vertexBuilder.MaxParticles - 1;

            VertexBuffer = VertexBufferOrigin + (VertexStride * CurrentParticleIndex * vertexBuilder.VerticesPerParticle);
        }

        /// <summary>
        /// Advances the pointer to the next segment in the buffer, so that its first vertex can be written
        /// </summary>
        public void NextSegment()
        {
            // The number of segments is tied to the number of particles
            if (++CurrentParticleIndex >= vertexBuilder.MaxParticles)
            {
                // Already at the last particle
                CurrentParticleIndex = vertexBuilder.MaxParticles - 1;
                return;
            }

            VertexBuffer += VertexStride * VerticesPerSegCurrent;
            VerticesPerSegCurrent = (CurrentParticleIndex < vertexBuilder.MaxParticles - 1) ? vertexBuilder.VerticesPerSegMiddle : vertexBuilder.VerticesPerSegLast;
        }

        /// <summary>
        /// Moves the index to the beginning of the buffer so that the data can be filled from the first particle again
        /// </summary>
        public void RestartBuffer()
        {
            VertexBuffer = VertexBufferOrigin;
            CurrentParticleIndex = 0;
            CurrentVertex = 0;
            VerticesPerSegCurrent = vertexBuilder.VerticesPerSegFirst;
        }
    }

    /// <summary>
    /// Manager class for the vertex buffer stream which can dynamically change the required vertex layout and rebuild the buffer based on the particle fields
    /// </summary>
    public class ParticleVertexBuilder
    {
        public int VerticesPerParticle { get; private set; } = 4;
        private int verticesPerQuad = 4;

        public readonly int IndicesPerQuad = 6;

        public delegate void TransformAttributeDelegate<T>(ref T value);

        private int vertexStructSize;
        private readonly int indexStructSize;

        private readonly Dictionary<AttributeDescription, AttributeAccessor> availableAttributes;

        private readonly List<VertexElement> vertexElementList;

        private int requiredQuads;

        private MappedResource mappedVertices;
//        private IntPtr vertexBuffer = IntPtr.Zero;
//        private IntPtr vertexBufferOrigin = IntPtr.Zero;

//        private int currentVertex;
//        private int maxVertices;

//        private int currentParticleIndex;
        public int MaxParticles { get; private set; }

        public int LivingQuads { get; private set; }

        public DeviceResourceContext ResourceContext { get; private set; }

        public bool IsBufferDirty { get; private set; } = true;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ParticleVertexBuilder()
        {
            vertexElementList = new List<VertexElement>();

            ResetVertexElementList();

            indexStructSize = sizeof(short);

            availableAttributes = new Dictionary<AttributeDescription, AttributeAccessor>();

            UpdateVertexLayout();
        }

        internal int VerticesPerSegFirst { get; private set; }
        internal int VerticesPerSegMiddle { get; private set; }
        internal int VerticesPerSegLast { get; private set; }

        internal int VerticesPerSegCurrent { get; private set; }

        /// <summary>
        /// The current <see cref="Graphics.VertexDeclaration"/> of the contained vertex buffer
        /// </summary>
        public VertexDeclaration VertexDeclaration { get; private set; }

        /// <summary>
        /// The current number of vertices which have to be drawn
        /// </summary>
        public int VertexCount => LivingQuads * verticesPerQuad;

        /// <summary>
        /// The default texture coordinates will default to the first texture coordinates element added to the list in case there are two or more sets
        /// </summary>
        public AttributeDescription DefaultTexCoords { get; private set; } = new AttributeDescription(null);

        /// <summary>
        /// Resets the list of required vertex elements, setting it to the minimum mandatory length
        /// </summary>
        public void ResetVertexElementList()
        {
            vertexElementList.Clear();

            // Mandatory
            AddVertexElement(ParticleVertexElements.Position);
            //AddVertexElement(ParticleVertexElements.TexCoord0);
        }

        /// <summary>
        /// Adds a new required element to the list of vertex elements, if it's not in the list already
        /// </summary>
        /// <param name="element">New element to add</param>
        public void AddVertexElement(VertexElement element)
        {
            if (vertexElementList.Contains(element))
                return;

            vertexElementList.Add(element);
        }

        /// <summary>
        /// Updates the vertex layout with the new list. Should be called only when there have been changes to the list.
        /// </summary>
        public void UpdateVertexLayout()
        {
            VertexDeclaration = new VertexDeclaration(vertexElementList.ToArray());

            availableAttributes.Clear();
            DefaultTexCoords = new AttributeDescription(null);

            var totalOffset = 0;
            foreach (var vertexElement in VertexDeclaration.VertexElements)
            {
                var attrDesc = new AttributeDescription(vertexElement.SemanticAsText);
                if (DefaultTexCoords.GetHashCode() == 0 && vertexElement.SemanticAsText.Contains("TEXCOORD"))
                {
                    DefaultTexCoords = attrDesc;
                }

                var stride = vertexElement.Format.SizeInBytes();
                var attrAccs = new AttributeAccessor { Offset = totalOffset, Size = stride };
                totalOffset += stride;

                availableAttributes.Add(attrDesc, attrAccs);
            }

            IsBufferDirty = true;
        }

        /// <summary>
        /// Sets the required quads per particle and number of particles so that a sufficiently big buffer can be allocated
        /// </summary>
        /// <param name="quadsPerParticle">Required quads per particle, assuming 1 quad = 4 vertices = 6 indices</param>
        /// <param name="livingParticles">Number of living particles this frame</param>
        /// <param name="totalParticles">Number of total number of possible particles for the parent emitter</param>
        public void SetRequiredQuads(int quadsPerParticle, int livingParticles, int totalParticles)
        {
            VerticesPerParticle = quadsPerParticle * verticesPerQuad;
            var minQuads = quadsPerParticle * livingParticles;
            var maxQuads = quadsPerParticle * totalParticles;

            LivingQuads = minQuads;
            MaxParticles = livingParticles;

            if (requiredQuads == 0 || minQuads > requiredQuads || maxQuads <= requiredQuads / 2)
            {
                requiredQuads = maxQuads;
                IsBufferDirty = true;
            }
        }

        /// <summary>
        /// Resets the <see cref="ParticleVertexBuilder"/> to its initial state, freeing any graphics memory used
        /// </summary>
        public void Reset()
        {
            SetRequiredQuads(4, 0, 0);
            ResourceContext?.Dispose();
            ResourceContext = null;
        }

        public void RecreateBuffers(GraphicsDevice graphicsDevice)
        {
            if (requiredQuads == 0)
            {
                ResourceContext?.Dispose();
                ResourceContext = null;
            }
            else
            {
                ResourceContext?.Dispose();
                ResourceContext = new DeviceResourceContext(graphicsDevice, VertexDeclaration, requiredQuads * verticesPerQuad, indexStructSize, requiredQuads * IndicesPerQuad);
            }

            // The default assumption is that every particle defines a separate segment and no segments are shared
            SetVerticesPerSegment(VerticesPerParticle, VerticesPerParticle, VerticesPerParticle);
        }

        /// <summary>
        /// Sets how many vertices are associated with the first, middle and last quad segments of the buffer. In case of billboards 1 segment = 1 quad but other shapes might be laid out differently
        /// </summary>
        /// <param name="verticesForFirstSegment">Number of vertices for the first segment</param>
        /// <param name="verticesForMiddleSegment">Number of vertices for the middle segments</param>
        /// <param name="verticesForLastSegment">Number of vertices for the last segment</param>
        public void SetVerticesPerSegment(int verticesForFirstSegment, int verticesForMiddleSegment, int verticesForLastSegment)
        {
            VerticesPerSegFirst = verticesForFirstSegment;
            VerticesPerSegMiddle = verticesForMiddleSegment;
            VerticesPerSegLast = verticesForLastSegment;

            VerticesPerSegCurrent = VerticesPerSegFirst;
        }

        /// <summary>
        /// Initiates a new vertex and index buffers
        /// </summary>
        /// <param name="device"><see cref="GraphicsDevice"/> to use</param>
        /// <param name="vertexCount">Required vertices count. Stride is estimated from the vertex declaration</param>
        /// <param name="indexCount">Required indices count. Stride is automatically estimated</param>
        private unsafe void InitializeIndexBuffer(CommandList commandList, int indexCount)
        {
            vertexStructSize = VertexDeclaration.VertexStride;

            var mappedIndices = commandList.MapSubresource(ResourceContext.IndexBuffer.Buffer, 0, MapMode.WriteDiscard, false, 0, indexCount * indexStructSize);
            var indexPointer = mappedIndices.DataBox.DataPointer;

            var k = 0;
            for (var i = 0; i < indexCount; k += verticesPerQuad)
            {
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 0);
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 1);
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 2);
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 0);
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 2);
                *(short*)(indexPointer + indexStructSize * i++) = (short)(k + 3);
            }

            commandList.UnmapSubresource(mappedIndices);
        }

        /// <summary>
        /// Maps a subresource so that particle data can be written to the vertex buffer
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public IntPtr MapBuffer(CommandList commandList)
        {
            if (IsBufferDirty && requiredQuads > 0)
            {
                InitializeIndexBuffer(commandList, requiredQuads * IndicesPerQuad);
                IsBufferDirty = false;
            }

            if (IsBufferDirty)
                return IntPtr.Zero;

            mappedVertices = commandList.MapSubresource(ResourceContext.VertexBuffer.Buffer, 0, MapMode.WriteDiscard, false, 0, ResourceContext.VertexCount * vertexStructSize);

            return mappedVertices.DataBox.DataPointer;
        }

        /// <summary>
        /// Unmaps the subresource after all the particle data has been updated
        /// </summary>
        /// <param name="device"></param>
        public void UnmapBuffer(CommandList commandList)
        {
            if (IsBufferDirty)
                return;

            commandList.UnmapSubresource(mappedVertices);
        }

        public AttributeAccessor GetAccessor(AttributeDescription desc) 
        {            
            AttributeAccessor accessor;
            if (!availableAttributes.TryGetValue(desc, out accessor))
            {
                return new AttributeAccessor { Offset = 0, Size = 0 };
            }
            
            return accessor;
        }

        /// <summary>
        /// Sets the data for the current vertex using the provided <see cref="AttributeAccessor"/>
        /// </summary>
        /// <param name="accessor">Accessor to the vertex data</param>
        /// <param name="ptrRef">Pointer to the source data</param>
        public void SetAttribute(ref ParticleBufferState state, AttributeAccessor accessor, IntPtr ptrRef) 
        {
            Utilities.CopyMemory(state.VertexBuffer + accessor.Offset, ptrRef, accessor.Size);
        }

        /// <summary>
        /// Sets the same data for the all vertices in the current particle using the provided <see cref="AttributeAccessor"/>
        /// </summary>
        /// <param name="accessor">Accessor to the vertex data</param>
        /// <param name="ptrRef">Pointer to the source data</param>
        public void SetAttributePerParticle(ref ParticleBufferState state, AttributeAccessor accessor, IntPtr ptrRef)
        {
            for (var i = 0; i < VerticesPerParticle; i++)
            {
                Utilities.CopyMemory(state.VertexBuffer + accessor.Offset + i * VertexDeclaration.VertexStride, ptrRef, accessor.Size);
            }
        }

        /// <summary>
        /// Sets the same data for the all vertices in the current particle using the provided <see cref="AttributeAccessor"/>
        /// </summary>
        /// <param name="accessor">Accessor to the vertex data</param>
        /// <param name="ptrRef">Pointer to the source data</param>
        public void SetAttributePerSegment(ref ParticleBufferState state, AttributeAccessor accessor, IntPtr ptrRef)
        {
            for (var i = 0; i < VerticesPerSegCurrent; i++)
            {
                Utilities.CopyMemory(state.VertexBuffer + accessor.Offset + i * VertexDeclaration.VertexStride, ptrRef, accessor.Size);
            }
        }

        /// <summary>
        /// Transforms attribute data using already written data from another attribute
        /// </summary>
        /// <typeparam name="T">Type data</typeparam>
        /// <param name="accessorTo">Vertex attribute accessor to the destination attribute</param>
        /// <param name="accessorFrom">Vertex attribute accessor to the source attribute</param>
        /// <param name="transformMethod">Transform method for the type data</param>
        public void TransformAttributePerSegment<T>(ref ParticleBufferState state, AttributeAccessor accessorFrom, AttributeAccessor accessorTo, IAttributeTransformer<T> transformMethod) where T : struct
        {
            for (var i = 0; i < VerticesPerSegCurrent; i++)
            {
                var temp = Utilities.Read<T>(state.VertexBuffer + accessorFrom.Offset + i * VertexDeclaration.VertexStride);

                transformMethod.Transform(ref temp);

                Utilities.Write(state.VertexBuffer + accessorTo.Offset + i * VertexDeclaration.VertexStride, ref temp);
            }
        }

        /// <summary>
        /// Transforms already written attribute data using the provided transform method
        /// </summary>
        /// <typeparam name="T">Type data</typeparam>
        /// <param name="accessor">Vertex attribute accessor</param>
        /// <param name="transformMethod">Transform method for the type data</param>
        public void TransformAttributePerParticle<T>(ref ParticleBufferState state, AttributeAccessor accessor, TransformAttributeDelegate<T> transformMethod) where T : struct
        {
            for (var i = 0; i < VerticesPerParticle; i++)
            {
                var temp = Utilities.Read<T>(state.VertexBuffer + accessor.Offset + i * VertexDeclaration.VertexStride);

                transformMethod(ref temp);

                Utilities.Write(state.VertexBuffer + accessor.Offset + i * VertexDeclaration.VertexStride, ref temp);
            }
        }

        /// <summary>
        /// Transforms attribute data using already written data from another attribute
        /// </summary>
        /// <typeparam name="T">Type data</typeparam>
        /// <param name="accessorTo">Vertex attribute accessor to the destination attribute</param>
        /// <param name="accessorFrom">Vertex attribute accessor to the source attribute</param>
        /// <param name="transformMethod">Transform method for the type data</param>
        public void TransformAttributePerParticle<T>(ref ParticleBufferState state, AttributeAccessor accessorFrom, AttributeAccessor accessorTo, TransformAttributeDelegate<T> transformMethod) where T : struct
        {
            for (var i = 0; i < VerticesPerParticle; i++)
            {
                var temp = Utilities.Read<T>(state.VertexBuffer + accessorFrom.Offset + i * VertexDeclaration.VertexStride);

                transformMethod(ref temp);

                Utilities.Write(state.VertexBuffer + accessorTo.Offset + i * VertexDeclaration.VertexStride, ref temp);
            }
        }

        public void TransformAttributePerParticle<T>(ref ParticleBufferState state, AttributeAccessor accessorFrom, AttributeAccessor accessorTo, IAttributeTransformer<T> transformMethod) where T : struct
        {
            for (var i = 0; i < VerticesPerParticle; i++)
            {
                var temp = Utilities.Read<T>(state.VertexBuffer + accessorFrom.Offset + i * VertexDeclaration.VertexStride);

                transformMethod.Transform(ref temp);

                Utilities.Write(state.VertexBuffer + accessorTo.Offset + i * VertexDeclaration.VertexStride, ref temp);
            }
        }

        /// <summary>
        /// Use a ResourceContext per GraphicsDevice (DeviceContext)
        /// </summary>
        public class DeviceResourceContext : ComponentBase
        {
            /// <summary>
            /// Gets the number of vertices.
            /// </summary>
            public readonly int VertexCount;

            public VertexBufferBinding VertexBuffer;

            public IndexBufferBinding IndexBuffer;

            public DeviceResourceContext(GraphicsDevice device, VertexDeclaration declaration, int vertexCount, int indexStructSize, int indexCount)
            {
                var vertexSize = declaration.CalculateSize();

                VertexCount = vertexCount;

                // Workaround: due to graphics refactor sometimes empty emitters will try to draw 0 particles
                // TODO Avoid calling this method if LivingParticles == 0
                {
                    if (VertexCount <= 0)
                        VertexCount = 1;
                    if (indexCount <= 0)
                        indexCount = 1;
                }

                var vertexBuffer = Buffer.Vertex.New(device, VertexCount * vertexSize, GraphicsResourceUsage.Dynamic).DisposeBy(this);
                var indexBuffer = Buffer.Index.New(device, indexCount * indexStructSize, GraphicsResourceUsage.Dynamic).DisposeBy(this);

                IndexBuffer = new IndexBufferBinding(indexBuffer, indexStructSize == sizeof(int), indexCount);
                VertexBuffer = new VertexBufferBinding(vertexBuffer, declaration, VertexCount, vertexSize);
            }
        }
    }
}
