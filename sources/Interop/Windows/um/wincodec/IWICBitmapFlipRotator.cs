// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5009834F-2D6A-41CE-9E1B-17C5AFF7A782")]
    public unsafe struct IWICBitmapFlipRotator
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapFlipRotator* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapFlipRotator* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapFlipRotator* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IWICBitmapFlipRotator* This,
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPixelFormat(
            [In] IWICBitmapFlipRotator* This,
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetResolution(
            [In] IWICBitmapFlipRotator* This,
            [Out] double* pDpiX,
            [Out] double* pDpiY
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPalette(
            [In] IWICBitmapFlipRotator* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyPixels(
            [In] IWICBitmapFlipRotator* This,
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Initialize(
            [In] IWICBitmapFlipRotator* This,
            [In, Optional] IWICBitmapSource* pISource,
            [In] WICBitmapTransformOptions options
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
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
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize(
            [Out, NativeTypeName("UINT")] uint* puiWidth,
            [Out, NativeTypeName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormat(
            [Out, NativeTypeName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResolution(
            [Out] double* pDpiX,
            [Out] double* pDpiY
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResolution>(lpVtbl->GetResolution)(
                    This,
                    pDpiX,
                    pDpiY
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPalette>(lpVtbl->CopyPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyPixels(
            [In, Optional] WICRect* prc,
            [In, NativeTypeName("UINT")] uint cbStride,
            [In, NativeTypeName("UINT")] uint cbBufferSize,
            [Out, NativeTypeName("BYTE[]")] byte* pbBuffer
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyPixels>(lpVtbl->CopyPixels)(
                    This,
                    prc,
                    cbStride,
                    cbBufferSize,
                    pbBuffer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Initialize(
            [In, Optional] IWICBitmapSource* pISource,
            [In] WICBitmapTransformOptions options
        )
        {
            fixed (IWICBitmapFlipRotator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Initialize>(lpVtbl->Initialize)(
                    This,
                    pISource,
                    options
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetSize;

            public IntPtr GetPixelFormat;

            public IntPtr GetResolution;

            public IntPtr CopyPalette;

            public IntPtr CopyPixels;

            public IntPtr Initialize;
        }
    }
}
