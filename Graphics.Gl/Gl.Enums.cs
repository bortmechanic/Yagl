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
        
        // TODO: May be merge the following 4 enums.
        
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
        
        public enum GetMapQuery
        {
            COEFF = 0x0A00,
            ORDER = 0x0A01,
            DOMAIN = 0x0A02,
            // Unused 0x0A03..0x0AFF. Unused for GetMapQuery
        }

        public enum MapQuery
        {
            COEFF = 0x0A00,
            ORDER = 0x0A01,
            DOMAIN = 0x0A02,
            // Unused 0x0A03..0x0AFF. Unused for GetMapQuery
        }

        public enum GetPName
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
        }
    }
}