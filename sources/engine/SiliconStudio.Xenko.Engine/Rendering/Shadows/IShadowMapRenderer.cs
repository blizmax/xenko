// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using System.Collections.Generic;
using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Rendering.Lights;

namespace SiliconStudio.Xenko.Rendering.Shadows
{
    /// <summary>
    /// Render shadow maps; should be set on <see cref="ForwardLightingRenderFeature.ShadowMapRenderer"/>.
    /// </summary>
    public interface IShadowMapRenderer
    {
        RenderSystem RenderSystem { get; set; }

        HashSet<RenderView> RenderViewsWithShadows { get; }

        List<ILightShadowMapRenderer> Renderers { get; }

        LightShadowMapTexture FindShadowMap(RenderView renderView, LightComponent lightComponent);

        void Collect(RenderContext context, Dictionary<RenderView, ForwardLightingRenderFeature.RenderViewLightData> renderViewLightDatas);

        void Draw(RenderDrawContext drawContext);

        void PrepareAtlasAsRenderTargets(CommandList commandList);

        void PrepareAtlasAsShaderResourceViews(CommandList commandList);

        void Flush(RenderDrawContext context);
    }
}
