// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiVertexArrayObjectOverloads
    {
        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetArrayObject(array, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectBuffer(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectBuffer(buffer, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVariantArrayObject(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVariantArrayObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe uint NewObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NewObjectBuffer(size, in pointer.GetPinnableReference(), usage);
        }

        public static unsafe uint NewObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.NewObjectBuffer(size, in pointer.GetPinnableReference(), usage);
        }

        public static unsafe void UpdateObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateObjectBuffer(buffer, offset, size, in pointer.GetPinnableReference(), preserve);
        }

        public static unsafe void UpdateObjectBuffer<T0>(this AtiVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UpdateObjectBuffer(buffer, offset, size, in pointer.GetPinnableReference(), preserve);
        }

    }
}

