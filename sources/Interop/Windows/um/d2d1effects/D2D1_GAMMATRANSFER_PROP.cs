// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Gamma Transfer effect's top level properties.</summary>
    public enum D2D1_GAMMATRANSFER_PROP : uint
    {
        /// <summary>Property Name: "RedAmplitude" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE = 0,

        /// <summary>Property Name: "RedExponent" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_RED_EXPONENT = 1,

        /// <summary>Property Name: "RedOffset" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_RED_OFFSET = 2,

        /// <summary>Property Name: "RedDisable" Property Type: BOOL</summary>
        D2D1_GAMMATRANSFER_PROP_RED_DISABLE = 3,

        /// <summary>Property Name: "GreenAmplitude" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE = 4,

        /// <summary>Property Name: "GreenExponent" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT = 5,

        /// <summary>Property Name: "GreenOffset" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET = 6,

        /// <summary>Property Name: "GreenDisable" Property Type: BOOL</summary>
        D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE = 7,

        /// <summary>Property Name: "BlueAmplitude" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE = 8,

        /// <summary>Property Name: "BlueExponent" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT = 9,

        /// <summary>Property Name: "BlueOffset" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET = 10,

        /// <summary>Property Name: "BlueDisable" Property Type: BOOL</summary>
        D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE = 11,

        /// <summary>Property Name: "AlphaAmplitude" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE = 12,

        /// <summary>Property Name: "AlphaExponent" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT = 13,

        /// <summary>Property Name: "AlphaOffset" Property Type: FLOAT</summary>
        D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET = 14,

        /// <summary>Property Name: "AlphaDisable" Property Type: BOOL</summary>
        D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE = 15,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT = 16,

        D2D1_GAMMATRANSFER_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
