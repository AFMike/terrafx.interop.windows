// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PPM_WMI_IDLE_STATE
    {
        [NativeTypeName("DWORD")]
        public uint Latency;

        [NativeTypeName("DWORD")]
        public uint Power;

        [NativeTypeName("DWORD")]
        public uint TimeCheck;

        [NativeTypeName("BYTE")]
        public byte PromotePercent;

        [NativeTypeName("BYTE")]
        public byte DemotePercent;

        [NativeTypeName("BYTE")]
        public byte StateType;

        [NativeTypeName("BYTE")]
        public byte Reserved;

        [NativeTypeName("DWORD")]
        public uint StateFlags;

        [NativeTypeName("DWORD")]
        public uint Context;

        [NativeTypeName("DWORD")]
        public uint IdleHandler;

        [NativeTypeName("DWORD")]
        public uint Reserved1;
    }
}
