// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public struct WICRawToneCurve
    {
        [NativeTypeName("UINT")]
        public uint cPoints;

        [NativeTypeName("WICRawToneCurvePoint[1]")]
        public _aPoints_e__FixedBuffer aPoints;

        public unsafe struct _aPoints_e__FixedBuffer
        {
            public WICRawToneCurvePoint e0;

            public ref WICRawToneCurvePoint this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<WICRawToneCurvePoint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
