// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID2D1HwndRenderTarget" /> struct.</summary>
    public static class ID2D1HwndRenderTargetTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID2D1HwndRenderTarget" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID2D1HwndRenderTarget).GUID, Is.EqualTo(IID_ID2D1HwndRenderTarget));
        }

        /// <summary>Validates that the layout of the <see cref="ID2D1HwndRenderTarget" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID2D1HwndRenderTarget).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID2D1HwndRenderTarget" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID2D1HwndRenderTarget>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID2D1HwndRenderTarget>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID2D1HwndRenderTarget.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID2D1HwndRenderTarget" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID2D1HwndRenderTarget.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID2D1HwndRenderTarget" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID2D1HwndRenderTarget.Vtbl>(), Is.EqualTo(480));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID2D1HwndRenderTarget.Vtbl>(), Is.EqualTo(240));
                }
            }
        }
    }
}
