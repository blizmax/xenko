﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Rendering;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace SiliconStudio.Xenko.Rendering.Images
{
    public static partial class LambertianPrefilteringSHPass1Keys
    {
        public static readonly ObjectParameterKey<Texture> RadianceMap = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Buffer> OutputBuffer = ParameterKeys.NewObject<Buffer>();
    }
}
