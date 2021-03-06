// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SP_CLASSINSTALL_HEADER" /> struct.</summary>
    public static unsafe class SP_CLASSINSTALL_HEADERTests
    {
        /// <summary>Validates that the <see cref="SP_CLASSINSTALL_HEADER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SP_CLASSINSTALL_HEADER>(), Is.EqualTo(sizeof(SP_CLASSINSTALL_HEADER)));
        }

        /// <summary>Validates that the <see cref="SP_CLASSINSTALL_HEADER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SP_CLASSINSTALL_HEADER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SP_CLASSINSTALL_HEADER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SP_CLASSINSTALL_HEADER), Is.EqualTo(8));
        }
    }
}
