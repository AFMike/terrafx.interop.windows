// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12DebugCommandQueue" /> struct.</summary>
    public static unsafe class ID3D12DebugCommandQueueTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12DebugCommandQueue" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID3D12DebugCommandQueue).GUID, Is.EqualTo(IID_ID3D12DebugCommandQueue));
        }

        /// <summary>Validates that the <see cref="ID3D12DebugCommandQueue" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ID3D12DebugCommandQueue>(), Is.EqualTo(sizeof(ID3D12DebugCommandQueue)));
        }

        /// <summary>Validates that the <see cref="ID3D12DebugCommandQueue" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12DebugCommandQueue).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ID3D12DebugCommandQueue" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ID3D12DebugCommandQueue), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ID3D12DebugCommandQueue), Is.EqualTo(4));
            }
        }
    }
}
