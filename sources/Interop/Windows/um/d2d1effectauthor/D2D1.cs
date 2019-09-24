// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class D2D1
    {
        public const uint D2D1_APPEND_ALIGNED_ELEMENT = 0xFFFFFFFF;

        public static readonly Guid IID_ID2D1VertexBuffer = new Guid(0x9B8B1336, 0x00A5, 0x4668, 0x92, 0xB7, 0xCE, 0xD5, 0xD8, 0xBF, 0x9B, 0x7B);

        public static readonly Guid IID_ID2D1ResourceTexture = new Guid(0x688D15C3, 0x02B0, 0x438D, 0xB1, 0x3A, 0xD1, 0xB4, 0x4C, 0x32, 0xC3, 0x9A);

        public static readonly Guid IID_ID2D1RenderInfo = new Guid(0x519AE1BD, 0xD19A, 0x420D, 0xB8, 0x49, 0x36, 0x4F, 0x59, 0x47, 0x76, 0xB7);

        public static readonly Guid IID_ID2D1DrawInfo = new Guid(0x693CE632, 0x7F2F, 0x45DE, 0x93, 0xFE, 0x18, 0xD8, 0x8B, 0x37, 0xAA, 0x21);

        public static readonly Guid IID_ID2D1ComputeInfo = new Guid(0x5598B14B, 0x9FD7, 0x48B7, 0x9B, 0xDB, 0x8F, 0x09, 0x64, 0xEB, 0x38, 0xBC);

        public static readonly Guid IID_ID2D1TransformNode = new Guid(0xB2EFE1E7, 0x729F, 0x4102, 0x94, 0x9F, 0x50, 0x5F, 0xA2, 0x1B, 0xF6, 0x66);

        public static readonly Guid IID_ID2D1TransformGraph = new Guid(0x13D29038, 0xC3E6, 0x4034, 0x90, 0x81, 0x13, 0xB5, 0x3A, 0x41, 0x79, 0x92);

        public static readonly Guid IID_ID2D1Transform = new Guid(0xEF1A287D, 0x342A, 0x4F76, 0x8F, 0xDB, 0xDA, 0x0D, 0x6E, 0xA9, 0xF9, 0x2B);

        public static readonly Guid IID_ID2D1DrawTransform = new Guid(0x36BFDCB6, 0x9739, 0x435D, 0xA3, 0x0D, 0xA6, 0x53, 0xBE, 0xFF, 0x6A, 0x6F);

        public static readonly Guid IID_ID2D1ComputeTransform = new Guid(0x0D85573C, 0x01E3, 0x4F7D, 0xBF, 0xD9, 0x0D, 0x60, 0x60, 0x8B, 0xF3, 0xC3);

        public static readonly Guid IID_ID2D1AnalysisTransform = new Guid(0x0359DC30, 0x95E6, 0x4568, 0x90, 0x55, 0x27, 0x72, 0x0D, 0x13, 0x0E, 0x93);

        public static readonly Guid IID_ID2D1SourceTransform = new Guid(0xDB1800DD, 0x0C34, 0x4CF9, 0xBE, 0x90, 0x31, 0xCC, 0x0A, 0x56, 0x53, 0xE1);

        public static readonly Guid IID_ID2D1ConcreteTransform = new Guid(0x1A799D8A, 0x69F7, 0x4E4C, 0x9F, 0xED, 0x43, 0x7C, 0xCC, 0x66, 0x84, 0xCC);

        public static readonly Guid IID_ID2D1BlendTransform = new Guid(0x63AC0B32, 0xBA44, 0x450F, 0x88, 0x06, 0x7F, 0x4C, 0xA1, 0xFF, 0x2F, 0x1B);

        public static readonly Guid IID_ID2D1BorderTransform = new Guid(0x4998735C, 0x3A19, 0x473C, 0x97, 0x81, 0x65, 0x68, 0x47, 0xE3, 0xA3, 0x47);

        public static readonly Guid IID_ID2D1OffsetTransform = new Guid(0x3FE6ADEA, 0x7643, 0x4F53, 0xBD, 0x14, 0xA0, 0xCE, 0x63, 0xF2, 0x40, 0x42);

        public static readonly Guid IID_ID2D1BoundsAdjustmentTransform = new Guid(0x90F732E2, 0x5092, 0x4606, 0xA8, 0x19, 0x86, 0x51, 0x97, 0x0B, 0xAC, 0xCD);

        public static readonly Guid IID_ID2D1EffectImpl = new Guid(0xA248FD3F, 0x3E6C, 0x4E63, 0x9F, 0x03, 0x7F, 0x68, 0xEC, 0xC9, 0x1D, 0xB9);

        public static readonly Guid IID_ID2D1EffectContext = new Guid(0x3D9F916B, 0x27DC, 0x4AD7, 0xB4, 0xF1, 0x64, 0x94, 0x53, 0x40, 0xF5, 0x63);
    }
}
