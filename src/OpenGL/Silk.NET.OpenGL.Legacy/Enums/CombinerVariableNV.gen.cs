// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "CombinerVariableNV")]
    public enum CombinerVariableNV : int
    {
        [NativeName("Name", "GL_VARIABLE_A_NV")]
        VariableANV = 0x8523,
        [NativeName("Name", "GL_VARIABLE_B_NV")]
        VariableBNV = 0x8524,
        [NativeName("Name", "GL_VARIABLE_C_NV")]
        VariableCNV = 0x8525,
        [NativeName("Name", "GL_VARIABLE_D_NV")]
        VariableDNV = 0x8526,
        [NativeName("Name", "GL_VARIABLE_E_NV")]
        VariableENV = 0x8527,
        [NativeName("Name", "GL_VARIABLE_F_NV")]
        VariableFNV = 0x8528,
        [NativeName("Name", "GL_VARIABLE_G_NV")]
        VariableGNV = 0x8529,
    }
}
