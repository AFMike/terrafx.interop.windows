// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        public const uint DXGI_CREATE_FACTORY_DEBUG = 0x00000001;

        public static readonly Guid IID_IDXGIDevice3 = new Guid(0x6007896C, 0x3244, 0x4AFD, 0xBF, 0x18, 0xA6, 0xD3, 0xBE, 0xDA, 0x50, 0x23);

        public static readonly Guid IID_IDXGISwapChain2 = new Guid(0xA8BE2AC4, 0x199F, 0x4946, 0xB3, 0x31, 0x79, 0x59, 0x9F, 0xB9, 0x8D, 0xE7);

        public static readonly Guid IID_IDXGIOutput2 = new Guid(0x595E39D1, 0x2724, 0x4663, 0x99, 0xB1, 0xDA, 0x96, 0x9D, 0xE2, 0x83, 0x64);

        public static readonly Guid IID_IDXGIFactory3 = new Guid(0x25483823, 0xCD46, 0x4C7D, 0x86, 0xCA, 0x47, 0xAA, 0x95, 0xB8, 0x37, 0xBD);

        public static readonly Guid IID_IDXGIDecodeSwapChain = new Guid(0x2633066B, 0x4514, 0x4C7A, 0x8F, 0xD8, 0x12, 0xEA, 0x98, 0x05, 0x9D, 0x18);

        public static readonly Guid IID_IDXGIFactoryMedia = new Guid(0x41E7D1F2, 0xA591, 0x4F7B, 0xA2, 0xE5, 0xFA, 0x9C, 0x84, 0x3E, 0x1C, 0x12);

        public static readonly Guid IID_IDXGISwapChainMedia = new Guid(0xDD95B90B, 0xF05F, 0x4F6A, 0xBD, 0x65, 0x25, 0xBF, 0xB2, 0x64, 0xBD, 0x84);

        public static readonly Guid IID_IDXGIOutput3 = new Guid(0x8A6BB301, 0x7E7E, 0x41F4, 0xA8, 0xE0, 0x5B, 0x32, 0xF7, 0xF9, 0x9B, 0x18);

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "CreateDXGIFactory2", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory2(
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppFactory
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "DXGIGetDebugInterface1", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface1(
            [In, NativeTypeName("UINT")] uint Flags,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** pDebug
        );
    }
}
