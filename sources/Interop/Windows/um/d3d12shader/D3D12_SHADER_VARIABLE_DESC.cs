// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct D3D12_SHADER_VARIABLE_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("UINT")]
        public uint StartOffset;

        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("LPVOID")]
        public void* DefaultValue;

        [NativeTypeName("UINT")]
        public uint StartTexture;

        [NativeTypeName("UINT")]
        public uint TextureSize;

        [NativeTypeName("UINT")]
        public uint StartSampler;

        [NativeTypeName("UINT")]
        public uint SamplerSize;
    }
}
