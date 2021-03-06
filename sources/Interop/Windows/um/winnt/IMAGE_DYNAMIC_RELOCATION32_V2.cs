// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct IMAGE_DYNAMIC_RELOCATION32_V2
    {
        [NativeTypeName("DWORD")]
        public uint HeaderSize;

        [NativeTypeName("DWORD")]
        public uint FixupInfoSize;

        [NativeTypeName("DWORD")]
        public uint Symbol;

        [NativeTypeName("DWORD")]
        public uint SymbolGroup;

        [NativeTypeName("DWORD")]
        public uint Flags;
    }
}
