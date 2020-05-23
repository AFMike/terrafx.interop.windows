// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID2D1SvgStrokeDashArray" /> struct.</summary>
    public static class ID2D1SvgStrokeDashArrayTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID2D1SvgStrokeDashArray" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID2D1SvgStrokeDashArray).GUID, Is.EqualTo(IID_ID2D1SvgStrokeDashArray));
        }

        /// <summary>Validates that the layout of the <see cref="ID2D1SvgStrokeDashArray" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID2D1SvgStrokeDashArray).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID2D1SvgStrokeDashArray" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID2D1SvgStrokeDashArray>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID2D1SvgStrokeDashArray>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID2D1SvgStrokeDashArray.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID2D1SvgStrokeDashArray" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID2D1SvgStrokeDashArray.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID2D1SvgStrokeDashArray" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID2D1SvgStrokeDashArray.Vtbl>(), Is.EqualTo(96));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID2D1SvgStrokeDashArray.Vtbl>(), Is.EqualTo(48));
                }
            }
        }
    }
}
