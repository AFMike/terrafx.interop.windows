// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_OPACITY_MASK_CONTENT : uint
    {
        D2D1_OPACITY_MASK_CONTENT_GRAPHICS = 0,
        D2D1_OPACITY_MASK_CONTENT_TEXT_NATURAL = 1,
        D2D1_OPACITY_MASK_CONTENT_TEXT_GDI_COMPATIBLE = 2,
        D2D1_OPACITY_MASK_CONTENT_FORCE_DWORD = 0xffffffff,
    }
}
