namespace Yagl.Graphics
{
    public static partial class Gl
    {
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

        public enum AttribMask : uint
        {
            CURRENT_BIT = 0x00000001,
            POINT_BIT = 0x00000002,
            LINE_BIT = 0x00000004,
            POLYGON_BIT = 0x00000008,
            POLYGON_STIPPLE_BIT = 0x00000010,
            PIXEL_MODE_BIT = 0x00000020,
            LIGHTING_BIT = 0x00000040,
            FOG_BIT = 0x00000080,
            DEPTH_BUFFER_BIT = 0x00000100,
            ACCUM_BUFFER_BIT = 0x00000200,
            STENCIL_BUFFER_BIT = 0x00000400,
            VIEWPORT_BIT = 0x00000800,
            TRANSFORM_BIT = 0x00001000,
            ENABLE_BIT = 0x00002000,
            COLOR_BUFFER_BIT = 0x00004000,
            HINT_BIT = 0x00008000,
            EVAL_BIT = 0x00010000,
            LIST_BIT = 0x00020000,
            TEXTURE_BIT = 0x00040000,
            SCISSOR_BIT = 0x00080000,
            MULTISAMPLE_BIT = 0x20000000,
            MULTISAMPLE_BIT_ARB = 0x20000000,
            MULTISAMPLE_BIT_EXT = 0x20000000,
            MULTISAMPLE_BIT_3DFX = 0x20000000,

            // Guaranteed to mark all attribute groups at once
            ALL_ATTRIB_BITS = 0xFFFFFFFF,
        }

        // GL_MAP_{COHERENT,PERSISTENT,READ,WRITE}_{BIT,BIT_EXT} also lie in this namespace
        public enum BufferStorageMask : uint
        {
            MAP_READ_BIT = 0x0001,
            MAP_READ_BIT_EXT = 0x0001,
            MAP_WRITE_BIT = 0x0002,
            MAP_WRITE_BIT_EXT = 0x0002,
            MAP_PERSISTENT_BIT = 0x0040,
            MAP_PERSISTENT_BIT_EXT = 0x0040,
            MAP_COHERENT_BIT = 0x0080,
            MAP_COHERENT_BIT_EXT = 0x0080,
            DYNAMIC_STORAGE_BIT = 0x0100,
            DYNAMIC_STORAGE_BIT_EXT = 0x0100,
            CLIENT_STORAGE_BIT = 0x0200,
            CLIENT_STORAGE_BIT_EXT = 0x0200,
            SPARSE_STORAGE_BIT_ARB = 0x0400,
            LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800,
            PER_GPU_STORAGE_BIT_NV = 0x0800,

            // Unused 0x1000..0x1000. Reserved for NVIDIA
            EXTERNAL_STORAGE_BIT_NVX = 0x2000,
        }

        // GL_{DEPTH,ACCUM,STENCIL,COLOR}_BUFFER_BIT also lie in this namespace
        public enum ClearBufferMask : uint
        {
            // Collides with AttribMask bit GL_HINT_BIT. OK since this token is for OpenGL ES 2, which doesn't have attribute groups.
            COVERAGE_BUFFER_BIT_NV = 0x00008000,
            DEPTH_BUFFER_BIT = 0x00000100,
            ACCUM_BUFFER_BIT = 0x00000200,
            STENCIL_BUFFER_BIT = 0x00000400,
            COLOR_BUFFER_BIT = 0x00004000,
        }

        public enum ClientAttribMask : uint
        {
            CLIENT_PIXEL_STORE_BIT = 0x00000001,
            CLIENT_VERTEX_ARRAY_BIT = 0x00000002,
            CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF,
        }

        // Should be shared with WGL/GLX, but aren't since the FORWARD_COMPATIBLE and DEBUG values are swapped vs. WGL/GLX.
        public enum ContextFlagMask : uint
        {
            CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001,
            CONTEXT_FLAG_DEBUG_BIT = 0x00000002,
            CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002,
            CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004,
            CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004,
            CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008,

            // Alias of GL_CONTEXT_FLAG_NO_ERROR_BIT
            CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008,
            CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010,
        }

        public enum ContextProfileMask : uint
        {
            CONTEXT_CORE_PROFILE_BIT = 0x00000001,
            CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002,
        }

        public enum MapBufferAccessMask : uint
        {
            MAP_READ_BIT = 0x0001,
            MAP_READ_BIT_EXT = 0x0001,
            MAP_WRITE_BIT = 0x0002,
            MAP_WRITE_BIT_EXT = 0x0002,
            MAP_INVALIDATE_RANGE_BIT = 0x0004,
            MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004,
            MAP_INVALIDATE_BUFFER_BIT = 0x0008,
            MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008,
            MAP_FLUSH_EXPLICIT_BIT = 0x0010,
            MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010,
            MAP_UNSYNCHRONIZED_BIT = 0x0020,
            MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020,
            MAP_PERSISTENT_BIT = 0x0040,
            MAP_PERSISTENT_BIT_EXT = 0x0040,
            MAP_COHERENT_BIT = 0x0080,
            MAP_COHERENT_BIT_EXT = 0x0080,
        }

        public enum MemoryBarrierMask : uint
        {
            VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001,
            VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001,
            ELEMENT_ARRAY_BARRIER_BIT = 0x00000002,
            ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002,
            UNIFORM_BARRIER_BIT = 0x00000004,
            UNIFORM_BARRIER_BIT_EXT = 0x00000004,
            TEXTURE_FETCH_BARRIER_BIT = 0x00000008,
            TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008,
            SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010,
            SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020,
            SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020,
            COMMAND_BARRIER_BIT = 0x00000040,
            COMMAND_BARRIER_BIT_EXT = 0x00000040,
            PIXEL_BUFFER_BARRIER_BIT = 0x00000080,
            PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080,
            TEXTURE_UPDATE_BARRIER_BIT = 0x00000100,
            TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100,
            BUFFER_UPDATE_BARRIER_BIT = 0x00000200,
            BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200,
            FRAMEBUFFER_BARRIER_BIT = 0x00000400,
            FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400,
            TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800,
            TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800,
            ATOMIC_COUNTER_BARRIER_BIT = 0x00001000,
            ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000,
            SHADER_STORAGE_BARRIER_BIT = 0x00002000,
            CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000,
            CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000,
            QUERY_BUFFER_BARRIER_BIT = 0x00008000,
            ALL_BARRIER_BITS = 0xFFFFFFFF,
            ALL_BARRIER_BITS_EXT = 0xFFFFFFFF,
        }

        public enum OcclusionQueryEventMaskAMD : uint
        {
            QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001,
            QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002,
            QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004,
            QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008,
            QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF,
        }

        public enum SyncObjectMask : uint
        {
            SYNC_FLUSH_COMMANDS_BIT = 0x00000001,
            SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001,
        }

        public enum UseProgramStageMask : uint
        {
            VERTEX_SHADER_BIT = 0x00000001,
            VERTEX_SHADER_BIT_EXT = 0x00000001,
            FRAGMENT_SHADER_BIT = 0x00000002,
            FRAGMENT_SHADER_BIT_EXT = 0x00000002,
            GEOMETRY_SHADER_BIT = 0x00000004,
            GEOMETRY_SHADER_BIT_EXT = 0x00000004,
            GEOMETRY_SHADER_BIT_OES = 0x00000004,
            TESS_CONTROL_SHADER_BIT = 0x00000008,
            TESS_CONTROL_SHADER_BIT_EXT = 0x00000008,
            TESS_CONTROL_SHADER_BIT_OES = 0x00000008,
            TESS_EVALUATION_SHADER_BIT = 0x00000010,
            TESS_EVALUATION_SHADER_BIT_EXT = 0x00000010,
            TESS_EVALUATION_SHADER_BIT_OES = 0x00000010,
            COMPUTE_SHADER_BIT = 0x00000020,
            MESH_SHADER_BIT_NV = 0x00000040,
            TASK_SHADER_BIT_NV = 0x00000080,
            ALL_SHADER_BITS = 0xFFFFFFFF,
            ALL_SHADER_BITS_EXT = 0xFFFFFFFF,
        }

        public enum SubgroupSupportedFeatures : uint
        {
            SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001,
            SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002,
            SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004,
            SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008,
            SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010,
            SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020,
            SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040,
            SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080,
            SUBGROUP_FEATURE_PARTITIONED_BIT_NV = 0x00000100,
        }

        public enum TextureStorageMaskAMD : uint
        {
            TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001,
        }

        public enum FragmentShaderDestMaskATI : uint
        {
            RED_BIT_ATI = 0x00000001,
            GREEN_BIT_ATI = 0x00000002,
            BLUE_BIT_ATI = 0x00000004,
        }

        public enum FragmentShaderDestModMaskATI : uint
        {
            GL_2X_BIT_ATI = 0x00000001,
            GL_4X_BIT_ATI = 0x00000002,
            GL_8X_BIT_ATI = 0x00000004,
            HALF_BIT_ATI = 0x00000008,
            QUARTER_BIT_ATI = 0x00000010,
            EIGHTH_BIT_ATI = 0x00000020,
            SATURATE_BIT_ATI = 0x00000040,
        }

        public enum FragmentShaderColorModMaskATI : uint
        {
            COMP_BIT_ATI = 0x00000002,
            NEGATE_BIT_ATI = 0x00000004,
            BIAS_BIT_ATI = 0x00000008,
        }

        public enum TraceMaskMESA : uint
        {
            TRACE_OPERATIONS_BIT_MESA = 0x0001,
            TRACE_PRIMITIVES_BIT_MESA = 0x0002,
            TRACE_ARRAYS_BIT_MESA = 0x0004,
            TRACE_TEXTURES_BIT_MESA = 0x0008,
            TRACE_PIXELS_BIT_MESA = 0x0010,
            TRACE_ERRORS_BIT_MESA = 0x0020,
            TRACE_ALL_BITS_MESA = 0xFFFF,
        }

        public enum PathRenderingMaskNV : uint
        {
            BOLD_BIT_NV = 0x01, // PathFontStyle
            ITALIC_BIT_NV = 0x02, // PathFontStyle
            GLYPH_WIDTH_BIT_NV = 0x01, // PathMetricMask
            GLYPH_HEIGHT_BIT_NV = 0x02, // PathMetricMask
            GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04, // PathMetricMask
            GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08, // PathMetricMask
            GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10, // PathMetricMask
            GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20, // PathMetricMask
            GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40, // PathMetricMask
            GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80, // PathMetricMask
            GLYPH_HAS_KERNING_BIT_NV = 0x100, // PathMetricMask
            FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000, // PathMetricMask
            FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000, // PathMetricMask
            FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000, // PathMetricMask
            FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000, // PathMetricMask
            FONT_UNITS_PER_EM_BIT_NV = 0x00100000, // PathMetricMask
            FONT_ASCENDER_BIT_NV = 0x00200000, // PathMetricMask
            FONT_DESCENDER_BIT_NV = 0x00400000, // PathMetricMask
            FONT_HEIGHT_BIT_NV = 0x00800000, // PathMetricMask
            FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000, // PathMetricMask
            FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000, // PathMetricMask
            FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000, // PathMetricMask
            FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000, // PathMetricMask
            FONT_HAS_KERNING_BIT_NV = 0x10000000, // PathMetricMask
            FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000, // PathMetricMask
        }

        public enum PerformanceQueryCapsMaskINTEL : uint
        {
            PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000,
            PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001,
        }

        public enum VertexHintsMaskPGI : uint
        {
            VERTEX23_BIT_PGI = 0x00000004,
            VERTEX4_BIT_PGI = 0x00000008,
            COLOR3_BIT_PGI = 0x00010000,
            COLOR4_BIT_PGI = 0x00020000,
            EDGEFLAG_BIT_PGI = 0x00040000,
            INDEX_BIT_PGI = 0x00080000,
            MAT_AMBIENT_BIT_PGI = 0x00100000,
            MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000,
            MAT_DIFFUSE_BIT_PGI = 0x00400000,
            MAT_EMISSION_BIT_PGI = 0x00800000,
            MAT_COLOR_INDEXES_BIT_PGI = 0x01000000,
            MAT_SHININESS_BIT_PGI = 0x02000000,
            MAT_SPECULAR_BIT_PGI = 0x04000000,
            NORMAL_BIT_PGI = 0x08000000,
            TEXCOORD1_BIT_PGI = 0x10000000,
            TEXCOORD2_BIT_PGI = 0x20000000,
            TEXCOORD3_BIT_PGI = 0x40000000,
            TEXCOORD4_BIT_PGI = 0x80000000,
        }

        public enum BufferBitQCOM : uint
        {
            COLOR_BUFFER_BIT0_QCOM = 0x00000001,
            COLOR_BUFFER_BIT1_QCOM = 0x00000002,
            COLOR_BUFFER_BIT2_QCOM = 0x00000004,
            COLOR_BUFFER_BIT3_QCOM = 0x00000008,
            COLOR_BUFFER_BIT4_QCOM = 0x00000010,
            COLOR_BUFFER_BIT5_QCOM = 0x00000020,
            COLOR_BUFFER_BIT6_QCOM = 0x00000040,
            COLOR_BUFFER_BIT7_QCOM = 0x00000080,
            DEPTH_BUFFER_BIT0_QCOM = 0x00000100,
            DEPTH_BUFFER_BIT1_QCOM = 0x00000200,
            DEPTH_BUFFER_BIT2_QCOM = 0x00000400,
            DEPTH_BUFFER_BIT3_QCOM = 0x00000800,
            DEPTH_BUFFER_BIT4_QCOM = 0x00001000,
            DEPTH_BUFFER_BIT5_QCOM = 0x00002000,
            DEPTH_BUFFER_BIT6_QCOM = 0x00004000,
            DEPTH_BUFFER_BIT7_QCOM = 0x00008000,
            STENCIL_BUFFER_BIT0_QCOM = 0x00010000,
            STENCIL_BUFFER_BIT1_QCOM = 0x00020000,
            STENCIL_BUFFER_BIT2_QCOM = 0x00040000,
            STENCIL_BUFFER_BIT3_QCOM = 0x00080000,
            STENCIL_BUFFER_BIT4_QCOM = 0x00100000,
            STENCIL_BUFFER_BIT5_QCOM = 0x00200000,
            STENCIL_BUFFER_BIT6_QCOM = 0x00400000,
            STENCIL_BUFFER_BIT7_QCOM = 0x00800000,
            MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000,
            MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000,
            MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000,
            MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000,
            MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000,
            MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000,
            MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000,
            MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000,
        }

        public enum FoveationConfigBitQCOM : uint
        {
            FOVEATION_ENABLE_BIT_QCOM = 0x00000001,
            FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002,
            FOVEATION_SUBSAMPLED_LAYOUT_METHOD_BIT_QCOM = 0x00000004,
        }

        public enum FfdMaskSGIX : uint
        {
            TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001,
            GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002,
        }

        // For NV_command_list.
        public enum CommandOpcodesNV : uint
        {
            TERMINATE_SEQUENCE_COMMAND_NV = 0x0000,
            NOP_COMMAND_NV = 0x0001,
            DRAW_ELEMENTS_COMMAND_NV = 0x0002,
            DRAW_ARRAYS_COMMAND_NV = 0x0003,
            DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004,
            DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005,
            DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006,
            DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007,
            ELEMENT_ADDRESS_COMMAND_NV = 0x0008,
            ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009,
            UNIFORM_ADDRESS_COMMAND_NV = 0x000A,
            BLEND_COLOR_COMMAND_NV = 0x000B,
            STENCIL_REF_COMMAND_NV = 0x000C,
            LINE_WIDTH_COMMAND_NV = 0x000D,
            POLYGON_OFFSET_COMMAND_NV = 0x000E,
            ALPHA_REF_COMMAND_NV = 0x000F,
            VIEWPORT_COMMAND_NV = 0x0010,
            SCISSOR_COMMAND_NV = 0x0011,
            FRONT_FACE_COMMAND_NV = 0x0012,
        }

        // Texture memory layouts for INTEL_map_texture
        public enum MapTextureFormatINTEL : uint
        {
            LAYOUT_DEFAULT_INTEL = 0,
            LAYOUT_LINEAR_INTEL = 1,
            LAYOUT_LINEAR_CPU_CACHED_INTEL = 2,
        }

        public enum PathRenderingTokenNV : byte
        {
            CLOSE_PATH_NV = 0x00, // PathCoordType
            MOVE_TO_NV = 0x02, // PathCoordType
            RELATIVE_MOVE_TO_NV = 0x03, // PathCoordType
            LINE_TO_NV = 0x04, // PathCoordType
            RELATIVE_LINE_TO_NV = 0x05, // PathCoordType
            HORIZONTAL_LINE_TO_NV = 0x06, // PathCoordType
            RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07, // PathCoordType
            VERTICAL_LINE_TO_NV = 0x08, // PathCoordType
            RELATIVE_VERTICAL_LINE_TO_NV = 0x09, // PathCoordType
            QUADRATIC_CURVE_TO_NV = 0x0A, // PathCoordType
            RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B, // PathCoordType
            CUBIC_CURVE_TO_NV = 0x0C, // PathCoordType
            RELATIVE_CUBIC_CURVE_TO_NV = 0x0D, // PathCoordType
            SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E, // PathCoordType
            RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F, // PathCoordType
            SMOOTH_CUBIC_CURVE_TO_NV = 0x10, // PathCoordType
            RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11, // PathCoordType
            SMALL_CCW_ARC_TO_NV = 0x12, // PathCoordType
            RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13, // PathCoordType
            SMALL_CW_ARC_TO_NV = 0x14, // PathCoordType
            RELATIVE_SMALL_CW_ARC_TO_NV = 0x15, // PathCoordType
            LARGE_CCW_ARC_TO_NV = 0x16, // PathCoordType
            RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17, // PathCoordType
            LARGE_CW_ARC_TO_NV = 0x18, // PathCoordType
            RELATIVE_LARGE_CW_ARC_TO_NV = 0x19, // PathCoordType
            CONIC_CURVE_TO_NV = 0x1A, // PathCoordType
            RELATIVE_CONIC_CURVE_TO_NV = 0x1B, // PathCoordType

            // Unused 0x1C..0xBF. Unused for PathRenderingTokenNV
            SHARED_EDGE_NV = 0xC0, // 

            // Unused 0xC1..0xE7. Unused for PathRenderingTokenNV
            ROUNDED_RECT_NV = 0xE8, // PathCoordType
            RELATIVE_ROUNDED_RECT_NV = 0xE9, // PathCoordType
            ROUNDED_RECT2_NV = 0xEA, // PathCoordType
            RELATIVE_ROUNDED_RECT2_NV = 0xEB, // PathCoordType
            ROUNDED_RECT4_NV = 0xEC, // PathCoordType
            RELATIVE_ROUNDED_RECT4_NV = 0xED, // PathCoordType
            ROUNDED_RECT8_NV = 0xEE, // PathCoordType
            RELATIVE_ROUNDED_RECT8_NV = 0xEF, // PathCoordType
            RESTART_PATH_NV = 0xF0, // PathCoordType
            DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2, // PathCoordType
            DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4, // PathCoordType
            RECT_NV = 0xF6, // PathCoordType
            RELATIVE_RECT_NV = 0xF7, // PathCoordType
            CIRCULAR_CCW_ARC_TO_NV = 0xF8, // PathCoordType
            CIRCULAR_CW_ARC_TO_NV = 0xFA, // PathCoordType
            CIRCULAR_TANGENT_ARC_TO_NV = 0xFC, // PathCoordType
            ARC_TO_NV = 0xFE, // PathCoordType
            RELATIVE_ARC_TO_NV = 0xFF, // PathCoordType
        }

        // For NV_transform_feedback. No clue why small negative values are used
        public enum TransformFeedbackTokenNV : int
        {
            NEXT_BUFFER_NV = -2,
            SKIP_COMPONENTS4_NV = -3,
            SKIP_COMPONENTS3_NV = -4,
            SKIP_COMPONENTS2_NV = -5,
            SKIP_COMPONENTS1_NV = -6,
        }

        public enum TriangleListSUN : uint
        {
            RESTART_SUN = 0x0001,
            REPLACE_MIDDLE_SUN = 0x0002,
            REPLACE_OLDEST_SUN = 0x0003,
        }

        // . Mostly OpenGL 1.0/1.1 enum assignments. Unused ranges should generally remain unused.

        public enum PrimitiveType : uint
        {

            POINTS = 0x0000,
            LINES = 0x0001,
            LINE_LOOP = 0x0002,
            LINE_STRIP = 0x0003,
            TRIANGLES = 0x0004,
            TRIANGLE_STRIP = 0x0005,
            TRIANGLE_FAN = 0x0006,
            QUADS = 0x0007,
            QUADS_EXT = 0x0007,
            QUADS_OES = 0x0007;
            QUAD_STRIP = 0x0008,
            POLYGON = 0x0009,
            LINES_ADJACENCY = 0x000A,
            LINES_ADJACENCY_ARB = 0x000A,
            LINES_ADJACENCY_EXT = 0x000A,
            LINES_ADJACENCY_OES = 0x000A;
            LINE_STRIP_ADJACENCY = 0x000B,
            LINE_STRIP_ADJACENCY_ARB = 0x000B,
            LINE_STRIP_ADJACENCY_EXT = 0x000B,
            LINE_STRIP_ADJACENCY_OES = 0x000B;
            TRIANGLES_ADJACENCY = 0x000C,
            TRIANGLES_ADJACENCY_ARB = 0x000C,
            TRIANGLES_ADJACENCY_EXT = 0x000C,
            TRIANGLES_ADJACENCY_OES = 0x000C;
            TRIANGLE_STRIP_ADJACENCY = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_OES = 0x000D;
            PATCHES = 0x000E,
            PATCHES_EXT = 0x000E,
            PATCHES_OES = 0x000E;
            // Unused 0x000F..0x00FF. Unused for PrimitiveType
        }

        public enum AccumOp : uint
        {
            ACCUM = 0x0100,
            LOAD = 0x0101,
            RETURN = 0x0102,
            MULT = 0x0103,
            ADD = 0x0104; // TextureEnvMode,LightEnvModeSGIX
            // Unused 0x0105..0x01FF. Unused for AccumOp
        }
    }
}