// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFNProgressNotification([NativeTypeName("LPVOID")] void* pvData, [NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress);
}
