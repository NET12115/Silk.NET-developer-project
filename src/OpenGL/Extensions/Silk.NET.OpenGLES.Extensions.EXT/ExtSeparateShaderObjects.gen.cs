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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_separate_shader_objects")]
    public unsafe partial class ExtSeparateShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_separate_shader_objects";
        [NativeApi(EntryPoint = "glActiveShaderProgramEXT")]
        public partial void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindProgramPipelineEXT")]
        public partial void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glCreateShaderProgramvEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramvEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramvEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramvEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelinesEXT")]
        public unsafe partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelinesEXT")]
        public partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelinesEXT")]
        public unsafe partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelinesEXT")]
        public partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelinesEXT")]
        public unsafe partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelinesEXT")]
        public partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelinesEXT")]
        public unsafe partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelinesEXT")]
        public partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glGetProgramPipelineivEXT")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineivEXT")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineivEXT")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineivEXT")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLogEXT")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glIsProgramPipelineEXT")]
        public partial bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glProgramParameteriEXT")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramParameteriEXT")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramUniform1fEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fvEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform1iEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1ivEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform1uiEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uivEXT")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform2fEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fvEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform2iEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2ivEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform2uiEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uivEXT")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform3fEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fvEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform3iEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3ivEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform3uiEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uivEXT")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform4fEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fvEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform4iEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4ivEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform4uiEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uivEXT")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT")]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT")]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT")]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT")]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT")]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT")]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT")]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT")]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT")]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUseProgramStagesEXT")]
        public partial void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipelineEXT")]
        public partial void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            SilkMarshal.Free((IntPtr) strings);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            SilkMarshal.Free((IntPtr) strings);
            return ret;
        }

        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        public ExtSeparateShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

