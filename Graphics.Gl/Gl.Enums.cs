/*
namespace Yagl.Graphics
{
    public static partial class Gl
    {
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
            QUADS_OES = 0x0007,
            QUAD_STRIP = 0x0008,
            POLYGON = 0x0009,
            LINES_ADJACENCY = 0x000A,
            LINES_ADJACENCY_ARB = 0x000A,
            LINES_ADJACENCY_EXT = 0x000A,
            LINES_ADJACENCY_OES = 0x000A,
            LINE_STRIP_ADJACENCY = 0x000B,
            LINE_STRIP_ADJACENCY_ARB = 0x000B,
            LINE_STRIP_ADJACENCY_EXT = 0x000B,
            LINE_STRIP_ADJACENCY_OES = 0x000B,
            TRIANGLES_ADJACENCY = 0x000C,
            TRIANGLES_ADJACENCY_ARB = 0x000C,
            TRIANGLES_ADJACENCY_EXT = 0x000C,
            TRIANGLES_ADJACENCY_OES = 0x000C,
            TRIANGLE_STRIP_ADJACENCY = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D,
            TRIANGLE_STRIP_ADJACENCY_OES = 0x000D,
            PATCHES = 0x000E,
            PATCHES_EXT = 0x000E,
            PATCHES_OES = 0x000E,
            // Unused 0x000F..0x00FF. Unused for PrimitiveType
        }

        public enum AccumOp : uint
        {
            ACCUM = 0x0100,
            LOAD = 0x0101,
            RETURN = 0x0102,
            MULT = 0x0103,
            ADD = 0x0104, // TextureEnvMode,LightEnvModeSGIX
            // Unused 0x0105..0x01FF. Unused for AccumOp
        }

        // TODO: May be merge the following 4 enums into one.

        // StencilFunction,IndexFunctionEXT,AlphaFunction,DepthFunction
        public enum AlphaFunction : uint
        {
            NEVER = 0x0200,
            LESS = 0x0201,
            EQUAL = 0x0202,
            LEQUAL = 0x0203,
            GREATER = 0x0204,
            NOTEQUAL = 0x0205,
            GEQUAL = 0x0206,
            ALWAYS = 0x0207,
            // Unused 0x0208..0x02FF. Unused for AlphaFunction
        }

        public enum DepthFunction : uint
        {
            NEVER = 0x0200,
            LESS = 0x0201,
            EQUAL = 0x0202,
            LEQUAL = 0x0203,
            GREATER = 0x0204,
            NOTEQUAL = 0x0205,
            GEQUAL = 0x0206,
            ALWAYS = 0x0207,
            // Unused 0x0208..0x02FF. Unused for AlphaFunction
        }

        public enum IndexFunctionEXT : uint
        {
            NEVER = 0x0200,
            LESS = 0x0201,
            EQUAL = 0x0202,
            LEQUAL = 0x0203,
            GREATER = 0x0204,
            NOTEQUAL = 0x0205,
            GEQUAL = 0x0206,
            ALWAYS = 0x0207,
            // Unused 0x0208..0x02FF. Unused for AlphaFunction
        }

        public enum StencilFunction : uint
        {
            NEVER = 0x0200,
            LESS = 0x0201,
            EQUAL = 0x0202,
            LEQUAL = 0x0203,
            GREATER = 0x0204,
            NOTEQUAL = 0x0205,
            GEQUAL = 0x0206,
            ALWAYS = 0x0207,
            // Unused 0x0208..0x02FF. Unused for AlphaFunction
        }

        public enum BlendingFactor : uint
        {
            SRC_COLOR = 0x0300,
            ONE_MINUS_SRC_COLOR = 0x0301,
            SRC_ALPHA = 0x0302,
            ONE_MINUS_SRC_ALPHA = 0x0303,
            DST_ALPHA = 0x0304,
            ONE_MINUS_DST_ALPHA = 0x0305,
            DST_COLOR = 0x0306,
            ONE_MINUS_DST_COLOR = 0x0307,
            SRC_ALPHA_SATURATE = 0x0308,
            SRC_ALPHA_SATURATE_EXT = 0x0308,
            // Unused 0x0309..0x03FF. Unused for BlendingFactor
            CONSTANT_COLOR = 0x8001;
            CONSTANT_COLOR_EXT = 0x8001;
            ONE_MINUS_CONSTANT_COLOR = 0x8002;
            ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;
            CONSTANT_ALPHA = 0x8003;
            CONSTANT_ALPHA_EXT = 0x8003;
            ONE_MINUS_CONSTANT_ALPHA = 0x8004;
            ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;
        }

        public enum ColorBuffer : uint
        {
            FRONT_LEFT = 0x0400, // ColorBuffer,DrawBufferMode,ReadBufferMode
            FRONT_RIGHT = 0x0401, // ColorBuffer,DrawBufferMode,ReadBufferMode
            BACK_LEFT = 0x0402, // ColorBuffer,DrawBufferMode,ReadBufferMode
            BACK_RIGHT = 0x0403, // ColorBuffer,DrawBufferMode,ReadBufferMode
            FRONT = 0x0404, // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,ReadBufferMode,StencilFaceDirection,MaterialFace
            BACK = 0x0405, // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,ReadBufferMode,StencilFaceDirection,MaterialFace
            LEFT = 0x0406, // ColorBuffer,DrawBufferMode,ReadBufferMode
            RIGHT = 0x0407, // ColorBuffer,DrawBufferMode,ReadBufferMode
            FRONT_AND_BACK = 0x0408, // ColorBuffer,ColorMaterialFace,CullFaceMode,DrawBufferMode,StencilFaceDirection,MaterialFace
        }

        public enum DrawBufferMode : uint
        {
            AUX0 = 0x0409,
            AUX1 = 0x040A,
            AUX2 = 0x040B,
            AUX3 = 0x040C,
            // Unused 0x040D..0x04FF. Unused for DrawBufferMode
        }

        public enum ReadBufferMode : uint
        {
            AUX0 = 0x0409,
            AUX1 = 0x040A,
            AUX2 = 0x040B,
            AUX3 = 0x040C,
            // Unused 0x040D..0x04FF. Unused for DrawBufferMode
        }

        public enum ErrorCode : uint
        {
            INVALID_ENUM = 0x0500,
            INVALID_VALUE = 0x0501,
            INVALID_OPERATION = 0x0502,
            STACK_OVERFLOW = 0x0503,
            STACK_OVERFLOW_KHR = 0x0503,
            STACK_UNDERFLOW = 0x0504,
            STACK_UNDERFLOW_KHR = 0x0504,
            OUT_OF_MEMORY = 0x0505,
            INVALID_FRAMEBUFFER_OPERATION = 0x0506,
            INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506,
            INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506,
            CONTEXT_LOST = 0x0507,
            CONTEXT_LOST_KHR = 0x0507,
            // Unused 0x0508..0x05FF. Unused for ErrorCode
            TABLE_TOO_LARGE_EXT = 0x8031; // ErrorCode
            TABLE_TOO_LARGE = 0x8031; // ErrorCode
            TEXTURE_TOO_LARGE_EXT = 0x8065; // ErrorCode
        }

        public enum FeedbackType : uint
        {
            GL_2D = 0x0600,
            GL_3D = 0x0601,
            GL_3D_COLOR = 0x0602,
            GL_3D_COLOR_TEXTURE = 0x0603,
            GL_4D_COLOR_TEXTURE = 0x0604,
            // Unused 0x0605..0x06FF. Unused for FeedbackType
        }

        public enum FeedBackToken : uint
        {
            PASS_THROUGH_TOKEN = 0x0700,
            POINT_TOKEN = 0x0701,
            LINE_TOKEN = 0x0702,
            POLYGON_TOKEN = 0x0703,
            BITMAP_TOKEN = 0x0704,
            DRAW_PIXEL_TOKEN = 0x0705,
            COPY_PIXEL_TOKEN = 0x0706,
            LINE_RESET_TOKEN = 0x0707,
            // Unused 0x0708..0x07FF. Unused for FeedbackToken
        }

        public enum FogMode : uint
        {
            EXP = 0x0800,
            EXP2 = 0x0801,
            // Unused 0x0802..0x08FF. Unused for FogMode
        }

        public enum FrontFaceDirection : uint
        {
            CW = 0x0900,
            CCW = 0x0901,
            // Unused 0x0902..0x09FF. Unused for FrontFaceDirection
        }

        public enum GetMapQuery : uint
        {
            COEFF = 0x0A00,
            ORDER = 0x0A01,
            DOMAIN = 0x0A02,
            // Unused 0x0A03..0x0AFF. Unused for GetMapQuery
        }

        public enum MapQuery : uint
        {
            COEFF = 0x0A00,
            ORDER = 0x0A01,
            DOMAIN = 0x0A02,
            // Unused 0x0A03..0x0AFF. Unused for GetMapQuery
        }

        public enum GetPName : uint
        {
            CURRENT_COLOR = 0x0B00, // GetPName
            CURRENT_INDEX = 0x0B01, // GetPName
            CURRENT_NORMAL = 0x0B02, // GetPName
            CURRENT_TEXTURE_COORDS = 0x0B03, // GetPName,VertexShaderTextureUnitParameter
            CURRENT_RASTER_COLOR = 0x0B04, // GetPName
            CURRENT_RASTER_INDEX = 0x0B05, // GetPName
            CURRENT_RASTER_TEXTURE_COORDS = 0x0B06, // GetPName
            CURRENT_RASTER_POSITION = 0x0B07, // GetPName
            CURRENT_RASTER_POSITION_VALID = 0x0B08, // GetPName
            CURRENT_RASTER_DISTANCE = 0x0B09, // GetPName
            POINT_SMOOTH = 0x0B10, // GetPName,EnableCap
            POINT_SIZE = 0x0B11, // GetPName
            POINT_SIZE_RANGE = 0x0B12, // GetPName
            // Alias of GL_POINT_SIZE_RANGE
            SMOOTH_POINT_SIZE_RANGE = 0x0B12, // GetPName
            POINT_SIZE_GRANULARITY = 0x0B13, // GetPName
            // Alias of GL_POINT_SIZE_GRANULARITY
            SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13, // GetPName
            LINE_SMOOTH = 0x0B20, // GetPName,EnableCap
            LINE_WIDTH = 0x0B21, // GetPName
            LINE_WIDTH_RANGE = 0x0B22, // GetPName
            // Alias of GL_LINE_WIDTH_RANGE
            SMOOTH_LINE_WIDTH_RANGE = 0x0B22, // GetPName
            LINE_WIDTH_GRANULARITY = 0x0B23, // GetPName
            // Alias of GL_LINE_WIDTH_GRANULARITY
            SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23, // GetPName
            LINE_STIPPLE = 0x0B24, // GetPName,EnableCap
            LINE_STIPPLE_PATTERN = 0x0B25, // GetPName
            LINE_STIPPLE_REPEAT = 0x0B26, // GetPName
            LIST_MODE = 0x0B30, // GetPName
            MAX_LIST_NESTING = 0x0B31, // GetPName
            LIST_BASE = 0x0B32, // GetPName
            LIST_INDEX = 0x0B33, // GetPName
            POLYGON_MODE = 0x0B40, // GetPName
            POLYGON_MODE_NV = 0x0B40,
            POLYGON_SMOOTH = 0x0B41, // GetPName,EnableCap
            POLYGON_STIPPLE = 0x0B42, // GetPName,EnableCap
            EDGE_FLAG = 0x0B43, // GetPName
            CULL_FACE = 0x0B44, // GetPName,EnableCap
            CULL_FACE_MODE = 0x0B45, // GetPName
            FRONT_FACE = 0x0B46, // GetPName
            LIGHTING = 0x0B50, // GetPName,EnableCap
            LIGHT_MODEL_LOCAL_VIEWER = 0x0B51, // LightModelParameter,GetPName
            LIGHT_MODEL_TWO_SIDE = 0x0B52, // LightModelParameter,GetPName
            LIGHT_MODEL_AMBIENT = 0x0B53, // LightModelParameter,GetPName
            SHADE_MODEL = 0x0B54, // GetPName
            COLOR_MATERIAL_FACE = 0x0B55, // GetPName
            COLOR_MATERIAL_PARAMETER = 0x0B56, // GetPName
            COLOR_MATERIAL = 0x0B57, // GetPName,EnableCap
            FOG = 0x0B60, // GetPName,EnableCap
            FOG_INDEX = 0x0B61, // FogPName,FogParameter,GetPName
            FOG_DENSITY = 0x0B62, // FogPName,FogParameter,GetPName
            FOG_START = 0x0B63, // FogPName,FogParameter,GetPName
            FOG_END = 0x0B64, // FogPName,FogParameter,GetPName
            FOG_MODE = 0x0B65, // FogPName,FogParameter,GetPName
            FOG_COLOR = 0x0B66, // GetPName,FogParameter
            DEPTH_RANGE = 0x0B70, // GetPName
            DEPTH_TEST = 0x0B71, // GetPName,EnableCap
            DEPTH_WRITEMASK = 0x0B72, // GetPName
            DEPTH_CLEAR_VALUE = 0x0B73, // GetPName
            DEPTH_FUNC = 0x0B74, // GetPName
            ACCUM_CLEAR_VALUE = 0x0B80, // GetPName
            STENCIL_TEST = 0x0B90, // GetPName,EnableCap
            STENCIL_CLEAR_VALUE = 0x0B91, // GetPName
            STENCIL_FUNC = 0x0B92, // GetPName
            STENCIL_VALUE_MASK = 0x0B93, // GetPName
            STENCIL_FAIL = 0x0B94, // GetPName
            STENCIL_PASS_DEPTH_FAIL = 0x0B95, // GetPName
            STENCIL_PASS_DEPTH_PASS = 0x0B96, // GetPName
            STENCIL_REF = 0x0B97, // GetPName
            STENCIL_WRITEMASK = 0x0B98, // GetPName
            MATRIX_MODE = 0x0BA0, // GetPName
            NORMALIZE = 0x0BA1, // GetPName,EnableCap
            VIEWPORT = 0x0BA2, // GetPName
            MODELVIEW_STACK_DEPTH = 0x0BA3, // GetPName
            MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3, // GetPName
            PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3,
            PROJECTION_STACK_DEPTH = 0x0BA4, // GetPName
            PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4,
            TEXTURE_STACK_DEPTH = 0x0BA5, // GetPName
            MODELVIEW_MATRIX = 0x0BA6, // GetPName
            MODELVIEW0_MATRIX_EXT = 0x0BA6, // GetPName
            PATH_MODELVIEW_MATRIX_NV = 0x0BA6,
            PROJECTION_MATRIX = 0x0BA7, // GetPName
            PATH_PROJECTION_MATRIX_NV = 0x0BA7,
            TEXTURE_MATRIX = 0x0BA8, // GetPName,VertexShaderTextureUnitParameter
            ATTRIB_STACK_DEPTH = 0x0BB0, // GetPName
            CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1, // GetPName
            ALPHA_TEST = 0x0BC0, // GetPName,EnableCap
            ALPHA_TEST_QCOM = 0x0BC0, // GetPName
            ALPHA_TEST_FUNC = 0x0BC1, // GetPName
            ALPHA_TEST_FUNC_QCOM = 0x0BC1, // GetPName
            ALPHA_TEST_REF = 0x0BC2, // GetPName
            ALPHA_TEST_REF_QCOM = 0x0BC2, // GetPName
            DITHER = 0x0BD0, // GetPName,EnableCap
            BLEND_DST = 0x0BE0, // GetPName
            BLEND_SRC = 0x0BE1, // GetPName
            BLEND = 0x0BE2, // TextureEnvMode,EnableCap,GetPName
            LOGIC_OP_MODE = 0x0BF0, // GetPName
            INDEX_LOGIC_OP = 0x0BF1, // GetPName,EnableCap
            LOGIC_OP = 0x0BF1, // GetPName
            COLOR_LOGIC_OP = 0x0BF2, // GetPName,EnableCap
            AUX_BUFFERS = 0x0C00, // GetPName
            DRAW_BUFFER = 0x0C01, // GetPName
            DRAW_BUFFER_EXT = 0x0C01, // GetPName
            READ_BUFFER = 0x0C02, // GetPName
            READ_BUFFER_EXT = 0x0C02, // GetPName
            READ_BUFFER_NV = 0x0C02, // GetPName
            SCISSOR_BOX = 0x0C10, // GetPName
            SCISSOR_TEST = 0x0C11, // GetPName,EnableCap
            INDEX_CLEAR_VALUE = 0x0C20, // GetPName
            INDEX_WRITEMASK = 0x0C21, // GetPName
            COLOR_CLEAR_VALUE = 0x0C22, // GetPName
            COLOR_WRITEMASK = 0x0C23, // GetPName
            INDEX_MODE = 0x0C30, // GetPName
            RGBA_MODE = 0x0C31, // GetPName
            DOUBLEBUFFER = 0x0C32, // GetFramebufferParameter,GetPName
            STEREO = 0x0C33, // GetFramebufferParameter,GetPName
            RENDER_MODE = 0x0C40, // GetPName
            PERSPECTIVE_CORRECTION_HINT = 0x0C50, // HintTarget,GetPName
            POINT_SMOOTH_HINT = 0x0C51, // HintTarget,GetPName
            LINE_SMOOTH_HINT = 0x0C52, // HintTarget,GetPName
            POLYGON_SMOOTH_HINT = 0x0C53, // HintTarget,GetPName
            FOG_HINT = 0x0C54, // HintTarget,GetPName
            TEXTURE_GEN_S = 0x0C60, // GetPName,EnableCap
            TEXTURE_GEN_T = 0x0C61, // GetPName,EnableCap
            TEXTURE_GEN_R = 0x0C62, // GetPName,EnableCap
            TEXTURE_GEN_Q = 0x0C63, // GetPName,EnableCap
            PIXEL_MAP_I_TO_I = 0x0C70, // PixelMap,GetPixelMap
            PIXEL_MAP_S_TO_S = 0x0C71, // PixelMap,GetPixelMap
            PIXEL_MAP_I_TO_R = 0x0C72, // PixelMap,GetPixelMap
            PIXEL_MAP_I_TO_G = 0x0C73, // PixelMap,GetPixelMap
            PIXEL_MAP_I_TO_B = 0x0C74, // PixelMap,GetPixelMap
            PIXEL_MAP_I_TO_A = 0x0C75, // PixelMap,GetPixelMap
            PIXEL_MAP_R_TO_R = 0x0C76, // PixelMap,GetPixelMap
            PIXEL_MAP_G_TO_G = 0x0C77, // PixelMap,GetPixelMap
            PIXEL_MAP_B_TO_B = 0x0C78, // PixelMap,GetPixelMap
            PIXEL_MAP_A_TO_A = 0x0C79, // PixelMap,GetPixelMap
            PIXEL_MAP_I_TO_I_SIZE = 0x0CB0, // GetPName
            PIXEL_MAP_S_TO_S_SIZE = 0x0CB1, // GetPName
            PIXEL_MAP_I_TO_R_SIZE = 0x0CB2, // GetPName
            PIXEL_MAP_I_TO_G_SIZE = 0x0CB3, // GetPName
            PIXEL_MAP_I_TO_B_SIZE = 0x0CB4, // GetPName
            PIXEL_MAP_I_TO_A_SIZE = 0x0CB5, // GetPName
            PIXEL_MAP_R_TO_R_SIZE = 0x0CB6, // GetPName
            PIXEL_MAP_G_TO_G_SIZE = 0x0CB7, // GetPName
            PIXEL_MAP_B_TO_B_SIZE = 0x0CB8, // GetPName
            PIXEL_MAP_A_TO_A_SIZE = 0x0CB9, // GetPName
            UNPACK_SWAP_BYTES = 0x0CF0, // PixelStoreParameter,GetPName
            UNPACK_LSB_FIRST = 0x0CF1, // PixelStoreParameter,GetPName
            UNPACK_ROW_LENGTH = 0x0CF2, // PixelStoreParameter,GetPName
            UNPACK_ROW_LENGTH_EXT = 0x0CF2, // PixelStoreParameter
            UNPACK_SKIP_ROWS = 0x0CF3, // PixelStoreParameter,GetPName
            UNPACK_SKIP_ROWS_EXT = 0x0CF3, // PixelStoreParameter
            UNPACK_SKIP_PIXELS = 0x0CF4, // PixelStoreParameter,GetPName
            UNPACK_SKIP_PIXELS_EXT = 0x0CF4, // PixelStoreParameter
            UNPACK_ALIGNMENT = 0x0CF5, // PixelStoreParameter,GetPName
            PACK_SWAP_BYTES = 0x0D00, // PixelStoreParameter,GetPName
            PACK_LSB_FIRST = 0x0D01, // PixelStoreParameter,GetPName
            PACK_ROW_LENGTH = 0x0D02, // PixelStoreParameter,GetPName
            PACK_SKIP_ROWS = 0x0D03, // PixelStoreParameter,GetPName
            PACK_SKIP_PIXELS = 0x0D04, // PixelStoreParameter,GetPName
            PACK_ALIGNMENT = 0x0D05, // PixelStoreParameter,GetPName
            MAP_COLOR = 0x0D10, // PixelTransferParameter,GetPName
            MAP_STENCIL = 0x0D11, // PixelTransferParameter,GetPName
            INDEX_SHIFT = 0x0D12, // PixelTransferParameter,GetPName
            INDEX_OFFSET = 0x0D13, // PixelTransferParameter,IndexMaterialParameterEXT,GetPName
            RED_SCALE = 0x0D14, // PixelTransferParameter,GetPName
            RED_BIAS = 0x0D15, // PixelTransferParameter,GetPName
            ZOOM_X = 0x0D16, // GetPName
            ZOOM_Y = 0x0D17, // GetPName
            GREEN_SCALE = 0x0D18, // PixelTransferParameter,GetPName
            GREEN_BIAS = 0x0D19, // PixelTransferParameter,GetPName
            BLUE_SCALE = 0x0D1A, // PixelTransferParameter,GetPName
            BLUE_BIAS = 0x0D1B, // PixelTransferParameter,GetPName
            ALPHA_SCALE = 0x0D1C, // PixelTransferParameter,GetPName
            ALPHA_BIAS = 0x0D1D, // PixelTransferParameter,GetPName
            DEPTH_SCALE = 0x0D1E, // PixelTransferParameter,GetPName
            DEPTH_BIAS = 0x0D1F, // PixelTransferParameter,GetPName
            MAX_EVAL_ORDER = 0x0D30, // GetPName
            MAX_LIGHTS = 0x0D31, // GetPName
            MAX_CLIP_PLANES = 0x0D32, // GetPName
            MAX_CLIP_PLANES_IMG = 0x0D32,
            // Alias of GL_MAX_CLIP_PLANES
            MAX_CLIP_DISTANCES = 0x0D32, // GetPName
            // Alias of GL_MAX_CLIP_PLANES
            MAX_CLIP_DISTANCES_EXT = 0x0D32,
            MAX_CLIP_DISTANCES_APPLE = 0x0D32,
            MAX_TEXTURE_SIZE = 0x0D33, // GetPName
            MAX_PIXEL_MAP_TABLE = 0x0D34, // GetPName
            MAX_ATTRIB_STACK_DEPTH = 0x0D35, // GetPName
            MAX_MODELVIEW_STACK_DEPTH = 0x0D36, // GetPName
            PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36,
            MAX_NAME_STACK_DEPTH = 0x0D37, // GetPName
            MAX_PROJECTION_STACK_DEPTH = 0x0D38, // GetPName
            PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38,
            MAX_TEXTURE_STACK_DEPTH = 0x0D39, // GetPName
            MAX_VIEWPORT_DIMS = 0x0D3A, // GetPName
            MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B, // GetPName
            SUBPIXEL_BITS = 0x0D50, // GetPName
            INDEX_BITS = 0x0D51, // GetPName
            RED_BITS = 0x0D52, // GetPName
            GREEN_BITS = 0x0D53, // GetPName
            BLUE_BITS = 0x0D54, // GetPName
            ALPHA_BITS = 0x0D55, // GetPName
            DEPTH_BITS = 0x0D56, // GetPName
            STENCIL_BITS = 0x0D57, // GetPName
            ACCUM_RED_BITS = 0x0D58, // GetPName
            ACCUM_GREEN_BITS = 0x0D59, // GetPName
            ACCUM_BLUE_BITS = 0x0D5A, // GetPName
            ACCUM_ALPHA_BITS = 0x0D5B, // GetPName
            NAME_STACK_DEPTH = 0x0D70, // GetPName
            AUTO_NORMAL = 0x0D80, // GetPName,EnableCap
            MAP1_COLOR_4 = 0x0D90, // MapTarget,EnableCap,GetPName
            MAP1_INDEX = 0x0D91, // MapTarget,EnableCap,GetPName
            MAP1_NORMAL = 0x0D92, // MapTarget,EnableCap,GetPName
            MAP1_TEXTURE_COORD_1 = 0x0D93, // MapTarget,EnableCap,GetPName
            MAP1_TEXTURE_COORD_2 = 0x0D94, // MapTarget,EnableCap,GetPName
            MAP1_TEXTURE_COORD_3 = 0x0D95, // MapTarget,EnableCap,GetPName
            MAP1_TEXTURE_COORD_4 = 0x0D96, // MapTarget,EnableCap,GetPName
            MAP1_VERTEX_3 = 0x0D97, // MapTarget,EnableCap,GetPName
            MAP1_VERTEX_4 = 0x0D98, // MapTarget,EnableCap,GetPName
            MAP2_COLOR_4 = 0x0DB0, // MapTarget,EnableCap,GetPName
            MAP2_INDEX = 0x0DB1, // MapTarget,EnableCap,GetPName
            MAP2_NORMAL = 0x0DB2, // MapTarget,EnableCap,GetPName
            MAP2_TEXTURE_COORD_1 = 0x0DB3, // MapTarget,EnableCap,GetPName
            MAP2_TEXTURE_COORD_2 = 0x0DB4, // MapTarget,EnableCap,GetPName
            MAP2_TEXTURE_COORD_3 = 0x0DB5, // MapTarget,EnableCap,GetPName
            MAP2_TEXTURE_COORD_4 = 0x0DB6, // MapTarget,EnableCap,GetPName
            MAP2_VERTEX_3 = 0x0DB7, // MapTarget,EnableCap,GetPName
            MAP2_VERTEX_4 = 0x0DB8, // MapTarget,EnableCap,GetPName
            MAP1_GRID_DOMAIN = 0x0DD0, // GetPName
            MAP1_GRID_SEGMENTS = 0x0DD1, // GetPName
            MAP2_GRID_DOMAIN = 0x0DD2, // GetPName
            MAP2_GRID_SEGMENTS = 0x0DD3, // GetPName
            TEXTURE_1D = 0x0DE0, // CopyImageSubDataTarget,EnableCap,GetPName,TextureTarget
            TEXTURE_2D = 0x0DE1, // CopyImageSubDataTarget,EnableCap,GetPName,TextureTarget
            FEEDBACK_BUFFER_POINTER = 0x0DF0, // GetPointervPName
            FEEDBACK_BUFFER_SIZE = 0x0DF1, // GetPName
            FEEDBACK_BUFFER_TYPE = 0x0DF2, // GetPName
            SELECTION_BUFFER_POINTER = 0x0DF3, // GetPointervPName
            SELECTION_BUFFER_SIZE = 0x0DF4, // GetPName
            // Unused 0x0DF5..0xFFFF. Unused for GetPName
            BLEND_COLOR = 0x8005; // GetPName
            BLEND_COLOR_EXT = 0x8005; // GetPName
            public const ushort RESCALE_NORMAL = 0x803A;
            public const ushort RESCALE_NORMAL_EXT = 0x803A; // GetPName,EnableCap
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
            public const ushort INTERLACE_SGIX = 0x8094; // GetPName,EnableCap
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
            public const ushort COLOR_MATRIX = 0x80B1;
            public const ushort COLOR_MATRIX_SGI = 0x80B1; // GetPName
            public const ushort COLOR_MATRIX_STACK_DEPTH = 0x80B2;
            public const ushort COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2; // GetPName
            public const ushort MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
            public const ushort MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3; // GetPName
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
        }
        
        public enum GetTextureParameter : uint
        {
            TEXTURE_WIDTH = 0x1000,
            TEXTURE_HEIGHT = 0x1001,
            TEXTURE_INTERNAL_FORMAT = 0x1003,
            TEXTURE_COMPONENTS = 0x1003,
            TEXTURE_BORDER_COLOR = 0x1004, // SamplerParameterF
            TEXTURE_BORDER_COLOR_EXT = 0x1004,
            TEXTURE_BORDER_COLOR_NV = 0x1004,
            TEXTURE_BORDER_COLOR_OES = 0x1004,
            TEXTURE_BORDER = 0x1005,
            TEXTURE_TARGET = 0x1006,
            // Unused 0x1007..0x10FF. Unused for GetTextureParameter
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
        }

        public enum TextureParameterName : uint
        {
            TEXTURE_WIDTH = 0x1000,
            TEXTURE_HEIGHT = 0x1001,
            TEXTURE_INTERNAL_FORMAT = 0x1003,
            TEXTURE_COMPONENTS = 0x1003,
            TEXTURE_BORDER_COLOR = 0x1004, // SamplerParameterF
            TEXTURE_BORDER_COLOR_EXT = 0x1004,
            TEXTURE_BORDER_COLOR_NV = 0x1004,
            TEXTURE_BORDER_COLOR_OES = 0x1004,
            TEXTURE_BORDER = 0x1005,
            TEXTURE_TARGET = 0x1006,
            // Unused 0x1007..0x10FF. Unused for GetTextureParameter
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
            public const ushort TEXTURE_DEPTH = 0x8071;
            public const ushort TEXTURE_DEPTH_EXT = 0x8071; // TextureParameterName,GetTextureParameter
            public const ushort TEXTURE_WRAP_R = 0x8072; // SamplerParameterI,TextureParameterName
            public const ushort TEXTURE_WRAP_R_EXT = 0x8072; // TextureParameterName,GetTextureParameter
            public const ushort TEXTURE_WRAP_R_OES = 0x8072; // TextureParameterName
            public const ushort DETAIL_TEXTURE_LEVEL_SGIS = 0x809A; // TextureParameterName,GetTextureParameter
            public const ushort DETAIL_TEXTURE_MODE_SGIS = 0x809B; // TextureParameterName,GetTextureParameter
            public const ushort DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C; // TextureParameterName,GetTextureParameter

        }
        
        public enum HintMode : uint
        {
            DONT_CARE = 0x1100, // DebugSeverity,DebugSource,DebugType
            FASTEST = 0x1101,
            NICEST = 0x1102,
            // Unused 0x1103..0x11FF. Unused for HintMode
        }
        
        public enum MaterialParameter : uint
        {
            AMBIENT = 0x1200, // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
            DIFFUSE = 0x1201, // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
            SPECULAR = 0x1202, // MaterialParameter,FragmentLightParameterSGIX,ColorMaterialParameter
            EMISSION = 0x1600, // MaterialParameter,ColorMaterialParameter
            SHININESS = 0x1601, // MaterialParameter
            AMBIENT_AND_DIFFUSE = 0x1602, // MaterialParameter,ColorMaterialParameter
            COLOR_INDEXES = 0x1603, // MaterialParameter
            // Unused 0x1604..0x16FF. Unused for MaterialParameter
        }
        
        public enum LightParameter : uint
        {
            POSITION = 0x1203, // LightParameter,FragmentLightParameterSGIX
            SPOT_DIRECTION = 0x1204, // LightParameter,FragmentLightParameterSGIX
            SPOT_EXPONENT = 0x1205, // LightParameter,FragmentLightParameterSGIX
            SPOT_CUTOFF = 0x1206, // LightParameter,FragmentLightParameterSGIX
            CONSTANT_ATTENUATION = 0x1207, // LightParameter,FragmentLightParameterSGIX
            LINEAR_ATTENUATION = 0x1208, // LightParameter,FragmentLightParameterSGIX
            QUADRATIC_ATTENUATION = 0x1209, // LightParameter,FragmentLightParameterSGIX
            // Unused 0x1210..0x12FF. Unused for LightParameter
        }

        public enum ListMode : uint
        {
            COMPILE = 0x1300,
            COMPILE_AND_EXECUTE = 0x1301,
            // Unused 0x1302..0x13FF. Unused for ListMode
        }

        public enum VertexAttribType : uint
        {
            BYTE = 0x1400, // VertexAttribIType,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,ColorPointerType,ListNameType,NormalPointerType,PixelType,VertexAttribType,VertexAttribPointerType
            UNSIGNED_BYTE = 0x1401, // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelType,VertexAttribType,VertexAttribPointerType
            SHORT = 0x1402, // VertexAttribIType,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,VertexAttribPointerType
            UNSIGNED_SHORT = 0x1403, // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelFormat,PixelType,VertexAttribType,VertexAttribPointerType
            INT = 0x1404, // VertexAttribIType,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
            UNSIGNED_INT = 0x1405, // VertexAttribIType,ScalarType,ReplacementCodeTypeSUN,ElementPointerTypeATI,MatrixIndexPointerTypeARB,WeightPointerTypeARB,ColorPointerType,DrawElementsType,ListNameType,PixelFormat,PixelType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
            FLOAT = 0x1406, // GlslTypeToken,MapTypeNV,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,VertexWeightPointerTypeEXT,TangentPointerTypeEXT,BinormalPointerTypeEXT,FogCoordinatePointerType,FogPointerTypeEXT,FogPointerTypeIBM,IndexPointerType,ListNameType,NormalPointerType,PixelType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType
            GL_2_BYTES = 0x1407, // ListNameType
            GL_2_BYTES_NV = 0x1407,
            GL_3_BYTES = 0x1408, // ListNameType
            GL_3_BYTES_NV = 0x1408,
            GL_4_BYTES = 0x1409, // ListNameType
            GL_4_BYTES_NV = 0x1409,
            DOUBLE = 0x140A, // VertexAttribLType,MapTypeNV,SecondaryColorPointerTypeIBM,WeightPointerTypeARB,TangentPointerTypeEXT,BinormalPointerTypeEXT,FogCoordinatePointerType,FogPointerTypeEXT,FogPointerTypeIBM,IndexPointerType,NormalPointerType,TexCoordPointerType,VertexPointerType,VertexAttribType,AttributeType,UniformType,VertexAttribPointerType,GlslTypeToken
            DOUBLE_EXT = 0x140A, // BinormalPointerTypeEXT,TangentPointerTypeEXT
            HALF_FLOAT = 0x140B, // VertexAttribPointerType,VertexAttribType
            HALF_FLOAT_ARB = 0x140B,
            HALF_FLOAT_NV = 0x140B,
            HALF_APPLE = 0x140B,
            FIXED = 0x140C, // VertexAttribPointerType,VertexAttribType
            FIXED_OES = 0x140C,
            // Unused 0x140D. Leave gap to preserve even/odd int/uint token values
        }
        
        public enum VertexAttribPointerType : uint
        {
            INT64_ARB = 0x140E, // VertexAttribPointerType,AttributeType
            INT64_NV = 0x140E, // VertexAttribPointerType,AttributeType
            UNSIGNED_INT64_ARB = 0x140F, // VertexAttribPointerType,AttributeType
            UNSIGNED_INT64_NV = 0x140F, // VertexAttribPointerType,AttributeType
            // Unused 0x1410..0x14FF. Unused for DataType
        }
        
        public enum LogicOp : uint
        {
            CLEAR = 0x1500,
            AND = 0x1501,
            AND_REVERSE = 0x1502,
            COPY = 0x1503,
            AND_INVERTED = 0x1504,
            NOOP = 0x1505,
            XOR = 0x1506,
            XOR_NV = 0x1506,
            OR = 0x1507,
            NOR = 0x1508,
            EQUIV = 0x1509,
            INVERT = 0x150A, // PathFillMode,StencilOp
            OR_REVERSE = 0x150B,
            COPY_INVERTED = 0x150C,
            OR_INVERTED = 0x150D,
            NAND = 0x150E,
            SET = 0x150F,
            // Unused 0x1510..0x15FF. Unused for LogicOp
        }

        public enum MatrixMode : uint
        {
            MODELVIEW = 0x1700, // MatrixMode
            MODELVIEW0_ARB = 0x1700,
            MODELVIEW0_EXT = 0x1700, // MatrixMode
            PATH_MODELVIEW_NV = 0x1700,
            PROJECTION = 0x1701, // MatrixMode
            PATH_PROJECTION_NV = 0x1701,
            TEXTURE = 0x1702, // ObjectIdentifier,MatrixMode
            // Unused 0x1703..0x17FF. Unused for MatrixMode
        }
        
        public enum PixelCopyType : uint
        {
            COLOR = 0x1800, // Buffer,PixelCopyType,InvalidateFramebufferAttachment
            COLOR_EXT = 0x1800, // PixelCopyType
            DEPTH = 0x1801, // Buffer,PixelCopyType,InvalidateFramebufferAttachment
            DEPTH_EXT = 0x1801, // PixelCopyType
            STENCIL = 0x1802, // Buffer,PixelCopyType,InvalidateFramebufferAttachment
            STENCIL_EXT = 0x1802, // PixelCopyType
            // Unused 0x1803..0x18FF. Unused for PixelCopyType
        }
    
        public enum PixelFormat : uint
        {
            COLOR_INDEX = 0x1900, // PixelFormat
            STENCIL_INDEX = 0x1901, // InternalFormat,PixelFormat
            STENCIL_INDEX_OES = 0x1901, // InternalFormat
            DEPTH_COMPONENT = 0x1902, // InternalFormat,PixelFormat
            RED = 0x1903, // TextureSwizzle,PixelFormat,InternalFormat
            RED_EXT = 0x1903, // InternalFormat,PixelFormat
            RED_NV = 0x1903,
            GREEN = 0x1904, // TextureSwizzle,PixelFormat
            GREEN_NV = 0x1904,
            BLUE = 0x1905, // TextureSwizzle,CombinerComponentUsageNV,PixelFormat
            BLUE_NV = 0x1905,
            ALPHA = 0x1906, // TextureSwizzle,CombinerPortionNV,PathColorFormat,CombinerComponentUsageNV,PixelFormat
            RGB = 0x1907, // PixelTexGenMode,CombinerPortionNV,PathColorFormat,CombinerComponentUsageNV,PixelFormat,InternalFormat
            RGBA = 0x1908, // PixelTexGenMode,PathColorFormat,PixelFormat,InternalFormat
            LUMINANCE = 0x1909, // PixelTexGenMode,PathColorFormat,PixelFormat
            LUMINANCE_ALPHA = 0x190A, // PixelTexGenMode,PathColorFormat,PixelFormat
            // Unused 0x1910..0x19FF. Unused for PixelFormat
            ABGR_EXT = 0x8000; // PixelFormat
            CMYK_EXT = 0x800C;
            CMYKA_EXT = 0x800D;
            
        }
        
        public enum PixelType : uint
        {
            BITMAP = 0x1A00, // PixelType
            // Unused 0x1A01..0x1AFF. Unused for PixelType
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

        }
    
        public enum PolygonMode : uint
        {
            POINT = 0x1B00, // PolygonMode,MeshMode1,MeshMode2
            POINT_NV = 0x1B00,
            LINE = 0x1B01, // PolygonMode,MeshMode1,MeshMode2
            LINE_NV = 0x1B01,
            FILL = 0x1B02, // PolygonMode,MeshMode2
            FILL_NV = 0x1B02, // EvalMapsModeNV
            // Unused 0x1B03..0x1BFF. Unused for PolygonMode
        }

        public enum RenderingMode : uint
        {
            RENDER = 0x1C00,
            FEEDBACK = 0x1C01,
            SELECT = 0x1C02,
            // Unused 0x1C03..0x1CFF. Unused for RenderingMode
        }

        public enum ShadingModel : uint
        {
            FLAT = 0x1D00, // ShadingModel
            SMOOTH = 0x1D01, // ShadingModel
            // Unused 0x1D02..0x1DFF. Unused for ShadingModel
        }

        public enum StencilOp : uint
        {
            KEEP = 0x1E00,
            REPLACE = 0x1E01, // LightEnvModeSGIX
            INCR = 0x1E02,
            DECR = 0x1E03,
            // Unused 0x1E04..0x1EFF. Unused for StencilOp
        }

        public enum StringName : uint
        {
            VENDOR = 0x1F00, // StringName
            RENDERER = 0x1F01, // StringName
            VERSION = 0x1F02, // StringName
            EXTENSIONS = 0x1F03, // StringName
            // Unused 0x1F04..0x1FFF. Unused for StringName
        }

        public enum TextureCoordName : uint
        {
            S = 0x2000,
            T = 0x2001,
            R = 0x2002,
            Q = 0x2003,
            // Unused 0x2004..0x20FF. Unused for TextureCoordName
        }

        public enum TextureEnvMode : uint
        {
            MODULATE = 0x2100, // LightEnvModeSGIX
            DECAL = 0x2101,
            // Unused 0x2102..0x21FF. Unused for TextureEnvMode
            REPLACE_EXT = 0x8062; // TextureEnvMode
            public const ushort TEXTURE_ENV_BIAS_SGIX = 0x80BE; // TextureEnvMode
        }

        public enum TextureEnvParameter : uint
        {
            TEXTURE_ENV_MODE = 0x2200,
            TEXTURE_ENV_COLOR = 0x2201,
            // Unused 0x2202..0x22FF. Unused for TextureEnvParameter
        }

        public enum TextureEnvTarget : uint
        {
            TEXTURE_ENV = 0x2300,
            // Unused 0x2301..0x23FF. Unused for TextureEnvTarget
        }

        public enum TextureGenMode : uint
        {
            EYE_LINEAR = 0x2400, // PathGenMode
            EYE_LINEAR_NV = 0x2400,
            OBJECT_LINEAR = 0x2401, // PathGenMode
            OBJECT_LINEAR_NV = 0x2401,
            SPHERE_MAP = 0x2402,
            // Unused 0x2403..0x24FF. Unused for TextureGenMode
        }

        public enum TextureGenParameter : uint
        {
            TEXTURE_GEN_MODE = 0x2500,
            TEXTURE_GEN_MODE_OES = 0x2500,
            OBJECT_PLANE = 0x2501,
            EYE_PLANE = 0x2502,
            // Unused 0x2503..0x25FF. Unused for TextureGenParameter
        }

        public enum TextureMagFilter : uint
        {
            NEAREST = 0x2600, // BlitFramebufferFilter,TextureMinFilter
            LINEAR = 0x2601, // BlitFramebufferFilter,FogMode,TextureMinFilter
            // Unused 0x2602..0x26FF. Unused for TextureMagFilter
            public const ushort LINEAR_DETAIL_SGIS = 0x8097; // TextureMagFilter
            public const ushort LINEAR_DETAIL_ALPHA_SGIS = 0x8098; // TextureMagFilter
            public const ushort LINEAR_DETAIL_COLOR_SGIS = 0x8099; // TextureMagFilter
            public const ushort LINEAR_SHARPEN_SGIS = 0x80AD; // TextureMagFilter
            public const ushort LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE; // TextureMagFilter
            public const ushort LINEAR_SHARPEN_COLOR_SGIS = 0x80AF; // TextureMagFilter
        }

        public enum TextureMinFilter : uint
        {
            NEAREST_MIPMAP_NEAREST = 0x2700,
            LINEAR_MIPMAP_NEAREST = 0x2701,
            NEAREST_MIPMAP_LINEAR = 0x2702,
            LINEAR_MIPMAP_LINEAR = 0x2703, // TextureWrapMode
            // Unused 0x2704..0x27FF. Unused for TextureMinFilter
        }

        public enum TextureParameterName : uint
        {
            TEXTURE_MAG_FILTER = 0x2800, // SamplerParameterI,GetTextureParameter
            TEXTURE_MIN_FILTER = 0x2801, // SamplerParameterI,GetTextureParameter
            TEXTURE_WRAP_S = 0x2802, // SamplerParameterI,GetTextureParameter
            TEXTURE_WRAP_T = 0x2803, // SamplerParameterI,GetTextureParameter
            // Unused 0x2804..0x28FF. Unused for TextureParameterName
            public const ushort SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0; // TextureParameterName,GetTextureParameter
            public const ushort SHADOW_AMBIENT_SGIX = 0x80BF; // TextureParameterName,GetTextureParameter
            public const ushort TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF; // ??? Should it be here?
        }

        public enum TextureWrapMode : uint
        {
            CLAMP = 0x2900,
            REPEAT = 0x2901,
            // Unused 0x2902..0x29FF. Unused for TextureWrapMode
        }

        public enum PolygonOffset : uint    // ???
        {
            POLYGON_OFFSET_UNITS = 0x2A00, // GetPName
            POLYGON_OFFSET_POINT = 0x2A01, // GetPName,EnableCap
            POLYGON_OFFSET_POINT_NV = 0x2A01,
            POLYGON_OFFSET_LINE = 0x2A02, // GetPName,EnableCap
            POLYGON_OFFSET_LINE_NV = 0x2A02,
            // Unused 0x2A03..0x2A09. Unused for PolygonOffset
            public const ushort POLYGON_OFFSET_EXT = 0x8037;
            public const ushort POLYGON_OFFSET_FILL = 0x8037; // GetPName,EnableCap
            public const ushort POLYGON_OFFSET_FACTOR = 0x8038; // GetPName
            public const ushort POLYGON_OFFSET_FACTOR_EXT = 0x8038;
            public const ushort POLYGON_OFFSET_BIAS_EXT = 0x8039; // GetPName
        }

        public enum InternalFormat : uint
        {
            R3_G3_B2 = 0x2A10,
            // Unused 0x2A11..0x2A1F. Unused for InternalFormat
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
        
        }
        
        public enum InterleavedArrayFormat : uint
        {
            V2F = 0x2A20,
            V3F = 0x2A21,
            C4UB_V2F = 0x2A22,
            C4UB_V3F = 0x2A23,
            C3F_V3F = 0x2A24,
            N3F_V3F = 0x2A25,
            C4F_N3F_V3F = 0x2A26,
            T2F_V3F = 0x2A27,
            T4F_V4F = 0x2A28,
            T2F_C4UB_V3F = 0x2A29,
            T2F_C3F_V3F = 0x2A2A,
            T2F_N3F_V3F = 0x2A2B,
            T2F_C4F_N3F_V3F = 0x2A2C,
            T4F_C4F_N3F_V4F = 0x2A2D,
            // Unused 0x2A2E..0x2FFF. Unused for InterleavedArrayFormat
        }
        
        public enum ClipPlaneName : uint
        {
            CLIP_PLANE0 = 0x3000, // GetPName,EnableCap
            CLIP_PLANE0_IMG = 0x3000,
            // Alias of GL_CLIP_PLANE0
            CLIP_DISTANCE0 = 0x3000, // EnableCap
            // Alias of GL_CLIP_PLANE0
            CLIP_DISTANCE0_EXT = 0x3000,
            CLIP_DISTANCE0_APPLE = 0x3000,
            CLIP_PLANE1 = 0x3001, // GetPName,EnableCap
            CLIP_PLANE1_IMG = 0x3001,
            // Alias of GL_CLIP_PLANE1
            CLIP_DISTANCE1 = 0x3001, // EnableCap
            // Alias of GL_CLIP_PLANE1
            CLIP_DISTANCE1_EXT = 0x3001,
            CLIP_DISTANCE1_APPLE = 0x3001,
            CLIP_PLANE2 = 0x3002, // GetPName,EnableCap
            CLIP_PLANE2_IMG = 0x3002,
            // Alias of GL_CLIP_PLANE2
            CLIP_DISTANCE2 = 0x3002, // EnableCap
            // Alias of GL_CLIP_PLANE2
            CLIP_DISTANCE2_EXT = 0x3002,
            CLIP_DISTANCE2_APPLE = 0x3002,
            CLIP_PLANE3 = 0x3003, // GetPName,EnableCap
            CLIP_PLANE3_IMG = 0x3003,
            // Alias of GL_CLIP_PLANE3
            CLIP_DISTANCE3 = 0x3003, // EnableCap
            // Alias of GL_CLIP_PLANE3
            CLIP_DISTANCE3_EXT = 0x3003,
            CLIP_DISTANCE3_APPLE = 0x3003,
            CLIP_PLANE4 = 0x3004, // GetPName,EnableCap
            CLIP_PLANE4_IMG = 0x3004,
            // Alias of GL_CLIP_PLANE4
            CLIP_DISTANCE4 = 0x3004, // EnableCap
            // Alias of GL_CLIP_PLANE4
            CLIP_DISTANCE4_EXT = 0x3004,
            CLIP_DISTANCE4_APPLE = 0x3004,
            CLIP_PLANE5 = 0x3005, // GetPName,EnableCap
            CLIP_PLANE5_IMG = 0x3005,
            // Alias of GL_CLIP_PLANE5
            CLIP_DISTANCE5 = 0x3005, // EnableCap
            // Alias of GL_CLIP_PLANE5
            CLIP_DISTANCE5_EXT = 0x3005,
            CLIP_DISTANCE5_APPLE = 0x3005,
            CLIP_DISTANCE6 = 0x3006, // EnableCap
            // Alias of GL_CLIP_DISTANCE6
            CLIP_DISTANCE6_EXT = 0x3006,
            CLIP_DISTANCE6_APPLE = 0x3006,
            CLIP_DISTANCE7 = 0x3007, // EnableCap
            // Alias of GL_CLIP_DISTANCE7
            CLIP_DISTANCE7_EXT = 0x3007,
            CLIP_DISTANCE7_APPLE = 0x3007,
            // Unused 0x3008..0x3FFF. Unused for ClipPlaneName
        }
        
        public enum LightName : uint
        {
            LIGHT0 = 0x4000, // EnableCap,GetPName
            LIGHT1 = 0x4001, // EnableCap,GetPName
            LIGHT2 = 0x4002, // EnableCap,GetPName
            LIGHT3 = 0x4003, // EnableCap,GetPName
            LIGHT4 = 0x4004, // EnableCap,GetPName
            LIGHT5 = 0x4005, // EnableCap,GetPName
            LIGHT6 = 0x4006, // EnableCap,GetPName
            LIGHT7 = 0x4007, // EnableCap,GetPName
            // Unused 0x4008..0x4FFF. Unused for LightName
        }
        
        // Unused 0x5000..0x5FFF. Unused. Do not use.
        // Unused 0x6000..0x6FFF. Experimental (internal/test only) range. DO NOT SHIP VALUES IN THIS RANGE.
        // Unused 0x7000..0x7FFF. Unused. Do not use.

        public enum BlendEquationModeEXT : uint
        {
            FUNC_ADD = 0x8006;
            FUNC_ADD_EXT = 0x8006;
            FUNC_ADD_OES = 0x8006;
            MIN = 0x8007;
            MIN_EXT = 0x8007;
            MAX = 0x8008;
            MAX_EXT = 0x8008;
            BLEND_EQUATION = 0x8009;
            BLEND_EQUATION_EXT = 0x8009; // GetPName
            BLEND_EQUATION_OES = 0x8009;
            BLEND_EQUATION_RGB = 0x8009; // GetPName
            BLEND_EQUATION_RGB_EXT = 0x8009;
            BLEND_EQUATION_RGB_OES = 0x8009;
            FUNC_SUBTRACT = 0x800A;
            FUNC_SUBTRACT_EXT = 0x800A;
            FUNC_SUBTRACT_OES = 0x800A;
            FUNC_REVERSE_SUBTRACT = 0x800B;
            FUNC_REVERSE_SUBTRACT_EXT = 0x800B;
            FUNC_REVERSE_SUBTRACT_OES = 0x800B;
        }

        public enum HintTarget : uint
        {
            PACK_CMYK_HINT_EXT = 0x800E; // GetPName
            UNPACK_CMYK_HINT_EXT = 0x800F; // GetPName
        }

        public enum ConvolutionTarget : uint
        {
            CONVOLUTION_1D = 0x8010; // ConvolutionTarget,ConvolutionTargetEXT
            CONVOLUTION_1D_EXT = 0x8010; // GetPName,ConvolutionTargetEXT,EnableCap
            CONVOLUTION_2D = 0x8011; // ConvolutionTarget,ConvolutionTargetEXT
            CONVOLUTION_2D_EXT = 0x8011; // GetPName,ConvolutionTargetEXT,EnableCap
        }

        public enum SeparableTargetEXT : uint
        {
            SEPARABLE_2D = 0x8012; // SeparableTargetEXT
            SEPARABLE_2D_EXT = 0x8012; // SeparableTargetEXT,EnableCap,GetPName
        }

        public enum GetConvolutionParameter : uint
        {
            public const ushort CONVOLUTION_BORDER_MODE = 0x8013; // GetConvolutionParameter,ConvolutionParameterEXT
            public const ushort CONVOLUTION_BORDER_MODE_EXT = 0x8013; // GetConvolutionParameter,ConvolutionParameterEXT
            public const ushort CONVOLUTION_FILTER_SCALE = 0x8014; // GetConvolutionParameter,ConvolutionParameterEXT
            public const ushort CONVOLUTION_FILTER_SCALE_EXT = 0x8014; // GetConvolutionParameter,ConvolutionParameterEXT
            public const ushort CONVOLUTION_FILTER_BIAS = 0x8015; // GetConvolutionParameter,ConvolutionParameterEXT
            public const ushort CONVOLUTION_FILTER_BIAS_EXT = 0x8015; // GetConvolutionParameter,ConvolutionParameterEXT
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
    }

        public enum ConvolutionBorderModeEXT : uint
        {
            public const ushort REDUCE = 0x8016; // ConvolutionBorderModeEXT
            public const ushort REDUCE_EXT = 0x8016; // ConvolutionBorderModeEXT
        }

        public enum PixelTransferParameter : uint
        {
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
}

        public enum HistogramTargetEXT : uint
        {
            public const ushort HISTOGRAM = 0x8024; // HistogramTargetEXT
            public const ushort HISTOGRAM_EXT = 0x8024; // HistogramTargetEXT,EnableCap,GetPName
            public const ushort PROXY_HISTOGRAM = 0x8025; // HistogramTargetEXT
            public const ushort PROXY_HISTOGRAM_EXT = 0x8025; // HistogramTargetEXT
        }

        public enum GetHistogramParameterPNameEXT : uint
        {
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
        }
        
        public enum MinmaxTargetEXT : uint
        {
            public const ushort MINMAX = 0x802E; // MinmaxTargetEXT
            public const ushort MINMAX_EXT = 0x802E; // MinmaxTargetEXT,EnableCap,GetPName
        }
            
        public enum GetMinmaxParameterPNameEXT : uint
        {
            public const ushort MINMAX_FORMAT = 0x802F; // GetMinmaxParameterPNameEXT
            public const ushort MINMAX_FORMAT_EXT = 0x802F; // GetMinmaxParameterPNameEXT
            public const ushort MINMAX_SINK = 0x8030; // GetMinmaxParameterPNameEXT
            public const ushort MINMAX_SINK_EXT = 0x8030; // GetMinmaxParameterPNameEXT
        }

        public enum TextureTarget : uint
        {
            public const ushort PROXY_TEXTURE_1D = 0x8063; // TextureTarget
            public const ushort PROXY_TEXTURE_1D_EXT = 0x8063; // TextureTarget
            public const ushort PROXY_TEXTURE_2D = 0x8064; // TextureTarget
            public const ushort PROXY_TEXTURE_2D_EXT = 0x8064; // TextureTarget
            public const ushort TEXTURE_3D = 0x806F; // CopyImageSubDataTarget,TextureTarget
            public const ushort TEXTURE_3D_EXT = 0x806F; // TextureTarget,EnableCap,GetPName
            public const ushort TEXTURE_3D_OES = 0x806F; // TextureTarget
            public const ushort PROXY_TEXTURE_3D = 0x8070; // TextureTarget
            public const ushort PROXY_TEXTURE_3D_EXT = 0x8070; // TextureTarget
            public const ushort DETAIL_TEXTURE_2D_SGIS = 0x8095; // TextureTarget
            public const ushort DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096; // GetPName
        }

        public enum PixelStoreParameter : uint
        {
            public const ushort PACK_SKIP_IMAGES = 0x806B; // PixelStoreParameter,GetPName
            public const ushort PACK_SKIP_IMAGES_EXT = 0x806B; // PixelStoreParameter,GetPName
            public const ushort PACK_IMAGE_HEIGHT = 0x806C; // PixelStoreParameter,GetPName
            public const ushort PACK_IMAGE_HEIGHT_EXT = 0x806C; // PixelStoreParameter,GetPName
            public const ushort UNPACK_SKIP_IMAGES = 0x806D; // PixelStoreParameter,GetPName
            public const ushort UNPACK_SKIP_IMAGES_EXT = 0x806D; // PixelStoreParameter,GetPName
            public const ushort UNPACK_IMAGE_HEIGHT = 0x806E; // PixelStoreParameter,GetPName
            public const ushort UNPACK_IMAGE_HEIGHT_EXT = 0x806E; // PixelStoreParameter,GetPName
        }

        public enum GetPointervPName : uint
        {
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
        }

        public enum SamplePatternSGIS : uint
        {
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
        }
        
        public enum ColorTableTargetSGI : uint
        {
            public const ushort TEXTURE_COLOR_TABLE_SGI = 0x80BC; // GetPName,ColorTableTargetSGI,EnableCap
            public const ushort PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD; // ColorTableTargetSGI
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
        }
        
        public enum ColorTableParameterPNameSGI : uint
        {
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
        }
    }
}
*/