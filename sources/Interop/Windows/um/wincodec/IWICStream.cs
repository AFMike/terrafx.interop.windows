// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
    public unsafe struct IWICStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Read(
            [In] IWICStream* This,
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Write(
            [In] IWICStream* This,
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Seek(
            [In] IWICStream* This,
            [In] LARGE_INTEGER dlibMove,
            [In, NativeTypeName("DWORD")] uint dwOrigin,
            [Out] ULARGE_INTEGER* plibNewPosition = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSize(
            [In] IWICStream* This,
            [In] ULARGE_INTEGER libNewSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyTo(
            [In] IWICStream* This,
            [In] IStream* pstm,
            [In] ULARGE_INTEGER cb,
            [Out] ULARGE_INTEGER* pcbRead = null,
            [Out] ULARGE_INTEGER* pcbWritten = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Commit(
            [In] IWICStream* This,
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Revert(
            [In] IWICStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _LockRegion(
            [In] IWICStream* This,
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _UnlockRegion(
            [In] IWICStream* This,
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Stat(
            [In] IWICStream* This,
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] IWICStream* This,
            [Out] IStream** ppstm = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromIStream(
            [In] IWICStream* This,
            [In] IStream* pIStream = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromFilename(
            [In] IWICStream* This,
            [In, NativeTypeName("LPCWSTR")] char* wzFileName,
            [In, NativeTypeName("DWORD")] uint dwDesiredAccess
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromMemory(
            [In] IWICStream* This,
            [In, NativeTypeName("WICInProcPointer")] byte* pbBuffer,
            [In, NativeTypeName("DWORD")] uint cbBufferSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InitializeFromIStreamRegion(
            [In] IWICStream* This,
            [In, Optional] IStream* pIStream,
            [In] ULARGE_INTEGER ulOffset,
            [In] ULARGE_INTEGER ulMaxSize
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICStream* This = &this)
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
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Read(
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)(
                    This,
                    pv,
                    cb,
                    pcbRead
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Write(
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)(
                    This,
                    pv,
                    cb,
                    pcbWritten
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(
            [In] LARGE_INTEGER dlibMove,
            [In, NativeTypeName("DWORD")] uint dwOrigin,
            [Out] ULARGE_INTEGER* plibNewPosition = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Seek>(lpVtbl->Seek)(
                    This,
                    dlibMove,
                    dwOrigin,
                    plibNewPosition
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(
            [In] ULARGE_INTEGER libNewSize
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)(
                    This,
                    libNewSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo(
            [In] IStream* pstm,
            [In] ULARGE_INTEGER cb,
            [Out] ULARGE_INTEGER* pcbRead = null,
            [Out] ULARGE_INTEGER* pcbWritten = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)(
                    This,
                    pstm,
                    cb,
                    pcbRead,
                    pcbWritten
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit(
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(
                    This,
                    grfCommitFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LockRegion>(lpVtbl->LockRegion)(
                    This,
                    libOffset,
                    cb,
                    dwLockType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>(lpVtbl->UnlockRegion)(
                    This,
                    libOffset,
                    cb,
                    dwLockType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat(
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)(
                    This,
                    pstatstg,
                    grfStatFlag
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] IStream** ppstm = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    ppstm
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStream(
            [In] IStream* pIStream = null
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromIStream>(lpVtbl->InitializeFromIStream)(
                    This,
                    pIStream
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename(
            [In, NativeTypeName("LPCWSTR")] char* wzFileName,
            [In, NativeTypeName("DWORD")] uint dwDesiredAccess
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromFilename>(lpVtbl->InitializeFromFilename)(
                    This,
                    wzFileName,
                    dwDesiredAccess
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory(
            [In, NativeTypeName("WICInProcPointer")] byte* pbBuffer,
            [In, NativeTypeName("DWORD")] uint cbBufferSize
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromMemory>(lpVtbl->InitializeFromMemory)(
                    This,
                    pbBuffer,
                    cbBufferSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStreamRegion(
            [In, Optional] IStream* pIStream,
            [In] ULARGE_INTEGER ulOffset,
            [In] ULARGE_INTEGER ulMaxSize
        )
        {
            fixed (IWICStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromIStreamRegion>(lpVtbl->InitializeFromIStreamRegion)(
                    This,
                    pIStream,
                    ulOffset,
                    ulMaxSize
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Read;

            public IntPtr Write;

            public IntPtr Seek;

            public IntPtr SetSize;

            public IntPtr CopyTo;

            public IntPtr Commit;

            public IntPtr Revert;

            public IntPtr LockRegion;

            public IntPtr UnlockRegion;

            public IntPtr Stat;

            public IntPtr Clone;

            public IntPtr InitializeFromIStream;

            public IntPtr InitializeFromFilename;

            public IntPtr InitializeFromMemory;

            public IntPtr InitializeFromIStreamRegion;
        }
    }
}
