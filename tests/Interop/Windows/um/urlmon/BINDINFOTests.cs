// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BINDINFO" /> struct.</summary>
    public static unsafe class BINDINFOTests
    {
        /// <summary>Validates that the <see cref="BINDINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BINDINFO>(), Is.EqualTo(sizeof(BINDINFO)));
        }

        /// <summary>Validates that the <see cref="BINDINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BINDINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BINDINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(BINDINFO), Is.EqualTo(128));
            }
            else
            {
                Assert.That(sizeof(BINDINFO), Is.EqualTo(84));
            }
        }
    }
}