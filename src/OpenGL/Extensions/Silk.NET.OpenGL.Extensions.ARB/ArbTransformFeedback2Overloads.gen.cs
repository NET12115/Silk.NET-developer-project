// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbTransformFeedback2Overloads
    {
        public static unsafe void DeleteTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void DeleteTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.DeleteTransformFeedbacks(n, in ids.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

        public static unsafe void GenTransformFeedbacks(this ArbTransformFeedback2 thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // SpanOverloader
            thisApi.GenTransformFeedbacks(n, out ids.GetPinnableReference());
        }

    }
}

