// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
    public unsafe struct IWICDdsDecoder
    {
        public readonly Vtbl* lpVtbl;

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICDdsDecoder* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICDdsDecoder* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICDdsDecoder* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetParameters(
            [In] IWICDdsDecoder* This,
            [Out] WICDdsParameters* pParameters
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFrame(
            [In] IWICDdsDecoder* This,
            [In, NativeTypeName("UINT")] uint arrayIndex,
            [In, NativeTypeName("UINT")] uint mipLevel,
            [In, NativeTypeName("UINT")] uint sliceIndex,
            [Out] IWICBitmapFrameDecode** ppIBitmapFrame = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParameters(
            [Out] WICDdsParameters* pParameters
        )
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParameters>(lpVtbl->GetParameters)(
                    This,
                    pParameters
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrame(
            [In, NativeTypeName("UINT")] uint arrayIndex,
            [In, NativeTypeName("UINT")] uint mipLevel,
            [In, NativeTypeName("UINT")] uint sliceIndex,
            [Out] IWICBitmapFrameDecode** ppIBitmapFrame = null
        )
        {
            fixed (IWICDdsDecoder* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrame>(lpVtbl->GetFrame)(
                    This,
                    arrayIndex,
                    mipLevel,
                    sliceIndex,
                    ppIBitmapFrame
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetParameters;

            public IntPtr GetFrame;
        }
    }
}
