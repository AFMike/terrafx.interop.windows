// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SCM_LOGICAL_DEVICES
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint DeviceCount;

        [NativeTypeName("SCM_LOGICAL_DEVICE_INSTANCE [1]")]
        public _Devices_e__FixedBuffer Devices;

        public partial struct _Devices_e__FixedBuffer
        {
            public SCM_LOGICAL_DEVICE_INSTANCE e0;

            public ref SCM_LOGICAL_DEVICE_INSTANCE this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<SCM_LOGICAL_DEVICE_INSTANCE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}