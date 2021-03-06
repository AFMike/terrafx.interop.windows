// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9EB-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IInternetPriority : IUnknown")]
    public unsafe partial struct IInternetPriority
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IInternetPriority*, Guid*, void**, int>)(lpVtbl[0]))((IInternetPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInternetPriority*, uint>)(lpVtbl[1]))((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInternetPriority*, uint>)(lpVtbl[2]))((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return ((delegate* unmanaged<IInternetPriority*, int, int>)(lpVtbl[3]))((IInternetPriority*)Unsafe.AsPointer(ref this), nPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return ((delegate* unmanaged<IInternetPriority*, int*, int>)(lpVtbl[4]))((IInternetPriority*)Unsafe.AsPointer(ref this), pnPriority);
        }
    }
}
