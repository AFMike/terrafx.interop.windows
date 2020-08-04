// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_DIRECTIONALBLUR_PROP : uint
    {
        D2D1_DIRECTIONALBLUR_PROP_STANDARD_DEVIATION = 0,
        D2D1_DIRECTIONALBLUR_PROP_ANGLE = 1,
        D2D1_DIRECTIONALBLUR_PROP_OPTIMIZATION = 2,
        D2D1_DIRECTIONALBLUR_PROP_BORDER_MODE = 3,
        D2D1_DIRECTIONALBLUR_PROP_FORCE_DWORD = 0xffffffff,
    }
}
