// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteAsyncResult interface represents the result of an asynchronous operation. A client can use the interface to wait for the operation to complete and to get the result.</summary>
    [Guid("CE25F8FD-863B-4D13-9651-C1F88DC73FE2")]
    public unsafe struct IDWriteAsyncResult
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteAsyncResult* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteAsyncResult* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteAsyncResult* This);

        /// <summary>The GetWaitHandleMethod method returns a handle that can be used to wait for the asynchronous operation to complete. The handle remains valid until the interface is released.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HANDLE")]
        public delegate IntPtr _GetWaitHandle(IDWriteAsyncResult* This);

        /// <summary>The GetResult method returns the result of the asynchronous operation. The return value is E_PENDING if the operation has not yet completed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetResult(IDWriteAsyncResult* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteAsyncResult* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteAsyncResult* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteAsyncResult* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetWaitHandle()
        {
            fixed (IDWriteAsyncResult* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetWaitHandle>(lpVtbl->GetWaitHandle)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResult()
        {
            fixed (IDWriteAsyncResult* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetResult>(lpVtbl->GetResult)(This);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetWaitHandle;

            public IntPtr GetResult;
        }
    }
}