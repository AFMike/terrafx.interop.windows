// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CERT_REVOCATION_STATUS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("DWORD")]
        public uint dwReason;

        [NativeTypeName("BOOL")]
        public int fHasFreshnessTime;

        [NativeTypeName("DWORD")]
        public uint dwFreshnessTime;
    }
}
