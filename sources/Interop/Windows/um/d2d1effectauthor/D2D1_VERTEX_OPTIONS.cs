// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D2D1_VERTEX_OPTIONS : uint
    {
        D2D1_VERTEX_OPTIONS_NONE = 0,
        D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR = 1,
        D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER = 2,
        D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP = 4,
        D2D1_VERTEX_OPTIONS_FORCE_DWORD = 0xffffffff,
    }
}
