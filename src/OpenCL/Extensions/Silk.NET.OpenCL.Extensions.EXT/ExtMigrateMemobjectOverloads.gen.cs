// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    public static class ExtMigrateMemobjectOverloads
    {
        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, mem_objects, flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, @event);
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, event_wait_list, out @event.GetPinnableReference());
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] nint* @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), @event);
        }

        public static unsafe int EnqueueMigrateMemObject(this ExtMigrateMemobject thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_mem_objects, [Flow(FlowDirection.In)] ReadOnlySpan<nint> mem_objects, [Flow(FlowDirection.In)] EXT flags, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] ReadOnlySpan<nint> event_wait_list, [Flow(FlowDirection.Out)] Span<nint> @event)
        {
            // SpanOverloader
            return thisApi.EnqueueMigrateMemObject(command_queue, num_mem_objects, in mem_objects.GetPinnableReference(), flags, num_events_in_wait_list, in event_wait_list.GetPinnableReference(), out @event.GetPinnableReference());
        }

    }
}

