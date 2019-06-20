// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Specified options that can be applied when a layer resource is applied to create a layer.</summary>
    [Flags]
    public enum D2D1_LAYER_OPTIONS : uint
    {
        D2D1_LAYER_OPTIONS_NONE = 0x00000000,

        /// <summary>The layer will render correctly for ClearType text. If the render target was set to ClearType previously, the layer will continue to render ClearType. If the render target was set to ClearType and this option is not specified, the render target will be set to render gray-scale until the layer is popped. The caller can override this default by calling SetTextAntialiasMode while within the layer. This flag is slightly slower than the default.</summary>
        D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE = 0x00000001,

        D2D1_LAYER_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
