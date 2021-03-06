// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct RTL_CRITICAL_SECTION_DEBUG
    {
        [NativeTypeName("WORD")]
        public ushort Type;

        [NativeTypeName("WORD")]
        public ushort CreatorBackTraceIndex;

        [NativeTypeName("struct _RTL_CRITICAL_SECTION *")]
        public RTL_CRITICAL_SECTION* CriticalSection;

        public LIST_ENTRY ProcessLocksList;

        [NativeTypeName("DWORD")]
        public uint EntryCount;

        [NativeTypeName("DWORD")]
        public uint ContentionCount;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("WORD")]
        public ushort CreatorBackTraceIndexHigh;

        [NativeTypeName("WORD")]
        public ushort SpareWORD;
    }
}
