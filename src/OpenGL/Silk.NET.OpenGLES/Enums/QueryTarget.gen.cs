// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "QueryTarget")]
    public enum QueryTarget : int
    {
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_OVERFLOW")]
        TransformFeedbackOverflow = 0x82EC,
        [NativeName("Name", "GL_VERTICES_SUBMITTED")]
        VerticesSubmitted = 0x82EE,
        [NativeName("Name", "GL_PRIMITIVES_SUBMITTED")]
        PrimitivesSubmitted = 0x82EF,
        [NativeName("Name", "GL_VERTEX_SHADER_INVOCATIONS")]
        VertexShaderInvocations = 0x82F0,
        [NativeName("Name", "GL_TIME_ELAPSED")]
        TimeElapsed = 0x88BF,
        [NativeName("Name", "GL_SAMPLES_PASSED")]
        SamplesPassed = 0x8914,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED")]
        AnySamplesPassed = 0x8C2F,
        [NativeName("Name", "GL_PRIMITIVES_GENERATED")]
        PrimitivesGenerated = 0x8C87,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
        TransformFeedbackPrimitivesWritten = 0x8C88,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
        AnySamplesPassedConservative = 0x8D6A,
    }
}
