// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_CONTENT_PROTECTION_CAPS
    {
        [NativeTypeName("UINT")]
        public uint Caps;

        [NativeTypeName("UINT")]
        public uint KeyExchangeTypeCount;

        [NativeTypeName("UINT")]
        public uint BlockAlignmentSize;

        [NativeTypeName("ULONGLONG")]
        public ulong ProtectedMemorySize;
    }
}
