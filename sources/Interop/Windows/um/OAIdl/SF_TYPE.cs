// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.VARENUM;

namespace TerraFX.Interop
{
    public enum SF_TYPE
    {
        SF_ERROR = VT_ERROR,
        SF_I1 = VT_I1,
        SF_I2 = VT_I2,
        SF_I4 = VT_I4,
        SF_I8 = VT_I8,
        SF_BSTR = VT_BSTR,
        SF_UNKNOWN = VT_UNKNOWN,
        SF_DISPATCH = VT_DISPATCH,
        SF_VARIANT = VT_VARIANT,
        SF_RECORD = VT_RECORD,
        SF_HAVEIID = (VT_UNKNOWN | VT_RESERVED),
    }
}
