/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace Yagl.Graphics
{
    public static partial class Gl
    {
        // Constants.
        // SpecialNumbers. Tokens whose numeric value is intrinsically meaningful
        public const int FALSE = 0; // Boolean,VertexShaderWriteMaskEXT,ClampColorModeARB
        public const int NO_ERROR = 0; // GraphicsResetStatus,ErrorCode
        public const int ZERO = 0; // TextureSwizzle,StencilOp,BlendingFactor
        public const int NONE = 0; // TextureCompareMode,PathColorFormat,CombinerBiasNV,CombinerScaleNV,DrawBufferMode,PixelTexGenMode,ReadBufferMode,ColorBuffer,PathGenMode,PathTransformType,PathFontStyle
        public const int NONE_OES = 0; // ReadBufferMode,DrawBufferMode
        public const int TRUE = 1; // Boolean,VertexShaderWriteMaskEXT,ClampColorModeARB
        public const int ONE = 1; // TextureSwizzle,BlendingFactor
        public const uint INVALID_INDEX = 0xFFFFFFFF;
        public const uint ALL_PIXELS_AMD = 0xFFFFFFFF;
        public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
        public const ulong TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF;
        public const int VERSION_ES_CL_1_0 = 1; // Not an API enum. API definition macro for ES 1.0/1.1 headers
        public const int VERSION_ES_CM_1_1 = 1; // Not an API enum. API definition macro for ES 1.0/1.1 headers
        public const int VERSION_ES_CL_1_1 = 1; // Not an API enum. API definition macro for ES 1.0/1.1 headers
        public const int UUID_SIZE_EXT = 16;
        public const int LUID_SIZE_EXT = 8;

        // AttribMask. 
        public const uint CURRENT_BIT = 0x00000001;
        public const uint POINT_BIT = 0x00000002;
        public const uint LINE_BIT = 0x00000004;
        public const uint POLYGON_BIT = 0x00000008;
        public const uint POLYGON_STIPPLE_BIT = 0x00000010;
        public const uint PIXEL_MODE_BIT = 0x00000020;
        public const uint LIGHTING_BIT = 0x00000040;
        public const uint FOG_BIT = 0x00000080;
        public const uint DEPTH_BUFFER_BIT = 0x00000100; // ClearBufferMask
        public const uint ACCUM_BUFFER_BIT = 0x00000200; // ClearBufferMask
        public const uint STENCIL_BUFFER_BIT = 0x00000400; // ClearBufferMask
        public const uint VIEWPORT_BIT = 0x00000800;
        public const uint TRANSFORM_BIT = 0x00001000;
        public const uint ENABLE_BIT = 0x00002000;
        public const uint COLOR_BUFFER_BIT = 0x00004000; // ClearBufferMask
        public const uint HINT_BIT = 0x00008000;
        public const uint EVAL_BIT = 0x00010000;
        public const uint LIST_BIT = 0x00020000;
        public const uint TEXTURE_BIT = 0x00040000;
        public const uint SCISSOR_BIT = 0x00080000;
        public const uint MULTISAMPLE_BIT = 0x20000000;
        public const uint MULTISAMPLE_BIT_ARB = 0x20000000;
        public const uint MULTISAMPLE_BIT_EXT = 0x20000000;
        public const uint MULTISAMPLE_BIT_3DFX = 0x20000000;
        // Guaranteed to mark all attribute groups at once
        public const uint ALL_ATTRIB_BITS = 0xFFFFFFFF;
        
        // BufferStorageMask. GL_MAP_{COHERENT,PERSISTENT,READ,WRITE}_{BIT,BIT_EXT} also lie in this namespace
        public const ushort DYNAMIC_STORAGE_BIT = 0x0100;
        public const ushort DYNAMIC_STORAGE_BIT_EXT = 0x0100;
        public const ushort CLIENT_STORAGE_BIT = 0x0200;
        public const ushort CLIENT_STORAGE_BIT_EXT = 0x0200;
        public const ushort SPARSE_STORAGE_BIT_ARB = 0x0400;
        public const ushort LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800;
        public const ushort PER_GPU_STORAGE_BIT_NV = 0x0800;
        // Unused 0x1000..0x1000. Reserved for NVIDIA
        public const ushort EXTERNAL_STORAGE_BIT_NVX = 0x2000;
        
        // ClearBufferMask. GL_{DEPTH,ACCUM,STENCIL,COLOR}_BUFFER_BIT also lie in this namespace
        // Collides with AttribMask bit GL_HINT_BIT. OK since this token is for OpenGL ES 2, which doesn't have attribute groups.
        public const uint COVERAGE_BUFFER_BIT_NV = 0x00008000;
        
        // ClientAttribMask. 
        public const uint CLIENT_PIXEL_STORE_BIT = 0x00000001;
        public const uint CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        public const uint CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
        
        // ContextFlagMask. Should be shared with WGL/GLX, but aren't since the FORWARD_COMPATIBLE and DEBUG values are swapped vs. WGL/GLX.
        public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
        public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        public const uint CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002;
        public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;
        public const uint CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
        // Alias of GL_CONTEXT_FLAG_NO_ERROR_BIT
        public const uint CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008;
        public const uint CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010;
        
        // ContextProfileMask. 
        public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
        public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
        
        // MapBufferAccessMask. 
        public const ushort MAP_READ_BIT = 0x0001; // BufferStorageMask
        public const ushort MAP_READ_BIT_EXT = 0x0001; // BufferStorageMask
        public const ushort MAP_WRITE_BIT = 0x0002; // BufferStorageMask
        public const ushort MAP_WRITE_BIT_EXT = 0x0002; // BufferStorageMask
        public const ushort MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const ushort MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
        public const ushort MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const ushort MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
        public const ushort MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const ushort MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
        public const ushort MAP_UNSYNCHRONIZED_BIT = 0x0020;
        public const ushort MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;
        public const ushort MAP_PERSISTENT_BIT = 0x0040; // BufferStorageMask
        public const ushort MAP_PERSISTENT_BIT_EXT = 0x0040; // BufferStorageMask
        public const ushort MAP_COHERENT_BIT = 0x0080; // BufferStorageMask
        public const ushort MAP_COHERENT_BIT_EXT = 0x0080; // BufferStorageMask
        
        // MemoryBarrierMask. 
        public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
        public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
        public const uint ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;
        public const uint UNIFORM_BARRIER_BIT = 0x00000004;
        public const uint UNIFORM_BARRIER_BIT_EXT = 0x00000004;
        public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
        public const uint TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;
        public const uint SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
        public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
        public const uint COMMAND_BARRIER_BIT = 0x00000040;
        public const uint COMMAND_BARRIER_BIT_EXT = 0x00000040;
        public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
        public const uint PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;
        public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
        public const uint TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
        public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
        public const uint BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;
        public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;
        public const uint FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;
        public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        public const uint TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
        public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
        public const uint ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
        public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
        public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;
        public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;
        public const uint ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;
        
        // OcclusionQueryEventMaskAMD. 
        public const uint QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001;
        public const uint QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002;
        public const uint QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004;
        public const uint QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008;
        public const uint QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF;
        
        // SyncObjectMask. 
        public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const uint SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;
        
        // UseProgramStageMask. 
        public const uint VERTEX_SHADER_BIT = 0x00000001;
        public const uint VERTEX_SHADER_BIT_EXT = 0x00000001;
        public const uint FRAGMENT_SHADER_BIT = 0x00000002;
        public const uint FRAGMENT_SHADER_BIT_EXT = 0x00000002;
        public const uint GEOMETRY_SHADER_BIT = 0x00000004;
        public const uint GEOMETRY_SHADER_BIT_EXT = 0x00000004;
        public const uint GEOMETRY_SHADER_BIT_OES = 0x00000004;
        public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const uint TESS_CONTROL_SHADER_BIT_EXT = 0x00000008;
        public const uint TESS_CONTROL_SHADER_BIT_OES = 0x00000008;
        public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;
        public const uint TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010;
        public const uint TESS_EVALUATION_SHADER_BIT_OES = 0x00000010;
        public const uint COMPUTE_SHADER_BIT = 0x00000020;
        public const uint MESH_SHADER_BIT_NV = 0x00000040;
        public const uint TASK_SHADER_BIT_NV = 0x00000080;
        public const uint ALL_SHADER_BITS = 0xFFFFFFFF;
        public const uint ALL_SHADER_BITS_EXT = 0xFFFFFFFF;
        
        // SubgroupSupportedFeatures. 
        public const uint SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001;
        public const uint SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002;
        public const uint SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004;
        public const uint SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008;
        public const uint SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010;
        public const uint SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020;
        public const uint SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040;
        public const uint SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080;
        public const uint SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100;
        
        // TextureStorageMaskAMD. 
        public const uint TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;
        
        // FragmentShaderDestMaskATI. 
        public const uint RED_BIT_ATI = 0x00000001;
        public const uint GREEN_BIT_ATI = 0x00000002;
        public const uint BLUE_BIT_ATI = 0x00000004;
        
        // FragmentShaderDestModMaskATI. 
        public const uint GL_2X_BIT_ATI = 0x00000001;
        public const uint GL_4X_BIT_ATI = 0x00000002;
        public const uint GL_8X_BIT_ATI = 0x00000004;
        public const uint HALF_BIT_ATI = 0x00000008;
        public const uint QUARTER_BIT_ATI = 0x00000010;
        public const uint EIGHTH_BIT_ATI = 0x00000020;
        public const uint SATURATE_BIT_ATI = 0x00000040;
        
        // FragmentShaderColorModMaskATI. 
        public const uint COMP_BIT_ATI = 0x00000002;
        public const uint NEGATE_BIT_ATI = 0x00000004;
        public const uint BIAS_BIT_ATI = 0x00000008;
        
        // TraceMaskMESA. 
        public const ushort TRACE_OPERATIONS_BIT_MESA = 0x0001;
        public const ushort TRACE_PRIMITIVES_BIT_MESA = 0x0002;
        public const ushort TRACE_ARRAYS_BIT_MESA = 0x0004;
        public const ushort TRACE_TEXTURES_BIT_MESA = 0x0008;
        public const ushort TRACE_PIXELS_BIT_MESA = 0x0010;
        public const ushort TRACE_ERRORS_BIT_MESA = 0x0020;
        public const ushort TRACE_ALL_BITS_MESA = 0xFFFF;
        
        // PathRenderingMaskNV. 
        public const byte BOLD_BIT_NV = 0x01; // PathFontStyle
        public const byte ITALIC_BIT_NV = 0x02; // PathFontStyle
        public const byte GLYPH_WIDTH_BIT_NV = 0x01; // PathMetricMask
        public const byte GLYPH_HEIGHT_BIT_NV = 0x02; // PathMetricMask
        public const byte GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04; // PathMetricMask
        public const byte GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08; // PathMetricMask
        public const byte GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10; // PathMetricMask
        public const byte GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20; // PathMetricMask
        public const byte GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40; // PathMetricMask
        public const byte GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80; // PathMetricMask
        public const int GLYPH_HAS_KERNING_BIT_NV = 0x100; // PathMetricMask
        public const uint FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000; // PathMetricMask
        public const uint FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000; // PathMetricMask
        public const uint FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000; // PathMetricMask
        public const uint FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000; // PathMetricMask
        public const uint FONT_UNITS_PER_EM_BIT_NV = 0x00100000; // PathMetricMask
        public const uint FONT_ASCENDER_BIT_NV = 0x00200000; // PathMetricMask
        public const uint FONT_DESCENDER_BIT_NV = 0x00400000; // PathMetricMask
        public const uint FONT_HEIGHT_BIT_NV = 0x00800000; // PathMetricMask
        public const uint FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000; // PathMetricMask
        public const uint FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000; // PathMetricMask
        public const uint FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000; // PathMetricMask
        public const uint FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000; // PathMetricMask
        public const uint FONT_HAS_KERNING_BIT_NV = 0x10000000; // PathMetricMask
        public const uint FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000; // PathMetricMask
        
        // PerformanceQueryCapsMaskINTEL. 
        public const uint PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;
        public const uint PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;
        
        // VertexHintsMaskPGI. 
        public const uint VERTEX23_BIT_PGI = 0x00000004;
        public const uint VERTEX4_BIT_PGI = 0x00000008;
        public const uint COLOR3_BIT_PGI = 0x00010000;
        public const uint COLOR4_BIT_PGI = 0x00020000;
        public const uint EDGEFLAG_BIT_PGI = 0x00040000;
        public const uint INDEX_BIT_PGI = 0x00080000;
        public const uint MAT_AMBIENT_BIT_PGI = 0x00100000;
        public const uint MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;
        public const uint MAT_DIFFUSE_BIT_PGI = 0x00400000;
        public const uint MAT_EMISSION_BIT_PGI = 0x00800000;
        public const uint MAT_COLOR_INDEXES_BIT_PGI = 0x01000000;
        public const uint MAT_SHININESS_BIT_PGI = 0x02000000;
        public const uint MAT_SPECULAR_BIT_PGI = 0x04000000;
        public const uint NORMAL_BIT_PGI = 0x08000000;
        public const uint TEXCOORD1_BIT_PGI = 0x10000000;
        public const uint TEXCOORD2_BIT_PGI = 0x20000000;
        public const uint TEXCOORD3_BIT_PGI = 0x40000000;
        public const uint TEXCOORD4_BIT_PGI = 0x80000000;
        
        // BufferBitQCOM. 
        public const uint COLOR_BUFFER_BIT0_QCOM = 0x00000001;
        public const uint COLOR_BUFFER_BIT1_QCOM = 0x00000002;
        public const uint COLOR_BUFFER_BIT2_QCOM = 0x00000004;
        public const uint COLOR_BUFFER_BIT3_QCOM = 0x00000008;
        public const uint COLOR_BUFFER_BIT4_QCOM = 0x00000010;
        public const uint COLOR_BUFFER_BIT5_QCOM = 0x00000020;
        public const uint COLOR_BUFFER_BIT6_QCOM = 0x00000040;
        public const uint COLOR_BUFFER_BIT7_QCOM = 0x00000080;
        public const uint DEPTH_BUFFER_BIT0_QCOM = 0x00000100;
        public const uint DEPTH_BUFFER_BIT1_QCOM = 0x00000200;
        public const uint DEPTH_BUFFER_BIT2_QCOM = 0x00000400;
        public const uint DEPTH_BUFFER_BIT3_QCOM = 0x00000800;
        public const uint DEPTH_BUFFER_BIT4_QCOM = 0x00001000;
        public const uint DEPTH_BUFFER_BIT5_QCOM = 0x00002000;
        public const uint DEPTH_BUFFER_BIT6_QCOM = 0x00004000;
        public const uint DEPTH_BUFFER_BIT7_QCOM = 0x00008000;
        public const uint STENCIL_BUFFER_BIT0_QCOM = 0x00010000;
        public const uint STENCIL_BUFFER_BIT1_QCOM = 0x00020000;
        public const uint STENCIL_BUFFER_BIT2_QCOM = 0x00040000;
        public const uint STENCIL_BUFFER_BIT3_QCOM = 0x00080000;
        public const uint STENCIL_BUFFER_BIT4_QCOM = 0x00100000;
        public const uint STENCIL_BUFFER_BIT5_QCOM = 0x00200000;
        public const uint STENCIL_BUFFER_BIT6_QCOM = 0x00400000;
        public const uint STENCIL_BUFFER_BIT7_QCOM = 0x00800000;
        public const uint MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000;
        public const uint MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000;
        public const uint MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000;
        public const uint MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000;
        public const uint MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000;
        public const uint MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000;
        public const uint MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000;
        public const uint MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000;
        
        // FoveationConfigBitQCOM. 
        public const uint FOVEATION_ENABLE_BIT_QCOM = 0x00000001;
        public const uint FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;
        public const uint FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM = 0x00000004;
        
        // FfdMaskSGIX. 
        public const uint TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;
        public const uint GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;
        
        // CommandOpcodesNV. For NV_command_list.
        public const ushort TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;
        public const ushort NOP_COMMAND_NV = 0x0001;
        public const ushort DRAW_ELEMENTS_COMMAND_NV = 0x0002;
        public const ushort DRAW_ARRAYS_COMMAND_NV = 0x0003;
        public const ushort DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;
        public const ushort DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;
        public const ushort DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;
        public const ushort DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;
        public const ushort ELEMENT_ADDRESS_COMMAND_NV = 0x0008;
        public const ushort ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;
        public const ushort UNIFORM_ADDRESS_COMMAND_NV = 0x000A;
        public const ushort BLEND_COLOR_COMMAND_NV = 0x000B;
        public const ushort STENCIL_REF_COMMAND_NV = 0x000C;
        public const ushort LINE_WIDTH_COMMAND_NV = 0x000D;
        public const ushort POLYGON_OFFSET_COMMAND_NV = 0x000E;
        public const ushort ALPHA_REF_COMMAND_NV = 0x000F;
        public const ushort VIEWPORT_COMMAND_NV = 0x0010;
        public const ushort SCISSOR_COMMAND_NV = 0x0011;
        public const ushort FRONT_FACE_COMMAND_NV = 0x0012;
        
        // MapTextureFormatINTEL. Texture memory layouts for INTEL_map_texture
        public const int LAYOUT_DEFAULT_INTEL = 0;
        public const int LAYOUT_LINEAR_INTEL = 1;
        public const int LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;
        
        // PathRenderingTokenNV. 
        public const byte CLOSE_PATH_NV = 0x00; // PathCoordType
        public const byte MOVE_TO_NV = 0x02; // PathCoordType
        public const byte RELATIVE_MOVE_TO_NV = 0x03; // PathCoordType
        public const byte LINE_TO_NV = 0x04; // PathCoordType
        public const byte RELATIVE_LINE_TO_NV = 0x05; // PathCoordType
        public const byte HORIZONTAL_LINE_TO_NV = 0x06; // PathCoordType
        public const byte RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07; // PathCoordType
        public const byte VERTICAL_LINE_TO_NV = 0x08; // PathCoordType
        public const byte RELATIVE_VERTICAL_LINE_TO_NV = 0x09; // PathCoordType
        public const byte QUADRATIC_CURVE_TO_NV = 0x0A; // PathCoordType
        public const byte RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B; // PathCoordType
        public const byte CUBIC_CURVE_TO_NV = 0x0C; // PathCoordType
        public const byte RELATIVE_CUBIC_CURVE_TO_NV = 0x0D; // PathCoordType
        public const byte SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E; // PathCoordType
        public const byte RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F; // PathCoordType
        public const byte SMOOTH_CUBIC_CURVE_TO_NV = 0x10; // PathCoordType
        public const byte RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11; // PathCoordType
        public const byte SMALL_CCW_ARC_TO_NV = 0x12; // PathCoordType
        public const byte RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13; // PathCoordType
        public const byte SMALL_CW_ARC_TO_NV = 0x14; // PathCoordType
        public const byte RELATIVE_SMALL_CW_ARC_TO_NV = 0x15; // PathCoordType
        public const byte LARGE_CCW_ARC_TO_NV = 0x16; // PathCoordType
        public const byte RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17; // PathCoordType
        public const byte LARGE_CW_ARC_TO_NV = 0x18; // PathCoordType
        public const byte RELATIVE_LARGE_CW_ARC_TO_NV = 0x19; // PathCoordType
        public const byte CONIC_CURVE_TO_NV = 0x1A; // PathCoordType
        public const byte RELATIVE_CONIC_CURVE_TO_NV = 0x1B; // PathCoordType
        // Unused 0x1C..0xBF. Unused for PathRenderingTokenNV
        public const byte SHARED_EDGE_NV = 0xC0;
        // Unused 0xC1..0xE7. Unused for PathRenderingTokenNV
        public const byte ROUNDED_RECT_NV = 0xE8; // PathCoordType
        public const byte RELATIVE_ROUNDED_RECT_NV = 0xE9; // PathCoordType
        public const byte ROUNDED_RECT2_NV = 0xEA; // PathCoordType
        public const byte RELATIVE_ROUNDED_RECT2_NV = 0xEB; // PathCoordType
        public const byte ROUNDED_RECT4_NV = 0xEC; // PathCoordType
        public const byte RELATIVE_ROUNDED_RECT4_NV = 0xED; // PathCoordType
        public const byte ROUNDED_RECT8_NV = 0xEE; // PathCoordType
        public const byte RELATIVE_ROUNDED_RECT8_NV = 0xEF; // PathCoordType
        public const byte RESTART_PATH_NV = 0xF0; // PathCoordType
        public const byte DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2; // PathCoordType
        public const byte DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4; // PathCoordType
        public const byte RECT_NV = 0xF6; // PathCoordType
        public const byte RELATIVE_RECT_NV = 0xF7; // PathCoordType
        public const byte CIRCULAR_CCW_ARC_TO_NV = 0xF8; // PathCoordType
        public const byte CIRCULAR_CW_ARC_TO_NV = 0xFA; // PathCoordType
        public const byte CIRCULAR_TANGENT_ARC_TO_NV = 0xFC; // PathCoordType
        public const byte ARC_TO_NV = 0xFE; // PathCoordType
        public const byte RELATIVE_ARC_TO_NV = 0xFF; // PathCoordType
        
        // TransformFeedbackTokenNV. For NV_transform_feedback. No clue why small negative values are used
        public const int NEXT_BUFFER_NV = -2;
        public const int SKIP_COMPONENTS4_NV = -3;
        public const int SKIP_COMPONENTS3_NV = -4;
        public const int SKIP_COMPONENTS2_NV = -5;
        public const int SKIP_COMPONENTS1_NV = -6;
        
        // TriangleListSUN. 
        public const ushort RESTART_SUN = 0x0001;
        public const ushort REPLACE_MIDDLE_SUN = 0x0002;
        public const ushort REPLACE_OLDEST_SUN = 0x0003;

        // . Mostly OpenGL 1.0/1.1 enum assignments. Unused ranges should generally remain unused.
        public const ushort POINTS = 0x0000; // PrimitiveType
        public const ushort LINES = 0x0001; // PrimitiveType
        public const ushort LINE_LOOP = 0x0002; // PrimitiveType
        public const ushort LINE_STRIP = 0x0003; // PrimitiveType
        public const ushort TRIANGLES = 0x0004; // PrimitiveType
        public const ushort TRIANGLE_STRIP = 0x0005; // PrimitiveType
        public const ushort TRIANGLE_FAN = 0x0006; // PrimitiveType
        public const ushort QUADS = 0x0007; // PrimitiveType
        public const ushort QUADS_EXT = 0x0007; // PrimitiveType
        public const ushort QUADS_OES = 0x0007;
        public const ushort QUAD_STRIP = 0x0008; // PrimitiveType
        public const ushort POLYGON = 0x0009; // PrimitiveType
        public const ushort LINES_ADJACENCY = 0x000A; // PrimitiveType
        public const ushort LINES_ADJACENCY_ARB = 0x000A; // PrimitiveType
        public const ushort LINES_ADJACENCY_EXT = 0x000A; // PrimitiveType
        public const ushort LINES_ADJACENCY_OES = 0x000A;
        public const ushort LINE_STRIP_ADJACENCY = 0x000B; // PrimitiveType
        public const ushort LINE_STRIP_ADJACENCY_ARB = 0x000B; // PrimitiveType
        public const ushort LINE_STRIP_ADJACENCY_EXT = 0x000B; // PrimitiveType
        public const ushort LINE_STRIP_ADJACENCY_OES = 0x000B;
        public const ushort TRIANGLES_ADJACENCY = 0x000C; // PrimitiveType
        public const ushort TRIANGLES_ADJACENCY_ARB = 0x000C; // PrimitiveType
        public const ushort TRIANGLES_ADJACENCY_EXT = 0x000C; // PrimitiveType
        public const ushort TRIANGLES_ADJACENCY_OES = 0x000C;
        public const ushort TRIANGLE_STRIP_ADJACENCY = 0x000D; // PrimitiveType
        public const ushort TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D; // PrimitiveType
        public const ushort TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D; // PrimitiveType
        public const ushort TRIANGLE_STRIP_ADJACENCY_OES = 0x000D;
        public const ushort PATCHES = 0x000E; // PrimitiveType
        public const ushort PATCHES_EXT = 0x000E; // PrimitiveType
        public const ushort PATCHES_OES = 0x000E;
        // Unused 0x000F..0x00FF. Unused for PrimitiveType
        public const ushort ACCUM = 0x0100; // AccumOp
        public const ushort LOAD = 0x0101; // AccumOp
        public const ushort RETURN = 0x0102; // AccumOp
        public const ushort MULT = 0x0103; // AccumOp
        public const ushort ADD = 0x0104; // TextureEnvMode,AccumOp,LightEnvModeSGIX
        // Unused 0x0105..0x01FF. Unused for AccumOp
        public const ushort NEVER = 0x0200; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort LESS = 0x0201; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort EQUAL = 0x0202; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort LEQUAL = 0x0203; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort GREATER = 0x0204; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort NOTEQUAL = 0x0205; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort GEQUAL = 0x0206; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public const ushort ALWAYS = 0x0207; // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        // Unused 0x0208..0x02FF. Unused for AlphaFunction
        public const ushort SRC_COLOR = 0x0300; // BlendingFactor
        public const ushort ONE_MINUS_SRC_COLOR = 0x0301; // BlendingFactor
        public const ushort SRC_ALPHA = 0x0302; // BlendingFactor
        public const ushort ONE_MINUS_SRC_ALPHA = 0x0303; // BlendingFactor
        public const ushort DST_ALPHA = 0x0304; // BlendingFactor
        public const ushort ONE_MINUS_DST_ALPHA = 0x0305; // BlendingFactor
        public const ushort DST_COLOR = 0x0306; // BlendingFactor
        public const ushort ONE_MINUS_DST_COLOR = 0x0307; // BlendingFactor
        public const ushort SRC_ALPHA_SATURATE = 0x0308; // BlendingFactor
        public const ushort SRC_ALPHA_SATURATE_EXT = 0x0308;
        // Unused 0x0309..0x03FF. Unused for BlendingFactor
        public const ushort FRONT_LEFT = 0x0400; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort FRONT_RIGHT = 0x0401; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort BACK_LEFT = 0x0402; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort BACK_RIGHT = 0x0403; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort FRONT = 0x0404; // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,ReadBufferMode,StencilFaceDirection,MaterialFace
        public const ushort BACK = 0x0405; // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,ReadBufferMode,StencilFaceDirection,MaterialFace
        public const ushort LEFT = 0x0406; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort RIGHT = 0x0407; // ColorBuffer,DrawBufferMode,ReadBufferMode
        public const ushort FRONT_AND_BACK = 0x0408; // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,StencilFaceDirection,MaterialFace
        public const ushort AUX0 = 0x0409; // ReadBufferMode,DrawBufferMode
        public const ushort AUX1 = 0x040A; // ReadBufferMode,DrawBufferMode
        public const ushort AUX2 = 0x040B; // ReadBufferMode,DrawBufferMode
        public const ushort AUX3 = 0x040C; // ReadBufferMode,DrawBufferMode
        // Unused 0x040D..0x04FF. Unused for DrawBufferMode
        public const ushort INVALID_ENUM = 0x0500; // ErrorCode
        public const ushort INVALID_VALUE = 0x0501; // ErrorCode
        public const ushort INVALID_OPERATION = 0x0502; // ErrorCode
        public const ushort STACK_OVERFLOW = 0x0503; // ErrorCode
        public const ushort STACK_OVERFLOW_KHR = 0x0503;
        public const ushort STACK_UNDERFLOW = 0x0504; // ErrorCode
        public const ushort STACK_UNDERFLOW_KHR = 0x0504;
        public const ushort OUT_OF_MEMORY = 0x0505; // ErrorCode
        public const ushort INVALID_FRAMEBUFFER_OPERATION = 0x0506; // ErrorCode
        public const ushort INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506; // ErrorCode
        public const ushort INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506; // ErrorCode
        public const ushort CONTEXT_LOST = 0x0507;
        public const ushort CONTEXT_LOST_KHR = 0x0507;
        // Unused 0x0508..0x05FF. Unused for ErrorCode
        public const ushort GL_2D = 0x0600; // FeedbackType
        public const ushort GL_3D = 0x0601; // FeedbackType
        public const ushort GL_3D_COLOR = 0x0602; // FeedbackType
        public const ushort GL_3D_COLOR_TEXTURE = 0x0603; // FeedbackType
        public const ushort GL_4D_COLOR_TEXTURE = 0x0604; // FeedbackType
        // Unused 0x0605..0x06FF. Unused for FeedbackType
        public const ushort PASS_THROUGH_TOKEN = 0x0700; // FeedBackToken
        public const ushort POINT_TOKEN = 0x0701; // FeedBackToken
        public const ushort LINE_TOKEN = 0x0702; // FeedBackToken
        public const ushort POLYGON_TOKEN = 0x0703; // FeedBackToken
        public const ushort BITMAP_TOKEN = 0x0704; // FeedBackToken
        public const ushort DRAW_PIXEL_TOKEN = 0x0705; // FeedBackToken
        public const ushort COPY_PIXEL_TOKEN = 0x0706; // FeedBackToken
        public const ushort LINE_RESET_TOKEN = 0x0707; // FeedBackToken
        // Unused 0x0708..0x07FF. Unused for FeedbackToken
        public const ushort EXP = 0x0800; // FogMode
        public const ushort EXP2 = 0x0801; // FogMode
        // Unused 0x0802..0x08FF. Unused for FogMode
        public const ushort CW = 0x0900; // FrontFaceDirection
        public const ushort CCW = 0x0901; // FrontFaceDirection
        // Unused 0x0902..0x09FF. Unused for FrontFaceDirection
        public const ushort COEFF = 0x0A00; // MapQuery,GetMapQuery
        public const ushort ORDER = 0x0A01; // MapQuery,GetMapQuery
        public const ushort DOMAIN = 0x0A02; // MapQuery,GetMapQuery
        // Unused 0x0A03..0x0AFF. Unused for GetMapQuery
        public const ushort CURRENT_COLOR = 0x0B00; // GetPName
        public const ushort CURRENT_INDEX = 0x0B01; // GetPName
        public const ushort CURRENT_NORMAL = 0x0B02; // GetPName
        public const ushort CURRENT_TEXTURE_COORDS = 0x0B03; // GetPName,VertexShaderTextureUnitParameter
        public const ushort CURRENT_RASTER_COLOR = 0x0B04; // GetPName
        public const ushort CURRENT_RASTER_INDEX = 0x0B05; // GetPName
        public const ushort CURRENT_RASTER_TEXTURE_COORDS = 0x0B06; // GetPName
        public const ushort CURRENT_RASTER_POSITION = 0x0B07; // GetPName
        public const ushort CURRENT_RASTER_POSITION_VALID = 0x0B08; // GetPName
        public const ushort CURRENT_RASTER_DISTANCE = 0x0B09; // GetPName
        public const ushort POINT_SMOOTH = 0x0B10; // GetPName,EnableCap
        public const ushort POINT_SIZE = 0x0B11; // GetPName
        public const ushort POINT_SIZE_RANGE = 0x0B12; // GetPName
        // Alias of GL_POINT_SIZE_RANGE
        public const ushort SMOOTH_POINT_SIZE_RANGE = 0x0B12; // GetPName
        public const ushort POINT_SIZE_GRANULARITY = 0x0B13; // GetPName
        // Alias of GL_POINT_SIZE_GRANULARITY
        public const ushort SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13; // GetPName
        public const ushort LINE_SMOOTH = 0x0B20; // GetPName,EnableCap
        public const ushort LINE_WIDTH = 0x0B21; // GetPName
        public const ushort LINE_WIDTH_RANGE = 0x0B22; // GetPName
        // Alias of GL_LINE_WIDTH_RANGE
        public const ushort SMOOTH_LINE_WIDTH_RANGE = 0x0B22; // GetPName
        public const ushort LINE_WIDTH_GRANULARITY = 0x0B23; // GetPName
        // Alias of GL_LINE_WIDTH_GRANULARITY
        public const ushort SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23; // GetPName
        public const ushort LINE_STIPPLE = 0x0B24; // GetPName,EnableCap
        public const ushort LINE_STIPPLE_PATTERN = 0x0B25; // GetPName
        public const ushort LINE_STIPPLE_REPEAT = 0x0B26; // GetPName
        public const ushort LIST_MODE = 0x0B30; // GetPName
        public const ushort MAX_LIST_NESTING = 0x0B31; // GetPName
        public const ushort LIST_BASE = 0x0B32; // GetPName
        public const ushort LIST_INDEX = 0x0B33; // GetPName
        public const ushort POLYGON_MODE = 0x0B40; // GetPName
        public const ushort POLYGON_MODE_NV = 0x0B40;
        public const ushort POLYGON_SMOOTH = 0x0B41; // GetPName,EnableCap
        public const ushort POLYGON_STIPPLE = 0x0B42; // GetPName,EnableCap
        public const ushort EDGE_FLAG = 0x0B43; // GetPName
        public const ushort CULL_FACE = 0x0B44; // GetPName,EnableCap
        public const ushort CULL_FACE_MODE = 0x0B45; // GetPName
        public const ushort FRONT_FACE = 0x0B46; // GetPName
        public const ushort LIGHTING = 0x0B50; // GetPName,EnableCap
        public const ushort LIGHT_MODEL_LOCAL_VIEWER = 0x0B51; // LightModelParameter,GetPName
        public const ushort LIGHT_MODEL_TWO_SIDE = 0x0B52; // LightModelParameter,GetPName
        public const ushort LIGHT_MODEL_AMBIENT = 0x0B53; // LightModelParameter,GetPName
        public const ushort SHADE_MODEL = 0x0B54; // GetPName
        public const ushort COLOR_MATERIAL_FACE = 0x0B55; // GetPName
        public const ushort COLOR_MATERIAL_PARAMETER = 0x0B56; // GetPName
        public const ushort COLOR_MATERIAL = 0x0B57; // GetPName,EnableCap
        public const ushort FOG = 0x0B60; // GetPName,EnableCap
        public const ushort FOG_INDEX = 0x0B61; // FogPName,FogParameter,GetPName
        public const ushort FOG_DENSITY = 0x0B62; // FogPName,FogParameter,GetPName
        public const ushort FOG_START = 0x0B63; // FogPName,FogParameter,GetPName
        public const ushort FOG_END = 0x0B64; // FogPName,FogParameter,GetPName
        public const ushort FOG_MODE = 0x0B65; // FogPName,FogParameter,GetPName
        public const ushort FOG_COLOR = 0x0B66; // GetPName,FogParameter
        public const ushort DEPTH_RANGE = 0x0B70; // GetPName
        public const ushort DEPTH_TEST = 0x0B71; // GetPName,EnableCap
        public const ushort DEPTH_WRITEMASK = 0x0B72; // GetPName
        public const ushort DEPTH_CLEAR_VALUE = 0x0B73; // GetPName
        public const ushort DEPTH_FUNC = 0x0B74; // GetPName
        public const ushort ACCUM_CLEAR_VALUE = 0x0B80; // GetPName
        public const ushort STENCIL_TEST = 0x0B90; // GetPName,EnableCap
        public const ushort STENCIL_CLEAR_VALUE = 0x0B91; // GetPName
        public const ushort STENCIL_FUNC = 0x0B92; // GetPName
        public const ushort STENCIL_VALUE_MASK = 0x0B93; // GetPName
        public const ushort STENCIL_FAIL = 0x0B94; // GetPName
        public const ushort STENCIL_PASS_DEPTH_FAIL = 0x0B95; // GetPName
        public const ushort STENCIL_PASS_DEPTH_PASS = 0x0B96; // GetPName
        public const ushort STENCIL_REF = 0x0B97; // GetPName
        public const ushort STENCIL_WRITEMASK = 0x0B98; // GetPName
        public const ushort MATRIX_MODE = 0x0BA0; // GetPName
        public const ushort NORMALIZE = 0x0BA1; // GetPName,EnableCap
        public const ushort VIEWPORT = 0x0BA2; // GetPName
        public const ushort MODELVIEW_STACK_DEPTH = 0x0BA3; // GetPName
        public const ushort MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3; // GetPName
        public const ushort PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3;
        public const ushort PROJECTION_STACK_DEPTH = 0x0BA4; // GetPName
        public const ushort PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4;
        public const ushort TEXTURE_STACK_DEPTH = 0x0BA5; // GetPName
        public const ushort MODELVIEW_MATRIX = 0x0BA6; // GetPName
        public const ushort MODELVIEW0_MATRIX_EXT = 0x0BA6; // GetPName
        public const ushort PATH_MODELVIEW_MATRIX_NV = 0x0BA6;
        public const ushort PROJECTION_MATRIX = 0x0BA7; // GetPName
        public const ushort PATH_PROJECTION_MATRIX_NV = 0x0BA7;
        public const ushort TEXTURE_MATRIX = 0x0BA8; // GetPName,VertexShaderTextureUnitParameter
        public const ushort ATTRIB_STACK_DEPTH = 0x0BB0; // GetPName
        public const ushort CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1; // GetPName
        public const ushort ALPHA_TEST = 0x0BC0; // GetPName,EnableCap
        public const ushort ALPHA_TEST_QCOM = 0x0BC0; // GetPName
        public const ushort ALPHA_TEST_FUNC = 0x0BC1; // GetPName
        public const ushort ALPHA_TEST_FUNC_QCOM = 0x0BC1; // GetPName
        public const ushort ALPHA_TEST_REF = 0x0BC2; // GetPName
        public const ushort ALPHA_TEST_REF_QCOM = 0x0BC2; // GetPName
        public const ushort DITHER = 0x0BD0; // GetPName,EnableCap
        public const ushort BLEND_DST = 0x0BE0; // GetPName
        public const ushort BLEND_SRC = 0x0BE1; // GetPName
        public const ushort BLEND = 0x0BE2; // TextureEnvMode,EnableCap,GetPName
        public const ushort LOGIC_OP_MODE = 0x0BF0; // GetPName
        public const ushort INDEX_LOGIC_OP = 0x0BF1; // GetPName,EnableCap
        public const ushort LOGIC_OP = 0x0BF1; // GetPName
        public const ushort COLOR_LOGIC_OP = 0x0BF2; // GetPName,EnableCap
        public const ushort AUX_BUFFERS = 0x0C00; // GetPName
        public const ushort DRAW_BUFFER = 0x0C01; // GetPName
        public const ushort DRAW_BUFFER_EXT = 0x0C01; // GetPName
        public const ushort READ_BUFFER = 0x0C02; // GetPName
        public const ushort READ_BUFFER_EXT = 0x0C02; // GetPName
        public const ushort READ_BUFFER_NV = 0x0C02; // GetPName
        public const ushort SCISSOR_BOX = 0x0C10; // GetPName
        public const ushort SCISSOR_TEST = 0x0C11; // GetPName,EnableCap
        public const ushort INDEX_CLEAR_VALUE = 0x0C20; // GetPName
        public const ushort INDEX_WRITEMASK = 0x0C21; // GetPName
        public const ushort COLOR_CLEAR_VALUE = 0x0C22; // GetPName
        public const ushort COLOR_WRITEMASK = 0x0C23; // GetPName
        public const ushort INDEX_MODE = 0x0C30; // GetPName
        public const ushort RGBA_MODE = 0x0C31; // GetPName
        public const ushort DOUBLEBUFFER = 0x0C32; // GetFramebufferParameter,GetPName
        public const ushort STEREO = 0x0C33; // GetFramebufferParameter,GetPName
        public const ushort RENDER_MODE = 0x0C40; // GetPName
        public const ushort PERSPECTIVE_CORRECTION_HINT = 0x0C50; // HintTarget,GetPName
        public const ushort POINT_SMOOTH_HINT = 0x0C51; // HintTarget,GetPName
        public const ushort LINE_SMOOTH_HINT = 0x0C52; // HintTarget,GetPName
        public const ushort POLYGON_SMOOTH_HINT = 0x0C53; // HintTarget,GetPName
        public const ushort FOG_HINT = 0x0C54; // HintTarget,GetPName
        public const ushort TEXTURE_GEN_S = 0x0C60; // GetPName,EnableCap
        public const ushort TEXTURE_GEN_T = 0x0C61; // GetPName,EnableCap
        public const ushort TEXTURE_GEN_R = 0x0C62; // GetPName,EnableCap
        public const ushort TEXTURE_GEN_Q = 0x0C63; // GetPName,EnableCap
        public const ushort PIXEL_MAP_I_TO_I = 0x0C70; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_S_TO_S = 0x0C71; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_I_TO_R = 0x0C72; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_I_TO_G = 0x0C73; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_I_TO_B = 0x0C74; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_I_TO_A = 0x0C75; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_R_TO_R = 0x0C76; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_G_TO_G = 0x0C77; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_B_TO_B = 0x0C78; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_A_TO_A = 0x0C79; // PixelMap,GetPixelMap
        public const ushort PIXEL_MAP_I_TO_I_SIZE = 0x0CB0; // GetPName
        public const ushort PIXEL_MAP_S_TO_S_SIZE = 0x0CB1; // GetPName
        public const ushort PIXEL_MAP_I_TO_R_SIZE = 0x0CB2; // GetPName
        public const ushort PIXEL_MAP_I_TO_G_SIZE = 0x0CB3; // GetPName
        public const ushort PIXEL_MAP_I_TO_B_SIZE = 0x0CB4; // GetPName
        public const ushort PIXEL_MAP_I_TO_A_SIZE = 0x0CB5; // GetPName
        public const ushort PIXEL_MAP_R_TO_R_SIZE = 0x0CB6; // GetPName
        public const ushort PIXEL_MAP_G_TO_G_SIZE = 0x0CB7; // GetPName
        public const ushort PIXEL_MAP_B_TO_B_SIZE = 0x0CB8; // GetPName
        public const ushort PIXEL_MAP_A_TO_A_SIZE = 0x0CB9; // GetPName
        public const ushort UNPACK_SWAP_BYTES = 0x0CF0; // PixelStoreParameter,GetPName
        public const ushort UNPACK_LSB_FIRST = 0x0CF1; // PixelStoreParameter,GetPName
        public const ushort UNPACK_ROW_LENGTH = 0x0CF2; // PixelStoreParameter,GetPName
        public const ushort UNPACK_ROW_LENGTH_EXT = 0x0CF2; // PixelStoreParameter
        public const ushort UNPACK_SKIP_ROWS = 0x0CF3; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SKIP_ROWS_EXT = 0x0CF3; // PixelStoreParameter
        public const ushort UNPACK_SKIP_PIXELS = 0x0CF4; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SKIP_PIXELS_EXT = 0x0CF4; // PixelStoreParameter
        public const ushort UNPACK_ALIGNMENT = 0x0CF5; // PixelStoreParameter,GetPName
        public const ushort PACK_SWAP_BYTES = 0x0D00; // PixelStoreParameter,GetPName
        public const ushort PACK_LSB_FIRST = 0x0D01; // PixelStoreParameter,GetPName
        public const ushort PACK_ROW_LENGTH = 0x0D02; // PixelStoreParameter,GetPName
        public const ushort PACK_SKIP_ROWS = 0x0D03; // PixelStoreParameter,GetPName
        public const ushort PACK_SKIP_PIXELS = 0x0D04; // PixelStoreParameter,GetPName
        public const ushort PACK_ALIGNMENT = 0x0D05; // PixelStoreParameter,GetPName
        public const ushort MAP_COLOR = 0x0D10; // PixelTransferParameter,GetPName
        public const ushort MAP_STENCIL = 0x0D11; // PixelTransferParameter,GetPName
        public const ushort INDEX_SHIFT = 0x0D12; // PixelTransferParameter,GetPName
        public const ushort INDEX_OFFSET = 0x0D13; // PixelTransferParameter,IndexMaterialParameterEXT,GetPName
        public const ushort RED_SCALE = 0x0D14; // PixelTransferParameter,GetPName
        public const ushort RED_BIAS = 0x0D15; // PixelTransferParameter,GetPName
        public const ushort ZOOM_X = 0x0D16; // GetPName
        public const ushort ZOOM_Y = 0x0D17; // GetPName
        public const ushort GREEN_SCALE = 0x0D18; // PixelTransferParameter,GetPName
        public const ushort GREEN_BIAS = 0x0D19; // PixelTransferParameter,GetPName
        public const ushort BLUE_SCALE = 0x0D1A; // PixelTransferParameter,GetPName
        public const ushort BLUE_BIAS = 0x0D1B; // PixelTransferParameter,GetPName
        public const ushort ALPHA_SCALE = 0x0D1C; // PixelTransferParameter,GetPName
        public const ushort ALPHA_BIAS = 0x0D1D; // PixelTransferParameter,GetPName
        public const ushort DEPTH_SCALE = 0x0D1E; // PixelTransferParameter,GetPName
        public const ushort DEPTH_BIAS = 0x0D1F; // PixelTransferParameter,GetPName
        public const ushort MAX_EVAL_ORDER = 0x0D30; // GetPName
        public const ushort MAX_LIGHTS = 0x0D31; // GetPName
        public const ushort MAX_CLIP_PLANES = 0x0D32; // GetPName
        public const ushort MAX_CLIP_PLANES_IMG = 0x0D32;
        // Alias of GL_MAX_CLIP_PLANES
        public const ushort MAX_CLIP_DISTANCES = 0x0D32; // GetPName
        // Alias of GL_MAX_CLIP_PLANES
        public const ushort MAX_CLIP_DISTANCES_EXT = 0x0D32;
        public const ushort MAX_CLIP_DISTANCES_APPLE = 0x0D32;
        public const ushort MAX_TEXTURE_SIZE = 0x0D33; // GetPName
        public const ushort MAX_PIXEL_MAP_TABLE = 0x0D34; // GetPName
        public const ushort MAX_ATTRIB_STACK_DEPTH = 0x0D35; // GetPName
        public const ushort MAX_MODELVIEW_STACK_DEPTH = 0x0D36; // GetPName
        public const ushort PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36;
        public const ushort MAX_NAME_STACK_DEPTH = 0x0D37; // GetPName
        public const ushort MAX_PROJECTION_STACK_DEPTH = 0x0D38; // GetPName
        public const ushort PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38;
        public const ushort MAX_TEXTURE_STACK_DEPTH = 0x0D39; // GetPName
        public const ushort MAX_VIEWPORT_DIMS = 0x0D3A; // GetPName
        public const ushort MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B; // GetPName
        public const ushort SUBPIXEL_BITS = 0x0D50; // GetPName
        public const ushort INDEX_BITS = 0x0D51; // GetPName
        public const ushort RED_BITS = 0x0D52; // GetPName
        public const ushort GREEN_BITS = 0x0D53; // GetPName
        public const ushort BLUE_BITS = 0x0D54; // GetPName
        public const ushort ALPHA_BITS = 0x0D55; // GetPName
        public const ushort DEPTH_BITS = 0x0D56; // GetPName
        public const ushort STENCIL_BITS = 0x0D57; // GetPName
        public const ushort ACCUM_RED_BITS = 0x0D58; // GetPName
        public const ushort ACCUM_GREEN_BITS = 0x0D59; // GetPName
        public const ushort ACCUM_BLUE_BITS = 0x0D5A; // GetPName
        public const ushort ACCUM_ALPHA_BITS = 0x0D5B; // GetPName
        public const ushort NAME_STACK_DEPTH = 0x0D70; // GetPName
        public const ushort AUTO_NORMAL = 0x0D80; // GetPName,EnableCap
        public const ushort MAP1_COLOR_4 = 0x0D90; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_INDEX = 0x0D91; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_NORMAL = 0x0D92; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_TEXTURE_COORD_1 = 0x0D93; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_TEXTURE_COORD_2 = 0x0D94; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_TEXTURE_COORD_3 = 0x0D95; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_TEXTURE_COORD_4 = 0x0D96; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_VERTEX_3 = 0x0D97; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_VERTEX_4 = 0x0D98; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_COLOR_4 = 0x0DB0; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_INDEX = 0x0DB1; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_NORMAL = 0x0DB2; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_TEXTURE_COORD_1 = 0x0DB3; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_TEXTURE_COORD_2 = 0x0DB4; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_TEXTURE_COORD_3 = 0x0DB5; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_TEXTURE_COORD_4 = 0x0DB6; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_VERTEX_3 = 0x0DB7; // MapTarget,EnableCap,GetPName
        public const ushort MAP2_VERTEX_4 = 0x0DB8; // MapTarget,EnableCap,GetPName
        public const ushort MAP1_GRID_DOMAIN = 0x0DD0; // GetPName
        public const ushort MAP1_GRID_SEGMENTS = 0x0DD1; // GetPName
        public const ushort MAP2_GRID_DOMAIN = 0x0DD2; // GetPName
        public const ushort MAP2_GRID_SEGMENTS = 0x0DD3; // GetPName
        public const ushort TEXTURE_1D = 0x0DE0; // CopyImageSubDataTarget,EnableCap,GetPName,TextureTarget
        public const ushort TEXTURE_2D = 0x0DE1; // CopyImageSubDataTarget,EnableCap,GetPName,TextureTarget
        public const ushort FEEDBACK_BUFFER_POINTER = 0x0DF0; // GetPointervPName
        public const ushort FEEDBACK_BUFFER_SIZE = 0x0DF1; // GetPName
        public const ushort FEEDBACK_BUFFER_TYPE = 0x0DF2; // GetPName
        public const ushort SELECTION_BUFFER_POINTER = 0x0DF3; // GetPointervPName
        public const ushort SELECTION_BUFFER_SIZE = 0x0DF4; // GetPName
        // Unused 0x0DF5..0xFFFF. Unused for GetPName
        public const ushort TEXTURE_WIDTH = 0x1000; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_HEIGHT = 0x1001; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_INTERNAL_FORMAT = 0x1003; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_COMPONENTS = 0x1003; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_BORDER_COLOR = 0x1004; // SamplerParameterF,GetTextureParameter,TextureParameterName
        public const ushort TEXTURE_BORDER_COLOR_EXT = 0x1004;
        public const ushort TEXTURE_BORDER_COLOR_NV = 0x1004; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_BORDER_COLOR_OES = 0x1004;
        public const ushort TEXTURE_BORDER = 0x1005; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_TARGET = 0x1006;
        // Unused 0x1007..0x10FF. Unused for GetTextureParameter
        public const ushort DONT_CARE = 0x1100; // DebugSeverity,HintMode,DebugSource,DebugType
        public const ushort FASTEST = 0x1101; // HintMode
        public const ushort NICEST = 0x1102; // HintMode
        // Unused 0x1103..0x11FF. Unused for HintMode
        public const ushort AMBIENT = 0x1200; // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
        public const ushort DIFFUSE = 0x1201; // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
        public const ushort SPECULAR = 0x1202; // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
        public const ushort POSITION = 0x1203; // LightParameter,FragmentLightParameterSGIX
        public const ushort SPOT_DIRECTION = 0x1204; // LightParameter,FragmentLightParameterSGIX
        public const ushort SPOT_EXPONENT = 0x1205; // LightParameter,FragmentLightParameterSGIX
        public const ushort SPOT_CUTOFF = 0x1206; // LightParameter,FragmentLightParameterSGIX
        public const ushort CONSTANT_ATTENUATION = 0x1207; // LightParameter,FragmentLightParameterSGIX
        public const ushort LINEAR_ATTENUATION = 0x1208; // LightParameter,FragmentLightParameterSGIX
        public const ushort QUADRATIC_ATTENUATION = 0x1209; // LightParameter,FragmentLightParameterSGIX
        // Unused 0x1210..0x12FF. Unused for LightParameter
        public const ushort COMPILE = 0x1300; // ListMode
        public const ushort COMPILE_AND_EXECUTE = 0x1301; // ListMode
        // Unused 0x1302..0x13FF. Unused for ListMode
        public const ushort BYTE = 0x1400; // VertexAttribIType,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,ColorPointerType,ListNameType,NormalPointerType,PixelType,VertexAttribType,VertexAttribPointerType
        public const ushort UNSIGNED_BYTE = 0x1401; // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelType,VertexAttribType,VertexAttribPointerType
        public const ushort SHORT = 0x1402; // VertexAttribIType,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,VertexAttribPointerType
        public const ushort UNSIGNED_SHORT = 0x1403; // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelFormat,PixelType,VertexAttribType,VertexAttribPointerType
        public const ushort INT = 0x1404; // VertexAttribIType,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
        public const ushort UNSIGNED_INT = 0x1405; // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelFormat,PixelType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
        public const ushort FLOAT = 0x1406; // GlslTypeToken,MapTypeNV,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,VertexWeightPointerTypeEXT,TangentPointerTypeEXT,BinormalPointerTypeEXT,FogCoordinatePointerType,FogPointerTypeEXT,FogPointerTypeIBM,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType
        public const ushort GL_2_BYTES = 0x1407; // ListNameType
        public const ushort GL_2_BYTES_NV = 0x1407;
        public const ushort GL_3_BYTES = 0x1408; // ListNameType
        public const ushort GL_3_BYTES_NV = 0x1408;
        public const ushort GL_4_BYTES = 0x1409; // ListNameType
        public const ushort GL_4_BYTES_NV = 0x1409;
        public const ushort DOUBLE = 0x140A; // VertexAttribLType,MapTypeNV,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,FogCoordinatePointerType,FogPointerTypeEXT,FogPointerTypeIBM,IndexPointerType,NormalPointerType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
        public const ushort DOUBLE_EXT = 0x140A; // BinormalPointerTypeEXT,TangentPointerTypeEXT
        public const ushort HALF_FLOAT = 0x140B; // VertexAttribPointerType,VertexAttribType
        public const ushort HALF_FLOAT_ARB = 0x140B;
        public const ushort HALF_FLOAT_NV = 0x140B;
        public const ushort HALF_APPLE = 0x140B;
        public const ushort FIXED = 0x140C; // VertexAttribPointerType,VertexAttribType
        public const ushort FIXED_OES = 0x140C;
        // Unused 0x140D. Leave gap to preserve even/odd int/uint token values
        public const ushort INT64_ARB = 0x140E; // VertexAttribPointerType,AttributeType
        public const ushort INT64_NV = 0x140E; // VertexAttribPointerType,AttributeType
        public const ushort UNSIGNED_INT64_ARB = 0x140F; // VertexAttribPointerType,AttributeType
        public const ushort UNSIGNED_INT64_NV = 0x140F; // VertexAttribPointerType,AttributeType
        // Unused 0x1410..0x14FF. Unused for DataType
        public const ushort CLEAR = 0x1500; // LogicOp
        public const ushort AND = 0x1501; // LogicOp
        public const ushort AND_REVERSE = 0x1502; // LogicOp
        public const ushort COPY = 0x1503; // LogicOp
        public const ushort AND_INVERTED = 0x1504; // LogicOp
        public const ushort NOOP = 0x1505; // LogicOp
        public const ushort XOR = 0x1506; // LogicOp
        public const ushort XOR_NV = 0x1506;
        public const ushort OR = 0x1507; // LogicOp
        public const ushort NOR = 0x1508; // LogicOp
        public const ushort EQUIV = 0x1509; // LogicOp
        public const ushort INVERT = 0x150A; // PathFillMode,LogicOp,StencilOp
        public const ushort OR_REVERSE = 0x150B; // LogicOp
        public const ushort COPY_INVERTED = 0x150C; // LogicOp
        public const ushort OR_INVERTED = 0x150D; // LogicOp
        public const ushort NAND = 0x150E; // LogicOp
        public const ushort SET = 0x150F; // LogicOp
        // Unused 0x1510..0x15FF. Unused for LogicOp
        public const ushort EMISSION = 0x1600; // MaterialParameter,ColorMaterialParameter
        public const ushort SHININESS = 0x1601; // MaterialParameter
        public const ushort AMBIENT_AND_DIFFUSE = 0x1602; // MaterialParameter,ColorMaterialParameter
        public const ushort COLOR_INDEXES = 0x1603; // MaterialParameter
        // Unused 0x1604..0x16FF. Unused for MaterialParameter
        public const ushort MODELVIEW = 0x1700; // MatrixMode
        public const ushort MODELVIEW0_ARB = 0x1700;
        public const ushort MODELVIEW0_EXT = 0x1700; // MatrixMode
        public const ushort PATH_MODELVIEW_NV = 0x1700;
        public const ushort PROJECTION = 0x1701; // MatrixMode
        public const ushort PATH_PROJECTION_NV = 0x1701;
        public const ushort TEXTURE = 0x1702; // ObjectIdentifier,MatrixMode
        // Unused 0x1703..0x17FF. Unused for MatrixMode
        public const ushort COLOR = 0x1800; // Buffer,PixelCopyType,InvalidateFramebufferAttachment
        public const ushort COLOR_EXT = 0x1800; // PixelCopyType
        public const ushort DEPTH = 0x1801; // Buffer,PixelCopyType,InvalidateFramebufferAttachment
        public const ushort DEPTH_EXT = 0x1801; // PixelCopyType
        public const ushort STENCIL = 0x1802; // Buffer,PixelCopyType,InvalidateFramebufferAttachment
        public const ushort STENCIL_EXT = 0x1802; // PixelCopyType
        // Unused 0x1803..0x18FF. Unused for PixelCopyType
        public const ushort COLOR_INDEX = 0x1900; // PixelFormat
        public const ushort STENCIL_INDEX = 0x1901; // InternalFormat,PixelFormat
        public const ushort STENCIL_INDEX_OES = 0x1901; // InternalFormat
        public const ushort DEPTH_COMPONENT = 0x1902; // InternalFormat,PixelFormat
        public const ushort RED = 0x1903; // TextureSwizzle,PixelFormat,InternalFormat
        public const ushort RED_EXT = 0x1903; // InternalFormat,PixelFormat
        public const ushort RED_NV = 0x1903;
        public const ushort GREEN = 0x1904; // TextureSwizzle,PixelFormat
        public const ushort GREEN_NV = 0x1904;
        public const ushort BLUE = 0x1905; // TextureSwizzle,CombinerComponentUsageNV,PixelFormat
        public const ushort BLUE_NV = 0x1905;
        public const ushort ALPHA = 0x1906; // TextureSwizzle,CombinerPortionNV,PathColorFormat,CombinerComponentUsageNV,PixelFormat
        public const ushort RGB = 0x1907; // PixelTexGenMode,CombinerPortionNV,PathColorFormat,CombinerComponentUsageNV,PixelFormat,InternalFormat
        public const ushort RGBA = 0x1908; // PixelTexGenMode,PathColorFormat,PixelFormat,InternalFormat
        public const ushort LUMINANCE = 0x1909; // PixelTexGenMode,PathColorFormat,PixelFormat
        public const ushort LUMINANCE_ALPHA = 0x190A; // PixelTexGenMode,PathColorFormat,PixelFormat
        // Unused 0x1910..0x19FF. Unused for PixelFormat
        public const ushort BITMAP = 0x1A00; // PixelType
        // Unused 0x1A01..0x1AFF. Unused for PixelType
        public const ushort POINT = 0x1B00; // PolygonMode,MeshMode1,MeshMode2
        public const ushort POINT_NV = 0x1B00;
        public const ushort LINE = 0x1B01; // PolygonMode,MeshMode1,MeshMode2
        public const ushort LINE_NV = 0x1B01;
        public const ushort FILL = 0x1B02; // PolygonMode,MeshMode2
        public const ushort FILL_NV = 0x1B02; // EvalMapsModeNV
        // Unused 0x1B03..0x1BFF. Unused for PolygonMode
        public const ushort RENDER = 0x1C00; // RenderingMode
        public const ushort FEEDBACK = 0x1C01; // RenderingMode
        public const ushort SELECT = 0x1C02; // RenderingMode
        // Unused 0x1C03..0x1CFF. Unused for RenderingMode
        public const ushort FLAT = 0x1D00; // ShadingModel
        public const ushort SMOOTH = 0x1D01; // ShadingModel
        // Unused 0x1D02..0x1DFF. Unused for ShadingModel
        public const ushort KEEP = 0x1E00; // StencilOp
        public const ushort REPLACE = 0x1E01; // StencilOp,LightEnvModeSGIX
        public const ushort INCR = 0x1E02; // StencilOp
        public const ushort DECR = 0x1E03; // StencilOp
        // Unused 0x1E04..0x1EFF. Unused for StencilOp
        public const ushort VENDOR = 0x1F00; // StringName
        public const ushort RENDERER = 0x1F01; // StringName
        public const ushort VERSION = 0x1F02; // StringName
        public const ushort EXTENSIONS = 0x1F03; // StringName
        // Unused 0x1F04..0x1FFF. Unused for StringName
        public const ushort S = 0x2000; // TextureCoordName
        public const ushort T = 0x2001; // TextureCoordName
        public const ushort R = 0x2002; // TextureCoordName
        public const ushort Q = 0x2003; // TextureCoordName
        // Unused 0x2004..0x20FF. Unused for TextureCoordName
        public const ushort MODULATE = 0x2100; // TextureEnvMode,LightEnvModeSGIX
        public const ushort DECAL = 0x2101; // TextureEnvMode
        // Unused 0x2102..0x21FF. Unused for TextureEnvMode
        public const ushort TEXTURE_ENV_MODE = 0x2200; // TextureEnvParameter
        public const ushort TEXTURE_ENV_COLOR = 0x2201; // TextureEnvParameter
        // Unused 0x2202..0x22FF. Unused for TextureEnvParameter
        public const ushort TEXTURE_ENV = 0x2300; // TextureEnvTarget
        // Unused 0x2301..0x23FF. Unused for TextureEnvTarget
        public const ushort EYE_LINEAR = 0x2400; // PathGenMode,TextureGenMode
        public const ushort EYE_LINEAR_NV = 0x2400;
        public const ushort OBJECT_LINEAR = 0x2401; // PathGenMode,TextureGenMode
        public const ushort OBJECT_LINEAR_NV = 0x2401;
        public const ushort SPHERE_MAP = 0x2402; // TextureGenMode
        // Unused 0x2403..0x24FF. Unused for TextureGenMode
        public const ushort TEXTURE_GEN_MODE = 0x2500; // TextureGenParameter
        public const ushort TEXTURE_GEN_MODE_OES = 0x2500;
        public const ushort OBJECT_PLANE = 0x2501; // TextureGenParameter
        public const ushort EYE_PLANE = 0x2502; // TextureGenParameter
        // Unused 0x2503..0x25FF. Unused for TextureGenParameter
        public const ushort NEAREST = 0x2600; // BlitFramebufferFilter,TextureMagFilter,TextureMinFilter
        public const ushort LINEAR = 0x2601; // BlitFramebufferFilter,FogMode,TextureMagFilter,TextureMinFilter
        // Unused 0x2602..0x26FF. Unused for TextureMagFilter
        public const ushort NEAREST_MIPMAP_NEAREST = 0x2700; // TextureMinFilter
        public const ushort LINEAR_MIPMAP_NEAREST = 0x2701; // TextureMinFilter
        public const ushort NEAREST_MIPMAP_LINEAR = 0x2702; // TextureMinFilter
        public const ushort LINEAR_MIPMAP_LINEAR = 0x2703; // TextureWrapMode,TextureMinFilter
        // Unused 0x2704..0x27FF. Unused for TextureMinFilter
        public const ushort TEXTURE_MAG_FILTER = 0x2800; // SamplerParameterI,GetTextureParameter,TextureParameterName
        public const ushort TEXTURE_MIN_FILTER = 0x2801; // SamplerParameterI,GetTextureParameter,TextureParameterName
        public const ushort TEXTURE_WRAP_S = 0x2802; // SamplerParameterI,GetTextureParameter,TextureParameterName
        public const ushort TEXTURE_WRAP_T = 0x2803; // SamplerParameterI,GetTextureParameter,TextureParameterName
        // Unused 0x2804..0x28FF. Unused for TextureParameterName
        public const ushort CLAMP = 0x2900; // TextureWrapMode
        public const ushort REPEAT = 0x2901; // TextureWrapMode
        // Unused 0x2902..0x29FF. Unused for TextureWrapMode
        public const ushort POLYGON_OFFSET_UNITS = 0x2A00; // GetPName
        public const ushort POLYGON_OFFSET_POINT = 0x2A01; // GetPName,EnableCap
        public const ushort POLYGON_OFFSET_POINT_NV = 0x2A01;
        public const ushort POLYGON_OFFSET_LINE = 0x2A02; // GetPName,EnableCap
        public const ushort POLYGON_OFFSET_LINE_NV = 0x2A02;
        // Unused 0x2A03..0x2A09. Unused for PolygonOffset
        public const ushort R3_G3_B2 = 0x2A10; // InternalFormat
        // Unused 0x2A11..0x2A1F. Unused for InternalFormat
        public const ushort V2F = 0x2A20; // InterleavedArrayFormat
        public const ushort V3F = 0x2A21; // InterleavedArrayFormat
        public const ushort C4UB_V2F = 0x2A22; // InterleavedArrayFormat
        public const ushort C4UB_V3F = 0x2A23; // InterleavedArrayFormat
        public const ushort C3F_V3F = 0x2A24; // InterleavedArrayFormat
        public const ushort N3F_V3F = 0x2A25; // InterleavedArrayFormat
        public const ushort C4F_N3F_V3F = 0x2A26; // InterleavedArrayFormat
        public const ushort T2F_V3F = 0x2A27; // InterleavedArrayFormat
        public const ushort T4F_V4F = 0x2A28; // InterleavedArrayFormat
        public const ushort T2F_C4UB_V3F = 0x2A29; // InterleavedArrayFormat
        public const ushort T2F_C3F_V3F = 0x2A2A; // InterleavedArrayFormat
        public const ushort T2F_N3F_V3F = 0x2A2B; // InterleavedArrayFormat
        public const ushort T2F_C4F_N3F_V3F = 0x2A2C; // InterleavedArrayFormat
        public const ushort T4F_C4F_N3F_V4F = 0x2A2D; // InterleavedArrayFormat
        // Unused 0x2A2E..0x2FFF. Unused for InterleavedArrayFormat
        public const ushort CLIP_PLANE0 = 0x3000; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE0_IMG = 0x3000;
        // Alias of GL_CLIP_PLANE0
        public const ushort CLIP_DISTANCE0 = 0x3000; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE0
        public const ushort CLIP_DISTANCE0_EXT = 0x3000;
        public const ushort CLIP_DISTANCE0_APPLE = 0x3000;
        public const ushort CLIP_PLANE1 = 0x3001; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE1_IMG = 0x3001;
        // Alias of GL_CLIP_PLANE1
        public const ushort CLIP_DISTANCE1 = 0x3001; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE1
        public const ushort CLIP_DISTANCE1_EXT = 0x3001;
        public const ushort CLIP_DISTANCE1_APPLE = 0x3001;
        public const ushort CLIP_PLANE2 = 0x3002; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE2_IMG = 0x3002;
        // Alias of GL_CLIP_PLANE2
        public const ushort CLIP_DISTANCE2 = 0x3002; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE2
        public const ushort CLIP_DISTANCE2_EXT = 0x3002;
        public const ushort CLIP_DISTANCE2_APPLE = 0x3002;
        public const ushort CLIP_PLANE3 = 0x3003; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE3_IMG = 0x3003;
        // Alias of GL_CLIP_PLANE3
        public const ushort CLIP_DISTANCE3 = 0x3003; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE3
        public const ushort CLIP_DISTANCE3_EXT = 0x3003;
        public const ushort CLIP_DISTANCE3_APPLE = 0x3003;
        public const ushort CLIP_PLANE4 = 0x3004; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE4_IMG = 0x3004;
        // Alias of GL_CLIP_PLANE4
        public const ushort CLIP_DISTANCE4 = 0x3004; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE4
        public const ushort CLIP_DISTANCE4_EXT = 0x3004;
        public const ushort CLIP_DISTANCE4_APPLE = 0x3004;
        public const ushort CLIP_PLANE5 = 0x3005; // GetPName,ClipPlaneName,EnableCap
        public const ushort CLIP_PLANE5_IMG = 0x3005;
        // Alias of GL_CLIP_PLANE5
        public const ushort CLIP_DISTANCE5 = 0x3005; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_PLANE5
        public const ushort CLIP_DISTANCE5_EXT = 0x3005;
        public const ushort CLIP_DISTANCE5_APPLE = 0x3005;
        public const ushort CLIP_DISTANCE6 = 0x3006; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_DISTANCE6
        public const ushort CLIP_DISTANCE6_EXT = 0x3006;
        public const ushort CLIP_DISTANCE6_APPLE = 0x3006;
        public const ushort CLIP_DISTANCE7 = 0x3007; // EnableCap,ClipPlaneName
        // Alias of GL_CLIP_DISTANCE7
        public const ushort CLIP_DISTANCE7_EXT = 0x3007;
        public const ushort CLIP_DISTANCE7_APPLE = 0x3007;
        // Unused 0x3008..0x3FFF. Unused for ClipPlaneName
        public const ushort LIGHT0 = 0x4000; // LightName,EnableCap,GetPName
        public const ushort LIGHT1 = 0x4001; // LightName,EnableCap,GetPName
        public const ushort LIGHT2 = 0x4002; // LightName,EnableCap,GetPName
        public const ushort LIGHT3 = 0x4003; // LightName,EnableCap,GetPName
        public const ushort LIGHT4 = 0x4004; // LightName,EnableCap,GetPName
        public const ushort LIGHT5 = 0x4005; // LightName,EnableCap,GetPName
        public const ushort LIGHT6 = 0x4006; // LightName,EnableCap,GetPName
        public const ushort LIGHT7 = 0x4007; // LightName,EnableCap,GetPName
        // Unused 0x4008..0x4FFF. Unused for LightName
        // Unused 0x5000..0x5FFF. Unused. Do not use.
        // Unused 0x6000..0x6FFF. Experimental (internal/test only) range. DO NOT SHIP VALUES IN THIS RANGE.
        // Unused 0x7000..0x7FFF. Unused. Do not use.
        
        // . The primary GL enumerant space begins here. All modern enum allocations are in this range. These enums are mostly assigned the default class since it's a great deal of not very useful work to be more specific
        public const ushort ABGR_EXT = 0x8000; // PixelFormat
        public const ushort CONSTANT_COLOR = 0x8001; // BlendingFactor
        public const ushort CONSTANT_COLOR_EXT = 0x8001;
        public const ushort ONE_MINUS_CONSTANT_COLOR = 0x8002; // BlendingFactor
        public const ushort ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
        public const ushort CONSTANT_ALPHA = 0x8003; // BlendingFactor
        public const ushort CONSTANT_ALPHA_EXT = 0x8003;
        public const ushort ONE_MINUS_CONSTANT_ALPHA = 0x8004; // BlendingFactor
        public const ushort ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
        public const ushort BLEND_COLOR = 0x8005; // GetPName
        public const ushort BLEND_COLOR_EXT = 0x8005; // GetPName
        public const ushort FUNC_ADD = 0x8006; // BlendEquationModeEXT
        public const ushort FUNC_ADD_EXT = 0x8006; // BlendEquationModeEXT
        public const ushort FUNC_ADD_OES = 0x8006;
        public const ushort MIN = 0x8007; // BlendEquationModeEXT
        public const ushort MIN_EXT = 0x8007; // BlendEquationModeEXT
        public const ushort MAX = 0x8008; // BlendEquationModeEXT
        public const ushort MAX_EXT = 0x8008; // BlendEquationModeEXT
        public const ushort BLEND_EQUATION = 0x8009;
        public const ushort BLEND_EQUATION_EXT = 0x8009; // GetPName
        public const ushort BLEND_EQUATION_OES = 0x8009;
        public const ushort BLEND_EQUATION_RGB = 0x8009; // GetPName
        public const ushort BLEND_EQUATION_RGB_EXT = 0x8009;
        public const ushort BLEND_EQUATION_RGB_OES = 0x8009;
        public const ushort FUNC_SUBTRACT = 0x800A; // BlendEquationModeEXT
        public const ushort FUNC_SUBTRACT_EXT = 0x800A; // BlendEquationModeEXT
        public const ushort FUNC_SUBTRACT_OES = 0x800A;
        public const ushort FUNC_REVERSE_SUBTRACT = 0x800B; // BlendEquationModeEXT
        public const ushort FUNC_REVERSE_SUBTRACT_EXT = 0x800B; // BlendEquationModeEXT
        public const ushort FUNC_REVERSE_SUBTRACT_OES = 0x800B;
        public const ushort CMYK_EXT = 0x800C; // PixelFormat
        public const ushort CMYKA_EXT = 0x800D; // PixelFormat
        public const ushort PACK_CMYK_HINT_EXT = 0x800E; // HintTarget,GetPName
        public const ushort UNPACK_CMYK_HINT_EXT = 0x800F; // HintTarget,GetPName
        public const ushort CONVOLUTION_1D = 0x8010; // ConvolutionTarget,ConvolutionTargetEXT
        public const ushort CONVOLUTION_1D_EXT = 0x8010; // GetPName,ConvolutionTargetEXT,EnableCap
        public const ushort CONVOLUTION_2D = 0x8011; // ConvolutionTarget,ConvolutionTargetEXT
        public const ushort CONVOLUTION_2D_EXT = 0x8011; // GetPName,ConvolutionTargetEXT,EnableCap
        public const ushort SEPARABLE_2D = 0x8012; // SeparableTargetEXT
        public const ushort SEPARABLE_2D_EXT = 0x8012; // SeparableTargetEXT,EnableCap,GetPName
        public const ushort CONVOLUTION_BORDER_MODE = 0x8013; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort CONVOLUTION_BORDER_MODE_EXT = 0x8013; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort CONVOLUTION_FILTER_SCALE = 0x8014; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort CONVOLUTION_FILTER_SCALE_EXT = 0x8014; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort CONVOLUTION_FILTER_BIAS = 0x8015; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort CONVOLUTION_FILTER_BIAS_EXT = 0x8015; // GetConvolutionParameter,ConvolutionParameterEXT
        public const ushort REDUCE = 0x8016; // ConvolutionBorderModeEXT
        public const ushort REDUCE_EXT = 0x8016; // ConvolutionBorderModeEXT
        public const ushort CONVOLUTION_FORMAT = 0x8017; // GetConvolutionParameter
        public const ushort CONVOLUTION_FORMAT_EXT = 0x8017; // GetConvolutionParameter
        public const ushort CONVOLUTION_WIDTH = 0x8018; // GetConvolutionParameter
        public const ushort CONVOLUTION_WIDTH_EXT = 0x8018; // GetConvolutionParameter
        public const ushort CONVOLUTION_HEIGHT = 0x8019; // GetConvolutionParameter
        public const ushort CONVOLUTION_HEIGHT_EXT = 0x8019; // GetConvolutionParameter
        public const ushort MAX_CONVOLUTION_WIDTH = 0x801A; // GetConvolutionParameter
        public const ushort MAX_CONVOLUTION_WIDTH_EXT = 0x801A; // GetConvolutionParameter
        public const ushort MAX_CONVOLUTION_HEIGHT = 0x801B; // GetConvolutionParameter
        public const ushort MAX_CONVOLUTION_HEIGHT_EXT = 0x801B; // GetConvolutionParameter
        public const ushort POST_CONVOLUTION_RED_SCALE = 0x801C; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_RED_SCALE_EXT = 0x801C; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_GREEN_SCALE = 0x801D; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_BLUE_SCALE = 0x801E; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_ALPHA_SCALE = 0x801F; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_RED_BIAS = 0x8020; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_RED_BIAS_EXT = 0x8020; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_GREEN_BIAS = 0x8021; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_BLUE_BIAS = 0x8022; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022; // PixelTransferParameter,GetPName
        public const ushort POST_CONVOLUTION_ALPHA_BIAS = 0x8023; // PixelTransferParameter
        public const ushort POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023; // PixelTransferParameter,GetPName
        public const ushort HISTOGRAM = 0x8024; // HistogramTargetEXT
        public const ushort HISTOGRAM_EXT = 0x8024; // HistogramTargetEXT,EnableCap,GetPName
        public const ushort PROXY_HISTOGRAM = 0x8025; // HistogramTargetEXT
        public const ushort PROXY_HISTOGRAM_EXT = 0x8025; // HistogramTargetEXT
        public const ushort HISTOGRAM_WIDTH = 0x8026; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_WIDTH_EXT = 0x8026; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_FORMAT = 0x8027; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_FORMAT_EXT = 0x8027; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_RED_SIZE = 0x8028; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_RED_SIZE_EXT = 0x8028; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_GREEN_SIZE = 0x8029; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_GREEN_SIZE_EXT = 0x8029; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_BLUE_SIZE = 0x802A; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_BLUE_SIZE_EXT = 0x802A; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_ALPHA_SIZE = 0x802B; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_ALPHA_SIZE_EXT = 0x802B; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_LUMINANCE_SIZE = 0x802C; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_SINK = 0x802D; // GetHistogramParameterPNameEXT
        public const ushort HISTOGRAM_SINK_EXT = 0x802D; // GetHistogramParameterPNameEXT
        public const ushort MINMAX = 0x802E; // MinmaxTargetEXT
        public const ushort MINMAX_EXT = 0x802E; // MinmaxTargetEXT,EnableCap,GetPName
        public const ushort MINMAX_FORMAT = 0x802F; // GetMinmaxParameterPNameEXT
        public const ushort MINMAX_FORMAT_EXT = 0x802F; // GetMinmaxParameterPNameEXT
        public const ushort MINMAX_SINK = 0x8030; // GetMinmaxParameterPNameEXT
        public const ushort MINMAX_SINK_EXT = 0x8030; // GetMinmaxParameterPNameEXT
        public const ushort TABLE_TOO_LARGE_EXT = 0x8031; // ErrorCode
        public const ushort TABLE_TOO_LARGE = 0x8031; // ErrorCode
        public const ushort UNSIGNED_BYTE_3_3_2 = 0x8032; // PixelType
        public const ushort UNSIGNED_BYTE_3_3_2_EXT = 0x8032; // PixelType
        public const ushort UNSIGNED_SHORT_4_4_4_4 = 0x8033; // PixelType
        public const ushort UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033; // PixelType
        public const ushort UNSIGNED_SHORT_5_5_5_1 = 0x8034; // PixelType
        public const ushort UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034; // PixelType
        public const ushort UNSIGNED_INT_8_8_8_8 = 0x8035; // PixelType
        public const ushort UNSIGNED_INT_8_8_8_8_EXT = 0x8035; // PixelType
        public const ushort UNSIGNED_INT_10_10_10_2 = 0x8036; // PixelType
        public const ushort UNSIGNED_INT_10_10_10_2_EXT = 0x8036; // PixelType
        public const ushort POLYGON_OFFSET_EXT = 0x8037;
        public const ushort POLYGON_OFFSET_FILL = 0x8037; // GetPName,EnableCap
        public const ushort POLYGON_OFFSET_FACTOR = 0x8038; // GetPName
        public const ushort POLYGON_OFFSET_FACTOR_EXT = 0x8038;
        public const ushort POLYGON_OFFSET_BIAS_EXT = 0x8039; // GetPName
        public const ushort RESCALE_NORMAL = 0x803A;
        public const ushort RESCALE_NORMAL_EXT = 0x803A; // GetPName,EnableCap
        public const ushort ALPHA4 = 0x803B; // InternalFormat
        public const ushort ALPHA4_EXT = 0x803B;
        public const ushort ALPHA8 = 0x803C; // InternalFormat
        public const ushort ALPHA8_EXT = 0x803C;
        public const ushort ALPHA8_OES = 0x803C;
        public const ushort ALPHA12 = 0x803D; // InternalFormat
        public const ushort ALPHA12_EXT = 0x803D;
        public const ushort ALPHA16 = 0x803E; // InternalFormat
        public const ushort ALPHA16_EXT = 0x803E;
        public const ushort LUMINANCE4 = 0x803F; // InternalFormat
        public const ushort LUMINANCE4_EXT = 0x803F;
        public const ushort LUMINANCE8 = 0x8040; // InternalFormat
        public const ushort LUMINANCE8_EXT = 0x8040;
        public const ushort LUMINANCE8_OES = 0x8040;
        public const ushort LUMINANCE12 = 0x8041; // InternalFormat
        public const ushort LUMINANCE12_EXT = 0x8041;
        public const ushort LUMINANCE16 = 0x8042; // InternalFormat
        public const ushort LUMINANCE16_EXT = 0x8042;
        public const ushort LUMINANCE4_ALPHA4 = 0x8043; // InternalFormat
        public const ushort LUMINANCE4_ALPHA4_EXT = 0x8043;
        public const ushort LUMINANCE4_ALPHA4_OES = 0x8043;
        public const ushort LUMINANCE6_ALPHA2 = 0x8044; // InternalFormat
        public const ushort LUMINANCE6_ALPHA2_EXT = 0x8044;
        public const ushort LUMINANCE8_ALPHA8 = 0x8045; // InternalFormat
        public const ushort LUMINANCE8_ALPHA8_EXT = 0x8045;
        public const ushort LUMINANCE8_ALPHA8_OES = 0x8045;
        public const ushort LUMINANCE12_ALPHA4 = 0x8046; // InternalFormat
        public const ushort LUMINANCE12_ALPHA4_EXT = 0x8046;
        public const ushort LUMINANCE12_ALPHA12 = 0x8047; // InternalFormat
        public const ushort LUMINANCE12_ALPHA12_EXT = 0x8047;
        public const ushort LUMINANCE16_ALPHA16 = 0x8048; // InternalFormat
        public const ushort LUMINANCE16_ALPHA16_EXT = 0x8048;
        public const ushort INTENSITY = 0x8049; // InternalFormat,PathColorFormat
        public const ushort INTENSITY_EXT = 0x8049;
        public const ushort INTENSITY4 = 0x804A; // InternalFormat
        public const ushort INTENSITY4_EXT = 0x804A;
        public const ushort INTENSITY8 = 0x804B; // InternalFormat
        public const ushort INTENSITY8_EXT = 0x804B;
        public const ushort INTENSITY12 = 0x804C; // InternalFormat
        public const ushort INTENSITY12_EXT = 0x804C;
        public const ushort INTENSITY16 = 0x804D; // InternalFormat
        public const ushort INTENSITY16_EXT = 0x804D;
        public const ushort RGB2_EXT = 0x804E; // InternalFormat
        public const ushort RGB4 = 0x804F; // InternalFormat
        public const ushort RGB4_EXT = 0x804F; // InternalFormat
        public const ushort RGB5 = 0x8050; // InternalFormat
        public const ushort RGB5_EXT = 0x8050; // InternalFormat
        public const ushort RGB8 = 0x8051; // InternalFormat
        public const ushort RGB8_EXT = 0x8051; // InternalFormat
        public const ushort RGB8_OES = 0x8051; // InternalFormat
        public const ushort RGB10 = 0x8052; // InternalFormat
        public const ushort RGB10_EXT = 0x8052; // InternalFormat
        public const ushort RGB12 = 0x8053; // InternalFormat
        public const ushort RGB12_EXT = 0x8053; // InternalFormat
        public const ushort RGB16 = 0x8054; // InternalFormat
        public const ushort RGB16_EXT = 0x8054; // InternalFormat
        public const ushort RGBA2 = 0x8055;
        public const ushort RGBA2_EXT = 0x8055;
        public const ushort RGBA4 = 0x8056; // InternalFormat
        public const ushort RGBA4_EXT = 0x8056; // InternalFormat
        public const ushort RGBA4_OES = 0x8056; // InternalFormat
        public const ushort RGB5_A1 = 0x8057; // InternalFormat
        public const ushort RGB5_A1_EXT = 0x8057; // InternalFormat
        public const ushort RGB5_A1_OES = 0x8057; // InternalFormat
        public const ushort RGBA8 = 0x8058; // InternalFormat
        public const ushort RGBA8_EXT = 0x8058; // InternalFormat
        public const ushort RGBA8_OES = 0x8058; // InternalFormat
        public const ushort RGB10_A2 = 0x8059; // InternalFormat
        public const ushort RGB10_A2_EXT = 0x8059; // InternalFormat
        public const ushort RGBA12 = 0x805A; // InternalFormat
        public const ushort RGBA12_EXT = 0x805A; // InternalFormat
        public const ushort RGBA16 = 0x805B; // InternalFormat
        public const ushort RGBA16_EXT = 0x805B; // InternalFormat
        public const ushort TEXTURE_RED_SIZE = 0x805C; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_RED_SIZE_EXT = 0x805C;
        public const ushort TEXTURE_GREEN_SIZE = 0x805D; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_GREEN_SIZE_EXT = 0x805D;
        public const ushort TEXTURE_BLUE_SIZE = 0x805E; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_BLUE_SIZE_EXT = 0x805E;
        public const ushort TEXTURE_ALPHA_SIZE = 0x805F; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_ALPHA_SIZE_EXT = 0x805F;
        public const ushort TEXTURE_LUMINANCE_SIZE = 0x8060; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_LUMINANCE_SIZE_EXT = 0x8060;
        public const ushort TEXTURE_INTENSITY_SIZE = 0x8061; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_INTENSITY_SIZE_EXT = 0x8061;
        public const ushort REPLACE_EXT = 0x8062; // TextureEnvMode
        public const ushort PROXY_TEXTURE_1D = 0x8063; // TextureTarget
        public const ushort PROXY_TEXTURE_1D_EXT = 0x8063; // TextureTarget
        public const ushort PROXY_TEXTURE_2D = 0x8064; // TextureTarget
        public const ushort PROXY_TEXTURE_2D_EXT = 0x8064; // TextureTarget
        public const ushort TEXTURE_TOO_LARGE_EXT = 0x8065; // ErrorCode
        public const ushort TEXTURE_PRIORITY = 0x8066; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_PRIORITY_EXT = 0x8066; // TextureParameterName
        public const ushort TEXTURE_RESIDENT = 0x8067; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_RESIDENT_EXT = 0x8067;
        public const ushort TEXTURE_1D_BINDING_EXT = 0x8068;
        public const ushort TEXTURE_BINDING_1D = 0x8068; // GetPName
        public const ushort TEXTURE_2D_BINDING_EXT = 0x8069;
        public const ushort TEXTURE_BINDING_2D = 0x8069; // GetPName
        public const ushort TEXTURE_3D_BINDING_EXT = 0x806A; // GetPName
        public const ushort TEXTURE_3D_BINDING_OES = 0x806A;
        public const ushort TEXTURE_BINDING_3D = 0x806A; // GetPName
        public const ushort TEXTURE_BINDING_3D_OES = 0x806A;
        public const ushort PACK_SKIP_IMAGES = 0x806B; // PixelStoreParameter,GetPName
        public const ushort PACK_SKIP_IMAGES_EXT = 0x806B; // PixelStoreParameter,GetPName
        public const ushort PACK_IMAGE_HEIGHT = 0x806C; // PixelStoreParameter,GetPName
        public const ushort PACK_IMAGE_HEIGHT_EXT = 0x806C; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SKIP_IMAGES = 0x806D; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SKIP_IMAGES_EXT = 0x806D; // PixelStoreParameter,GetPName
        public const ushort UNPACK_IMAGE_HEIGHT = 0x806E; // PixelStoreParameter,GetPName
        public const ushort UNPACK_IMAGE_HEIGHT_EXT = 0x806E; // PixelStoreParameter,GetPName
        public const ushort TEXTURE_3D = 0x806F; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_3D_EXT = 0x806F; // TextureTarget,EnableCap,GetPName
        public const ushort TEXTURE_3D_OES = 0x806F; // TextureTarget
        public const ushort PROXY_TEXTURE_3D = 0x8070; // TextureTarget
        public const ushort PROXY_TEXTURE_3D_EXT = 0x8070; // TextureTarget
        public const ushort TEXTURE_DEPTH = 0x8071;
        public const ushort TEXTURE_DEPTH_EXT = 0x8071; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_WRAP_R = 0x8072; // SamplerParameterI,TextureParameterName
        public const ushort TEXTURE_WRAP_R_EXT = 0x8072; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_WRAP_R_OES = 0x8072; // TextureParameterName
        public const ushort MAX_3D_TEXTURE_SIZE = 0x8073; // GetPName
        public const ushort MAX_3D_TEXTURE_SIZE_EXT = 0x8073; // GetPName
        public const ushort MAX_3D_TEXTURE_SIZE_OES = 0x8073;
        public const ushort VERTEX_ARRAY = 0x8074; // ObjectIdentifier,EnableCap,GetPName
        public const ushort VERTEX_ARRAY_EXT = 0x8074;
        public const ushort VERTEX_ARRAY_KHR = 0x8074;
        public const ushort NORMAL_ARRAY = 0x8075; // GetPName,EnableCap
        public const ushort NORMAL_ARRAY_EXT = 0x8075;
        public const ushort COLOR_ARRAY = 0x8076; // GetPName,EnableCap
        public const ushort COLOR_ARRAY_EXT = 0x8076;
        public const ushort INDEX_ARRAY = 0x8077; // GetPName,EnableCap
        public const ushort INDEX_ARRAY_EXT = 0x8077;
        public const ushort TEXTURE_COORD_ARRAY = 0x8078; // GetPName,EnableCap
        public const ushort TEXTURE_COORD_ARRAY_EXT = 0x8078;
        public const ushort EDGE_FLAG_ARRAY = 0x8079; // GetPName,EnableCap
        public const ushort EDGE_FLAG_ARRAY_EXT = 0x8079;
        public const ushort VERTEX_ARRAY_SIZE = 0x807A; // GetPName
        public const ushort VERTEX_ARRAY_SIZE_EXT = 0x807A;
        public const ushort VERTEX_ARRAY_TYPE = 0x807B; // GetPName
        public const ushort VERTEX_ARRAY_TYPE_EXT = 0x807B;
        public const ushort VERTEX_ARRAY_STRIDE = 0x807C; // GetPName
        public const ushort VERTEX_ARRAY_STRIDE_EXT = 0x807C;
        public const ushort VERTEX_ARRAY_COUNT_EXT = 0x807D; // GetPName
        public const ushort NORMAL_ARRAY_TYPE = 0x807E; // GetPName
        public const ushort NORMAL_ARRAY_TYPE_EXT = 0x807E;
        public const ushort NORMAL_ARRAY_STRIDE = 0x807F; // GetPName
        public const ushort NORMAL_ARRAY_STRIDE_EXT = 0x807F;
        public const ushort NORMAL_ARRAY_COUNT_EXT = 0x8080; // GetPName
        public const ushort COLOR_ARRAY_SIZE = 0x8081; // GetPName
        public const ushort COLOR_ARRAY_SIZE_EXT = 0x8081;
        public const ushort COLOR_ARRAY_TYPE = 0x8082; // GetPName
        public const ushort COLOR_ARRAY_TYPE_EXT = 0x8082;
        public const ushort COLOR_ARRAY_STRIDE = 0x8083; // GetPName
        public const ushort COLOR_ARRAY_STRIDE_EXT = 0x8083;
        public const ushort COLOR_ARRAY_COUNT_EXT = 0x8084; // GetPName
        public const ushort INDEX_ARRAY_TYPE = 0x8085; // GetPName
        public const ushort INDEX_ARRAY_TYPE_EXT = 0x8085;
        public const ushort INDEX_ARRAY_STRIDE = 0x8086; // GetPName
        public const ushort INDEX_ARRAY_STRIDE_EXT = 0x8086;
        public const ushort INDEX_ARRAY_COUNT_EXT = 0x8087; // GetPName
        public const ushort TEXTURE_COORD_ARRAY_SIZE = 0x8088; // GetPName
        public const ushort TEXTURE_COORD_ARRAY_SIZE_EXT = 0x8088;
        public const ushort TEXTURE_COORD_ARRAY_TYPE = 0x8089; // GetPName
        public const ushort TEXTURE_COORD_ARRAY_TYPE_EXT = 0x8089;
        public const ushort TEXTURE_COORD_ARRAY_STRIDE = 0x808A; // GetPName
        public const ushort TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
        public const ushort TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B; // GetPName
        public const ushort EDGE_FLAG_ARRAY_STRIDE = 0x808C; // GetPName
        public const ushort EDGE_FLAG_ARRAY_STRIDE_EXT = 0x808C;
        public const ushort EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D; // GetPName
        public const ushort VERTEX_ARRAY_POINTER = 0x808E; // GetPointervPName
        public const ushort VERTEX_ARRAY_POINTER_EXT = 0x808E; // GetPointervPName
        public const ushort NORMAL_ARRAY_POINTER = 0x808F; // GetPointervPName
        public const ushort NORMAL_ARRAY_POINTER_EXT = 0x808F; // GetPointervPName
        public const ushort COLOR_ARRAY_POINTER = 0x8090; // GetPointervPName
        public const ushort COLOR_ARRAY_POINTER_EXT = 0x8090; // GetPointervPName
        public const ushort INDEX_ARRAY_POINTER = 0x8091; // GetPointervPName
        public const ushort INDEX_ARRAY_POINTER_EXT = 0x8091; // GetPointervPName
        public const ushort TEXTURE_COORD_ARRAY_POINTER = 0x8092; // GetPointervPName
        public const ushort TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092; // GetPointervPName
        public const ushort EDGE_FLAG_ARRAY_POINTER = 0x8093; // GetPointervPName
        public const ushort EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093; // GetPointervPName
        public const ushort INTERLACE_SGIX = 0x8094; // GetPName,EnableCap
        public const ushort DETAIL_TEXTURE_2D_SGIS = 0x8095; // TextureTarget
        public const ushort DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096; // GetPName
        public const ushort LINEAR_DETAIL_SGIS = 0x8097; // TextureMagFilter
        public const ushort LINEAR_DETAIL_ALPHA_SGIS = 0x8098; // TextureMagFilter
        public const ushort LINEAR_DETAIL_COLOR_SGIS = 0x8099; // TextureMagFilter
        public const ushort DETAIL_TEXTURE_LEVEL_SGIS = 0x809A; // TextureParameterName,GetTextureParameter
        public const ushort DETAIL_TEXTURE_MODE_SGIS = 0x809B; // TextureParameterName,GetTextureParameter
        public const ushort DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C; // TextureParameterName,GetTextureParameter
        public const ushort MULTISAMPLE = 0x809D; // EnableCap
        public const ushort MULTISAMPLE_ARB = 0x809D;
        public const ushort MULTISAMPLE_EXT = 0x809D;
        public const ushort MULTISAMPLE_SGIS = 0x809D; // GetPName,EnableCap
        public const ushort SAMPLE_ALPHA_TO_COVERAGE = 0x809E; // EnableCap
        public const ushort SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
        public const ushort SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
        public const ushort SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E; // GetPName,EnableCap
        public const ushort SAMPLE_ALPHA_TO_ONE = 0x809F; // EnableCap
        public const ushort SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
        public const ushort SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
        public const ushort SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F; // GetPName,EnableCap
        public const ushort SAMPLE_COVERAGE = 0x80A0; // EnableCap
        public const ushort SAMPLE_COVERAGE_ARB = 0x80A0;
        public const ushort SAMPLE_MASK_EXT = 0x80A0;
        public const ushort SAMPLE_MASK_SGIS = 0x80A0; // GetPName,EnableCap
        public const ushort GL_1PASS_EXT = 0x80A1; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_1PASS_SGIS = 0x80A1; // SamplePatternSGIS
        public const ushort GL_2PASS_0_EXT = 0x80A2; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_2PASS_0_SGIS = 0x80A2; // SamplePatternSGIS
        public const ushort GL_2PASS_1_EXT = 0x80A3; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_2PASS_1_SGIS = 0x80A3; // SamplePatternSGIS
        public const ushort GL_4PASS_0_EXT = 0x80A4; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_4PASS_0_SGIS = 0x80A4; // SamplePatternSGIS
        public const ushort GL_4PASS_1_EXT = 0x80A5; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_4PASS_1_SGIS = 0x80A5; // SamplePatternSGIS
        public const ushort GL_4PASS_2_EXT = 0x80A6; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_4PASS_2_SGIS = 0x80A6; // SamplePatternSGIS
        public const ushort GL_4PASS_3_EXT = 0x80A7; // SamplePatternSGIS,SamplePatternEXT
        public const ushort GL_4PASS_3_SGIS = 0x80A7; // SamplePatternSGIS
        public const ushort SAMPLE_BUFFERS = 0x80A8; // GetFramebufferParameter,GetPName
        public const ushort SAMPLE_BUFFERS_ARB = 0x80A8;
        public const ushort SAMPLE_BUFFERS_EXT = 0x80A8;
        public const ushort SAMPLE_BUFFERS_SGIS = 0x80A8; // GetPName
        public const ushort SAMPLES = 0x80A9; // GetFramebufferParameter,GetPName,InternalFormatPName
        public const ushort SAMPLES_ARB = 0x80A9;
        public const ushort SAMPLES_EXT = 0x80A9;
        public const ushort SAMPLES_SGIS = 0x80A9; // GetPName
        public const ushort SAMPLE_COVERAGE_VALUE = 0x80AA; // GetPName
        public const ushort SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
        public const ushort SAMPLE_MASK_VALUE_EXT = 0x80AA;
        public const ushort SAMPLE_MASK_VALUE_SGIS = 0x80AA; // GetPName
        public const ushort SAMPLE_COVERAGE_INVERT = 0x80AB; // GetPName
        public const ushort SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
        public const ushort SAMPLE_MASK_INVERT_EXT = 0x80AB;
        public const ushort SAMPLE_MASK_INVERT_SGIS = 0x80AB; // GetPName
        public const ushort SAMPLE_PATTERN_EXT = 0x80AC;
        public const ushort SAMPLE_PATTERN_SGIS = 0x80AC; // GetPName
        public const ushort LINEAR_SHARPEN_SGIS = 0x80AD; // TextureMagFilter
        public const ushort LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE; // TextureMagFilter
        public const ushort LINEAR_SHARPEN_COLOR_SGIS = 0x80AF; // TextureMagFilter
        public const ushort SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0; // TextureParameterName,GetTextureParameter
        public const ushort COLOR_MATRIX = 0x80B1;
        public const ushort COLOR_MATRIX_SGI = 0x80B1; // GetPName
        public const ushort COLOR_MATRIX_STACK_DEPTH = 0x80B2;
        public const ushort COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2; // GetPName
        public const ushort MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
        public const ushort MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3; // GetPName
        public const ushort POST_COLOR_MATRIX_RED_SCALE = 0x80B4; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_RED_BIAS = 0x80B8; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA; // PixelTransferParameter,GetPName
        public const ushort POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB; // PixelTransferParameter
        public const ushort POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB; // PixelTransferParameter,GetPName
        public const ushort TEXTURE_COLOR_TABLE_SGI = 0x80BC; // GetPName,ColorTableTargetSGI,EnableCap
        public const ushort PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD; // ColorTableTargetSGI
        public const ushort TEXTURE_ENV_BIAS_SGIX = 0x80BE; // TextureEnvMode
        public const ushort SHADOW_AMBIENT_SGIX = 0x80BF; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;
        
        // . 
        // Unused 0x80C0..0x80C7. 
        public const ushort BLEND_DST_RGB = 0x80C8; // GetPName
        public const ushort BLEND_DST_RGB_EXT = 0x80C8;
        public const ushort BLEND_DST_RGB_OES = 0x80C8;
        public const ushort BLEND_SRC_RGB = 0x80C9; // GetPName
        public const ushort BLEND_SRC_RGB_EXT = 0x80C9;
        public const ushort BLEND_SRC_RGB_OES = 0x80C9;
        public const ushort BLEND_DST_ALPHA = 0x80CA; // GetPName
        public const ushort BLEND_DST_ALPHA_EXT = 0x80CA;
        public const ushort BLEND_DST_ALPHA_OES = 0x80CA;
        public const ushort BLEND_SRC_ALPHA = 0x80CB; // GetPName
        public const ushort BLEND_SRC_ALPHA_EXT = 0x80CB;
        public const ushort BLEND_SRC_ALPHA_OES = 0x80CB;
        public const ushort GL_422_EXT = 0x80CC;
        public const ushort GL_422_REV_EXT = 0x80CD;
        public const ushort GL_422_AVERAGE_EXT = 0x80CE;
        public const ushort GL_422_REV_AVERAGE_EXT = 0x80CF;
        
        // . 
        public const ushort COLOR_TABLE = 0x80D0; // ColorTableTarget,ColorTableTargetSGI
        public const ushort COLOR_TABLE_SGI = 0x80D0; // GetPName,ColorTableTargetSGI,EnableCap
        public const ushort POST_CONVOLUTION_COLOR_TABLE = 0x80D1; // ColorTableTarget,ColorTableTargetSGI
        public const ushort POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1; // GetPName,ColorTableTargetSGI,EnableCap
        public const ushort POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2; // ColorTableTarget,ColorTableTargetSGI
        public const ushort POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2; // GetPName,ColorTableTargetSGI,EnableCap
        public const ushort PROXY_COLOR_TABLE = 0x80D3; // ColorTableTargetSGI
        public const ushort PROXY_COLOR_TABLE_SGI = 0x80D3; // ColorTableTargetSGI
        public const ushort PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4; // ColorTableTargetSGI
        public const ushort PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4; // ColorTableTargetSGI
        public const ushort PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5; // ColorTableTargetSGI
        public const ushort PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5; // ColorTableTargetSGI
        public const ushort COLOR_TABLE_SCALE = 0x80D6; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_SCALE_SGI = 0x80D6; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_BIAS = 0x80D7; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_BIAS_SGI = 0x80D7; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_FORMAT = 0x80D8; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_FORMAT_SGI = 0x80D8; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_WIDTH = 0x80D9; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_WIDTH_SGI = 0x80D9; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_RED_SIZE = 0x80DA; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_RED_SIZE_SGI = 0x80DA; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_GREEN_SIZE = 0x80DB; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_BLUE_SIZE = 0x80DC; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_ALPHA_SIZE = 0x80DD; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_LUMINANCE_SIZE = 0x80DE; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_INTENSITY_SIZE = 0x80DF; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        public const ushort COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF; // GetColorTableParameterPNameSGI,ColorTableParameterPNameSGI
        
        // . 
        public const ushort BGR = 0x80E0; // PixelFormat
        public const ushort BGR_EXT = 0x80E0;
        public const ushort BGRA = 0x80E1; // PixelFormat
        public const ushort BGRA_EXT = 0x80E1;
        public const ushort BGRA_IMG = 0x80E1;
        public const ushort COLOR_INDEX1_EXT = 0x80E2;
        public const ushort COLOR_INDEX2_EXT = 0x80E3;
        public const ushort COLOR_INDEX4_EXT = 0x80E4;
        public const ushort COLOR_INDEX8_EXT = 0x80E5;
        public const ushort COLOR_INDEX12_EXT = 0x80E6;
        public const ushort COLOR_INDEX16_EXT = 0x80E7;
        public const ushort MAX_ELEMENTS_VERTICES = 0x80E8; // GetPName
        public const ushort MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
        public const ushort MAX_ELEMENTS_INDICES = 0x80E9; // GetPName
        public const ushort MAX_ELEMENTS_INDICES_EXT = 0x80E9;
        public const ushort PHONG_WIN = 0x80EA;
        public const ushort PHONG_HINT_WIN = 0x80EB; // HintTarget
        public const ushort FOG_SPECULAR_TEXTURE_WIN = 0x80EC;
        public const ushort TEXTURE_INDEX_SIZE_EXT = 0x80ED;
        public const ushort PARAMETER_BUFFER = 0x80EE; // BufferTargetARB
        // Alias of GL_PARAMETER_BUFFER
        public const ushort PARAMETER_BUFFER_ARB = 0x80EE;
        public const ushort PARAMETER_BUFFER_BINDING = 0x80EF;
        // Alias of GL_PARAMETER_BUFFER_BINDING
        public const ushort PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
        public const ushort CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0; // HintTarget
        // Unused 0x80F1..0x810F. 
        
        // . 
        public const ushort DUAL_ALPHA4_SGIS = 0x8110; // InternalFormat
        public const ushort DUAL_ALPHA8_SGIS = 0x8111; // InternalFormat
        public const ushort DUAL_ALPHA12_SGIS = 0x8112; // InternalFormat
        public const ushort DUAL_ALPHA16_SGIS = 0x8113; // InternalFormat
        public const ushort DUAL_LUMINANCE4_SGIS = 0x8114; // InternalFormat
        public const ushort DUAL_LUMINANCE8_SGIS = 0x8115; // InternalFormat
        public const ushort DUAL_LUMINANCE12_SGIS = 0x8116; // InternalFormat
        public const ushort DUAL_LUMINANCE16_SGIS = 0x8117; // InternalFormat
        public const ushort DUAL_INTENSITY4_SGIS = 0x8118; // InternalFormat
        public const ushort DUAL_INTENSITY8_SGIS = 0x8119; // InternalFormat
        public const ushort DUAL_INTENSITY12_SGIS = 0x811A; // InternalFormat
        public const ushort DUAL_INTENSITY16_SGIS = 0x811B; // InternalFormat
        public const ushort DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C; // InternalFormat
        public const ushort DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D; // InternalFormat
        public const ushort QUAD_ALPHA4_SGIS = 0x811E; // InternalFormat
        public const ushort QUAD_ALPHA8_SGIS = 0x811F; // InternalFormat
        public const ushort QUAD_LUMINANCE4_SGIS = 0x8120; // InternalFormat
        public const ushort QUAD_LUMINANCE8_SGIS = 0x8121; // InternalFormat
        public const ushort QUAD_INTENSITY4_SGIS = 0x8122; // InternalFormat
        public const ushort QUAD_INTENSITY8_SGIS = 0x8123; // InternalFormat
        public const ushort DUAL_TEXTURE_SELECT_SGIS = 0x8124; // TextureParameterName,GetTextureParameter
        public const ushort QUAD_TEXTURE_SELECT_SGIS = 0x8125; // TextureParameterName,GetTextureParameter
        public const ushort POINT_SIZE_MIN = 0x8126; // PointParameterNameSGIS
        public const ushort POINT_SIZE_MIN_ARB = 0x8126; // PointParameterNameSGIS
        public const ushort POINT_SIZE_MIN_EXT = 0x8126; // PointParameterNameSGIS,PointParameterNameARB
        public const ushort POINT_SIZE_MIN_SGIS = 0x8126; // PointParameterNameSGIS,GetPName
        public const ushort POINT_SIZE_MAX = 0x8127; // PointParameterNameSGIS
        public const ushort POINT_SIZE_MAX_ARB = 0x8127; // PointParameterNameSGIS
        public const ushort POINT_SIZE_MAX_EXT = 0x8127; // PointParameterNameSGIS,PointParameterNameARB
        public const ushort POINT_SIZE_MAX_SGIS = 0x8127; // PointParameterNameSGIS,GetPName
        public const ushort POINT_FADE_THRESHOLD_SIZE = 0x8128; // PointParameterNameSGIS,PointParameterNameARB,GetPName
        public const ushort POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128; // PointParameterNameSGIS
        public const ushort POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128; // PointParameterNameSGIS,PointParameterNameARB
        public const ushort POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128; // PointParameterNameSGIS,GetPName
        public const ushort DISTANCE_ATTENUATION_EXT = 0x8129; // PointParameterNameSGIS
        public const ushort DISTANCE_ATTENUATION_SGIS = 0x8129; // PointParameterNameSGIS,GetPName
        public const ushort POINT_DISTANCE_ATTENUATION = 0x8129; // PointParameterNameSGIS
        public const ushort POINT_DISTANCE_ATTENUATION_ARB = 0x8129; // PointParameterNameSGIS
        public const ushort FOG_FUNC_SGIS = 0x812A; // FogMode
        public const ushort FOG_FUNC_POINTS_SGIS = 0x812B; // GetPName
        public const ushort MAX_FOG_FUNC_POINTS_SGIS = 0x812C; // GetPName
        public const ushort CLAMP_TO_BORDER = 0x812D; // TextureWrapMode
        public const ushort CLAMP_TO_BORDER_ARB = 0x812D; // TextureWrapMode
        public const ushort CLAMP_TO_BORDER_EXT = 0x812D;
        public const ushort CLAMP_TO_BORDER_NV = 0x812D; // TextureWrapMode
        public const ushort CLAMP_TO_BORDER_SGIS = 0x812D; // TextureWrapMode
        public const ushort CLAMP_TO_BORDER_OES = 0x812D;
        public const ushort TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E; // HintTarget
        public const ushort CLAMP_TO_EDGE = 0x812F; // TextureWrapMode
        public const ushort CLAMP_TO_EDGE_SGIS = 0x812F; // TextureWrapMode
        public const ushort PACK_SKIP_VOLUMES_SGIS = 0x8130; // PixelStoreParameter,GetPName
        public const ushort PACK_IMAGE_DEPTH_SGIS = 0x8131; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SKIP_VOLUMES_SGIS = 0x8132; // PixelStoreParameter,GetPName
        public const ushort UNPACK_IMAGE_DEPTH_SGIS = 0x8133; // PixelStoreParameter,GetPName
        public const ushort TEXTURE_4D_SGIS = 0x8134; // TextureTarget,EnableCap,GetPName
        public const ushort PROXY_TEXTURE_4D_SGIS = 0x8135; // TextureTarget
        public const ushort TEXTURE_4DSIZE_SGIS = 0x8136; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_WRAP_Q_SGIS = 0x8137; // TextureParameterName,GetTextureParameter
        public const ushort MAX_4D_TEXTURE_SIZE_SGIS = 0x8138; // GetPName
        public const ushort PIXEL_TEX_GEN_SGIX = 0x8139; // GetPName,EnableCap
        public const ushort TEXTURE_MIN_LOD = 0x813A; // SamplerParameterF,TextureParameterName
        public const ushort TEXTURE_MIN_LOD_SGIS = 0x813A; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_MAX_LOD = 0x813B; // SamplerParameterF,TextureParameterName
        public const ushort TEXTURE_MAX_LOD_SGIS = 0x813B; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_BASE_LEVEL = 0x813C; // TextureParameterName
        public const ushort TEXTURE_BASE_LEVEL_SGIS = 0x813C; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_MAX_LEVEL = 0x813D; // TextureParameterName
        public const ushort TEXTURE_MAX_LEVEL_APPLE = 0x813D;
        public const ushort TEXTURE_MAX_LEVEL_SGIS = 0x813D; // TextureParameterName,GetTextureParameter
        public const ushort PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E; // GetPName
        public const ushort PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F; // GetPName
        public const ushort PIXEL_TILE_WIDTH_SGIX = 0x8140; // PixelStoreParameter,GetPName
        public const ushort PIXEL_TILE_HEIGHT_SGIX = 0x8141; // PixelStoreParameter,GetPName
        public const ushort PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142; // PixelStoreParameter,GetPName
        public const ushort PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143; // PixelStoreParameter,GetPName
        public const ushort PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144; // PixelStoreParameter,GetPName
        public const ushort PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145; // PixelStoreParameter,GetPName
        public const ushort FILTER4_SGIS = 0x8146; // TextureMinFilter,TextureFilterSGIS,TextureFilterFuncSGIS,TextureMagFilter
        public const ushort TEXTURE_FILTER4_SIZE_SGIS = 0x8147; // TextureParameterName,GetTextureParameter
        public const ushort SPRITE_SGIX = 0x8148; // GetPName,EnableCap
        public const ushort SPRITE_MODE_SGIX = 0x8149; // GetPName,SpriteParameterNameSGIX
        public const ushort SPRITE_AXIS_SGIX = 0x814A; // GetPName
        public const ushort SPRITE_TRANSLATION_SGIX = 0x814B; // GetPName
        public const ushort SPRITE_AXIAL_SGIX = 0x814C;
        public const ushort SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;
        public const ushort SPRITE_EYE_ALIGNED_SGIX = 0x814E;
        public const ushort TEXTURE_4D_BINDING_SGIS = 0x814F; // GetPName
        
        // . 
        public const ushort IGNORE_BORDER_HP = 0x8150;
        public const ushort CONSTANT_BORDER = 0x8151;
        public const ushort CONSTANT_BORDER_HP = 0x8151;
        // Unused 0x8152. GL_WRAP_BORDER = 0x8152 was proposed, but not actually promoted to core
        public const ushort REPLICATE_BORDER = 0x8153;
        public const ushort REPLICATE_BORDER_HP = 0x8153;
        public const ushort CONVOLUTION_BORDER_COLOR = 0x8154; // GetConvolutionParameter
        public const ushort CONVOLUTION_BORDER_COLOR_HP = 0x8154;
        public const ushort IMAGE_SCALE_X_HP = 0x8155; // ImageTransformPNameHP
        public const ushort IMAGE_SCALE_Y_HP = 0x8156; // ImageTransformPNameHP
        public const ushort IMAGE_TRANSLATE_X_HP = 0x8157; // ImageTransformPNameHP
        public const ushort IMAGE_TRANSLATE_Y_HP = 0x8158; // ImageTransformPNameHP
        public const ushort IMAGE_ROTATE_ANGLE_HP = 0x8159; // ImageTransformPNameHP
        public const ushort IMAGE_ROTATE_ORIGIN_X_HP = 0x815A; // ImageTransformPNameHP
        public const ushort IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B; // ImageTransformPNameHP
        public const ushort IMAGE_MAG_FILTER_HP = 0x815C; // ImageTransformPNameHP
        public const ushort IMAGE_MIN_FILTER_HP = 0x815D; // ImageTransformPNameHP
        public const ushort IMAGE_CUBIC_WEIGHT_HP = 0x815E; // ImageTransformPNameHP
        public const ushort CUBIC_HP = 0x815F;
        public const ushort AVERAGE_HP = 0x8160;
        public const ushort IMAGE_TRANSFORM_2D_HP = 0x8161; // ImageTransformTargetHP
        public const ushort POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
        public const ushort PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;
        // Unused 0x8164. 
        public const ushort OCCLUSION_TEST_HP = 0x8165;
        public const ushort OCCLUSION_TEST_RESULT_HP = 0x8166;
        public const ushort TEXTURE_LIGHTING_MODE_HP = 0x8167;
        public const ushort TEXTURE_POST_SPECULAR_HP = 0x8168;
        public const ushort TEXTURE_PRE_SPECULAR_HP = 0x8169;
        // Unused 0x816A..0x816F. 
        
        // . 
        public const ushort LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170; // TextureMinFilter
        public const ushort TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176; // TextureParameterName,GetTextureParameter
        public const ushort MAX_CLIPMAP_DEPTH_SGIX = 0x8177; // GetPName
        public const ushort MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178; // GetPName
        public const ushort POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179; // TextureParameterName,GetTextureParameter
        public const ushort POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A; // TextureParameterName,GetTextureParameter
        public const ushort POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B; // GetPName
        public const ushort POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C; // GetPName
        public const ushort REFERENCE_PLANE_SGIX = 0x817D; // GetPName,EnableCap
        public const ushort REFERENCE_PLANE_EQUATION_SGIX = 0x817E; // GetPName
        public const ushort IR_INSTRUMENT1_SGIX = 0x817F; // GetPName,EnableCap
        public const ushort INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180; // GetPointervPName
        public const ushort INSTRUMENT_MEASUREMENTS_SGIX = 0x8181; // GetPName
        public const ushort LIST_PRIORITY_SGIX = 0x8182; // ListParameterName
        public const ushort CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183; // GetPName,EnableCap
        public const ushort PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184; // TextureMinFilter,PixelTexGenModeSGIX,TextureMagFilter
        public const ushort PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185; // TextureMinFilter,PixelTexGenModeSGIX,TextureMagFilter
        public const ushort PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186; // TextureMinFilter,PixelTexGenModeSGIX,TextureMagFilter
        public const ushort PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187; // PixelTexGenMode
        public const ushort PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188; // PixelTexGenMode
        public const ushort PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189; // PixelTexGenMode,PixelTexGenModeSGIX
        public const ushort PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A; // PixelTexGenMode,PixelTexGenModeSGIX
        public const ushort FRAMEZOOM_SGIX = 0x818B; // GetPName,EnableCap
        public const ushort FRAMEZOOM_FACTOR_SGIX = 0x818C; // GetPName
        public const ushort MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D; // GetPName
        public const ushort TEXTURE_LOD_BIAS_S_SGIX = 0x818E; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_LOD_BIAS_T_SGIX = 0x818F; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_LOD_BIAS_R_SGIX = 0x8190; // TextureParameterName,GetTextureParameter
        public const ushort GENERATE_MIPMAP = 0x8191; // InternalFormatPName,TextureParameterName
        public const ushort GENERATE_MIPMAP_SGIS = 0x8191; // TextureParameterName,GetTextureParameter
        public const ushort GENERATE_MIPMAP_HINT = 0x8192; // HintTarget
        public const ushort GENERATE_MIPMAP_HINT_SGIS = 0x8192; // HintTarget,GetPName
        // Unused 0x8193..0x8193. Incomplete extension SGIX_spotlight_cutoff
        public const ushort GEOMETRY_DEFORMATION_SGIX = 0x8194; // MapTarget,FfdTargetSGIX
        public const ushort TEXTURE_DEFORMATION_SGIX = 0x8195; // MapTarget,FfdTargetSGIX
        public const ushort DEFORMATIONS_MASK_SGIX = 0x8196; // GetPName
        public const ushort MAX_DEFORMATION_ORDER_SGIX = 0x8197;
        public const ushort FOG_OFFSET_SGIX = 0x8198; // GetPName,EnableCap
        public const ushort FOG_OFFSET_VALUE_SGIX = 0x8199; // GetPName,FogParameter
        public const ushort TEXTURE_COMPARE_SGIX = 0x819A; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_LEQUAL_R_SGIX = 0x819C; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_GEQUAL_R_SGIX = 0x819D; // TextureParameterName,GetTextureParameter
        // Unused 0x819E..0x81A4. Private (internal) extension SGIX_igloo_interface
        public const ushort DEPTH_COMPONENT16 = 0x81A5; // InternalFormat
        public const ushort DEPTH_COMPONENT16_ARB = 0x81A5; // InternalFormat
        public const ushort DEPTH_COMPONENT16_OES = 0x81A5; // InternalFormat
        public const ushort DEPTH_COMPONENT16_SGIX = 0x81A5; // InternalFormat
        public const ushort DEPTH_COMPONENT24 = 0x81A6;
        public const ushort DEPTH_COMPONENT24_ARB = 0x81A6; // InternalFormat
        public const ushort DEPTH_COMPONENT24_OES = 0x81A6; // InternalFormat
        public const ushort DEPTH_COMPONENT24_SGIX = 0x81A6; // InternalFormat
        public const ushort DEPTH_COMPONENT32 = 0x81A7;
        public const ushort DEPTH_COMPONENT32_ARB = 0x81A7; // InternalFormat
        public const ushort DEPTH_COMPONENT32_OES = 0x81A7; // InternalFormat
        public const ushort DEPTH_COMPONENT32_SGIX = 0x81A7; // InternalFormat
        public const ushort ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
        public const ushort ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
        public const ushort CULL_VERTEX_EXT = 0x81AA;
        public const ushort CULL_VERTEX_EYE_POSITION_EXT = 0x81AB; // CullParameterEXT
        public const ushort CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC; // CullParameterEXT
        public const ushort IUI_V2F_EXT = 0x81AD;
        public const ushort IUI_V3F_EXT = 0x81AE;
        public const ushort IUI_N3F_V2F_EXT = 0x81AF;
        public const ushort IUI_N3F_V3F_EXT = 0x81B0;
        public const ushort T2F_IUI_V2F_EXT = 0x81B1;
        public const ushort T2F_IUI_V3F_EXT = 0x81B2;
        public const ushort T2F_IUI_N3F_V2F_EXT = 0x81B3;
        public const ushort T2F_IUI_N3F_V3F_EXT = 0x81B4;
        public const ushort INDEX_TEST_EXT = 0x81B5;
        public const ushort INDEX_TEST_FUNC_EXT = 0x81B6;
        public const ushort INDEX_TEST_REF_EXT = 0x81B7;
        public const ushort INDEX_MATERIAL_EXT = 0x81B8;
        public const ushort INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;
        public const ushort INDEX_MATERIAL_FACE_EXT = 0x81BA;
        public const ushort YCRCB_422_SGIX = 0x81BB; // PixelFormat
        public const ushort YCRCB_444_SGIX = 0x81BC; // PixelFormat
        // Unused 0x81BD..0x81C3. Incomplete extension SGI_complex_type
        // Unused 0x81C4..0x81CA. Incomplete extension SGI_fft
        // Unused 0x81CB..0x81CF. Incomplete extension SGIX_nurbs_eval
        
        // . 
        // Unused 0x81D0..0x81D1. 
        // Unused 0x81D2..0x81D3. No extension spec SUNX_surface_hint
        public const ushort WRAP_BORDER_SUN = 0x81D4;
        public const ushort UNPACK_CONSTANT_DATA_SUNX = 0x81D5;
        public const ushort TEXTURE_CONSTANT_DATA_SUNX = 0x81D6;
        public const ushort TRIANGLE_LIST_SUN = 0x81D7;
        public const ushort REPLACEMENT_CODE_SUN = 0x81D8;
        public const ushort GLOBAL_ALPHA_SUN = 0x81D9;
        public const ushort GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;
        // Unused 0x81DB..0x81DF. 
        
        // . 
        // Unused 0x81E0..0x81EE. Incomplete extension SGIX_nurbs_eval
        public const ushort TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;
        public const ushort EYE_DISTANCE_TO_POINT_SGIS = 0x81F0; // TextureGenMode
        public const ushort OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1; // TextureGenMode
        public const ushort EYE_DISTANCE_TO_LINE_SGIS = 0x81F2; // TextureGenMode
        public const ushort OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3; // TextureGenMode
        public const ushort EYE_POINT_SGIS = 0x81F4; // TextureGenParameter
        public const ushort OBJECT_POINT_SGIS = 0x81F5; // TextureGenParameter
        public const ushort EYE_LINE_SGIS = 0x81F6; // TextureGenParameter
        public const ushort OBJECT_LINE_SGIS = 0x81F7; // TextureGenParameter
        public const ushort LIGHT_MODEL_COLOR_CONTROL = 0x81F8; // LightModelParameter,GetPName
        public const ushort LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8; // LightModelParameter
        public const ushort SINGLE_COLOR = 0x81F9; // LightModelColorControl
        public const ushort SINGLE_COLOR_EXT = 0x81F9; // LightModelColorControl
        public const ushort SEPARATE_SPECULAR_COLOR = 0x81FA; // LightModelColorControl
        public const ushort SEPARATE_SPECULAR_COLOR_EXT = 0x81FA; // LightModelColorControl
        public const ushort SHARED_TEXTURE_PALETTE_EXT = 0x81FB; // GetPName,EnableCap
        // Unused 0x81FC..0x81FD. Incomplete extension SGIX_fog_scale
        // Unused 0x81FE..0x81FF. Incomplete extension SGIX_fog_blend
        
        // . Range released by MS 2002/9/16
        public const ushort TEXT_FRAGMENT_SHADER_ATI = 0x8200; // ProgramTarget
        // Unused 0x8201..0x820F. 
        
        // . 
        public const ushort FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_DEFAULT = 0x8218;
        public const ushort FRAMEBUFFER_UNDEFINED = 0x8219; // FramebufferStatus
        public const ushort FRAMEBUFFER_UNDEFINED_OES = 0x8219;
        public const ushort DEPTH_STENCIL_ATTACHMENT = 0x821A; // InvalidateFramebufferAttachment
        public const ushort MAJOR_VERSION = 0x821B; // GetPName
        public const ushort MINOR_VERSION = 0x821C; // GetPName
        public const ushort NUM_EXTENSIONS = 0x821D; // GetPName
        public const ushort CONTEXT_FLAGS = 0x821E; // GetPName
        public const ushort BUFFER_IMMUTABLE_STORAGE = 0x821F; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
        public const ushort BUFFER_STORAGE_FLAGS = 0x8220; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_STORAGE_FLAGS_EXT = 0x8220;
        public const ushort PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const ushort PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES = 0x8221;
        public const ushort INDEX = 0x8222;
        // Unused 0x8223. GL_DEPTH_BUFFER = 0x8223 not actually used in the API
        // Unused 0x8224. GL_STENCIL_BUFFER = 0x8224 not actually used in the API
        public const ushort COMPRESSED_RED = 0x8225; // InternalFormat
        public const ushort COMPRESSED_RG = 0x8226; // InternalFormat
        public const ushort RG = 0x8227; // InternalFormat,PixelFormat
        public const ushort RG_EXT = 0x8227;
        public const ushort RG_INTEGER = 0x8228; // PixelFormat
        public const ushort R8 = 0x8229; // InternalFormat
        public const ushort R8_EXT = 0x8229; // InternalFormat
        public const ushort R16 = 0x822A; // InternalFormat
        public const ushort R16_EXT = 0x822A; // InternalFormat
        public const ushort RG8 = 0x822B; // InternalFormat
        public const ushort RG8_EXT = 0x822B; // InternalFormat
        public const ushort RG16 = 0x822C; // InternalFormat
        public const ushort RG16_EXT = 0x822C; // InternalFormat
        public const ushort R16F = 0x822D; // InternalFormat
        public const ushort R16F_EXT = 0x822D; // InternalFormat
        public const ushort R32F = 0x822E; // InternalFormat
        public const ushort R32F_EXT = 0x822E; // InternalFormat
        public const ushort RG16F = 0x822F; // InternalFormat
        public const ushort RG16F_EXT = 0x822F; // InternalFormat
        public const ushort RG32F = 0x8230; // InternalFormat
        public const ushort RG32F_EXT = 0x8230; // InternalFormat
        public const ushort R8I = 0x8231; // InternalFormat
        public const ushort R8UI = 0x8232; // InternalFormat
        public const ushort R16I = 0x8233; // InternalFormat
        public const ushort R16UI = 0x8234; // InternalFormat
        public const ushort R32I = 0x8235; // InternalFormat
        public const ushort R32UI = 0x8236; // InternalFormat
        public const ushort RG8I = 0x8237; // InternalFormat
        public const ushort RG8UI = 0x8238; // InternalFormat
        public const ushort RG16I = 0x8239; // InternalFormat
        public const ushort RG16UI = 0x823A; // InternalFormat
        public const ushort RG32I = 0x823B; // InternalFormat
        public const ushort RG32UI = 0x823C; // InternalFormat
        // Unused 0x823D..0x823F. 
        
        // . Range released by MS on 2002/9/16
        public const ushort SYNC_CL_EVENT_ARB = 0x8240;
        public const ushort SYNC_CL_EVENT_COMPLETE_ARB = 0x8241;
        public const ushort DEBUG_OUTPUT_SYNCHRONOUS = 0x8242; // EnableCap
        public const ushort DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
        public const ushort DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242;
        public const ushort DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const ushort DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
        public const ushort DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243;
        public const ushort DEBUG_CALLBACK_FUNCTION = 0x8244; // GetPointervPName
        public const ushort DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
        public const ushort DEBUG_CALLBACK_FUNCTION_KHR = 0x8244;
        public const ushort DEBUG_CALLBACK_USER_PARAM = 0x8245; // GetPointervPName
        public const ushort DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
        public const ushort DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245;
        public const ushort DEBUG_SOURCE_API = 0x8246; // DebugSource
        public const ushort DEBUG_SOURCE_API_ARB = 0x8246;
        public const ushort DEBUG_SOURCE_API_KHR = 0x8246;
        public const ushort DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247; // DebugSource
        public const ushort DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
        public const ushort DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247;
        public const ushort DEBUG_SOURCE_SHADER_COMPILER = 0x8248; // DebugSource
        public const ushort DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
        public const ushort DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248;
        public const ushort DEBUG_SOURCE_THIRD_PARTY = 0x8249; // DebugSource
        public const ushort DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
        public const ushort DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249;
        public const ushort DEBUG_SOURCE_APPLICATION = 0x824A; // DebugSource
        public const ushort DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
        public const ushort DEBUG_SOURCE_APPLICATION_KHR = 0x824A;
        public const ushort DEBUG_SOURCE_OTHER = 0x824B; // DebugSource
        public const ushort DEBUG_SOURCE_OTHER_ARB = 0x824B;
        public const ushort DEBUG_SOURCE_OTHER_KHR = 0x824B;
        public const ushort DEBUG_TYPE_ERROR = 0x824C; // DebugType
        public const ushort DEBUG_TYPE_ERROR_ARB = 0x824C;
        public const ushort DEBUG_TYPE_ERROR_KHR = 0x824C;
        public const ushort DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D; // DebugType
        public const ushort DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
        public const ushort DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D;
        public const ushort DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E; // DebugType
        public const ushort DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
        public const ushort DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E;
        public const ushort DEBUG_TYPE_PORTABILITY = 0x824F; // DebugType
        public const ushort DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
        public const ushort DEBUG_TYPE_PORTABILITY_KHR = 0x824F;
        public const ushort DEBUG_TYPE_PERFORMANCE = 0x8250; // DebugType
        public const ushort DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
        public const ushort DEBUG_TYPE_PERFORMANCE_KHR = 0x8250;
        public const ushort DEBUG_TYPE_OTHER = 0x8251; // DebugType
        public const ushort DEBUG_TYPE_OTHER_ARB = 0x8251;
        public const ushort DEBUG_TYPE_OTHER_KHR = 0x8251;
        public const ushort LOSE_CONTEXT_ON_RESET = 0x8252;
        public const ushort LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
        public const ushort LOSE_CONTEXT_ON_RESET_EXT = 0x8252;
        public const ushort LOSE_CONTEXT_ON_RESET_KHR = 0x8252;
        public const ushort GUILTY_CONTEXT_RESET = 0x8253; // GraphicsResetStatus
        public const ushort GUILTY_CONTEXT_RESET_ARB = 0x8253;
        public const ushort GUILTY_CONTEXT_RESET_EXT = 0x8253;
        public const ushort GUILTY_CONTEXT_RESET_KHR = 0x8253;
        public const ushort INNOCENT_CONTEXT_RESET = 0x8254; // GraphicsResetStatus
        public const ushort INNOCENT_CONTEXT_RESET_ARB = 0x8254;
        public const ushort INNOCENT_CONTEXT_RESET_EXT = 0x8254;
        public const ushort INNOCENT_CONTEXT_RESET_KHR = 0x8254;
        public const ushort UNKNOWN_CONTEXT_RESET = 0x8255; // GraphicsResetStatus
        public const ushort UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
        public const ushort UNKNOWN_CONTEXT_RESET_EXT = 0x8255;
        public const ushort UNKNOWN_CONTEXT_RESET_KHR = 0x8255;
        public const ushort RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const ushort RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
        public const ushort RESET_NOTIFICATION_STRATEGY_EXT = 0x8256;
        public const ushort RESET_NOTIFICATION_STRATEGY_KHR = 0x8256;
        public const ushort PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257; // ProgramParameterPName,HintTarget
        public const ushort PROGRAM_SEPARABLE = 0x8258; // ProgramParameterPName
        public const ushort PROGRAM_SEPARABLE_EXT = 0x8258;
        public const ushort ACTIVE_PROGRAM = 0x8259; // PipelineParameterName
        public const ushort PROGRAM_PIPELINE_BINDING = 0x825A; // GetPName
        public const ushort PROGRAM_PIPELINE_BINDING_EXT = 0x825A;
        public const ushort MAX_VIEWPORTS = 0x825B; // GetPName
        public const ushort MAX_VIEWPORTS_NV = 0x825B;
        public const ushort MAX_VIEWPORTS_OES = 0x825B;
        public const ushort VIEWPORT_SUBPIXEL_BITS = 0x825C; // GetPName
        public const ushort VIEWPORT_SUBPIXEL_BITS_EXT = 0x825C;
        public const ushort VIEWPORT_SUBPIXEL_BITS_NV = 0x825C;
        public const ushort VIEWPORT_SUBPIXEL_BITS_OES = 0x825C;
        public const ushort VIEWPORT_BOUNDS_RANGE = 0x825D; // GetPName
        public const ushort VIEWPORT_BOUNDS_RANGE_EXT = 0x825D;
        public const ushort VIEWPORT_BOUNDS_RANGE_NV = 0x825D;
        public const ushort VIEWPORT_BOUNDS_RANGE_OES = 0x825D;
        public const ushort LAYER_PROVOKING_VERTEX = 0x825E; // GetPName
        public const ushort LAYER_PROVOKING_VERTEX_EXT = 0x825E;
        public const ushort LAYER_PROVOKING_VERTEX_OES = 0x825E;
        public const ushort VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F; // GetPName
        public const ushort VIEWPORT_INDEX_PROVOKING_VERTEX_EXT = 0x825F;
        public const ushort VIEWPORT_INDEX_PROVOKING_VERTEX_NV = 0x825F;
        public const ushort VIEWPORT_INDEX_PROVOKING_VERTEX_OES = 0x825F;
        public const ushort UNDEFINED_VERTEX = 0x8260;
        public const ushort UNDEFINED_VERTEX_EXT = 0x8260;
        public const ushort UNDEFINED_VERTEX_OES = 0x8260;
        public const ushort NO_RESET_NOTIFICATION = 0x8261;
        public const ushort NO_RESET_NOTIFICATION_ARB = 0x8261;
        public const ushort NO_RESET_NOTIFICATION_EXT = 0x8261;
        public const ushort NO_RESET_NOTIFICATION_KHR = 0x8261;
        public const ushort MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const ushort MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263; // GetPName
        public const ushort MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264; // GetPName
        public const ushort MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265; // GetPName
        public const ushort MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266; // GetPName
        public const ushort COMPUTE_WORK_GROUP_SIZE = 0x8267; // ProgramPropertyARB
        public const ushort DEBUG_TYPE_MARKER = 0x8268; // DebugType
        public const ushort DEBUG_TYPE_MARKER_KHR = 0x8268;
        public const ushort DEBUG_TYPE_PUSH_GROUP = 0x8269; // DebugType
        public const ushort DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269;
        public const ushort DEBUG_TYPE_POP_GROUP = 0x826A; // DebugType
        public const ushort DEBUG_TYPE_POP_GROUP_KHR = 0x826A;
        public const ushort DEBUG_SEVERITY_NOTIFICATION = 0x826B; // DebugSeverity
        public const ushort DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B;
        public const ushort MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C; // GetPName
        public const ushort MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C;
        public const ushort DEBUG_GROUP_STACK_DEPTH = 0x826D; // GetPName
        public const ushort DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D;
        public const ushort MAX_UNIFORM_LOCATIONS = 0x826E; // GetPName
        public const ushort INTERNALFORMAT_SUPPORTED = 0x826F; // InternalFormatPName
        public const ushort INTERNALFORMAT_PREFERRED = 0x8270; // InternalFormatPName
        public const ushort INTERNALFORMAT_RED_SIZE = 0x8271; // InternalFormatPName
        public const ushort INTERNALFORMAT_GREEN_SIZE = 0x8272; // InternalFormatPName
        public const ushort INTERNALFORMAT_BLUE_SIZE = 0x8273; // InternalFormatPName
        public const ushort INTERNALFORMAT_ALPHA_SIZE = 0x8274; // InternalFormatPName
        public const ushort INTERNALFORMAT_DEPTH_SIZE = 0x8275; // InternalFormatPName
        public const ushort INTERNALFORMAT_STENCIL_SIZE = 0x8276; // InternalFormatPName
        public const ushort INTERNALFORMAT_SHARED_SIZE = 0x8277; // InternalFormatPName
        public const ushort INTERNALFORMAT_RED_TYPE = 0x8278; // InternalFormatPName
        public const ushort INTERNALFORMAT_GREEN_TYPE = 0x8279; // InternalFormatPName
        public const ushort INTERNALFORMAT_BLUE_TYPE = 0x827A; // InternalFormatPName
        public const ushort INTERNALFORMAT_ALPHA_TYPE = 0x827B; // InternalFormatPName
        public const ushort INTERNALFORMAT_DEPTH_TYPE = 0x827C; // InternalFormatPName
        public const ushort INTERNALFORMAT_STENCIL_TYPE = 0x827D; // InternalFormatPName
        public const ushort MAX_WIDTH = 0x827E; // InternalFormatPName
        public const ushort MAX_HEIGHT = 0x827F; // InternalFormatPName
        public const ushort MAX_DEPTH = 0x8280; // InternalFormatPName
        public const ushort MAX_LAYERS = 0x8281; // InternalFormatPName
        public const ushort MAX_COMBINED_DIMENSIONS = 0x8282;
        public const ushort COLOR_COMPONENTS = 0x8283; // InternalFormatPName
        public const ushort DEPTH_COMPONENTS = 0x8284;
        public const ushort STENCIL_COMPONENTS = 0x8285;
        public const ushort COLOR_RENDERABLE = 0x8286; // InternalFormatPName
        public const ushort DEPTH_RENDERABLE = 0x8287; // InternalFormatPName
        public const ushort STENCIL_RENDERABLE = 0x8288; // InternalFormatPName
        public const ushort FRAMEBUFFER_RENDERABLE = 0x8289; // InternalFormatPName
        public const ushort FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A; // InternalFormatPName
        public const ushort FRAMEBUFFER_BLEND = 0x828B; // InternalFormatPName
        public const ushort READ_PIXELS = 0x828C; // InternalFormatPName
        public const ushort READ_PIXELS_FORMAT = 0x828D; // InternalFormatPName
        public const ushort READ_PIXELS_TYPE = 0x828E; // InternalFormatPName
        public const ushort TEXTURE_IMAGE_FORMAT = 0x828F; // InternalFormatPName
        public const ushort TEXTURE_IMAGE_TYPE = 0x8290; // InternalFormatPName
        public const ushort GET_TEXTURE_IMAGE_FORMAT = 0x8291; // InternalFormatPName
        public const ushort GET_TEXTURE_IMAGE_TYPE = 0x8292; // InternalFormatPName
        public const ushort MIPMAP = 0x8293; // InternalFormatPName
        public const ushort MANUAL_GENERATE_MIPMAP = 0x8294;
        // Should be deprecated
        public const ushort AUTO_GENERATE_MIPMAP = 0x8295; // InternalFormatPName
        public const ushort COLOR_ENCODING = 0x8296; // InternalFormatPName
        public const ushort SRGB_READ = 0x8297; // InternalFormatPName
        public const ushort SRGB_WRITE = 0x8298; // InternalFormatPName
        public const ushort SRGB_DECODE_ARB = 0x8299;
        public const ushort FILTER = 0x829A; // InternalFormatPName
        public const ushort VERTEX_TEXTURE = 0x829B; // InternalFormatPName
        public const ushort TESS_CONTROL_TEXTURE = 0x829C; // InternalFormatPName
        public const ushort TESS_EVALUATION_TEXTURE = 0x829D; // InternalFormatPName
        public const ushort GEOMETRY_TEXTURE = 0x829E; // InternalFormatPName
        public const ushort FRAGMENT_TEXTURE = 0x829F; // InternalFormatPName
        public const ushort COMPUTE_TEXTURE = 0x82A0; // InternalFormatPName
        public const ushort TEXTURE_SHADOW = 0x82A1; // InternalFormatPName
        public const ushort TEXTURE_GATHER = 0x82A2; // InternalFormatPName
        public const ushort TEXTURE_GATHER_SHADOW = 0x82A3; // InternalFormatPName
        public const ushort SHADER_IMAGE_LOAD = 0x82A4; // InternalFormatPName
        public const ushort SHADER_IMAGE_STORE = 0x82A5; // InternalFormatPName
        public const ushort SHADER_IMAGE_ATOMIC = 0x82A6; // InternalFormatPName
        public const ushort IMAGE_TEXEL_SIZE = 0x82A7; // InternalFormatPName
        public const ushort IMAGE_COMPATIBILITY_CLASS = 0x82A8; // InternalFormatPName
        public const ushort IMAGE_PIXEL_FORMAT = 0x82A9; // InternalFormatPName
        public const ushort IMAGE_PIXEL_TYPE = 0x82AA; // InternalFormatPName
        // Unused 0x82AB. 
        public const ushort SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC; // InternalFormatPName
        public const ushort SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD; // InternalFormatPName
        public const ushort SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE; // InternalFormatPName
        public const ushort SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF; // InternalFormatPName
        
        // . Range reclaimed from ADD on 2012/05/10
        // Unused 0x82B0. 
        public const ushort TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1; // InternalFormatPName
        public const ushort TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2; // InternalFormatPName
        public const ushort TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3; // InternalFormatPName
        public const ushort CLEAR_BUFFER = 0x82B4; // InternalFormatPName
        public const ushort TEXTURE_VIEW = 0x82B5; // InternalFormatPName
        public const ushort VIEW_COMPATIBILITY_CLASS = 0x82B6; // InternalFormatPName
        public const ushort FULL_SUPPORT = 0x82B7;
        public const ushort CAVEAT_SUPPORT = 0x82B8;
        public const ushort IMAGE_CLASS_4_X_32 = 0x82B9;
        public const ushort IMAGE_CLASS_2_X_32 = 0x82BA;
        public const ushort IMAGE_CLASS_1_X_32 = 0x82BB;
        public const ushort IMAGE_CLASS_4_X_16 = 0x82BC;
        public const ushort IMAGE_CLASS_2_X_16 = 0x82BD;
        public const ushort IMAGE_CLASS_1_X_16 = 0x82BE;
        public const ushort IMAGE_CLASS_4_X_8 = 0x82BF;
        public const ushort IMAGE_CLASS_2_X_8 = 0x82C0;
        public const ushort IMAGE_CLASS_1_X_8 = 0x82C1;
        public const ushort IMAGE_CLASS_11_11_10 = 0x82C2;
        public const ushort IMAGE_CLASS_10_10_10_2 = 0x82C3;
        public const ushort VIEW_CLASS_128_BITS = 0x82C4;
        public const ushort VIEW_CLASS_96_BITS = 0x82C5;
        public const ushort VIEW_CLASS_64_BITS = 0x82C6;
        public const ushort VIEW_CLASS_48_BITS = 0x82C7;
        public const ushort VIEW_CLASS_32_BITS = 0x82C8;
        public const ushort VIEW_CLASS_24_BITS = 0x82C9;
        public const ushort VIEW_CLASS_16_BITS = 0x82CA;
        public const ushort VIEW_CLASS_8_BITS = 0x82CB;
        public const ushort VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
        public const ushort VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
        public const ushort VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
        public const ushort VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
        public const ushort VIEW_CLASS_RGTC1_RED = 0x82D0;
        public const ushort VIEW_CLASS_RGTC2_RG = 0x82D1;
        public const ushort VIEW_CLASS_BPTC_UNORM = 0x82D2;
        public const ushort VIEW_CLASS_BPTC_FLOAT = 0x82D3;
        public const ushort VERTEX_ATTRIB_BINDING = 0x82D4; // VertexAttribPropertyARB
        public const ushort VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5; // VertexArrayPName,VertexAttribPropertyARB
        public const ushort VERTEX_BINDING_DIVISOR = 0x82D6; // GetPName
        public const ushort VERTEX_BINDING_OFFSET = 0x82D7; // GetPName
        public const ushort VERTEX_BINDING_STRIDE = 0x82D8; // GetPName
        public const ushort MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9; // GetPName
        public const ushort MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA; // GetPName
        public const ushort TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
        public const ushort TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB;
        public const ushort TEXTURE_VIEW_MIN_LEVEL_OES = 0x82DB;
        public const ushort TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
        public const ushort TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC;
        public const ushort TEXTURE_VIEW_NUM_LEVELS_OES = 0x82DC;
        public const ushort TEXTURE_VIEW_MIN_LAYER = 0x82DD;
        public const ushort TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD;
        public const ushort TEXTURE_VIEW_MIN_LAYER_OES = 0x82DD;
        public const ushort TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
        public const ushort TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE;
        public const ushort TEXTURE_VIEW_NUM_LAYERS_OES = 0x82DE;
        public const ushort TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
        public const ushort BUFFER = 0x82E0; // ObjectIdentifier
        public const ushort BUFFER_KHR = 0x82E0;
        public const ushort SHADER = 0x82E1; // ObjectIdentifier
        public const ushort SHADER_KHR = 0x82E1;
        public const ushort PROGRAM = 0x82E2; // ObjectIdentifier
        public const ushort PROGRAM_KHR = 0x82E2;
        public const ushort QUERY = 0x82E3; // ObjectIdentifier
        public const ushort QUERY_KHR = 0x82E3;
        public const ushort PROGRAM_PIPELINE = 0x82E4; // ObjectIdentifier
        public const ushort PROGRAM_PIPELINE_KHR = 0x82E4;
        public const ushort MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
        public const ushort SAMPLER = 0x82E6; // ObjectIdentifier
        public const ushort SAMPLER_KHR = 0x82E6;
        public const ushort DISPLAY_LIST = 0x82E7;
        public const ushort MAX_LABEL_LENGTH = 0x82E8; // GetPName
        public const ushort MAX_LABEL_LENGTH_KHR = 0x82E8;
        public const ushort NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
        public const ushort QUERY_TARGET = 0x82EA; // QueryObjectParameterName
        // Unused 0x82EB. Reserved. Formerly used for GL_TEXTURE_BINDING.
        public const ushort TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC; // QueryTarget
        // Alias of GL_TRANSFORM_FEEDBACK_OVERFLOW
        public const ushort TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;
        public const ushort TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
        // Alias of GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW
        public const ushort TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;
        public const ushort VERTICES_SUBMITTED = 0x82EE; // QueryTarget
        // Alias of GL_VERTICES_SUBMITTED
        public const ushort VERTICES_SUBMITTED_ARB = 0x82EE;
        public const ushort PRIMITIVES_SUBMITTED = 0x82EF; // QueryTarget
        // Alias of GL_PRIMITIVES_SUBMITTED
        public const ushort PRIMITIVES_SUBMITTED_ARB = 0x82EF;
        public const ushort VERTEX_SHADER_INVOCATIONS = 0x82F0; // QueryTarget
        // Alias of GL_VERTEX_SHADER_INVOCATIONS
        public const ushort VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;
        public const ushort TESS_CONTROL_SHADER_PATCHES = 0x82F1;
        // Alias of GL_TESS_CONTROL_SHADER_PATCHES
        public const ushort TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;
        public const ushort TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
        // Alias of GL_TESS_EVALUATION_SHADER_INVOCATIONS
        public const ushort TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;
        public const ushort GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
        // Alias of GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED
        public const ushort GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;
        public const ushort FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
        // Alias of GL_FRAGMENT_SHADER_INVOCATIONS
        public const ushort FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;
        public const ushort COMPUTE_SHADER_INVOCATIONS = 0x82F5;
        // Alias of GL_COMPUTE_SHADER_INVOCATIONS
        public const ushort COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;
        public const ushort CLIPPING_INPUT_PRIMITIVES = 0x82F6;
        // Alias of GL_CLIPPING_INPUT_PRIMITIVES
        public const ushort CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;
        public const ushort CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
        // Alias of GL_CLIPPING_OUTPUT_PRIMITIVES
        public const ushort CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;
        public const ushort SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
        public const ushort MAX_CULL_DISTANCES = 0x82F9;
        // Alias of GL_MAX_CULL_DISTANCES
        public const ushort MAX_CULL_DISTANCES_EXT = 0x82F9;
        public const ushort MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
        // Alias of GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES
        public const ushort MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT = 0x82FA;
        public const ushort CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
        public const ushort CONTEXT_RELEASE_BEHAVIOR_KHR = 0x82FB;
        public const ushort CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
        public const ushort CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR = 0x82FC;
        // Reserved for future
        public const ushort ROBUST_GPU_TIMEOUT_MS_KHR = 0x82FD;
        // Unused 0x82FE..0x830F. 
        
        // . 
        public const ushort DEPTH_PASS_INSTRUMENT_SGIX = 0x8310;
        public const ushort DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX = 0x8311;
        public const ushort DEPTH_PASS_INSTRUMENT_MAX_SGIX = 0x8312;
        public const ushort FRAGMENTS_INSTRUMENT_SGIX = 0x8313;
        public const ushort FRAGMENTS_INSTRUMENT_COUNTERS_SGIX = 0x8314;
        public const ushort FRAGMENTS_INSTRUMENT_MAX_SGIX = 0x8315;
        public const ushort CONVOLUTION_HINT_SGIX = 0x8316; // HintTarget,GetPName
        // Unused 0x8317. Incomplete extension SGIX_color_matrix_accuracy
        public const ushort YCRCB_SGIX = 0x8318;
        public const ushort YCRCBA_SGIX = 0x8319;
        public const ushort UNPACK_COMPRESSED_SIZE_SGIX = 0x831A;
        public const ushort PACK_MAX_COMPRESSED_SIZE_SGIX = 0x831B;
        public const ushort PACK_COMPRESSED_SIZE_SGIX = 0x831C;
        public const ushort SLIM8U_SGIX = 0x831D;
        public const ushort SLIM10U_SGIX = 0x831E;
        public const ushort SLIM12S_SGIX = 0x831F;
        public const ushort ALPHA_MIN_SGIX = 0x8320; // BlendEquationModeEXT
        public const ushort ALPHA_MAX_SGIX = 0x8321; // BlendEquationModeEXT
        public const ushort SCALEBIAS_HINT_SGIX = 0x8322; // HintTarget
        // Unused 0x8323..0x8328. Incomplete extension SGIX_fog_layers
        public const ushort ASYNC_MARKER_SGIX = 0x8329; // GetPName
        // Unused 0x832A. Incomplete extension SGIX_texture_phase
        public const ushort PIXEL_TEX_GEN_MODE_SGIX = 0x832B; // GetPName
        public const ushort ASYNC_HISTOGRAM_SGIX = 0x832C; // GetPName,EnableCap
        public const ushort MAX_ASYNC_HISTOGRAM_SGIX = 0x832D; // GetPName
        // Unused 0x832E..0x832F. Incomplete extension SGIX_texture_mipmap_anisotropic
        
        // . 
        public const ushort PIXEL_TRANSFORM_2D_EXT = 0x8330; // PixelTransformTargetEXT
        public const ushort PIXEL_MAG_FILTER_EXT = 0x8331; // PixelTransformPNameEXT
        public const ushort PIXEL_MIN_FILTER_EXT = 0x8332; // PixelTransformPNameEXT
        public const ushort PIXEL_CUBIC_WEIGHT_EXT = 0x8333; // PixelTransformPNameEXT
        public const ushort CUBIC_EXT = 0x8334;
        public const ushort AVERAGE_EXT = 0x8335;
        public const ushort PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
        public const ushort MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
        public const ushort PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
        // Unused 0x8339..0x833F. 
        
        // . 
        // Unused 0x8340..0x8348. Incomplete extension SGIX_cube_map
        public const ushort FRAGMENT_MATERIAL_EXT = 0x8349; // LightTextureModeEXT
        public const ushort FRAGMENT_NORMAL_EXT = 0x834A; // LightTextureModeEXT
        public const ushort FRAGMENT_COLOR_EXT = 0x834C; // LightTextureModeEXT
        public const ushort ATTENUATION_EXT = 0x834D; // LightTexturePNameEXT
        public const ushort SHADOW_ATTENUATION_EXT = 0x834E; // LightTexturePNameEXT
        public const ushort TEXTURE_APPLICATION_MODE_EXT = 0x834F;
        public const ushort TEXTURE_LIGHT_EXT = 0x8350;
        public const ushort TEXTURE_MATERIAL_FACE_EXT = 0x8351;
        public const ushort TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
        public const ushort PIXEL_TEXTURE_SGIS = 0x8353; // GetPName,EnableCap
        public const ushort PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354; // PixelTexGenParameterNameSGIS
        public const ushort PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355; // PixelTexGenParameterNameSGIS
        public const ushort PIXEL_GROUP_COLOR_SGIS = 0x8356;
        // Unused 0x8357..0x8359. Incomplete extension SGIX_pixel_texture_bits
        // Unused 0x835A. Incomplete extension SGIX_pixel_texture_lod
        public const ushort LINE_QUALITY_HINT_SGIX = 0x835B; // HintTarget
        public const ushort ASYNC_TEX_IMAGE_SGIX = 0x835C; // GetPName,EnableCap
        public const ushort ASYNC_DRAW_PIXELS_SGIX = 0x835D; // GetPName,EnableCap
        public const ushort ASYNC_READ_PIXELS_SGIX = 0x835E; // GetPName,EnableCap
        public const ushort MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F; // GetPName
        public const ushort MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360; // GetPName
        public const ushort MAX_ASYNC_READ_PIXELS_SGIX = 0x8361; // GetPName
        public const ushort UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const ushort UNSIGNED_BYTE_2_3_3_REV_EXT = 0x8362;
        public const ushort UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const ushort UNSIGNED_SHORT_5_6_5_EXT = 0x8363;
        public const ushort UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const ushort UNSIGNED_SHORT_5_6_5_REV_EXT = 0x8364;
        public const ushort UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const ushort UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365;
        public const ushort UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365;
        public const ushort UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const ushort UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366;
        public const ushort UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const ushort UNSIGNED_INT_8_8_8_8_REV_EXT = 0x8367;
        public const ushort UNSIGNED_INT_2_10_10_10_REV = 0x8368; // VertexAttribPointerType,VertexAttribType
        public const ushort UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368;
        public const ushort TEXTURE_MAX_CLAMP_S_SGIX = 0x8369; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_MAX_CLAMP_T_SGIX = 0x836A; // TextureParameterName,GetTextureParameter
        public const ushort TEXTURE_MAX_CLAMP_R_SGIX = 0x836B; // TextureParameterName,GetTextureParameter
        // Unused 0x836C..0x836E. Incomplete extension SGIX_fog_texture
        // Unused 0x836F. Incomplete extension SGIX_fog_factor_to_alpha
        
        // . 
        public const ushort MIRRORED_REPEAT = 0x8370; // TextureWrapMode
        public const ushort MIRRORED_REPEAT_ARB = 0x8370;
        public const ushort MIRRORED_REPEAT_IBM = 0x8370;
        public const ushort MIRRORED_REPEAT_OES = 0x8370;
        // Unused 0x8371..0x837F. 
        
        // . 
        // Unused 0x8380..0x839F. 
        
        // . 
        public const ushort RGB_S3TC = 0x83A0;
        public const ushort RGB4_S3TC = 0x83A1;
        public const ushort RGBA_S3TC = 0x83A2;
        public const ushort RGBA4_S3TC = 0x83A3;
        public const ushort RGBA_DXT5_S3TC = 0x83A4;
        public const ushort RGBA4_DXT5_S3TC = 0x83A5;
        // Unused 0x83A6..0x83BF. 
        
        // . Most of this could be reclaimed
        // Unused 0x83C0..0x83CA. Withdrawn extension SGIS_multitexture
        // Unused 0x83CB..0x83E5. 
        // Unused 0x83E6..0x83E9. Incomplete extension SGIX_bali_g_instruments
        // Unused 0x83EA..0x83EC. Incomplete extension SGIX_bali_r_instruments
        // Unused 0x83ED. Incomplete extension SGIX_occlusion_instrument
        public const ushort VERTEX_PRECLIP_SGIX = 0x83EE; // HintTarget,GetPName
        public const ushort VERTEX_PRECLIP_HINT_SGIX = 0x83EF; // HintTarget,GetPName
        
        // . 
        public const ushort COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0; // InternalFormat
        public const ushort COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1; // InternalFormat
        public const ushort COMPRESSED_RGBA_S3TC_DXT3_ANGLE = 0x83F2;
        public const ushort COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2; // InternalFormat
        public const ushort COMPRESSED_RGBA_S3TC_DXT5_ANGLE = 0x83F3;
        public const ushort COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3; // InternalFormat
        public const ushort PARALLEL_ARRAYS_INTEL = 0x83F4;
        public const ushort VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;
        public const ushort NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;
        public const ushort COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;
        public const ushort TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;
        public const ushort PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;
        public const ushort PERFQUERY_FLUSH_INTEL = 0x83FA;
        public const ushort PERFQUERY_WAIT_INTEL = 0x83FB;
        public const ushort BLACKHOLE_RENDER_INTEL = 0x83FC;
        // Unused 0x83FD. 
        public const ushort CONSERVATIVE_RASTERIZATION_INTEL = 0x83FE;
        public const ushort TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;
        
        // . 
        public const ushort FRAGMENT_LIGHTING_SGIX = 0x8400; // GetPName,EnableCap
        public const ushort FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401; // GetPName,EnableCap
        public const ushort FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402; // GetPName
        public const ushort FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403; // GetPName
        public const ushort MAX_FRAGMENT_LIGHTS_SGIX = 0x8404; // GetPName
        public const ushort MAX_ACTIVE_LIGHTS_SGIX = 0x8405; // GetPName
        public const ushort CURRENT_RASTER_NORMAL_SGIX = 0x8406;
        public const ushort LIGHT_ENV_MODE_SGIX = 0x8407; // LightEnvParameterSGIX,GetPName
        public const ushort FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408; // GetPName,FragmentLightModelParameterSGIX
        public const ushort FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409; // GetPName,FragmentLightModelParameterSGIX
        public const ushort FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A; // GetPName,FragmentLightModelParameterSGIX
        public const ushort FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B; // GetPName,FragmentLightModelParameterSGIX
        public const ushort FRAGMENT_LIGHT0_SGIX = 0x840C; // LightName,FragmentLightNameSGIX,EnableCap,GetPName
        public const ushort FRAGMENT_LIGHT1_SGIX = 0x840D; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT2_SGIX = 0x840E; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT3_SGIX = 0x840F; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT4_SGIX = 0x8410; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT5_SGIX = 0x8411; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT6_SGIX = 0x8412; // LightName,FragmentLightNameSGIX,EnableCap
        public const ushort FRAGMENT_LIGHT7_SGIX = 0x8413; // LightName,FragmentLightNameSGIX,EnableCap
        // Unused 0x8414..0x842D. 
        // Formerly 0x842C in SGI specfile
        public const ushort PACK_RESAMPLE_SGIX = 0x842E; // PixelStoreParameter,GetPName
        // Formerly 0x842D in SGI specfile
        public const ushort UNPACK_RESAMPLE_SGIX = 0x842F; // PixelStoreParameter,GetPName
        // Formerly 0x8430 in SGI specfile
        public const ushort RESAMPLE_DECIMATE_SGIX = 0x8430; // PixelStoreResampleMode
        // Unused 0x8431..0x8432. 
        // Formerly 0x842E in SGI specfile
        public const ushort RESAMPLE_REPLICATE_SGIX = 0x8433; // PixelStoreResampleMode
        // Formerly 0x842F in SGI specfile
        public const ushort RESAMPLE_ZERO_FILL_SGIX = 0x8434; // PixelStoreResampleMode
        // Unused 0x8435. 
        public const ushort TANGENT_ARRAY_EXT = 0x8439;
        public const ushort BINORMAL_ARRAY_EXT = 0x843A;
        public const ushort CURRENT_TANGENT_EXT = 0x843B;
        public const ushort CURRENT_BINORMAL_EXT = 0x843C;
        // Unused 0x844D. 
        public const ushort TANGENT_ARRAY_TYPE_EXT = 0x843E;
        public const ushort TANGENT_ARRAY_STRIDE_EXT = 0x843F;
        public const ushort BINORMAL_ARRAY_TYPE_EXT = 0x8440;
        public const ushort BINORMAL_ARRAY_STRIDE_EXT = 0x8441;
        public const ushort TANGENT_ARRAY_POINTER_EXT = 0x8442;
        public const ushort BINORMAL_ARRAY_POINTER_EXT = 0x8443;
        public const ushort MAP1_TANGENT_EXT = 0x8444;
        public const ushort MAP2_TANGENT_EXT = 0x8445;
        public const ushort MAP1_BINORMAL_EXT = 0x8446;
        public const ushort MAP2_BINORMAL_EXT = 0x8447;
        // Unused 0x8448..0x8449. Incomplete extension SGIX_fragment_lighting
        // Unused 0x844A..0x844C. Incomplete extension SGIX_bali_timer_instruments
        public const ushort NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D; // TextureMinFilter
        public const ushort NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E; // TextureMinFilter
        public const ushort LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F; // TextureMinFilter
        public const ushort FOG_COORDINATE_SOURCE = 0x8450;
        public const ushort FOG_COORDINATE_SOURCE_EXT = 0x8450;
        // Alias of GL_FOG_COORDINATE_SOURCE
        public const ushort FOG_COORD_SRC = 0x8450; // FogPName
        public const ushort FOG_COORDINATE = 0x8451;
        // Alias of GL_FOG_COORDINATE
        public const ushort FOG_COORD = 0x8451;
        public const ushort FOG_COORDINATE_EXT = 0x8451;
        public const ushort FRAGMENT_DEPTH = 0x8452;
        public const ushort FRAGMENT_DEPTH_EXT = 0x8452; // LightTextureModeEXT
        public const ushort CURRENT_FOG_COORDINATE = 0x8453;
        // Alias of GL_CURRENT_FOG_COORDINATE
        public const ushort CURRENT_FOG_COORD = 0x8453;
        public const ushort CURRENT_FOG_COORDINATE_EXT = 0x8453;
        public const ushort FOG_COORDINATE_ARRAY_TYPE = 0x8454;
        public const ushort FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
        // Alias of GL_FOG_COORDINATE_ARRAY_TYPE
        public const ushort FOG_COORD_ARRAY_TYPE = 0x8454;
        public const ushort FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
        public const ushort FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
        // Alias of GL_FOG_COORDINATE_ARRAY_STRIDE
        public const ushort FOG_COORD_ARRAY_STRIDE = 0x8455;
        public const ushort FOG_COORDINATE_ARRAY_POINTER = 0x8456;
        public const ushort FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
        // Alias of GL_FOG_COORDINATE_ARRAY_POINTER
        public const ushort FOG_COORD_ARRAY_POINTER = 0x8456;
        public const ushort FOG_COORDINATE_ARRAY = 0x8457;
        public const ushort FOG_COORDINATE_ARRAY_EXT = 0x8457;
        // Alias of GL_FOG_COORDINATE_ARRAY
        public const ushort FOG_COORD_ARRAY = 0x8457;
        public const ushort COLOR_SUM = 0x8458;
        public const ushort COLOR_SUM_ARB = 0x8458;
        public const ushort COLOR_SUM_EXT = 0x8458;
        public const ushort CURRENT_SECONDARY_COLOR = 0x8459;
        public const ushort CURRENT_SECONDARY_COLOR_EXT = 0x8459;
        public const ushort SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
        public const ushort SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
        public const ushort SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
        public const ushort SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
        public const ushort SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
        public const ushort SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
        public const ushort SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
        public const ushort SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
        public const ushort SECONDARY_COLOR_ARRAY = 0x845E;
        public const ushort SECONDARY_COLOR_ARRAY_EXT = 0x845E;
        public const ushort CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
        // Unused 0x8460..0x846B. Incomplete extension SGIX_icc_texture
        // Unused 0x846C. 
        public const ushort ALIASED_POINT_SIZE_RANGE = 0x846D; // GetPName
        public const ushort ALIASED_LINE_WIDTH_RANGE = 0x846E; // GetPName
        // Unused 0x846F. 
        
        // . 
        // Unused 0x8470..0x848F. 
        
        // . 
        public const ushort SCREEN_COORDINATES_REND = 0x8490;
        public const ushort INVERTED_SCREEN_W_REND = 0x8491;
        // Unused 0x8492..0x849F. 
        
        // . 
        // Unused 0x84A0..0x84BF. 
        
        // . 
        public const ushort TEXTURE0 = 0x84C0; // TextureUnit
        public const ushort TEXTURE0_ARB = 0x84C0; // CombinerRegisterNV
        public const ushort TEXTURE1 = 0x84C1; // TextureUnit
        public const ushort TEXTURE1_ARB = 0x84C1; // CombinerRegisterNV
        public const ushort TEXTURE2 = 0x84C2; // TextureUnit
        public const ushort TEXTURE2_ARB = 0x84C2;
        public const ushort TEXTURE3 = 0x84C3; // TextureUnit
        public const ushort TEXTURE3_ARB = 0x84C3;
        public const ushort TEXTURE4 = 0x84C4; // TextureUnit
        public const ushort TEXTURE4_ARB = 0x84C4;
        public const ushort TEXTURE5 = 0x84C5; // TextureUnit
        public const ushort TEXTURE5_ARB = 0x84C5;
        public const ushort TEXTURE6 = 0x84C6; // TextureUnit
        public const ushort TEXTURE6_ARB = 0x84C6;
        public const ushort TEXTURE7 = 0x84C7; // TextureUnit
        public const ushort TEXTURE7_ARB = 0x84C7;
        public const ushort TEXTURE8 = 0x84C8; // TextureUnit
        public const ushort TEXTURE8_ARB = 0x84C8;
        public const ushort TEXTURE9 = 0x84C9; // TextureUnit
        public const ushort TEXTURE9_ARB = 0x84C9;
        public const ushort TEXTURE10 = 0x84CA; // TextureUnit
        public const ushort TEXTURE10_ARB = 0x84CA;
        public const ushort TEXTURE11 = 0x84CB; // TextureUnit
        public const ushort TEXTURE11_ARB = 0x84CB;
        public const ushort TEXTURE12 = 0x84CC; // TextureUnit
        public const ushort TEXTURE12_ARB = 0x84CC;
        public const ushort TEXTURE13 = 0x84CD; // TextureUnit
        public const ushort TEXTURE13_ARB = 0x84CD;
        public const ushort TEXTURE14 = 0x84CE; // TextureUnit
        public const ushort TEXTURE14_ARB = 0x84CE;
        public const ushort TEXTURE15 = 0x84CF; // TextureUnit
        public const ushort TEXTURE15_ARB = 0x84CF;
        public const ushort TEXTURE16 = 0x84D0; // TextureUnit
        public const ushort TEXTURE16_ARB = 0x84D0;
        public const ushort TEXTURE17 = 0x84D1; // TextureUnit
        public const ushort TEXTURE17_ARB = 0x84D1;
        public const ushort TEXTURE18 = 0x84D2; // TextureUnit
        public const ushort TEXTURE18_ARB = 0x84D2;
        public const ushort TEXTURE19 = 0x84D3; // TextureUnit
        public const ushort TEXTURE19_ARB = 0x84D3;
        public const ushort TEXTURE20 = 0x84D4; // TextureUnit
        public const ushort TEXTURE20_ARB = 0x84D4;
        public const ushort TEXTURE21 = 0x84D5; // TextureUnit
        public const ushort TEXTURE21_ARB = 0x84D5;
        public const ushort TEXTURE22 = 0x84D6; // TextureUnit
        public const ushort TEXTURE22_ARB = 0x84D6;
        public const ushort TEXTURE23 = 0x84D7; // TextureUnit
        public const ushort TEXTURE23_ARB = 0x84D7;
        public const ushort TEXTURE24 = 0x84D8; // TextureUnit
        public const ushort TEXTURE24_ARB = 0x84D8;
        public const ushort TEXTURE25 = 0x84D9; // TextureUnit
        public const ushort TEXTURE25_ARB = 0x84D9;
        public const ushort TEXTURE26 = 0x84DA; // TextureUnit
        public const ushort TEXTURE26_ARB = 0x84DA;
        public const ushort TEXTURE27 = 0x84DB; // TextureUnit
        public const ushort TEXTURE27_ARB = 0x84DB;
        public const ushort TEXTURE28 = 0x84DC; // TextureUnit
        public const ushort TEXTURE28_ARB = 0x84DC;
        public const ushort TEXTURE29 = 0x84DD; // TextureUnit
        public const ushort TEXTURE29_ARB = 0x84DD;
        public const ushort TEXTURE30 = 0x84DE; // TextureUnit
        public const ushort TEXTURE30_ARB = 0x84DE;
        public const ushort TEXTURE31 = 0x84DF; // TextureUnit
        public const ushort TEXTURE31_ARB = 0x84DF;
        public const ushort ACTIVE_TEXTURE = 0x84E0; // GetPName
        public const ushort ACTIVE_TEXTURE_ARB = 0x84E0;
        public const ushort CLIENT_ACTIVE_TEXTURE = 0x84E1;
        public const ushort CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
        public const ushort MAX_TEXTURE_UNITS = 0x84E2;
        public const ushort MAX_TEXTURE_UNITS_ARB = 0x84E2;
        public const ushort TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        public const ushort TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        public const ushort PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3;
        public const ushort TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        public const ushort TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        public const ushort PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4;
        public const ushort TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        public const ushort TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        public const ushort TRANSPOSE_COLOR_MATRIX = 0x84E6;
        public const ushort TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
        public const ushort SUBTRACT = 0x84E7;
        public const ushort SUBTRACT_ARB = 0x84E7;
        public const ushort MAX_RENDERBUFFER_SIZE = 0x84E8; // GetPName
        public const ushort MAX_RENDERBUFFER_SIZE_EXT = 0x84E8;
        public const ushort MAX_RENDERBUFFER_SIZE_OES = 0x84E8;
        public const ushort COMPRESSED_ALPHA = 0x84E9;
        public const ushort COMPRESSED_ALPHA_ARB = 0x84E9;
        public const ushort COMPRESSED_LUMINANCE = 0x84EA;
        public const ushort COMPRESSED_LUMINANCE_ARB = 0x84EA;
        public const ushort COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        public const ushort COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
        public const ushort COMPRESSED_INTENSITY = 0x84EC;
        public const ushort COMPRESSED_INTENSITY_ARB = 0x84EC;
        public const ushort COMPRESSED_RGB = 0x84ED; // InternalFormat
        public const ushort COMPRESSED_RGB_ARB = 0x84ED;
        public const ushort COMPRESSED_RGBA = 0x84EE; // InternalFormat
        public const ushort COMPRESSED_RGBA_ARB = 0x84EE;
        public const ushort TEXTURE_COMPRESSION_HINT = 0x84EF; // HintTarget,GetPName
        public const ushort TEXTURE_COMPRESSION_HINT_ARB = 0x84EF; // HintTarget
        
        // . 
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1; // UniformBlockPName
        public const ushort ALL_COMPLETED_NV = 0x84F2; // FenceConditionNV
        public const ushort FENCE_STATUS_NV = 0x84F3; // FenceParameterNameNV
        public const ushort FENCE_CONDITION_NV = 0x84F4; // FenceParameterNameNV
        public const ushort TEXTURE_RECTANGLE = 0x84F5; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_RECTANGLE_ARB = 0x84F5;
        public const ushort TEXTURE_RECTANGLE_NV = 0x84F5;
        public const ushort TEXTURE_BINDING_RECTANGLE = 0x84F6; // GetPName
        public const ushort TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
        public const ushort TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
        public const ushort PROXY_TEXTURE_RECTANGLE = 0x84F7; // TextureTarget
        public const ushort PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7; // TextureTarget
        public const ushort PROXY_TEXTURE_RECTANGLE_NV = 0x84F7; // TextureTarget
        public const ushort MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8; // GetPName
        public const ushort MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;
        public const ushort MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
        public const ushort DEPTH_STENCIL = 0x84F9; // InternalFormat,PixelFormat
        public const ushort DEPTH_STENCIL_EXT = 0x84F9; // InternalFormat
        public const ushort DEPTH_STENCIL_NV = 0x84F9; // InternalFormat
        public const ushort DEPTH_STENCIL_OES = 0x84F9; // InternalFormat
        public const ushort UNSIGNED_INT_24_8 = 0x84FA;
        public const ushort UNSIGNED_INT_24_8_EXT = 0x84FA;
        public const ushort UNSIGNED_INT_24_8_NV = 0x84FA;
        public const ushort UNSIGNED_INT_24_8_OES = 0x84FA;
        // Unused 0x84FB..0x84FC. 
        public const ushort MAX_TEXTURE_LOD_BIAS = 0x84FD; // GetPName
        public const ushort MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
        public const ushort TEXTURE_MAX_ANISOTROPY = 0x84FE; // SamplerParameterF
        // Alias of GL_TEXTURE_MAX_ANISOTROPY
        public const ushort TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        public const ushort MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
        // Alias of GL_MAX_TEXTURE_MAX_ANISOTROPY
        public const ushort MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
        public const ushort TEXTURE_FILTER_CONTROL = 0x8500;
        public const ushort TEXTURE_FILTER_CONTROL_EXT = 0x8500;
        public const ushort TEXTURE_LOD_BIAS = 0x8501; // TextureParameterName,SamplerParameterF
        public const ushort TEXTURE_LOD_BIAS_EXT = 0x8501;
        public const ushort MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
        public const ushort COMBINE4_NV = 0x8503;
        public const ushort MAX_SHININESS_NV = 0x8504;
        public const ushort MAX_SPOT_EXPONENT_NV = 0x8505;
        public const ushort MODELVIEW1_MATRIX_EXT = 0x8506;
        public const ushort INCR_WRAP = 0x8507; // StencilOp
        public const ushort INCR_WRAP_EXT = 0x8507;
        public const ushort INCR_WRAP_OES = 0x8507;
        public const ushort DECR_WRAP = 0x8508; // StencilOp
        public const ushort DECR_WRAP_EXT = 0x8508;
        public const ushort DECR_WRAP_OES = 0x8508;
        public const ushort VERTEX_WEIGHTING_EXT = 0x8509;
        public const ushort MODELVIEW1_ARB = 0x850A;
        public const ushort MODELVIEW1_EXT = 0x850A;
        public const ushort CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
        public const ushort VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
        public const ushort VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
        public const ushort VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
        public const ushort VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
        public const ushort VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;
        public const ushort NORMAL_MAP = 0x8511;
        public const ushort NORMAL_MAP_ARB = 0x8511;
        public const ushort NORMAL_MAP_EXT = 0x8511;
        public const ushort NORMAL_MAP_NV = 0x8511;
        public const ushort NORMAL_MAP_OES = 0x8511;
        public const ushort REFLECTION_MAP = 0x8512;
        public const ushort REFLECTION_MAP_ARB = 0x8512;
        public const ushort REFLECTION_MAP_EXT = 0x8512;
        public const ushort REFLECTION_MAP_NV = 0x8512;
        public const ushort REFLECTION_MAP_OES = 0x8512;
        public const ushort TEXTURE_CUBE_MAP = 0x8513; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_CUBE_MAP_ARB = 0x8513;
        public const ushort TEXTURE_CUBE_MAP_EXT = 0x8513;
        public const ushort TEXTURE_CUBE_MAP_OES = 0x8513;
        public const ushort TEXTURE_BINDING_CUBE_MAP = 0x8514; // GetPName
        public const ushort TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
        public const ushort TEXTURE_BINDING_CUBE_MAP_EXT = 0x8514;
        public const ushort TEXTURE_BINDING_CUBE_MAP_OES = 0x8514;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
        public const ushort TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
        public const ushort TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A;
        public const ushort PROXY_TEXTURE_CUBE_MAP = 0x851B; // TextureTarget
        public const ushort PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B; // TextureTarget
        public const ushort PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B; // TextureTarget
        public const ushort MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C; // GetPName
        public const ushort MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;
        public const ushort MAX_CUBE_MAP_TEXTURE_SIZE_EXT = 0x851C;
        public const ushort MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C;
        public const ushort VERTEX_ARRAY_RANGE_APPLE = 0x851D;
        public const ushort VERTEX_ARRAY_RANGE_NV = 0x851D;
        public const ushort VERTEX_ARRAY_RANGE_LENGTH_APPLE = 0x851E;
        public const ushort VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
        public const ushort VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
        public const ushort VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F; // HintTarget
        public const ushort MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
        public const ushort VERTEX_ARRAY_RANGE_POINTER_APPLE = 0x8521;
        public const ushort VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
        public const ushort REGISTER_COMBINERS_NV = 0x8522;
        public const ushort VARIABLE_A_NV = 0x8523; // CombinerVariableNV
        public const ushort VARIABLE_B_NV = 0x8524; // CombinerVariableNV
        public const ushort VARIABLE_C_NV = 0x8525; // CombinerVariableNV
        public const ushort VARIABLE_D_NV = 0x8526; // CombinerVariableNV
        public const ushort VARIABLE_E_NV = 0x8527; // CombinerVariableNV
        public const ushort VARIABLE_F_NV = 0x8528; // CombinerVariableNV
        public const ushort VARIABLE_G_NV = 0x8529; // CombinerVariableNV
        public const ushort CONSTANT_COLOR0_NV = 0x852A;
        public const ushort CONSTANT_COLOR1_NV = 0x852B;
        public const ushort PRIMARY_COLOR_NV = 0x852C; // PathColor,CombinerRegisterNV
        public const ushort SECONDARY_COLOR_NV = 0x852D; // PathColor,CombinerRegisterNV
        public const ushort SPARE0_NV = 0x852E; // CombinerRegisterNV
        public const ushort SPARE1_NV = 0x852F; // CombinerRegisterNV
        public const ushort DISCARD_NV = 0x8530; // CombinerRegisterNV
        public const ushort E_TIMES_F_NV = 0x8531;
        public const ushort SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
        public const ushort VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
        public const ushort MULTISAMPLE_FILTER_HINT_NV = 0x8534; // HintTarget
        public const ushort PER_STAGE_CONSTANTS_NV = 0x8535;
        public const ushort UNSIGNED_IDENTITY_NV = 0x8536; // CombinerMappingNV
        public const ushort UNSIGNED_INVERT_NV = 0x8537; // CombinerMappingNV
        public const ushort EXPAND_NORMAL_NV = 0x8538; // CombinerMappingNV
        public const ushort EXPAND_NEGATE_NV = 0x8539; // CombinerMappingNV
        public const ushort HALF_BIAS_NORMAL_NV = 0x853A; // CombinerMappingNV
        public const ushort HALF_BIAS_NEGATE_NV = 0x853B; // CombinerMappingNV
        public const ushort SIGNED_IDENTITY_NV = 0x853C; // CombinerMappingNV
        public const ushort SIGNED_NEGATE_NV = 0x853D; // CombinerMappingNV
        public const ushort SCALE_BY_TWO_NV = 0x853E; // CombinerScaleNV
        public const ushort SCALE_BY_FOUR_NV = 0x853F; // CombinerScaleNV
        public const ushort SCALE_BY_ONE_HALF_NV = 0x8540; // CombinerScaleNV
        public const ushort BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541; // CombinerBiasNV
        public const ushort COMBINER_INPUT_NV = 0x8542; // CombinerParameterNV
        public const ushort COMBINER_MAPPING_NV = 0x8543; // CombinerParameterNV
        public const ushort COMBINER_COMPONENT_USAGE_NV = 0x8544; // CombinerParameterNV
        public const ushort COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
        public const ushort COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
        public const ushort COMBINER_MUX_SUM_NV = 0x8547;
        public const ushort COMBINER_SCALE_NV = 0x8548;
        public const ushort COMBINER_BIAS_NV = 0x8549;
        public const ushort COMBINER_AB_OUTPUT_NV = 0x854A;
        public const ushort COMBINER_CD_OUTPUT_NV = 0x854B;
        public const ushort COMBINER_SUM_OUTPUT_NV = 0x854C;
        public const ushort MAX_GENERAL_COMBINERS_NV = 0x854D;
        public const ushort NUM_GENERAL_COMBINERS_NV = 0x854E;
        public const ushort COLOR_SUM_CLAMP_NV = 0x854F;
        public const ushort COMBINER0_NV = 0x8550; // CombinerStageNV
        public const ushort COMBINER1_NV = 0x8551; // CombinerStageNV
        public const ushort COMBINER2_NV = 0x8552; // CombinerStageNV
        public const ushort COMBINER3_NV = 0x8553; // CombinerStageNV
        public const ushort COMBINER4_NV = 0x8554; // CombinerStageNV
        public const ushort COMBINER5_NV = 0x8555; // CombinerStageNV
        public const ushort COMBINER6_NV = 0x8556; // CombinerStageNV
        public const ushort COMBINER7_NV = 0x8557; // CombinerStageNV
        public const ushort PRIMITIVE_RESTART_NV = 0x8558;
        public const ushort PRIMITIVE_RESTART_INDEX_NV = 0x8559;
        public const ushort FOG_DISTANCE_MODE_NV = 0x855A;
        public const ushort EYE_RADIAL_NV = 0x855B;
        public const ushort EYE_PLANE_ABSOLUTE_NV = 0x855C;
        public const ushort EMBOSS_LIGHT_NV = 0x855D;
        public const ushort EMBOSS_CONSTANT_NV = 0x855E;
        public const ushort EMBOSS_MAP_NV = 0x855F;
        
        // . 
        public const ushort RED_MIN_CLAMP_INGR = 0x8560;
        public const ushort GREEN_MIN_CLAMP_INGR = 0x8561;
        public const ushort BLUE_MIN_CLAMP_INGR = 0x8562;
        public const ushort ALPHA_MIN_CLAMP_INGR = 0x8563;
        public const ushort RED_MAX_CLAMP_INGR = 0x8564;
        public const ushort GREEN_MAX_CLAMP_INGR = 0x8565;
        public const ushort BLUE_MAX_CLAMP_INGR = 0x8566;
        public const ushort ALPHA_MAX_CLAMP_INGR = 0x8567;
        public const ushort INTERLACE_READ_INGR = 0x8568;
        // Unused 0x8569..0x856F. 
        
        // RegisterCombinerPname. 
        public const ushort COMBINE = 0x8570;
        public const ushort COMBINE_ARB = 0x8570;
        public const ushort COMBINE_EXT = 0x8570;
        public const ushort COMBINE_RGB = 0x8571;
        public const ushort COMBINE_RGB_ARB = 0x8571;
        public const ushort COMBINE_RGB_EXT = 0x8571;
        public const ushort COMBINE_ALPHA = 0x8572;
        public const ushort COMBINE_ALPHA_ARB = 0x8572;
        public const ushort COMBINE_ALPHA_EXT = 0x8572;
        public const ushort RGB_SCALE = 0x8573;
        public const ushort RGB_SCALE_ARB = 0x8573;
        public const ushort RGB_SCALE_EXT = 0x8573;
        public const ushort ADD_SIGNED = 0x8574;
        public const ushort ADD_SIGNED_ARB = 0x8574;
        public const ushort ADD_SIGNED_EXT = 0x8574;
        public const ushort INTERPOLATE = 0x8575;
        public const ushort INTERPOLATE_ARB = 0x8575;
        public const ushort INTERPOLATE_EXT = 0x8575;
        public const ushort CONSTANT = 0x8576; // PathGenMode
        public const ushort CONSTANT_ARB = 0x8576;
        public const ushort CONSTANT_EXT = 0x8576;
        public const ushort CONSTANT_NV = 0x8576;
        public const ushort PRIMARY_COLOR = 0x8577; // PathColor
        public const ushort PRIMARY_COLOR_ARB = 0x8577;
        public const ushort PRIMARY_COLOR_EXT = 0x8577;
        public const ushort PREVIOUS = 0x8578;
        public const ushort PREVIOUS_ARB = 0x8578;
        public const ushort PREVIOUS_EXT = 0x8578;
        // Unused 0x8579..0x857F. Additional combiner enums only
        public const ushort SOURCE0_RGB = 0x8580;
        public const ushort SOURCE0_RGB_ARB = 0x8580;
        public const ushort SOURCE0_RGB_EXT = 0x8580;
        // Alias of GL_SOURCE0_RGB
        public const ushort SRC0_RGB = 0x8580;
        public const ushort SOURCE1_RGB = 0x8581;
        public const ushort SOURCE1_RGB_ARB = 0x8581;
        public const ushort SOURCE1_RGB_EXT = 0x8581;
        // Alias of GL_SOURCE1_RGB
        public const ushort SRC1_RGB = 0x8581;
        public const ushort SOURCE2_RGB = 0x8582;
        public const ushort SOURCE2_RGB_ARB = 0x8582;
        public const ushort SOURCE2_RGB_EXT = 0x8582;
        // Alias of GL_SOURCE2_RGB
        public const ushort SRC2_RGB = 0x8582;
        public const ushort SOURCE3_RGB_NV = 0x8583;
        // Unused 0x8584..0x8587. Additional combiner enums only
        public const ushort SOURCE0_ALPHA = 0x8588;
        public const ushort SOURCE0_ALPHA_ARB = 0x8588;
        public const ushort SOURCE0_ALPHA_EXT = 0x8588;
        // Alias of GL_SOURCE0_ALPHA
        public const ushort SRC0_ALPHA = 0x8588;
        public const ushort SOURCE1_ALPHA = 0x8589;
        public const ushort SOURCE1_ALPHA_ARB = 0x8589;
        public const ushort SOURCE1_ALPHA_EXT = 0x8589;
        // Alias of GL_SOURCE1_ALPHA
        public const ushort SRC1_ALPHA = 0x8589; // BlendingFactor
        public const ushort SRC1_ALPHA_EXT = 0x8589;
        public const ushort SOURCE2_ALPHA = 0x858A;
        public const ushort SOURCE2_ALPHA_ARB = 0x858A;
        public const ushort SOURCE2_ALPHA_EXT = 0x858A;
        // Alias of GL_SOURCE2_ALPHA
        public const ushort SRC2_ALPHA = 0x858A;
        public const ushort SOURCE3_ALPHA_NV = 0x858B;
        // Unused 0x858C..0x858F. Additional combiner enums only
        public const ushort OPERAND0_RGB = 0x8590;
        public const ushort OPERAND0_RGB_ARB = 0x8590;
        public const ushort OPERAND0_RGB_EXT = 0x8590;
        public const ushort OPERAND1_RGB = 0x8591;
        public const ushort OPERAND1_RGB_ARB = 0x8591;
        public const ushort OPERAND1_RGB_EXT = 0x8591;
        public const ushort OPERAND2_RGB = 0x8592;
        public const ushort OPERAND2_RGB_ARB = 0x8592;
        public const ushort OPERAND2_RGB_EXT = 0x8592;
        public const ushort OPERAND3_RGB_NV = 0x8593;
        // Unused 0x8594..0x8597. Additional combiner enums only
        public const ushort OPERAND0_ALPHA = 0x8598;
        public const ushort OPERAND0_ALPHA_ARB = 0x8598;
        public const ushort OPERAND0_ALPHA_EXT = 0x8598;
        public const ushort OPERAND1_ALPHA = 0x8599;
        public const ushort OPERAND1_ALPHA_ARB = 0x8599;
        public const ushort OPERAND1_ALPHA_EXT = 0x8599;
        public const ushort OPERAND2_ALPHA = 0x859A;
        public const ushort OPERAND2_ALPHA_ARB = 0x859A;
        public const ushort OPERAND2_ALPHA_EXT = 0x859A;
        public const ushort OPERAND3_ALPHA_NV = 0x859B;
        // Unused 0x859C..0x859F. Additional combiner enums only
        
        // . 
        public const ushort PACK_SUBSAMPLE_RATE_SGIX = 0x85A0; // PixelStoreParameter,GetPName
        public const ushort UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1; // PixelStoreParameter,GetPName
        public const ushort PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2; // PixelStoreSubsampleRate
        public const ushort PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3; // PixelStoreSubsampleRate
        public const ushort PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4; // PixelStoreSubsampleRate
        // Unused 0x85A5..0x85AD. Incomplete extension SGIS_color_range
        public const ushort PERTURB_EXT = 0x85AE; // TextureNormalModeEXT
        public const ushort TEXTURE_NORMAL_EXT = 0x85AF;
        
        // . 
        public const ushort LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;
        public const ushort TRANSFORM_HINT_APPLE = 0x85B1; // HintTarget
        public const ushort UNPACK_CLIENT_STORAGE_APPLE = 0x85B2;
        public const ushort BUFFER_OBJECT_APPLE = 0x85B3;
        public const ushort STORAGE_CLIENT_APPLE = 0x85B4; // VertexArrayPNameAPPLE
        public const ushort VERTEX_ARRAY_BINDING = 0x85B5; // GetPName
        public const ushort VERTEX_ARRAY_BINDING_APPLE = 0x85B5;
        public const ushort VERTEX_ARRAY_BINDING_OES = 0x85B5;
        // Unused 0x85B6. Unknown extension (Khronos error #632)
        public const ushort TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;
        public const ushort TEXTURE_RANGE_POINTER_APPLE = 0x85B8;
        public const ushort YCBCR_422_APPLE = 0x85B9;
        public const ushort UNSIGNED_SHORT_8_8_APPLE = 0x85BA;
        public const ushort UNSIGNED_SHORT_8_8_MESA = 0x85BA;
        public const ushort UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB;
        public const ushort UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
        public const ushort TEXTURE_STORAGE_HINT_APPLE = 0x85BC; // HintTarget
        public const ushort STORAGE_PRIVATE_APPLE = 0x85BD;
        public const ushort STORAGE_CACHED_APPLE = 0x85BE; // VertexArrayPNameAPPLE
        public const ushort STORAGE_SHARED_APPLE = 0x85BF; // VertexArrayPNameAPPLE
        
        // . 
        public const ushort REPLACEMENT_CODE_ARRAY_SUN = 0x85C0;
        public const ushort REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;
        public const ushort REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;
        public const ushort REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;
        public const ushort R1UI_V3F_SUN = 0x85C4;
        public const ushort R1UI_C4UB_V3F_SUN = 0x85C5;
        public const ushort R1UI_C3F_V3F_SUN = 0x85C6;
        public const ushort R1UI_N3F_V3F_SUN = 0x85C7;
        public const ushort R1UI_C4F_N3F_V3F_SUN = 0x85C8;
        public const ushort R1UI_T2F_V3F_SUN = 0x85C9;
        public const ushort R1UI_T2F_N3F_V3F_SUN = 0x85CA;
        public const ushort R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB;
        public const ushort SLICE_ACCUM_SUN = 0x85CC;
        // Unused 0x85CD..0x85CF. 
        
        // . 3Dlabs private extension for Autodesk
        // Unused 0x85D0..0x85D1. Unknown 3Dlabs private extension for Autodesk (but we know the enum values)
        // Unused 0x85D2..0x85DF. 
        
        // . 
        // Unused 0x85E0..0x85FB. Incomplete extension SGIX_texture_range
        // Unused 0x85FC..0x85FF. 
        
        // . 
        // Unused 0x8600..0x8613. 
        public const ushort QUAD_MESH_SUN = 0x8614;
        public const ushort TRIANGLE_MESH_SUN = 0x8615;
        // Unused 0x8614..0x861F. 
        
        // . 
        public const ushort VERTEX_PROGRAM_ARB = 0x8620; // ProgramTarget
        public const ushort VERTEX_PROGRAM_NV = 0x8620;
        public const ushort VERTEX_STATE_PROGRAM_NV = 0x8621;
        public const ushort VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
        public const ushort ATTRIB_ARRAY_SIZE_NV = 0x8623;
        public const ushort VERTEX_ATTRIB_ARRAY_SIZE = 0x8623; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
        public const ushort ATTRIB_ARRAY_STRIDE_NV = 0x8624;
        public const ushort VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
        public const ushort ATTRIB_ARRAY_TYPE_NV = 0x8625;
        public const ushort VERTEX_ATTRIB_ARRAY_TYPE = 0x8625; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
        public const ushort CURRENT_ATTRIB_NV = 0x8626;
        public const ushort CURRENT_VERTEX_ATTRIB = 0x8626; // VertexAttribEnum,VertexAttribPropertyARB
        public const ushort CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
        public const ushort PROGRAM_LENGTH_ARB = 0x8627;
        public const ushort PROGRAM_LENGTH_NV = 0x8627;
        public const ushort PROGRAM_STRING_ARB = 0x8628; // ProgramStringProperty
        public const ushort PROGRAM_STRING_NV = 0x8628;
        public const ushort MODELVIEW_PROJECTION_NV = 0x8629;
        public const ushort IDENTITY_NV = 0x862A;
        public const ushort INVERSE_NV = 0x862B;
        public const ushort TRANSPOSE_NV = 0x862C;
        public const ushort INVERSE_TRANSPOSE_NV = 0x862D;
        public const ushort MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
        public const ushort MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
        public const ushort MAX_PROGRAM_MATRICES_ARB = 0x862F;
        public const ushort MAX_TRACK_MATRICES_NV = 0x862F;
        public const ushort MATRIX0_NV = 0x8630;
        public const ushort MATRIX1_NV = 0x8631;
        public const ushort MATRIX2_NV = 0x8632;
        public const ushort MATRIX3_NV = 0x8633;
        public const ushort MATRIX4_NV = 0x8634;
        public const ushort MATRIX5_NV = 0x8635;
        public const ushort MATRIX6_NV = 0x8636;
        public const ushort MATRIX7_NV = 0x8637;
        // Unused 0x8638..0x863F. Reserved for MATRIX{8-15}_NV
        public const ushort CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
        public const ushort CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
        public const ushort CURRENT_MATRIX_ARB = 0x8641;
        public const ushort CURRENT_MATRIX_NV = 0x8641;
        public const ushort VERTEX_PROGRAM_POINT_SIZE = 0x8642;
        public const ushort VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const ushort VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
        // Alias of GL_VERTEX_PROGRAM_POINT_SIZE
        public const ushort PROGRAM_POINT_SIZE = 0x8642; // GetPName,EnableCap
        public const ushort PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const ushort PROGRAM_POINT_SIZE_EXT = 0x8642;
        public const ushort VERTEX_PROGRAM_TWO_SIDE = 0x8643;
        public const ushort VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
        public const ushort VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
        public const ushort PROGRAM_PARAMETER_NV = 0x8644; // VertexAttribEnumNV
        public const ushort ATTRIB_ARRAY_POINTER_NV = 0x8645;
        public const ushort VERTEX_ATTRIB_ARRAY_POINTER = 0x8645; // VertexAttribPointerPropertyARB
        public const ushort VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645; // VertexAttribPointerPropertyARB
        public const ushort PROGRAM_TARGET_NV = 0x8646;
        public const ushort PROGRAM_RESIDENT_NV = 0x8647;
        public const ushort TRACK_MATRIX_NV = 0x8648;
        public const ushort TRACK_MATRIX_TRANSFORM_NV = 0x8649;
        public const ushort VERTEX_PROGRAM_BINDING_NV = 0x864A;
        public const ushort PROGRAM_ERROR_POSITION_ARB = 0x864B;
        public const ushort PROGRAM_ERROR_POSITION_NV = 0x864B;
        public const ushort OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
        public const ushort OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
        public const ushort DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
        public const ushort DEPTH_CLAMP = 0x864F; // EnableCap
        public const ushort DEPTH_CLAMP_NV = 0x864F;
        public const ushort DEPTH_CLAMP_EXT = 0x864F;
        public const ushort VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
        public const ushort VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
        public const ushort VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
        public const ushort VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
        public const ushort VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
        public const ushort VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
        public const ushort VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
        public const ushort VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
        public const ushort VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
        public const ushort VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
        public const ushort VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
        public const ushort VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
        public const ushort VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
        public const ushort VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
        public const ushort VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
        public const ushort VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
        public const ushort MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
        public const ushort MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
        public const ushort MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
        public const ushort MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
        public const ushort MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
        public const ushort MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
        public const ushort MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
        public const ushort MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
        public const ushort MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
        public const ushort MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
        public const ushort MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
        public const ushort MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
        public const ushort MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
        public const ushort MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
        public const ushort MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
        public const ushort MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
        public const ushort MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
        public const ushort MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
        public const ushort MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
        public const ushort MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
        public const ushort MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
        public const ushort MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
        public const ushort MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
        public const ushort MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
        // NOT an alias. Accidental reuse of GL_MAP2_VERTEX_ATTRIB7_4_NV
        public const ushort PROGRAM_BINDING_ARB = 0x8677;
        public const ushort MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
        public const ushort MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
        public const ushort MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
        public const ushort MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
        public const ushort MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
        public const ushort MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
        public const ushort MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
        public const ushort MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
        
        // . 
        // Unused 0x8680..0x869F. 
        
        // . 
        public const ushort TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const ushort TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
        public const ushort TEXTURE_COMPRESSED = 0x86A1; // InternalFormatPName
        public const ushort TEXTURE_COMPRESSED_ARB = 0x86A1;
        public const ushort NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2; // GetPName
        public const ushort NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
        public const ushort COMPRESSED_TEXTURE_FORMATS = 0x86A3; // GetPName
        public const ushort COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
        public const ushort MAX_VERTEX_UNITS_ARB = 0x86A4;
        public const ushort MAX_VERTEX_UNITS_OES = 0x86A4;
        public const ushort ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
        public const ushort WEIGHT_SUM_UNITY_ARB = 0x86A6;
        public const ushort VERTEX_BLEND_ARB = 0x86A7;
        public const ushort CURRENT_WEIGHT_ARB = 0x86A8;
        public const ushort WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
        public const ushort WEIGHT_ARRAY_TYPE_OES = 0x86A9;
        public const ushort WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
        public const ushort WEIGHT_ARRAY_STRIDE_OES = 0x86AA;
        public const ushort WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
        public const ushort WEIGHT_ARRAY_SIZE_OES = 0x86AB;
        public const ushort WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
        public const ushort WEIGHT_ARRAY_POINTER_OES = 0x86AC;
        public const ushort WEIGHT_ARRAY_ARB = 0x86AD;
        public const ushort WEIGHT_ARRAY_OES = 0x86AD;
        public const ushort DOT3_RGB = 0x86AE;
        public const ushort DOT3_RGB_ARB = 0x86AE;
        public const ushort DOT3_RGBA = 0x86AF;
        public const ushort DOT3_RGBA_ARB = 0x86AF;
        public const ushort DOT3_RGBA_IMG = 0x86AF;
        
        // . 
        public const ushort COMPRESSED_RGB_FXT1_3DFX = 0x86B0;
        public const ushort COMPRESSED_RGBA_FXT1_3DFX = 0x86B1;
        public const ushort MULTISAMPLE_3DFX = 0x86B2;
        public const ushort SAMPLE_BUFFERS_3DFX = 0x86B3;
        public const ushort SAMPLES_3DFX = 0x86B4;
        // Unused 0x86B5..0x86BF. 
        
        // . 
        public const ushort EVAL_2D_NV = 0x86C0; // EvalTargetNV
        public const ushort EVAL_TRIANGULAR_2D_NV = 0x86C1; // EvalTargetNV
        public const ushort MAP_TESSELLATION_NV = 0x86C2; // MapParameterNV
        public const ushort MAP_ATTRIB_U_ORDER_NV = 0x86C3; // MapAttribParameterNV
        public const ushort MAP_ATTRIB_V_ORDER_NV = 0x86C4; // MapAttribParameterNV
        public const ushort EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
        public const ushort EVAL_VERTEX_ATTRIB0_NV = 0x86C6;
        public const ushort EVAL_VERTEX_ATTRIB1_NV = 0x86C7;
        public const ushort EVAL_VERTEX_ATTRIB2_NV = 0x86C8;
        public const ushort EVAL_VERTEX_ATTRIB3_NV = 0x86C9;
        public const ushort EVAL_VERTEX_ATTRIB4_NV = 0x86CA;
        public const ushort EVAL_VERTEX_ATTRIB5_NV = 0x86CB;
        public const ushort EVAL_VERTEX_ATTRIB6_NV = 0x86CC;
        public const ushort EVAL_VERTEX_ATTRIB7_NV = 0x86CD;
        public const ushort EVAL_VERTEX_ATTRIB8_NV = 0x86CE;
        public const ushort EVAL_VERTEX_ATTRIB9_NV = 0x86CF;
        public const ushort EVAL_VERTEX_ATTRIB10_NV = 0x86D0;
        public const ushort EVAL_VERTEX_ATTRIB11_NV = 0x86D1;
        public const ushort EVAL_VERTEX_ATTRIB12_NV = 0x86D2;
        public const ushort EVAL_VERTEX_ATTRIB13_NV = 0x86D3;
        public const ushort EVAL_VERTEX_ATTRIB14_NV = 0x86D4;
        public const ushort EVAL_VERTEX_ATTRIB15_NV = 0x86D5;
        public const ushort MAX_MAP_TESSELLATION_NV = 0x86D6;
        public const ushort MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;
        public const ushort MAX_PROGRAM_PATCH_ATTRIBS_NV = 0x86D8;
        public const ushort RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
        public const ushort UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
        public const ushort UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
        public const ushort DSDT_MAG_INTENSITY_NV = 0x86DC;
        public const ushort SHADER_CONSISTENT_NV = 0x86DD;
        public const ushort TEXTURE_SHADER_NV = 0x86DE;
        public const ushort SHADER_OPERATION_NV = 0x86DF;
        public const ushort CULL_MODES_NV = 0x86E0;
        public const ushort OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
        // Alias of GL_OFFSET_TEXTURE_MATRIX_NV
        public const ushort OFFSET_TEXTURE_2D_MATRIX_NV = 0x86E1;
        public const ushort OFFSET_TEXTURE_SCALE_NV = 0x86E2;
        // Alias of GL_OFFSET_TEXTURE_SCALE_NV
        public const ushort OFFSET_TEXTURE_2D_SCALE_NV = 0x86E2;
        public const ushort OFFSET_TEXTURE_BIAS_NV = 0x86E3;
        // Alias of GL_OFFSET_TEXTURE_BIAS_NV
        public const ushort OFFSET_TEXTURE_2D_BIAS_NV = 0x86E3;
        public const ushort PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
        public const ushort CONST_EYE_NV = 0x86E5;
        public const ushort PASS_THROUGH_NV = 0x86E6;
        public const ushort CULL_FRAGMENT_NV = 0x86E7;
        public const ushort OFFSET_TEXTURE_2D_NV = 0x86E8;
        public const ushort DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
        public const ushort DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
        public const ushort SURFACE_STATE_NV = 0x86EB;
        public const ushort DOT_PRODUCT_NV = 0x86EC;
        public const ushort DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
        public const ushort DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
        public const ushort DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
        public const ushort DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
        public const ushort DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
        public const ushort DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
        public const ushort DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
        public const ushort HILO_NV = 0x86F4;
        public const ushort DSDT_NV = 0x86F5;
        public const ushort DSDT_MAG_NV = 0x86F6;
        public const ushort DSDT_MAG_VIB_NV = 0x86F7;
        public const ushort HILO16_NV = 0x86F8;
        public const ushort SIGNED_HILO_NV = 0x86F9;
        public const ushort SIGNED_HILO16_NV = 0x86FA;
        public const ushort SIGNED_RGBA_NV = 0x86FB;
        public const ushort SIGNED_RGBA8_NV = 0x86FC;
        public const ushort SURFACE_REGISTERED_NV = 0x86FD;
        public const ushort SIGNED_RGB_NV = 0x86FE;
        public const ushort SIGNED_RGB8_NV = 0x86FF;
        public const ushort SURFACE_MAPPED_NV = 0x8700;
        public const ushort SIGNED_LUMINANCE_NV = 0x8701;
        public const ushort SIGNED_LUMINANCE8_NV = 0x8702;
        public const ushort SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
        public const ushort SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
        public const ushort SIGNED_ALPHA_NV = 0x8705;
        public const ushort SIGNED_ALPHA8_NV = 0x8706;
        public const ushort SIGNED_INTENSITY_NV = 0x8707;
        public const ushort SIGNED_INTENSITY8_NV = 0x8708;
        public const ushort DSDT8_NV = 0x8709;
        public const ushort DSDT8_MAG8_NV = 0x870A;
        public const ushort DSDT8_MAG8_INTENSITY8_NV = 0x870B;
        public const ushort SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
        public const ushort SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
        public const ushort HI_SCALE_NV = 0x870E;
        public const ushort LO_SCALE_NV = 0x870F;
        public const ushort DS_SCALE_NV = 0x8710;
        public const ushort DT_SCALE_NV = 0x8711;
        public const ushort MAGNITUDE_SCALE_NV = 0x8712;
        public const ushort VIBRANCE_SCALE_NV = 0x8713;
        public const ushort HI_BIAS_NV = 0x8714;
        public const ushort LO_BIAS_NV = 0x8715;
        public const ushort DS_BIAS_NV = 0x8716;
        public const ushort DT_BIAS_NV = 0x8717;
        public const ushort MAGNITUDE_BIAS_NV = 0x8718;
        public const ushort VIBRANCE_BIAS_NV = 0x8719;
        public const ushort TEXTURE_BORDER_VALUES_NV = 0x871A;
        public const ushort TEXTURE_HI_SIZE_NV = 0x871B;
        public const ushort TEXTURE_LO_SIZE_NV = 0x871C;
        public const ushort TEXTURE_DS_SIZE_NV = 0x871D;
        public const ushort TEXTURE_DT_SIZE_NV = 0x871E;
        public const ushort TEXTURE_MAG_SIZE_NV = 0x871F;
        
        // . 
        // Unused 0x8720..0x8721. MODELVIEW0/1 already exist
        public const ushort MODELVIEW2_ARB = 0x8722;
        public const ushort MODELVIEW3_ARB = 0x8723;
        public const ushort MODELVIEW4_ARB = 0x8724;
        public const ushort MODELVIEW5_ARB = 0x8725;
        public const ushort MODELVIEW6_ARB = 0x8726;
        public const ushort MODELVIEW7_ARB = 0x8727;
        public const ushort MODELVIEW8_ARB = 0x8728;
        public const ushort MODELVIEW9_ARB = 0x8729;
        public const ushort MODELVIEW10_ARB = 0x872A;
        public const ushort MODELVIEW11_ARB = 0x872B;
        public const ushort MODELVIEW12_ARB = 0x872C;
        public const ushort MODELVIEW13_ARB = 0x872D;
        public const ushort MODELVIEW14_ARB = 0x872E;
        public const ushort MODELVIEW15_ARB = 0x872F;
        public const ushort MODELVIEW16_ARB = 0x8730;
        public const ushort MODELVIEW17_ARB = 0x8731;
        public const ushort MODELVIEW18_ARB = 0x8732;
        public const ushort MODELVIEW19_ARB = 0x8733;
        public const ushort MODELVIEW20_ARB = 0x8734;
        public const ushort MODELVIEW21_ARB = 0x8735;
        public const ushort MODELVIEW22_ARB = 0x8736;
        public const ushort MODELVIEW23_ARB = 0x8737;
        public const ushort MODELVIEW24_ARB = 0x8738;
        public const ushort MODELVIEW25_ARB = 0x8739;
        public const ushort MODELVIEW26_ARB = 0x873A;
        public const ushort MODELVIEW27_ARB = 0x873B;
        public const ushort MODELVIEW28_ARB = 0x873C;
        public const ushort MODELVIEW29_ARB = 0x873D;
        public const ushort MODELVIEW30_ARB = 0x873E;
        public const ushort MODELVIEW31_ARB = 0x873F;
        
        // . 
        public const ushort DOT3_RGB_EXT = 0x8740;
        // NOT an alias. Accidental reuse of GL_DOT3_RGB_EXT
        public const ushort Z400_BINARY_AMD = 0x8740;
        public const ushort DOT3_RGBA_EXT = 0x8741;
        // NOT an alias. Accidental reuse of GL_DOT3_RGBA_EXT
        public const ushort PROGRAM_BINARY_LENGTH_OES = 0x8741;
        public const ushort PROGRAM_BINARY_LENGTH = 0x8741; // ProgramPropertyARB
        public const ushort MIRROR_CLAMP_ATI = 0x8742;
        public const ushort MIRROR_CLAMP_EXT = 0x8742;
        public const ushort MIRROR_CLAMP_TO_EDGE = 0x8743;
        public const ushort MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
        public const ushort MIRROR_CLAMP_TO_EDGE_EXT = 0x8743;
        public const ushort MODULATE_ADD_ATI = 0x8744;
        public const ushort MODULATE_SIGNED_ADD_ATI = 0x8745;
        public const ushort MODULATE_SUBTRACT_ATI = 0x8746;
        // Unused 0x8747..0x8749. 
        public const ushort SET_AMD = 0x874A;
        public const ushort REPLACE_VALUE_AMD = 0x874B;
        public const ushort STENCIL_OP_VALUE_AMD = 0x874C;
        public const ushort STENCIL_BACK_OP_VALUE_AMD = 0x874D;
        public const ushort VERTEX_ATTRIB_ARRAY_LONG = 0x874E; // VertexArrayPName,VertexAttribPropertyARB
        public const ushort OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F;
        
        // . 
        public const ushort DEPTH_STENCIL_MESA = 0x8750; // InternalFormat
        public const ushort UNSIGNED_INT_24_8_MESA = 0x8751;
        public const ushort UNSIGNED_INT_8_24_REV_MESA = 0x8752;
        public const ushort UNSIGNED_SHORT_15_1_MESA = 0x8753;
        public const ushort UNSIGNED_SHORT_1_15_REV_MESA = 0x8754;
        public const ushort TRACE_MASK_MESA = 0x8755;
        public const ushort TRACE_NAME_MESA = 0x8756;
        public const ushort YCBCR_MESA = 0x8757;
        public const ushort PACK_INVERT_MESA = 0x8758;
        // NOT an alias. Accidental reuse of GL_TEXTURE_1D_STACK_MESAX
        public const ushort DEBUG_OBJECT_MESA = 0x8759;
        public const ushort TEXTURE_1D_STACK_MESAX = 0x8759;
        // NOT an alias. Accidental reuse of GL_TEXTURE_2D_STACK_MESAX
        public const ushort DEBUG_PRINT_MESA = 0x875A;
        public const ushort TEXTURE_2D_STACK_MESAX = 0x875A;
        // NOT an alias. Accidental reuse of GL_PROXY_TEXTURE_1D_STACK_MESAX
        public const ushort DEBUG_ASSERT_MESA = 0x875B;
        public const ushort PROXY_TEXTURE_1D_STACK_MESAX = 0x875B;
        public const ushort PROXY_TEXTURE_2D_STACK_MESAX = 0x875C;
        public const ushort TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
        public const ushort TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;
        public const ushort PROGRAM_BINARY_FORMAT_MESA = 0x875F;
        
        // . 
        public const ushort STATIC_ATI = 0x8760; // ArrayObjectUsageATI
        public const ushort DYNAMIC_ATI = 0x8761; // ArrayObjectUsageATI
        public const ushort PRESERVE_ATI = 0x8762; // PreserveModeATI
        public const ushort DISCARD_ATI = 0x8763; // PreserveModeATI
        public const ushort BUFFER_SIZE = 0x8764; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_SIZE_ARB = 0x8764; // BufferPNameARB
        public const ushort OBJECT_BUFFER_SIZE_ATI = 0x8764; // ArrayObjectPNameATI
        public const ushort BUFFER_USAGE = 0x8765; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_USAGE_ARB = 0x8765; // BufferPNameARB
        public const ushort OBJECT_BUFFER_USAGE_ATI = 0x8765; // ArrayObjectPNameATI
        public const ushort ARRAY_OBJECT_BUFFER_ATI = 0x8766;
        public const ushort ARRAY_OBJECT_OFFSET_ATI = 0x8767;
        public const ushort ELEMENT_ARRAY_ATI = 0x8768;
        public const ushort ELEMENT_ARRAY_TYPE_ATI = 0x8769;
        public const ushort ELEMENT_ARRAY_POINTER_ATI = 0x876A;
        public const ushort MAX_VERTEX_STREAMS_ATI = 0x876B;
        public const ushort VERTEX_STREAM0_ATI = 0x876C; // VertexStreamATI
        public const ushort VERTEX_STREAM1_ATI = 0x876D; // VertexStreamATI
        public const ushort VERTEX_STREAM2_ATI = 0x876E; // VertexStreamATI
        public const ushort VERTEX_STREAM3_ATI = 0x876F; // VertexStreamATI
        public const ushort VERTEX_STREAM4_ATI = 0x8770; // VertexStreamATI
        public const ushort VERTEX_STREAM5_ATI = 0x8771; // VertexStreamATI
        public const ushort VERTEX_STREAM6_ATI = 0x8772; // VertexStreamATI
        public const ushort VERTEX_STREAM7_ATI = 0x8773; // VertexStreamATI
        public const ushort VERTEX_SOURCE_ATI = 0x8774;
        public const ushort BUMP_ROT_MATRIX_ATI = 0x8775; // GetTexBumpParameterATI,TexBumpParameterATI
        public const ushort BUMP_ROT_MATRIX_SIZE_ATI = 0x8776; // GetTexBumpParameterATI
        public const ushort BUMP_NUM_TEX_UNITS_ATI = 0x8777; // GetTexBumpParameterATI
        public const ushort BUMP_TEX_UNITS_ATI = 0x8778; // GetTexBumpParameterATI
        public const ushort DUDV_ATI = 0x8779;
        public const ushort DU8DV8_ATI = 0x877A;
        public const ushort BUMP_ENVMAP_ATI = 0x877B;
        public const ushort BUMP_TARGET_ATI = 0x877C;
        // Unused 0x877D..0x877F. 
        public const ushort VERTEX_SHADER_EXT = 0x8780;
        public const ushort VERTEX_SHADER_BINDING_EXT = 0x8781;
        public const ushort OP_INDEX_EXT = 0x8782; // VertexShaderOpEXT
        public const ushort OP_NEGATE_EXT = 0x8783; // VertexShaderOpEXT
        public const ushort OP_DOT3_EXT = 0x8784; // VertexShaderOpEXT
        public const ushort OP_DOT4_EXT = 0x8785; // VertexShaderOpEXT
        public const ushort OP_MUL_EXT = 0x8786; // VertexShaderOpEXT
        public const ushort OP_ADD_EXT = 0x8787; // VertexShaderOpEXT
        public const ushort OP_MADD_EXT = 0x8788; // VertexShaderOpEXT
        public const ushort OP_FRAC_EXT = 0x8789; // VertexShaderOpEXT
        public const ushort OP_MAX_EXT = 0x878A; // VertexShaderOpEXT
        public const ushort OP_MIN_EXT = 0x878B; // VertexShaderOpEXT
        public const ushort OP_SET_GE_EXT = 0x878C; // VertexShaderOpEXT
        public const ushort OP_SET_LT_EXT = 0x878D; // VertexShaderOpEXT
        public const ushort OP_CLAMP_EXT = 0x878E; // VertexShaderOpEXT
        public const ushort OP_FLOOR_EXT = 0x878F; // VertexShaderOpEXT
        public const ushort OP_ROUND_EXT = 0x8790; // VertexShaderOpEXT
        public const ushort OP_EXP_BASE_2_EXT = 0x8791; // VertexShaderOpEXT
        public const ushort OP_LOG_BASE_2_EXT = 0x8792; // VertexShaderOpEXT
        public const ushort OP_POWER_EXT = 0x8793; // VertexShaderOpEXT
        public const ushort OP_RECIP_EXT = 0x8794; // VertexShaderOpEXT
        public const ushort OP_RECIP_SQRT_EXT = 0x8795; // VertexShaderOpEXT
        public const ushort OP_SUB_EXT = 0x8796; // VertexShaderOpEXT
        public const ushort OP_CROSS_PRODUCT_EXT = 0x8797; // VertexShaderOpEXT
        public const ushort OP_MULTIPLY_MATRIX_EXT = 0x8798; // VertexShaderOpEXT
        public const ushort OP_MOV_EXT = 0x8799; // VertexShaderOpEXT
        public const ushort OUTPUT_VERTEX_EXT = 0x879A;
        public const ushort OUTPUT_COLOR0_EXT = 0x879B;
        public const ushort OUTPUT_COLOR1_EXT = 0x879C;
        public const ushort OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
        public const ushort OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
        public const ushort OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
        public const ushort OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
        public const ushort OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
        public const ushort OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
        public const ushort OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
        public const ushort OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
        public const ushort OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
        public const ushort OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
        public const ushort OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
        public const ushort OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
        public const ushort OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
        public const ushort OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
        public const ushort OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
        public const ushort OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
        public const ushort OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
        public const ushort OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
        public const ushort OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
        public const ushort OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
        public const ushort OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
        public const ushort OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
        public const ushort OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
        public const ushort OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
        public const ushort OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
        public const ushort OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
        public const ushort OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
        public const ushort OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
        public const ushort OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
        public const ushort OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
        public const ushort OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
        public const ushort OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
        public const ushort OUTPUT_FOG_EXT = 0x87BD;
        public const ushort SCALAR_EXT = 0x87BE; // DataTypeEXT
        public const ushort VECTOR_EXT = 0x87BF; // DataTypeEXT
        public const ushort MATRIX_EXT = 0x87C0; // DataTypeEXT
        public const ushort VARIANT_EXT = 0x87C1; // VertexShaderStorageTypeEXT
        public const ushort INVARIANT_EXT = 0x87C2; // VertexShaderStorageTypeEXT
        public const ushort LOCAL_CONSTANT_EXT = 0x87C3; // VertexShaderStorageTypeEXT
        public const ushort LOCAL_EXT = 0x87C4; // VertexShaderStorageTypeEXT
        public const ushort MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
        public const ushort MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
        public const ushort MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
        public const ushort MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
        public const ushort MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
        public const ushort MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
        public const ushort MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
        public const ushort MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC;
        public const ushort MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD;
        public const ushort MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
        public const ushort VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
        public const ushort VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
        public const ushort VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
        public const ushort VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
        public const ushort VERTEX_SHADER_LOCALS_EXT = 0x87D3;
        public const ushort VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
        public const ushort X_EXT = 0x87D5; // VertexShaderCoordOutEXT
        public const ushort Y_EXT = 0x87D6; // VertexShaderCoordOutEXT
        public const ushort Z_EXT = 0x87D7; // VertexShaderCoordOutEXT
        public const ushort W_EXT = 0x87D8; // VertexShaderCoordOutEXT
        public const ushort NEGATIVE_X_EXT = 0x87D9; // VertexShaderCoordOutEXT
        public const ushort NEGATIVE_Y_EXT = 0x87DA; // VertexShaderCoordOutEXT
        public const ushort NEGATIVE_Z_EXT = 0x87DB; // VertexShaderCoordOutEXT
        public const ushort NEGATIVE_W_EXT = 0x87DC; // VertexShaderCoordOutEXT
        public const ushort ZERO_EXT = 0x87DD; // VertexShaderCoordOutEXT
        public const ushort ONE_EXT = 0x87DE; // VertexShaderCoordOutEXT
        public const ushort NEGATIVE_ONE_EXT = 0x87DF; // VertexShaderCoordOutEXT
        public const ushort NORMALIZED_RANGE_EXT = 0x87E0; // ParameterRangeEXT
        public const ushort FULL_RANGE_EXT = 0x87E1; // ParameterRangeEXT
        public const ushort CURRENT_VERTEX_EXT = 0x87E2; // VertexShaderParameterEXT
        public const ushort MVP_MATRIX_EXT = 0x87E3; // VertexShaderParameterEXT
        public const ushort VARIANT_VALUE_EXT = 0x87E4; // GetVariantValueEXT
        public const ushort VARIANT_DATATYPE_EXT = 0x87E5; // GetVariantValueEXT
        public const ushort VARIANT_ARRAY_STRIDE_EXT = 0x87E6; // GetVariantValueEXT
        public const ushort VARIANT_ARRAY_TYPE_EXT = 0x87E7; // GetVariantValueEXT
        public const ushort VARIANT_ARRAY_EXT = 0x87E8; // VariantCapEXT
        public const ushort VARIANT_ARRAY_POINTER_EXT = 0x87E9;
        public const ushort INVARIANT_VALUE_EXT = 0x87EA;
        public const ushort INVARIANT_DATATYPE_EXT = 0x87EB;
        public const ushort LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
        public const ushort LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;
        public const ushort ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
        public const ushort PN_TRIANGLES_ATI = 0x87F0;
        public const ushort MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
        public const ushort PN_TRIANGLES_POINT_MODE_ATI = 0x87F2; // PNTrianglesPNameATI
        public const ushort PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3; // PNTrianglesPNameATI
        public const ushort PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4; // PNTrianglesPNameATI
        public const ushort PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
        public const ushort PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
        public const ushort PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
        public const ushort PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
        public const ushort GL_3DC_X_AMD = 0x87F9;
        public const ushort GL_3DC_XY_AMD = 0x87FA;
        public const ushort VBO_FREE_MEMORY_ATI = 0x87FB;
        public const ushort TEXTURE_FREE_MEMORY_ATI = 0x87FC;
        public const ushort RENDERBUFFER_FREE_MEMORY_ATI = 0x87FD;
        public const ushort NUM_PROGRAM_BINARY_FORMATS = 0x87FE; // GetPName
        public const ushort NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE;
        public const ushort PROGRAM_BINARY_FORMATS = 0x87FF; // GetPName
        public const ushort PROGRAM_BINARY_FORMATS_OES = 0x87FF;
        public const ushort STENCIL_BACK_FUNC = 0x8800; // GetPName
        public const ushort STENCIL_BACK_FUNC_ATI = 0x8800;
        public const ushort STENCIL_BACK_FAIL = 0x8801; // GetPName
        public const ushort STENCIL_BACK_FAIL_ATI = 0x8801;
        public const ushort STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802; // GetPName
        public const ushort STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;
        public const ushort STENCIL_BACK_PASS_DEPTH_PASS = 0x8803; // GetPName
        public const ushort STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;
        public const ushort FRAGMENT_PROGRAM_ARB = 0x8804; // ProgramTarget
        public const ushort PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
        public const ushort PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
        public const ushort PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
        public const ushort PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
        public const ushort PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
        public const ushort PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
        public const ushort MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
        public const ushort MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
        public const ushort MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
        public const ushort MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
        public const ushort MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
        public const ushort MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
        // Unused 0x8811..0x8813. 
        public const ushort RGBA32F = 0x8814; // InternalFormat
        public const ushort RGBA32F_ARB = 0x8814; // InternalFormat
        public const ushort RGBA32F_EXT = 0x8814; // InternalFormat
        public const ushort RGBA_FLOAT32_APPLE = 0x8814;
        public const ushort RGBA_FLOAT32_ATI = 0x8814;
        public const ushort RGB32F = 0x8815; // InternalFormat
        public const ushort RGB32F_ARB = 0x8815;
        public const ushort RGB32F_EXT = 0x8815;
        public const ushort RGB_FLOAT32_APPLE = 0x8815;
        public const ushort RGB_FLOAT32_ATI = 0x8815;
        public const ushort ALPHA32F_ARB = 0x8816;
        public const ushort ALPHA32F_EXT = 0x8816;
        public const ushort ALPHA_FLOAT32_APPLE = 0x8816;
        public const ushort ALPHA_FLOAT32_ATI = 0x8816;
        public const ushort INTENSITY32F_ARB = 0x8817;
        public const ushort INTENSITY_FLOAT32_APPLE = 0x8817;
        public const ushort INTENSITY_FLOAT32_ATI = 0x8817;
        public const ushort LUMINANCE32F_ARB = 0x8818;
        public const ushort LUMINANCE32F_EXT = 0x8818;
        public const ushort LUMINANCE_FLOAT32_APPLE = 0x8818;
        public const ushort LUMINANCE_FLOAT32_ATI = 0x8818;
        public const ushort LUMINANCE_ALPHA32F_ARB = 0x8819;
        public const ushort LUMINANCE_ALPHA32F_EXT = 0x8819;
        public const ushort LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819;
        public const ushort LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
        public const ushort RGBA16F = 0x881A; // InternalFormat
        public const ushort RGBA16F_ARB = 0x881A; // InternalFormat
        public const ushort RGBA16F_EXT = 0x881A; // InternalFormat
        public const ushort RGBA_FLOAT16_APPLE = 0x881A;
        public const ushort RGBA_FLOAT16_ATI = 0x881A;
        public const ushort RGB16F = 0x881B; // InternalFormat
        public const ushort RGB16F_ARB = 0x881B; // InternalFormat
        public const ushort RGB16F_EXT = 0x881B; // InternalFormat
        public const ushort RGB_FLOAT16_APPLE = 0x881B;
        public const ushort RGB_FLOAT16_ATI = 0x881B;
        public const ushort ALPHA16F_ARB = 0x881C;
        public const ushort ALPHA16F_EXT = 0x881C;
        public const ushort ALPHA_FLOAT16_APPLE = 0x881C;
        public const ushort ALPHA_FLOAT16_ATI = 0x881C;
        public const ushort INTENSITY16F_ARB = 0x881D;
        public const ushort INTENSITY_FLOAT16_APPLE = 0x881D;
        public const ushort INTENSITY_FLOAT16_ATI = 0x881D;
        public const ushort LUMINANCE16F_ARB = 0x881E;
        public const ushort LUMINANCE16F_EXT = 0x881E;
        public const ushort LUMINANCE_FLOAT16_APPLE = 0x881E;
        public const ushort LUMINANCE_FLOAT16_ATI = 0x881E;
        public const ushort LUMINANCE_ALPHA16F_ARB = 0x881F;
        public const ushort LUMINANCE_ALPHA16F_EXT = 0x881F;
        public const ushort LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F;
        public const ushort LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
        public const ushort RGBA_FLOAT_MODE_ARB = 0x8820;
        public const ushort RGBA_FLOAT_MODE_ATI = 0x8820;
        // Unused 0x8821..0x8822. 
        public const ushort WRITEONLY_RENDERING_QCOM = 0x8823;
        public const ushort MAX_DRAW_BUFFERS = 0x8824; // GetPName
        public const ushort MAX_DRAW_BUFFERS_ARB = 0x8824;
        public const ushort MAX_DRAW_BUFFERS_ATI = 0x8824;
        public const ushort MAX_DRAW_BUFFERS_EXT = 0x8824;
        public const ushort MAX_DRAW_BUFFERS_NV = 0x8824;
        public const ushort DRAW_BUFFER0 = 0x8825;
        public const ushort DRAW_BUFFER0_ARB = 0x8825;
        public const ushort DRAW_BUFFER0_ATI = 0x8825;
        public const ushort DRAW_BUFFER0_EXT = 0x8825;
        public const ushort DRAW_BUFFER0_NV = 0x8825;
        public const ushort DRAW_BUFFER1 = 0x8826;
        public const ushort DRAW_BUFFER1_ARB = 0x8826;
        public const ushort DRAW_BUFFER1_ATI = 0x8826;
        public const ushort DRAW_BUFFER1_EXT = 0x8826;
        public const ushort DRAW_BUFFER1_NV = 0x8826;
        public const ushort DRAW_BUFFER2 = 0x8827;
        public const ushort DRAW_BUFFER2_ARB = 0x8827;
        public const ushort DRAW_BUFFER2_ATI = 0x8827;
        public const ushort DRAW_BUFFER2_EXT = 0x8827;
        public const ushort DRAW_BUFFER2_NV = 0x8827;
        public const ushort DRAW_BUFFER3 = 0x8828;
        public const ushort DRAW_BUFFER3_ARB = 0x8828;
        public const ushort DRAW_BUFFER3_ATI = 0x8828;
        public const ushort DRAW_BUFFER3_EXT = 0x8828;
        public const ushort DRAW_BUFFER3_NV = 0x8828;
        public const ushort DRAW_BUFFER4 = 0x8829;
        public const ushort DRAW_BUFFER4_ARB = 0x8829;
        public const ushort DRAW_BUFFER4_ATI = 0x8829;
        public const ushort DRAW_BUFFER4_EXT = 0x8829;
        public const ushort DRAW_BUFFER4_NV = 0x8829;
        public const ushort DRAW_BUFFER5 = 0x882A;
        public const ushort DRAW_BUFFER5_ARB = 0x882A;
        public const ushort DRAW_BUFFER5_ATI = 0x882A;
        public const ushort DRAW_BUFFER5_EXT = 0x882A;
        public const ushort DRAW_BUFFER5_NV = 0x882A;
        public const ushort DRAW_BUFFER6 = 0x882B;
        public const ushort DRAW_BUFFER6_ARB = 0x882B;
        public const ushort DRAW_BUFFER6_ATI = 0x882B;
        public const ushort DRAW_BUFFER6_EXT = 0x882B;
        public const ushort DRAW_BUFFER6_NV = 0x882B;
        public const ushort DRAW_BUFFER7 = 0x882C;
        public const ushort DRAW_BUFFER7_ARB = 0x882C;
        public const ushort DRAW_BUFFER7_ATI = 0x882C;
        public const ushort DRAW_BUFFER7_EXT = 0x882C;
        public const ushort DRAW_BUFFER7_NV = 0x882C;
        public const ushort DRAW_BUFFER8 = 0x882D;
        public const ushort DRAW_BUFFER8_ARB = 0x882D;
        public const ushort DRAW_BUFFER8_ATI = 0x882D;
        public const ushort DRAW_BUFFER8_EXT = 0x882D;
        public const ushort DRAW_BUFFER8_NV = 0x882D;
        public const ushort DRAW_BUFFER9 = 0x882E;
        public const ushort DRAW_BUFFER9_ARB = 0x882E;
        public const ushort DRAW_BUFFER9_ATI = 0x882E;
        public const ushort DRAW_BUFFER9_EXT = 0x882E;
        public const ushort DRAW_BUFFER9_NV = 0x882E;
        public const ushort DRAW_BUFFER10 = 0x882F;
        public const ushort DRAW_BUFFER10_ARB = 0x882F;
        public const ushort DRAW_BUFFER10_ATI = 0x882F;
        public const ushort DRAW_BUFFER10_EXT = 0x882F;
        public const ushort DRAW_BUFFER10_NV = 0x882F;
        public const ushort DRAW_BUFFER11 = 0x8830;
        public const ushort DRAW_BUFFER11_ARB = 0x8830;
        public const ushort DRAW_BUFFER11_ATI = 0x8830;
        public const ushort DRAW_BUFFER11_EXT = 0x8830;
        public const ushort DRAW_BUFFER11_NV = 0x8830;
        public const ushort DRAW_BUFFER12 = 0x8831;
        public const ushort DRAW_BUFFER12_ARB = 0x8831;
        public const ushort DRAW_BUFFER12_ATI = 0x8831;
        public const ushort DRAW_BUFFER12_EXT = 0x8831;
        public const ushort DRAW_BUFFER12_NV = 0x8831;
        public const ushort DRAW_BUFFER13 = 0x8832;
        public const ushort DRAW_BUFFER13_ARB = 0x8832;
        public const ushort DRAW_BUFFER13_ATI = 0x8832;
        public const ushort DRAW_BUFFER13_EXT = 0x8832;
        public const ushort DRAW_BUFFER13_NV = 0x8832;
        public const ushort DRAW_BUFFER14 = 0x8833;
        public const ushort DRAW_BUFFER14_ARB = 0x8833;
        public const ushort DRAW_BUFFER14_ATI = 0x8833;
        public const ushort DRAW_BUFFER14_EXT = 0x8833;
        public const ushort DRAW_BUFFER14_NV = 0x8833;
        public const ushort DRAW_BUFFER15 = 0x8834;
        public const ushort DRAW_BUFFER15_ARB = 0x8834;
        public const ushort DRAW_BUFFER15_ATI = 0x8834;
        public const ushort DRAW_BUFFER15_EXT = 0x8834;
        public const ushort DRAW_BUFFER15_NV = 0x8834;
        public const ushort COLOR_CLEAR_UNCLAMPED_VALUE_ATI = 0x8835;
        // Unused 0x8836. 
        // Defined by Mesa but not ATI
        public const ushort COMPRESSED_LUMINANCE_ALPHA_3DC_ATI = 0x8837;
        // Unused 0x8838..0x883C. 
        public const ushort BLEND_EQUATION_ALPHA = 0x883D; // GetPName
        public const ushort BLEND_EQUATION_ALPHA_EXT = 0x883D;
        public const ushort BLEND_EQUATION_ALPHA_OES = 0x883D;
        // Unused 0x883E. 
        public const ushort SUBSAMPLE_DISTANCE_AMD = 0x883F;
        
        // . 
        public const ushort MATRIX_PALETTE_ARB = 0x8840;
        public const ushort MATRIX_PALETTE_OES = 0x8840;
        public const ushort MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
        public const ushort MAX_PALETTE_MATRICES_ARB = 0x8842;
        public const ushort MAX_PALETTE_MATRICES_OES = 0x8842;
        public const ushort CURRENT_PALETTE_MATRIX_ARB = 0x8843;
        public const ushort CURRENT_PALETTE_MATRIX_OES = 0x8843;
        public const ushort MATRIX_INDEX_ARRAY_ARB = 0x8844;
        public const ushort MATRIX_INDEX_ARRAY_OES = 0x8844;
        public const ushort CURRENT_MATRIX_INDEX_ARB = 0x8845;
        public const ushort MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
        public const ushort MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846;
        public const ushort MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
        public const ushort MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847;
        public const ushort MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
        public const ushort MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848;
        public const ushort MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
        public const ushort MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849;
        public const ushort TEXTURE_DEPTH_SIZE = 0x884A;
        public const ushort TEXTURE_DEPTH_SIZE_ARB = 0x884A;
        public const ushort DEPTH_TEXTURE_MODE = 0x884B;
        public const ushort DEPTH_TEXTURE_MODE_ARB = 0x884B;
        public const ushort TEXTURE_COMPARE_MODE = 0x884C; // SamplerParameterI,TextureParameterName
        public const ushort TEXTURE_COMPARE_MODE_ARB = 0x884C;
        public const ushort TEXTURE_COMPARE_MODE_EXT = 0x884C;
        public const ushort TEXTURE_COMPARE_FUNC = 0x884D; // SamplerParameterI,TextureParameterName
        public const ushort TEXTURE_COMPARE_FUNC_ARB = 0x884D;
        public const ushort TEXTURE_COMPARE_FUNC_EXT = 0x884D;
        public const ushort COMPARE_R_TO_TEXTURE = 0x884E; // TextureCompareMode
        public const ushort COMPARE_R_TO_TEXTURE_ARB = 0x884E;
        public const ushort COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
        // Alias of GL_COMPARE_R_TO_TEXTURE
        public const ushort COMPARE_REF_TO_TEXTURE = 0x884E; // TextureCompareMode
        public const ushort COMPARE_REF_TO_TEXTURE_EXT = 0x884E;
        public const ushort TEXTURE_CUBE_MAP_SEAMLESS = 0x884F; // EnableCap
        
        // . 
        public const ushort OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
        public const ushort OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
        public const ushort OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
        public const ushort OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
        public const ushort OFFSET_HILO_TEXTURE_2D_NV = 0x8854;
        public const ushort OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
        public const ushort OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
        public const ushort OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
        public const ushort DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;
        public const ushort DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;
        public const ushort DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
        public const ushort DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;
        public const ushort DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;
        public const ushort DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
        public const ushort HILO8_NV = 0x885E;
        public const ushort SIGNED_HILO8_NV = 0x885F;
        public const ushort FORCE_BLUE_TO_ONE_NV = 0x8860;
        public const ushort POINT_SPRITE = 0x8861;
        public const ushort POINT_SPRITE_ARB = 0x8861;
        public const ushort POINT_SPRITE_NV = 0x8861;
        public const ushort POINT_SPRITE_OES = 0x8861;
        public const ushort COORD_REPLACE = 0x8862;
        public const ushort COORD_REPLACE_ARB = 0x8862;
        public const ushort COORD_REPLACE_NV = 0x8862;
        public const ushort COORD_REPLACE_OES = 0x8862;
        public const ushort POINT_SPRITE_R_MODE_NV = 0x8863;
        public const ushort PIXEL_COUNTER_BITS_NV = 0x8864;
        public const ushort QUERY_COUNTER_BITS = 0x8864; // QueryParameterName
        public const ushort QUERY_COUNTER_BITS_ARB = 0x8864;
        public const ushort QUERY_COUNTER_BITS_EXT = 0x8864;
        public const ushort CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
        public const ushort CURRENT_QUERY = 0x8865; // QueryParameterName
        public const ushort CURRENT_QUERY_ARB = 0x8865;
        public const ushort CURRENT_QUERY_EXT = 0x8865;
        public const ushort PIXEL_COUNT_NV = 0x8866; // OcclusionQueryParameterNameNV
        public const ushort QUERY_RESULT = 0x8866; // QueryObjectParameterName
        public const ushort QUERY_RESULT_ARB = 0x8866;
        public const ushort QUERY_RESULT_EXT = 0x8866;
        public const ushort PIXEL_COUNT_AVAILABLE_NV = 0x8867; // OcclusionQueryParameterNameNV
        public const ushort QUERY_RESULT_AVAILABLE = 0x8867; // QueryObjectParameterName
        public const ushort QUERY_RESULT_AVAILABLE_ARB = 0x8867;
        public const ushort QUERY_RESULT_AVAILABLE_EXT = 0x8867;
        public const ushort MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
        public const ushort MAX_VERTEX_ATTRIBS = 0x8869; // GetPName
        public const ushort MAX_VERTEX_ATTRIBS_ARB = 0x8869;
        public const ushort VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
        // Unused 0x886B. 
        public const ushort MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const ushort MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT = 0x886C;
        public const ushort MAX_TESS_CONTROL_INPUT_COMPONENTS_OES = 0x886C;
        public const ushort MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const ushort MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT = 0x886D;
        public const ushort MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES = 0x886D;
        public const ushort DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
        public const ushort DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
        public const ushort FRAGMENT_PROGRAM_NV = 0x8870;
        public const ushort MAX_TEXTURE_COORDS = 0x8871;
        public const ushort MAX_TEXTURE_COORDS_ARB = 0x8871;
        public const ushort MAX_TEXTURE_COORDS_NV = 0x8871;
        public const ushort MAX_TEXTURE_IMAGE_UNITS = 0x8872; // GetPName
        public const ushort MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
        public const ushort MAX_TEXTURE_IMAGE_UNITS_NV = 0x8872;
        public const ushort FRAGMENT_PROGRAM_BINDING_NV = 0x8873;
        public const ushort PROGRAM_ERROR_STRING_ARB = 0x8874;
        public const ushort PROGRAM_ERROR_STRING_NV = 0x8874;
        public const ushort PROGRAM_FORMAT_ASCII_ARB = 0x8875; // ProgramFormat
        public const ushort PROGRAM_FORMAT_ARB = 0x8876;
        // Unused 0x8877. Should have been assigned to PROGRAM_BINDING_ARB
        public const ushort WRITE_PIXEL_DATA_RANGE_NV = 0x8878; // PixelDataRangeTargetNV
        public const ushort READ_PIXEL_DATA_RANGE_NV = 0x8879; // PixelDataRangeTargetNV
        public const ushort WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
        public const ushort READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
        public const ushort WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
        public const ushort READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
        // Unused 0x887E. 
        public const ushort GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const ushort GEOMETRY_SHADER_INVOCATIONS_EXT = 0x887F;
        public const ushort GEOMETRY_SHADER_INVOCATIONS_OES = 0x887F;
        public const ushort FLOAT_R_NV = 0x8880;
        public const ushort FLOAT_RG_NV = 0x8881;
        public const ushort FLOAT_RGB_NV = 0x8882;
        public const ushort FLOAT_RGBA_NV = 0x8883;
        public const ushort FLOAT_R16_NV = 0x8884;
        public const ushort FLOAT_R32_NV = 0x8885;
        public const ushort FLOAT_RG16_NV = 0x8886;
        public const ushort FLOAT_RG32_NV = 0x8887;
        public const ushort FLOAT_RGB16_NV = 0x8888;
        public const ushort FLOAT_RGB32_NV = 0x8889;
        public const ushort FLOAT_RGBA16_NV = 0x888A;
        public const ushort FLOAT_RGBA32_NV = 0x888B;
        public const ushort TEXTURE_FLOAT_COMPONENTS_NV = 0x888C;
        public const ushort FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D;
        public const ushort FLOAT_RGBA_MODE_NV = 0x888E;
        public const ushort TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;
        public const ushort DEPTH_BOUNDS_TEST_EXT = 0x8890;
        public const ushort DEPTH_BOUNDS_EXT = 0x8891;
        public const ushort ARRAY_BUFFER = 0x8892; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort ARRAY_BUFFER_ARB = 0x8892;
        public const ushort ELEMENT_ARRAY_BUFFER = 0x8893; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
        public const ushort ARRAY_BUFFER_BINDING = 0x8894; // GetPName
        public const ushort ARRAY_BUFFER_BINDING_ARB = 0x8894;
        public const ushort ELEMENT_ARRAY_BUFFER_BINDING = 0x8895; // GetPName
        public const ushort ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
        public const ushort VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
        public const ushort VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
        public const ushort NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
        public const ushort NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
        public const ushort COLOR_ARRAY_BUFFER_BINDING = 0x8898;
        public const ushort COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
        public const ushort INDEX_ARRAY_BUFFER_BINDING = 0x8899;
        public const ushort INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
        public const ushort TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
        public const ushort TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
        public const ushort EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
        public const ushort EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
        public const ushort SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
        public const ushort SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
        public const ushort FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
        public const ushort FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        // Alias of GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING
        public const ushort FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
        public const ushort WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
        public const ushort WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
        public const ushort WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E;
        public const ushort VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F; // VertexAttribEnum,VertexAttribPropertyARB
        public const ushort VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
        public const ushort PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
        public const ushort MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
        public const ushort PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
        public const ushort MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
        public const ushort PROGRAM_TEMPORARIES_ARB = 0x88A4;
        public const ushort MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
        public const ushort PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
        public const ushort MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
        public const ushort PROGRAM_PARAMETERS_ARB = 0x88A8;
        public const ushort MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
        public const ushort PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
        public const ushort MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
        public const ushort PROGRAM_ATTRIBS_ARB = 0x88AC;
        public const ushort MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
        public const ushort PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
        public const ushort MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
        public const ushort PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
        public const ushort MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
        public const ushort PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
        public const ushort MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
        public const ushort MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
        public const ushort MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
        public const ushort PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
        public const ushort TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
        public const ushort READ_ONLY = 0x88B8; // BufferAccessARB
        public const ushort READ_ONLY_ARB = 0x88B8;
        public const ushort WRITE_ONLY = 0x88B9; // BufferAccessARB
        public const ushort WRITE_ONLY_ARB = 0x88B9;
        public const ushort WRITE_ONLY_OES = 0x88B9;
        public const ushort READ_WRITE = 0x88BA; // BufferAccessARB
        public const ushort READ_WRITE_ARB = 0x88BA;
        public const ushort BUFFER_ACCESS = 0x88BB; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_ACCESS_ARB = 0x88BB; // BufferPNameARB
        public const ushort BUFFER_ACCESS_OES = 0x88BB;
        public const ushort BUFFER_MAPPED = 0x88BC; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_MAPPED_ARB = 0x88BC; // BufferPNameARB
        public const ushort BUFFER_MAPPED_OES = 0x88BC;
        public const ushort BUFFER_MAP_POINTER = 0x88BD; // BufferPointerNameARB
        public const ushort BUFFER_MAP_POINTER_ARB = 0x88BD; // BufferPointerNameARB
        public const ushort BUFFER_MAP_POINTER_OES = 0x88BD;
        public const ushort WRITE_DISCARD_NV = 0x88BE;
        public const ushort TIME_ELAPSED = 0x88BF; // QueryTarget
        public const ushort TIME_ELAPSED_EXT = 0x88BF;
        public const ushort MATRIX0_ARB = 0x88C0;
        public const ushort MATRIX1_ARB = 0x88C1;
        public const ushort MATRIX2_ARB = 0x88C2;
        public const ushort MATRIX3_ARB = 0x88C3;
        public const ushort MATRIX4_ARB = 0x88C4;
        public const ushort MATRIX5_ARB = 0x88C5;
        public const ushort MATRIX6_ARB = 0x88C6;
        public const ushort MATRIX7_ARB = 0x88C7;
        public const ushort MATRIX8_ARB = 0x88C8;
        public const ushort MATRIX9_ARB = 0x88C9;
        public const ushort MATRIX10_ARB = 0x88CA;
        public const ushort MATRIX11_ARB = 0x88CB;
        public const ushort MATRIX12_ARB = 0x88CC;
        public const ushort MATRIX13_ARB = 0x88CD;
        public const ushort MATRIX14_ARB = 0x88CE;
        public const ushort MATRIX15_ARB = 0x88CF;
        public const ushort MATRIX16_ARB = 0x88D0;
        public const ushort MATRIX17_ARB = 0x88D1;
        public const ushort MATRIX18_ARB = 0x88D2;
        public const ushort MATRIX19_ARB = 0x88D3;
        public const ushort MATRIX20_ARB = 0x88D4;
        public const ushort MATRIX21_ARB = 0x88D5;
        public const ushort MATRIX22_ARB = 0x88D6;
        public const ushort MATRIX23_ARB = 0x88D7;
        public const ushort MATRIX24_ARB = 0x88D8;
        public const ushort MATRIX25_ARB = 0x88D9;
        public const ushort MATRIX26_ARB = 0x88DA;
        public const ushort MATRIX27_ARB = 0x88DB;
        public const ushort MATRIX28_ARB = 0x88DC;
        public const ushort MATRIX29_ARB = 0x88DD;
        public const ushort MATRIX30_ARB = 0x88DE;
        public const ushort MATRIX31_ARB = 0x88DF;
        public const ushort STREAM_DRAW = 0x88E0; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STREAM_DRAW_ARB = 0x88E0;
        public const ushort STREAM_READ = 0x88E1; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STREAM_READ_ARB = 0x88E1;
        public const ushort STREAM_COPY = 0x88E2; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STREAM_COPY_ARB = 0x88E2;
        // Unused 0x88E3. To extend ARB_vbo
        public const ushort STATIC_DRAW = 0x88E4; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STATIC_DRAW_ARB = 0x88E4;
        public const ushort STATIC_READ = 0x88E5; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STATIC_READ_ARB = 0x88E5;
        public const ushort STATIC_COPY = 0x88E6; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort STATIC_COPY_ARB = 0x88E6;
        // Unused 0x88E7. To extend ARB_vbo
        public const ushort DYNAMIC_DRAW = 0x88E8; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort DYNAMIC_DRAW_ARB = 0x88E8;
        public const ushort DYNAMIC_READ = 0x88E9; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort DYNAMIC_READ_ARB = 0x88E9;
        public const ushort DYNAMIC_COPY = 0x88EA; // VertexBufferObjectUsage,BufferUsageARB
        public const ushort DYNAMIC_COPY_ARB = 0x88EA;
        public const ushort PIXEL_PACK_BUFFER = 0x88EB; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort PIXEL_PACK_BUFFER_ARB = 0x88EB;
        public const ushort PIXEL_PACK_BUFFER_EXT = 0x88EB;
        public const ushort PIXEL_PACK_BUFFER_NV = 0x88EB;
        public const ushort PIXEL_UNPACK_BUFFER = 0x88EC; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
        public const ushort PIXEL_UNPACK_BUFFER_EXT = 0x88EC;
        public const ushort PIXEL_UNPACK_BUFFER_NV = 0x88EC;
        public const ushort PIXEL_PACK_BUFFER_BINDING = 0x88ED; // GetPName
        public const ushort PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
        public const ushort PIXEL_PACK_BUFFER_BINDING_EXT = 0x88ED;
        public const ushort PIXEL_PACK_BUFFER_BINDING_NV = 0x88ED;
        public const ushort ETC1_SRGB8_NV = 0x88EE;
        public const ushort PIXEL_UNPACK_BUFFER_BINDING = 0x88EF; // GetPName
        public const ushort PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;
        public const ushort PIXEL_UNPACK_BUFFER_BINDING_EXT = 0x88EF;
        public const ushort PIXEL_UNPACK_BUFFER_BINDING_NV = 0x88EF;
        public const ushort DEPTH24_STENCIL8 = 0x88F0; // InternalFormat
        public const ushort DEPTH24_STENCIL8_EXT = 0x88F0; // InternalFormat
        public const ushort DEPTH24_STENCIL8_OES = 0x88F0; // InternalFormat
        public const ushort TEXTURE_STENCIL_SIZE = 0x88F1;
        public const ushort TEXTURE_STENCIL_SIZE_EXT = 0x88F1;
        public const ushort STENCIL_TAG_BITS_EXT = 0x88F2;
        public const ushort STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;
        public const ushort MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        public const ushort MAX_PROGRAM_CALL_DEPTH_NV = 0x88F5;
        public const ushort MAX_PROGRAM_IF_DEPTH_NV = 0x88F6;
        public const ushort MAX_PROGRAM_LOOP_DEPTH_NV = 0x88F7;
        public const ushort MAX_PROGRAM_LOOP_COUNT_NV = 0x88F8;
        public const ushort SRC1_COLOR = 0x88F9; // BlendingFactor
        public const ushort SRC1_COLOR_EXT = 0x88F9;
        public const ushort ONE_MINUS_SRC1_COLOR = 0x88FA; // BlendingFactor
        public const ushort ONE_MINUS_SRC1_COLOR_EXT = 0x88FA;
        public const ushort ONE_MINUS_SRC1_ALPHA = 0x88FB; // BlendingFactor
        public const ushort ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB;
        public const ushort MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC; // GetPName
        public const ushort MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC;
        public const ushort VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD; // VertexAttribPropertyARB
        public const ushort VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;
        public const ushort VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE; // VertexAttribEnum,VertexAttribPropertyARB,VertexArrayPName
        public const ushort VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE = 0x88FE;
        public const ushort VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
        public const ushort VERTEX_ATTRIB_ARRAY_DIVISOR_EXT = 0x88FE;
        public const ushort VERTEX_ATTRIB_ARRAY_DIVISOR_NV = 0x88FE;
        public const ushort MAX_ARRAY_TEXTURE_LAYERS = 0x88FF; // GetPName
        public const ushort MAX_ARRAY_TEXTURE_LAYERS_EXT = 0x88FF;
        public const ushort MIN_PROGRAM_TEXEL_OFFSET = 0x8904; // GetPName
        public const ushort MIN_PROGRAM_TEXEL_OFFSET_EXT = 0x8904;
        public const ushort MIN_PROGRAM_TEXEL_OFFSET_NV = 0x8904;
        public const ushort MAX_PROGRAM_TEXEL_OFFSET = 0x8905; // GetPName
        public const ushort MAX_PROGRAM_TEXEL_OFFSET_EXT = 0x8905;
        public const ushort MAX_PROGRAM_TEXEL_OFFSET_NV = 0x8905;
        public const ushort PROGRAM_ATTRIB_COMPONENTS_NV = 0x8906;
        public const ushort PROGRAM_RESULT_COMPONENTS_NV = 0x8907;
        public const ushort MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
        public const ushort MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
        public const ushort STENCIL_TEST_TWO_SIDE_EXT = 0x8910;
        public const ushort ACTIVE_STENCIL_FACE_EXT = 0x8911;
        public const ushort MIRROR_CLAMP_TO_BORDER_EXT = 0x8912;
        // Unused 0x8913. 
        public const ushort SAMPLES_PASSED = 0x8914; // QueryTarget
        public const ushort SAMPLES_PASSED_ARB = 0x8914;
        // Unused 0x8915. 
        public const ushort GEOMETRY_VERTICES_OUT = 0x8916; // ProgramPropertyARB
        public const ushort GEOMETRY_LINKED_VERTICES_OUT_EXT = 0x8916;
        public const ushort GEOMETRY_LINKED_VERTICES_OUT_OES = 0x8916;
        public const ushort GEOMETRY_INPUT_TYPE = 0x8917; // ProgramPropertyARB
        public const ushort GEOMETRY_LINKED_INPUT_TYPE_EXT = 0x8917;
        public const ushort GEOMETRY_LINKED_INPUT_TYPE_OES = 0x8917;
        public const ushort GEOMETRY_OUTPUT_TYPE = 0x8918; // ProgramPropertyARB
        public const ushort GEOMETRY_LINKED_OUTPUT_TYPE_EXT = 0x8918;
        public const ushort GEOMETRY_LINKED_OUTPUT_TYPE_OES = 0x8918;
        public const ushort SAMPLER_BINDING = 0x8919; // GetPName
        public const ushort CLAMP_VERTEX_COLOR = 0x891A;
        public const ushort CLAMP_VERTEX_COLOR_ARB = 0x891A; // ClampColorTargetARB
        public const ushort CLAMP_FRAGMENT_COLOR = 0x891B;
        public const ushort CLAMP_FRAGMENT_COLOR_ARB = 0x891B; // ClampColorTargetARB
        public const ushort CLAMP_READ_COLOR = 0x891C; // ClampColorTargetARB
        public const ushort CLAMP_READ_COLOR_ARB = 0x891C; // ClampColorTargetARB
        public const ushort FIXED_ONLY = 0x891D; // ClampColorModeARB
        public const ushort FIXED_ONLY_ARB = 0x891D; // ClampColorModeARB
        public const ushort TESS_CONTROL_PROGRAM_NV = 0x891E; // ProgramTarget
        public const ushort TESS_EVALUATION_PROGRAM_NV = 0x891F; // ProgramTarget
        
        // . 
        public const ushort FRAGMENT_SHADER_ATI = 0x8920;
        public const ushort REG_0_ATI = 0x8921;
        public const ushort REG_1_ATI = 0x8922;
        public const ushort REG_2_ATI = 0x8923;
        public const ushort REG_3_ATI = 0x8924;
        public const ushort REG_4_ATI = 0x8925;
        public const ushort REG_5_ATI = 0x8926;
        public const ushort REG_6_ATI = 0x8927;
        public const ushort REG_7_ATI = 0x8928;
        public const ushort REG_8_ATI = 0x8929;
        public const ushort REG_9_ATI = 0x892A;
        public const ushort REG_10_ATI = 0x892B;
        public const ushort REG_11_ATI = 0x892C;
        public const ushort REG_12_ATI = 0x892D;
        public const ushort REG_13_ATI = 0x892E;
        public const ushort REG_14_ATI = 0x892F;
        public const ushort REG_15_ATI = 0x8930;
        public const ushort REG_16_ATI = 0x8931;
        public const ushort REG_17_ATI = 0x8932;
        public const ushort REG_18_ATI = 0x8933;
        public const ushort REG_19_ATI = 0x8934;
        public const ushort REG_20_ATI = 0x8935;
        public const ushort REG_21_ATI = 0x8936;
        public const ushort REG_22_ATI = 0x8937;
        public const ushort REG_23_ATI = 0x8938;
        public const ushort REG_24_ATI = 0x8939;
        public const ushort REG_25_ATI = 0x893A;
        public const ushort REG_26_ATI = 0x893B;
        public const ushort REG_27_ATI = 0x893C;
        public const ushort REG_28_ATI = 0x893D;
        public const ushort REG_29_ATI = 0x893E;
        public const ushort REG_30_ATI = 0x893F;
        public const ushort REG_31_ATI = 0x8940;
        public const ushort CON_0_ATI = 0x8941;
        public const ushort CON_1_ATI = 0x8942;
        public const ushort CON_2_ATI = 0x8943;
        public const ushort CON_3_ATI = 0x8944;
        public const ushort CON_4_ATI = 0x8945;
        public const ushort CON_5_ATI = 0x8946;
        public const ushort CON_6_ATI = 0x8947;
        public const ushort CON_7_ATI = 0x8948;
        public const ushort CON_8_ATI = 0x8949;
        public const ushort CON_9_ATI = 0x894A;
        public const ushort CON_10_ATI = 0x894B;
        public const ushort CON_11_ATI = 0x894C;
        public const ushort CON_12_ATI = 0x894D;
        public const ushort CON_13_ATI = 0x894E;
        public const ushort CON_14_ATI = 0x894F;
        public const ushort CON_15_ATI = 0x8950;
        public const ushort CON_16_ATI = 0x8951;
        public const ushort CON_17_ATI = 0x8952;
        public const ushort CON_18_ATI = 0x8953;
        public const ushort CON_19_ATI = 0x8954;
        public const ushort CON_20_ATI = 0x8955;
        public const ushort CON_21_ATI = 0x8956;
        public const ushort CON_22_ATI = 0x8957;
        public const ushort CON_23_ATI = 0x8958;
        public const ushort CON_24_ATI = 0x8959;
        public const ushort CON_25_ATI = 0x895A;
        public const ushort CON_26_ATI = 0x895B;
        public const ushort CON_27_ATI = 0x895C;
        public const ushort CON_28_ATI = 0x895D;
        public const ushort CON_29_ATI = 0x895E;
        public const ushort CON_30_ATI = 0x895F;
        public const ushort CON_31_ATI = 0x8960;
        public const ushort MOV_ATI = 0x8961; // FragmentOpATI
        public const ushort ADD_ATI = 0x8963; // FragmentOpATI
        public const ushort MUL_ATI = 0x8964; // FragmentOpATI
        public const ushort SUB_ATI = 0x8965; // FragmentOpATI
        public const ushort DOT3_ATI = 0x8966; // FragmentOpATI
        public const ushort DOT4_ATI = 0x8967; // FragmentOpATI
        public const ushort MAD_ATI = 0x8968; // FragmentOpATI
        public const ushort LERP_ATI = 0x8969; // FragmentOpATI
        public const ushort CND_ATI = 0x896A; // FragmentOpATI
        public const ushort CND0_ATI = 0x896B; // FragmentOpATI
        public const ushort DOT2_ADD_ATI = 0x896C; // FragmentOpATI
        public const ushort SECONDARY_INTERPOLATOR_ATI = 0x896D;
        public const ushort NUM_FRAGMENT_REGISTERS_ATI = 0x896E;
        public const ushort NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;
        public const ushort NUM_PASSES_ATI = 0x8970;
        public const ushort NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;
        public const ushort NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;
        public const ushort NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
        public const ushort NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;
        public const ushort COLOR_ALPHA_PAIRING_ATI = 0x8975;
        public const ushort SWIZZLE_STR_ATI = 0x8976; // SwizzleOpATI
        public const ushort SWIZZLE_STQ_ATI = 0x8977; // SwizzleOpATI
        public const ushort SWIZZLE_STR_DR_ATI = 0x8978; // SwizzleOpATI
        public const ushort SWIZZLE_STQ_DQ_ATI = 0x8979; // SwizzleOpATI
        public const ushort SWIZZLE_STRQ_ATI = 0x897A;
        public const ushort SWIZZLE_STRQ_DQ_ATI = 0x897B;
        // Unused 0x897C..0x897F. 
        
        // . 
        public const ushort INTERLACE_OML = 0x8980;
        public const ushort INTERLACE_READ_OML = 0x8981;
        public const ushort FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
        public const ushort FORMAT_SUBSAMPLE_244_244_OML = 0x8983;
        public const ushort PACK_RESAMPLE_OML = 0x8984; // PixelStoreParameter
        public const ushort UNPACK_RESAMPLE_OML = 0x8985; // PixelStoreParameter
        public const ushort RESAMPLE_REPLICATE_OML = 0x8986;
        public const ushort RESAMPLE_ZERO_FILL_OML = 0x8987;
        public const ushort RESAMPLE_AVERAGE_OML = 0x8988;
        public const ushort RESAMPLE_DECIMATE_OML = 0x8989;
        public const ushort POINT_SIZE_ARRAY_TYPE_OES = 0x898A;
        public const ushort POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;
        public const ushort POINT_SIZE_ARRAY_POINTER_OES = 0x898C;
        public const ushort MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D;
        public const ushort PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E;
        public const ushort TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F;
        
        // . 
        // Unused 0x8990..0x899F. 
        
        // . 
        // Unused 0x89A0..0x89FF. 
        
        // . 
        public const ushort VERTEX_ATTRIB_MAP1_APPLE = 0x8A00;
        public const ushort VERTEX_ATTRIB_MAP2_APPLE = 0x8A01;
        public const ushort VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02;
        public const ushort VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03;
        public const ushort VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04;
        public const ushort VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05;
        public const ushort VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06;
        public const ushort VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07;
        public const ushort VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08;
        public const ushort VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09;
        public const ushort DRAW_PIXELS_APPLE = 0x8A0A; // ObjectTypeAPPLE
        public const ushort FENCE_APPLE = 0x8A0B; // ObjectTypeAPPLE
        public const ushort ELEMENT_ARRAY_APPLE = 0x8A0C;
        public const ushort ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;
        public const ushort ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;
        public const ushort COLOR_FLOAT_APPLE = 0x8A0F;
        // Unused 0x8A10. Unknown extension (Khronos error #632)
        public const ushort UNIFORM_BUFFER = 0x8A11; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
        public const ushort BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;
        public const ushort AUX_DEPTH_STENCIL_APPLE = 0x8A14;
        public const ushort PACK_ROW_BYTES_APPLE = 0x8A15;
        public const ushort UNPACK_ROW_BYTES_APPLE = 0x8A16;
        // Unused 0x8A17..0x8A18. 
        public const ushort RELEASED_APPLE = 0x8A19;
        public const ushort VOLATILE_APPLE = 0x8A1A;
        public const ushort RETAINED_APPLE = 0x8A1B;
        public const ushort UNDEFINED_APPLE = 0x8A1C;
        public const ushort PURGEABLE_APPLE = 0x8A1D;
        // Unused 0x8A1E. 
        public const ushort RGB_422_APPLE = 0x8A1F;
        // Unused 0x8A20..0x8A27. 
        public const ushort UNIFORM_BUFFER_BINDING = 0x8A28; // GetPName
        public const ushort UNIFORM_BUFFER_START = 0x8A29; // GetPName
        public const ushort UNIFORM_BUFFER_SIZE = 0x8A2A; // GetPName
        public const ushort MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B; // GetPName
        public const ushort MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C; // GetPName
        public const ushort MAX_GEOMETRY_UNIFORM_BLOCKS_EXT = 0x8A2C;
        public const ushort MAX_GEOMETRY_UNIFORM_BLOCKS_OES = 0x8A2C;
        public const ushort MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D; // GetPName
        public const ushort MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E; // GetPName
        public const ushort MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F; // GetPName
        public const ushort MAX_UNIFORM_BLOCK_SIZE = 0x8A30; // GetPName
        public const ushort MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31; // GetPName
        public const ushort MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32; // GetPName
        public const ushort MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8A32;
        public const ushort MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8A32;
        public const ushort MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33; // GetPName
        public const ushort UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34; // GetPName
        public const ushort ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35; // ProgramPropertyARB
        public const ushort ACTIVE_UNIFORM_BLOCKS = 0x8A36; // ProgramPropertyARB
        public const ushort UNIFORM_TYPE = 0x8A37; // UniformPName
        public const ushort UNIFORM_SIZE = 0x8A38; // SubroutineParameterName,UniformPName
        public const ushort UNIFORM_NAME_LENGTH = 0x8A39; // SubroutineParameterName,UniformPName
        public const ushort UNIFORM_BLOCK_INDEX = 0x8A3A; // UniformPName
        public const ushort UNIFORM_OFFSET = 0x8A3B; // UniformPName
        public const ushort UNIFORM_ARRAY_STRIDE = 0x8A3C; // UniformPName
        public const ushort UNIFORM_MATRIX_STRIDE = 0x8A3D; // UniformPName
        public const ushort UNIFORM_IS_ROW_MAJOR = 0x8A3E; // UniformPName
        public const ushort UNIFORM_BLOCK_BINDING = 0x8A3F; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_DATA_SIZE = 0x8A40; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_NAME_LENGTH = 0x8A41; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45; // UniformBlockPName
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46; // UniformBlockPName
        // Unused 0x8A47. 
        public const ushort TEXTURE_SRGB_DECODE_EXT = 0x8A48;
        public const ushort DECODE_EXT = 0x8A49;
        public const ushort SKIP_DECODE_EXT = 0x8A4A;
        // Unused 0x8A4B..0x8A4E. 
        public const ushort PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;
        // Unused 0x8A50. 
        public const ushort RGB_RAW_422_APPLE = 0x8A51;
        public const ushort FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT = 0x8A52;
        public const ushort SYNC_OBJECT_APPLE = 0x8A53;
        public const ushort COMPRESSED_SRGB_PVRTC_2BPPV1_EXT = 0x8A54;
        public const ushort COMPRESSED_SRGB_PVRTC_4BPPV1_EXT = 0x8A55;
        public const ushort COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT = 0x8A56;
        public const ushort COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT = 0x8A57;
        // Unused 0x8A58..0x8A7F. 
        
        // . 
        // Unused 0x8A80..0x8AEF. 
        
        // . For Brian Paul
        // Unused 0x8AF0..0x8B2F. 
        
        // ShaderType. 
        public const ushort FRAGMENT_SHADER = 0x8B30; // PipelineParameterName
        public const ushort FRAGMENT_SHADER_ARB = 0x8B30;
        public const ushort VERTEX_SHADER = 0x8B31; // PipelineParameterName
        public const ushort VERTEX_SHADER_ARB = 0x8B31;
        // Unused 0x8B32..0x8B3F. For shader types
        
        // ContainerType. 
        public const ushort PROGRAM_OBJECT_ARB = 0x8B40;
        public const ushort PROGRAM_OBJECT_EXT = 0x8B40;
        // Unused 0x8B41..0x8B47. For container types
        
        // . 
        public const ushort SHADER_OBJECT_ARB = 0x8B48;
        public const ushort SHADER_OBJECT_EXT = 0x8B48;
        public const ushort MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49; // GetPName
        public const ushort MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
        public const ushort MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A; // GetPName
        public const ushort MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
        public const ushort MAX_VARYING_FLOATS = 0x8B4B; // GetPName
        // Alias of MAX_VARYING_FLOATS
        public const ushort MAX_VARYING_COMPONENTS = 0x8B4B; // GetPName
        public const ushort MAX_VARYING_COMPONENTS_EXT = 0x8B4B;
        public const ushort MAX_VARYING_FLOATS_ARB = 0x8B4B;
        public const ushort MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C; // GetPName
        public const ushort MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
        public const ushort MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D; // GetPName
        public const ushort MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
        public const ushort OBJECT_TYPE_ARB = 0x8B4E;
        public const ushort SHADER_TYPE = 0x8B4F; // ShaderParameterName
        public const ushort OBJECT_SUBTYPE_ARB = 0x8B4F;
        
        // AttributeType. 
        public const ushort FLOAT_VEC2 = 0x8B50; // GlslTypeToken,UniformType
        public const ushort FLOAT_VEC2_ARB = 0x8B50;
        public const ushort FLOAT_VEC3 = 0x8B51; // GlslTypeToken,UniformType
        public const ushort FLOAT_VEC3_ARB = 0x8B51;
        public const ushort FLOAT_VEC4 = 0x8B52; // GlslTypeToken,UniformType
        public const ushort FLOAT_VEC4_ARB = 0x8B52;
        public const ushort INT_VEC2 = 0x8B53; // GlslTypeToken,UniformType
        public const ushort INT_VEC2_ARB = 0x8B53;
        public const ushort INT_VEC3 = 0x8B54; // GlslTypeToken,UniformType
        public const ushort INT_VEC3_ARB = 0x8B54;
        public const ushort INT_VEC4 = 0x8B55; // GlslTypeToken,UniformType
        public const ushort INT_VEC4_ARB = 0x8B55;
        public const ushort BOOL = 0x8B56; // GlslTypeToken,UniformType
        public const ushort BOOL_ARB = 0x8B56;
        public const ushort BOOL_VEC2 = 0x8B57; // GlslTypeToken,UniformType
        public const ushort BOOL_VEC2_ARB = 0x8B57;
        public const ushort BOOL_VEC3 = 0x8B58; // GlslTypeToken,UniformType
        public const ushort BOOL_VEC3_ARB = 0x8B58;
        public const ushort BOOL_VEC4 = 0x8B59; // GlslTypeToken,UniformType
        public const ushort BOOL_VEC4_ARB = 0x8B59;
        public const ushort FLOAT_MAT2 = 0x8B5A; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT2_ARB = 0x8B5A;
        public const ushort FLOAT_MAT3 = 0x8B5B; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT3_ARB = 0x8B5B;
        public const ushort FLOAT_MAT4 = 0x8B5C; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT4_ARB = 0x8B5C;
        public const ushort SAMPLER_1D = 0x8B5D; // GlslTypeToken,UniformType
        public const ushort SAMPLER_1D_ARB = 0x8B5D;
        public const ushort SAMPLER_2D = 0x8B5E; // GlslTypeToken,UniformType
        public const ushort SAMPLER_2D_ARB = 0x8B5E;
        public const ushort SAMPLER_3D = 0x8B5F; // GlslTypeToken,UniformType
        public const ushort SAMPLER_3D_ARB = 0x8B5F;
        public const ushort SAMPLER_3D_OES = 0x8B5F;
        public const ushort SAMPLER_CUBE = 0x8B60; // GlslTypeToken,UniformType
        public const ushort SAMPLER_CUBE_ARB = 0x8B60;
        public const ushort SAMPLER_1D_SHADOW = 0x8B61; // GlslTypeToken,UniformType
        public const ushort SAMPLER_1D_SHADOW_ARB = 0x8B61;
        public const ushort SAMPLER_2D_SHADOW = 0x8B62; // GlslTypeToken,UniformType
        public const ushort SAMPLER_2D_SHADOW_ARB = 0x8B62;
        public const ushort SAMPLER_2D_SHADOW_EXT = 0x8B62;
        public const ushort SAMPLER_2D_RECT = 0x8B63; // GlslTypeToken,UniformType
        public const ushort SAMPLER_2D_RECT_ARB = 0x8B63;
        public const ushort SAMPLER_2D_RECT_SHADOW = 0x8B64; // GlslTypeToken,UniformType
        public const ushort SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
        public const ushort FLOAT_MAT2x3 = 0x8B65; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT2x3_NV = 0x8B65;
        public const ushort FLOAT_MAT2x4 = 0x8B66; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT2x4_NV = 0x8B66;
        public const ushort FLOAT_MAT3x2 = 0x8B67; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT3x2_NV = 0x8B67;
        public const ushort FLOAT_MAT3x4 = 0x8B68; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT3x4_NV = 0x8B68;
        public const ushort FLOAT_MAT4x2 = 0x8B69; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT4x2_NV = 0x8B69;
        public const ushort FLOAT_MAT4x3 = 0x8B6A; // GlslTypeToken,UniformType
        public const ushort FLOAT_MAT4x3_NV = 0x8B6A;
        // Unused 0x8B6B..0x8B7F. For attribute types
        
        // . 
        public const ushort DELETE_STATUS = 0x8B80; // ProgramPropertyARB,ShaderParameterName
        public const ushort OBJECT_DELETE_STATUS_ARB = 0x8B80;
        public const ushort COMPILE_STATUS = 0x8B81; // ShaderParameterName
        public const ushort OBJECT_COMPILE_STATUS_ARB = 0x8B81;
        public const ushort LINK_STATUS = 0x8B82; // ProgramPropertyARB
        public const ushort OBJECT_LINK_STATUS_ARB = 0x8B82;
        public const ushort VALIDATE_STATUS = 0x8B83; // ProgramPropertyARB
        public const ushort OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
        public const ushort INFO_LOG_LENGTH = 0x8B84; // ProgramPropertyARB,ShaderParameterName,PipelineParameterName
        public const ushort OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
        public const ushort ATTACHED_SHADERS = 0x8B85; // ProgramPropertyARB
        public const ushort OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
        public const ushort ACTIVE_UNIFORMS = 0x8B86; // ProgramPropertyARB
        public const ushort OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
        public const ushort ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87; // ProgramPropertyARB
        public const ushort OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
        public const ushort SHADER_SOURCE_LENGTH = 0x8B88; // ShaderParameterName
        public const ushort OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;
        public const ushort ACTIVE_ATTRIBUTES = 0x8B89; // ProgramPropertyARB
        public const ushort OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
        public const ushort ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A; // ProgramPropertyARB
        public const ushort OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
        public const ushort FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B; // HintTarget,GetPName
        public const ushort FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B; // HintTarget
        public const ushort FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B; // HintTarget
        public const ushort SHADING_LANGUAGE_VERSION = 0x8B8C; // StringName
        public const ushort SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;
        public const ushort CURRENT_PROGRAM = 0x8B8D; // GetPName
        // Alias of GL_CURRENT_PROGRAM
        // For the OpenGL version of EXT_separate_shader_objects
        public const ushort ACTIVE_PROGRAM_EXT = 0x8B8D;
        // Unused 0x8B8E..0x8B8F. 
        
        // . 
        public const ushort PALETTE4_RGB8_OES = 0x8B90;
        public const ushort PALETTE4_RGBA8_OES = 0x8B91;
        public const ushort PALETTE4_R5_G6_B5_OES = 0x8B92;
        public const ushort PALETTE4_RGBA4_OES = 0x8B93;
        public const ushort PALETTE4_RGB5_A1_OES = 0x8B94;
        public const ushort PALETTE8_RGB8_OES = 0x8B95;
        public const ushort PALETTE8_RGBA8_OES = 0x8B96;
        public const ushort PALETTE8_R5_G6_B5_OES = 0x8B97;
        public const ushort PALETTE8_RGBA4_OES = 0x8B98;
        public const ushort PALETTE8_RGB5_A1_OES = 0x8B99;
        public const ushort IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A; // GetFramebufferParameter,GetPName
        public const ushort IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;
        public const ushort IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B; // GetFramebufferParameter,GetPName
        public const ushort IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;
        public const ushort POINT_SIZE_ARRAY_OES = 0x8B9C;
        public const ushort TEXTURE_CROP_RECT_OES = 0x8B9D;
        public const ushort MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E;
        public const ushort POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;
        
        // . 
        // Unused 0x8BA0..0x8BAF. 
        
        // . 
        public const ushort FRAGMENT_PROGRAM_POSITION_MESA = 0x8BB0;
        public const ushort FRAGMENT_PROGRAM_CALLBACK_MESA = 0x8BB1;
        public const ushort FRAGMENT_PROGRAM_CALLBACK_FUNC_MESA = 0x8BB2;
        public const ushort FRAGMENT_PROGRAM_CALLBACK_DATA_MESA = 0x8BB3;
        public const ushort VERTEX_PROGRAM_POSITION_MESA = 0x8BB4;
        public const ushort VERTEX_PROGRAM_CALLBACK_MESA = 0x8BB5;
        public const ushort VERTEX_PROGRAM_CALLBACK_FUNC_MESA = 0x8BB6;
        public const ushort VERTEX_PROGRAM_CALLBACK_DATA_MESA = 0x8BB7;
        public const ushort TILE_RASTER_ORDER_FIXED_MESA = 0x8BB8;
        public const ushort TILE_RASTER_ORDER_INCREASING_X_MESA = 0x8BB9;
        public const ushort TILE_RASTER_ORDER_INCREASING_Y_MESA = 0x8BBA;
        public const ushort FRAMEBUFFER_FLIP_Y_MESA = 0x8BBB;
        public const ushort FRAMEBUFFER_FLIP_X_MESA = 0x8BBC;
        public const ushort FRAMEBUFFER_SWAP_XY_MESA = 0x8BBD;
        
        // . Reassigned from AMD to QCOM
        public const ushort COUNTER_TYPE_AMD = 0x8BC0;
        public const ushort COUNTER_RANGE_AMD = 0x8BC1;
        public const ushort UNSIGNED_INT64_AMD = 0x8BC2;
        public const ushort PERCENTAGE_AMD = 0x8BC3;
        public const ushort PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;
        public const ushort PERFMON_RESULT_SIZE_AMD = 0x8BC5;
        public const ushort PERFMON_RESULT_AMD = 0x8BC6;
        // Unused 0x8BC7..0x8BD1. 
        public const ushort TEXTURE_WIDTH_QCOM = 0x8BD2;
        public const ushort TEXTURE_HEIGHT_QCOM = 0x8BD3;
        public const ushort TEXTURE_DEPTH_QCOM = 0x8BD4;
        public const ushort TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5;
        public const ushort TEXTURE_FORMAT_QCOM = 0x8BD6;
        public const ushort TEXTURE_TYPE_QCOM = 0x8BD7;
        public const ushort TEXTURE_IMAGE_VALID_QCOM = 0x8BD8;
        public const ushort TEXTURE_NUM_LEVELS_QCOM = 0x8BD9;
        public const ushort TEXTURE_TARGET_QCOM = 0x8BDA;
        public const ushort TEXTURE_OBJECT_VALID_QCOM = 0x8BDB;
        public const ushort STATE_RESTORE = 0x8BDC;
        // Unused 0x8BDD..0x8BE6. 
        public const ushort SAMPLER_EXTERNAL_2D_Y2Y_EXT = 0x8BE7;
        // Unused 0x8BE8..0x8BEF. 
        public const ushort TEXTURE_PROTECTED_EXT = 0x8BFA;
        public const ushort TEXTURE_FOVEATED_FEATURE_BITS_QCOM = 0x8BFB;
        public const ushort TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM = 0x8BFC;
        public const ushort TEXTURE_FOVEATED_FEATURE_QUERY_QCOM = 0x8BFD;
        public const ushort TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM = 0x8BFE;
        public const ushort FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM = 0x8BFF;
        
        // . 
        public const ushort COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00;
        public const ushort COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01;
        public const ushort COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02;
        public const ushort COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03;
        public const ushort MODULATE_COLOR_IMG = 0x8C04;
        public const ushort RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05;
        public const ushort TEXTURE_ALPHA_MODULATE_IMG = 0x8C06;
        public const ushort FACTOR_ALPHA_MODULATE_IMG = 0x8C07;
        public const ushort FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08;
        public const ushort ADD_BLEND_IMG = 0x8C09;
        public const ushort SGX_BINARY_IMG = 0x8C0A;
        // Unused 0x8C0B..0x8C0F. 
        
        // . For Pat Brown
        public const ushort TEXTURE_RED_TYPE = 0x8C10;
        public const ushort TEXTURE_RED_TYPE_ARB = 0x8C10;
        public const ushort TEXTURE_GREEN_TYPE = 0x8C11;
        public const ushort TEXTURE_GREEN_TYPE_ARB = 0x8C11;
        public const ushort TEXTURE_BLUE_TYPE = 0x8C12;
        public const ushort TEXTURE_BLUE_TYPE_ARB = 0x8C12;
        public const ushort TEXTURE_ALPHA_TYPE = 0x8C13;
        public const ushort TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
        public const ushort TEXTURE_LUMINANCE_TYPE = 0x8C14;
        public const ushort TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
        public const ushort TEXTURE_INTENSITY_TYPE = 0x8C15;
        public const ushort TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
        public const ushort TEXTURE_DEPTH_TYPE = 0x8C16;
        public const ushort TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
        public const ushort UNSIGNED_NORMALIZED = 0x8C17;
        public const ushort UNSIGNED_NORMALIZED_ARB = 0x8C17;
        public const ushort UNSIGNED_NORMALIZED_EXT = 0x8C17;
        public const ushort TEXTURE_1D_ARRAY = 0x8C18; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_1D_ARRAY_EXT = 0x8C18;
        public const ushort PROXY_TEXTURE_1D_ARRAY = 0x8C19; // TextureTarget
        public const ushort PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19; // TextureTarget
        public const ushort TEXTURE_2D_ARRAY = 0x8C1A; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_2D_ARRAY_EXT = 0x8C1A;
        public const ushort PROXY_TEXTURE_2D_ARRAY = 0x8C1B; // TextureTarget
        public const ushort PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B; // TextureTarget
        public const ushort TEXTURE_BINDING_1D_ARRAY = 0x8C1C; // GetPName
        public const ushort TEXTURE_BINDING_1D_ARRAY_EXT = 0x8C1C;
        public const ushort TEXTURE_BINDING_2D_ARRAY = 0x8C1D; // GetPName
        public const ushort TEXTURE_BINDING_2D_ARRAY_EXT = 0x8C1D;
        // Unused 0x8C1E..0x8C25. 
        public const ushort GEOMETRY_PROGRAM_NV = 0x8C26; // ProgramTarget
        public const ushort MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
        public const ushort MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
        public const ushort MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29; // GetPName
        public const ushort MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
        public const ushort MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
        public const ushort MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES = 0x8C29;
        public const ushort TEXTURE_BUFFER = 0x8C2A; // TextureTarget,CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort TEXTURE_BUFFER_ARB = 0x8C2A;
        public const ushort TEXTURE_BUFFER_EXT = 0x8C2A;
        public const ushort TEXTURE_BUFFER_OES = 0x8C2A;
        // Equivalent to GL_TEXTURE_BUFFER_ARB query, but named more consistently
        public const ushort TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const ushort TEXTURE_BUFFER_BINDING_EXT = 0x8C2A;
        public const ushort TEXTURE_BUFFER_BINDING_OES = 0x8C2A;
        public const ushort MAX_TEXTURE_BUFFER_SIZE = 0x8C2B; // GetPName
        public const ushort MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
        public const ushort MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;
        public const ushort MAX_TEXTURE_BUFFER_SIZE_OES = 0x8C2B;
        public const ushort TEXTURE_BINDING_BUFFER = 0x8C2C; // GetPName
        public const ushort TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
        public const ushort TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;
        public const ushort TEXTURE_BINDING_BUFFER_OES = 0x8C2C;
        public const ushort TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const ushort TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
        public const ushort TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
        public const ushort TEXTURE_BUFFER_DATA_STORE_BINDING_OES = 0x8C2D;
        public const ushort TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
        public const ushort TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;
        public const ushort ANY_SAMPLES_PASSED = 0x8C2F; // QueryTarget
        public const ushort ANY_SAMPLES_PASSED_EXT = 0x8C2F;
        // Unused 0x8C30..0x8C35. 
        public const ushort SAMPLE_SHADING = 0x8C36; // EnableCap
        public const ushort SAMPLE_SHADING_ARB = 0x8C36;
        public const ushort SAMPLE_SHADING_OES = 0x8C36;
        public const ushort MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        public const ushort MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;
        public const ushort MIN_SAMPLE_SHADING_VALUE_OES = 0x8C37;
        // Unused 0x8C38..0x8C39. 
        public const ushort R11F_G11F_B10F = 0x8C3A; // InternalFormat
        public const ushort R11F_G11F_B10F_APPLE = 0x8C3A; // InternalFormat
        public const ushort R11F_G11F_B10F_EXT = 0x8C3A; // InternalFormat
        public const ushort UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B; // VertexAttribPointerType,VertexAttribType
        public const ushort UNSIGNED_INT_10F_11F_11F_REV_APPLE = 0x8C3B;
        public const ushort UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
        public const ushort RGBA_SIGNED_COMPONENTS_EXT = 0x8C3C;
        public const ushort RGB9_E5 = 0x8C3D; // InternalFormat
        public const ushort RGB9_E5_APPLE = 0x8C3D; // InternalFormat
        public const ushort RGB9_E5_EXT = 0x8C3D; // InternalFormat
        public const ushort UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const ushort UNSIGNED_INT_5_9_9_9_REV_APPLE = 0x8C3E;
        public const ushort UNSIGNED_INT_5_9_9_9_REV_EXT = 0x8C3E;
        public const ushort TEXTURE_SHARED_SIZE = 0x8C3F;
        public const ushort TEXTURE_SHARED_SIZE_EXT = 0x8C3F;
        public const ushort SRGB = 0x8C40; // InternalFormat
        public const ushort SRGB_EXT = 0x8C40; // InternalFormat
        public const ushort SRGB8 = 0x8C41; // InternalFormat
        public const ushort SRGB8_EXT = 0x8C41; // InternalFormat
        public const ushort SRGB8_NV = 0x8C41; // InternalFormat
        public const ushort SRGB_ALPHA = 0x8C42; // InternalFormat
        public const ushort SRGB_ALPHA_EXT = 0x8C42; // InternalFormat
        public const ushort SRGB8_ALPHA8 = 0x8C43; // InternalFormat
        public const ushort SRGB8_ALPHA8_EXT = 0x8C43; // InternalFormat
        public const ushort SLUMINANCE_ALPHA = 0x8C44;
        public const ushort SLUMINANCE_ALPHA_EXT = 0x8C44;
        public const ushort SLUMINANCE_ALPHA_NV = 0x8C44;
        public const ushort SLUMINANCE8_ALPHA8 = 0x8C45;
        public const ushort SLUMINANCE8_ALPHA8_EXT = 0x8C45;
        public const ushort SLUMINANCE8_ALPHA8_NV = 0x8C45;
        public const ushort SLUMINANCE = 0x8C46;
        public const ushort SLUMINANCE_EXT = 0x8C46;
        public const ushort SLUMINANCE_NV = 0x8C46;
        public const ushort SLUMINANCE8 = 0x8C47;
        public const ushort SLUMINANCE8_EXT = 0x8C47;
        public const ushort SLUMINANCE8_NV = 0x8C47;
        public const ushort COMPRESSED_SRGB = 0x8C48; // InternalFormat
        public const ushort COMPRESSED_SRGB_EXT = 0x8C48;
        public const ushort COMPRESSED_SRGB_ALPHA = 0x8C49; // InternalFormat
        public const ushort COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;
        public const ushort COMPRESSED_SLUMINANCE = 0x8C4A;
        public const ushort COMPRESSED_SLUMINANCE_EXT = 0x8C4A;
        public const ushort COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        public const ushort COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
        public const ushort COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C; // InternalFormat
        public const ushort COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C;
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D; // InternalFormat
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D;
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E; // InternalFormat
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E;
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F; // InternalFormat
        public const ushort COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F;
        // Unused 0x8C50..0x8C6F. 
        public const ushort COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
        public const ushort COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
        public const ushort COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
        public const ushort COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;
        public const ushort TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
        public const ushort TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;
        public const ushort TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76; // ProgramPropertyARB
        public const ushort TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;
        public const ushort BACK_PRIMARY_COLOR_NV = 0x8C77;
        public const ushort BACK_SECONDARY_COLOR_NV = 0x8C78;
        public const ushort TEXTURE_COORD_NV = 0x8C79;
        public const ushort CLIP_DISTANCE_NV = 0x8C7A;
        public const ushort VERTEX_ID_NV = 0x8C7B;
        public const ushort PRIMITIVE_ID_NV = 0x8C7C;
        public const ushort GENERIC_ATTRIB_NV = 0x8C7D;
        public const ushort TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F; // ProgramPropertyARB
        public const ushort TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;
        public const ushort ACTIVE_VARYINGS_NV = 0x8C81;
        public const ushort ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;
        public const ushort TRANSFORM_FEEDBACK_VARYINGS = 0x8C83; // ProgramPropertyARB
        public const ushort TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
        public const ushort TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84; // TransformFeedbackPName,GetPName
        public const ushort TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85; // TransformFeedbackPName,GetPName
        public const ushort TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;
        public const ushort TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;
        public const ushort PRIMITIVES_GENERATED = 0x8C87; // QueryTarget
        public const ushort PRIMITIVES_GENERATED_EXT = 0x8C87;
        public const ushort PRIMITIVES_GENERATED_NV = 0x8C87;
        public const ushort PRIMITIVES_GENERATED_OES = 0x8C87;
        public const ushort TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88; // QueryTarget
        public const ushort TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
        public const ushort TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;
        public const ushort RASTERIZER_DISCARD = 0x8C89; // EnableCap
        public const ushort RASTERIZER_DISCARD_EXT = 0x8C89;
        public const ushort RASTERIZER_DISCARD_NV = 0x8C89;
        public const ushort MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const ushort MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
        public const ushort MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
        public const ushort MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;
        public const ushort INTERLEAVED_ATTRIBS = 0x8C8C; // TransformFeedbackBufferMode
        public const ushort INTERLEAVED_ATTRIBS_EXT = 0x8C8C;
        public const ushort INTERLEAVED_ATTRIBS_NV = 0x8C8C;
        public const ushort SEPARATE_ATTRIBS = 0x8C8D; // TransformFeedbackBufferMode
        public const ushort SEPARATE_ATTRIBS_EXT = 0x8C8D;
        public const ushort SEPARATE_ATTRIBS_NV = 0x8C8D;
        public const ushort TRANSFORM_FEEDBACK_BUFFER = 0x8C8E; // ProgramInterface,BufferTargetARB,BufferStorageTarget,CopyBufferSubDataTarget
        public const ushort TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F; // TransformFeedbackPName,GetPName
        public const ushort TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;
        
        // . For Affie Munshi. Reassigned from AMD to QCOM (error #5874)
        public const ushort MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM = 0x8C90; // GetPName
        public const ushort MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM = 0x8C91; // GetPName
        public const ushort ATC_RGB_AMD = 0x8C92;
        public const ushort ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
        // Unused 0x8C94..0x8C9F. 
        
        // . 
        public const ushort POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
        public const ushort LOWER_LEFT = 0x8CA1; // ClipControlOrigin
        // Alias of GL_LOWER_LEFT
        public const ushort LOWER_LEFT_EXT = 0x8CA1;
        public const ushort UPPER_LEFT = 0x8CA2; // ClipControlOrigin
        // Alias of GL_UPPER_LEFT
        public const ushort UPPER_LEFT_EXT = 0x8CA2;
        public const ushort STENCIL_BACK_REF = 0x8CA3; // GetPName
        public const ushort STENCIL_BACK_VALUE_MASK = 0x8CA4; // GetPName
        public const ushort STENCIL_BACK_WRITEMASK = 0x8CA5; // GetPName
        public const ushort DRAW_FRAMEBUFFER_BINDING = 0x8CA6; // GetPName
        public const ushort DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
        public const ushort DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6;
        public const ushort DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        public const ushort DRAW_FRAMEBUFFER_BINDING_NV = 0x8CA6;
        public const ushort FRAMEBUFFER_BINDING = 0x8CA6;
        public const ushort FRAMEBUFFER_BINDING_ANGLE = 0x8CA6;
        public const ushort FRAMEBUFFER_BINDING_EXT = 0x8CA6;
        public const ushort FRAMEBUFFER_BINDING_OES = 0x8CA6;
        public const ushort RENDERBUFFER_BINDING = 0x8CA7; // GetPName
        public const ushort RENDERBUFFER_BINDING_ANGLE = 0x8CA7;
        public const ushort RENDERBUFFER_BINDING_EXT = 0x8CA7;
        public const ushort RENDERBUFFER_BINDING_OES = 0x8CA7;
        public const ushort READ_FRAMEBUFFER = 0x8CA8; // CheckFramebufferStatusTarget,FramebufferTarget
        public const ushort READ_FRAMEBUFFER_ANGLE = 0x8CA8;
        public const ushort READ_FRAMEBUFFER_APPLE = 0x8CA8;
        public const ushort READ_FRAMEBUFFER_EXT = 0x8CA8;
        public const ushort READ_FRAMEBUFFER_NV = 0x8CA8;
        public const ushort DRAW_FRAMEBUFFER = 0x8CA9; // CheckFramebufferStatusTarget,FramebufferTarget
        public const ushort DRAW_FRAMEBUFFER_ANGLE = 0x8CA9;
        public const ushort DRAW_FRAMEBUFFER_APPLE = 0x8CA9;
        public const ushort DRAW_FRAMEBUFFER_EXT = 0x8CA9;
        public const ushort DRAW_FRAMEBUFFER_NV = 0x8CA9;
        public const ushort READ_FRAMEBUFFER_BINDING = 0x8CAA; // GetPName
        public const ushort READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA;
        public const ushort READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA;
        public const ushort READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;
        public const ushort READ_FRAMEBUFFER_BINDING_NV = 0x8CAA;
        public const ushort RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB; // RenderbufferParameterName
        public const ushort RENDERBUFFER_SAMPLES = 0x8CAB; // RenderbufferParameterName
        public const ushort RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB; // RenderbufferParameterName
        public const ushort RENDERBUFFER_SAMPLES_APPLE = 0x8CAB; // RenderbufferParameterName
        public const ushort RENDERBUFFER_SAMPLES_EXT = 0x8CAB; // RenderbufferParameterName
        public const ushort RENDERBUFFER_SAMPLES_NV = 0x8CAB; // RenderbufferParameterName
        public const ushort DEPTH_COMPONENT32F = 0x8CAC; // InternalFormat
        public const ushort DEPTH32F_STENCIL8 = 0x8CAD; // InternalFormat
        // Unused 0x8CAE..0x8CAF. 
        
        // . For Barthold Lichtenbelt 2004/12/1
        // Unused 0x8CB0..0x8CCF. 
        
        // . Framebuffer object specification + headroom
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_COMPLETE = 0x8CD5; // FramebufferStatus
        public const ushort FRAMEBUFFER_COMPLETE_EXT = 0x8CD5;
        public const ushort FRAMEBUFFER_COMPLETE_OES = 0x8CD5;
        public const ushort FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
        public const ushort FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6;
        public const ushort FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
        public const ushort FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7;
        // Unused 0x8CD8. Removed 2005/09/26 in revision #117 of the FBO extension spec
        public const ushort FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
        public const ushort FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
        public const ushort FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9;
        public const ushort FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
        public const ushort FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA;
        public const ushort FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
        public const ushort FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_OES = 0x8CDB;
        public const ushort FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
        public const ushort FRAMEBUFFER_INCOMPLETE_READ_BUFFER_OES = 0x8CDC;
        public const ushort FRAMEBUFFER_UNSUPPORTED = 0x8CDD; // FramebufferStatus
        public const ushort FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD;
        public const ushort FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD;
        // Unused 0x8CDE. Removed 2005/05/31 in revision #113 of the FBO extension spec
        public const ushort MAX_COLOR_ATTACHMENTS = 0x8CDF;
        public const ushort MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF;
        public const ushort MAX_COLOR_ATTACHMENTS_NV = 0x8CDF;
        public const ushort COLOR_ATTACHMENT0 = 0x8CE0; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT0_EXT = 0x8CE0; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT0_NV = 0x8CE0; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT0_OES = 0x8CE0; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT1 = 0x8CE1; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT1_EXT = 0x8CE1; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT1_NV = 0x8CE1; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT2 = 0x8CE2; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT2_EXT = 0x8CE2; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT2_NV = 0x8CE2; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT3 = 0x8CE3; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT3_EXT = 0x8CE3; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT3_NV = 0x8CE3; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT4 = 0x8CE4; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT4_EXT = 0x8CE4; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT4_NV = 0x8CE4; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT5 = 0x8CE5; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT5_EXT = 0x8CE5; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT5_NV = 0x8CE5; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT6 = 0x8CE6; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT6_EXT = 0x8CE6; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT6_NV = 0x8CE6; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT7 = 0x8CE7; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT7_EXT = 0x8CE7; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT7_NV = 0x8CE7; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT8 = 0x8CE8; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT8_EXT = 0x8CE8; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT8_NV = 0x8CE8; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT9 = 0x8CE9; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT9_EXT = 0x8CE9; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT9_NV = 0x8CE9; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT10 = 0x8CEA; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT10_EXT = 0x8CEA; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT10_NV = 0x8CEA; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT11 = 0x8CEB; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT11_EXT = 0x8CEB; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT11_NV = 0x8CEB; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT12 = 0x8CEC; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT12_EXT = 0x8CEC; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT12_NV = 0x8CEC; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT13 = 0x8CED; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT13_EXT = 0x8CED; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT13_NV = 0x8CED; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT14 = 0x8CEE; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT14_EXT = 0x8CEE; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT14_NV = 0x8CEE; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT15 = 0x8CEF; // ColorBuffer,DrawBufferMode,ReadBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT15_EXT = 0x8CEF; // InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT15_NV = 0x8CEF; // InvalidateFramebufferAttachment,DrawBufferModeATI
        public const ushort COLOR_ATTACHMENT16 = 0x8CF0; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT17 = 0x8CF1; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT18 = 0x8CF2; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT19 = 0x8CF3; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT20 = 0x8CF4; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT21 = 0x8CF5; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT22 = 0x8CF6; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT23 = 0x8CF7; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT24 = 0x8CF8; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT25 = 0x8CF9; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT26 = 0x8CFA; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT27 = 0x8CFB; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT28 = 0x8CFC; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT29 = 0x8CFD; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT30 = 0x8CFE; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort COLOR_ATTACHMENT31 = 0x8CFF; // ColorBuffer,DrawBufferMode,FramebufferAttachment,InvalidateFramebufferAttachment
        public const ushort DEPTH_ATTACHMENT = 0x8D00; // InvalidateFramebufferAttachment,FramebufferAttachment
        public const ushort DEPTH_ATTACHMENT_EXT = 0x8D00; // InvalidateFramebufferAttachment
        public const ushort DEPTH_ATTACHMENT_OES = 0x8D00; // InvalidateFramebufferAttachment
        // Unused 0x8D01..0x8D1F. For depth attachments 16-31
        public const ushort STENCIL_ATTACHMENT = 0x8D20; // FramebufferAttachment
        public const ushort STENCIL_ATTACHMENT_EXT = 0x8D20; // InvalidateFramebufferAttachment
        public const ushort STENCIL_ATTACHMENT_OES = 0x8D20; // InvalidateFramebufferAttachment
        // Unused 0x8D21..0x8D3F. For stencil attachments 16-31
        public const ushort FRAMEBUFFER = 0x8D40; // ObjectIdentifier,FramebufferTarget,CheckFramebufferStatusTarget
        public const ushort FRAMEBUFFER_EXT = 0x8D40;
        public const ushort FRAMEBUFFER_OES = 0x8D40; // FramebufferTarget
        public const ushort RENDERBUFFER = 0x8D41; // ObjectIdentifier,RenderbufferTarget,CopyImageSubDataTarget
        public const ushort RENDERBUFFER_EXT = 0x8D41;
        public const ushort RENDERBUFFER_OES = 0x8D41; // RenderbufferTarget
        public const ushort RENDERBUFFER_WIDTH = 0x8D42; // RenderbufferParameterName
        public const ushort RENDERBUFFER_WIDTH_EXT = 0x8D42; // RenderbufferParameterName
        public const ushort RENDERBUFFER_WIDTH_OES = 0x8D42; // RenderbufferParameterName
        public const ushort RENDERBUFFER_HEIGHT = 0x8D43; // RenderbufferParameterName
        public const ushort RENDERBUFFER_HEIGHT_EXT = 0x8D43; // RenderbufferParameterName
        public const ushort RENDERBUFFER_HEIGHT_OES = 0x8D43; // RenderbufferParameterName
        public const ushort RENDERBUFFER_INTERNAL_FORMAT = 0x8D44; // RenderbufferParameterName
        public const ushort RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44; // RenderbufferParameterName
        public const ushort RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44; // RenderbufferParameterName
        // Unused 0x8D45. Was for GL_STENCIL_INDEX_EXT, but now use core STENCIL_INDEX instead
        public const ushort STENCIL_INDEX1 = 0x8D46; // InternalFormat
        public const ushort STENCIL_INDEX1_EXT = 0x8D46; // InternalFormat
        public const ushort STENCIL_INDEX1_OES = 0x8D46; // InternalFormat
        public const ushort STENCIL_INDEX4 = 0x8D47; // InternalFormat
        public const ushort STENCIL_INDEX4_EXT = 0x8D47; // InternalFormat
        public const ushort STENCIL_INDEX4_OES = 0x8D47; // InternalFormat
        public const ushort STENCIL_INDEX8 = 0x8D48; // InternalFormat
        public const ushort STENCIL_INDEX8_EXT = 0x8D48; // InternalFormat
        public const ushort STENCIL_INDEX8_OES = 0x8D48; // InternalFormat
        public const ushort STENCIL_INDEX16 = 0x8D49; // InternalFormat
        public const ushort STENCIL_INDEX16_EXT = 0x8D49; // InternalFormat
        // Unused 0x8D4A..0x8D4F. For additional stencil formats
        public const ushort RENDERBUFFER_RED_SIZE = 0x8D50; // RenderbufferParameterName
        public const ushort RENDERBUFFER_RED_SIZE_EXT = 0x8D50; // RenderbufferParameterName
        public const ushort RENDERBUFFER_RED_SIZE_OES = 0x8D50; // RenderbufferParameterName
        public const ushort RENDERBUFFER_GREEN_SIZE = 0x8D51; // RenderbufferParameterName
        public const ushort RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51; // RenderbufferParameterName
        public const ushort RENDERBUFFER_GREEN_SIZE_OES = 0x8D51; // RenderbufferParameterName
        public const ushort RENDERBUFFER_BLUE_SIZE = 0x8D52; // RenderbufferParameterName
        public const ushort RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52; // RenderbufferParameterName
        public const ushort RENDERBUFFER_BLUE_SIZE_OES = 0x8D52; // RenderbufferParameterName
        public const ushort RENDERBUFFER_ALPHA_SIZE = 0x8D53; // RenderbufferParameterName
        public const ushort RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53; // RenderbufferParameterName
        public const ushort RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53; // RenderbufferParameterName
        public const ushort RENDERBUFFER_DEPTH_SIZE = 0x8D54; // RenderbufferParameterName
        public const ushort RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54; // RenderbufferParameterName
        public const ushort RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54; // RenderbufferParameterName
        public const ushort RENDERBUFFER_STENCIL_SIZE = 0x8D55; // RenderbufferParameterName
        public const ushort RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55; // RenderbufferParameterName
        public const ushort RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55; // RenderbufferParameterName
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56;
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56;
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV = 0x8D56;
        public const ushort MAX_SAMPLES = 0x8D57;
        public const ushort MAX_SAMPLES_ANGLE = 0x8D57;
        public const ushort MAX_SAMPLES_APPLE = 0x8D57;
        public const ushort MAX_SAMPLES_EXT = 0x8D57;
        public const ushort MAX_SAMPLES_NV = 0x8D57;
        // Unused 0x8D58..0x8D5F. 
        
        // . 
        public const ushort TEXTURE_GEN_STR_OES = 0x8D60;
        public const ushort HALF_FLOAT_OES = 0x8D61;
        public const ushort RGB565_OES = 0x8D62;
        public const ushort RGB565 = 0x8D62;
        // Unused 0x8D63. Was GL_TEXTURE_IMMUTABLE_LEVELS in draft ES 3.0 spec
        public const ushort ETC1_RGB8_OES = 0x8D64;
        public const ushort TEXTURE_EXTERNAL_OES = 0x8D65;
        public const ushort SAMPLER_EXTERNAL_OES = 0x8D66;
        public const ushort TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;
        public const ushort REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;
        public const ushort PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69; // EnableCap
        public const ushort ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A; // QueryTarget
        public const ushort ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A;
        public const ushort MAX_ELEMENT_INDEX = 0x8D6B; // GetPName
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C; // FramebufferAttachmentParameterName
        // Unused 0x8D6D..0x8D6F. 
        
        // . For Pat Brown 2005/10/13
        public const ushort RGBA32UI = 0x8D70; // InternalFormat
        public const ushort RGBA32UI_EXT = 0x8D70;
        public const ushort RGB32UI = 0x8D71; // InternalFormat
        public const ushort RGB32UI_EXT = 0x8D71;
        public const ushort ALPHA32UI_EXT = 0x8D72;
        public const ushort INTENSITY32UI_EXT = 0x8D73;
        public const ushort LUMINANCE32UI_EXT = 0x8D74;
        public const ushort LUMINANCE_ALPHA32UI_EXT = 0x8D75;
        public const ushort RGBA16UI = 0x8D76; // InternalFormat
        public const ushort RGBA16UI_EXT = 0x8D76;
        public const ushort RGB16UI = 0x8D77; // InternalFormat
        public const ushort RGB16UI_EXT = 0x8D77;
        public const ushort ALPHA16UI_EXT = 0x8D78;
        public const ushort INTENSITY16UI_EXT = 0x8D79;
        public const ushort LUMINANCE16UI_EXT = 0x8D7A;
        public const ushort LUMINANCE_ALPHA16UI_EXT = 0x8D7B;
        public const ushort RGBA8UI = 0x8D7C; // InternalFormat
        public const ushort RGBA8UI_EXT = 0x8D7C;
        public const ushort RGB8UI = 0x8D7D; // InternalFormat
        public const ushort RGB8UI_EXT = 0x8D7D;
        public const ushort ALPHA8UI_EXT = 0x8D7E;
        public const ushort INTENSITY8UI_EXT = 0x8D7F;
        public const ushort LUMINANCE8UI_EXT = 0x8D80;
        public const ushort LUMINANCE_ALPHA8UI_EXT = 0x8D81;
        public const ushort RGBA32I = 0x8D82; // InternalFormat
        public const ushort RGBA32I_EXT = 0x8D82;
        public const ushort RGB32I = 0x8D83; // InternalFormat
        public const ushort RGB32I_EXT = 0x8D83;
        public const ushort ALPHA32I_EXT = 0x8D84;
        public const ushort INTENSITY32I_EXT = 0x8D85;
        public const ushort LUMINANCE32I_EXT = 0x8D86;
        public const ushort LUMINANCE_ALPHA32I_EXT = 0x8D87;
        public const ushort RGBA16I = 0x8D88; // InternalFormat
        public const ushort RGBA16I_EXT = 0x8D88;
        public const ushort RGB16I = 0x8D89; // InternalFormat
        public const ushort RGB16I_EXT = 0x8D89;
        public const ushort ALPHA16I_EXT = 0x8D8A;
        public const ushort INTENSITY16I_EXT = 0x8D8B;
        public const ushort LUMINANCE16I_EXT = 0x8D8C;
        public const ushort LUMINANCE_ALPHA16I_EXT = 0x8D8D;
        public const ushort RGBA8I = 0x8D8E; // InternalFormat
        public const ushort RGBA8I_EXT = 0x8D8E;
        public const ushort RGB8I = 0x8D8F; // InternalFormat
        public const ushort RGB8I_EXT = 0x8D8F;
        public const ushort ALPHA8I_EXT = 0x8D90;
        public const ushort INTENSITY8I_EXT = 0x8D91;
        public const ushort LUMINANCE8I_EXT = 0x8D92;
        public const ushort LUMINANCE_ALPHA8I_EXT = 0x8D93;
        public const ushort RED_INTEGER = 0x8D94; // PixelFormat
        public const ushort RED_INTEGER_EXT = 0x8D94;
        public const ushort GREEN_INTEGER = 0x8D95; // PixelFormat
        public const ushort GREEN_INTEGER_EXT = 0x8D95;
        public const ushort BLUE_INTEGER = 0x8D96; // PixelFormat
        public const ushort BLUE_INTEGER_EXT = 0x8D96;
        public const ushort ALPHA_INTEGER = 0x8D97;
        public const ushort ALPHA_INTEGER_EXT = 0x8D97;
        public const ushort RGB_INTEGER = 0x8D98; // PixelFormat
        public const ushort RGB_INTEGER_EXT = 0x8D98;
        public const ushort RGBA_INTEGER = 0x8D99; // PixelFormat
        public const ushort RGBA_INTEGER_EXT = 0x8D99;
        public const ushort BGR_INTEGER = 0x8D9A; // PixelFormat
        public const ushort BGR_INTEGER_EXT = 0x8D9A;
        public const ushort BGRA_INTEGER = 0x8D9B; // PixelFormat
        public const ushort BGRA_INTEGER_EXT = 0x8D9B;
        public const ushort LUMINANCE_INTEGER_EXT = 0x8D9C;
        public const ushort LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;
        public const ushort RGBA_INTEGER_MODE_EXT = 0x8D9E;
        public const ushort INT_2_10_10_10_REV = 0x8D9F; // VertexAttribPointerType,VertexAttribType
        public const ushort MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
        public const ushort MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
        public const ushort VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
        public const ushort GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
        public const ushort FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;
        public const ushort MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
        public const ushort MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;
        public const ushort FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_ATTACHMENT_LAYERED_OES = 0x8DA7; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8; // FramebufferStatus
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES = 0x8DA8;
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
        public const ushort FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
        public const ushort LAYER_NV = 0x8DAA;
        public const ushort DEPTH_COMPONENT32F_NV = 0x8DAB; // InternalFormat
        public const ushort DEPTH32F_STENCIL8_NV = 0x8DAC; // InternalFormat
        public const ushort FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const ushort FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
        public const ushort SHADER_INCLUDE_ARB = 0x8DAE;
        public const ushort DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;
        // Unused 0x8DB0..0x8DB8. 
        public const ushort FRAMEBUFFER_SRGB = 0x8DB9; // EnableCap
        public const ushort FRAMEBUFFER_SRGB_EXT = 0x8DB9;
        public const ushort FRAMEBUFFER_SRGB_CAPABLE_EXT = 0x8DBA;
        public const ushort COMPRESSED_RED_RGTC1 = 0x8DBB; // InternalFormat
        public const ushort COMPRESSED_RED_RGTC1_EXT = 0x8DBB; // InternalFormat
        public const ushort COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC; // InternalFormat
        public const ushort COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC; // InternalFormat
        public const ushort COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
        public const ushort COMPRESSED_RG_RGTC2 = 0x8DBD; // InternalFormat
        public const ushort COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;
        public const ushort COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE; // InternalFormat
        public const ushort SAMPLER_1D_ARRAY = 0x8DC0; // GlslTypeToken,UniformType
        public const ushort SAMPLER_1D_ARRAY_EXT = 0x8DC0;
        public const ushort SAMPLER_2D_ARRAY = 0x8DC1; // GlslTypeToken,UniformType
        public const ushort SAMPLER_2D_ARRAY_EXT = 0x8DC1;
        public const ushort SAMPLER_BUFFER = 0x8DC2; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_BUFFER_EXT = 0x8DC2;
        public const ushort SAMPLER_BUFFER_OES = 0x8DC2;
        public const ushort SAMPLER_1D_ARRAY_SHADOW = 0x8DC3; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;
        public const ushort SAMPLER_2D_ARRAY_SHADOW = 0x8DC4; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;
        public const ushort SAMPLER_2D_ARRAY_SHADOW_NV = 0x8DC4;
        public const ushort SAMPLER_CUBE_SHADOW = 0x8DC5; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;
        public const ushort SAMPLER_CUBE_SHADOW_NV = 0x8DC5;
        public const ushort UNSIGNED_INT_VEC2 = 0x8DC6; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_VEC2_EXT = 0x8DC6;
        public const ushort UNSIGNED_INT_VEC3 = 0x8DC7; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_VEC3_EXT = 0x8DC7;
        public const ushort UNSIGNED_INT_VEC4 = 0x8DC8; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_VEC4_EXT = 0x8DC8;
        public const ushort INT_SAMPLER_1D = 0x8DC9; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_1D_EXT = 0x8DC9;
        public const ushort INT_SAMPLER_2D = 0x8DCA; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_2D_EXT = 0x8DCA;
        public const ushort INT_SAMPLER_3D = 0x8DCB; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_3D_EXT = 0x8DCB;
        public const ushort INT_SAMPLER_CUBE = 0x8DCC; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_CUBE_EXT = 0x8DCC;
        public const ushort INT_SAMPLER_2D_RECT = 0x8DCD; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_2D_RECT_EXT = 0x8DCD;
        public const ushort INT_SAMPLER_1D_ARRAY = 0x8DCE; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;
        public const ushort INT_SAMPLER_2D_ARRAY = 0x8DCF; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;
        public const ushort INT_SAMPLER_BUFFER = 0x8DD0; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_BUFFER_EXT = 0x8DD0;
        public const ushort INT_SAMPLER_BUFFER_OES = 0x8DD0;
        public const ushort UNSIGNED_INT_SAMPLER_1D = 0x8DD1; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;
        public const ushort UNSIGNED_INT_SAMPLER_2D = 0x8DD2; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;
        public const ushort UNSIGNED_INT_SAMPLER_3D = 0x8DD3; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;
        public const ushort UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;
        public const ushort UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
        public const ushort UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
        public const ushort UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
        public const ushort UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;
        public const ushort UNSIGNED_INT_SAMPLER_BUFFER_OES = 0x8DD8;
        public const ushort GEOMETRY_SHADER = 0x8DD9; // PipelineParameterName,ShaderType
        public const ushort GEOMETRY_SHADER_ARB = 0x8DD9;
        public const ushort GEOMETRY_SHADER_EXT = 0x8DD9;
        public const ushort GEOMETRY_SHADER_OES = 0x8DD9;
        public const ushort GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
        public const ushort GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;
        public const ushort GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
        public const ushort GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;
        public const ushort GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
        public const ushort GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;
        public const ushort MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
        public const ushort MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
        public const ushort MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
        public const ushort MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;
        public const ushort MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF; // GetPName
        public const ushort MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
        public const ushort MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
        public const ushort MAX_GEOMETRY_UNIFORM_COMPONENTS_OES = 0x8DDF;
        public const ushort MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const ushort MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
        public const ushort MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
        public const ushort MAX_GEOMETRY_OUTPUT_VERTICES_OES = 0x8DE0;
        public const ushort MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const ushort MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
        public const ushort MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
        public const ushort MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES = 0x8DE1;
        public const ushort MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
        public const ushort MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
        public const ushort MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
        public const ushort ACTIVE_SUBROUTINES = 0x8DE5; // ProgramStagePName
        public const ushort ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6; // ProgramStagePName
        public const ushort MAX_SUBROUTINES = 0x8DE7;
        public const ushort MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        public const ushort NAMED_STRING_LENGTH_ARB = 0x8DE9;
        public const ushort NAMED_STRING_TYPE_ARB = 0x8DEA;
        // Unused 0x8DEB..0x8DEC. 
        public const ushort MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;
        public const ushort UNIFORM_BUFFER_EXT = 0x8DEE;
        public const ushort UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;
        
        // . 
        public const ushort LOW_FLOAT = 0x8DF0; // PrecisionType
        public const ushort MEDIUM_FLOAT = 0x8DF1; // PrecisionType
        public const ushort HIGH_FLOAT = 0x8DF2; // PrecisionType
        public const ushort LOW_INT = 0x8DF3; // PrecisionType
        public const ushort MEDIUM_INT = 0x8DF4; // PrecisionType
        public const ushort HIGH_INT = 0x8DF5; // PrecisionType
        public const ushort UNSIGNED_INT_10_10_10_2_OES = 0x8DF6;
        public const ushort INT_10_10_10_2_OES = 0x8DF7;
        public const ushort SHADER_BINARY_FORMATS = 0x8DF8;
        public const ushort NUM_SHADER_BINARY_FORMATS = 0x8DF9; // GetPName
        public const ushort SHADER_COMPILER = 0x8DFA; // GetPName
        public const ushort MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB; // GetPName
        public const ushort MAX_VARYING_VECTORS = 0x8DFC; // GetPName
        public const ushort MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD; // GetPName
        // Unused 0x8DFE..0x8E0F. 
        
        // . For Michael Gold 2006/08/07
        public const ushort RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10; // RenderbufferParameterName
        public const ushort MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
        public const ushort MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;
        public const ushort QUERY_WAIT = 0x8E13; // ConditionalRenderMode
        public const ushort QUERY_WAIT_NV = 0x8E13;
        public const ushort QUERY_NO_WAIT = 0x8E14; // ConditionalRenderMode
        public const ushort QUERY_NO_WAIT_NV = 0x8E14;
        public const ushort QUERY_BY_REGION_WAIT = 0x8E15; // ConditionalRenderMode
        public const ushort QUERY_BY_REGION_WAIT_NV = 0x8E15;
        public const ushort QUERY_BY_REGION_NO_WAIT = 0x8E16; // ConditionalRenderMode
        public const ushort QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;
        public const ushort QUERY_WAIT_INVERTED = 0x8E17; // ConditionalRenderMode
        public const ushort QUERY_NO_WAIT_INVERTED = 0x8E18; // ConditionalRenderMode
        public const ushort QUERY_BY_REGION_WAIT_INVERTED = 0x8E19; // ConditionalRenderMode
        public const ushort QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A; // ConditionalRenderMode
        public const ushort POLYGON_OFFSET_CLAMP = 0x8E1B;
        // Alias of GL_POLYGON_OFFSET_CLAMP
        public const ushort POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;
        // Unused 0x8E1C..0x8E1D. 
        public const ushort MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const ushort MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E1E;
        public const ushort MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E1E;
        public const ushort MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const ushort MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E1F;
        public const ushort MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E1F;
        public const ushort COLOR_SAMPLES_NV = 0x8E20;
        // Unused 0x8E21. 
        public const ushort TRANSFORM_FEEDBACK = 0x8E22; // ObjectIdentifier,BindTransformFeedbackTarget
        public const ushort TRANSFORM_FEEDBACK_NV = 0x8E22;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        // Alias of GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED
        public const ushort TRANSFORM_FEEDBACK_PAUSED = 0x8E23; // TransformFeedbackPName
        public const ushort TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
        public const ushort TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        // Alias of GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE
        public const ushort TRANSFORM_FEEDBACK_ACTIVE = 0x8E24; // TransformFeedbackPName
        public const ushort TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
        public const ushort TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const ushort TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
        public const ushort FRAME_NV = 0x8E26;
        public const ushort FIELDS_NV = 0x8E27;
        public const ushort CURRENT_TIME_NV = 0x8E28;
        public const ushort TIMESTAMP = 0x8E28; // QueryCounterTarget,GetPName
        public const ushort TIMESTAMP_EXT = 0x8E28;
        public const ushort NUM_FILL_STREAMS_NV = 0x8E29;
        public const ushort PRESENT_TIME_NV = 0x8E2A;
        public const ushort PRESENT_DURATION_NV = 0x8E2B;
        public const ushort DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C;
        public const ushort PROGRAM_MATRIX_EXT = 0x8E2D;
        public const ushort TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
        public const ushort PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
        // Unused 0x8E30..0x8E41. 
        public const ushort TEXTURE_SWIZZLE_R = 0x8E42; // TextureParameterName
        public const ushort TEXTURE_SWIZZLE_R_EXT = 0x8E42;
        public const ushort TEXTURE_SWIZZLE_G = 0x8E43; // TextureParameterName
        public const ushort TEXTURE_SWIZZLE_G_EXT = 0x8E43;
        public const ushort TEXTURE_SWIZZLE_B = 0x8E44; // TextureParameterName
        public const ushort TEXTURE_SWIZZLE_B_EXT = 0x8E44;
        public const ushort TEXTURE_SWIZZLE_A = 0x8E45; // TextureParameterName
        public const ushort TEXTURE_SWIZZLE_A_EXT = 0x8E45;
        public const ushort TEXTURE_SWIZZLE_RGBA = 0x8E46; // TextureParameterName
        public const ushort TEXTURE_SWIZZLE_RGBA_EXT = 0x8E46;
        public const ushort ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47; // ProgramStagePName
        public const ushort ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48; // ProgramStagePName
        public const ushort ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49; // ProgramStagePName
        public const ushort NUM_COMPATIBLE_SUBROUTINES = 0x8E4A; // ProgramResourceProperty,SubroutineParameterName
        public const ushort COMPATIBLE_SUBROUTINES = 0x8E4B; // ProgramResourceProperty,SubroutineParameterName
        public const ushort QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const ushort QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
        public const ushort FIRST_VERTEX_CONVENTION = 0x8E4D; // VertexProvokingMode
        public const ushort FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;
        public const ushort FIRST_VERTEX_CONVENTION_OES = 0x8E4D;
        public const ushort LAST_VERTEX_CONVENTION = 0x8E4E; // VertexProvokingMode
        public const ushort LAST_VERTEX_CONVENTION_EXT = 0x8E4E;
        public const ushort LAST_VERTEX_CONVENTION_OES = 0x8E4E;
        public const ushort PROVOKING_VERTEX = 0x8E4F; // GetPName
        public const ushort PROVOKING_VERTEX_EXT = 0x8E4F;
        public const ushort SAMPLE_POSITION = 0x8E50; // GetMultisamplePNameNV
        public const ushort SAMPLE_POSITION_NV = 0x8E50;
        // Alias of GL_SAMPLE_POSITION
        public const ushort SAMPLE_LOCATION_ARB = 0x8E50; // GetMultisamplePNameNV
        // Alias of GL_SAMPLE_POSITION_NV
        public const ushort SAMPLE_LOCATION_NV = 0x8E50;
        public const ushort SAMPLE_MASK = 0x8E51; // EnableCap
        public const ushort SAMPLE_MASK_NV = 0x8E51;
        public const ushort SAMPLE_MASK_VALUE = 0x8E52;
        public const ushort SAMPLE_MASK_VALUE_NV = 0x8E52;
        public const ushort TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
        public const ushort TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
        public const ushort TEXTURE_RENDERBUFFER_NV = 0x8E55;
        public const ushort SAMPLER_RENDERBUFFER_NV = 0x8E56;
        public const ushort INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;
        public const ushort UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
        public const ushort MAX_SAMPLE_MASK_WORDS = 0x8E59; // GetPName
        public const ushort MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;
        public const ushort MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
        public const ushort MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const ushort MAX_GEOMETRY_SHADER_INVOCATIONS_EXT = 0x8E5A;
        public const ushort MAX_GEOMETRY_SHADER_INVOCATIONS_OES = 0x8E5A;
        public const ushort MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const ushort MIN_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5B;
        public const ushort MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
        public const ushort MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const ushort MAX_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5C;
        public const ushort MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
        public const ushort FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const ushort FRAGMENT_INTERPOLATION_OFFSET_BITS_OES = 0x8E5D;
        public const ushort FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
        public const ushort MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        public const ushort MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5E;
        public const ushort MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
        public const ushort MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        public const ushort MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB = 0x8E5F;
        public const ushort MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
        public const ushort MAX_MESH_UNIFORM_BLOCKS_NV = 0x8E60;
        public const ushort MAX_MESH_TEXTURE_IMAGE_UNITS_NV = 0x8E61;
        public const ushort MAX_MESH_IMAGE_UNIFORMS_NV = 0x8E62;
        public const ushort MAX_MESH_UNIFORM_COMPONENTS_NV = 0x8E63;
        public const ushort MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV = 0x8E64;
        public const ushort MAX_MESH_ATOMIC_COUNTERS_NV = 0x8E65;
        public const ushort MAX_MESH_SHADER_STORAGE_BLOCKS_NV = 0x8E66;
        public const ushort MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV = 0x8E67;
        public const ushort MAX_TASK_UNIFORM_BLOCKS_NV = 0x8E68;
        public const ushort MAX_TASK_TEXTURE_IMAGE_UNITS_NV = 0x8E69;
        public const ushort MAX_TASK_IMAGE_UNIFORMS_NV = 0x8E6A;
        public const ushort MAX_TASK_UNIFORM_COMPONENTS_NV = 0x8E6B;
        public const ushort MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV = 0x8E6C;
        public const ushort MAX_TASK_ATOMIC_COUNTERS_NV = 0x8E6D;
        public const ushort MAX_TASK_SHADER_STORAGE_BLOCKS_NV = 0x8E6E;
        public const ushort MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV = 0x8E6F;
        public const ushort MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const ushort MAX_VERTEX_STREAMS = 0x8E71;
        public const ushort PATCH_VERTICES = 0x8E72; // PatchParameterName
        public const ushort PATCH_VERTICES_EXT = 0x8E72;
        public const ushort PATCH_VERTICES_OES = 0x8E72;
        public const ushort PATCH_DEFAULT_INNER_LEVEL = 0x8E73; // PatchParameterName
        public const ushort PATCH_DEFAULT_INNER_LEVEL_EXT = 0x8E73;
        public const ushort PATCH_DEFAULT_OUTER_LEVEL = 0x8E74; // PatchParameterName
        public const ushort PATCH_DEFAULT_OUTER_LEVEL_EXT = 0x8E74;
        public const ushort TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const ushort TESS_CONTROL_OUTPUT_VERTICES_EXT = 0x8E75;
        public const ushort TESS_CONTROL_OUTPUT_VERTICES_OES = 0x8E75;
        public const ushort TESS_GEN_MODE = 0x8E76;
        public const ushort TESS_GEN_MODE_EXT = 0x8E76;
        public const ushort TESS_GEN_MODE_OES = 0x8E76;
        public const ushort TESS_GEN_SPACING = 0x8E77;
        public const ushort TESS_GEN_SPACING_EXT = 0x8E77;
        public const ushort TESS_GEN_SPACING_OES = 0x8E77;
        public const ushort TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const ushort TESS_GEN_VERTEX_ORDER_EXT = 0x8E78;
        public const ushort TESS_GEN_VERTEX_ORDER_OES = 0x8E78;
        public const ushort TESS_GEN_POINT_MODE = 0x8E79;
        public const ushort TESS_GEN_POINT_MODE_EXT = 0x8E79;
        public const ushort TESS_GEN_POINT_MODE_OES = 0x8E79;
        public const ushort ISOLINES = 0x8E7A;
        public const ushort ISOLINES_EXT = 0x8E7A;
        public const ushort ISOLINES_OES = 0x8E7A;
        public const ushort FRACTIONAL_ODD = 0x8E7B;
        public const ushort FRACTIONAL_ODD_EXT = 0x8E7B;
        public const ushort FRACTIONAL_ODD_OES = 0x8E7B;
        public const ushort FRACTIONAL_EVEN = 0x8E7C;
        public const ushort FRACTIONAL_EVEN_EXT = 0x8E7C;
        public const ushort FRACTIONAL_EVEN_OES = 0x8E7C;
        public const ushort MAX_PATCH_VERTICES = 0x8E7D;
        public const ushort MAX_PATCH_VERTICES_EXT = 0x8E7D;
        public const ushort MAX_PATCH_VERTICES_OES = 0x8E7D;
        public const ushort MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const ushort MAX_TESS_GEN_LEVEL_EXT = 0x8E7E;
        public const ushort MAX_TESS_GEN_LEVEL_OES = 0x8E7E;
        public const ushort MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const ushort MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT = 0x8E7F;
        public const ushort MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES = 0x8E7F;
        public const ushort MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const ushort MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT = 0x8E80;
        public const ushort MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES = 0x8E80;
        public const ushort MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const ushort MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT = 0x8E81;
        public const ushort MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES = 0x8E81;
        public const ushort MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const ushort MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT = 0x8E82;
        public const ushort MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES = 0x8E82;
        public const ushort MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const ushort MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT = 0x8E83;
        public const ushort MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES = 0x8E83;
        public const ushort MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const ushort MAX_TESS_PATCH_COMPONENTS_EXT = 0x8E84;
        public const ushort MAX_TESS_PATCH_COMPONENTS_OES = 0x8E84;
        public const ushort MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const ushort MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8E85;
        public const ushort MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES = 0x8E85;
        public const ushort MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const ushort MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT = 0x8E86;
        public const ushort MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES = 0x8E86;
        public const ushort TESS_EVALUATION_SHADER = 0x8E87; // PipelineParameterName,ShaderType
        public const ushort TESS_EVALUATION_SHADER_EXT = 0x8E87;
        public const ushort TESS_EVALUATION_SHADER_OES = 0x8E87;
        public const ushort TESS_CONTROL_SHADER = 0x8E88; // PipelineParameterName,ShaderType
        public const ushort TESS_CONTROL_SHADER_EXT = 0x8E88;
        public const ushort TESS_CONTROL_SHADER_OES = 0x8E88;
        public const ushort MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89; // GetPName
        public const ushort MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT = 0x8E89;
        public const ushort MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES = 0x8E89;
        public const ushort MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A; // GetPName
        public const ushort MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT = 0x8E8A;
        public const ushort MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES = 0x8E8A;
        // Unused 0x8E8B. 
        public const ushort COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C; // InternalFormat
        public const ushort COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;
        public const ushort COMPRESSED_RGBA_BPTC_UNORM_EXT = 0x8E8C;
        public const ushort COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D; // InternalFormat
        public const ushort COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;
        public const ushort COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT = 0x8E8D;
        public const ushort COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E; // InternalFormat
        public const ushort COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;
        public const ushort COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT = 0x8E8E;
        public const ushort COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F; // InternalFormat
        public const ushort COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;
        public const ushort COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT = 0x8E8F;
        
        // . For QNX_texture_tiling, QNX_complex_polygon, QNX_stippled_lines (Khronos error #696)
        // Unused 0x8E90..0x8E9F. 
        
        // . 
        // Unused 0x8EA0..0x8EAF. 
        
        // . For Affie Munshi 2007/07/20
        // Unused 0x8EB0..0x8EBF. 
        
        // . 
        // Unused 0x8EC0..0x8ECF. 
        
        // . For Pat Brown, Khronos error #3191
        public const ushort COVERAGE_COMPONENT_NV = 0x8ED0;
        public const ushort COVERAGE_COMPONENT4_NV = 0x8ED1;
        public const ushort COVERAGE_ATTACHMENT_NV = 0x8ED2;
        public const ushort COVERAGE_BUFFERS_NV = 0x8ED3;
        public const ushort COVERAGE_SAMPLES_NV = 0x8ED4;
        public const ushort COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;
        public const ushort COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;
        public const ushort COVERAGE_AUTOMATIC_NV = 0x8ED7;
        // Unused 0x8ED8..0x8F0F. 
        public const ushort INCLUSIVE_EXT = 0x8F10;
        public const ushort EXCLUSIVE_EXT = 0x8F11;
        public const ushort WINDOW_RECTANGLE_EXT = 0x8F12;
        public const ushort WINDOW_RECTANGLE_MODE_EXT = 0x8F13;
        public const ushort MAX_WINDOW_RECTANGLES_EXT = 0x8F14;
        public const ushort NUM_WINDOW_RECTANGLES_EXT = 0x8F15;
        // Unused 0x8F16..0x8F1C. 
        public const ushort BUFFER_GPU_ADDRESS_NV = 0x8F1D;
        public const ushort VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;
        public const ushort ELEMENT_ARRAY_UNIFIED_NV = 0x8F1F;
        public const ushort VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;
        public const ushort VERTEX_ARRAY_ADDRESS_NV = 0x8F21;
        public const ushort NORMAL_ARRAY_ADDRESS_NV = 0x8F22;
        public const ushort COLOR_ARRAY_ADDRESS_NV = 0x8F23;
        public const ushort INDEX_ARRAY_ADDRESS_NV = 0x8F24;
        public const ushort TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;
        public const ushort EDGE_FLAG_ARRAY_ADDRESS_NV = 0x8F26;
        public const ushort SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;
        public const ushort FOG_COORD_ARRAY_ADDRESS_NV = 0x8F28;
        public const ushort ELEMENT_ARRAY_ADDRESS_NV = 0x8F29;
        public const ushort VERTEX_ATTRIB_ARRAY_LENGTH_NV = 0x8F2A;
        public const ushort VERTEX_ARRAY_LENGTH_NV = 0x8F2B;
        public const ushort NORMAL_ARRAY_LENGTH_NV = 0x8F2C;
        public const ushort COLOR_ARRAY_LENGTH_NV = 0x8F2D;
        public const ushort INDEX_ARRAY_LENGTH_NV = 0x8F2E;
        public const ushort TEXTURE_COORD_ARRAY_LENGTH_NV = 0x8F2F;
        public const ushort EDGE_FLAG_ARRAY_LENGTH_NV = 0x8F30;
        public const ushort SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;
        public const ushort FOG_COORD_ARRAY_LENGTH_NV = 0x8F32;
        public const ushort ELEMENT_ARRAY_LENGTH_NV = 0x8F33;
        public const ushort GPU_ADDRESS_NV = 0x8F34;
        public const ushort MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;
        public const ushort COPY_READ_BUFFER = 0x8F36; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort COPY_READ_BUFFER_NV = 0x8F36;
        // Alias of GL_COPY_READ_BUFFER
        public const ushort COPY_READ_BUFFER_BINDING = 0x8F36;
        public const ushort COPY_WRITE_BUFFER = 0x8F37; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort COPY_WRITE_BUFFER_NV = 0x8F37;
        // Alias of GL_COPY_WRITE_BUFFER
        public const ushort COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const ushort MAX_IMAGE_UNITS = 0x8F38;
        public const ushort MAX_IMAGE_UNITS_EXT = 0x8F38;
        public const ushort MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const ushort MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
        // Alias of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS
        public const ushort MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const ushort IMAGE_BINDING_NAME = 0x8F3A;
        public const ushort IMAGE_BINDING_NAME_EXT = 0x8F3A;
        public const ushort IMAGE_BINDING_LEVEL = 0x8F3B;
        public const ushort IMAGE_BINDING_LEVEL_EXT = 0x8F3B;
        public const ushort IMAGE_BINDING_LAYERED = 0x8F3C;
        public const ushort IMAGE_BINDING_LAYERED_EXT = 0x8F3C;
        public const ushort IMAGE_BINDING_LAYER = 0x8F3D;
        public const ushort IMAGE_BINDING_LAYER_EXT = 0x8F3D;
        public const ushort IMAGE_BINDING_ACCESS = 0x8F3E;
        public const ushort IMAGE_BINDING_ACCESS_EXT = 0x8F3E;
        public const ushort DRAW_INDIRECT_BUFFER = 0x8F3F; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort DRAW_INDIRECT_UNIFIED_NV = 0x8F40;
        public const ushort DRAW_INDIRECT_ADDRESS_NV = 0x8F41;
        public const ushort DRAW_INDIRECT_LENGTH_NV = 0x8F42;
        public const ushort DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        public const ushort MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
        public const ushort MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;
        public const ushort DOUBLE_MAT2 = 0x8F46; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_MAT2_EXT = 0x8F46;
        public const ushort DOUBLE_MAT3 = 0x8F47; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_MAT3_EXT = 0x8F47;
        public const ushort DOUBLE_MAT4 = 0x8F48; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_MAT4_EXT = 0x8F48;
        public const ushort DOUBLE_MAT2x3 = 0x8F49; // UniformType,AttributeType
        public const ushort DOUBLE_MAT2x3_EXT = 0x8F49;
        public const ushort DOUBLE_MAT2x4 = 0x8F4A; // UniformType,AttributeType
        public const ushort DOUBLE_MAT2x4_EXT = 0x8F4A;
        public const ushort DOUBLE_MAT3x2 = 0x8F4B; // UniformType,AttributeType
        public const ushort DOUBLE_MAT3x2_EXT = 0x8F4B;
        public const ushort DOUBLE_MAT3x4 = 0x8F4C; // UniformType,AttributeType
        public const ushort DOUBLE_MAT3x4_EXT = 0x8F4C;
        public const ushort DOUBLE_MAT4x2 = 0x8F4D; // UniformType,AttributeType
        public const ushort DOUBLE_MAT4x2_EXT = 0x8F4D;
        public const ushort DOUBLE_MAT4x3 = 0x8F4E; // UniformType,AttributeType
        public const ushort DOUBLE_MAT4x3_EXT = 0x8F4E;
        public const ushort VERTEX_BINDING_BUFFER = 0x8F4F;
        
        // . For Jon Kennedy, Khronos public error #75
        // Unused 0x8F50..0x8F5F. 
        
        // . For Remi Pedersen, Khronos error #3745
        public const ushort MALI_SHADER_BINARY_ARM = 0x8F60;
        public const ushort MALI_PROGRAM_BINARY_ARM = 0x8F61;
        // Unused 0x8F62. 
        public const ushort MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;
        public const ushort SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;
        public const ushort FETCH_PER_SAMPLE_ARM = 0x8F65;
        public const ushort FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66;
        public const ushort MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;
        // Unused 0x8F68. 
        public const ushort TEXTURE_ASTC_DECODE_PRECISION_EXT = 0x8F69;
        public const ushort TEXTURE_UNNORMALIZED_COORDINATES_ARM = 0x8F6A; // SamplerParameterF,SamplerParameterI,GetTextureParameter,TextureParameterName
        // Unused 0x8F6B..0x8F6F. 
        
        // . For Mark Callow, Khronos error #4055. Shared with EGL.
        // Unused 0x8F70..0x8F7F. 
        
        // . For Mike Weiblen, public error #910
        // Unused 0x8F80..0x8F8F. 
        
        // . 
        public const ushort RED_SNORM = 0x8F90;
        public const ushort RG_SNORM = 0x8F91;
        public const ushort RGB_SNORM = 0x8F92;
        public const ushort RGBA_SNORM = 0x8F93;
        public const ushort R8_SNORM = 0x8F94; // InternalFormat
        public const ushort RG8_SNORM = 0x8F95; // InternalFormat
        public const ushort RGB8_SNORM = 0x8F96; // InternalFormat
        public const ushort RGBA8_SNORM = 0x8F97; // InternalFormat
        public const ushort R16_SNORM = 0x8F98; // InternalFormat
        public const ushort R16_SNORM_EXT = 0x8F98; // InternalFormat
        public const ushort RG16_SNORM = 0x8F99; // InternalFormat
        public const ushort RG16_SNORM_EXT = 0x8F99; // InternalFormat
        public const ushort RGB16_SNORM = 0x8F9A; // InternalFormat
        public const ushort RGB16_SNORM_EXT = 0x8F9A; // InternalFormat
        public const ushort RGBA16_SNORM = 0x8F9B;
        public const ushort RGBA16_SNORM_EXT = 0x8F9B;
        public const ushort SIGNED_NORMALIZED = 0x8F9C;
        public const ushort PRIMITIVE_RESTART = 0x8F9D; // EnableCap
        public const ushort PRIMITIVE_RESTART_INDEX = 0x8F9E; // GetPName
        public const ushort MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB = 0x8F9F;
        
        // . For Maurice Ribble, error #4512
        public const ushort PERFMON_GLOBAL_MODE_QCOM = 0x8FA0;
        public const ushort MAX_SHADER_SUBSAMPLED_IMAGE_UNITS_QCOM = 0x8FA1;
        // Unused 0x8FA2..0x8FAF. 
        public const ushort BINNING_CONTROL_HINT_QCOM = 0x8FB0; // HintTarget
        public const ushort CPU_OPTIMIZED_QCOM = 0x8FB1;
        public const ushort GPU_OPTIMIZED_QCOM = 0x8FB2;
        public const ushort RENDER_DIRECT_TO_FRAMEBUFFER_QCOM = 0x8FB3;
        // Unused 0x8FB4..0x8FBA. 
        public const ushort GPU_DISJOINT_EXT = 0x8FBB;
        // Unused 0x8FBC. 
        public const ushort SR8_EXT = 0x8FBD;
        public const ushort SRG8_EXT = 0x8FBE;
        public const ushort TEXTURE_FORMAT_SRGB_OVERRIDE_EXT = 0x8FBF;
        
        // . For Frido Garritsen, error #4526
        public const ushort SHADER_BINARY_VIV = 0x8FC4;
        
        // . For Pat Brown, error #4935
        public const ushort INT8_NV = 0x8FE0;
        public const ushort INT8_VEC2_NV = 0x8FE1;
        public const ushort INT8_VEC3_NV = 0x8FE2;
        public const ushort INT8_VEC4_NV = 0x8FE3;
        public const ushort INT16_NV = 0x8FE4;
        public const ushort INT16_VEC2_NV = 0x8FE5;
        public const ushort INT16_VEC3_NV = 0x8FE6;
        public const ushort INT16_VEC4_NV = 0x8FE7;
        public const ushort INT64_VEC2_ARB = 0x8FE9; // AttributeType
        public const ushort INT64_VEC2_NV = 0x8FE9;
        public const ushort INT64_VEC3_ARB = 0x8FEA; // AttributeType
        public const ushort INT64_VEC3_NV = 0x8FEA;
        public const ushort INT64_VEC4_ARB = 0x8FEB; // AttributeType
        public const ushort INT64_VEC4_NV = 0x8FEB;
        public const ushort UNSIGNED_INT8_NV = 0x8FEC;
        public const ushort UNSIGNED_INT8_VEC2_NV = 0x8FED;
        public const ushort UNSIGNED_INT8_VEC3_NV = 0x8FEE;
        public const ushort UNSIGNED_INT8_VEC4_NV = 0x8FEF;
        public const ushort UNSIGNED_INT16_NV = 0x8FF0;
        public const ushort UNSIGNED_INT16_VEC2_NV = 0x8FF1;
        public const ushort UNSIGNED_INT16_VEC3_NV = 0x8FF2;
        public const ushort UNSIGNED_INT16_VEC4_NV = 0x8FF3;
        public const ushort UNSIGNED_INT64_VEC2_ARB = 0x8FF5; // AttributeType
        public const ushort UNSIGNED_INT64_VEC2_NV = 0x8FF5;
        public const ushort UNSIGNED_INT64_VEC3_ARB = 0x8FF6; // AttributeType
        public const ushort UNSIGNED_INT64_VEC3_NV = 0x8FF6;
        public const ushort UNSIGNED_INT64_VEC4_ARB = 0x8FF7; // AttributeType
        public const ushort UNSIGNED_INT64_VEC4_NV = 0x8FF7;
        public const ushort FLOAT16_NV = 0x8FF8;
        public const ushort FLOAT16_VEC2_NV = 0x8FF9;
        public const ushort FLOAT16_VEC3_NV = 0x8FFA;
        public const ushort FLOAT16_VEC4_NV = 0x8FFB;
        public const ushort DOUBLE_VEC2 = 0x8FFC; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_VEC2_EXT = 0x8FFC;
        public const ushort DOUBLE_VEC3 = 0x8FFD; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_VEC3_EXT = 0x8FFD;
        public const ushort DOUBLE_VEC4 = 0x8FFE; // GlslTypeToken,AttributeType,UniformType
        public const ushort DOUBLE_VEC4_EXT = 0x8FFE;
        // Unused 0x8FFF. 
        
        // . For Bill Licea-Kane
        public const ushort SAMPLER_BUFFER_AMD = 0x9001;
        public const ushort INT_SAMPLER_BUFFER_AMD = 0x9002;
        public const ushort UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;
        public const ushort TESSELLATION_MODE_AMD = 0x9004;
        public const ushort TESSELLATION_FACTOR_AMD = 0x9005;
        public const ushort DISCRETE_AMD = 0x9006;
        public const ushort CONTINUOUS_AMD = 0x9007;
        // Unused 0x9008. 
        public const ushort TEXTURE_CUBE_MAP_ARRAY = 0x9009; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009; // TextureTarget
        public const ushort TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009; // TextureTarget
        public const ushort TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const ushort TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB = 0x900A;
        public const ushort TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT = 0x900A;
        public const ushort TEXTURE_BINDING_CUBE_MAP_ARRAY_OES = 0x900A;
        public const ushort PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B; // TextureTarget
        public const ushort PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B; // TextureTarget
        public const ushort SAMPLER_CUBE_MAP_ARRAY = 0x900C; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900C;
        public const ushort SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900C;
        public const ushort SAMPLER_CUBE_MAP_ARRAY_OES = 0x900C;
        public const ushort SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB = 0x900D;
        public const ushort SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT = 0x900D;
        public const ushort SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES = 0x900D;
        public const ushort INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900E;
        public const ushort INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900E;
        public const ushort INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900E;
        public const ushort UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB = 0x900F;
        public const ushort UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT = 0x900F;
        public const ushort UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES = 0x900F;
        public const ushort ALPHA_SNORM = 0x9010;
        public const ushort LUMINANCE_SNORM = 0x9011;
        public const ushort LUMINANCE_ALPHA_SNORM = 0x9012;
        public const ushort INTENSITY_SNORM = 0x9013;
        public const ushort ALPHA8_SNORM = 0x9014;
        public const ushort LUMINANCE8_SNORM = 0x9015;
        public const ushort LUMINANCE8_ALPHA8_SNORM = 0x9016;
        public const ushort INTENSITY8_SNORM = 0x9017;
        public const ushort ALPHA16_SNORM = 0x9018;
        public const ushort LUMINANCE16_SNORM = 0x9019;
        public const ushort LUMINANCE16_ALPHA16_SNORM = 0x901A;
        public const ushort INTENSITY16_SNORM = 0x901B;
        public const ushort FACTOR_MIN_AMD = 0x901C;
        public const ushort FACTOR_MAX_AMD = 0x901D;
        public const ushort DEPTH_CLAMP_NEAR_AMD = 0x901E;
        public const ushort DEPTH_CLAMP_FAR_AMD = 0x901F;
        
        // . For Pat Brown, error #4935
        public const ushort VIDEO_BUFFER_NV = 0x9020;
        public const ushort VIDEO_BUFFER_BINDING_NV = 0x9021;
        public const ushort FIELD_UPPER_NV = 0x9022;
        public const ushort FIELD_LOWER_NV = 0x9023;
        public const ushort NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;
        public const ushort NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
        public const ushort VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
        public const ushort LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;
        public const ushort VIDEO_BUFFER_PITCH_NV = 0x9028;
        public const ushort VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
        public const ushort VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;
        public const ushort VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;
        public const ushort VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
        public const ushort VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
        public const ushort PARTIAL_SUCCESS_NV = 0x902E;
        public const ushort SUCCESS_NV = 0x902F;
        public const ushort FAILURE_NV = 0x9030;
        public const ushort YCBYCR8_422_NV = 0x9031;
        public const ushort YCBAYCR8A_4224_NV = 0x9032;
        public const ushort Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;
        public const ushort Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
        public const ushort Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;
        public const ushort Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
        public const ushort Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;
        public const ushort VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;
        public const ushort VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;
        public const ushort VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
        public const ushort VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
        public const ushort VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;
        // Unused 0x903D..0x9044. 
        public const ushort TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
        public const ushort TEXTURE_COLOR_SAMPLES_NV = 0x9046;
        public const ushort GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047;
        public const ushort GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048;
        public const ushort GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049;
        public const ushort GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A;
        public const ushort GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B;
        public const ushort IMAGE_1D = 0x904C; // GlslTypeToken,AttributeType
        public const ushort IMAGE_1D_EXT = 0x904C;
        public const ushort IMAGE_2D = 0x904D; // GlslTypeToken,AttributeType
        public const ushort IMAGE_2D_EXT = 0x904D;
        public const ushort IMAGE_3D = 0x904E; // GlslTypeToken,AttributeType
        public const ushort IMAGE_3D_EXT = 0x904E;
        public const ushort IMAGE_2D_RECT = 0x904F; // GlslTypeToken,AttributeType
        public const ushort IMAGE_2D_RECT_EXT = 0x904F;
        public const ushort IMAGE_CUBE = 0x9050; // GlslTypeToken,AttributeType
        public const ushort IMAGE_CUBE_EXT = 0x9050;
        public const ushort IMAGE_BUFFER = 0x9051; // GlslTypeToken,AttributeType
        public const ushort IMAGE_BUFFER_EXT = 0x9051;
        public const ushort IMAGE_BUFFER_OES = 0x9051;
        public const ushort IMAGE_1D_ARRAY = 0x9052; // GlslTypeToken,AttributeType
        public const ushort IMAGE_1D_ARRAY_EXT = 0x9052;
        public const ushort IMAGE_2D_ARRAY = 0x9053; // GlslTypeToken,AttributeType
        public const ushort IMAGE_2D_ARRAY_EXT = 0x9053;
        public const ushort IMAGE_CUBE_MAP_ARRAY = 0x9054; // GlslTypeToken,AttributeType
        public const ushort IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;
        public const ushort IMAGE_CUBE_MAP_ARRAY_OES = 0x9054;
        public const ushort IMAGE_2D_MULTISAMPLE = 0x9055; // GlslTypeToken,AttributeType
        public const ushort IMAGE_2D_MULTISAMPLE_EXT = 0x9055;
        public const ushort IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056; // GlslTypeToken,AttributeType
        public const ushort IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
        public const ushort INT_IMAGE_1D = 0x9057; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_1D_EXT = 0x9057;
        public const ushort INT_IMAGE_2D = 0x9058; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_2D_EXT = 0x9058;
        public const ushort INT_IMAGE_3D = 0x9059; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_3D_EXT = 0x9059;
        public const ushort INT_IMAGE_2D_RECT = 0x905A; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_2D_RECT_EXT = 0x905A;
        public const ushort INT_IMAGE_CUBE = 0x905B; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_CUBE_EXT = 0x905B;
        public const ushort INT_IMAGE_BUFFER = 0x905C; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_BUFFER_EXT = 0x905C;
        public const ushort INT_IMAGE_BUFFER_OES = 0x905C;
        public const ushort INT_IMAGE_1D_ARRAY = 0x905D; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_1D_ARRAY_EXT = 0x905D;
        public const ushort INT_IMAGE_2D_ARRAY = 0x905E; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_2D_ARRAY_EXT = 0x905E;
        public const ushort INT_IMAGE_CUBE_MAP_ARRAY = 0x905F; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;
        public const ushort INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x905F;
        public const ushort INT_IMAGE_2D_MULTISAMPLE = 0x9060; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;
        public const ushort INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061; // GlslTypeToken,AttributeType
        public const ushort INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
        public const ushort UNSIGNED_INT_IMAGE_1D = 0x9062; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;
        public const ushort UNSIGNED_INT_IMAGE_2D = 0x9063; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;
        public const ushort UNSIGNED_INT_IMAGE_3D = 0x9064; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;
        public const ushort UNSIGNED_INT_IMAGE_2D_RECT = 0x9065; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
        public const ushort UNSIGNED_INT_IMAGE_CUBE = 0x9066; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;
        public const ushort UNSIGNED_INT_IMAGE_BUFFER = 0x9067; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;
        public const ushort UNSIGNED_INT_IMAGE_BUFFER_OES = 0x9067;
        public const ushort UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
        public const ushort UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
        public const ushort UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
        public const ushort UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES = 0x906A;
        public const ushort UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
        public const ushort UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C; // GlslTypeToken,AttributeType
        public const ushort UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
        public const ushort MAX_IMAGE_SAMPLES = 0x906D;
        public const ushort MAX_IMAGE_SAMPLES_EXT = 0x906D;
        public const ushort IMAGE_BINDING_FORMAT = 0x906E;
        public const ushort IMAGE_BINDING_FORMAT_EXT = 0x906E;
        public const ushort RGB10_A2UI = 0x906F; // InternalFormat
        public const ushort PATH_FORMAT_SVG_NV = 0x9070; // PathStringFormat
        public const ushort PATH_FORMAT_PS_NV = 0x9071; // PathStringFormat
        public const ushort STANDARD_FONT_NAME_NV = 0x9072; // PathFontTarget
        public const ushort SYSTEM_FONT_NAME_NV = 0x9073; // PathFontTarget
        public const ushort FILE_NAME_NV = 0x9074; // PathFontTarget
        public const ushort PATH_STROKE_WIDTH_NV = 0x9075; // PathParameter
        public const ushort PATH_END_CAPS_NV = 0x9076; // PathParameter
        public const ushort PATH_INITIAL_END_CAP_NV = 0x9077; // PathParameter
        public const ushort PATH_TERMINAL_END_CAP_NV = 0x9078; // PathParameter
        public const ushort PATH_JOIN_STYLE_NV = 0x9079; // PathParameter
        public const ushort PATH_MITER_LIMIT_NV = 0x907A; // PathParameter
        public const ushort PATH_DASH_CAPS_NV = 0x907B; // PathParameter
        public const ushort PATH_INITIAL_DASH_CAP_NV = 0x907C; // PathParameter
        public const ushort PATH_TERMINAL_DASH_CAP_NV = 0x907D; // PathParameter
        public const ushort PATH_DASH_OFFSET_NV = 0x907E; // PathParameter
        public const ushort PATH_CLIENT_LENGTH_NV = 0x907F; // PathParameter
        public const ushort PATH_FILL_MODE_NV = 0x9080; // PathParameter,PathFillMode
        public const ushort PATH_FILL_MASK_NV = 0x9081; // PathParameter
        public const ushort PATH_FILL_COVER_MODE_NV = 0x9082; // PathCoverMode,PathParameter
        public const ushort PATH_STROKE_COVER_MODE_NV = 0x9083; // PathParameter
        public const ushort PATH_STROKE_MASK_NV = 0x9084; // PathParameter
        public const ushort COUNT_UP_NV = 0x9088; // PathFillMode
        public const ushort COUNT_DOWN_NV = 0x9089; // PathFillMode
        public const ushort PATH_OBJECT_BOUNDING_BOX_NV = 0x908A; // PathGenMode,PathParameter
        public const ushort CONVEX_HULL_NV = 0x908B; // PathCoverMode
        public const ushort BOUNDING_BOX_NV = 0x908D; // PathCoverMode
        public const ushort TRANSLATE_X_NV = 0x908E; // PathTransformType
        public const ushort TRANSLATE_Y_NV = 0x908F; // PathTransformType
        public const ushort TRANSLATE_2D_NV = 0x9090; // PathTransformType
        public const ushort TRANSLATE_3D_NV = 0x9091; // PathTransformType
        public const ushort AFFINE_2D_NV = 0x9092; // PathTransformType
        public const ushort AFFINE_3D_NV = 0x9094; // PathTransformType
        public const ushort TRANSPOSE_AFFINE_2D_NV = 0x9096; // PathTransformType
        public const ushort TRANSPOSE_AFFINE_3D_NV = 0x9098; // PathTransformType
        public const ushort UTF8_NV = 0x909A; // PathElementType
        public const ushort UTF16_NV = 0x909B; // PathElementType
        public const ushort BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C; // PathCoverMode
        public const ushort PATH_COMMAND_COUNT_NV = 0x909D; // PathParameter
        public const ushort PATH_COORD_COUNT_NV = 0x909E; // PathParameter
        public const ushort PATH_DASH_ARRAY_COUNT_NV = 0x909F; // PathParameter
        public const ushort PATH_COMPUTED_LENGTH_NV = 0x90A0; // PathParameter
        public const ushort PATH_FILL_BOUNDING_BOX_NV = 0x90A1; // PathParameter
        public const ushort PATH_STROKE_BOUNDING_BOX_NV = 0x90A2; // PathParameter
        public const ushort SQUARE_NV = 0x90A3;
        public const ushort ROUND_NV = 0x90A4;
        public const ushort TRIANGULAR_NV = 0x90A5;
        public const ushort BEVEL_NV = 0x90A6;
        public const ushort MITER_REVERT_NV = 0x90A7;
        public const ushort MITER_TRUNCATE_NV = 0x90A8;
        public const ushort SKIP_MISSING_GLYPH_NV = 0x90A9; // PathHandleMissingGlyphs
        public const ushort USE_MISSING_GLYPH_NV = 0x90AA; // PathHandleMissingGlyphs
        public const ushort PATH_ERROR_POSITION_NV = 0x90AB;
        public const ushort PATH_FOG_GEN_MODE_NV = 0x90AC;
        public const ushort ACCUM_ADJACENT_PAIRS_NV = 0x90AD; // PathListMode
        public const ushort ADJACENT_PAIRS_NV = 0x90AE; // PathListMode
        public const ushort FIRST_TO_REST_NV = 0x90AF; // PathListMode
        public const ushort PATH_GEN_MODE_NV = 0x90B0;
        public const ushort PATH_GEN_COEFF_NV = 0x90B1;
        public const ushort PATH_GEN_COLOR_FORMAT_NV = 0x90B2;
        public const ushort PATH_GEN_COMPONENTS_NV = 0x90B3;
        public const ushort PATH_DASH_OFFSET_RESET_NV = 0x90B4; // PathParameter
        public const ushort MOVE_TO_RESETS_NV = 0x90B5;
        public const ushort MOVE_TO_CONTINUES_NV = 0x90B6;
        public const ushort PATH_STENCIL_FUNC_NV = 0x90B7;
        public const ushort PATH_STENCIL_REF_NV = 0x90B8;
        public const ushort PATH_STENCIL_VALUE_MASK_NV = 0x90B9;
        public const ushort SCALED_RESOLVE_FASTEST_EXT = 0x90BA;
        public const ushort SCALED_RESOLVE_NICEST_EXT = 0x90BB;
        public const ushort MIN_MAP_BUFFER_ALIGNMENT = 0x90BC; // GetPName
        public const ushort PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
        public const ushort PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
        public const ushort PATH_COVER_DEPTH_FUNC_NV = 0x90BF;
        // Unused 0x90C0..0x90C6. 
        public const ushort IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7; // InternalFormatPName
        public const ushort IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const ushort IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const ushort MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const ushort MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const ushort MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT = 0x90CB;
        public const ushort MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES = 0x90CB;
        public const ushort MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const ushort MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT = 0x90CC;
        public const ushort MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES = 0x90CC;
        public const ushort MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const ushort MAX_GEOMETRY_IMAGE_UNIFORMS_EXT = 0x90CD;
        public const ushort MAX_GEOMETRY_IMAGE_UNIFORMS_OES = 0x90CD;
        public const ushort MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const ushort MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const ushort MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV = 0x90D0;
        public const ushort MAX_DEEP_3D_TEXTURE_DEPTH_NV = 0x90D1;
        public const ushort SHADER_STORAGE_BUFFER = 0x90D2; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort SHADER_STORAGE_BUFFER_BINDING = 0x90D3; // GetPName
        public const ushort SHADER_STORAGE_BUFFER_START = 0x90D4; // GetPName
        public const ushort SHADER_STORAGE_BUFFER_SIZE = 0x90D5; // GetPName
        public const ushort MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6; // GetPName
        public const ushort MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7; // GetPName
        public const ushort MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT = 0x90D7;
        public const ushort MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES = 0x90D7;
        public const ushort MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8; // GetPName
        public const ushort MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT = 0x90D8;
        public const ushort MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES = 0x90D8;
        public const ushort MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9; // GetPName
        public const ushort MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT = 0x90D9;
        public const ushort MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES = 0x90D9;
        public const ushort MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA; // GetPName
        public const ushort MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB; // GetPName
        public const ushort MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC; // GetPName
        public const ushort MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD; // GetPName
        public const ushort MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const ushort SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF; // GetPName
        // Unused 0x90E0. 
        public const ushort SYNC_X11_FENCE_EXT = 0x90E1;
        // Unused 0x90E2..0x90E9. 
        public const ushort DEPTH_STENCIL_TEXTURE_MODE = 0x90EA; // TextureParameterName
        public const ushort MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB; // GetPName
        // Alias of GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS
        public const ushort MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC; // UniformBlockPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED; // AtomicCounterBufferPName
        public const ushort DISPATCH_INDIRECT_BUFFER = 0x90EE; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF; // GetPName
        public const ushort COLOR_ATTACHMENT_EXT = 0x90F0;
        public const ushort MULTIVIEW_EXT = 0x90F1;
        public const ushort MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;
        public const ushort CONTEXT_ROBUST_ACCESS = 0x90F3;
        public const ushort CONTEXT_ROBUST_ACCESS_EXT = 0x90F3;
        public const ushort CONTEXT_ROBUST_ACCESS_KHR = 0x90F3;
        // Unused 0x90F4..0x90FA. 
        public const ushort COMPUTE_PROGRAM_NV = 0x90FB; // ProgramTarget
        public const ushort COMPUTE_PROGRAM_PARAMETER_BUFFER_NV = 0x90FC;
        // Unused 0x90FD..0x90FF. 
        
        // . 
        public const ushort TEXTURE_2D_MULTISAMPLE = 0x9100; // CopyImageSubDataTarget,TextureTarget
        public const ushort PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101; // TextureTarget
        public const ushort TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102; // CopyImageSubDataTarget,TextureTarget
        public const ushort TEXTURE_2D_MULTISAMPLE_ARRAY_OES = 0x9102;
        public const ushort PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103; // TextureTarget
        public const ushort TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104; // GetPName
        public const ushort TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105; // GetPName
        public const ushort TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES = 0x9105;
        public const ushort TEXTURE_SAMPLES = 0x9106;
        public const ushort TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const ushort SAMPLER_2D_MULTISAMPLE = 0x9108; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_2D_MULTISAMPLE = 0x9109; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B; // GlslTypeToken,AttributeType,UniformType
        public const ushort SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910B;
        public const ushort INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C; // GlslTypeToken,AttributeType,UniformType
        public const ushort INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910C;
        public const ushort UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D; // GlslTypeToken,AttributeType,UniformType
        public const ushort UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES = 0x910D;
        public const ushort MAX_COLOR_TEXTURE_SAMPLES = 0x910E; // GetPName
        public const ushort MAX_DEPTH_TEXTURE_SAMPLES = 0x910F; // GetPName
        public const ushort MAX_INTEGER_SAMPLES = 0x9110; // GetPName
        public const ushort MAX_SERVER_WAIT_TIMEOUT = 0x9111; // GetPName
        public const ushort MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;
        public const ushort OBJECT_TYPE = 0x9112; // SyncParameterName
        public const ushort OBJECT_TYPE_APPLE = 0x9112;
        public const ushort SYNC_CONDITION = 0x9113; // SyncParameterName
        public const ushort SYNC_CONDITION_APPLE = 0x9113;
        public const ushort SYNC_STATUS = 0x9114; // SyncParameterName
        public const ushort SYNC_STATUS_APPLE = 0x9114;
        public const ushort SYNC_FLAGS = 0x9115; // SyncParameterName
        public const ushort SYNC_FLAGS_APPLE = 0x9115;
        public const ushort SYNC_FENCE = 0x9116;
        public const ushort SYNC_FENCE_APPLE = 0x9116;
        public const ushort SYNC_GPU_COMMANDS_COMPLETE = 0x9117; // SyncCondition
        public const ushort SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;
        public const ushort UNSIGNALED = 0x9118;
        public const ushort UNSIGNALED_APPLE = 0x9118;
        public const ushort SIGNALED = 0x9119;
        public const ushort SIGNALED_APPLE = 0x9119;
        public const ushort ALREADY_SIGNALED = 0x911A; // SyncStatus
        public const ushort ALREADY_SIGNALED_APPLE = 0x911A;
        public const ushort TIMEOUT_EXPIRED = 0x911B; // SyncStatus
        public const ushort TIMEOUT_EXPIRED_APPLE = 0x911B;
        public const ushort CONDITION_SATISFIED = 0x911C; // SyncStatus
        public const ushort CONDITION_SATISFIED_APPLE = 0x911C;
        public const ushort WAIT_FAILED = 0x911D; // SyncStatus
        public const ushort WAIT_FAILED_APPLE = 0x911D;
        public const ushort BUFFER_ACCESS_FLAGS = 0x911F; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_MAP_LENGTH = 0x9120; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort BUFFER_MAP_OFFSET = 0x9121; // VertexBufferObjectParameter,BufferPNameARB
        public const ushort MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122; // GetPName
        public const ushort MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123; // GetPName
        public const ushort MAX_GEOMETRY_INPUT_COMPONENTS_EXT = 0x9123;
        public const ushort MAX_GEOMETRY_INPUT_COMPONENTS_OES = 0x9123;
        public const ushort MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124; // GetPName
        public const ushort MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT = 0x9124;
        public const ushort MAX_GEOMETRY_OUTPUT_COMPONENTS_OES = 0x9124;
        public const ushort MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125; // GetPName
        public const ushort CONTEXT_PROFILE_MASK = 0x9126; // GetPName
        public const ushort UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const ushort UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const ushort UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const ushort UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const ushort PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const ushort PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const ushort PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const ushort PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
        public const ushort TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const ushort TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F;
        
        // . Khronos error #882
        public const ushort SGX_PROGRAM_BINARY_IMG = 0x9130;
        // Unused 0x9131..0x9132. 
        public const ushort RENDERBUFFER_SAMPLES_IMG = 0x9133; // RenderbufferParameterName
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;
        public const ushort MAX_SAMPLES_IMG = 0x9135;
        public const ushort TEXTURE_SAMPLES_IMG = 0x9136;
        public const ushort COMPRESSED_RGBA_PVRTC_2BPPV2_IMG = 0x9137;
        public const ushort COMPRESSED_RGBA_PVRTC_4BPPV2_IMG = 0x9138;
        public const ushort CUBIC_IMG = 0x9139;
        public const ushort CUBIC_MIPMAP_NEAREST_IMG = 0x913A;
        public const ushort CUBIC_MIPMAP_LINEAR_IMG = 0x913B;
        public const ushort FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG = 0x913C;
        public const ushort NUM_DOWNSAMPLE_SCALES_IMG = 0x913D;
        public const ushort DOWNSAMPLE_SCALES_IMG = 0x913E;
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F; // FramebufferAttachmentParameterName
        
        // . Khronos bugs 5899, 6004
        // Unused 0x9140..0x9142. 
        public const ushort MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        public const ushort MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143;
        public const ushort MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
        public const ushort MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143;
        public const ushort MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        public const ushort MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144;
        public const ushort MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
        public const ushort MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144;
        public const ushort DEBUG_LOGGED_MESSAGES = 0x9145;
        public const ushort DEBUG_LOGGED_MESSAGES_AMD = 0x9145;
        public const ushort DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
        public const ushort DEBUG_LOGGED_MESSAGES_KHR = 0x9145;
        public const ushort DEBUG_SEVERITY_HIGH = 0x9146; // DebugSeverity
        public const ushort DEBUG_SEVERITY_HIGH_AMD = 0x9146;
        public const ushort DEBUG_SEVERITY_HIGH_ARB = 0x9146;
        public const ushort DEBUG_SEVERITY_HIGH_KHR = 0x9146;
        public const ushort DEBUG_SEVERITY_MEDIUM = 0x9147; // DebugSeverity
        public const ushort DEBUG_SEVERITY_MEDIUM_AMD = 0x9147;
        public const ushort DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
        public const ushort DEBUG_SEVERITY_MEDIUM_KHR = 0x9147;
        public const ushort DEBUG_SEVERITY_LOW = 0x9148; // DebugSeverity
        public const ushort DEBUG_SEVERITY_LOW_AMD = 0x9148;
        public const ushort DEBUG_SEVERITY_LOW_ARB = 0x9148;
        public const ushort DEBUG_SEVERITY_LOW_KHR = 0x9148;
        public const ushort DEBUG_CATEGORY_API_ERROR_AMD = 0x9149;
        public const ushort DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A;
        public const ushort DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B;
        public const ushort DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C;
        public const ushort DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D;
        public const ushort DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E;
        public const ushort DEBUG_CATEGORY_APPLICATION_AMD = 0x914F;
        public const ushort DEBUG_CATEGORY_OTHER_AMD = 0x9150;
        public const ushort BUFFER_OBJECT_EXT = 0x9151;
        public const ushort DATA_BUFFER_AMD = 0x9151;
        public const ushort PERFORMANCE_MONITOR_AMD = 0x9152;
        public const ushort QUERY_OBJECT_AMD = 0x9153;
        public const ushort QUERY_OBJECT_EXT = 0x9153;
        public const ushort VERTEX_ARRAY_OBJECT_AMD = 0x9154;
        public const ushort VERTEX_ARRAY_OBJECT_EXT = 0x9154;
        public const ushort SAMPLER_OBJECT_AMD = 0x9155;
        // Unused 0x9156..0x915F. 
        public const ushort EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
        // Unused 0x9161. 
        public const ushort QUERY_BUFFER = 0x9192; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort QUERY_BUFFER_AMD = 0x9192;
        public const ushort QUERY_BUFFER_BINDING = 0x9193;
        public const ushort QUERY_BUFFER_BINDING_AMD = 0x9193;
        public const ushort QUERY_RESULT_NO_WAIT = 0x9194; // QueryObjectParameterName
        public const ushort QUERY_RESULT_NO_WAIT_AMD = 0x9194;
        public const ushort VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;
        public const ushort VIRTUAL_PAGE_SIZE_X_EXT = 0x9195;
        public const ushort VIRTUAL_PAGE_SIZE_X_AMD = 0x9195;
        public const ushort VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;
        public const ushort VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196;
        public const ushort VIRTUAL_PAGE_SIZE_Y_AMD = 0x9196;
        public const ushort VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;
        public const ushort VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197;
        public const ushort VIRTUAL_PAGE_SIZE_Z_AMD = 0x9197;
        public const ushort MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;
        public const ushort MAX_SPARSE_TEXTURE_SIZE_EXT = 0x9198;
        public const ushort MAX_SPARSE_TEXTURE_SIZE_AMD = 0x9198;
        public const ushort MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;
        public const ushort MAX_SPARSE_3D_TEXTURE_SIZE_EXT = 0x9199;
        public const ushort MAX_SPARSE_3D_TEXTURE_SIZE_AMD = 0x9199;
        public const ushort MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;
        public const ushort MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB = 0x919A;
        public const ushort MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT = 0x919A;
        public const ushort MIN_SPARSE_LEVEL_AMD = 0x919B;
        public const ushort MIN_LOD_WARNING_AMD = 0x919C;
        public const ushort TEXTURE_BUFFER_OFFSET = 0x919D;
        public const ushort TEXTURE_BUFFER_OFFSET_EXT = 0x919D;
        public const ushort TEXTURE_BUFFER_OFFSET_OES = 0x919D;
        public const ushort TEXTURE_BUFFER_SIZE = 0x919E;
        public const ushort TEXTURE_BUFFER_SIZE_EXT = 0x919E;
        public const ushort TEXTURE_BUFFER_SIZE_OES = 0x919E;
        public const ushort TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F; // GetPName
        public const ushort TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT = 0x919F;
        public const ushort TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES = 0x919F;
        public const ushort STREAM_RASTERIZATION_AMD = 0x91A0;
        // Unused 0x91A1..0x91A3. 
        public const ushort VERTEX_ELEMENT_SWIZZLE_AMD = 0x91A4;
        public const ushort VERTEX_ID_SWIZZLE_AMD = 0x91A5;
        public const ushort TEXTURE_SPARSE_ARB = 0x91A6;
        public const ushort TEXTURE_SPARSE_EXT = 0x91A6;
        public const ushort VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;
        public const ushort VIRTUAL_PAGE_SIZE_INDEX_EXT = 0x91A7;
        public const ushort NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;
        public const ushort NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8;
        public const ushort SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;
        public const ushort SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT = 0x91A9;
        public const ushort NUM_SPARSE_LEVELS_ARB = 0x91AA;
        public const ushort NUM_SPARSE_LEVELS_EXT = 0x91AA;
        // Unused 0x91AB..0x91AD. 
        public const ushort PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE;
        public const ushort PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF;
        public const ushort MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0;
        // Alias of GL_MAX_SHADER_COMPILER_THREADS_KHR
        public const ushort MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
        public const ushort COMPLETION_STATUS_KHR = 0x91B1;
        // Alias of GL_COMPLETION_STATUS_KHR
        public const ushort COMPLETION_STATUS_ARB = 0x91B1;
        public const ushort RENDERBUFFER_STORAGE_SAMPLES_AMD = 0x91B2; // RenderbufferParameterName
        public const ushort MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD = 0x91B3;
        public const ushort MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD = 0x91B4;
        public const ushort MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD = 0x91B5;
        public const ushort NUM_SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B6;
        public const ushort SUPPORTED_MULTISAMPLE_MODES_AMD = 0x91B7;
        // Unused 0x91B8..0x91B8. 
        public const ushort COMPUTE_SHADER = 0x91B9; // ShaderType
        // Unused 0x91BA. 
        public const ushort MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB; // GetPName
        public const ushort MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC; // GetPName
        public const ushort MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const ushort MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE; // GetPName
        public const ushort MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF; // GetPName
        // Alias of GL_MAX_COMPUTE_WORK_GROUP_SIZE
        public const ushort MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
        // Unused 0x91C0..0x91C4. 
        public const ushort FLOAT16_MAT2_AMD = 0x91C5;
        public const ushort FLOAT16_MAT3_AMD = 0x91C6;
        public const ushort FLOAT16_MAT4_AMD = 0x91C7;
        public const ushort FLOAT16_MAT2x3_AMD = 0x91C8;
        public const ushort FLOAT16_MAT2x4_AMD = 0x91C9;
        public const ushort FLOAT16_MAT3x2_AMD = 0x91CA;
        public const ushort FLOAT16_MAT3x4_AMD = 0x91CB;
        public const ushort FLOAT16_MAT4x2_AMD = 0x91CC;
        public const ushort FLOAT16_MAT4x3_AMD = 0x91CD;
        // Unused 0x91CE..0x923F. 
        
        // . Khronos error #6473,6884
        public const ushort UNPACK_FLIP_Y_WEBGL = 0x9240;
        public const ushort UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
        public const ushort CONTEXT_LOST_WEBGL = 0x9242;
        public const ushort UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
        public const ushort BROWSER_DEFAULT_WEBGL = 0x9244;
        // Unused 0x9245..0x924F. 
        
        // . For Eisaku Ohbuchi via email
        public const ushort SHADER_BINARY_DMP = 0x9250;
        public const ushort SMAPHS30_PROGRAM_BINARY_DMP = 0x9251;
        public const ushort SMAPHS_PROGRAM_BINARY_DMP = 0x9252;
        public const ushort DMP_PROGRAM_BINARY_DMP = 0x9253;
        // Unused 0x9254..0x925F. 
        
        // . Khronos error #7486
        public const ushort GCCSO_SHADER_BINARY_FJ = 0x9260;
        // Unused 0x9261..0x926F. 
        
        // . Khronos error #7625
        public const ushort COMPRESSED_R11_EAC = 0x9270; // InternalFormat
        public const ushort COMPRESSED_R11_EAC_OES = 0x9270;
        public const ushort COMPRESSED_SIGNED_R11_EAC = 0x9271; // InternalFormat
        public const ushort COMPRESSED_SIGNED_R11_EAC_OES = 0x9271;
        public const ushort COMPRESSED_RG11_EAC = 0x9272; // InternalFormat
        public const ushort COMPRESSED_RG11_EAC_OES = 0x9272;
        public const ushort COMPRESSED_SIGNED_RG11_EAC = 0x9273; // InternalFormat
        public const ushort COMPRESSED_SIGNED_RG11_EAC_OES = 0x9273;
        public const ushort COMPRESSED_RGB8_ETC2 = 0x9274; // InternalFormat
        public const ushort COMPRESSED_RGB8_ETC2_OES = 0x9274;
        public const ushort COMPRESSED_SRGB8_ETC2 = 0x9275; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ETC2_OES = 0x9275;
        public const ushort COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276; // InternalFormat
        public const ushort COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES = 0x9276;
        public const ushort COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277; // InternalFormat
        public const ushort COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2_OES = 0x9277;
        public const ushort COMPRESSED_RGBA8_ETC2_EAC = 0x9278; // InternalFormat
        public const ushort COMPRESSED_RGBA8_ETC2_EAC_OES = 0x9278;
        public const ushort COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ETC2_EAC_OES = 0x9279;
        // Unused 0x927A..0x927F. 
        
        // . Khronos error #7658
        public const ushort BLEND_PREMULTIPLIED_SRC_NV = 0x9280;
        public const ushort BLEND_OVERLAP_NV = 0x9281;
        public const ushort UNCORRELATED_NV = 0x9282;
        public const ushort DISJOINT_NV = 0x9283;
        public const ushort CONJOINT_NV = 0x9284;
        public const ushort BLEND_ADVANCED_COHERENT_KHR = 0x9285;
        public const ushort BLEND_ADVANCED_COHERENT_NV = 0x9285;
        public const ushort SRC_NV = 0x9286;
        public const ushort DST_NV = 0x9287;
        public const ushort SRC_OVER_NV = 0x9288;
        public const ushort DST_OVER_NV = 0x9289;
        public const ushort SRC_IN_NV = 0x928A;
        public const ushort DST_IN_NV = 0x928B;
        public const ushort SRC_OUT_NV = 0x928C;
        public const ushort DST_OUT_NV = 0x928D;
        public const ushort SRC_ATOP_NV = 0x928E;
        public const ushort DST_ATOP_NV = 0x928F;
        // Unused 0x9290. 
        public const ushort PLUS_NV = 0x9291;
        public const ushort PLUS_DARKER_NV = 0x9292;
        // Unused 0x9293. 
        public const ushort MULTIPLY = 0x9294;
        public const ushort MULTIPLY_KHR = 0x9294;
        public const ushort MULTIPLY_NV = 0x9294;
        public const ushort SCREEN = 0x9295;
        public const ushort SCREEN_KHR = 0x9295;
        public const ushort SCREEN_NV = 0x9295;
        public const ushort OVERLAY = 0x9296;
        public const ushort OVERLAY_KHR = 0x9296;
        public const ushort OVERLAY_NV = 0x9296;
        public const ushort DARKEN = 0x9297;
        public const ushort DARKEN_KHR = 0x9297;
        public const ushort DARKEN_NV = 0x9297;
        public const ushort LIGHTEN = 0x9298;
        public const ushort LIGHTEN_KHR = 0x9298;
        public const ushort LIGHTEN_NV = 0x9298;
        public const ushort COLORDODGE = 0x9299;
        public const ushort COLORDODGE_KHR = 0x9299;
        public const ushort COLORDODGE_NV = 0x9299;
        public const ushort COLORBURN = 0x929A;
        public const ushort COLORBURN_KHR = 0x929A;
        public const ushort COLORBURN_NV = 0x929A;
        public const ushort HARDLIGHT = 0x929B;
        public const ushort HARDLIGHT_KHR = 0x929B;
        public const ushort HARDLIGHT_NV = 0x929B;
        public const ushort SOFTLIGHT = 0x929C;
        public const ushort SOFTLIGHT_KHR = 0x929C;
        public const ushort SOFTLIGHT_NV = 0x929C;
        // Unused 0x929D. 
        public const ushort DIFFERENCE = 0x929E;
        public const ushort DIFFERENCE_KHR = 0x929E;
        public const ushort DIFFERENCE_NV = 0x929E;
        public const ushort MINUS_NV = 0x929F;
        public const ushort EXCLUSION = 0x92A0;
        public const ushort EXCLUSION_KHR = 0x92A0;
        public const ushort EXCLUSION_NV = 0x92A0;
        public const ushort CONTRAST_NV = 0x92A1;
        // Unused 0x92A2. 
        public const ushort INVERT_RGB_NV = 0x92A3;
        public const ushort LINEARDODGE_NV = 0x92A4;
        public const ushort LINEARBURN_NV = 0x92A5;
        public const ushort VIVIDLIGHT_NV = 0x92A6;
        public const ushort LINEARLIGHT_NV = 0x92A7;
        public const ushort PINLIGHT_NV = 0x92A8;
        public const ushort HARDMIX_NV = 0x92A9;
        // Unused 0x92AA..0x92AC. 
        public const ushort HSL_HUE = 0x92AD;
        public const ushort HSL_HUE_KHR = 0x92AD;
        public const ushort HSL_HUE_NV = 0x92AD;
        public const ushort HSL_SATURATION = 0x92AE;
        public const ushort HSL_SATURATION_KHR = 0x92AE;
        public const ushort HSL_SATURATION_NV = 0x92AE;
        public const ushort HSL_COLOR = 0x92AF;
        public const ushort HSL_COLOR_KHR = 0x92AF;
        public const ushort HSL_COLOR_NV = 0x92AF;
        public const ushort HSL_LUMINOSITY = 0x92B0;
        public const ushort HSL_LUMINOSITY_KHR = 0x92B0;
        public const ushort HSL_LUMINOSITY_NV = 0x92B0;
        public const ushort PLUS_CLAMPED_NV = 0x92B1;
        public const ushort PLUS_CLAMPED_ALPHA_NV = 0x92B2;
        public const ushort MINUS_CLAMPED_NV = 0x92B3;
        public const ushort INVERT_OVG_NV = 0x92B4;
        // Unused 0x92B5..0x92B9. 
        public const ushort MAX_LGPU_GPUS_NVX = 0x92BA;
        public const ushort MULTICAST_GPUS_NV = 0x92BA;
        public const ushort PURGED_CONTEXT_RESET_NV = 0x92BB;
        // Unused 0x92BC..0x92BD. 
        public const ushort PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
        public const ushort PRIMITIVE_BOUNDING_BOX = 0x92BE;
        public const ushort PRIMITIVE_BOUNDING_BOX_EXT = 0x92BE;
        public const ushort PRIMITIVE_BOUNDING_BOX_OES = 0x92BE;
        public const ushort ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;
        public const ushort ATOMIC_COUNTER_BUFFER = 0x92C0; // CopyBufferSubDataTarget,BufferTargetARB,BufferStorageTarget
        public const ushort ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const ushort ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const ushort ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA; // AtomicCounterBufferPName
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB; // AtomicCounterBufferPName
        public const ushort MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CD;
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES = 0x92CD;
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CE;
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES = 0x92CE;
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT = 0x92CF;
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES = 0x92CF;
        public const ushort MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const ushort MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const ushort MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2; // GetPName
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3; // GetPName
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT = 0x92D3;
        public const ushort MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES = 0x92D3;
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4; // GetPName
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT = 0x92D4;
        public const ushort MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES = 0x92D4;
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5; // GetPName
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTERS_EXT = 0x92D5;
        public const ushort MAX_GEOMETRY_ATOMIC_COUNTERS_OES = 0x92D5;
        public const ushort MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6; // GetPName
        public const ushort MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7; // GetPName
        public const ushort MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const ushort ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9; // ProgramPropertyARB
        public const ushort UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA; // UniformPName
        public const ushort UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB; // GlslTypeToken
        public const ushort MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const ushort FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;
        public const ushort FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;
        public const ushort MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV = 0x92DF;
        public const ushort DEBUG_OUTPUT = 0x92E0; // EnableCap
        public const ushort DEBUG_OUTPUT_KHR = 0x92E0;
        public const ushort UNIFORM = 0x92E1; // ProgramResourceProperty,ProgramInterface
        public const ushort UNIFORM_BLOCK = 0x92E2; // ProgramInterface
        public const ushort PROGRAM_INPUT = 0x92E3; // ProgramInterface
        public const ushort PROGRAM_OUTPUT = 0x92E4; // ProgramInterface
        public const ushort BUFFER_VARIABLE = 0x92E5; // ProgramInterface
        public const ushort SHADER_STORAGE_BLOCK = 0x92E6; // ProgramInterface
        public const ushort IS_PER_PATCH = 0x92E7; // ProgramResourceProperty
        public const ushort IS_PER_PATCH_EXT = 0x92E7;
        public const ushort IS_PER_PATCH_OES = 0x92E7;
        public const ushort VERTEX_SUBROUTINE = 0x92E8; // ProgramInterface
        public const ushort TESS_CONTROL_SUBROUTINE = 0x92E9; // ProgramInterface
        public const ushort TESS_EVALUATION_SUBROUTINE = 0x92EA; // ProgramInterface
        public const ushort GEOMETRY_SUBROUTINE = 0x92EB; // ProgramInterface
        public const ushort FRAGMENT_SUBROUTINE = 0x92EC; // ProgramInterface
        public const ushort COMPUTE_SUBROUTINE = 0x92ED; // ProgramInterface
        public const ushort VERTEX_SUBROUTINE_UNIFORM = 0x92EE; // ProgramInterface
        public const ushort TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF; // ProgramInterface
        public const ushort TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0; // ProgramInterface
        public const ushort GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1; // ProgramInterface
        public const ushort FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2; // ProgramInterface
        public const ushort COMPUTE_SUBROUTINE_UNIFORM = 0x92F3; // ProgramInterface
        public const ushort TRANSFORM_FEEDBACK_VARYING = 0x92F4; // ProgramInterface
        public const ushort ACTIVE_RESOURCES = 0x92F5; // ProgramInterfacePName
        public const ushort MAX_NAME_LENGTH = 0x92F6; // ProgramInterfacePName
        public const ushort MAX_NUM_ACTIVE_VARIABLES = 0x92F7; // ProgramInterfacePName
        public const ushort MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8; // ProgramInterfacePName
        public const ushort NAME_LENGTH = 0x92F9; // ProgramResourceProperty
        public const ushort TYPE = 0x92FA; // ProgramResourceProperty
        public const ushort ARRAY_SIZE = 0x92FB; // ProgramResourceProperty
        public const ushort OFFSET = 0x92FC; // ProgramResourceProperty
        public const ushort BLOCK_INDEX = 0x92FD; // ProgramResourceProperty
        public const ushort ARRAY_STRIDE = 0x92FE; // ProgramResourceProperty
        public const ushort MATRIX_STRIDE = 0x92FF; // ProgramResourceProperty
        public const ushort IS_ROW_MAJOR = 0x9300; // ProgramResourceProperty
        public const ushort ATOMIC_COUNTER_BUFFER_INDEX = 0x9301; // ProgramResourceProperty
        public const ushort BUFFER_BINDING = 0x9302; // ProgramResourceProperty
        public const ushort BUFFER_DATA_SIZE = 0x9303; // ProgramResourceProperty
        public const ushort NUM_ACTIVE_VARIABLES = 0x9304; // ProgramResourceProperty
        public const ushort ACTIVE_VARIABLES = 0x9305; // ProgramResourceProperty
        public const ushort REFERENCED_BY_VERTEX_SHADER = 0x9306; // ProgramResourceProperty
        public const ushort REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307; // ProgramResourceProperty
        public const ushort REFERENCED_BY_TESS_CONTROL_SHADER_EXT = 0x9307;
        public const ushort REFERENCED_BY_TESS_CONTROL_SHADER_OES = 0x9307;
        public const ushort REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308; // ProgramResourceProperty
        public const ushort REFERENCED_BY_TESS_EVALUATION_SHADER_EXT = 0x9308;
        public const ushort REFERENCED_BY_TESS_EVALUATION_SHADER_OES = 0x9308;
        public const ushort REFERENCED_BY_GEOMETRY_SHADER = 0x9309; // ProgramResourceProperty
        public const ushort REFERENCED_BY_GEOMETRY_SHADER_EXT = 0x9309;
        public const ushort REFERENCED_BY_GEOMETRY_SHADER_OES = 0x9309;
        public const ushort REFERENCED_BY_FRAGMENT_SHADER = 0x930A; // ProgramResourceProperty
        public const ushort REFERENCED_BY_COMPUTE_SHADER = 0x930B; // ProgramResourceProperty
        public const ushort TOP_LEVEL_ARRAY_SIZE = 0x930C; // ProgramResourceProperty
        public const ushort TOP_LEVEL_ARRAY_STRIDE = 0x930D; // ProgramResourceProperty
        public const ushort LOCATION = 0x930E; // ProgramResourceProperty
        public const ushort LOCATION_INDEX = 0x930F; // ProgramResourceProperty
        public const ushort LOCATION_INDEX_EXT = 0x930F;
        public const ushort FRAMEBUFFER_DEFAULT_WIDTH = 0x9310; // GetFramebufferParameter,FramebufferParameterName
        public const ushort FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311; // GetFramebufferParameter,FramebufferParameterName
        public const ushort FRAMEBUFFER_DEFAULT_LAYERS = 0x9312; // GetFramebufferParameter,FramebufferParameterName
        public const ushort FRAMEBUFFER_DEFAULT_LAYERS_EXT = 0x9312;
        public const ushort FRAMEBUFFER_DEFAULT_LAYERS_OES = 0x9312;
        public const ushort FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313; // GetFramebufferParameter,FramebufferParameterName
        public const ushort FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314; // GetFramebufferParameter,FramebufferParameterName
        public const ushort MAX_FRAMEBUFFER_WIDTH = 0x9315; // GetPName
        public const ushort MAX_FRAMEBUFFER_HEIGHT = 0x9316; // GetPName
        public const ushort MAX_FRAMEBUFFER_LAYERS = 0x9317; // GetPName
        public const ushort MAX_FRAMEBUFFER_LAYERS_EXT = 0x9317;
        public const ushort MAX_FRAMEBUFFER_LAYERS_OES = 0x9317;
        public const ushort MAX_FRAMEBUFFER_SAMPLES = 0x9318; // GetPName
        // Unused 0x9319..0x9326. 
        public const ushort RASTER_MULTISAMPLE_EXT = 0x9327;
        public const ushort RASTER_SAMPLES_EXT = 0x9328;
        public const ushort MAX_RASTER_SAMPLES_EXT = 0x9329;
        public const ushort RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;
        public const ushort MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;
        public const ushort EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;
        public const ushort DEPTH_SAMPLES_NV = 0x932D;
        public const ushort STENCIL_SAMPLES_NV = 0x932E;
        public const ushort MIXED_DEPTH_SAMPLES_SUPPORTED_NV = 0x932F;
        public const ushort MIXED_STENCIL_SAMPLES_SUPPORTED_NV = 0x9330;
        public const ushort COVERAGE_MODULATION_TABLE_NV = 0x9331;
        public const ushort COVERAGE_MODULATION_NV = 0x9332;
        public const ushort COVERAGE_MODULATION_TABLE_SIZE_NV = 0x9333;
        // Unused 0x9334..0x9338. 
        public const ushort WARP_SIZE_NV = 0x9339;
        public const ushort WARPS_PER_SM_NV = 0x933A;
        public const ushort SM_COUNT_NV = 0x933B;
        public const ushort FILL_RECTANGLE_NV = 0x933C;
        public const ushort SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
        public const ushort SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;
        public const ushort SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
        public const ushort SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;
        public const ushort SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
        public const ushort SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;
        public const ushort PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
        public const ushort PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;
        public const ushort PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341; // GetMultisamplePNameNV
        public const ushort PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;
        public const ushort FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
        public const ushort FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;
        public const ushort FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;
        public const ushort FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;
        public const ushort MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
        public const ushort MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
        public const ushort CONSERVATIVE_RASTERIZATION_NV = 0x9346;
        public const ushort SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;
        public const ushort SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;
        public const ushort MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;
        public const ushort LOCATION_COMPONENT = 0x934A; // ProgramResourceProperty
        public const ushort TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B; // ProgramResourceProperty
        public const ushort TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C; // ProgramResourceProperty
        public const ushort ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;
        public const ushort ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;
        public const ushort ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;
        public const ushort VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;
        public const ushort VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;
        public const ushort VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;
        public const ushort VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;
        public const ushort VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;
        public const ushort VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;
        public const ushort VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;
        public const ushort VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;
        public const ushort VIEWPORT_SWIZZLE_X_NV = 0x9358;
        public const ushort VIEWPORT_SWIZZLE_Y_NV = 0x9359;
        public const ushort VIEWPORT_SWIZZLE_Z_NV = 0x935A;
        public const ushort VIEWPORT_SWIZZLE_W_NV = 0x935B;
        public const ushort CLIP_ORIGIN = 0x935C;
        // Alias of GL_CLIP_ORIGIN
        public const ushort CLIP_ORIGIN_EXT = 0x935C;
        public const ushort CLIP_DEPTH_MODE = 0x935D;
        // Alias of GL_CLIP_DEPTH_MODE
        public const ushort CLIP_DEPTH_MODE_EXT = 0x935D;
        public const ushort NEGATIVE_ONE_TO_ONE = 0x935E; // ClipControlDepth
        // Alias of GL_NEGATIVE_ONE_TO_ONE
        public const ushort NEGATIVE_ONE_TO_ONE_EXT = 0x935E;
        public const ushort ZERO_TO_ONE = 0x935F; // ClipControlDepth
        // Alias of GL_ZERO_TO_ONE
        public const ushort ZERO_TO_ONE_EXT = 0x935F;
        // Unused 0x9360..0x9364. 
        public const ushort CLEAR_TEXTURE = 0x9365; // InternalFormatPName
        public const ushort TEXTURE_REDUCTION_MODE_ARB = 0x9366;
        // Alias of GL_TEXTURE_REDUCTION_MODE_ARB
        public const ushort TEXTURE_REDUCTION_MODE_EXT = 0x9366;
        public const ushort WEIGHTED_AVERAGE_ARB = 0x9367;
        // Alias of GL_WEIGHTED_AVERAGE_ARB
        public const ushort WEIGHTED_AVERAGE_EXT = 0x9367;
        public const ushort FONT_GLYPHS_AVAILABLE_NV = 0x9368;
        public const ushort FONT_TARGET_UNAVAILABLE_NV = 0x9369;
        public const ushort FONT_UNAVAILABLE_NV = 0x936A;
        public const ushort FONT_UNINTELLIGIBLE_NV = 0x936B;
        public const ushort STANDARD_FONT_FORMAT_NV = 0x936C;
        public const ushort FRAGMENT_INPUT_NV = 0x936D;
        public const ushort UNIFORM_BUFFER_UNIFIED_NV = 0x936E;
        public const ushort UNIFORM_BUFFER_ADDRESS_NV = 0x936F;
        public const ushort UNIFORM_BUFFER_LENGTH_NV = 0x9370;
        public const ushort MULTISAMPLES_NV = 0x9371;
        public const ushort SUPERSAMPLE_SCALE_X_NV = 0x9372;
        public const ushort SUPERSAMPLE_SCALE_Y_NV = 0x9373;
        public const ushort CONFORMANT_NV = 0x9374;
        // Unused 0x9375..0x9378. 
        public const ushort CONSERVATIVE_RASTER_DILATE_NV = 0x9379;
        public const ushort CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;
        public const ushort CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;
        public const ushort VIEWPORT_POSITION_W_SCALE_NV = 0x937C;
        public const ushort VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D;
        public const ushort VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E;
        public const ushort REPRESENTATIVE_FRAGMENT_TEST_NV = 0x937F;
        
        // . 
        public const ushort NUM_SAMPLE_COUNTS = 0x9380; // InternalFormatPName
        public const ushort MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
        public const ushort MULTISAMPLE_LINE_WIDTH_RANGE = 0x9381;
        public const ushort MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
        public const ushort MULTISAMPLE_LINE_WIDTH_GRANULARITY = 0x9382;
        public const ushort VIEW_CLASS_EAC_R11 = 0x9383;
        public const ushort VIEW_CLASS_EAC_RG11 = 0x9384;
        public const ushort VIEW_CLASS_ETC2_RGB = 0x9385;
        public const ushort VIEW_CLASS_ETC2_RGBA = 0x9386;
        public const ushort VIEW_CLASS_ETC2_EAC_RGBA = 0x9387;
        public const ushort VIEW_CLASS_ASTC_4x4_RGBA = 0x9388;
        public const ushort VIEW_CLASS_ASTC_5x4_RGBA = 0x9389;
        public const ushort VIEW_CLASS_ASTC_5x5_RGBA = 0x938A;
        public const ushort VIEW_CLASS_ASTC_6x5_RGBA = 0x938B;
        public const ushort VIEW_CLASS_ASTC_6x6_RGBA = 0x938C;
        public const ushort VIEW_CLASS_ASTC_8x5_RGBA = 0x938D;
        public const ushort VIEW_CLASS_ASTC_8x6_RGBA = 0x938E;
        public const ushort VIEW_CLASS_ASTC_8x8_RGBA = 0x938F;
        public const ushort VIEW_CLASS_ASTC_10x5_RGBA = 0x9390;
        public const ushort VIEW_CLASS_ASTC_10x6_RGBA = 0x9391;
        public const ushort VIEW_CLASS_ASTC_10x8_RGBA = 0x9392;
        public const ushort VIEW_CLASS_ASTC_10x10_RGBA = 0x9393;
        public const ushort VIEW_CLASS_ASTC_12x10_RGBA = 0x9394;
        public const ushort VIEW_CLASS_ASTC_12x12_RGBA = 0x9395;
        // Unused 0x9396..0x939F. reserved for ASTC 3D interactions with ARB_ifq2
        
        // . Khronos error #8100
        public const ushort TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;
        public const ushort BGRA8_EXT = 0x93A1;
        public const ushort TEXTURE_USAGE_ANGLE = 0x93A2;
        public const ushort FRAMEBUFFER_ATTACHMENT_ANGLE = 0x93A3;
        public const ushort PACK_REVERSE_ROW_ORDER_ANGLE = 0x93A4;
        // Unused 0x93A5. 
        public const ushort PROGRAM_BINARY_ANGLE = 0x93A6;
        // Unused 0x93A7..0x93AF. 
        
        // . Khronos error #8853
        public const ushort COMPRESSED_RGBA_ASTC_4x4 = 0x93B0; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x4 = 0x93B1; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x5 = 0x93B2; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x5 = 0x93B3; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x6 = 0x93B4; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x5 = 0x93B5; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x6 = 0x93B6; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x8 = 0x93B7; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x5 = 0x93B8; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x6 = 0x93B9; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x8 = 0x93BA; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x10 = 0x93BB; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_12x10 = 0x93BC; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_12x12 = 0x93BD; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD; // InternalFormat
        // Unused 0x93BE..0x93BF. 
        public const ushort COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8; // InternalFormat
        public const ushort COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9; // InternalFormat
        // Unused 0x93CA..0x93CF. 
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD; // InternalFormat
        // Unused 0x93DE..0x93DF. 
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8; // InternalFormat
        public const ushort COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9; // InternalFormat
        // Unused 0x93EA..0x93EF. 
        
        // . Khronos error #10233
        public const ushort COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG = 0x93F0;
        public const ushort COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG = 0x93F1;
        // Unused 0x93F2..0x94EF. 
        
        // . Khronos error #11345
        public const ushort PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;
        public const ushort PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;
        public const ushort PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;
        public const ushort PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;
        public const ushort PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;
        public const ushort PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;
        // Unused 0x94F6..0x94F7. 
        public const ushort PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;
        public const ushort PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;
        public const ushort PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;
        public const ushort PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;
        public const ushort PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;
        public const ushort PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;
        public const ushort PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;
        public const ushort PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;
        public const ushort PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;
        // Unused 0x9501..0x950F. 
        
        // . Khronos error #12203
        // Unused 0x9510..0x952F. 
        
        // . Khronos error #12977
        public const ushort LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530; // TextureLayout
        public const ushort LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531; // TextureLayout
        public const ushort SUBGROUP_SIZE_KHR = 0x9532;
        public const ushort SUBGROUP_SUPPORTED_STAGES_KHR = 0x9533;
        public const ushort SUBGROUP_SUPPORTED_FEATURES_KHR = 0x9534;
        public const ushort SUBGROUP_QUAD_ALL_STAGES_KHR = 0x9535;
        public const ushort MAX_MESH_TOTAL_MEMORY_SIZE_NV = 0x9536;
        public const ushort MAX_TASK_TOTAL_MEMORY_SIZE_NV = 0x9537;
        public const ushort MAX_MESH_OUTPUT_VERTICES_NV = 0x9538;
        public const ushort MAX_MESH_OUTPUT_PRIMITIVES_NV = 0x9539;
        public const ushort MAX_TASK_OUTPUT_COUNT_NV = 0x953A;
        public const ushort MAX_MESH_WORK_GROUP_SIZE_NV = 0x953B;
        public const ushort MAX_TASK_WORK_GROUP_SIZE_NV = 0x953C;
        public const ushort MAX_DRAW_MESH_TASKS_COUNT_NV = 0x953D;
        public const ushort MESH_WORK_GROUP_SIZE_NV = 0x953E;
        public const ushort TASK_WORK_GROUP_SIZE_NV = 0x953F;
        public const ushort QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV = 0x9540;
        // Unused 0x9541. 
        public const ushort QUERY_RESOURCE_MEMTYPE_VIDMEM_NV = 0x9542;
        public const ushort MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV = 0x9543;
        public const ushort QUERY_RESOURCE_SYS_RESERVED_NV = 0x9544;
        public const ushort QUERY_RESOURCE_TEXTURE_NV = 0x9545;
        public const ushort QUERY_RESOURCE_RENDERBUFFER_NV = 0x9546;
        public const ushort QUERY_RESOURCE_BUFFEROBJECT_NV = 0x9547;
        public const ushort PER_GPU_STORAGE_NV = 0x9548;
        public const ushort MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549;
        public const ushort UPLOAD_GPU_MASK_NVX = 0x954A;
        // Unused 0x954B..0x954C. 
        public const ushort CONSERVATIVE_RASTER_MODE_NV = 0x954D;
        public const ushort CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;
        public const ushort CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;
        public const ushort CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV = 0x9550;
        public const ushort SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
        // Alias of GL_SHADER_BINARY_FORMAT_SPIR_V
        public const ushort SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
        public const ushort SPIR_V_BINARY = 0x9552;
        // Alias of GL_SPIR_V_BINARY
        public const ushort SPIR_V_BINARY_ARB = 0x9552;
        public const ushort SPIR_V_EXTENSIONS = 0x9553;
        public const ushort NUM_SPIR_V_EXTENSIONS = 0x9554;
        public const ushort SCISSOR_TEST_EXCLUSIVE_NV = 0x9555;
        public const ushort SCISSOR_BOX_EXCLUSIVE_NV = 0x9556;
        public const ushort MAX_MESH_VIEWS_NV = 0x9557;
        public const ushort RENDER_GPU_MASK_NV = 0x9558;
        public const ushort MESH_SHADER_NV = 0x9559;
        public const ushort TASK_SHADER_NV = 0x955A;
        public const ushort SHADING_RATE_IMAGE_BINDING_NV = 0x955B;
        public const ushort SHADING_RATE_IMAGE_TEXEL_WIDTH_NV = 0x955C;
        public const ushort SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV = 0x955D;
        public const ushort SHADING_RATE_IMAGE_PALETTE_SIZE_NV = 0x955E;
        public const ushort MAX_COARSE_FRAGMENT_SAMPLES_NV = 0x955F;
        // Unused 0x9560..0x9562. 
        public const ushort SHADING_RATE_IMAGE_NV = 0x9563;
        public const ushort SHADING_RATE_NO_INVOCATIONS_NV = 0x9564;
        public const ushort SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0x9565;
        public const ushort SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 0x9566;
        public const ushort SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 0x9567;
        public const ushort SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 0x9568;
        public const ushort SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 0x9569;
        public const ushort SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 0x956A;
        public const ushort SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 0x956B;
        public const ushort SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 0x956C;
        public const ushort SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 0x956D;
        public const ushort SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 0x956E;
        public const ushort SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 0x956F;
        // Unused 0x9570..0x9578. 
        public const ushort MESH_VERTICES_OUT_NV = 0x9579;
        public const ushort MESH_PRIMITIVES_OUT_NV = 0x957A;
        public const ushort MESH_OUTPUT_TYPE_NV = 0x957B;
        public const ushort MESH_SUBROUTINE_NV = 0x957C;
        public const ushort TASK_SUBROUTINE_NV = 0x957D;
        public const ushort MESH_SUBROUTINE_UNIFORM_NV = 0x957E;
        public const ushort TASK_SUBROUTINE_UNIFORM_NV = 0x957F;
        public const ushort TEXTURE_TILING_EXT = 0x9580; // TextureParameterName
        public const ushort DEDICATED_MEMORY_OBJECT_EXT = 0x9581; // MemoryObjectParameterName
        public const ushort NUM_TILING_TYPES_EXT = 0x9582;
        public const ushort TILING_TYPES_EXT = 0x9583;
        public const ushort OPTIMAL_TILING_EXT = 0x9584;
        public const ushort LINEAR_TILING_EXT = 0x9585;
        public const ushort HANDLE_TYPE_OPAQUE_FD_EXT = 0x9586; // ExternalHandleType
        public const ushort HANDLE_TYPE_OPAQUE_WIN32_EXT = 0x9587; // ExternalHandleType
        public const ushort HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT = 0x9588; // ExternalHandleType
        public const ushort HANDLE_TYPE_D3D12_TILEPOOL_EXT = 0x9589; // ExternalHandleType
        public const ushort HANDLE_TYPE_D3D12_RESOURCE_EXT = 0x958A; // ExternalHandleType
        public const ushort HANDLE_TYPE_D3D11_IMAGE_EXT = 0x958B; // ExternalHandleType
        public const ushort HANDLE_TYPE_D3D11_IMAGE_KMT_EXT = 0x958C; // ExternalHandleType
        public const ushort LAYOUT_GENERAL_EXT = 0x958D; // TextureLayout
        public const ushort LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E; // TextureLayout
        public const ushort LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F; // TextureLayout
        public const ushort LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590; // TextureLayout
        public const ushort LAYOUT_SHADER_READ_ONLY_EXT = 0x9591; // TextureLayout
        public const ushort LAYOUT_TRANSFER_SRC_EXT = 0x9592; // TextureLayout
        public const ushort LAYOUT_TRANSFER_DST_EXT = 0x9593; // TextureLayout
        public const ushort HANDLE_TYPE_D3D12_FENCE_EXT = 0x9594; // ExternalHandleType
        public const ushort D3D12_FENCE_VALUE_EXT = 0x9595; // SemaphoreParameterName
        public const ushort NUM_DEVICE_UUIDS_EXT = 0x9596; // GetPName
        public const ushort DEVICE_UUID_EXT = 0x9597; // GetPName
        public const ushort DRIVER_UUID_EXT = 0x9598; // GetPName
        public const ushort DEVICE_LUID_EXT = 0x9599; // GetPName
        public const ushort DEVICE_NODE_MASK_EXT = 0x959A; // GetPName
        public const ushort PROTECTED_MEMORY_OBJECT_EXT = 0x959B; // MemoryObjectParameterName
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV = 0x959C;
        public const ushort UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV = 0x959D;
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV = 0x959E;
        public const ushort ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV = 0x959F;
        public const ushort REFERENCED_BY_MESH_SHADER_NV = 0x95A0;
        public const ushort REFERENCED_BY_TASK_SHADER_NV = 0x95A1;
        public const ushort MAX_MESH_WORK_GROUP_INVOCATIONS_NV = 0x95A2;
        public const ushort MAX_TASK_WORK_GROUP_INVOCATIONS_NV = 0x95A3;
        public const ushort ATTACHED_MEMORY_OBJECT_NV = 0x95A4;
        public const ushort ATTACHED_MEMORY_OFFSET_NV = 0x95A5;
        public const ushort MEMORY_ATTACHABLE_ALIGNMENT_NV = 0x95A6;
        public const ushort MEMORY_ATTACHABLE_SIZE_NV = 0x95A7;
        public const ushort MEMORY_ATTACHABLE_NV = 0x95A8;
        public const ushort DETACHED_MEMORY_INCARNATION_NV = 0x95A9;
        public const ushort DETACHED_TEXTURES_NV = 0x95AA;
        public const ushort DETACHED_BUFFERS_NV = 0x95AB;
        public const ushort MAX_DETACHED_TEXTURES_NV = 0x95AC;
        public const ushort MAX_DETACHED_BUFFERS_NV = 0x95AD;
        public const ushort SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV = 0x95AE;
        public const ushort SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV = 0x95AF;
        public const ushort SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV = 0x95B0;
        // Unused 0x9581..0x962F. 
        
        // . Email from Cass Everitt
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630; // FramebufferAttachmentParameterName
        public const ushort MAX_VIEWS_OVR = 0x9631;
        public const ushort FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632; // FramebufferAttachmentParameterName
        public const ushort FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;
        // Unused 0x9634..0x963F. 
        
        // . Khronos error #14294
        public const ushort GS_SHADER_BINARY_MTK = 0x9640;
        public const ushort GS_PROGRAM_BINARY_MTK = 0x9641;
        // Unused 0x9642..0x964F. 
        
        // . Khronos error #14977
        public const ushort MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
        public const ushort MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
        public const ushort FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;
        // Unused 0x9653..0x968F. 
        
        // . Khronos error #15423
        // Unused 0x9690..0x969F. 
        
        // . contact Jeff Leger
        // Unused 0x96A0..0x96A1. 
        public const ushort FRAMEBUFFER_FETCH_NONCOHERENT_QCOM = 0x96A2; // FramebufferFetchNoncoherent
        public const ushort VALIDATE_SHADER_BINARY_QCOM = 0x96A3;
        public const ushort SHADING_RATE_QCOM = 0x96A4; // GetPName
        public const ushort SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM = 0x96A5; // EnableCap
        public const ushort SHADING_RATE_1X1_PIXELS_QCOM = 0x96A6; // ShadingRateQCOM
        public const ushort SHADING_RATE_1X2_PIXELS_QCOM = 0x96A7; // ShadingRateQCOM
        public const ushort SHADING_RATE_2X1_PIXELS_QCOM = 0x96A8; // ShadingRateQCOM
        public const ushort SHADING_RATE_2X2_PIXELS_QCOM = 0x96A9; // ShadingRateQCOM
        public const ushort SHADING_RATE_1X4_PIXELS_QCOM = 0x96AA; // ShadingRateQCOM
        public const ushort SHADING_RATE_4X1_PIXELS_QCOM = 0x96AB; // ShadingRateQCOM
        public const ushort SHADING_RATE_4X2_PIXELS_QCOM = 0x96AC; // ShadingRateQCOM
        public const ushort SHADING_RATE_2X4_PIXELS_QCOM = 0x96AD; // ShadingRateQCOM
        public const ushort SHADING_RATE_4X4_PIXELS_QCOM = 0x96AE; // ShadingRateQCOM
        // Unused 0x96AF..0x96AF. 
        
        // . github pull request
        // Unused 0x96B0..0x96BF. 
        
        // . Contact Jan-Harald Fredriksen
        // Unused 0x96C0..0x96CF. 
        
        // . RESERVED FOR FUTURE ALLOCATIONS BY KHRONOS
        // Unused 0x96D0..99999. RESERVED
        
        // . GLU enums
        
        // . Conformance test enums
        
        // . Unused, unlikely to ever be used
        
        // . IBM is out of the graphics hardware business. Most of this range will remain unused.
        public const int RASTER_POSITION_UNCLIPPED_IBM = 0x19262;
        public const int CULL_VERTEX_IBM = 103050;
        public const int ALL_STATIC_DATA_IBM = 103060;
        public const int STATIC_VERTEX_ARRAY_IBM = 103061;
        public const int VERTEX_ARRAY_LIST_IBM = 103070;
        public const int NORMAL_ARRAY_LIST_IBM = 103071;
        public const int COLOR_ARRAY_LIST_IBM = 103072;
        public const int INDEX_ARRAY_LIST_IBM = 103073;
        public const int TEXTURE_COORD_ARRAY_LIST_IBM = 103074;
        public const int EDGE_FLAG_ARRAY_LIST_IBM = 103075;
        public const int FOG_COORDINATE_ARRAY_LIST_IBM = 103076;
        public const int SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;
        public const int VERTEX_ARRAY_LIST_STRIDE_IBM = 103080;
        public const int NORMAL_ARRAY_LIST_STRIDE_IBM = 103081;
        public const int COLOR_ARRAY_LIST_STRIDE_IBM = 103082;
        public const int INDEX_ARRAY_LIST_STRIDE_IBM = 103083;
        public const int TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;
        public const int EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;
        public const int FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;
        public const int SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;
        
        // . NEC may be out of the graphics hardware business?
        
        // . Compaq was acquired by HP
        
        // . Kubota Pacific is out of business
        
        // . Portland Graphics was acquired by Template Graphics, which is out of business
        public const int PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8; // HintTarget
        public const int CONSERVE_MEMORY_HINT_PGI = 0x1A1FD; // HintTarget
        public const int RECLAIM_MEMORY_HINT_PGI = 0x1A1FE; // HintTarget
        public const int NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;
        public const int NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203; // HintTarget
        public const int NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204; // HintTarget
        public const int ALWAYS_FAST_HINT_PGI = 0x1A20C; // HintTarget
        public const int ALWAYS_SOFT_HINT_PGI = 0x1A20D; // HintTarget
        public const int ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E; // HintTarget
        public const int ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F; // HintTarget
        public const int ALLOW_DRAW_FRG_HINT_PGI = 0x1A210; // HintTarget
        public const int ALLOW_DRAW_MEM_HINT_PGI = 0x1A211; // HintTarget
        public const int STRICT_DEPTHFUNC_HINT_PGI = 0x1A216; // HintTarget
        public const int STRICT_LIGHTING_HINT_PGI = 0x1A217; // HintTarget
        public const int STRICT_SCISSOR_HINT_PGI = 0x1A218; // HintTarget
        public const int FULL_STIPPLE_HINT_PGI = 0x1A219; // HintTarget
        public const int CLIP_NEAR_HINT_PGI = 0x1A220; // HintTarget
        public const int CLIP_FAR_HINT_PGI = 0x1A221; // HintTarget
        public const int WIDE_LINE_HINT_PGI = 0x1A222; // HintTarget
        public const int BACK_NORMALS_HINT_PGI = 0x1A223; // HintTarget
        public const int VERTEX_DATA_HINT_PGI = 0x1A22A; // HintTarget,HintTargetPGI
        public const int VERTEX_CONSISTENT_HINT_PGI = 0x1A22B; // HintTarget,HintTargetPGI
        public const int MATERIAL_SIDE_HINT_PGI = 0x1A22C; // HintTarget,HintTargetPGI
        public const int MAX_VERTEX_HINT_PGI = 0x1A22D; // HintTarget,HintTargetPGI
        
        // . Evans and Sutherland is out of the graphics hardware business
        

    }
}
