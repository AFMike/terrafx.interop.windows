// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICComponentEnumerateOptions
    {
        WICComponentEnumerateDefault = 0,
        WICComponentEnumerateRefresh = 0x1,
        WICComponentEnumerateDisabled = unchecked((int)(0x80000000)),
        WICComponentEnumerateUnsigned = 0x40000000,
        WICComponentEnumerateBuiltInOnly = 0x20000000,
        WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD = 0x7fffffff,
    }
}
