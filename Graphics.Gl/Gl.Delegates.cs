// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

using System;

namespace Yagl.Graphics
{
    public static partial class Gl
    {

        // glAccum
        private delegate void AccumDel(uint /*AccumOp*/  op, float /*CoordF*/  value); private static AccumDel AccumPtr;
        
        // glAccumxOES
        private delegate void AccumxOESDel(uint  op, int  value); private static AccumxOESDel AccumxOESPtr;
        
        // glActiveProgramEXT
        private delegate void ActiveProgramEXTDel(uint  program); private static ActiveProgramEXTDel ActiveProgramEXTPtr;
        
        // glActiveShaderProgram
        private delegate void ActiveShaderProgramDel(uint  pipeline, uint  program); private static ActiveShaderProgramDel ActiveShaderProgramPtr;
        
        // glActiveShaderProgramEXT
        private delegate void ActiveShaderProgramEXTDel(uint  pipeline, uint  program); private static ActiveShaderProgramEXTDel ActiveShaderProgramEXTPtr;
        
        // glActiveStencilFaceEXT
        private delegate void ActiveStencilFaceEXTDel(uint /*StencilFaceDirection*/  face); private static ActiveStencilFaceEXTDel ActiveStencilFaceEXTPtr;
        
        // glActiveTexture
        private delegate void ActiveTextureDel(uint /*TextureUnit*/  texture); private static ActiveTextureDel ActiveTexturePtr;
        
        // glActiveTextureARB
        private delegate void ActiveTextureARBDel(uint /*TextureUnit*/  texture); private static ActiveTextureARBDel ActiveTextureARBPtr;
        
        // glActiveVaryingNV
        private delegate void ActiveVaryingNVDel(uint  program, string  name); private static ActiveVaryingNVDel ActiveVaryingNVPtr;
        
        // glAlphaFragmentOp1ATI
        private delegate void AlphaFragmentOp1ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod); private static AlphaFragmentOp1ATIDel AlphaFragmentOp1ATIPtr;
        
        // glAlphaFragmentOp2ATI
        private delegate void AlphaFragmentOp2ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod, uint  arg2, uint  arg2Rep, uint  arg2Mod); private static AlphaFragmentOp2ATIDel AlphaFragmentOp2ATIPtr;
        
        // glAlphaFragmentOp3ATI
        private delegate void AlphaFragmentOp3ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod, uint  arg2, uint  arg2Rep, uint  arg2Mod, uint  arg3, uint  arg3Rep, uint  arg3Mod); private static AlphaFragmentOp3ATIDel AlphaFragmentOp3ATIPtr;
        
        // glAlphaFunc
        private delegate void AlphaFuncDel(uint /*AlphaFunction*/  func, float  refVal); private static AlphaFuncDel AlphaFuncPtr;
        
        // glAlphaFuncQCOM
        private delegate void AlphaFuncQCOMDel(uint  func, float  refVal); private static AlphaFuncQCOMDel AlphaFuncQCOMPtr;
        
        // glAlphaFuncx
        private delegate void AlphaFuncxDel(uint /*AlphaFunction*/  func, int  refVal); private static AlphaFuncxDel AlphaFuncxPtr;
        
        // glAlphaFuncxOES
        private delegate void AlphaFuncxOESDel(uint /*AlphaFunction*/  func, int /*ClampedFixed*/  refVal); private static AlphaFuncxOESDel AlphaFuncxOESPtr;
        
        // glAlphaToCoverageDitherControlNV
        private delegate void AlphaToCoverageDitherControlNVDel(uint  mode); private static AlphaToCoverageDitherControlNVDel AlphaToCoverageDitherControlNVPtr;
        
        // glApplyFramebufferAttachmentCMAAINTEL
        private delegate void ApplyFramebufferAttachmentCMAAINTELDel(); private static ApplyFramebufferAttachmentCMAAINTELDel ApplyFramebufferAttachmentCMAAINTELPtr;
        
        // glApplyTextureEXT
        private delegate void ApplyTextureEXTDel(uint /*LightTextureModeEXT*/  mode); private static ApplyTextureEXTDel ApplyTextureEXTPtr;
        
        // glAcquireKeyedMutexWin32EXT
        private delegate bool /*Boolean*/ AcquireKeyedMutexWin32EXTDel(uint  memory, ulong  key, uint  timeout); private static AcquireKeyedMutexWin32EXTDel AcquireKeyedMutexWin32EXTPtr;
        
        // glAreProgramsResidentNV
        private delegate bool /*Boolean*/ AreProgramsResidentNVDel(uint  n, uint[]  programs, bool[] /*Boolean*/  residences); private static AreProgramsResidentNVDel AreProgramsResidentNVPtr;
        
        // glAreTexturesResident
        private delegate bool /*Boolean*/ AreTexturesResidentDel(uint  n, uint[] /*Texture*/  textures, bool[] /*Boolean*/  residences); private static AreTexturesResidentDel AreTexturesResidentPtr;
        
        // glAreTexturesResidentEXT
        private delegate bool /*Boolean*/ AreTexturesResidentEXTDel(uint  n, uint[] /*Texture*/  textures, bool[] /*Boolean*/  residences); private static AreTexturesResidentEXTDel AreTexturesResidentEXTPtr;
        
        // glArrayElement
        private delegate void ArrayElementDel(int  i); private static ArrayElementDel ArrayElementPtr;
        
        // glArrayElementEXT
        private delegate void ArrayElementEXTDel(int  i); private static ArrayElementEXTDel ArrayElementEXTPtr;
        
        // glArrayObjectATI
        private delegate void ArrayObjectATIDel(uint /*EnableCap*/  array, int  size, uint /*ScalarType*/  type, uint  stride, uint  buffer, uint  offset); private static ArrayObjectATIDel ArrayObjectATIPtr;
        
        // glAsyncCopyBufferSubDataNVX
        private delegate uint AsyncCopyBufferSubDataNVXDel(uint  waitSemaphoreCount, uint[]  waitSemaphoreArray, ulong[]  fenceValueArray, uint  readGpu, uint  writeGpuMask, uint  readBuffer, uint  writeBuffer, IntPtr  readOffset, IntPtr  writeOffset, IntPtr  size, uint  signalSemaphoreCount, uint[]  signalSemaphoreArray, ulong[]  signalValueArray); private static AsyncCopyBufferSubDataNVXDel AsyncCopyBufferSubDataNVXPtr;
        
        // glAsyncCopyImageSubDataNVX
        private delegate uint AsyncCopyImageSubDataNVXDel(uint  waitSemaphoreCount, uint[]  waitSemaphoreArray, ulong[]  waitValueArray, uint  srcGpu, uint  dstGpuMask, uint  srcName, uint  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  srcWidth, uint  srcHeight, uint  srcDepth, uint  signalSemaphoreCount, uint[]  signalSemaphoreArray, ulong[]  signalValueArray); private static AsyncCopyImageSubDataNVXDel AsyncCopyImageSubDataNVXPtr;
        
        // glAsyncMarkerSGIX
        private delegate void AsyncMarkerSGIXDel(uint  marker); private static AsyncMarkerSGIXDel AsyncMarkerSGIXPtr;
        
        // glAttachObjectARB
        private delegate void AttachObjectARBDel(IntPtr /*handleARB*/  containerObj, IntPtr /*handleARB*/  obj); private static AttachObjectARBDel AttachObjectARBPtr;
        
        // glAttachShader
        private delegate void AttachShaderDel(uint  program, uint  shader); private static AttachShaderDel AttachShaderPtr;
        
        // glBegin
        private delegate void BeginDel(uint /*PrimitiveType*/  mode); private static BeginDel BeginPtr;
        
        // glBeginConditionalRender
        private delegate void BeginConditionalRenderDel(uint  id, uint /*ConditionalRenderMode*/  mode); private static BeginConditionalRenderDel BeginConditionalRenderPtr;
        
        // glBeginConditionalRenderNV
        private delegate void BeginConditionalRenderNVDel(uint  id, uint /*ConditionalRenderMode*/  mode); private static BeginConditionalRenderNVDel BeginConditionalRenderNVPtr;
        
        // glBeginConditionalRenderNVX
        private delegate void BeginConditionalRenderNVXDel(uint  id); private static BeginConditionalRenderNVXDel BeginConditionalRenderNVXPtr;
        
        // glBeginFragmentShaderATI
        private delegate void BeginFragmentShaderATIDel(); private static BeginFragmentShaderATIDel BeginFragmentShaderATIPtr;
        
        // glBeginOcclusionQueryNV
        private delegate void BeginOcclusionQueryNVDel(uint  id); private static BeginOcclusionQueryNVDel BeginOcclusionQueryNVPtr;
        
        // glBeginPerfMonitorAMD
        private delegate void BeginPerfMonitorAMDDel(uint  monitor); private static BeginPerfMonitorAMDDel BeginPerfMonitorAMDPtr;
        
        // glBeginPerfQueryINTEL
        private delegate void BeginPerfQueryINTELDel(uint  queryHandle); private static BeginPerfQueryINTELDel BeginPerfQueryINTELPtr;
        
        // glBeginQuery
        private delegate void BeginQueryDel(uint /*QueryTarget*/  target, uint  id); private static BeginQueryDel BeginQueryPtr;
        
        // glBeginQueryARB
        private delegate void BeginQueryARBDel(uint  target, uint  id); private static BeginQueryARBDel BeginQueryARBPtr;
        
        // glBeginQueryEXT
        private delegate void BeginQueryEXTDel(uint /*QueryTarget*/  target, uint  id); private static BeginQueryEXTDel BeginQueryEXTPtr;
        
        // glBeginQueryIndexed
        private delegate void BeginQueryIndexedDel(uint /*QueryTarget*/  target, uint  index, uint  id); private static BeginQueryIndexedDel BeginQueryIndexedPtr;
        
        // glBeginTransformFeedback
        private delegate void BeginTransformFeedbackDel(uint /*PrimitiveType*/  primitiveMode); private static BeginTransformFeedbackDel BeginTransformFeedbackPtr;
        
        // glBeginTransformFeedbackEXT
        private delegate void BeginTransformFeedbackEXTDel(uint /*PrimitiveType*/  primitiveMode); private static BeginTransformFeedbackEXTDel BeginTransformFeedbackEXTPtr;
        
        // glBeginTransformFeedbackNV
        private delegate void BeginTransformFeedbackNVDel(uint /*PrimitiveType*/  primitiveMode); private static BeginTransformFeedbackNVDel BeginTransformFeedbackNVPtr;
        
        // glBeginVertexShaderEXT
        private delegate void BeginVertexShaderEXTDel(); private static BeginVertexShaderEXTDel BeginVertexShaderEXTPtr;
        
        // glBeginVideoCaptureNV
        private delegate void BeginVideoCaptureNVDel(uint  video_capture_slot); private static BeginVideoCaptureNVDel BeginVideoCaptureNVPtr;
        
        // glBindAttribLocation
        private delegate void BindAttribLocationDel(uint  program, uint  index, string  name); private static BindAttribLocationDel BindAttribLocationPtr;
        
        // glBindAttribLocationARB
        private delegate void BindAttribLocationARBDel(IntPtr /*handleARB*/  programObj, uint  index, string  name); private static BindAttribLocationARBDel BindAttribLocationARBPtr;
        
        // glBindBuffer
        private delegate void BindBufferDel(uint /*BufferTargetARB*/  target, uint  buffer); private static BindBufferDel BindBufferPtr;
        
        // glBindBufferARB
        private delegate void BindBufferARBDel(uint /*BufferTargetARB*/  target, uint  buffer); private static BindBufferARBDel BindBufferARBPtr;
        
        // glBindBufferBase
        private delegate void BindBufferBaseDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer); private static BindBufferBaseDel BindBufferBasePtr;
        
        // glBindBufferBaseEXT
        private delegate void BindBufferBaseEXTDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer); private static BindBufferBaseEXTDel BindBufferBaseEXTPtr;
        
        // glBindBufferBaseNV
        private delegate void BindBufferBaseNVDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer); private static BindBufferBaseNVDel BindBufferBaseNVPtr;
        
        // glBindBufferOffsetEXT
        private delegate void BindBufferOffsetEXTDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer, IntPtr /*BufferOffset*/  offset); private static BindBufferOffsetEXTDel BindBufferOffsetEXTPtr;
        
        // glBindBufferOffsetNV
        private delegate void BindBufferOffsetNVDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer, IntPtr /*BufferOffset*/  offset); private static BindBufferOffsetNVDel BindBufferOffsetNVPtr;
        
        // glBindBufferRange
        private delegate void BindBufferRangeDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static BindBufferRangeDel BindBufferRangePtr;
        
        // glBindBufferRangeEXT
        private delegate void BindBufferRangeEXTDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static BindBufferRangeEXTDel BindBufferRangeEXTPtr;
        
        // glBindBufferRangeNV
        private delegate void BindBufferRangeNVDel(uint /*BufferTargetARB*/  target, uint  index, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static BindBufferRangeNVDel BindBufferRangeNVPtr;
        
        // glBindBuffersBase
        private delegate void BindBuffersBaseDel(uint /*BufferTargetARB*/  target, uint  first, uint  count, uint[]  buffers); private static BindBuffersBaseDel BindBuffersBasePtr;
        
        // glBindBuffersRange
        private delegate void BindBuffersRangeDel(uint /*BufferTargetARB*/  target, uint  first, uint  count, uint[]  buffers, IntPtr[]  offsets, IntPtr[]  sizes); private static BindBuffersRangeDel BindBuffersRangePtr;
        
        // glBindFragDataLocation
        private delegate void BindFragDataLocationDel(uint  program, uint  color, string  name); private static BindFragDataLocationDel BindFragDataLocationPtr;
        
        // glBindFragDataLocationEXT
        private delegate void BindFragDataLocationEXTDel(uint  program, uint  color, string  name); private static BindFragDataLocationEXTDel BindFragDataLocationEXTPtr;
        
        // glBindFragDataLocationIndexed
        private delegate void BindFragDataLocationIndexedDel(uint  program, uint  colorNumber, uint  index, string  name); private static BindFragDataLocationIndexedDel BindFragDataLocationIndexedPtr;
        
        // glBindFragDataLocationIndexedEXT
        private delegate void BindFragDataLocationIndexedEXTDel(uint  program, uint  colorNumber, uint  index, string  name); private static BindFragDataLocationIndexedEXTDel BindFragDataLocationIndexedEXTPtr;
        
        // glBindFragmentShaderATI
        private delegate void BindFragmentShaderATIDel(uint  id); private static BindFragmentShaderATIDel BindFragmentShaderATIPtr;
        
        // glBindFramebuffer
        private delegate void BindFramebufferDel(uint /*FramebufferTarget*/  target, uint  framebuffer); private static BindFramebufferDel BindFramebufferPtr;
        
        // glBindFramebufferEXT
        private delegate void BindFramebufferEXTDel(uint /*FramebufferTarget*/  target, uint  framebuffer); private static BindFramebufferEXTDel BindFramebufferEXTPtr;
        
        // glBindFramebufferOES
        private delegate void BindFramebufferOESDel(uint /*FramebufferTarget*/  target, uint  framebuffer); private static BindFramebufferOESDel BindFramebufferOESPtr;
        
        // glBindImageTexture
        private delegate void BindImageTextureDel(uint  unit, uint  texture, int  level, bool /*Boolean*/  layered, int  layer, uint /*BufferAccessARB*/  access, uint /*InternalFormat*/  format); private static BindImageTextureDel BindImageTexturePtr;
        
        // glBindImageTextureEXT
        private delegate void BindImageTextureEXTDel(uint  index, uint  texture, int  level, bool /*Boolean*/  layered, int  layer, uint /*BufferAccessARB*/  access, int  format); private static BindImageTextureEXTDel BindImageTextureEXTPtr;
        
        // glBindImageTextures
        private delegate void BindImageTexturesDel(uint  first, uint  count, uint[]  textures); private static BindImageTexturesDel BindImageTexturesPtr;
        
        // glBindLightParameterEXT
        private delegate uint BindLightParameterEXTDel(uint /*LightName*/  light, uint /*LightParameter*/  value); private static BindLightParameterEXTDel BindLightParameterEXTPtr;
        
        // glBindMaterialParameterEXT
        private delegate uint BindMaterialParameterEXTDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  value); private static BindMaterialParameterEXTDel BindMaterialParameterEXTPtr;
        
        // glBindMultiTextureEXT
        private delegate void BindMultiTextureEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*Texture*/  texture); private static BindMultiTextureEXTDel BindMultiTextureEXTPtr;
        
        // glBindParameterEXT
        private delegate uint BindParameterEXTDel(uint /*VertexShaderParameterEXT*/  value); private static BindParameterEXTDel BindParameterEXTPtr;
        
        // glBindProgramARB
        private delegate void BindProgramARBDel(uint /*ProgramTarget*/  target, uint  program); private static BindProgramARBDel BindProgramARBPtr;
        
        // glBindProgramNV
        private delegate void BindProgramNVDel(uint /*VertexAttribEnumNV*/  target, uint  id); private static BindProgramNVDel BindProgramNVPtr;
        
        // glBindProgramPipeline
        private delegate void BindProgramPipelineDel(uint  pipeline); private static BindProgramPipelineDel BindProgramPipelinePtr;
        
        // glBindProgramPipelineEXT
        private delegate void BindProgramPipelineEXTDel(uint  pipeline); private static BindProgramPipelineEXTDel BindProgramPipelineEXTPtr;
        
        // glBindRenderbuffer
        private delegate void BindRenderbufferDel(uint /*RenderbufferTarget*/  target, uint  renderbuffer); private static BindRenderbufferDel BindRenderbufferPtr;
        
        // glBindRenderbufferEXT
        private delegate void BindRenderbufferEXTDel(uint /*RenderbufferTarget*/  target, uint  renderbuffer); private static BindRenderbufferEXTDel BindRenderbufferEXTPtr;
        
        // glBindRenderbufferOES
        private delegate void BindRenderbufferOESDel(uint /*RenderbufferTarget*/  target, uint  renderbuffer); private static BindRenderbufferOESDel BindRenderbufferOESPtr;
        
        // glBindSampler
        private delegate void BindSamplerDel(uint  unit, uint  sampler); private static BindSamplerDel BindSamplerPtr;
        
        // glBindSamplers
        private delegate void BindSamplersDel(uint  first, uint  count, uint[]  samplers); private static BindSamplersDel BindSamplersPtr;
        
        // glBindShadingRateImageNV
        private delegate void BindShadingRateImageNVDel(uint  texture); private static BindShadingRateImageNVDel BindShadingRateImageNVPtr;
        
        // glBindTexGenParameterEXT
        private delegate uint BindTexGenParameterEXTDel(uint /*TextureUnit*/  unit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  value); private static BindTexGenParameterEXTDel BindTexGenParameterEXTPtr;
        
        // glBindTexture
        private delegate void BindTextureDel(uint /*TextureTarget*/  target, uint /*Texture*/  texture); private static BindTextureDel BindTexturePtr;
        
        // glBindTextureEXT
        private delegate void BindTextureEXTDel(uint /*TextureTarget*/  target, uint /*Texture*/  texture); private static BindTextureEXTDel BindTextureEXTPtr;
        
        // glBindTextureUnit
        private delegate void BindTextureUnitDel(uint  unit, uint  texture); private static BindTextureUnitDel BindTextureUnitPtr;
        
        // glBindTextureUnitParameterEXT
        private delegate uint BindTextureUnitParameterEXTDel(uint /*TextureUnit*/  unit, uint /*VertexShaderTextureUnitParameter*/  value); private static BindTextureUnitParameterEXTDel BindTextureUnitParameterEXTPtr;
        
        // glBindTextures
        private delegate void BindTexturesDel(uint  first, uint  count, uint[]  textures); private static BindTexturesDel BindTexturesPtr;
        
        // glBindTransformFeedback
        private delegate void BindTransformFeedbackDel(uint /*BindTransformFeedbackTarget*/  target, uint  id); private static BindTransformFeedbackDel BindTransformFeedbackPtr;
        
        // glBindTransformFeedbackNV
        private delegate void BindTransformFeedbackNVDel(uint /*BufferTargetARB*/  target, uint  id); private static BindTransformFeedbackNVDel BindTransformFeedbackNVPtr;
        
        // glBindVertexArray
        private delegate void BindVertexArrayDel(uint  array); private static BindVertexArrayDel BindVertexArrayPtr;
        
        // glBindVertexArrayAPPLE
        private delegate void BindVertexArrayAPPLEDel(uint  array); private static BindVertexArrayAPPLEDel BindVertexArrayAPPLEPtr;
        
        // glBindVertexArrayOES
        private delegate void BindVertexArrayOESDel(uint  array); private static BindVertexArrayOESDel BindVertexArrayOESPtr;
        
        // glBindVertexBuffer
        private delegate void BindVertexBufferDel(uint  bindingindex, uint  buffer, IntPtr /*BufferOffset*/  offset, uint  stride); private static BindVertexBufferDel BindVertexBufferPtr;
        
        // glBindVertexBuffers
        private delegate void BindVertexBuffersDel(uint  first, uint  count, uint[]  buffers, IntPtr[]  offsets, uint[]  strides); private static BindVertexBuffersDel BindVertexBuffersPtr;
        
        // glBindVertexShaderEXT
        private delegate void BindVertexShaderEXTDel(uint  id); private static BindVertexShaderEXTDel BindVertexShaderEXTPtr;
        
        // glBindVideoCaptureStreamBufferNV
        private delegate void BindVideoCaptureStreamBufferNVDel(uint  video_capture_slot, uint  stream, uint  frame_region, IntPtr /*BufferOffsetARB*/  offset); private static BindVideoCaptureStreamBufferNVDel BindVideoCaptureStreamBufferNVPtr;
        
        // glBindVideoCaptureStreamTextureNV
        private delegate void BindVideoCaptureStreamTextureNVDel(uint  video_capture_slot, uint  stream, uint  frame_region, uint  target, uint  texture); private static BindVideoCaptureStreamTextureNVDel BindVideoCaptureStreamTextureNVPtr;
        
        // glBinormal3bEXT
        private delegate void Binormal3bEXTDel(sbyte  bx, sbyte  by, sbyte  bz); private static Binormal3bEXTDel Binormal3bEXTPtr;
        
        // glBinormal3bvEXT
        private delegate void Binormal3bvEXTDel(sbyte[]  v); private static Binormal3bvEXTDel Binormal3bvEXTPtr;
        
        // glBinormal3dEXT
        private delegate void Binormal3dEXTDel(double /*CoordD*/  bx, double /*CoordD*/  by, double /*CoordD*/  bz); private static Binormal3dEXTDel Binormal3dEXTPtr;
        
        // glBinormal3dvEXT
        private delegate void Binormal3dvEXTDel(double[] /*CoordD*/  v); private static Binormal3dvEXTDel Binormal3dvEXTPtr;
        
        // glBinormal3fEXT
        private delegate void Binormal3fEXTDel(float /*CoordF*/  bx, float /*CoordF*/  by, float /*CoordF*/  bz); private static Binormal3fEXTDel Binormal3fEXTPtr;
        
        // glBinormal3fvEXT
        private delegate void Binormal3fvEXTDel(float[] /*CoordF*/  v); private static Binormal3fvEXTDel Binormal3fvEXTPtr;
        
        // glBinormal3iEXT
        private delegate void Binormal3iEXTDel(int  bx, int  by, int  bz); private static Binormal3iEXTDel Binormal3iEXTPtr;
        
        // glBinormal3ivEXT
        private delegate void Binormal3ivEXTDel(int[]  v); private static Binormal3ivEXTDel Binormal3ivEXTPtr;
        
        // glBinormal3sEXT
        private delegate void Binormal3sEXTDel(short  bx, short  by, short  bz); private static Binormal3sEXTDel Binormal3sEXTPtr;
        
        // glBinormal3svEXT
        private delegate void Binormal3svEXTDel(short[]  v); private static Binormal3svEXTDel Binormal3svEXTPtr;
        
        // glBinormalPointerEXT
        private delegate void BinormalPointerEXTDel(uint /*BinormalPointerTypeEXT*/  type, uint  stride, IntPtr  pointer); private static BinormalPointerEXTDel BinormalPointerEXTPtr;
        
        // glBitmap
        private delegate void BitmapDel(uint  width, uint  height, float /*CoordF*/  xorig, float /*CoordF*/  yorig, float /*CoordF*/  xmove, float /*CoordF*/  ymove, byte[]  bitmap); private static BitmapDel BitmapPtr;
        
        // glBitmapxOES
        private delegate void BitmapxOESDel(uint  width, uint  height, int  xorig, int  yorig, int  xmove, int  ymove, byte[]  bitmap); private static BitmapxOESDel BitmapxOESPtr;
        
        // glBlendBarrier
        private delegate void BlendBarrierDel(); private static BlendBarrierDel BlendBarrierPtr;
        
        // glBlendBarrierKHR
        private delegate void BlendBarrierKHRDel(); private static BlendBarrierKHRDel BlendBarrierKHRPtr;
        
        // glBlendBarrierNV
        private delegate void BlendBarrierNVDel(); private static BlendBarrierNVDel BlendBarrierNVPtr;
        
        // glBlendColor
        private delegate void BlendColorDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue, float /*ColorF*/  alpha); private static BlendColorDel BlendColorPtr;
        
        // glBlendColorEXT
        private delegate void BlendColorEXTDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue, float /*ColorF*/  alpha); private static BlendColorEXTDel BlendColorEXTPtr;
        
        // glBlendColorxOES
        private delegate void BlendColorxOESDel(int /*ClampedFixed*/  red, int /*ClampedFixed*/  green, int /*ClampedFixed*/  blue, int /*ClampedFixed*/  alpha); private static BlendColorxOESDel BlendColorxOESPtr;
        
        // glBlendEquation
        private delegate void BlendEquationDel(uint /*BlendEquationModeEXT*/  mode); private static BlendEquationDel BlendEquationPtr;
        
        // glBlendEquationEXT
        private delegate void BlendEquationEXTDel(uint /*BlendEquationModeEXT*/  mode); private static BlendEquationEXTDel BlendEquationEXTPtr;
        
        // glBlendEquationIndexedAMD
        private delegate void BlendEquationIndexedAMDDel(uint  buf, uint /*BlendEquationModeEXT*/  mode); private static BlendEquationIndexedAMDDel BlendEquationIndexedAMDPtr;
        
        // glBlendEquationOES
        private delegate void BlendEquationOESDel(uint /*BlendEquationModeEXT*/  mode); private static BlendEquationOESDel BlendEquationOESPtr;
        
        // glBlendEquationSeparate
        private delegate void BlendEquationSeparateDel(uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateDel BlendEquationSeparatePtr;
        
        // glBlendEquationSeparateEXT
        private delegate void BlendEquationSeparateEXTDel(uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateEXTDel BlendEquationSeparateEXTPtr;
        
        // glBlendEquationSeparateIndexedAMD
        private delegate void BlendEquationSeparateIndexedAMDDel(uint  buf, uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateIndexedAMDDel BlendEquationSeparateIndexedAMDPtr;
        
        // glBlendEquationSeparateOES
        private delegate void BlendEquationSeparateOESDel(uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateOESDel BlendEquationSeparateOESPtr;
        
        // glBlendEquationSeparatei
        private delegate void BlendEquationSeparateiDel(uint  buf, uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateiDel BlendEquationSeparateiPtr;
        
        // glBlendEquationSeparateiARB
        private delegate void BlendEquationSeparateiARBDel(uint  buf, uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateiARBDel BlendEquationSeparateiARBPtr;
        
        // glBlendEquationSeparateiEXT
        private delegate void BlendEquationSeparateiEXTDel(uint  buf, uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateiEXTDel BlendEquationSeparateiEXTPtr;
        
        // glBlendEquationSeparateiOES
        private delegate void BlendEquationSeparateiOESDel(uint  buf, uint /*BlendEquationModeEXT*/  modeRGB, uint /*BlendEquationModeEXT*/  modeAlpha); private static BlendEquationSeparateiOESDel BlendEquationSeparateiOESPtr;
        
        // glBlendEquationi
        private delegate void BlendEquationiDel(uint  buf, uint /*BlendEquationModeEXT*/  mode); private static BlendEquationiDel BlendEquationiPtr;
        
        // glBlendEquationiARB
        private delegate void BlendEquationiARBDel(uint  buf, uint /*BlendEquationModeEXT*/  mode); private static BlendEquationiARBDel BlendEquationiARBPtr;
        
        // glBlendEquationiEXT
        private delegate void BlendEquationiEXTDel(uint  buf, uint /*BlendEquationModeEXT*/  mode); private static BlendEquationiEXTDel BlendEquationiEXTPtr;
        
        // glBlendEquationiOES
        private delegate void BlendEquationiOESDel(uint  buf, uint /*BlendEquationModeEXT*/  mode); private static BlendEquationiOESDel BlendEquationiOESPtr;
        
        // glBlendFunc
        private delegate void BlendFuncDel(uint /*BlendingFactor*/  sfactor, uint /*BlendingFactor*/  dfactor); private static BlendFuncDel BlendFuncPtr;
        
        // glBlendFuncIndexedAMD
        private delegate void BlendFuncIndexedAMDDel(uint  buf, uint  src, uint  dst); private static BlendFuncIndexedAMDDel BlendFuncIndexedAMDPtr;
        
        // glBlendFuncSeparate
        private delegate void BlendFuncSeparateDel(uint /*BlendingFactor*/  sfactorRGB, uint /*BlendingFactor*/  dfactorRGB, uint /*BlendingFactor*/  sfactorAlpha, uint /*BlendingFactor*/  dfactorAlpha); private static BlendFuncSeparateDel BlendFuncSeparatePtr;
        
        // glBlendFuncSeparateEXT
        private delegate void BlendFuncSeparateEXTDel(uint /*BlendingFactor*/  sfactorRGB, uint /*BlendingFactor*/  dfactorRGB, uint /*BlendingFactor*/  sfactorAlpha, uint /*BlendingFactor*/  dfactorAlpha); private static BlendFuncSeparateEXTDel BlendFuncSeparateEXTPtr;
        
        // glBlendFuncSeparateINGR
        private delegate void BlendFuncSeparateINGRDel(uint /*BlendingFactor*/  sfactorRGB, uint /*BlendingFactor*/  dfactorRGB, uint /*BlendingFactor*/  sfactorAlpha, uint /*BlendingFactor*/  dfactorAlpha); private static BlendFuncSeparateINGRDel BlendFuncSeparateINGRPtr;
        
        // glBlendFuncSeparateIndexedAMD
        private delegate void BlendFuncSeparateIndexedAMDDel(uint  buf, uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateIndexedAMDDel BlendFuncSeparateIndexedAMDPtr;
        
        // glBlendFuncSeparateOES
        private delegate void BlendFuncSeparateOESDel(uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateOESDel BlendFuncSeparateOESPtr;
        
        // glBlendFuncSeparatei
        private delegate void BlendFuncSeparateiDel(uint  buf, uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateiDel BlendFuncSeparateiPtr;
        
        // glBlendFuncSeparateiARB
        private delegate void BlendFuncSeparateiARBDel(uint  buf, uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateiARBDel BlendFuncSeparateiARBPtr;
        
        // glBlendFuncSeparateiEXT
        private delegate void BlendFuncSeparateiEXTDel(uint  buf, uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateiEXTDel BlendFuncSeparateiEXTPtr;
        
        // glBlendFuncSeparateiOES
        private delegate void BlendFuncSeparateiOESDel(uint  buf, uint /*BlendingFactor*/  srcRGB, uint /*BlendingFactor*/  dstRGB, uint /*BlendingFactor*/  srcAlpha, uint /*BlendingFactor*/  dstAlpha); private static BlendFuncSeparateiOESDel BlendFuncSeparateiOESPtr;
        
        // glBlendFunci
        private delegate void BlendFunciDel(uint  buf, uint /*BlendingFactor*/  src, uint /*BlendingFactor*/  dst); private static BlendFunciDel BlendFunciPtr;
        
        // glBlendFunciARB
        private delegate void BlendFunciARBDel(uint  buf, uint /*BlendingFactor*/  src, uint /*BlendingFactor*/  dst); private static BlendFunciARBDel BlendFunciARBPtr;
        
        // glBlendFunciEXT
        private delegate void BlendFunciEXTDel(uint  buf, uint /*BlendingFactor*/  src, uint /*BlendingFactor*/  dst); private static BlendFunciEXTDel BlendFunciEXTPtr;
        
        // glBlendFunciOES
        private delegate void BlendFunciOESDel(uint  buf, uint /*BlendingFactor*/  src, uint /*BlendingFactor*/  dst); private static BlendFunciOESDel BlendFunciOESPtr;
        
        // glBlendParameteriNV
        private delegate void BlendParameteriNVDel(uint  pname, int  value); private static BlendParameteriNVDel BlendParameteriNVPtr;
        
        // glBlitFramebuffer
        private delegate void BlitFramebufferDel(int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint /*BlitFramebufferFilter*/  filter); private static BlitFramebufferDel BlitFramebufferPtr;
        
        // glBlitFramebufferANGLE
        private delegate void BlitFramebufferANGLEDel(int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint /*BlitFramebufferFilter*/  filter); private static BlitFramebufferANGLEDel BlitFramebufferANGLEPtr;
        
        // glBlitFramebufferEXT
        private delegate void BlitFramebufferEXTDel(int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint /*BlitFramebufferFilter*/  filter); private static BlitFramebufferEXTDel BlitFramebufferEXTPtr;
        
        // glBlitFramebufferNV
        private delegate void BlitFramebufferNVDel(int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint /*BlitFramebufferFilter*/  filter); private static BlitFramebufferNVDel BlitFramebufferNVPtr;
        
        // glBlitNamedFramebuffer
        private delegate void BlitNamedFramebufferDel(uint  readFramebuffer, uint  drawFramebuffer, int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint /*BlitFramebufferFilter*/  filter); private static BlitNamedFramebufferDel BlitNamedFramebufferPtr;
        
        // glBufferAddressRangeNV
        private delegate void BufferAddressRangeNVDel(uint  pname, uint  index, ulong  address, IntPtr /*BufferSize*/  length); private static BufferAddressRangeNVDel BufferAddressRangeNVPtr;
        
        // glBufferAttachMemoryNV
        private delegate void BufferAttachMemoryNVDel(uint /*BufferTargetARB*/  target, uint  memory, ulong  offset); private static BufferAttachMemoryNVDel BufferAttachMemoryNVPtr;
        
        // glBufferData
        private delegate void BufferDataDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferSize*/  size, IntPtr  data, uint /*BufferUsageARB*/  usage); private static BufferDataDel BufferDataPtr;
        
        // glBufferDataARB
        private delegate void BufferDataARBDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferSizeARB*/  size, IntPtr  data, uint /*BufferUsageARB*/  usage); private static BufferDataARBDel BufferDataARBPtr;
        
        // glBufferPageCommitmentARB
        private delegate void BufferPageCommitmentARBDel(uint  target, IntPtr  offset, IntPtr  size, bool /*Boolean*/  commit); private static BufferPageCommitmentARBDel BufferPageCommitmentARBPtr;
        
        // glBufferParameteriAPPLE
        private delegate void BufferParameteriAPPLEDel(uint  target, uint  pname, int  param); private static BufferParameteriAPPLEDel BufferParameteriAPPLEPtr;
        
        // glBufferStorage
        private delegate void BufferStorageDel(uint /*BufferStorageTarget*/  target, IntPtr  size, IntPtr  data, uint /*BufferStorageMask*/  flags); private static BufferStorageDel BufferStoragePtr;
        
        // glBufferStorageEXT
        private delegate void BufferStorageEXTDel(uint /*BufferStorageTarget*/  target, IntPtr  size, IntPtr  data, uint /*BufferStorageMask*/  flags); private static BufferStorageEXTDel BufferStorageEXTPtr;
        
        // glBufferStorageExternalEXT
        private delegate void BufferStorageExternalEXTDel(uint  target, IntPtr  offset, IntPtr  size, IntPtr /*GLeglClientBufferEXT*/  clientBuffer, uint /*BufferStorageMask*/  flags); private static BufferStorageExternalEXTDel BufferStorageExternalEXTPtr;
        
        // glBufferStorageMemEXT
        private delegate void BufferStorageMemEXTDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferSize*/  size, uint  memory, ulong  offset); private static BufferStorageMemEXTDel BufferStorageMemEXTPtr;
        
        // glBufferSubData
        private delegate void BufferSubDataDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size, IntPtr  data); private static BufferSubDataDel BufferSubDataPtr;
        
        // glBufferSubDataARB
        private delegate void BufferSubDataARBDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffsetARB*/  offset, IntPtr /*BufferSizeARB*/  size, IntPtr  data); private static BufferSubDataARBDel BufferSubDataARBPtr;
        
        // glCallCommandListNV
        private delegate void CallCommandListNVDel(uint  list); private static CallCommandListNVDel CallCommandListNVPtr;
        
        // glCallList
        private delegate void CallListDel(uint /*List*/  list); private static CallListDel CallListPtr;
        
        // glCallLists
        private delegate void CallListsDel(uint  n, uint /*ListNameType*/  type, IntPtr  lists); private static CallListsDel CallListsPtr;
        
        // glCheckFramebufferStatus
        private delegate uint /*FramebufferStatus*/ CheckFramebufferStatusDel(uint /*FramebufferTarget*/  target); private static CheckFramebufferStatusDel CheckFramebufferStatusPtr;
        
        // glCheckFramebufferStatusEXT
        private delegate uint /*FramebufferStatus*/ CheckFramebufferStatusEXTDel(uint /*FramebufferTarget*/  target); private static CheckFramebufferStatusEXTDel CheckFramebufferStatusEXTPtr;
        
        // glCheckFramebufferStatusOES
        private delegate uint /*FramebufferStatus*/ CheckFramebufferStatusOESDel(uint /*FramebufferTarget*/  target); private static CheckFramebufferStatusOESDel CheckFramebufferStatusOESPtr;
        
        // glCheckNamedFramebufferStatus
        private delegate uint /*FramebufferStatus*/ CheckNamedFramebufferStatusDel(uint  framebuffer, uint /*FramebufferTarget*/  target); private static CheckNamedFramebufferStatusDel CheckNamedFramebufferStatusPtr;
        
        // glCheckNamedFramebufferStatusEXT
        private delegate uint /*FramebufferStatus*/ CheckNamedFramebufferStatusEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferTarget*/  target); private static CheckNamedFramebufferStatusEXTDel CheckNamedFramebufferStatusEXTPtr;
        
        // glClampColor
        private delegate void ClampColorDel(uint /*ClampColorTargetARB*/  target, uint /*ClampColorModeARB*/  clamp); private static ClampColorDel ClampColorPtr;
        
        // glClampColorARB
        private delegate void ClampColorARBDel(uint /*ClampColorTargetARB*/  target, uint /*ClampColorModeARB*/  clamp); private static ClampColorARBDel ClampColorARBPtr;
        
        // glClear
        private delegate void ClearDel(uint /*ClearBufferMask*/  mask); private static ClearDel ClearPtr;
        
        // glClearAccum
        private delegate void ClearAccumDel(float  red, float  green, float  blue, float  alpha); private static ClearAccumDel ClearAccumPtr;
        
        // glClearAccumxOES
        private delegate void ClearAccumxOESDel(int /*ClampedFixed*/  red, int /*ClampedFixed*/  green, int /*ClampedFixed*/  blue, int /*ClampedFixed*/  alpha); private static ClearAccumxOESDel ClearAccumxOESPtr;
        
        // glClearBufferData
        private delegate void ClearBufferDataDel(uint /*BufferStorageTarget*/  target, uint /*InternalFormat*/  internalformat, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearBufferDataDel ClearBufferDataPtr;
        
        // glClearBufferSubData
        private delegate void ClearBufferSubDataDel(uint /*BufferTargetARB*/  target, uint /*InternalFormat*/  internalformat, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearBufferSubDataDel ClearBufferSubDataPtr;
        
        // glClearBufferfi
        private delegate void ClearBufferfiDel(uint /*Buffer*/  buffer, int /*DrawBufferName*/  drawbuffer, float  depth, int  stencil); private static ClearBufferfiDel ClearBufferfiPtr;
        
        // glClearBufferfv
        private delegate void ClearBufferfvDel(uint /*Buffer*/  buffer, int /*DrawBufferName*/  drawbuffer, float[]  value); private static ClearBufferfvDel ClearBufferfvPtr;
        
        // glClearBufferiv
        private delegate void ClearBufferivDel(uint /*Buffer*/  buffer, int /*DrawBufferName*/  drawbuffer, int[]  value); private static ClearBufferivDel ClearBufferivPtr;
        
        // glClearBufferuiv
        private delegate void ClearBufferuivDel(uint /*Buffer*/  buffer, int /*DrawBufferName*/  drawbuffer, uint[]  value); private static ClearBufferuivDel ClearBufferuivPtr;
        
        // glClearColor
        private delegate void ClearColorDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue, float /*ColorF*/  alpha); private static ClearColorDel ClearColorPtr;
        
        // glClearColorIiEXT
        private delegate void ClearColorIiEXTDel(int  red, int  green, int  blue, int  alpha); private static ClearColorIiEXTDel ClearColorIiEXTPtr;
        
        // glClearColorIuiEXT
        private delegate void ClearColorIuiEXTDel(uint  red, uint  green, uint  blue, uint  alpha); private static ClearColorIuiEXTDel ClearColorIuiEXTPtr;
        
        // glClearColorx
        private delegate void ClearColorxDel(int  red, int  green, int  blue, int  alpha); private static ClearColorxDel ClearColorxPtr;
        
        // glClearColorxOES
        private delegate void ClearColorxOESDel(int /*ClampedFixed*/  red, int /*ClampedFixed*/  green, int /*ClampedFixed*/  blue, int /*ClampedFixed*/  alpha); private static ClearColorxOESDel ClearColorxOESPtr;
        
        // glClearDepth
        private delegate void ClearDepthDel(double  depth); private static ClearDepthDel ClearDepthPtr;
        
        // glClearDepthdNV
        private delegate void ClearDepthdNVDel(double  depth); private static ClearDepthdNVDel ClearDepthdNVPtr;
        
        // glClearDepthf
        private delegate void ClearDepthfDel(float  d); private static ClearDepthfDel ClearDepthfPtr;
        
        // glClearDepthfOES
        private delegate void ClearDepthfOESDel(float /*ClampedFloat32*/  depth); private static ClearDepthfOESDel ClearDepthfOESPtr;
        
        // glClearDepthx
        private delegate void ClearDepthxDel(int  depth); private static ClearDepthxDel ClearDepthxPtr;
        
        // glClearDepthxOES
        private delegate void ClearDepthxOESDel(int /*ClampedFixed*/  depth); private static ClearDepthxOESDel ClearDepthxOESPtr;
        
        // glClearIndex
        private delegate void ClearIndexDel(float /*MaskedColorIndexValueF*/  c); private static ClearIndexDel ClearIndexPtr;
        
        // glClearNamedBufferData
        private delegate void ClearNamedBufferDataDel(uint  buffer, uint /*InternalFormat*/  internalformat, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearNamedBufferDataDel ClearNamedBufferDataPtr;
        
        // glClearNamedBufferDataEXT
        private delegate void ClearNamedBufferDataEXTDel(uint  buffer, uint /*InternalFormat*/  internalformat, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearNamedBufferDataEXTDel ClearNamedBufferDataEXTPtr;
        
        // glClearNamedBufferSubData
        private delegate void ClearNamedBufferSubDataDel(uint  buffer, uint /*InternalFormat*/  internalformat, IntPtr  offset, IntPtr /*BufferSize*/  size, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearNamedBufferSubDataDel ClearNamedBufferSubDataPtr;
        
        // glClearNamedBufferSubDataEXT
        private delegate void ClearNamedBufferSubDataEXTDel(uint  buffer, uint  internalformat, IntPtr /*BufferSize*/  offset, IntPtr /*BufferSize*/  size, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearNamedBufferSubDataEXTDel ClearNamedBufferSubDataEXTPtr;
        
        // glClearNamedFramebufferfi
        private delegate void ClearNamedFramebufferfiDel(uint  framebuffer, uint /*Buffer*/  buffer, int  drawbuffer, float  depth, int  stencil); private static ClearNamedFramebufferfiDel ClearNamedFramebufferfiPtr;
        
        // glClearNamedFramebufferfv
        private delegate void ClearNamedFramebufferfvDel(uint  framebuffer, uint /*Buffer*/  buffer, int  drawbuffer, float[]  value); private static ClearNamedFramebufferfvDel ClearNamedFramebufferfvPtr;
        
        // glClearNamedFramebufferiv
        private delegate void ClearNamedFramebufferivDel(uint  framebuffer, uint /*Buffer*/  buffer, int  drawbuffer, int[]  value); private static ClearNamedFramebufferivDel ClearNamedFramebufferivPtr;
        
        // glClearNamedFramebufferuiv
        private delegate void ClearNamedFramebufferuivDel(uint  framebuffer, uint /*Buffer*/  buffer, int  drawbuffer, uint[]  value); private static ClearNamedFramebufferuivDel ClearNamedFramebufferuivPtr;
        
        // glClearPixelLocalStorageuiEXT
        private delegate void ClearPixelLocalStorageuiEXTDel(uint  offset, uint  n, uint[]  values); private static ClearPixelLocalStorageuiEXTDel ClearPixelLocalStorageuiEXTPtr;
        
        // glClearStencil
        private delegate void ClearStencilDel(int /*StencilValue*/  s); private static ClearStencilDel ClearStencilPtr;
        
        // glClearTexImage
        private delegate void ClearTexImageDel(uint  texture, int  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearTexImageDel ClearTexImagePtr;
        
        // glClearTexImageEXT
        private delegate void ClearTexImageEXTDel(uint  texture, int  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearTexImageEXTDel ClearTexImageEXTPtr;
        
        // glClearTexSubImage
        private delegate void ClearTexSubImageDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearTexSubImageDel ClearTexSubImagePtr;
        
        // glClearTexSubImageEXT
        private delegate void ClearTexSubImageEXTDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ClearTexSubImageEXTDel ClearTexSubImageEXTPtr;
        
        // glClientActiveTexture
        private delegate void ClientActiveTextureDel(uint /*TextureUnit*/  texture); private static ClientActiveTextureDel ClientActiveTexturePtr;
        
        // glClientActiveTextureARB
        private delegate void ClientActiveTextureARBDel(uint /*TextureUnit*/  texture); private static ClientActiveTextureARBDel ClientActiveTextureARBPtr;
        
        // glClientActiveVertexStreamATI
        private delegate void ClientActiveVertexStreamATIDel(uint /*VertexStreamATI*/  stream); private static ClientActiveVertexStreamATIDel ClientActiveVertexStreamATIPtr;
        
        // glClientAttribDefaultEXT
        private delegate void ClientAttribDefaultEXTDel(uint /*ClientAttribMask*/  mask); private static ClientAttribDefaultEXTDel ClientAttribDefaultEXTPtr;
        
        // glClientWaitSemaphoreui64NVX
        private delegate void ClientWaitSemaphoreui64NVXDel(uint  fenceObjectCount, uint[]  semaphoreArray, ulong[]  fenceValueArray); private static ClientWaitSemaphoreui64NVXDel ClientWaitSemaphoreui64NVXPtr;
        
        // glClientWaitSync
        private delegate uint /*SyncStatus*/ ClientWaitSyncDel(IntPtr /*sync*/  sync, uint /*SyncObjectMask*/  flags, ulong  timeout); private static ClientWaitSyncDel ClientWaitSyncPtr;
        
        // glClientWaitSyncAPPLE
        private delegate uint /*SyncStatus*/ ClientWaitSyncAPPLEDel(IntPtr  sync, uint /*SyncObjectMask*/  flags, ulong  timeout); private static ClientWaitSyncAPPLEDel ClientWaitSyncAPPLEPtr;
        
        // glClipControl
        private delegate void ClipControlDel(uint /*ClipControlOrigin*/  origin, uint /*ClipControlDepth*/  depth); private static ClipControlDel ClipControlPtr;
        
        // glClipControlEXT
        private delegate void ClipControlEXTDel(uint  origin, uint  depth); private static ClipControlEXTDel ClipControlEXTPtr;
        
        // glClipPlane
        private delegate void ClipPlaneDel(uint /*ClipPlaneName*/  plane, double[]  equation); private static ClipPlaneDel ClipPlanePtr;
        
        // glClipPlanef
        private delegate void ClipPlanefDel(uint /*ClipPlaneName*/  p, float[]  eqn); private static ClipPlanefDel ClipPlanefPtr;
        
        // glClipPlanefIMG
        private delegate void ClipPlanefIMGDel(uint /*ClipPlaneName*/  p, float[]  eqn); private static ClipPlanefIMGDel ClipPlanefIMGPtr;
        
        // glClipPlanefOES
        private delegate void ClipPlanefOESDel(uint /*ClipPlaneName*/  plane, float[]  equation); private static ClipPlanefOESDel ClipPlanefOESPtr;
        
        // glClipPlanex
        private delegate void ClipPlanexDel(uint /*ClipPlaneName*/  plane, int[]  equation); private static ClipPlanexDel ClipPlanexPtr;
        
        // glClipPlanexIMG
        private delegate void ClipPlanexIMGDel(uint /*ClipPlaneName*/  p, int[]  eqn); private static ClipPlanexIMGDel ClipPlanexIMGPtr;
        
        // glClipPlanexOES
        private delegate void ClipPlanexOESDel(uint /*ClipPlaneName*/  plane, int[]  equation); private static ClipPlanexOESDel ClipPlanexOESPtr;
        
        // glColor3b
        private delegate void Color3bDel(sbyte /*ColorB*/  red, sbyte /*ColorB*/  green, sbyte /*ColorB*/  blue); private static Color3bDel Color3bPtr;
        
        // glColor3bv
        private delegate void Color3bvDel(sbyte[] /*ColorB*/  v); private static Color3bvDel Color3bvPtr;
        
        // glColor3d
        private delegate void Color3dDel(double /*ColorD*/  red, double /*ColorD*/  green, double /*ColorD*/  blue); private static Color3dDel Color3dPtr;
        
        // glColor3dv
        private delegate void Color3dvDel(double[] /*ColorD*/  v); private static Color3dvDel Color3dvPtr;
        
        // glColor3f
        private delegate void Color3fDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue); private static Color3fDel Color3fPtr;
        
        // glColor3fVertex3fSUN
        private delegate void Color3fVertex3fSUNDel(float  r, float  g, float  b, float  x, float  y, float  z); private static Color3fVertex3fSUNDel Color3fVertex3fSUNPtr;
        
        // glColor3fVertex3fvSUN
        private delegate void Color3fVertex3fvSUNDel(float[]  c, float[]  v); private static Color3fVertex3fvSUNDel Color3fVertex3fvSUNPtr;
        
        // glColor3fv
        private delegate void Color3fvDel(float[] /*ColorF*/  v); private static Color3fvDel Color3fvPtr;
        
        // glColor3hNV
        private delegate void Color3hNVDel(ushort /*Half16NV*/  red, ushort /*Half16NV*/  green, ushort /*Half16NV*/  blue); private static Color3hNVDel Color3hNVPtr;
        
        // glColor3hvNV
        private delegate void Color3hvNVDel(ushort[] /*Half16NV*/  v); private static Color3hvNVDel Color3hvNVPtr;
        
        // glColor3i
        private delegate void Color3iDel(int /*ColorI*/  red, int /*ColorI*/  green, int /*ColorI*/  blue); private static Color3iDel Color3iPtr;
        
        // glColor3iv
        private delegate void Color3ivDel(int[] /*ColorI*/  v); private static Color3ivDel Color3ivPtr;
        
        // glColor3s
        private delegate void Color3sDel(short /*ColorS*/  red, short /*ColorS*/  green, short /*ColorS*/  blue); private static Color3sDel Color3sPtr;
        
        // glColor3sv
        private delegate void Color3svDel(short[] /*ColorS*/  v); private static Color3svDel Color3svPtr;
        
        // glColor3ub
        private delegate void Color3ubDel(byte /*ColorUB*/  red, byte /*ColorUB*/  green, byte /*ColorUB*/  blue); private static Color3ubDel Color3ubPtr;
        
        // glColor3ubv
        private delegate void Color3ubvDel(byte[] /*ColorUB*/  v); private static Color3ubvDel Color3ubvPtr;
        
        // glColor3ui
        private delegate void Color3uiDel(uint /*ColorUI*/  red, uint /*ColorUI*/  green, uint /*ColorUI*/  blue); private static Color3uiDel Color3uiPtr;
        
        // glColor3uiv
        private delegate void Color3uivDel(uint[] /*ColorUI*/  v); private static Color3uivDel Color3uivPtr;
        
        // glColor3us
        private delegate void Color3usDel(ushort /*ColorUS*/  red, ushort /*ColorUS*/  green, ushort /*ColorUS*/  blue); private static Color3usDel Color3usPtr;
        
        // glColor3usv
        private delegate void Color3usvDel(ushort[] /*ColorUS*/  v); private static Color3usvDel Color3usvPtr;
        
        // glColor3xOES
        private delegate void Color3xOESDel(int  red, int  green, int  blue); private static Color3xOESDel Color3xOESPtr;
        
        // glColor3xvOES
        private delegate void Color3xvOESDel(int[]  components); private static Color3xvOESDel Color3xvOESPtr;
        
        // glColor4b
        private delegate void Color4bDel(sbyte /*ColorB*/  red, sbyte /*ColorB*/  green, sbyte /*ColorB*/  blue, sbyte /*ColorB*/  alpha); private static Color4bDel Color4bPtr;
        
        // glColor4bv
        private delegate void Color4bvDel(sbyte[] /*ColorB*/  v); private static Color4bvDel Color4bvPtr;
        
        // glColor4d
        private delegate void Color4dDel(double /*ColorD*/  red, double /*ColorD*/  green, double /*ColorD*/  blue, double /*ColorD*/  alpha); private static Color4dDel Color4dPtr;
        
        // glColor4dv
        private delegate void Color4dvDel(double[] /*ColorD*/  v); private static Color4dvDel Color4dvPtr;
        
        // glColor4f
        private delegate void Color4fDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue, float /*ColorF*/  alpha); private static Color4fDel Color4fPtr;
        
        // glColor4fNormal3fVertex3fSUN
        private delegate void Color4fNormal3fVertex3fSUNDel(float  r, float  g, float  b, float  a, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static Color4fNormal3fVertex3fSUNDel Color4fNormal3fVertex3fSUNPtr;
        
        // glColor4fNormal3fVertex3fvSUN
        private delegate void Color4fNormal3fVertex3fvSUNDel(float[]  c, float[]  n, float[]  v); private static Color4fNormal3fVertex3fvSUNDel Color4fNormal3fVertex3fvSUNPtr;
        
        // glColor4fv
        private delegate void Color4fvDel(float[] /*ColorF*/  v); private static Color4fvDel Color4fvPtr;
        
        // glColor4hNV
        private delegate void Color4hNVDel(ushort /*Half16NV*/  red, ushort /*Half16NV*/  green, ushort /*Half16NV*/  blue, ushort /*Half16NV*/  alpha); private static Color4hNVDel Color4hNVPtr;
        
        // glColor4hvNV
        private delegate void Color4hvNVDel(ushort[] /*Half16NV*/  v); private static Color4hvNVDel Color4hvNVPtr;
        
        // glColor4i
        private delegate void Color4iDel(int /*ColorI*/  red, int /*ColorI*/  green, int /*ColorI*/  blue, int /*ColorI*/  alpha); private static Color4iDel Color4iPtr;
        
        // glColor4iv
        private delegate void Color4ivDel(int[] /*ColorI*/  v); private static Color4ivDel Color4ivPtr;
        
        // glColor4s
        private delegate void Color4sDel(short /*ColorS*/  red, short /*ColorS*/  green, short /*ColorS*/  blue, short /*ColorS*/  alpha); private static Color4sDel Color4sPtr;
        
        // glColor4sv
        private delegate void Color4svDel(short[] /*ColorS*/  v); private static Color4svDel Color4svPtr;
        
        // glColor4ub
        private delegate void Color4ubDel(byte /*ColorUB*/  red, byte /*ColorUB*/  green, byte /*ColorUB*/  blue, byte /*ColorUB*/  alpha); private static Color4ubDel Color4ubPtr;
        
        // glColor4ubVertex2fSUN
        private delegate void Color4ubVertex2fSUNDel(byte  r, byte  g, byte  b, byte  a, float  x, float  y); private static Color4ubVertex2fSUNDel Color4ubVertex2fSUNPtr;
        
        // glColor4ubVertex2fvSUN
        private delegate void Color4ubVertex2fvSUNDel(byte[]  c, float[]  v); private static Color4ubVertex2fvSUNDel Color4ubVertex2fvSUNPtr;
        
        // glColor4ubVertex3fSUN
        private delegate void Color4ubVertex3fSUNDel(byte  r, byte  g, byte  b, byte  a, float  x, float  y, float  z); private static Color4ubVertex3fSUNDel Color4ubVertex3fSUNPtr;
        
        // glColor4ubVertex3fvSUN
        private delegate void Color4ubVertex3fvSUNDel(byte[]  c, float[]  v); private static Color4ubVertex3fvSUNDel Color4ubVertex3fvSUNPtr;
        
        // glColor4ubv
        private delegate void Color4ubvDel(byte[] /*ColorUB*/  v); private static Color4ubvDel Color4ubvPtr;
        
        // glColor4ui
        private delegate void Color4uiDel(uint /*ColorUI*/  red, uint /*ColorUI*/  green, uint /*ColorUI*/  blue, uint /*ColorUI*/  alpha); private static Color4uiDel Color4uiPtr;
        
        // glColor4uiv
        private delegate void Color4uivDel(uint[] /*ColorUI*/  v); private static Color4uivDel Color4uivPtr;
        
        // glColor4us
        private delegate void Color4usDel(ushort /*ColorUS*/  red, ushort /*ColorUS*/  green, ushort /*ColorUS*/  blue, ushort /*ColorUS*/  alpha); private static Color4usDel Color4usPtr;
        
        // glColor4usv
        private delegate void Color4usvDel(ushort[] /*ColorUS*/  v); private static Color4usvDel Color4usvPtr;
        
        // glColor4x
        private delegate void Color4xDel(int  red, int  green, int  blue, int  alpha); private static Color4xDel Color4xPtr;
        
        // glColor4xOES
        private delegate void Color4xOESDel(int  red, int  green, int  blue, int  alpha); private static Color4xOESDel Color4xOESPtr;
        
        // glColor4xvOES
        private delegate void Color4xvOESDel(int[]  components); private static Color4xvOESDel Color4xvOESPtr;
        
        // glColorFormatNV
        private delegate void ColorFormatNVDel(int  size, uint  type, uint  stride); private static ColorFormatNVDel ColorFormatNVPtr;
        
        // glColorFragmentOp1ATI
        private delegate void ColorFragmentOp1ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMask, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod); private static ColorFragmentOp1ATIDel ColorFragmentOp1ATIPtr;
        
        // glColorFragmentOp2ATI
        private delegate void ColorFragmentOp2ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMask, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod, uint  arg2, uint  arg2Rep, uint  arg2Mod); private static ColorFragmentOp2ATIDel ColorFragmentOp2ATIPtr;
        
        // glColorFragmentOp3ATI
        private delegate void ColorFragmentOp3ATIDel(uint /*FragmentOpATI*/  op, uint  dst, uint  dstMask, uint  dstMod, uint  arg1, uint  arg1Rep, uint  arg1Mod, uint  arg2, uint  arg2Rep, uint  arg2Mod, uint  arg3, uint  arg3Rep, uint  arg3Mod); private static ColorFragmentOp3ATIDel ColorFragmentOp3ATIPtr;
        
        // glColorMask
        private delegate void ColorMaskDel(bool /*Boolean*/  red, bool /*Boolean*/  green, bool /*Boolean*/  blue, bool /*Boolean*/  alpha); private static ColorMaskDel ColorMaskPtr;
        
        // glColorMaskIndexedEXT
        private delegate void ColorMaskIndexedEXTDel(uint  index, bool /*Boolean*/  r, bool /*Boolean*/  g, bool /*Boolean*/  b, bool /*Boolean*/  a); private static ColorMaskIndexedEXTDel ColorMaskIndexedEXTPtr;
        
        // glColorMaski
        private delegate void ColorMaskiDel(uint  index, bool /*Boolean*/  r, bool /*Boolean*/  g, bool /*Boolean*/  b, bool /*Boolean*/  a); private static ColorMaskiDel ColorMaskiPtr;
        
        // glColorMaskiEXT
        private delegate void ColorMaskiEXTDel(uint  index, bool /*Boolean*/  r, bool /*Boolean*/  g, bool /*Boolean*/  b, bool /*Boolean*/  a); private static ColorMaskiEXTDel ColorMaskiEXTPtr;
        
        // glColorMaskiOES
        private delegate void ColorMaskiOESDel(uint  index, bool /*Boolean*/  r, bool /*Boolean*/  g, bool /*Boolean*/  b, bool /*Boolean*/  a); private static ColorMaskiOESDel ColorMaskiOESPtr;
        
        // glColorMaterial
        private delegate void ColorMaterialDel(uint /*MaterialFace*/  face, uint /*ColorMaterialParameter*/  mode); private static ColorMaterialDel ColorMaterialPtr;
        
        // glColorP3ui
        private delegate void ColorP3uiDel(uint /*ColorPointerType*/  type, uint  color); private static ColorP3uiDel ColorP3uiPtr;
        
        // glColorP3uiv
        private delegate void ColorP3uivDel(uint /*ColorPointerType*/  type, uint[]  color); private static ColorP3uivDel ColorP3uivPtr;
        
        // glColorP4ui
        private delegate void ColorP4uiDel(uint /*ColorPointerType*/  type, uint  color); private static ColorP4uiDel ColorP4uiPtr;
        
        // glColorP4uiv
        private delegate void ColorP4uivDel(uint /*ColorPointerType*/  type, uint[]  color); private static ColorP4uivDel ColorP4uivPtr;
        
        // glColorPointer
        private delegate void ColorPointerDel(int  size, uint /*ColorPointerType*/  type, uint  stride, IntPtr  pointer); private static ColorPointerDel ColorPointerPtr;
        
        // glColorPointerEXT
        private delegate void ColorPointerEXTDel(int  size, uint /*ColorPointerType*/  type, uint  stride, uint  count, IntPtr  pointer); private static ColorPointerEXTDel ColorPointerEXTPtr;
        
        // glColorPointerListIBM
        private delegate void ColorPointerListIBMDel(int  size, uint /*ColorPointerType*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static ColorPointerListIBMDel ColorPointerListIBMPtr;
        
        // glColorPointervINTEL
        private delegate void ColorPointervINTELDel(int  size, uint /*VertexPointerType*/  type, IntPtr  pointer); private static ColorPointervINTELDel ColorPointervINTELPtr;
        
        // glColorSubTable
        private delegate void ColorSubTableDel(uint /*ColorTableTarget*/  target, uint  start, uint  count, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ColorSubTableDel ColorSubTablePtr;
        
        // glColorSubTableEXT
        private delegate void ColorSubTableEXTDel(uint /*ColorTableTarget*/  target, uint  start, uint  count, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static ColorSubTableEXTDel ColorSubTableEXTPtr;
        
        // glColorTable
        private delegate void ColorTableDel(uint /*ColorTableTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  table); private static ColorTableDel ColorTablePtr;
        
        // glColorTableEXT
        private delegate void ColorTableEXTDel(uint /*ColorTableTarget*/  target, uint /*InternalFormat*/  internalFormat, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  table); private static ColorTableEXTDel ColorTableEXTPtr;
        
        // glColorTableParameterfv
        private delegate void ColorTableParameterfvDel(uint /*ColorTableTarget*/  target, uint /*ColorTableParameterPNameSGI*/  pname, float[] /*CheckedFloat32*/  parameters); private static ColorTableParameterfvDel ColorTableParameterfvPtr;
        
        // glColorTableParameterfvSGI
        private delegate void ColorTableParameterfvSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*ColorTableParameterPNameSGI*/  pname, float[] /*CheckedFloat32*/  parameters); private static ColorTableParameterfvSGIDel ColorTableParameterfvSGIPtr;
        
        // glColorTableParameteriv
        private delegate void ColorTableParameterivDel(uint /*ColorTableTarget*/  target, uint /*ColorTableParameterPNameSGI*/  pname, int[] /*CheckedInt32*/  parameters); private static ColorTableParameterivDel ColorTableParameterivPtr;
        
        // glColorTableParameterivSGI
        private delegate void ColorTableParameterivSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*ColorTableParameterPNameSGI*/  pname, int[] /*CheckedInt32*/  parameters); private static ColorTableParameterivSGIDel ColorTableParameterivSGIPtr;
        
        // glColorTableSGI
        private delegate void ColorTableSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  table); private static ColorTableSGIDel ColorTableSGIPtr;
        
        // glCombinerInputNV
        private delegate void CombinerInputNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerVariableNV*/  variable, uint /*CombinerRegisterNV*/  input, uint /*CombinerMappingNV*/  mapping, uint /*CombinerComponentUsageNV*/  componentUsage); private static CombinerInputNVDel CombinerInputNVPtr;
        
        // glCombinerOutputNV
        private delegate void CombinerOutputNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerRegisterNV*/  abOutput, uint /*CombinerRegisterNV*/  cdOutput, uint /*CombinerRegisterNV*/  sumOutput, uint /*CombinerScaleNV*/  scale, uint /*CombinerBiasNV*/  bias, bool /*Boolean*/  abDotProduct, bool /*Boolean*/  cdDotProduct, bool /*Boolean*/  muxSum); private static CombinerOutputNVDel CombinerOutputNVPtr;
        
        // glCombinerParameterfNV
        private delegate void CombinerParameterfNVDel(uint /*CombinerParameterNV*/  pname, float  param); private static CombinerParameterfNVDel CombinerParameterfNVPtr;
        
        // glCombinerParameterfvNV
        private delegate void CombinerParameterfvNVDel(uint /*CombinerParameterNV*/  pname, float[] /*CheckedFloat32*/  parameters); private static CombinerParameterfvNVDel CombinerParameterfvNVPtr;
        
        // glCombinerParameteriNV
        private delegate void CombinerParameteriNVDel(uint /*CombinerParameterNV*/  pname, int  param); private static CombinerParameteriNVDel CombinerParameteriNVPtr;
        
        // glCombinerParameterivNV
        private delegate void CombinerParameterivNVDel(uint /*CombinerParameterNV*/  pname, int[] /*CheckedInt32*/  parameters); private static CombinerParameterivNVDel CombinerParameterivNVPtr;
        
        // glCombinerStageParameterfvNV
        private delegate void CombinerStageParameterfvNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerParameterNV*/  pname, float[] /*CheckedFloat32*/  parameters); private static CombinerStageParameterfvNVDel CombinerStageParameterfvNVPtr;
        
        // glCommandListSegmentsNV
        private delegate void CommandListSegmentsNVDel(uint  list, uint  segments); private static CommandListSegmentsNVDel CommandListSegmentsNVPtr;
        
        // glCompileCommandListNV
        private delegate void CompileCommandListNVDel(uint  list); private static CompileCommandListNVDel CompileCommandListNVPtr;
        
        // glCompileShader
        private delegate void CompileShaderDel(uint  shader); private static CompileShaderDel CompileShaderPtr;
        
        // glCompileShaderARB
        private delegate void CompileShaderARBDel(IntPtr /*handleARB*/  shaderObj); private static CompileShaderARBDel CompileShaderARBPtr;
        
        // glCompileShaderIncludeARB
        private delegate void CompileShaderIncludeARBDel(uint  shader, uint  count, string  path, int[]  length); private static CompileShaderIncludeARBDel CompileShaderIncludeARBPtr;
        
        // glCompressedMultiTexImage1DEXT
        private delegate void CompressedMultiTexImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedMultiTexImage1DEXTDel CompressedMultiTexImage1DEXTPtr;
        
        // glCompressedMultiTexImage2DEXT
        private delegate void CompressedMultiTexImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedMultiTexImage2DEXTDel CompressedMultiTexImage2DEXTPtr;
        
        // glCompressedMultiTexImage3DEXT
        private delegate void CompressedMultiTexImage3DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedMultiTexImage3DEXTDel CompressedMultiTexImage3DEXTPtr;
        
        // glCompressedMultiTexSubImage1DEXT
        private delegate void CompressedMultiTexSubImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedMultiTexSubImage1DEXTDel CompressedMultiTexSubImage1DEXTPtr;
        
        // glCompressedMultiTexSubImage2DEXT
        private delegate void CompressedMultiTexSubImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedMultiTexSubImage2DEXTDel CompressedMultiTexSubImage2DEXTPtr;
        
        // glCompressedMultiTexSubImage3DEXT
        private delegate void CompressedMultiTexSubImage3DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedMultiTexSubImage3DEXTDel CompressedMultiTexSubImage3DEXTPtr;
        
        // glCompressedTexImage1D
        private delegate void CompressedTexImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage1DDel CompressedTexImage1DPtr;
        
        // glCompressedTexImage1DARB
        private delegate void CompressedTexImage1DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage1DARBDel CompressedTexImage1DARBPtr;
        
        // glCompressedTexImage2D
        private delegate void CompressedTexImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage2DDel CompressedTexImage2DPtr;
        
        // glCompressedTexImage2DARB
        private delegate void CompressedTexImage2DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage2DARBDel CompressedTexImage2DARBPtr;
        
        // glCompressedTexImage3D
        private delegate void CompressedTexImage3DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage3DDel CompressedTexImage3DPtr;
        
        // glCompressedTexImage3DARB
        private delegate void CompressedTexImage3DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexImage3DARBDel CompressedTexImage3DARBPtr;
        
        // glCompressedTexImage3DOES
        private delegate void CompressedTexImage3DOESDel(uint /*TextureTarget*/  target, int  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int  border, uint  imageSize, IntPtr  data); private static CompressedTexImage3DOESDel CompressedTexImage3DOESPtr;
        
        // glCompressedTexSubImage1D
        private delegate void CompressedTexSubImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage1DDel CompressedTexSubImage1DPtr;
        
        // glCompressedTexSubImage1DARB
        private delegate void CompressedTexSubImage1DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage1DARBDel CompressedTexSubImage1DARBPtr;
        
        // glCompressedTexSubImage2D
        private delegate void CompressedTexSubImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage2DDel CompressedTexSubImage2DPtr;
        
        // glCompressedTexSubImage2DARB
        private delegate void CompressedTexSubImage2DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage2DARBDel CompressedTexSubImage2DARBPtr;
        
        // glCompressedTexSubImage3D
        private delegate void CompressedTexSubImage3DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage3DDel CompressedTexSubImage3DPtr;
        
        // glCompressedTexSubImage3DARB
        private delegate void CompressedTexSubImage3DARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr /*CompressedTextureARB*/  data); private static CompressedTexSubImage3DARBDel CompressedTexSubImage3DARBPtr;
        
        // glCompressedTexSubImage3DOES
        private delegate void CompressedTexSubImage3DOESDel(uint /*TextureTarget*/  target, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  data); private static CompressedTexSubImage3DOESDel CompressedTexSubImage3DOESPtr;
        
        // glCompressedTextureImage1DEXT
        private delegate void CompressedTextureImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedTextureImage1DEXTDel CompressedTextureImage1DEXTPtr;
        
        // glCompressedTextureImage2DEXT
        private delegate void CompressedTextureImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedTextureImage2DEXTDel CompressedTextureImage2DEXTPtr;
        
        // glCompressedTextureImage3DEXT
        private delegate void CompressedTextureImage3DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint  imageSize, IntPtr  bits); private static CompressedTextureImage3DEXTDel CompressedTextureImage3DEXTPtr;
        
        // glCompressedTextureSubImage1D
        private delegate void CompressedTextureSubImage1DDel(uint  texture, int  level, int  xoffset, uint  width, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  data); private static CompressedTextureSubImage1DDel CompressedTextureSubImage1DPtr;
        
        // glCompressedTextureSubImage1DEXT
        private delegate void CompressedTextureSubImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedTextureSubImage1DEXTDel CompressedTextureSubImage1DEXTPtr;
        
        // glCompressedTextureSubImage2D
        private delegate void CompressedTextureSubImage2DDel(uint  texture, int  level, int  xoffset, int  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  data); private static CompressedTextureSubImage2DDel CompressedTextureSubImage2DPtr;
        
        // glCompressedTextureSubImage2DEXT
        private delegate void CompressedTextureSubImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedTextureSubImage2DEXTDel CompressedTextureSubImage2DEXTPtr;
        
        // glCompressedTextureSubImage3D
        private delegate void CompressedTextureSubImage3DDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  data); private static CompressedTextureSubImage3DDel CompressedTextureSubImage3DPtr;
        
        // glCompressedTextureSubImage3DEXT
        private delegate void CompressedTextureSubImage3DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint  imageSize, IntPtr  bits); private static CompressedTextureSubImage3DEXTDel CompressedTextureSubImage3DEXTPtr;
        
        // glConservativeRasterParameterfNV
        private delegate void ConservativeRasterParameterfNVDel(uint  pname, float  value); private static ConservativeRasterParameterfNVDel ConservativeRasterParameterfNVPtr;
        
        // glConservativeRasterParameteriNV
        private delegate void ConservativeRasterParameteriNVDel(uint  pname, int  param); private static ConservativeRasterParameteriNVDel ConservativeRasterParameteriNVPtr;
        
        // glConvolutionFilter1D
        private delegate void ConvolutionFilter1DDel(uint /*ConvolutionTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static ConvolutionFilter1DDel ConvolutionFilter1DPtr;
        
        // glConvolutionFilter1DEXT
        private delegate void ConvolutionFilter1DEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static ConvolutionFilter1DEXTDel ConvolutionFilter1DEXTPtr;
        
        // glConvolutionFilter2D
        private delegate void ConvolutionFilter2DDel(uint /*ConvolutionTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static ConvolutionFilter2DDel ConvolutionFilter2DPtr;
        
        // glConvolutionFilter2DEXT
        private delegate void ConvolutionFilter2DEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static ConvolutionFilter2DEXTDel ConvolutionFilter2DEXTPtr;
        
        // glConvolutionParameterf
        private delegate void ConvolutionParameterfDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, float /*CheckedFloat32*/  parameters); private static ConvolutionParameterfDel ConvolutionParameterfPtr;
        
        // glConvolutionParameterfEXT
        private delegate void ConvolutionParameterfEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, float /*CheckedFloat32*/  parameters); private static ConvolutionParameterfEXTDel ConvolutionParameterfEXTPtr;
        
        // glConvolutionParameterfv
        private delegate void ConvolutionParameterfvDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, float[] /*CheckedFloat32*/  parameters); private static ConvolutionParameterfvDel ConvolutionParameterfvPtr;
        
        // glConvolutionParameterfvEXT
        private delegate void ConvolutionParameterfvEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, float[] /*CheckedFloat32*/  parameters); private static ConvolutionParameterfvEXTDel ConvolutionParameterfvEXTPtr;
        
        // glConvolutionParameteri
        private delegate void ConvolutionParameteriDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, int /*CheckedInt32*/  parameters); private static ConvolutionParameteriDel ConvolutionParameteriPtr;
        
        // glConvolutionParameteriEXT
        private delegate void ConvolutionParameteriEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, int /*CheckedInt32*/  parameters); private static ConvolutionParameteriEXTDel ConvolutionParameteriEXTPtr;
        
        // glConvolutionParameteriv
        private delegate void ConvolutionParameterivDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, int[] /*CheckedInt32*/  parameters); private static ConvolutionParameterivDel ConvolutionParameterivPtr;
        
        // glConvolutionParameterivEXT
        private delegate void ConvolutionParameterivEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, int[] /*CheckedInt32*/  parameters); private static ConvolutionParameterivEXTDel ConvolutionParameterivEXTPtr;
        
        // glConvolutionParameterxOES
        private delegate void ConvolutionParameterxOESDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, int  param); private static ConvolutionParameterxOESDel ConvolutionParameterxOESPtr;
        
        // glConvolutionParameterxvOES
        private delegate void ConvolutionParameterxvOESDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, int[]  parameters); private static ConvolutionParameterxvOESDel ConvolutionParameterxvOESPtr;
        
        // glCopyBufferSubData
        private delegate void CopyBufferSubDataDel(uint /*CopyBufferSubDataTarget*/  readTarget, uint /*CopyBufferSubDataTarget*/  writeTarget, IntPtr /*BufferOffset*/  readOffset, IntPtr /*BufferOffset*/  writeOffset, IntPtr /*BufferSize*/  size); private static CopyBufferSubDataDel CopyBufferSubDataPtr;
        
        // glCopyBufferSubDataNV
        private delegate void CopyBufferSubDataNVDel(uint /*CopyBufferSubDataTarget*/  readTarget, uint /*CopyBufferSubDataTarget*/  writeTarget, IntPtr /*BufferOffset*/  readOffset, IntPtr /*BufferOffset*/  writeOffset, IntPtr /*BufferSize*/  size); private static CopyBufferSubDataNVDel CopyBufferSubDataNVPtr;
        
        // glCopyColorSubTable
        private delegate void CopyColorSubTableDel(uint /*ColorTableTarget*/  target, uint  start, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyColorSubTableDel CopyColorSubTablePtr;
        
        // glCopyColorSubTableEXT
        private delegate void CopyColorSubTableEXTDel(uint /*ColorTableTarget*/  target, uint  start, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyColorSubTableEXTDel CopyColorSubTableEXTPtr;
        
        // glCopyColorTable
        private delegate void CopyColorTableDel(uint /*ColorTableTarget*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyColorTableDel CopyColorTablePtr;
        
        // glCopyColorTableSGI
        private delegate void CopyColorTableSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyColorTableSGIDel CopyColorTableSGIPtr;
        
        // glCopyConvolutionFilter1D
        private delegate void CopyConvolutionFilter1DDel(uint /*ConvolutionTarget*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyConvolutionFilter1DDel CopyConvolutionFilter1DPtr;
        
        // glCopyConvolutionFilter1DEXT
        private delegate void CopyConvolutionFilter1DEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyConvolutionFilter1DEXTDel CopyConvolutionFilter1DEXTPtr;
        
        // glCopyConvolutionFilter2D
        private delegate void CopyConvolutionFilter2DDel(uint /*ConvolutionTarget*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyConvolutionFilter2DDel CopyConvolutionFilter2DPtr;
        
        // glCopyConvolutionFilter2DEXT
        private delegate void CopyConvolutionFilter2DEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyConvolutionFilter2DEXTDel CopyConvolutionFilter2DEXTPtr;
        
        // glCopyImageSubData
        private delegate void CopyImageSubDataDel(uint  srcName, uint /*CopyImageSubDataTarget*/  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint /*CopyImageSubDataTarget*/  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  srcWidth, uint  srcHeight, uint  srcDepth); private static CopyImageSubDataDel CopyImageSubDataPtr;
        
        // glCopyImageSubDataEXT
        private delegate void CopyImageSubDataEXTDel(uint  srcName, uint /*CopyBufferSubDataTarget*/  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint /*CopyBufferSubDataTarget*/  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  srcWidth, uint  srcHeight, uint  srcDepth); private static CopyImageSubDataEXTDel CopyImageSubDataEXTPtr;
        
        // glCopyImageSubDataNV
        private delegate void CopyImageSubDataNVDel(uint  srcName, uint /*CopyBufferSubDataTarget*/  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint /*CopyBufferSubDataTarget*/  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  width, uint  height, uint  depth); private static CopyImageSubDataNVDel CopyImageSubDataNVPtr;
        
        // glCopyImageSubDataOES
        private delegate void CopyImageSubDataOESDel(uint  srcName, uint /*CopyBufferSubDataTarget*/  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint /*CopyBufferSubDataTarget*/  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  srcWidth, uint  srcHeight, uint  srcDepth); private static CopyImageSubDataOESDel CopyImageSubDataOESPtr;
        
        // glCopyMultiTexImage1DEXT
        private delegate void CopyMultiTexImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, int /*CheckedInt32*/  border); private static CopyMultiTexImage1DEXTDel CopyMultiTexImage1DEXTPtr;
        
        // glCopyMultiTexImage2DEXT
        private delegate void CopyMultiTexImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, int /*CheckedInt32*/  border); private static CopyMultiTexImage2DEXTDel CopyMultiTexImage2DEXTPtr;
        
        // glCopyMultiTexSubImage1DEXT
        private delegate void CopyMultiTexSubImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyMultiTexSubImage1DEXTDel CopyMultiTexSubImage1DEXTPtr;
        
        // glCopyMultiTexSubImage2DEXT
        private delegate void CopyMultiTexSubImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyMultiTexSubImage2DEXTDel CopyMultiTexSubImage2DEXTPtr;
        
        // glCopyMultiTexSubImage3DEXT
        private delegate void CopyMultiTexSubImage3DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyMultiTexSubImage3DEXTDel CopyMultiTexSubImage3DEXTPtr;
        
        // glCopyNamedBufferSubData
        private delegate void CopyNamedBufferSubDataDel(uint  readBuffer, uint  writeBuffer, IntPtr  readOffset, IntPtr  writeOffset, IntPtr /*BufferSize*/  size); private static CopyNamedBufferSubDataDel CopyNamedBufferSubDataPtr;
        
        // glCopyPathNV
        private delegate void CopyPathNVDel(uint /*Path*/  resultPath, uint /*Path*/  srcPath); private static CopyPathNVDel CopyPathNVPtr;
        
        // glCopyPixels
        private delegate void CopyPixelsDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, uint /*PixelCopyType*/  type); private static CopyPixelsDel CopyPixelsPtr;
        
        // glCopyTexImage1D
        private delegate void CopyTexImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, int /*CheckedInt32*/  border); private static CopyTexImage1DDel CopyTexImage1DPtr;
        
        // glCopyTexImage1DEXT
        private delegate void CopyTexImage1DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, int /*CheckedInt32*/  border); private static CopyTexImage1DEXTDel CopyTexImage1DEXTPtr;
        
        // glCopyTexImage2D
        private delegate void CopyTexImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, int /*CheckedInt32*/  border); private static CopyTexImage2DDel CopyTexImage2DPtr;
        
        // glCopyTexImage2DEXT
        private delegate void CopyTexImage2DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, int /*CheckedInt32*/  border); private static CopyTexImage2DEXTDel CopyTexImage2DEXTPtr;
        
        // glCopyTexSubImage1D
        private delegate void CopyTexSubImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyTexSubImage1DDel CopyTexSubImage1DPtr;
        
        // glCopyTexSubImage1DEXT
        private delegate void CopyTexSubImage1DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyTexSubImage1DEXTDel CopyTexSubImage1DEXTPtr;
        
        // glCopyTexSubImage2D
        private delegate void CopyTexSubImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTexSubImage2DDel CopyTexSubImage2DPtr;
        
        // glCopyTexSubImage2DEXT
        private delegate void CopyTexSubImage2DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTexSubImage2DEXTDel CopyTexSubImage2DEXTPtr;
        
        // glCopyTexSubImage3D
        private delegate void CopyTexSubImage3DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTexSubImage3DDel CopyTexSubImage3DPtr;
        
        // glCopyTexSubImage3DEXT
        private delegate void CopyTexSubImage3DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTexSubImage3DEXTDel CopyTexSubImage3DEXTPtr;
        
        // glCopyTexSubImage3DOES
        private delegate void CopyTexSubImage3DOESDel(uint  target, int  level, int  xoffset, int  yoffset, int  zoffset, int  x, int  y, uint  width, uint  height); private static CopyTexSubImage3DOESDel CopyTexSubImage3DOESPtr;
        
        // glCopyTextureImage1DEXT
        private delegate void CopyTextureImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, int /*CheckedInt32*/  border); private static CopyTextureImage1DEXTDel CopyTextureImage1DEXTPtr;
        
        // glCopyTextureImage2DEXT
        private delegate void CopyTextureImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, int /*CheckedInt32*/  border); private static CopyTextureImage2DEXTDel CopyTextureImage2DEXTPtr;
        
        // glCopyTextureLevelsAPPLE
        private delegate void CopyTextureLevelsAPPLEDel(uint  destinationTexture, uint  sourceTexture, int  sourceBaseLevel, uint  sourceLevelCount); private static CopyTextureLevelsAPPLEDel CopyTextureLevelsAPPLEPtr;
        
        // glCopyTextureSubImage1D
        private delegate void CopyTextureSubImage1DDel(uint  texture, int  level, int  xoffset, int  x, int  y, uint  width); private static CopyTextureSubImage1DDel CopyTextureSubImage1DPtr;
        
        // glCopyTextureSubImage1DEXT
        private delegate void CopyTextureSubImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width); private static CopyTextureSubImage1DEXTDel CopyTextureSubImage1DEXTPtr;
        
        // glCopyTextureSubImage2D
        private delegate void CopyTextureSubImage2DDel(uint  texture, int  level, int  xoffset, int  yoffset, int  x, int  y, uint  width, uint  height); private static CopyTextureSubImage2DDel CopyTextureSubImage2DPtr;
        
        // glCopyTextureSubImage2DEXT
        private delegate void CopyTextureSubImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTextureSubImage2DEXTDel CopyTextureSubImage2DEXTPtr;
        
        // glCopyTextureSubImage3D
        private delegate void CopyTextureSubImage3DDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, int  x, int  y, uint  width, uint  height); private static CopyTextureSubImage3DDel CopyTextureSubImage3DPtr;
        
        // glCopyTextureSubImage3DEXT
        private delegate void CopyTextureSubImage3DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static CopyTextureSubImage3DEXTDel CopyTextureSubImage3DEXTPtr;
        
        // glCoverFillPathInstancedNV
        private delegate void CoverFillPathInstancedNVDel(uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, uint /*PathCoverMode*/  coverMode, uint /*PathTransformType*/  transformType, float[]  transformValues); private static CoverFillPathInstancedNVDel CoverFillPathInstancedNVPtr;
        
        // glCoverFillPathNV
        private delegate void CoverFillPathNVDel(uint /*Path*/  path, uint /*PathCoverMode*/  coverMode); private static CoverFillPathNVDel CoverFillPathNVPtr;
        
        // glCoverStrokePathInstancedNV
        private delegate void CoverStrokePathInstancedNVDel(uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, uint /*PathCoverMode*/  coverMode, uint /*PathTransformType*/  transformType, float[]  transformValues); private static CoverStrokePathInstancedNVDel CoverStrokePathInstancedNVPtr;
        
        // glCoverStrokePathNV
        private delegate void CoverStrokePathNVDel(uint /*Path*/  path, uint /*PathCoverMode*/  coverMode); private static CoverStrokePathNVDel CoverStrokePathNVPtr;
        
        // glCoverageMaskNV
        private delegate void CoverageMaskNVDel(bool /*Boolean*/  mask); private static CoverageMaskNVDel CoverageMaskNVPtr;
        
        // glCoverageModulationNV
        private delegate void CoverageModulationNVDel(uint  components); private static CoverageModulationNVDel CoverageModulationNVPtr;
        
        // glCoverageModulationTableNV
        private delegate void CoverageModulationTableNVDel(uint  n, float[]  v); private static CoverageModulationTableNVDel CoverageModulationTableNVPtr;
        
        // glCoverageOperationNV
        private delegate void CoverageOperationNVDel(uint  operation); private static CoverageOperationNVDel CoverageOperationNVPtr;
        
        // glCreateBuffers
        private delegate void CreateBuffersDel(uint  n, uint[]  buffers); private static CreateBuffersDel CreateBuffersPtr;
        
        // glCreateCommandListsNV
        private delegate void CreateCommandListsNVDel(uint  n, uint[]  lists); private static CreateCommandListsNVDel CreateCommandListsNVPtr;
        
        // glCreateFramebuffers
        private delegate void CreateFramebuffersDel(uint  n, uint[]  framebuffers); private static CreateFramebuffersDel CreateFramebuffersPtr;
        
        // glCreateMemoryObjectsEXT
        private delegate void CreateMemoryObjectsEXTDel(uint  n, uint[]  memoryObjects); private static CreateMemoryObjectsEXTDel CreateMemoryObjectsEXTPtr;
        
        // glCreatePerfQueryINTEL
        private delegate void CreatePerfQueryINTELDel(uint  queryId, uint[]  queryHandle); private static CreatePerfQueryINTELDel CreatePerfQueryINTELPtr;
        
        // glCreateProgram
        private delegate uint CreateProgramDel(); private static CreateProgramDel CreateProgramPtr;
        
        // glCreateProgramObjectARB
        private delegate IntPtr /*handleARB*/ CreateProgramObjectARBDel(); private static CreateProgramObjectARBDel CreateProgramObjectARBPtr;
        
        // glCreateProgramPipelines
        private delegate void CreateProgramPipelinesDel(uint  n, uint[]  pipelines); private static CreateProgramPipelinesDel CreateProgramPipelinesPtr;
        
        // glCreateProgressFenceNVX
        private delegate uint CreateProgressFenceNVXDel(); private static CreateProgressFenceNVXDel CreateProgressFenceNVXPtr;
        
        // glCreateQueries
        private delegate void CreateQueriesDel(uint /*QueryTarget*/  target, uint  n, uint[]  ids); private static CreateQueriesDel CreateQueriesPtr;
        
        // glCreateRenderbuffers
        private delegate void CreateRenderbuffersDel(uint  n, uint[]  renderbuffers); private static CreateRenderbuffersDel CreateRenderbuffersPtr;
        
        // glCreateSamplers
        private delegate void CreateSamplersDel(uint  n, uint[]  samplers); private static CreateSamplersDel CreateSamplersPtr;
        
        // glCreateShader
        private delegate uint CreateShaderDel(uint /*ShaderType*/  type); private static CreateShaderDel CreateShaderPtr;
        
        // glCreateShaderObjectARB
        private delegate IntPtr /*handleARB*/ CreateShaderObjectARBDel(uint /*ShaderType*/  shaderType); private static CreateShaderObjectARBDel CreateShaderObjectARBPtr;
        
        // glCreateShaderProgramEXT
        private delegate uint CreateShaderProgramEXTDel(uint /*ShaderType*/  type, string  str); private static CreateShaderProgramEXTDel CreateShaderProgramEXTPtr;
        
        // glCreateShaderProgramv
        private delegate uint CreateShaderProgramvDel(uint /*ShaderType*/  type, uint  count, string  strings); private static CreateShaderProgramvDel CreateShaderProgramvPtr;
        
        // glCreateShaderProgramvEXT
        private delegate uint CreateShaderProgramvEXTDel(uint /*ShaderType*/  type, uint  count, string  strings); private static CreateShaderProgramvEXTDel CreateShaderProgramvEXTPtr;
        
        // glCreateStatesNV
        private delegate void CreateStatesNVDel(uint  n, uint[]  states); private static CreateStatesNVDel CreateStatesNVPtr;
        
        // glCreateSyncFromCLeventARB
        private delegate IntPtr /*sync*/ CreateSyncFromCLeventARBDel(IntPtr /*cl_context*/  context, IntPtr /*cl_event*/  evnt, uint  flags); private static CreateSyncFromCLeventARBDel CreateSyncFromCLeventARBPtr;
        
        // glCreateTextures
        private delegate void CreateTexturesDel(uint /*TextureTarget*/  target, uint  n, uint[]  textures); private static CreateTexturesDel CreateTexturesPtr;
        
        // glCreateTransformFeedbacks
        private delegate void CreateTransformFeedbacksDel(uint  n, uint[]  ids); private static CreateTransformFeedbacksDel CreateTransformFeedbacksPtr;
        
        // glCreateVertexArrays
        private delegate void CreateVertexArraysDel(uint  n, uint[]  arrays); private static CreateVertexArraysDel CreateVertexArraysPtr;
        
        // glCullFace
        private delegate void CullFaceDel(uint /*CullFaceMode*/  mode); private static CullFaceDel CullFacePtr;
        
        // glCullParameterdvEXT
        private delegate void CullParameterdvEXTDel(uint /*CullParameterEXT*/  pname, double[]  parameters); private static CullParameterdvEXTDel CullParameterdvEXTPtr;
        
        // glCullParameterfvEXT
        private delegate void CullParameterfvEXTDel(uint /*CullParameterEXT*/  pname, float[]  parameters); private static CullParameterfvEXTDel CullParameterfvEXTPtr;
        
        // glCurrentPaletteMatrixARB
        private delegate void CurrentPaletteMatrixARBDel(int  index); private static CurrentPaletteMatrixARBDel CurrentPaletteMatrixARBPtr;
        
        // glCurrentPaletteMatrixOES
        private delegate void CurrentPaletteMatrixOESDel(uint  matrixpaletteindex); private static CurrentPaletteMatrixOESDel CurrentPaletteMatrixOESPtr;
        
        // glDebugMessageCallback
        private delegate void DebugMessageCallbackDel(IntPtr /*GLDEBUGPROC*/  callback, IntPtr  userParam); private static DebugMessageCallbackDel DebugMessageCallbackPtr;
        
        // glDebugMessageCallbackAMD
        private delegate void DebugMessageCallbackAMDDel(IntPtr /*GLDEBUGPROC*/  callback, IntPtr  userParam); private static DebugMessageCallbackAMDDel DebugMessageCallbackAMDPtr;
        
        // glDebugMessageCallbackARB
        private delegate void DebugMessageCallbackARBDel(IntPtr /*GLDEBUGPROC*/  callback, IntPtr  userParam); private static DebugMessageCallbackARBDel DebugMessageCallbackARBPtr;
        
        // glDebugMessageCallbackKHR
        private delegate void DebugMessageCallbackKHRDel(IntPtr /*GLDEBUGPROC*/  callback, IntPtr  userParam); private static DebugMessageCallbackKHRDel DebugMessageCallbackKHRPtr;
        
        // glDebugMessageControl
        private delegate void DebugMessageControlDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint /*DebugSeverity*/  severity, uint  count, uint[]  ids, bool /*Boolean*/  enabled); private static DebugMessageControlDel DebugMessageControlPtr;
        
        // glDebugMessageControlARB
        private delegate void DebugMessageControlARBDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint /*DebugSeverity*/  severity, uint  count, uint[]  ids, bool /*Boolean*/  enabled); private static DebugMessageControlARBDel DebugMessageControlARBPtr;
        
        // glDebugMessageControlKHR
        private delegate void DebugMessageControlKHRDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint /*DebugSeverity*/  severity, uint  count, uint[]  ids, bool /*Boolean*/  enabled); private static DebugMessageControlKHRDel DebugMessageControlKHRPtr;
        
        // glDebugMessageEnableAMD
        private delegate void DebugMessageEnableAMDDel(uint  category, uint /*DebugSeverity*/  severity, uint  count, uint[]  ids, bool /*Boolean*/  enabled); private static DebugMessageEnableAMDDel DebugMessageEnableAMDPtr;
        
        // glDebugMessageInsert
        private delegate void DebugMessageInsertDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint  id, uint /*DebugSeverity*/  severity, uint  length, string  buf); private static DebugMessageInsertDel DebugMessageInsertPtr;
        
        // glDebugMessageInsertAMD
        private delegate void DebugMessageInsertAMDDel(uint  category, uint /*DebugSeverity*/  severity, uint  id, uint  length, string  buf); private static DebugMessageInsertAMDDel DebugMessageInsertAMDPtr;
        
        // glDebugMessageInsertARB
        private delegate void DebugMessageInsertARBDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint  id, uint /*DebugSeverity*/  severity, uint  length, string  buf); private static DebugMessageInsertARBDel DebugMessageInsertARBPtr;
        
        // glDebugMessageInsertKHR
        private delegate void DebugMessageInsertKHRDel(uint /*DebugSource*/  source, uint /*DebugType*/  type, uint  id, uint /*DebugSeverity*/  severity, uint  length, string  buf); private static DebugMessageInsertKHRDel DebugMessageInsertKHRPtr;
        
        // glDeformSGIX
        private delegate void DeformSGIXDel(uint /*FfdMaskSGIX*/  mask); private static DeformSGIXDel DeformSGIXPtr;
        
        // glDeformationMap3dSGIX
        private delegate void DeformationMap3dSGIXDel(uint /*FfdTargetSGIX*/  target, double /*CoordD*/  u1, double /*CoordD*/  u2, int  ustride, int /*CheckedInt32*/  uorder, double /*CoordD*/  v1, double /*CoordD*/  v2, int  vstride, int /*CheckedInt32*/  vorder, double /*CoordD*/  w1, double /*CoordD*/  w2, int  wstride, int /*CheckedInt32*/  worder, double[] /*CoordD*/  points); private static DeformationMap3dSGIXDel DeformationMap3dSGIXPtr;
        
        // glDeformationMap3fSGIX
        private delegate void DeformationMap3fSGIXDel(uint /*FfdTargetSGIX*/  target, float /*CoordF*/  u1, float /*CoordF*/  u2, int  ustride, int /*CheckedInt32*/  uorder, float /*CoordF*/  v1, float /*CoordF*/  v2, int  vstride, int /*CheckedInt32*/  vorder, float /*CoordF*/  w1, float /*CoordF*/  w2, int  wstride, int /*CheckedInt32*/  worder, float[] /*CoordF*/  points); private static DeformationMap3fSGIXDel DeformationMap3fSGIXPtr;
        
        // glDeleteAsyncMarkersSGIX
        private delegate void DeleteAsyncMarkersSGIXDel(uint  marker, uint  range); private static DeleteAsyncMarkersSGIXDel DeleteAsyncMarkersSGIXPtr;
        
        // glDeleteBuffers
        private delegate void DeleteBuffersDel(uint  n, uint[]  buffers); private static DeleteBuffersDel DeleteBuffersPtr;
        
        // glDeleteBuffersARB
        private delegate void DeleteBuffersARBDel(uint  n, uint[]  buffers); private static DeleteBuffersARBDel DeleteBuffersARBPtr;
        
        // glDeleteCommandListsNV
        private delegate void DeleteCommandListsNVDel(uint  n, uint[]  lists); private static DeleteCommandListsNVDel DeleteCommandListsNVPtr;
        
        // glDeleteFencesAPPLE
        private delegate void DeleteFencesAPPLEDel(uint  n, uint[] /*FenceNV*/  fences); private static DeleteFencesAPPLEDel DeleteFencesAPPLEPtr;
        
        // glDeleteFencesNV
        private delegate void DeleteFencesNVDel(uint  n, uint[] /*FenceNV*/  fences); private static DeleteFencesNVDel DeleteFencesNVPtr;
        
        // glDeleteFragmentShaderATI
        private delegate void DeleteFragmentShaderATIDel(uint  id); private static DeleteFragmentShaderATIDel DeleteFragmentShaderATIPtr;
        
        // glDeleteFramebuffers
        private delegate void DeleteFramebuffersDel(uint  n, uint[]  framebuffers); private static DeleteFramebuffersDel DeleteFramebuffersPtr;
        
        // glDeleteFramebuffersEXT
        private delegate void DeleteFramebuffersEXTDel(uint  n, uint[]  framebuffers); private static DeleteFramebuffersEXTDel DeleteFramebuffersEXTPtr;
        
        // glDeleteFramebuffersOES
        private delegate void DeleteFramebuffersOESDel(uint  n, uint[]  framebuffers); private static DeleteFramebuffersOESDel DeleteFramebuffersOESPtr;
        
        // glDeleteLists
        private delegate void DeleteListsDel(uint /*List*/  list, uint  range); private static DeleteListsDel DeleteListsPtr;
        
        // glDeleteMemoryObjectsEXT
        private delegate void DeleteMemoryObjectsEXTDel(uint  n, uint[]  memoryObjects); private static DeleteMemoryObjectsEXTDel DeleteMemoryObjectsEXTPtr;
        
        // glDeleteNamedStringARB
        private delegate void DeleteNamedStringARBDel(int  namelen, string  name); private static DeleteNamedStringARBDel DeleteNamedStringARBPtr;
        
        // glDeleteNamesAMD
        private delegate void DeleteNamesAMDDel(uint  identifier, uint  num, uint[]  names); private static DeleteNamesAMDDel DeleteNamesAMDPtr;
        
        // glDeleteObjectARB
        private delegate void DeleteObjectARBDel(IntPtr /*handleARB*/  obj); private static DeleteObjectARBDel DeleteObjectARBPtr;
        
        // glDeleteOcclusionQueriesNV
        private delegate void DeleteOcclusionQueriesNVDel(uint  n, uint[]  ids); private static DeleteOcclusionQueriesNVDel DeleteOcclusionQueriesNVPtr;
        
        // glDeletePathsNV
        private delegate void DeletePathsNVDel(uint /*Path*/  path, uint  range); private static DeletePathsNVDel DeletePathsNVPtr;
        
        // glDeletePerfMonitorsAMD
        private delegate void DeletePerfMonitorsAMDDel(uint  n, uint[]  monitors); private static DeletePerfMonitorsAMDDel DeletePerfMonitorsAMDPtr;
        
        // glDeletePerfQueryINTEL
        private delegate void DeletePerfQueryINTELDel(uint  queryHandle); private static DeletePerfQueryINTELDel DeletePerfQueryINTELPtr;
        
        // glDeleteProgram
        private delegate void DeleteProgramDel(uint  program); private static DeleteProgramDel DeleteProgramPtr;
        
        // glDeleteProgramPipelines
        private delegate void DeleteProgramPipelinesDel(uint  n, uint[]  pipelines); private static DeleteProgramPipelinesDel DeleteProgramPipelinesPtr;
        
        // glDeleteProgramPipelinesEXT
        private delegate void DeleteProgramPipelinesEXTDel(uint  n, uint[]  pipelines); private static DeleteProgramPipelinesEXTDel DeleteProgramPipelinesEXTPtr;
        
        // glDeleteProgramsARB
        private delegate void DeleteProgramsARBDel(uint  n, uint[]  programs); private static DeleteProgramsARBDel DeleteProgramsARBPtr;
        
        // glDeleteProgramsNV
        private delegate void DeleteProgramsNVDel(uint  n, uint[]  programs); private static DeleteProgramsNVDel DeleteProgramsNVPtr;
        
        // glDeleteQueries
        private delegate void DeleteQueriesDel(uint  n, uint[]  ids); private static DeleteQueriesDel DeleteQueriesPtr;
        
        // glDeleteQueriesARB
        private delegate void DeleteQueriesARBDel(uint  n, uint[]  ids); private static DeleteQueriesARBDel DeleteQueriesARBPtr;
        
        // glDeleteQueriesEXT
        private delegate void DeleteQueriesEXTDel(uint  n, uint[]  ids); private static DeleteQueriesEXTDel DeleteQueriesEXTPtr;
        
        // glDeleteQueryResourceTagNV
        private delegate void DeleteQueryResourceTagNVDel(uint  n, int[]  tagIds); private static DeleteQueryResourceTagNVDel DeleteQueryResourceTagNVPtr;
        
        // glDeleteRenderbuffers
        private delegate void DeleteRenderbuffersDel(uint  n, uint[]  renderbuffers); private static DeleteRenderbuffersDel DeleteRenderbuffersPtr;
        
        // glDeleteRenderbuffersEXT
        private delegate void DeleteRenderbuffersEXTDel(uint  n, uint[]  renderbuffers); private static DeleteRenderbuffersEXTDel DeleteRenderbuffersEXTPtr;
        
        // glDeleteRenderbuffersOES
        private delegate void DeleteRenderbuffersOESDel(uint  n, uint[]  renderbuffers); private static DeleteRenderbuffersOESDel DeleteRenderbuffersOESPtr;
        
        // glDeleteSamplers
        private delegate void DeleteSamplersDel(uint  count, uint[]  samplers); private static DeleteSamplersDel DeleteSamplersPtr;
        
        // glDeleteSemaphoresEXT
        private delegate void DeleteSemaphoresEXTDel(uint  n, uint[]  semaphores); private static DeleteSemaphoresEXTDel DeleteSemaphoresEXTPtr;
        
        // glDeleteShader
        private delegate void DeleteShaderDel(uint  shader); private static DeleteShaderDel DeleteShaderPtr;
        
        // glDeleteStatesNV
        private delegate void DeleteStatesNVDel(uint  n, uint[]  states); private static DeleteStatesNVDel DeleteStatesNVPtr;
        
        // glDeleteSync
        private delegate void DeleteSyncDel(IntPtr /*sync*/  sync); private static DeleteSyncDel DeleteSyncPtr;
        
        // glDeleteSyncAPPLE
        private delegate void DeleteSyncAPPLEDel(IntPtr  sync); private static DeleteSyncAPPLEDel DeleteSyncAPPLEPtr;
        
        // glDeleteTextures
        private delegate void DeleteTexturesDel(uint  n, uint[] /*Texture*/  textures); private static DeleteTexturesDel DeleteTexturesPtr;
        
        // glDeleteTexturesEXT
        private delegate void DeleteTexturesEXTDel(uint  n, uint[] /*Texture*/  textures); private static DeleteTexturesEXTDel DeleteTexturesEXTPtr;
        
        // glDeleteTransformFeedbacks
        private delegate void DeleteTransformFeedbacksDel(uint  n, uint[]  ids); private static DeleteTransformFeedbacksDel DeleteTransformFeedbacksPtr;
        
        // glDeleteTransformFeedbacksNV
        private delegate void DeleteTransformFeedbacksNVDel(uint  n, uint[]  ids); private static DeleteTransformFeedbacksNVDel DeleteTransformFeedbacksNVPtr;
        
        // glDeleteVertexArrays
        private delegate void DeleteVertexArraysDel(uint  n, uint[]  arrays); private static DeleteVertexArraysDel DeleteVertexArraysPtr;
        
        // glDeleteVertexArraysAPPLE
        private delegate void DeleteVertexArraysAPPLEDel(uint  n, uint[]  arrays); private static DeleteVertexArraysAPPLEDel DeleteVertexArraysAPPLEPtr;
        
        // glDeleteVertexArraysOES
        private delegate void DeleteVertexArraysOESDel(uint  n, uint[]  arrays); private static DeleteVertexArraysOESDel DeleteVertexArraysOESPtr;
        
        // glDeleteVertexShaderEXT
        private delegate void DeleteVertexShaderEXTDel(uint  id); private static DeleteVertexShaderEXTDel DeleteVertexShaderEXTPtr;
        
        // glDepthBoundsEXT
        private delegate void DepthBoundsEXTDel(double /*ClampedFloat64*/  zmin, double /*ClampedFloat64*/  zmax); private static DepthBoundsEXTDel DepthBoundsEXTPtr;
        
        // glDepthBoundsdNV
        private delegate void DepthBoundsdNVDel(double  zmin, double  zmax); private static DepthBoundsdNVDel DepthBoundsdNVPtr;
        
        // glDepthFunc
        private delegate void DepthFuncDel(uint /*DepthFunction*/  func); private static DepthFuncDel DepthFuncPtr;
        
        // glDepthMask
        private delegate void DepthMaskDel(bool /*Boolean*/  flag); private static DepthMaskDel DepthMaskPtr;
        
        // glDepthRange
        private delegate void DepthRangeDel(double  n, double  f); private static DepthRangeDel DepthRangePtr;
        
        // glDepthRangeArraydvNV
        private delegate void DepthRangeArraydvNVDel(uint  first, uint  count, double[]  v); private static DepthRangeArraydvNVDel DepthRangeArraydvNVPtr;
        
        // glDepthRangeArrayfvNV
        private delegate void DepthRangeArrayfvNVDel(uint  first, uint  count, float[]  v); private static DepthRangeArrayfvNVDel DepthRangeArrayfvNVPtr;
        
        // glDepthRangeArrayfvOES
        private delegate void DepthRangeArrayfvOESDel(uint  first, uint  count, float[]  v); private static DepthRangeArrayfvOESDel DepthRangeArrayfvOESPtr;
        
        // glDepthRangeArrayv
        private delegate void DepthRangeArrayvDel(uint  first, uint  count, double[]  v); private static DepthRangeArrayvDel DepthRangeArrayvPtr;
        
        // glDepthRangeIndexed
        private delegate void DepthRangeIndexedDel(uint  index, double  n, double  f); private static DepthRangeIndexedDel DepthRangeIndexedPtr;
        
        // glDepthRangeIndexeddNV
        private delegate void DepthRangeIndexeddNVDel(uint  index, double  n, double  f); private static DepthRangeIndexeddNVDel DepthRangeIndexeddNVPtr;
        
        // glDepthRangeIndexedfNV
        private delegate void DepthRangeIndexedfNVDel(uint  index, float  n, float  f); private static DepthRangeIndexedfNVDel DepthRangeIndexedfNVPtr;
        
        // glDepthRangeIndexedfOES
        private delegate void DepthRangeIndexedfOESDel(uint  index, float  n, float  f); private static DepthRangeIndexedfOESDel DepthRangeIndexedfOESPtr;
        
        // glDepthRangedNV
        private delegate void DepthRangedNVDel(double  zNear, double  zFar); private static DepthRangedNVDel DepthRangedNVPtr;
        
        // glDepthRangef
        private delegate void DepthRangefDel(float  n, float  f); private static DepthRangefDel DepthRangefPtr;
        
        // glDepthRangefOES
        private delegate void DepthRangefOESDel(float /*ClampedFloat32*/  n, float /*ClampedFloat32*/  f); private static DepthRangefOESDel DepthRangefOESPtr;
        
        // glDepthRangex
        private delegate void DepthRangexDel(int  n, int  f); private static DepthRangexDel DepthRangexPtr;
        
        // glDepthRangexOES
        private delegate void DepthRangexOESDel(int /*ClampedFixed*/  n, int /*ClampedFixed*/  f); private static DepthRangexOESDel DepthRangexOESPtr;
        
        // glDetachObjectARB
        private delegate void DetachObjectARBDel(IntPtr /*handleARB*/  containerObj, IntPtr /*handleARB*/  attachedObj); private static DetachObjectARBDel DetachObjectARBPtr;
        
        // glDetachShader
        private delegate void DetachShaderDel(uint  program, uint  shader); private static DetachShaderDel DetachShaderPtr;
        
        // glDetailTexFuncSGIS
        private delegate void DetailTexFuncSGISDel(uint /*TextureTarget*/  target, uint  n, float[]  points); private static DetailTexFuncSGISDel DetailTexFuncSGISPtr;
        
        // glDisable
        private delegate void DisableDel(uint /*EnableCap*/  cap); private static DisableDel DisablePtr;
        
        // glDisableClientState
        private delegate void DisableClientStateDel(uint /*EnableCap*/  array); private static DisableClientStateDel DisableClientStatePtr;
        
        // glDisableClientStateIndexedEXT
        private delegate void DisableClientStateIndexedEXTDel(uint /*EnableCap*/  array, uint  index); private static DisableClientStateIndexedEXTDel DisableClientStateIndexedEXTPtr;
        
        // glDisableClientStateiEXT
        private delegate void DisableClientStateiEXTDel(uint /*EnableCap*/  array, uint  index); private static DisableClientStateiEXTDel DisableClientStateiEXTPtr;
        
        // glDisableDriverControlQCOM
        private delegate void DisableDriverControlQCOMDel(uint  driverControl); private static DisableDriverControlQCOMDel DisableDriverControlQCOMPtr;
        
        // glDisableIndexedEXT
        private delegate void DisableIndexedEXTDel(uint /*EnableCap*/  target, uint  index); private static DisableIndexedEXTDel DisableIndexedEXTPtr;
        
        // glDisableVariantClientStateEXT
        private delegate void DisableVariantClientStateEXTDel(uint  id); private static DisableVariantClientStateEXTDel DisableVariantClientStateEXTPtr;
        
        // glDisableVertexArrayAttrib
        private delegate void DisableVertexArrayAttribDel(uint  vaobj, uint  index); private static DisableVertexArrayAttribDel DisableVertexArrayAttribPtr;
        
        // glDisableVertexArrayAttribEXT
        private delegate void DisableVertexArrayAttribEXTDel(uint  vaobj, uint  index); private static DisableVertexArrayAttribEXTDel DisableVertexArrayAttribEXTPtr;
        
        // glDisableVertexArrayEXT
        private delegate void DisableVertexArrayEXTDel(uint  vaobj, uint /*EnableCap*/  array); private static DisableVertexArrayEXTDel DisableVertexArrayEXTPtr;
        
        // glDisableVertexAttribAPPLE
        private delegate void DisableVertexAttribAPPLEDel(uint  index, uint  pname); private static DisableVertexAttribAPPLEDel DisableVertexAttribAPPLEPtr;
        
        // glDisableVertexAttribArray
        private delegate void DisableVertexAttribArrayDel(uint  index); private static DisableVertexAttribArrayDel DisableVertexAttribArrayPtr;
        
        // glDisableVertexAttribArrayARB
        private delegate void DisableVertexAttribArrayARBDel(uint  index); private static DisableVertexAttribArrayARBDel DisableVertexAttribArrayARBPtr;
        
        // glDisablei
        private delegate void DisableiDel(uint /*EnableCap*/  target, uint  index); private static DisableiDel DisableiPtr;
        
        // glDisableiEXT
        private delegate void DisableiEXTDel(uint /*EnableCap*/  target, uint  index); private static DisableiEXTDel DisableiEXTPtr;
        
        // glDisableiNV
        private delegate void DisableiNVDel(uint /*EnableCap*/  target, uint  index); private static DisableiNVDel DisableiNVPtr;
        
        // glDisableiOES
        private delegate void DisableiOESDel(uint /*EnableCap*/  target, uint  index); private static DisableiOESDel DisableiOESPtr;
        
        // glDiscardFramebufferEXT
        private delegate void DiscardFramebufferEXTDel(uint /*FramebufferTarget*/  target, uint  numAttachments, uint[] /*InvalidateFramebufferAttachment*/  attachments); private static DiscardFramebufferEXTDel DiscardFramebufferEXTPtr;
        
        // glDispatchCompute
        private delegate void DispatchComputeDel(uint  num_groups_x, uint  num_groups_y, uint  num_groups_z); private static DispatchComputeDel DispatchComputePtr;
        
        // glDispatchComputeGroupSizeARB
        private delegate void DispatchComputeGroupSizeARBDel(uint  num_groups_x, uint  num_groups_y, uint  num_groups_z, uint  group_size_x, uint  group_size_y, uint  group_size_z); private static DispatchComputeGroupSizeARBDel DispatchComputeGroupSizeARBPtr;
        
        // glDispatchComputeIndirect
        private delegate void DispatchComputeIndirectDel(IntPtr /*BufferOffset*/  indirect); private static DispatchComputeIndirectDel DispatchComputeIndirectPtr;
        
        // glDrawArrays
        private delegate void DrawArraysDel(uint /*PrimitiveType*/  mode, int  first, uint  count); private static DrawArraysDel DrawArraysPtr;
        
        // glDrawArraysEXT
        private delegate void DrawArraysEXTDel(uint /*PrimitiveType*/  mode, int  first, uint  count); private static DrawArraysEXTDel DrawArraysEXTPtr;
        
        // glDrawArraysIndirect
        private delegate void DrawArraysIndirectDel(uint /*PrimitiveType*/  mode, IntPtr  indirect); private static DrawArraysIndirectDel DrawArraysIndirectPtr;
        
        // glDrawArraysInstanced
        private delegate void DrawArraysInstancedDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  instancecount); private static DrawArraysInstancedDel DrawArraysInstancedPtr;
        
        // glDrawArraysInstancedANGLE
        private delegate void DrawArraysInstancedANGLEDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  primcount); private static DrawArraysInstancedANGLEDel DrawArraysInstancedANGLEPtr;
        
        // glDrawArraysInstancedARB
        private delegate void DrawArraysInstancedARBDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  primcount); private static DrawArraysInstancedARBDel DrawArraysInstancedARBPtr;
        
        // glDrawArraysInstancedBaseInstance
        private delegate void DrawArraysInstancedBaseInstanceDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  instancecount, uint  baseinstance); private static DrawArraysInstancedBaseInstanceDel DrawArraysInstancedBaseInstancePtr;
        
        // glDrawArraysInstancedBaseInstanceEXT
        private delegate void DrawArraysInstancedBaseInstanceEXTDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  instancecount, uint  baseinstance); private static DrawArraysInstancedBaseInstanceEXTDel DrawArraysInstancedBaseInstanceEXTPtr;
        
        // glDrawArraysInstancedEXT
        // primcount should be renamed to instanceCount for OpenGL ES
        private delegate void DrawArraysInstancedEXTDel(uint /*PrimitiveType*/  mode, int  start, uint  count, uint  primcount); private static DrawArraysInstancedEXTDel DrawArraysInstancedEXTPtr;
        
        // glDrawArraysInstancedNV
        private delegate void DrawArraysInstancedNVDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  primcount); private static DrawArraysInstancedNVDel DrawArraysInstancedNVPtr;
        
        // glDrawBuffer
        private delegate void DrawBufferDel(uint /*DrawBufferMode*/  buf); private static DrawBufferDel DrawBufferPtr;
        
        // glDrawBuffers
        private delegate void DrawBuffersDel(uint  n, uint[] /*DrawBufferMode*/  bufs); private static DrawBuffersDel DrawBuffersPtr;
        
        // glDrawBuffersARB
        private delegate void DrawBuffersARBDel(uint  n, uint[] /*DrawBufferMode*/  bufs); private static DrawBuffersARBDel DrawBuffersARBPtr;
        
        // glDrawBuffersATI
        private delegate void DrawBuffersATIDel(uint  n, uint[] /*DrawBufferMode*/  bufs); private static DrawBuffersATIDel DrawBuffersATIPtr;
        
        // glDrawBuffersEXT
        private delegate void DrawBuffersEXTDel(uint  n, uint[]  bufs); private static DrawBuffersEXTDel DrawBuffersEXTPtr;
        
        // glDrawBuffersIndexedEXT
        private delegate void DrawBuffersIndexedEXTDel(int  n, uint[]  location, int[]  indices); private static DrawBuffersIndexedEXTDel DrawBuffersIndexedEXTPtr;
        
        // glDrawBuffersNV
        private delegate void DrawBuffersNVDel(uint  n, uint[]  bufs); private static DrawBuffersNVDel DrawBuffersNVPtr;
        
        // glDrawCommandsAddressNV
        private delegate void DrawCommandsAddressNVDel(uint  primitiveMode, ulong[]  indirects, uint[]  sizes, uint  count); private static DrawCommandsAddressNVDel DrawCommandsAddressNVPtr;
        
        // glDrawCommandsNV
        private delegate void DrawCommandsNVDel(uint  primitiveMode, uint  buffer, IntPtr[]  indirects, uint[]  sizes, uint  count); private static DrawCommandsNVDel DrawCommandsNVPtr;
        
        // glDrawCommandsStatesAddressNV
        private delegate void DrawCommandsStatesAddressNVDel(ulong[]  indirects, uint[]  sizes, uint[]  states, uint[]  fbos, uint  count); private static DrawCommandsStatesAddressNVDel DrawCommandsStatesAddressNVPtr;
        
        // glDrawCommandsStatesNV
        private delegate void DrawCommandsStatesNVDel(uint  buffer, IntPtr[]  indirects, uint[]  sizes, uint[]  states, uint[]  fbos, uint  count); private static DrawCommandsStatesNVDel DrawCommandsStatesNVPtr;
        
        // glDrawElementArrayAPPLE
        private delegate void DrawElementArrayAPPLEDel(uint /*PrimitiveType*/  mode, int  first, uint  count); private static DrawElementArrayAPPLEDel DrawElementArrayAPPLEPtr;
        
        // glDrawElementArrayATI
        private delegate void DrawElementArrayATIDel(uint /*PrimitiveType*/  mode, uint  count); private static DrawElementArrayATIDel DrawElementArrayATIPtr;
        
        // glDrawElements
        private delegate void DrawElementsDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices); private static DrawElementsDel DrawElementsPtr;
        
        // glDrawElementsBaseVertex
        private delegate void DrawElementsBaseVertexDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawElementsBaseVertexDel DrawElementsBaseVertexPtr;
        
        // glDrawElementsBaseVertexEXT
        private delegate void DrawElementsBaseVertexEXTDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawElementsBaseVertexEXTDel DrawElementsBaseVertexEXTPtr;
        
        // glDrawElementsBaseVertexOES
        private delegate void DrawElementsBaseVertexOESDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawElementsBaseVertexOESDel DrawElementsBaseVertexOESPtr;
        
        // glDrawElementsIndirect
        private delegate void DrawElementsIndirectDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect); private static DrawElementsIndirectDel DrawElementsIndirectPtr;
        
        // glDrawElementsInstanced
        private delegate void DrawElementsInstancedDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount); private static DrawElementsInstancedDel DrawElementsInstancedPtr;
        
        // glDrawElementsInstancedANGLE
        private delegate void DrawElementsInstancedANGLEDel(uint /*PrimitiveType*/  mode, uint  count, uint /*PrimitiveType*/  type, IntPtr  indices, uint  primcount); private static DrawElementsInstancedANGLEDel DrawElementsInstancedANGLEPtr;
        
        // glDrawElementsInstancedARB
        private delegate void DrawElementsInstancedARBDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  primcount); private static DrawElementsInstancedARBDel DrawElementsInstancedARBPtr;
        
        // glDrawElementsInstancedBaseInstance
        private delegate void DrawElementsInstancedBaseInstanceDel(uint /*PrimitiveType*/  mode, uint  count, uint /*PrimitiveType*/  type, IntPtr  indices, uint  instancecount, uint  baseinstance); private static DrawElementsInstancedBaseInstanceDel DrawElementsInstancedBaseInstancePtr;
        
        // glDrawElementsInstancedBaseInstanceEXT
        private delegate void DrawElementsInstancedBaseInstanceEXTDel(uint /*PrimitiveType*/  mode, uint  count, uint /*PrimitiveType*/  type, IntPtr  indices, uint  instancecount, uint  baseinstance); private static DrawElementsInstancedBaseInstanceEXTDel DrawElementsInstancedBaseInstanceEXTPtr;
        
        // glDrawElementsInstancedBaseVertex
        private delegate void DrawElementsInstancedBaseVertexDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount, int  basevertex); private static DrawElementsInstancedBaseVertexDel DrawElementsInstancedBaseVertexPtr;
        
        // glDrawElementsInstancedBaseVertexBaseInstance
        private delegate void DrawElementsInstancedBaseVertexBaseInstanceDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount, int  basevertex, uint  baseinstance); private static DrawElementsInstancedBaseVertexBaseInstanceDel DrawElementsInstancedBaseVertexBaseInstancePtr;
        
        // glDrawElementsInstancedBaseVertexBaseInstanceEXT
        private delegate void DrawElementsInstancedBaseVertexBaseInstanceEXTDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount, int  basevertex, uint  baseinstance); private static DrawElementsInstancedBaseVertexBaseInstanceEXTDel DrawElementsInstancedBaseVertexBaseInstanceEXTPtr;
        
        // glDrawElementsInstancedBaseVertexEXT
        private delegate void DrawElementsInstancedBaseVertexEXTDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount, int  basevertex); private static DrawElementsInstancedBaseVertexEXTDel DrawElementsInstancedBaseVertexEXTPtr;
        
        // glDrawElementsInstancedBaseVertexOES
        private delegate void DrawElementsInstancedBaseVertexOESDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  instancecount, int  basevertex); private static DrawElementsInstancedBaseVertexOESDel DrawElementsInstancedBaseVertexOESPtr;
        
        // glDrawElementsInstancedEXT
        // primcount should be renamed to instanceCount for OpenGL ES
        private delegate void DrawElementsInstancedEXTDel(uint /*PrimitiveType*/  mode, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  primcount); private static DrawElementsInstancedEXTDel DrawElementsInstancedEXTPtr;
        
        // glDrawElementsInstancedNV
        private delegate void DrawElementsInstancedNVDel(uint /*PrimitiveType*/  mode, uint  count, uint /*PrimitiveType*/  type, IntPtr  indices, uint  primcount); private static DrawElementsInstancedNVDel DrawElementsInstancedNVPtr;
        
        // glDrawMeshArraysSUN
        private delegate void DrawMeshArraysSUNDel(uint /*PrimitiveType*/  mode, int  first, uint  count, uint  width); private static DrawMeshArraysSUNDel DrawMeshArraysSUNPtr;
        
        // glDrawMeshTasksNV
        private delegate void DrawMeshTasksNVDel(uint  first, uint  count); private static DrawMeshTasksNVDel DrawMeshTasksNVPtr;
        
        // glDrawMeshTasksIndirectNV
        private delegate void DrawMeshTasksIndirectNVDel(IntPtr  indirect); private static DrawMeshTasksIndirectNVDel DrawMeshTasksIndirectNVPtr;
        
        // glDrawPixels
        private delegate void DrawPixelsDel(uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static DrawPixelsDel DrawPixelsPtr;
        
        // glDrawRangeElementArrayAPPLE
        private delegate void DrawRangeElementArrayAPPLEDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, int  first, uint  count); private static DrawRangeElementArrayAPPLEDel DrawRangeElementArrayAPPLEPtr;
        
        // glDrawRangeElementArrayATI
        private delegate void DrawRangeElementArrayATIDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count); private static DrawRangeElementArrayATIDel DrawRangeElementArrayATIPtr;
        
        // glDrawRangeElements
        private delegate void DrawRangeElementsDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices); private static DrawRangeElementsDel DrawRangeElementsPtr;
        
        // glDrawRangeElementsBaseVertex
        private delegate void DrawRangeElementsBaseVertexDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawRangeElementsBaseVertexDel DrawRangeElementsBaseVertexPtr;
        
        // glDrawRangeElementsBaseVertexEXT
        private delegate void DrawRangeElementsBaseVertexEXTDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawRangeElementsBaseVertexEXTDel DrawRangeElementsBaseVertexEXTPtr;
        
        // glDrawRangeElementsBaseVertexOES
        private delegate void DrawRangeElementsBaseVertexOESDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices, int  basevertex); private static DrawRangeElementsBaseVertexOESDel DrawRangeElementsBaseVertexOESPtr;
        
        // glDrawRangeElementsEXT
        private delegate void DrawRangeElementsEXTDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, uint  count, uint /*DrawElementsType*/  type, IntPtr  indices); private static DrawRangeElementsEXTDel DrawRangeElementsEXTPtr;
        
        // glDrawTexfOES
        private delegate void DrawTexfOESDel(float  x, float  y, float  z, float  width, float  height); private static DrawTexfOESDel DrawTexfOESPtr;
        
        // glDrawTexfvOES
        private delegate void DrawTexfvOESDel(float[]  coords); private static DrawTexfvOESDel DrawTexfvOESPtr;
        
        // glDrawTexiOES
        private delegate void DrawTexiOESDel(int  x, int  y, int  z, int  width, int  height); private static DrawTexiOESDel DrawTexiOESPtr;
        
        // glDrawTexivOES
        private delegate void DrawTexivOESDel(int[]  coords); private static DrawTexivOESDel DrawTexivOESPtr;
        
        // glDrawTexsOES
        private delegate void DrawTexsOESDel(short  x, short  y, short  z, short  width, short  height); private static DrawTexsOESDel DrawTexsOESPtr;
        
        // glDrawTexsvOES
        private delegate void DrawTexsvOESDel(short[]  coords); private static DrawTexsvOESDel DrawTexsvOESPtr;
        
        // glDrawTextureNV
        private delegate void DrawTextureNVDel(uint  texture, uint  sampler, float  x0, float  y0, float  x1, float  y1, float  z, float  s0, float  t0, float  s1, float  t1); private static DrawTextureNVDel DrawTextureNVPtr;
        
        // glDrawTexxOES
        private delegate void DrawTexxOESDel(int  x, int  y, int  z, int  width, int  height); private static DrawTexxOESDel DrawTexxOESPtr;
        
        // glDrawTexxvOES
        private delegate void DrawTexxvOESDel(int[]  coords); private static DrawTexxvOESDel DrawTexxvOESPtr;
        
        // glDrawTransformFeedback
        private delegate void DrawTransformFeedbackDel(uint /*PrimitiveType*/  mode, uint  id); private static DrawTransformFeedbackDel DrawTransformFeedbackPtr;
        
        // glDrawTransformFeedbackEXT
        private delegate void DrawTransformFeedbackEXTDel(uint /*PrimitiveType*/  mode, uint  id); private static DrawTransformFeedbackEXTDel DrawTransformFeedbackEXTPtr;
        
        // glDrawTransformFeedbackInstanced
        private delegate void DrawTransformFeedbackInstancedDel(uint /*PrimitiveType*/  mode, uint  id, uint  instancecount); private static DrawTransformFeedbackInstancedDel DrawTransformFeedbackInstancedPtr;
        
        // glDrawTransformFeedbackInstancedEXT
        private delegate void DrawTransformFeedbackInstancedEXTDel(uint /*PrimitiveType*/  mode, uint  id, uint  instancecount); private static DrawTransformFeedbackInstancedEXTDel DrawTransformFeedbackInstancedEXTPtr;
        
        // glDrawTransformFeedbackNV
        private delegate void DrawTransformFeedbackNVDel(uint /*PrimitiveType*/  mode, uint  id); private static DrawTransformFeedbackNVDel DrawTransformFeedbackNVPtr;
        
        // glDrawTransformFeedbackStream
        private delegate void DrawTransformFeedbackStreamDel(uint /*PrimitiveType*/  mode, uint  id, uint  stream); private static DrawTransformFeedbackStreamDel DrawTransformFeedbackStreamPtr;
        
        // glDrawTransformFeedbackStreamInstanced
        private delegate void DrawTransformFeedbackStreamInstancedDel(uint /*PrimitiveType*/  mode, uint  id, uint  stream, uint  instancecount); private static DrawTransformFeedbackStreamInstancedDel DrawTransformFeedbackStreamInstancedPtr;
        
        // glEGLImageTargetRenderbufferStorageOES
        private delegate void EGLImageTargetRenderbufferStorageOESDel(uint  target, IntPtr /*GLeglImageOES*/  image); private static EGLImageTargetRenderbufferStorageOESDel EGLImageTargetRenderbufferStorageOESPtr;
        
        // glEGLImageTargetTexStorageEXT
        private delegate void EGLImageTargetTexStorageEXTDel(uint  target, IntPtr /*GLeglImageOES*/  image, int  attrib_list); private static EGLImageTargetTexStorageEXTDel EGLImageTargetTexStorageEXTPtr;
        
        // glEGLImageTargetTexture2DOES
        private delegate void EGLImageTargetTexture2DOESDel(uint  target, IntPtr /*GLeglImageOES*/  image); private static EGLImageTargetTexture2DOESDel EGLImageTargetTexture2DOESPtr;
        
        // glEGLImageTargetTextureStorageEXT
        private delegate void EGLImageTargetTextureStorageEXTDel(uint  texture, IntPtr /*GLeglImageOES*/  image, int  attrib_list); private static EGLImageTargetTextureStorageEXTDel EGLImageTargetTextureStorageEXTPtr;
        
        // glEdgeFlag
        private delegate void EdgeFlagDel(bool /*Boolean*/  flag); private static EdgeFlagDel EdgeFlagPtr;
        
        // glEdgeFlagFormatNV
        private delegate void EdgeFlagFormatNVDel(uint  stride); private static EdgeFlagFormatNVDel EdgeFlagFormatNVPtr;
        
        // glEdgeFlagPointer
        private delegate void EdgeFlagPointerDel(uint  stride, IntPtr  pointer); private static EdgeFlagPointerDel EdgeFlagPointerPtr;
        
        // glEdgeFlagPointerEXT
        private delegate void EdgeFlagPointerEXTDel(uint  stride, uint  count, bool[] /*Boolean*/  pointer); private static EdgeFlagPointerEXTDel EdgeFlagPointerEXTPtr;
        
        // glEdgeFlagPointerListIBM
        private delegate void EdgeFlagPointerListIBMDel(int  stride, bool[] /*BooleanPointer*/  pointer, int  ptrstride); private static EdgeFlagPointerListIBMDel EdgeFlagPointerListIBMPtr;
        
        // glEdgeFlagv
        private delegate void EdgeFlagvDel(bool[] /*Boolean*/  flag); private static EdgeFlagvDel EdgeFlagvPtr;
        
        // glElementPointerAPPLE
        private delegate void ElementPointerAPPLEDel(uint /*ElementPointerTypeATI*/  type, IntPtr  pointer); private static ElementPointerAPPLEDel ElementPointerAPPLEPtr;
        
        // glElementPointerATI
        private delegate void ElementPointerATIDel(uint /*ElementPointerTypeATI*/  type, IntPtr  pointer); private static ElementPointerATIDel ElementPointerATIPtr;
        
        // glEnable
        private delegate void EnableDel(uint /*EnableCap*/  cap); private static EnableDel EnablePtr;
        
        // glEnableClientState
        private delegate void EnableClientStateDel(uint /*EnableCap*/  array); private static EnableClientStateDel EnableClientStatePtr;
        
        // glEnableClientStateIndexedEXT
        private delegate void EnableClientStateIndexedEXTDel(uint /*EnableCap*/  array, uint  index); private static EnableClientStateIndexedEXTDel EnableClientStateIndexedEXTPtr;
        
        // glEnableClientStateiEXT
        private delegate void EnableClientStateiEXTDel(uint /*EnableCap*/  array, uint  index); private static EnableClientStateiEXTDel EnableClientStateiEXTPtr;
        
        // glEnableDriverControlQCOM
        private delegate void EnableDriverControlQCOMDel(uint  driverControl); private static EnableDriverControlQCOMDel EnableDriverControlQCOMPtr;
        
        // glEnableIndexedEXT
        private delegate void EnableIndexedEXTDel(uint /*EnableCap*/  target, uint  index); private static EnableIndexedEXTDel EnableIndexedEXTPtr;
        
        // glEnableVariantClientStateEXT
        private delegate void EnableVariantClientStateEXTDel(uint  id); private static EnableVariantClientStateEXTDel EnableVariantClientStateEXTPtr;
        
        // glEnableVertexArrayAttrib
        private delegate void EnableVertexArrayAttribDel(uint  vaobj, uint  index); private static EnableVertexArrayAttribDel EnableVertexArrayAttribPtr;
        
        // glEnableVertexArrayAttribEXT
        private delegate void EnableVertexArrayAttribEXTDel(uint  vaobj, uint  index); private static EnableVertexArrayAttribEXTDel EnableVertexArrayAttribEXTPtr;
        
        // glEnableVertexArrayEXT
        private delegate void EnableVertexArrayEXTDel(uint  vaobj, uint /*EnableCap*/  array); private static EnableVertexArrayEXTDel EnableVertexArrayEXTPtr;
        
        // glEnableVertexAttribAPPLE
        private delegate void EnableVertexAttribAPPLEDel(uint  index, uint  pname); private static EnableVertexAttribAPPLEDel EnableVertexAttribAPPLEPtr;
        
        // glEnableVertexAttribArray
        private delegate void EnableVertexAttribArrayDel(uint  index); private static EnableVertexAttribArrayDel EnableVertexAttribArrayPtr;
        
        // glEnableVertexAttribArrayARB
        private delegate void EnableVertexAttribArrayARBDel(uint  index); private static EnableVertexAttribArrayARBDel EnableVertexAttribArrayARBPtr;
        
        // glEnablei
        private delegate void EnableiDel(uint /*EnableCap*/  target, uint  index); private static EnableiDel EnableiPtr;
        
        // glEnableiEXT
        private delegate void EnableiEXTDel(uint /*EnableCap*/  target, uint  index); private static EnableiEXTDel EnableiEXTPtr;
        
        // glEnableiNV
        private delegate void EnableiNVDel(uint /*EnableCap*/  target, uint  index); private static EnableiNVDel EnableiNVPtr;
        
        // glEnableiOES
        private delegate void EnableiOESDel(uint /*EnableCap*/  target, uint  index); private static EnableiOESDel EnableiOESPtr;
        
        // glEnd
        private delegate void EndDel(); private static EndDel EndPtr;
        
        // glEndConditionalRender
        private delegate void EndConditionalRenderDel(); private static EndConditionalRenderDel EndConditionalRenderPtr;
        
        // glEndConditionalRenderNV
        private delegate void EndConditionalRenderNVDel(); private static EndConditionalRenderNVDel EndConditionalRenderNVPtr;
        
        // glEndConditionalRenderNVX
        private delegate void EndConditionalRenderNVXDel(); private static EndConditionalRenderNVXDel EndConditionalRenderNVXPtr;
        
        // glEndFragmentShaderATI
        private delegate void EndFragmentShaderATIDel(); private static EndFragmentShaderATIDel EndFragmentShaderATIPtr;
        
        // glEndList
        private delegate void EndListDel(); private static EndListDel EndListPtr;
        
        // glEndOcclusionQueryNV
        private delegate void EndOcclusionQueryNVDel(); private static EndOcclusionQueryNVDel EndOcclusionQueryNVPtr;
        
        // glEndPerfMonitorAMD
        private delegate void EndPerfMonitorAMDDel(uint  monitor); private static EndPerfMonitorAMDDel EndPerfMonitorAMDPtr;
        
        // glEndPerfQueryINTEL
        private delegate void EndPerfQueryINTELDel(uint  queryHandle); private static EndPerfQueryINTELDel EndPerfQueryINTELPtr;
        
        // glEndQuery
        private delegate void EndQueryDel(uint /*QueryTarget*/  target); private static EndQueryDel EndQueryPtr;
        
        // glEndQueryARB
        private delegate void EndQueryARBDel(uint /*QueryTarget*/  target); private static EndQueryARBDel EndQueryARBPtr;
        
        // glEndQueryEXT
        private delegate void EndQueryEXTDel(uint /*QueryTarget*/  target); private static EndQueryEXTDel EndQueryEXTPtr;
        
        // glEndQueryIndexed
        private delegate void EndQueryIndexedDel(uint /*QueryTarget*/  target, uint  index); private static EndQueryIndexedDel EndQueryIndexedPtr;
        
        // glEndTilingQCOM
        private delegate void EndTilingQCOMDel(uint /*BufferBitQCOM*/  preserveMask); private static EndTilingQCOMDel EndTilingQCOMPtr;
        
        // glEndTransformFeedback
        private delegate void EndTransformFeedbackDel(); private static EndTransformFeedbackDel EndTransformFeedbackPtr;
        
        // glEndTransformFeedbackEXT
        private delegate void EndTransformFeedbackEXTDel(); private static EndTransformFeedbackEXTDel EndTransformFeedbackEXTPtr;
        
        // glEndTransformFeedbackNV
        private delegate void EndTransformFeedbackNVDel(); private static EndTransformFeedbackNVDel EndTransformFeedbackNVPtr;
        
        // glEndVertexShaderEXT
        private delegate void EndVertexShaderEXTDel(); private static EndVertexShaderEXTDel EndVertexShaderEXTPtr;
        
        // glEndVideoCaptureNV
        private delegate void EndVideoCaptureNVDel(uint  video_capture_slot); private static EndVideoCaptureNVDel EndVideoCaptureNVPtr;
        
        // glEvalCoord1d
        private delegate void EvalCoord1dDel(double /*CoordD*/  u); private static EvalCoord1dDel EvalCoord1dPtr;
        
        // glEvalCoord1dv
        private delegate void EvalCoord1dvDel(double[] /*CoordD*/  u); private static EvalCoord1dvDel EvalCoord1dvPtr;
        
        // glEvalCoord1f
        private delegate void EvalCoord1fDel(float /*CoordF*/  u); private static EvalCoord1fDel EvalCoord1fPtr;
        
        // glEvalCoord1fv
        private delegate void EvalCoord1fvDel(float[] /*CoordF*/  u); private static EvalCoord1fvDel EvalCoord1fvPtr;
        
        // glEvalCoord1xOES
        private delegate void EvalCoord1xOESDel(int  u); private static EvalCoord1xOESDel EvalCoord1xOESPtr;
        
        // glEvalCoord1xvOES
        private delegate void EvalCoord1xvOESDel(int[]  coords); private static EvalCoord1xvOESDel EvalCoord1xvOESPtr;
        
        // glEvalCoord2d
        private delegate void EvalCoord2dDel(double /*CoordD*/  u, double /*CoordD*/  v); private static EvalCoord2dDel EvalCoord2dPtr;
        
        // glEvalCoord2dv
        private delegate void EvalCoord2dvDel(double[] /*CoordD*/  u); private static EvalCoord2dvDel EvalCoord2dvPtr;
        
        // glEvalCoord2f
        private delegate void EvalCoord2fDel(float /*CoordF*/  u, float /*CoordF*/  v); private static EvalCoord2fDel EvalCoord2fPtr;
        
        // glEvalCoord2fv
        private delegate void EvalCoord2fvDel(float[] /*CoordF*/  u); private static EvalCoord2fvDel EvalCoord2fvPtr;
        
        // glEvalCoord2xOES
        private delegate void EvalCoord2xOESDel(int  u, int  v); private static EvalCoord2xOESDel EvalCoord2xOESPtr;
        
        // glEvalCoord2xvOES
        private delegate void EvalCoord2xvOESDel(int[]  coords); private static EvalCoord2xvOESDel EvalCoord2xvOESPtr;
        
        // glEvalMapsNV
        private delegate void EvalMapsNVDel(uint /*EvalTargetNV*/  target, uint /*EvalMapsModeNV*/  mode); private static EvalMapsNVDel EvalMapsNVPtr;
        
        // glEvalMesh1
        private delegate void EvalMesh1Del(uint /*MeshMode1*/  mode, int /*CheckedInt32*/  i1, int /*CheckedInt32*/  i2); private static EvalMesh1Del EvalMesh1Ptr;
        
        // glEvalMesh2
        private delegate void EvalMesh2Del(uint /*MeshMode2*/  mode, int /*CheckedInt32*/  i1, int /*CheckedInt32*/  i2, int /*CheckedInt32*/  j1, int /*CheckedInt32*/  j2); private static EvalMesh2Del EvalMesh2Ptr;
        
        // glEvalPoint1
        private delegate void EvalPoint1Del(int  i); private static EvalPoint1Del EvalPoint1Ptr;
        
        // glEvalPoint2
        private delegate void EvalPoint2Del(int /*CheckedInt32*/  i, int /*CheckedInt32*/  j); private static EvalPoint2Del EvalPoint2Ptr;
        
        // glEvaluateDepthValuesARB
        private delegate void EvaluateDepthValuesARBDel(); private static EvaluateDepthValuesARBDel EvaluateDepthValuesARBPtr;
        
        // glExecuteProgramNV
        private delegate void ExecuteProgramNVDel(uint /*VertexAttribEnumNV*/  target, uint  id, float[]  parameters); private static ExecuteProgramNVDel ExecuteProgramNVPtr;
        
        // glExtGetBufferPointervQCOM
        private delegate void ExtGetBufferPointervQCOMDel(uint  target, IntPtr  parameters); private static ExtGetBufferPointervQCOMDel ExtGetBufferPointervQCOMPtr;
        
        // glExtGetBuffersQCOM
        private delegate void ExtGetBuffersQCOMDel(uint[]  buffers, int  maxBuffers, int[]  numBuffers); private static ExtGetBuffersQCOMDel ExtGetBuffersQCOMPtr;
        
        // glExtGetFramebuffersQCOM
        private delegate void ExtGetFramebuffersQCOMDel(uint[]  framebuffers, int  maxFramebuffers, int[]  numFramebuffers); private static ExtGetFramebuffersQCOMDel ExtGetFramebuffersQCOMPtr;
        
        // glExtGetProgramBinarySourceQCOM
        private delegate void ExtGetProgramBinarySourceQCOMDel(uint  program, uint /*ShaderType*/  shadertype, string  source, int[]  length); private static ExtGetProgramBinarySourceQCOMDel ExtGetProgramBinarySourceQCOMPtr;
        
        // glExtGetProgramsQCOM
        private delegate void ExtGetProgramsQCOMDel(uint[]  programs, int  maxPrograms, int[]  numPrograms); private static ExtGetProgramsQCOMDel ExtGetProgramsQCOMPtr;
        
        // glExtGetRenderbuffersQCOM
        private delegate void ExtGetRenderbuffersQCOMDel(uint[]  renderbuffers, int  maxRenderbuffers, int[]  numRenderbuffers); private static ExtGetRenderbuffersQCOMDel ExtGetRenderbuffersQCOMPtr;
        
        // glExtGetShadersQCOM
        private delegate void ExtGetShadersQCOMDel(uint[]  shaders, int  maxShaders, int[]  numShaders); private static ExtGetShadersQCOMDel ExtGetShadersQCOMPtr;
        
        // glExtGetTexLevelParameterivQCOM
        private delegate void ExtGetTexLevelParameterivQCOMDel(uint  texture, uint  face, int  level, uint  pname, int[]  parameters); private static ExtGetTexLevelParameterivQCOMDel ExtGetTexLevelParameterivQCOMPtr;
        
        // glExtGetTexSubImageQCOM
        private delegate void ExtGetTexSubImageQCOMDel(uint  target, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  texels); private static ExtGetTexSubImageQCOMDel ExtGetTexSubImageQCOMPtr;
        
        // glExtGetTexturesQCOM
        private delegate void ExtGetTexturesQCOMDel(uint[]  textures, int  maxTextures, int[]  numTextures); private static ExtGetTexturesQCOMDel ExtGetTexturesQCOMPtr;
        
        // glExtIsProgramBinaryQCOM
        private delegate bool /*Boolean*/ ExtIsProgramBinaryQCOMDel(uint  program); private static ExtIsProgramBinaryQCOMDel ExtIsProgramBinaryQCOMPtr;
        
        // glExtTexObjectStateOverrideiQCOM
        private delegate void ExtTexObjectStateOverrideiQCOMDel(uint  target, uint  pname, int  param); private static ExtTexObjectStateOverrideiQCOMDel ExtTexObjectStateOverrideiQCOMPtr;
        
        // glExtractComponentEXT
        private delegate void ExtractComponentEXTDel(uint  res, uint  src, uint  num); private static ExtractComponentEXTDel ExtractComponentEXTPtr;
        
        // glFeedbackBuffer
        private delegate void FeedbackBufferDel(uint  size, uint /*FeedbackType*/  type, float[] /*FeedbackElement*/  buffer); private static FeedbackBufferDel FeedbackBufferPtr;
        
        // glFeedbackBufferxOES
        private delegate void FeedbackBufferxOESDel(uint  n, uint  type, int[]  buffer); private static FeedbackBufferxOESDel FeedbackBufferxOESPtr;
        
        // glFenceSync
        private delegate IntPtr /*sync*/ FenceSyncDel(uint /*SyncCondition*/  condition, uint  flags); private static FenceSyncDel FenceSyncPtr;
        
        // glFenceSyncAPPLE
        private delegate IntPtr FenceSyncAPPLEDel(uint /*SyncCondition*/  condition, uint  flags); private static FenceSyncAPPLEDel FenceSyncAPPLEPtr;
        
        // glFinalCombinerInputNV
        private delegate void FinalCombinerInputNVDel(uint /*CombinerVariableNV*/  variable, uint /*CombinerRegisterNV*/  input, uint /*CombinerMappingNV*/  mapping, uint /*CombinerComponentUsageNV*/  componentUsage); private static FinalCombinerInputNVDel FinalCombinerInputNVPtr;
        
        // glFinish
        private delegate void FinishDel(); private static FinishDel FinishPtr;
        
        // glFinishAsyncSGIX
        private delegate int FinishAsyncSGIXDel(uint[]  markerp); private static FinishAsyncSGIXDel FinishAsyncSGIXPtr;
        
        // glFinishFenceAPPLE
        private delegate void FinishFenceAPPLEDel(uint /*FenceNV*/  fence); private static FinishFenceAPPLEDel FinishFenceAPPLEPtr;
        
        // glFinishFenceNV
        private delegate void FinishFenceNVDel(uint /*FenceNV*/  fence); private static FinishFenceNVDel FinishFenceNVPtr;
        
        // glFinishObjectAPPLE
        private delegate void FinishObjectAPPLEDel(uint /*ObjectTypeAPPLE*/  obj, int  name); private static FinishObjectAPPLEDel FinishObjectAPPLEPtr;
        
        // glFinishTextureSUNX
        private delegate void FinishTextureSUNXDel(); private static FinishTextureSUNXDel FinishTextureSUNXPtr;
        
        // glFlush
        private delegate void FlushDel(); private static FlushDel FlushPtr;
        
        // glFlushMappedBufferRange
        private delegate void FlushMappedBufferRangeDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  length); private static FlushMappedBufferRangeDel FlushMappedBufferRangePtr;
        
        // glFlushMappedBufferRangeAPPLE
        private delegate void FlushMappedBufferRangeAPPLEDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static FlushMappedBufferRangeAPPLEDel FlushMappedBufferRangeAPPLEPtr;
        
        // glFlushMappedBufferRangeEXT
        private delegate void FlushMappedBufferRangeEXTDel(uint /*BufferTargetARB*/  target, IntPtr  offset, IntPtr  length); private static FlushMappedBufferRangeEXTDel FlushMappedBufferRangeEXTPtr;
        
        // glFlushMappedNamedBufferRange
        private delegate void FlushMappedNamedBufferRangeDel(uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  length); private static FlushMappedNamedBufferRangeDel FlushMappedNamedBufferRangePtr;
        
        // glFlushMappedNamedBufferRangeEXT
        private delegate void FlushMappedNamedBufferRangeEXTDel(uint  buffer, IntPtr  offset, IntPtr  length); private static FlushMappedNamedBufferRangeEXTDel FlushMappedNamedBufferRangeEXTPtr;
        
        // glFlushPixelDataRangeNV
        private delegate void FlushPixelDataRangeNVDel(uint /*PixelDataRangeTargetNV*/  target); private static FlushPixelDataRangeNVDel FlushPixelDataRangeNVPtr;
        
        // glFlushRasterSGIX
        private delegate void FlushRasterSGIXDel(); private static FlushRasterSGIXDel FlushRasterSGIXPtr;
        
        // glFlushStaticDataIBM
        private delegate void FlushStaticDataIBMDel(uint  target); private static FlushStaticDataIBMDel FlushStaticDataIBMPtr;
        
        // glFlushVertexArrayRangeAPPLE
        private delegate void FlushVertexArrayRangeAPPLEDel(uint  length, IntPtr  pointer); private static FlushVertexArrayRangeAPPLEDel FlushVertexArrayRangeAPPLEPtr;
        
        // glFlushVertexArrayRangeNV
        private delegate void FlushVertexArrayRangeNVDel(); private static FlushVertexArrayRangeNVDel FlushVertexArrayRangeNVPtr;
        
        // glFogCoordFormatNV
        private delegate void FogCoordFormatNVDel(uint  type, uint  stride); private static FogCoordFormatNVDel FogCoordFormatNVPtr;
        
        // glFogCoordPointer
        private delegate void FogCoordPointerDel(uint /*FogPointerTypeEXT*/  type, uint  stride, IntPtr  pointer); private static FogCoordPointerDel FogCoordPointerPtr;
        
        // glFogCoordPointerEXT
        private delegate void FogCoordPointerEXTDel(uint /*FogPointerTypeEXT*/  type, uint  stride, IntPtr  pointer); private static FogCoordPointerEXTDel FogCoordPointerEXTPtr;
        
        // glFogCoordPointerListIBM
        private delegate void FogCoordPointerListIBMDel(uint /*FogPointerTypeIBM*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static FogCoordPointerListIBMDel FogCoordPointerListIBMPtr;
        
        // glFogCoordd
        private delegate void FogCoorddDel(double /*CoordD*/  coord); private static FogCoorddDel FogCoorddPtr;
        
        // glFogCoorddEXT
        private delegate void FogCoorddEXTDel(double /*CoordD*/  coord); private static FogCoorddEXTDel FogCoorddEXTPtr;
        
        // glFogCoorddv
        private delegate void FogCoorddvDel(double[] /*CoordD*/  coord); private static FogCoorddvDel FogCoorddvPtr;
        
        // glFogCoorddvEXT
        private delegate void FogCoorddvEXTDel(double[] /*CoordD*/  coord); private static FogCoorddvEXTDel FogCoorddvEXTPtr;
        
        // glFogCoordf
        private delegate void FogCoordfDel(float /*CoordF*/  coord); private static FogCoordfDel FogCoordfPtr;
        
        // glFogCoordfEXT
        private delegate void FogCoordfEXTDel(float /*CoordF*/  coord); private static FogCoordfEXTDel FogCoordfEXTPtr;
        
        // glFogCoordfv
        private delegate void FogCoordfvDel(float[] /*CoordF*/  coord); private static FogCoordfvDel FogCoordfvPtr;
        
        // glFogCoordfvEXT
        private delegate void FogCoordfvEXTDel(float[] /*CoordF*/  coord); private static FogCoordfvEXTDel FogCoordfvEXTPtr;
        
        // glFogCoordhNV
        private delegate void FogCoordhNVDel(ushort /*Half16NV*/  fog); private static FogCoordhNVDel FogCoordhNVPtr;
        
        // glFogCoordhvNV
        private delegate void FogCoordhvNVDel(ushort[] /*Half16NV*/  fog); private static FogCoordhvNVDel FogCoordhvNVPtr;
        
        // glFogFuncSGIS
        private delegate void FogFuncSGISDel(uint  n, float[]  points); private static FogFuncSGISDel FogFuncSGISPtr;
        
        // glFogf
        private delegate void FogfDel(uint /*FogParameter*/  pname, float /*CheckedFloat32*/  param); private static FogfDel FogfPtr;
        
        // glFogfv
        private delegate void FogfvDel(uint /*FogParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static FogfvDel FogfvPtr;
        
        // glFogi
        private delegate void FogiDel(uint /*FogParameter*/  pname, int /*CheckedInt32*/  param); private static FogiDel FogiPtr;
        
        // glFogiv
        private delegate void FogivDel(uint /*FogParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static FogivDel FogivPtr;
        
        // glFogx
        private delegate void FogxDel(uint /*FogPName*/  pname, int  param); private static FogxDel FogxPtr;
        
        // glFogxOES
        private delegate void FogxOESDel(uint /*FogPName*/  pname, int  param); private static FogxOESDel FogxOESPtr;
        
        // glFogxv
        private delegate void FogxvDel(uint /*FogPName*/  pname, int[]  param); private static FogxvDel FogxvPtr;
        
        // glFogxvOES
        private delegate void FogxvOESDel(uint /*FogPName*/  pname, int[]  param); private static FogxvOESDel FogxvOESPtr;
        
        // glFragmentColorMaterialSGIX
        private delegate void FragmentColorMaterialSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  mode); private static FragmentColorMaterialSGIXDel FragmentColorMaterialSGIXPtr;
        
        // glFragmentCoverageColorNV
        private delegate void FragmentCoverageColorNVDel(uint  color); private static FragmentCoverageColorNVDel FragmentCoverageColorNVPtr;
        
        // glFragmentLightModelfSGIX
        private delegate void FragmentLightModelfSGIXDel(uint /*FragmentLightModelParameterSGIX*/  pname, float /*CheckedFloat32*/  param); private static FragmentLightModelfSGIXDel FragmentLightModelfSGIXPtr;
        
        // glFragmentLightModelfvSGIX
        private delegate void FragmentLightModelfvSGIXDel(uint /*FragmentLightModelParameterSGIX*/  pname, float[] /*CheckedFloat32*/  parameters); private static FragmentLightModelfvSGIXDel FragmentLightModelfvSGIXPtr;
        
        // glFragmentLightModeliSGIX
        private delegate void FragmentLightModeliSGIXDel(uint /*FragmentLightModelParameterSGIX*/  pname, int /*CheckedInt32*/  param); private static FragmentLightModeliSGIXDel FragmentLightModeliSGIXPtr;
        
        // glFragmentLightModelivSGIX
        private delegate void FragmentLightModelivSGIXDel(uint /*FragmentLightModelParameterSGIX*/  pname, int[] /*CheckedInt32*/  parameters); private static FragmentLightModelivSGIXDel FragmentLightModelivSGIXPtr;
        
        // glFragmentLightfSGIX
        private delegate void FragmentLightfSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, float /*CheckedFloat32*/  param); private static FragmentLightfSGIXDel FragmentLightfSGIXPtr;
        
        // glFragmentLightfvSGIX
        private delegate void FragmentLightfvSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, float[] /*CheckedFloat32*/  parameters); private static FragmentLightfvSGIXDel FragmentLightfvSGIXPtr;
        
        // glFragmentLightiSGIX
        private delegate void FragmentLightiSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, int /*CheckedInt32*/  param); private static FragmentLightiSGIXDel FragmentLightiSGIXPtr;
        
        // glFragmentLightivSGIX
        private delegate void FragmentLightivSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, int[] /*CheckedInt32*/  parameters); private static FragmentLightivSGIXDel FragmentLightivSGIXPtr;
        
        // glFragmentMaterialfSGIX
        private delegate void FragmentMaterialfSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float /*CheckedFloat32*/  param); private static FragmentMaterialfSGIXDel FragmentMaterialfSGIXPtr;
        
        // glFragmentMaterialfvSGIX
        private delegate void FragmentMaterialfvSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static FragmentMaterialfvSGIXDel FragmentMaterialfvSGIXPtr;
        
        // glFragmentMaterialiSGIX
        private delegate void FragmentMaterialiSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int /*CheckedInt32*/  param); private static FragmentMaterialiSGIXDel FragmentMaterialiSGIXPtr;
        
        // glFragmentMaterialivSGIX
        private delegate void FragmentMaterialivSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static FragmentMaterialivSGIXDel FragmentMaterialivSGIXPtr;
        
        // glFrameTerminatorGREMEDY
        private delegate void FrameTerminatorGREMEDYDel(); private static FrameTerminatorGREMEDYDel FrameTerminatorGREMEDYPtr;
        
        // glFrameZoomSGIX
        private delegate void FrameZoomSGIXDel(int /*CheckedInt32*/  factor); private static FrameZoomSGIXDel FrameZoomSGIXPtr;
        
        // glFramebufferDrawBufferEXT
        private delegate void FramebufferDrawBufferEXTDel(uint /*Framebuffer*/  framebuffer, uint /*DrawBufferMode*/  mode); private static FramebufferDrawBufferEXTDel FramebufferDrawBufferEXTPtr;
        
        // glFramebufferDrawBuffersEXT
        private delegate void FramebufferDrawBuffersEXTDel(uint /*Framebuffer*/  framebuffer, uint  n, uint[] /*DrawBufferMode*/  bufs); private static FramebufferDrawBuffersEXTDel FramebufferDrawBuffersEXTPtr;
        
        // glFramebufferFetchBarrierEXT
        private delegate void FramebufferFetchBarrierEXTDel(); private static FramebufferFetchBarrierEXTDel FramebufferFetchBarrierEXTPtr;
        
        // glFramebufferFetchBarrierQCOM
        private delegate void FramebufferFetchBarrierQCOMDel(); private static FramebufferFetchBarrierQCOMDel FramebufferFetchBarrierQCOMPtr;
        
        // glFramebufferFoveationConfigQCOM
        private delegate void FramebufferFoveationConfigQCOMDel(uint /*Framebuffer*/  framebuffer, uint  numLayers, uint  focalPointsPerLayer, uint  requestedFeatures, uint[]  providedFeatures); private static FramebufferFoveationConfigQCOMDel FramebufferFoveationConfigQCOMPtr;
        
        // glFramebufferFoveationParametersQCOM
        private delegate void FramebufferFoveationParametersQCOMDel(uint /*Framebuffer*/  framebuffer, uint  layer, uint  focalPoint, float /*CheckedFloat32*/  focalX, float /*CheckedFloat32*/  focalY, float /*CheckedFloat32*/  gainX, float /*CheckedFloat32*/  gainY, float /*CheckedFloat32*/  foveaArea); private static FramebufferFoveationParametersQCOMDel FramebufferFoveationParametersQCOMPtr;
        
        // glFramebufferParameteri
        private delegate void FramebufferParameteriDel(uint /*FramebufferTarget*/  target, uint /*FramebufferParameterName*/  pname, int  param); private static FramebufferParameteriDel FramebufferParameteriPtr;
        
        // glFramebufferPixelLocalStorageSizeEXT
        private delegate void FramebufferPixelLocalStorageSizeEXTDel(uint  target, uint  size); private static FramebufferPixelLocalStorageSizeEXTDel FramebufferPixelLocalStorageSizeEXTPtr;
        
        // glFramebufferReadBufferEXT
        private delegate void FramebufferReadBufferEXTDel(uint /*Framebuffer*/  framebuffer, uint /*ReadBufferMode*/  mode); private static FramebufferReadBufferEXTDel FramebufferReadBufferEXTPtr;
        
        // glFramebufferRenderbuffer
        private delegate void FramebufferRenderbufferDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*RenderbufferTarget*/  renderbuffertarget, uint  renderbuffer); private static FramebufferRenderbufferDel FramebufferRenderbufferPtr;
        
        // glFramebufferRenderbufferEXT
        private delegate void FramebufferRenderbufferEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*RenderbufferTarget*/  renderbuffertarget, uint  renderbuffer); private static FramebufferRenderbufferEXTDel FramebufferRenderbufferEXTPtr;
        
        // glFramebufferRenderbufferOES
        private delegate void FramebufferRenderbufferOESDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*RenderbufferTarget*/  renderbuffertarget, uint  renderbuffer); private static FramebufferRenderbufferOESDel FramebufferRenderbufferOESPtr;
        
        // glFramebufferSampleLocationsfvARB
        private delegate void FramebufferSampleLocationsfvARBDel(uint /*FramebufferTarget*/  target, uint  start, uint  count, float[]  v); private static FramebufferSampleLocationsfvARBDel FramebufferSampleLocationsfvARBPtr;
        
        // glFramebufferSampleLocationsfvNV
        private delegate void FramebufferSampleLocationsfvNVDel(uint /*FramebufferTarget*/  target, uint  start, uint  count, float[]  v); private static FramebufferSampleLocationsfvNVDel FramebufferSampleLocationsfvNVPtr;
        
        // glFramebufferSamplePositionsfvAMD
        private delegate void FramebufferSamplePositionsfvAMDDel(uint /*FramebufferTarget*/  target, uint  numsamples, uint  pixelindex, float[]  values); private static FramebufferSamplePositionsfvAMDDel FramebufferSamplePositionsfvAMDPtr;
        
        // glFramebufferTexture
        private delegate void FramebufferTextureDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint  texture, int  level); private static FramebufferTextureDel FramebufferTexturePtr;
        
        // glFramebufferTexture1D
        private delegate void FramebufferTexture1DDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level); private static FramebufferTexture1DDel FramebufferTexture1DPtr;
        
        // glFramebufferTexture1DEXT
        private delegate void FramebufferTexture1DEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level); private static FramebufferTexture1DEXTDel FramebufferTexture1DEXTPtr;
        
        // glFramebufferTexture2D
        private delegate void FramebufferTexture2DDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level); private static FramebufferTexture2DDel FramebufferTexture2DPtr;
        
        // glFramebufferTexture2DEXT
        private delegate void FramebufferTexture2DEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level); private static FramebufferTexture2DEXTDel FramebufferTexture2DEXTPtr;
        
        // glFramebufferTexture2DDownsampleIMG
        private delegate void FramebufferTexture2DDownsampleIMGDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, int  xscale, int  yscale); private static FramebufferTexture2DDownsampleIMGDel FramebufferTexture2DDownsampleIMGPtr;
        
        // glFramebufferTexture2DMultisampleEXT
        private delegate void FramebufferTexture2DMultisampleEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, uint  samples); private static FramebufferTexture2DMultisampleEXTDel FramebufferTexture2DMultisampleEXTPtr;
        
        // glFramebufferTexture2DMultisampleIMG
        private delegate void FramebufferTexture2DMultisampleIMGDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, uint  samples); private static FramebufferTexture2DMultisampleIMGDel FramebufferTexture2DMultisampleIMGPtr;
        
        // glFramebufferTexture2DOES
        private delegate void FramebufferTexture2DOESDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level); private static FramebufferTexture2DOESDel FramebufferTexture2DOESPtr;
        
        // glFramebufferTexture3D
        private delegate void FramebufferTexture3DDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, int  zoffset); private static FramebufferTexture3DDel FramebufferTexture3DPtr;
        
        // glFramebufferTexture3DEXT
        private delegate void FramebufferTexture3DEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, int  zoffset); private static FramebufferTexture3DEXTDel FramebufferTexture3DEXTPtr;
        
        // glFramebufferTexture3DOES
        private delegate void FramebufferTexture3DOESDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint  texture, int  level, int  zoffset); private static FramebufferTexture3DOESDel FramebufferTexture3DOESPtr;
        
        // glFramebufferTextureARB
        private delegate void FramebufferTextureARBDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static FramebufferTextureARBDel FramebufferTextureARBPtr;
        
        // glFramebufferTextureEXT
        private delegate void FramebufferTextureEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static FramebufferTextureEXTDel FramebufferTextureEXTPtr;
        
        // glFramebufferTextureFaceARB
        private delegate void FramebufferTextureFaceARBDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, uint /*TextureTarget*/  face); private static FramebufferTextureFaceARBDel FramebufferTextureFaceARBPtr;
        
        // glFramebufferTextureFaceEXT
        private delegate void FramebufferTextureFaceEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, uint /*TextureTarget*/  face); private static FramebufferTextureFaceEXTDel FramebufferTextureFaceEXTPtr;
        
        // glFramebufferTextureLayer
        private delegate void FramebufferTextureLayerDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  layer); private static FramebufferTextureLayerDel FramebufferTextureLayerPtr;
        
        // glFramebufferTextureLayerARB
        private delegate void FramebufferTextureLayerARBDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  layer); private static FramebufferTextureLayerARBDel FramebufferTextureLayerARBPtr;
        
        // glFramebufferTextureLayerEXT
        private delegate void FramebufferTextureLayerEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  layer); private static FramebufferTextureLayerEXTDel FramebufferTextureLayerEXTPtr;
        
        // glFramebufferTextureLayerDownsampleIMG
        private delegate void FramebufferTextureLayerDownsampleIMGDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  layer, int  xscale, int  yscale); private static FramebufferTextureLayerDownsampleIMGDel FramebufferTextureLayerDownsampleIMGPtr;
        
        // glFramebufferTextureMultisampleMultiviewOVR
        private delegate void FramebufferTextureMultisampleMultiviewOVRDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, uint  samples, int  baseViewIndex, uint  numViews); private static FramebufferTextureMultisampleMultiviewOVRDel FramebufferTextureMultisampleMultiviewOVRPtr;
        
        // glFramebufferTextureMultiviewOVR
        private delegate void FramebufferTextureMultiviewOVRDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int  baseViewIndex, uint  numViews); private static FramebufferTextureMultiviewOVRDel FramebufferTextureMultiviewOVRPtr;
        
        // glFramebufferTextureOES
        private delegate void FramebufferTextureOESDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static FramebufferTextureOESDel FramebufferTextureOESPtr;
        
        // glFreeObjectBufferATI
        private delegate void FreeObjectBufferATIDel(uint  buffer); private static FreeObjectBufferATIDel FreeObjectBufferATIPtr;
        
        // glFrontFace
        private delegate void FrontFaceDel(uint /*FrontFaceDirection*/  mode); private static FrontFaceDel FrontFacePtr;
        
        // glFrustum
        private delegate void FrustumDel(double  left, double  right, double  bottom, double  top, double  zNear, double  zFar); private static FrustumDel FrustumPtr;
        
        // glFrustumf
        private delegate void FrustumfDel(float  l, float  r, float  b, float  t, float  n, float  f); private static FrustumfDel FrustumfPtr;
        
        // glFrustumfOES
        private delegate void FrustumfOESDel(float  l, float  r, float  b, float  t, float  n, float  f); private static FrustumfOESDel FrustumfOESPtr;
        
        // glFrustumx
        private delegate void FrustumxDel(int  l, int  r, int  b, int  t, int  n, int  f); private static FrustumxDel FrustumxPtr;
        
        // glFrustumxOES
        private delegate void FrustumxOESDel(int  l, int  r, int  b, int  t, int  n, int  f); private static FrustumxOESDel FrustumxOESPtr;
        
        // glGenAsyncMarkersSGIX
        private delegate uint GenAsyncMarkersSGIXDel(uint  range); private static GenAsyncMarkersSGIXDel GenAsyncMarkersSGIXPtr;
        
        // glGenBuffers
        private delegate void GenBuffersDel(uint  n, uint[]  buffers); private static GenBuffersDel GenBuffersPtr;
        
        // glGenBuffersARB
        private delegate void GenBuffersARBDel(uint  n, uint[]  buffers); private static GenBuffersARBDel GenBuffersARBPtr;
        
        // glGenFencesAPPLE
        private delegate void GenFencesAPPLEDel(uint  n, uint[] /*FenceNV*/  fences); private static GenFencesAPPLEDel GenFencesAPPLEPtr;
        
        // glGenFencesNV
        private delegate void GenFencesNVDel(uint  n, uint[] /*FenceNV*/  fences); private static GenFencesNVDel GenFencesNVPtr;
        
        // glGenFragmentShadersATI
        private delegate uint GenFragmentShadersATIDel(uint  range); private static GenFragmentShadersATIDel GenFragmentShadersATIPtr;
        
        // glGenFramebuffers
        private delegate void GenFramebuffersDel(uint  n, uint[]  framebuffers); private static GenFramebuffersDel GenFramebuffersPtr;
        
        // glGenFramebuffersEXT
        private delegate void GenFramebuffersEXTDel(uint  n, uint[]  framebuffers); private static GenFramebuffersEXTDel GenFramebuffersEXTPtr;
        
        // glGenFramebuffersOES
        private delegate void GenFramebuffersOESDel(uint  n, uint[]  framebuffers); private static GenFramebuffersOESDel GenFramebuffersOESPtr;
        
        // glGenLists
        private delegate uint /*List*/ GenListsDel(uint  range); private static GenListsDel GenListsPtr;
        
        // glGenNamesAMD
        private delegate void GenNamesAMDDel(uint  identifier, uint  num, uint[]  names); private static GenNamesAMDDel GenNamesAMDPtr;
        
        // glGenOcclusionQueriesNV
        private delegate void GenOcclusionQueriesNVDel(uint  n, uint[]  ids); private static GenOcclusionQueriesNVDel GenOcclusionQueriesNVPtr;
        
        // glGenPathsNV
        private delegate uint /*Path*/ GenPathsNVDel(uint  range); private static GenPathsNVDel GenPathsNVPtr;
        
        // glGenPerfMonitorsAMD
        private delegate void GenPerfMonitorsAMDDel(uint  n, uint[]  monitors); private static GenPerfMonitorsAMDDel GenPerfMonitorsAMDPtr;
        
        // glGenProgramPipelines
        private delegate void GenProgramPipelinesDel(uint  n, uint[]  pipelines); private static GenProgramPipelinesDel GenProgramPipelinesPtr;
        
        // glGenProgramPipelinesEXT
        private delegate void GenProgramPipelinesEXTDel(uint  n, uint[]  pipelines); private static GenProgramPipelinesEXTDel GenProgramPipelinesEXTPtr;
        
        // glGenProgramsARB
        private delegate void GenProgramsARBDel(uint  n, uint[]  programs); private static GenProgramsARBDel GenProgramsARBPtr;
        
        // glGenProgramsNV
        private delegate void GenProgramsNVDel(uint  n, uint[]  programs); private static GenProgramsNVDel GenProgramsNVPtr;
        
        // glGenQueries
        private delegate void GenQueriesDel(uint  n, uint[]  ids); private static GenQueriesDel GenQueriesPtr;
        
        // glGenQueriesARB
        private delegate void GenQueriesARBDel(uint  n, uint[]  ids); private static GenQueriesARBDel GenQueriesARBPtr;
        
        // glGenQueriesEXT
        private delegate void GenQueriesEXTDel(uint  n, uint[]  ids); private static GenQueriesEXTDel GenQueriesEXTPtr;
        
        // glGenQueryResourceTagNV
        private delegate void GenQueryResourceTagNVDel(uint  n, int[]  tagIds); private static GenQueryResourceTagNVDel GenQueryResourceTagNVPtr;
        
        // glGenRenderbuffers
        private delegate void GenRenderbuffersDel(uint  n, uint[]  renderbuffers); private static GenRenderbuffersDel GenRenderbuffersPtr;
        
        // glGenRenderbuffersEXT
        private delegate void GenRenderbuffersEXTDel(uint  n, uint[]  renderbuffers); private static GenRenderbuffersEXTDel GenRenderbuffersEXTPtr;
        
        // glGenRenderbuffersOES
        private delegate void GenRenderbuffersOESDel(uint  n, uint[]  renderbuffers); private static GenRenderbuffersOESDel GenRenderbuffersOESPtr;
        
        // glGenSamplers
        private delegate void GenSamplersDel(uint  count, uint[]  samplers); private static GenSamplersDel GenSamplersPtr;
        
        // glGenSemaphoresEXT
        private delegate void GenSemaphoresEXTDel(uint  n, uint[]  semaphores); private static GenSemaphoresEXTDel GenSemaphoresEXTPtr;
        
        // glGenSymbolsEXT
        private delegate uint GenSymbolsEXTDel(uint /*DataTypeEXT*/  datatype, uint /*VertexShaderStorageTypeEXT*/  storagetype, uint /*ParameterRangeEXT*/  range, uint  components); private static GenSymbolsEXTDel GenSymbolsEXTPtr;
        
        // glGenTextures
        private delegate void GenTexturesDel(uint  n, uint[] /*Texture*/  textures); private static GenTexturesDel GenTexturesPtr;
        
        // glGenTexturesEXT
        private delegate void GenTexturesEXTDel(uint  n, uint[] /*Texture*/  textures); private static GenTexturesEXTDel GenTexturesEXTPtr;
        
        // glGenTransformFeedbacks
        private delegate void GenTransformFeedbacksDel(uint  n, uint[]  ids); private static GenTransformFeedbacksDel GenTransformFeedbacksPtr;
        
        // glGenTransformFeedbacksNV
        private delegate void GenTransformFeedbacksNVDel(uint  n, uint[]  ids); private static GenTransformFeedbacksNVDel GenTransformFeedbacksNVPtr;
        
        // glGenVertexArrays
        private delegate void GenVertexArraysDel(uint  n, uint[]  arrays); private static GenVertexArraysDel GenVertexArraysPtr;
        
        // glGenVertexArraysAPPLE
        private delegate void GenVertexArraysAPPLEDel(uint  n, uint[]  arrays); private static GenVertexArraysAPPLEDel GenVertexArraysAPPLEPtr;
        
        // glGenVertexArraysOES
        private delegate void GenVertexArraysOESDel(uint  n, uint[]  arrays); private static GenVertexArraysOESDel GenVertexArraysOESPtr;
        
        // glGenVertexShadersEXT
        private delegate uint GenVertexShadersEXTDel(uint  range); private static GenVertexShadersEXTDel GenVertexShadersEXTPtr;
        
        // glGenerateMipmap
        private delegate void GenerateMipmapDel(uint /*TextureTarget*/  target); private static GenerateMipmapDel GenerateMipmapPtr;
        
        // glGenerateMipmapEXT
        private delegate void GenerateMipmapEXTDel(uint /*TextureTarget*/  target); private static GenerateMipmapEXTDel GenerateMipmapEXTPtr;
        
        // glGenerateMipmapOES
        private delegate void GenerateMipmapOESDel(uint /*TextureTarget*/  target); private static GenerateMipmapOESDel GenerateMipmapOESPtr;
        
        // glGenerateMultiTexMipmapEXT
        private delegate void GenerateMultiTexMipmapEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target); private static GenerateMultiTexMipmapEXTDel GenerateMultiTexMipmapEXTPtr;
        
        // glGenerateTextureMipmap
        private delegate void GenerateTextureMipmapDel(uint  texture); private static GenerateTextureMipmapDel GenerateTextureMipmapPtr;
        
        // glGenerateTextureMipmapEXT
        private delegate void GenerateTextureMipmapEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target); private static GenerateTextureMipmapEXTDel GenerateTextureMipmapEXTPtr;
        
        // glGetActiveAtomicCounterBufferiv
        private delegate void GetActiveAtomicCounterBufferivDel(uint  program, uint  bufferIndex, uint /*AtomicCounterBufferPName*/  pname, int[]  parameters); private static GetActiveAtomicCounterBufferivDel GetActiveAtomicCounterBufferivPtr;
        
        // glGetActiveAttrib
        private delegate void GetActiveAttribDel(uint  program, uint  index, uint  bufSize, uint[]  length, int[]  size, uint[] /*AttributeType*/  type, string  name); private static GetActiveAttribDel GetActiveAttribPtr;
        
        // glGetActiveAttribARB
        private delegate void GetActiveAttribARBDel(IntPtr /*handleARB*/  programObj, uint  index, uint  maxLength, uint[]  length, int[]  size, uint[] /*AttributeType*/  type, string  name); private static GetActiveAttribARBDel GetActiveAttribARBPtr;
        
        // glGetActiveSubroutineName
        private delegate void GetActiveSubroutineNameDel(uint  program, uint /*ShaderType*/  shadertype, uint  index, uint  bufSize, uint[]  length, string  name); private static GetActiveSubroutineNameDel GetActiveSubroutineNamePtr;
        
        // glGetActiveSubroutineUniformName
        private delegate void GetActiveSubroutineUniformNameDel(uint  program, uint /*ShaderType*/  shadertype, uint  index, uint  bufSize, uint[]  length, string  name); private static GetActiveSubroutineUniformNameDel GetActiveSubroutineUniformNamePtr;
        
        // glGetActiveSubroutineUniformiv
        private delegate void GetActiveSubroutineUniformivDel(uint  program, uint /*ShaderType*/  shadertype, uint  index, uint /*SubroutineParameterName*/  pname, int[]  values); private static GetActiveSubroutineUniformivDel GetActiveSubroutineUniformivPtr;
        
        // glGetActiveUniform
        private delegate void GetActiveUniformDel(uint  program, uint  index, uint  bufSize, uint[]  length, int[]  size, uint[] /*UniformType*/  type, string  name); private static GetActiveUniformDel GetActiveUniformPtr;
        
        // glGetActiveUniformARB
        private delegate void GetActiveUniformARBDel(IntPtr /*handleARB*/  programObj, uint  index, uint  maxLength, uint[]  length, int[]  size, uint[] /*UniformType*/  type, string  name); private static GetActiveUniformARBDel GetActiveUniformARBPtr;
        
        // glGetActiveUniformBlockName
        private delegate void GetActiveUniformBlockNameDel(uint  program, uint  uniformBlockIndex, uint  bufSize, uint[]  length, string  uniformBlockName); private static GetActiveUniformBlockNameDel GetActiveUniformBlockNamePtr;
        
        // glGetActiveUniformBlockiv
        private delegate void GetActiveUniformBlockivDel(uint  program, uint  uniformBlockIndex, uint /*UniformBlockPName*/  pname, int[]  parameters); private static GetActiveUniformBlockivDel GetActiveUniformBlockivPtr;
        
        // glGetActiveUniformName
        private delegate void GetActiveUniformNameDel(uint  program, uint  uniformIndex, uint  bufSize, uint[]  length, string  uniformName); private static GetActiveUniformNameDel GetActiveUniformNamePtr;
        
        // glGetActiveUniformsiv
        private delegate void GetActiveUniformsivDel(uint  program, uint  uniformCount, uint[]  uniformIndices, uint /*UniformPName*/  pname, int[]  parameters); private static GetActiveUniformsivDel GetActiveUniformsivPtr;
        
        // glGetActiveVaryingNV
        private delegate void GetActiveVaryingNVDel(uint  program, uint  index, uint  bufSize, uint[]  length, uint[]  size, uint[]  type, string  name); private static GetActiveVaryingNVDel GetActiveVaryingNVPtr;
        
        // glGetArrayObjectfvATI
        private delegate void GetArrayObjectfvATIDel(uint /*EnableCap*/  array, uint /*ArrayObjectPNameATI*/  pname, float[]  parameters); private static GetArrayObjectfvATIDel GetArrayObjectfvATIPtr;
        
        // glGetArrayObjectivATI
        private delegate void GetArrayObjectivATIDel(uint /*EnableCap*/  array, uint /*ArrayObjectPNameATI*/  pname, int[]  parameters); private static GetArrayObjectivATIDel GetArrayObjectivATIPtr;
        
        // glGetAttachedObjectsARB
        // Could be an alias of glGetAttachedShaders except that GLhandleARB is different on MacOS X
        private delegate void GetAttachedObjectsARBDel(IntPtr /*handleARB*/  containerObj, uint  maxCount, uint[]  count, IntPtr[] /*handleARB*/  obj); private static GetAttachedObjectsARBDel GetAttachedObjectsARBPtr;
        
        // glGetAttachedShaders
        private delegate void GetAttachedShadersDel(uint  program, uint  maxCount, uint[]  count, uint[]  shaders); private static GetAttachedShadersDel GetAttachedShadersPtr;
        
        // glGetAttribLocation
        private delegate int GetAttribLocationDel(uint  program, string  name); private static GetAttribLocationDel GetAttribLocationPtr;
        
        // glGetAttribLocationARB
        private delegate int GetAttribLocationARBDel(IntPtr /*handleARB*/  programObj, string  name); private static GetAttribLocationARBDel GetAttribLocationARBPtr;
        
        // glGetBooleanIndexedvEXT
        private delegate void GetBooleanIndexedvEXTDel(uint /*BufferTargetARB*/  target, uint  index, bool[] /*Boolean*/  data); private static GetBooleanIndexedvEXTDel GetBooleanIndexedvEXTPtr;
        
        // glGetBooleani_v
        private delegate void GetBooleani_vDel(uint /*BufferTargetARB*/  target, uint  index, bool[] /*Boolean*/  data); private static GetBooleani_vDel GetBooleani_vPtr;
        
        // glGetBooleanv
        private delegate void GetBooleanvDel(uint /*GetPName*/  pname, bool[] /*Boolean*/  data); private static GetBooleanvDel GetBooleanvPtr;
        
        // glGetBufferParameteri64v
        private delegate void GetBufferParameteri64vDel(uint /*BufferTargetARB*/  target, uint /*BufferPNameARB*/  pname, long[]  parameters); private static GetBufferParameteri64vDel GetBufferParameteri64vPtr;
        
        // glGetBufferParameteriv
        private delegate void GetBufferParameterivDel(uint /*BufferTargetARB*/  target, uint /*BufferPNameARB*/  pname, int[]  parameters); private static GetBufferParameterivDel GetBufferParameterivPtr;
        
        // glGetBufferParameterivARB
        private delegate void GetBufferParameterivARBDel(uint /*BufferTargetARB*/  target, uint /*BufferPNameARB*/  pname, int[]  parameters); private static GetBufferParameterivARBDel GetBufferParameterivARBPtr;
        
        // glGetBufferParameterui64vNV
        private delegate void GetBufferParameterui64vNVDel(uint /*BufferTargetARB*/  target, uint  pname, ulong[]  parameters); private static GetBufferParameterui64vNVDel GetBufferParameterui64vNVPtr;
        
        // glGetBufferPointerv
        private delegate void GetBufferPointervDel(uint /*BufferTargetARB*/  target, uint /*BufferPointerNameARB*/  pname, IntPtr  parameters); private static GetBufferPointervDel GetBufferPointervPtr;
        
        // glGetBufferPointervARB
        private delegate void GetBufferPointervARBDel(uint /*BufferTargetARB*/  target, uint /*BufferPointerNameARB*/  pname, IntPtr  parameters); private static GetBufferPointervARBDel GetBufferPointervARBPtr;
        
        // glGetBufferPointervOES
        private delegate void GetBufferPointervOESDel(uint /*BufferTargetARB*/  target, uint /*BufferPointerNameARB*/  pname, IntPtr  parameters); private static GetBufferPointervOESDel GetBufferPointervOESPtr;
        
        // glGetBufferSubData
        private delegate void GetBufferSubDataDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size, IntPtr  data); private static GetBufferSubDataDel GetBufferSubDataPtr;
        
        // glGetBufferSubDataARB
        private delegate void GetBufferSubDataARBDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffsetARB*/  offset, IntPtr /*BufferSizeARB*/  size, IntPtr  data); private static GetBufferSubDataARBDel GetBufferSubDataARBPtr;
        
        // glGetClipPlane
        private delegate void GetClipPlaneDel(uint /*ClipPlaneName*/  plane, double[]  equation); private static GetClipPlaneDel GetClipPlanePtr;
        
        // glGetClipPlanef
        private delegate void GetClipPlanefDel(uint /*ClipPlaneName*/  plane, float[]  equation); private static GetClipPlanefDel GetClipPlanefPtr;
        
        // glGetClipPlanefOES
        private delegate void GetClipPlanefOESDel(uint /*ClipPlaneName*/  plane, float[]  equation); private static GetClipPlanefOESDel GetClipPlanefOESPtr;
        
        // glGetClipPlanex
        private delegate void GetClipPlanexDel(uint /*ClipPlaneName*/  plane, int[]  equation); private static GetClipPlanexDel GetClipPlanexPtr;
        
        // glGetClipPlanexOES
        private delegate void GetClipPlanexOESDel(uint /*ClipPlaneName*/  plane, int[]  equation); private static GetClipPlanexOESDel GetClipPlanexOESPtr;
        
        // glGetColorTable
        private delegate void GetColorTableDel(uint /*ColorTableTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  table); private static GetColorTableDel GetColorTablePtr;
        
        // glGetColorTableEXT
        private delegate void GetColorTableEXTDel(uint /*ColorTableTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  data); private static GetColorTableEXTDel GetColorTableEXTPtr;
        
        // glGetColorTableParameterfv
        private delegate void GetColorTableParameterfvDel(uint /*ColorTableTarget*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, float[]  parameters); private static GetColorTableParameterfvDel GetColorTableParameterfvPtr;
        
        // glGetColorTableParameterfvEXT
        private delegate void GetColorTableParameterfvEXTDel(uint /*ColorTableTarget*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, float[]  parameters); private static GetColorTableParameterfvEXTDel GetColorTableParameterfvEXTPtr;
        
        // glGetColorTableParameterfvSGI
        private delegate void GetColorTableParameterfvSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, float[]  parameters); private static GetColorTableParameterfvSGIDel GetColorTableParameterfvSGIPtr;
        
        // glGetColorTableParameteriv
        private delegate void GetColorTableParameterivDel(uint /*ColorTableTarget*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, int[]  parameters); private static GetColorTableParameterivDel GetColorTableParameterivPtr;
        
        // glGetColorTableParameterivEXT
        private delegate void GetColorTableParameterivEXTDel(uint /*ColorTableTarget*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, int[]  parameters); private static GetColorTableParameterivEXTDel GetColorTableParameterivEXTPtr;
        
        // glGetColorTableParameterivSGI
        private delegate void GetColorTableParameterivSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*GetColorTableParameterPNameSGI*/  pname, int[]  parameters); private static GetColorTableParameterivSGIDel GetColorTableParameterivSGIPtr;
        
        // glGetColorTableSGI
        private delegate void GetColorTableSGIDel(uint /*ColorTableTargetSGI*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  table); private static GetColorTableSGIDel GetColorTableSGIPtr;
        
        // glGetCombinerInputParameterfvNV
        private delegate void GetCombinerInputParameterfvNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerVariableNV*/  variable, uint /*CombinerParameterNV*/  pname, float[]  parameters); private static GetCombinerInputParameterfvNVDel GetCombinerInputParameterfvNVPtr;
        
        // glGetCombinerInputParameterivNV
        private delegate void GetCombinerInputParameterivNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerVariableNV*/  variable, uint /*CombinerParameterNV*/  pname, int[]  parameters); private static GetCombinerInputParameterivNVDel GetCombinerInputParameterivNVPtr;
        
        // glGetCombinerOutputParameterfvNV
        private delegate void GetCombinerOutputParameterfvNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerParameterNV*/  pname, float[]  parameters); private static GetCombinerOutputParameterfvNVDel GetCombinerOutputParameterfvNVPtr;
        
        // glGetCombinerOutputParameterivNV
        private delegate void GetCombinerOutputParameterivNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerPortionNV*/  portion, uint /*CombinerParameterNV*/  pname, int[]  parameters); private static GetCombinerOutputParameterivNVDel GetCombinerOutputParameterivNVPtr;
        
        // glGetCombinerStageParameterfvNV
        private delegate void GetCombinerStageParameterfvNVDel(uint /*CombinerStageNV*/  stage, uint /*CombinerParameterNV*/  pname, float[]  parameters); private static GetCombinerStageParameterfvNVDel GetCombinerStageParameterfvNVPtr;
        
        // glGetCommandHeaderNV
        private delegate uint GetCommandHeaderNVDel(uint  tokenID, uint  size); private static GetCommandHeaderNVDel GetCommandHeaderNVPtr;
        
        // glGetCompressedMultiTexImageEXT
        private delegate void GetCompressedMultiTexImageEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  lod, IntPtr  img); private static GetCompressedMultiTexImageEXTDel GetCompressedMultiTexImageEXTPtr;
        
        // glGetCompressedTexImage
        private delegate void GetCompressedTexImageDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, IntPtr /*CompressedTextureARB*/  img); private static GetCompressedTexImageDel GetCompressedTexImagePtr;
        
        // glGetCompressedTexImageARB
        private delegate void GetCompressedTexImageARBDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, IntPtr /*CompressedTextureARB*/  img); private static GetCompressedTexImageARBDel GetCompressedTexImageARBPtr;
        
        // glGetCompressedTextureImage
        private delegate void GetCompressedTextureImageDel(uint  texture, int  level, uint  bufSize, IntPtr  pixels); private static GetCompressedTextureImageDel GetCompressedTextureImagePtr;
        
        // glGetCompressedTextureImageEXT
        private delegate void GetCompressedTextureImageEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  lod, IntPtr  img); private static GetCompressedTextureImageEXTDel GetCompressedTextureImageEXTPtr;
        
        // glGetCompressedTextureSubImage
        private delegate void GetCompressedTextureSubImageDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint  bufSize, IntPtr  pixels); private static GetCompressedTextureSubImageDel GetCompressedTextureSubImagePtr;
        
        // glGetConvolutionFilter
        private delegate void GetConvolutionFilterDel(uint /*ConvolutionTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static GetConvolutionFilterDel GetConvolutionFilterPtr;
        
        // glGetConvolutionFilterEXT
        private delegate void GetConvolutionFilterEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  image); private static GetConvolutionFilterEXTDel GetConvolutionFilterEXTPtr;
        
        // glGetConvolutionParameterfv
        private delegate void GetConvolutionParameterfvDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, float[]  parameters); private static GetConvolutionParameterfvDel GetConvolutionParameterfvPtr;
        
        // glGetConvolutionParameterfvEXT
        private delegate void GetConvolutionParameterfvEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, float[]  parameters); private static GetConvolutionParameterfvEXTDel GetConvolutionParameterfvEXTPtr;
        
        // glGetConvolutionParameteriv
        private delegate void GetConvolutionParameterivDel(uint /*ConvolutionTarget*/  target, uint /*ConvolutionParameterEXT*/  pname, int[]  parameters); private static GetConvolutionParameterivDel GetConvolutionParameterivPtr;
        
        // glGetConvolutionParameterivEXT
        private delegate void GetConvolutionParameterivEXTDel(uint /*ConvolutionTargetEXT*/  target, uint /*ConvolutionParameterEXT*/  pname, int[]  parameters); private static GetConvolutionParameterivEXTDel GetConvolutionParameterivEXTPtr;
        
        // glGetConvolutionParameterxvOES
        private delegate void GetConvolutionParameterxvOESDel(uint  target, uint  pname, int[]  parameters); private static GetConvolutionParameterxvOESDel GetConvolutionParameterxvOESPtr;
        
        // glGetCoverageModulationTableNV
        private delegate void GetCoverageModulationTableNVDel(uint  bufSize, float[]  v); private static GetCoverageModulationTableNVDel GetCoverageModulationTableNVPtr;
        
        // glGetDebugMessageLog
        private delegate uint GetDebugMessageLogDel(uint  count, uint  bufSize, uint[] /*DebugSource*/  sources, uint[] /*DebugType*/  types, uint[]  ids, uint[] /*DebugSeverity*/  severities, uint[]  lengths, string  messageLog); private static GetDebugMessageLogDel GetDebugMessageLogPtr;
        
        // glGetDebugMessageLogAMD
        private delegate uint GetDebugMessageLogAMDDel(uint  count, uint  bufSize, uint[]  categories, uint[] /*DebugSeverity*/  severities, uint[]  ids, uint[]  lengths, string  message); private static GetDebugMessageLogAMDDel GetDebugMessageLogAMDPtr;
        
        // glGetDebugMessageLogARB
        private delegate uint GetDebugMessageLogARBDel(uint  count, uint  bufSize, uint[] /*DebugSource*/  sources, uint[] /*DebugType*/  types, uint[]  ids, uint[] /*DebugSeverity*/  severities, uint[]  lengths, string  messageLog); private static GetDebugMessageLogARBDel GetDebugMessageLogARBPtr;
        
        // glGetDebugMessageLogKHR
        private delegate uint GetDebugMessageLogKHRDel(uint  count, uint  bufSize, uint[] /*DebugSource*/  sources, uint[] /*DebugType*/  types, uint[]  ids, uint[] /*DebugSeverity*/  severities, uint[]  lengths, string  messageLog); private static GetDebugMessageLogKHRDel GetDebugMessageLogKHRPtr;
        
        // glGetDetailTexFuncSGIS
        private delegate void GetDetailTexFuncSGISDel(uint /*TextureTarget*/  target, float[]  points); private static GetDetailTexFuncSGISDel GetDetailTexFuncSGISPtr;
        
        // glGetDoubleIndexedvEXT
        private delegate void GetDoubleIndexedvEXTDel(uint  target, uint  index, double[]  data); private static GetDoubleIndexedvEXTDel GetDoubleIndexedvEXTPtr;
        
        // glGetDoublei_v
        private delegate void GetDoublei_vDel(uint  target, uint  index, double[]  data); private static GetDoublei_vDel GetDoublei_vPtr;
        
        // glGetDoublei_vEXT
        private delegate void GetDoublei_vEXTDel(uint  pname, uint  index, double[]  parameters); private static GetDoublei_vEXTDel GetDoublei_vEXTPtr;
        
        // glGetDoublev
        private delegate void GetDoublevDel(uint /*GetPName*/  pname, double[]  data); private static GetDoublevDel GetDoublevPtr;
        
        // glGetDriverControlStringQCOM
        private delegate void GetDriverControlStringQCOMDel(uint  driverControl, uint  bufSize, uint[]  length, string  driverControlString); private static GetDriverControlStringQCOMDel GetDriverControlStringQCOMPtr;
        
        // glGetDriverControlsQCOM
        private delegate void GetDriverControlsQCOMDel(int[]  num, uint  size, uint[]  driverControls); private static GetDriverControlsQCOMDel GetDriverControlsQCOMPtr;
        
        // glGetError
        private delegate uint /*ErrorCode*/ GetErrorDel(); private static GetErrorDel GetErrorPtr;
        
        // glGetFenceivNV
        private delegate void GetFenceivNVDel(uint /*FenceNV*/  fence, uint /*FenceParameterNameNV*/  pname, int[]  parameters); private static GetFenceivNVDel GetFenceivNVPtr;
        
        // glGetFinalCombinerInputParameterfvNV
        private delegate void GetFinalCombinerInputParameterfvNVDel(uint /*CombinerVariableNV*/  variable, uint /*CombinerParameterNV*/  pname, float[]  parameters); private static GetFinalCombinerInputParameterfvNVDel GetFinalCombinerInputParameterfvNVPtr;
        
        // glGetFinalCombinerInputParameterivNV
        private delegate void GetFinalCombinerInputParameterivNVDel(uint /*CombinerVariableNV*/  variable, uint /*CombinerParameterNV*/  pname, int[]  parameters); private static GetFinalCombinerInputParameterivNVDel GetFinalCombinerInputParameterivNVPtr;
        
        // glGetFirstPerfQueryIdINTEL
        private delegate void GetFirstPerfQueryIdINTELDel(uint[]  queryId); private static GetFirstPerfQueryIdINTELDel GetFirstPerfQueryIdINTELPtr;
        
        // glGetFixedv
        private delegate void GetFixedvDel(uint /*GetPName*/  pname, int[]  parameters); private static GetFixedvDel GetFixedvPtr;
        
        // glGetFixedvOES
        private delegate void GetFixedvOESDel(uint /*GetPName*/  pname, int[]  parameters); private static GetFixedvOESDel GetFixedvOESPtr;
        
        // glGetFloatIndexedvEXT
        private delegate void GetFloatIndexedvEXTDel(uint  target, uint  index, float[]  data); private static GetFloatIndexedvEXTDel GetFloatIndexedvEXTPtr;
        
        // glGetFloati_v
        private delegate void GetFloati_vDel(uint  target, uint  index, float[]  data); private static GetFloati_vDel GetFloati_vPtr;
        
        // glGetFloati_vEXT
        private delegate void GetFloati_vEXTDel(uint  pname, uint  index, float[]  parameters); private static GetFloati_vEXTDel GetFloati_vEXTPtr;
        
        // glGetFloati_vNV
        private delegate void GetFloati_vNVDel(uint  target, uint  index, float[]  data); private static GetFloati_vNVDel GetFloati_vNVPtr;
        
        // glGetFloati_vOES
        private delegate void GetFloati_vOESDel(uint  target, uint  index, float[]  data); private static GetFloati_vOESDel GetFloati_vOESPtr;
        
        // glGetFloatv
        private delegate void GetFloatvDel(uint /*GetPName*/  pname, float[]  data); private static GetFloatvDel GetFloatvPtr;
        
        // glGetFogFuncSGIS
        private delegate void GetFogFuncSGISDel(float[]  points); private static GetFogFuncSGISDel GetFogFuncSGISPtr;
        
        // glGetFragDataIndex
        private delegate int GetFragDataIndexDel(uint  program, string  name); private static GetFragDataIndexDel GetFragDataIndexPtr;
        
        // glGetFragDataIndexEXT
        private delegate int GetFragDataIndexEXTDel(uint  program, string  name); private static GetFragDataIndexEXTDel GetFragDataIndexEXTPtr;
        
        // glGetFragDataLocation
        private delegate int GetFragDataLocationDel(uint  program, string  name); private static GetFragDataLocationDel GetFragDataLocationPtr;
        
        // glGetFragDataLocationEXT
        private delegate int GetFragDataLocationEXTDel(uint  program, string  name); private static GetFragDataLocationEXTDel GetFragDataLocationEXTPtr;
        
        // glGetFragmentLightfvSGIX
        private delegate void GetFragmentLightfvSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, float[]  parameters); private static GetFragmentLightfvSGIXDel GetFragmentLightfvSGIXPtr;
        
        // glGetFragmentLightivSGIX
        private delegate void GetFragmentLightivSGIXDel(uint /*FragmentLightNameSGIX*/  light, uint /*FragmentLightParameterSGIX*/  pname, int[]  parameters); private static GetFragmentLightivSGIXDel GetFragmentLightivSGIXPtr;
        
        // glGetFragmentMaterialfvSGIX
        private delegate void GetFragmentMaterialfvSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float[]  parameters); private static GetFragmentMaterialfvSGIXDel GetFragmentMaterialfvSGIXPtr;
        
        // glGetFragmentMaterialivSGIX
        private delegate void GetFragmentMaterialivSGIXDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  parameters); private static GetFragmentMaterialivSGIXDel GetFragmentMaterialivSGIXPtr;
        
        // glGetFramebufferAttachmentParameteriv
        private delegate void GetFramebufferAttachmentParameterivDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetFramebufferAttachmentParameterivDel GetFramebufferAttachmentParameterivPtr;
        
        // glGetFramebufferAttachmentParameterivEXT
        private delegate void GetFramebufferAttachmentParameterivEXTDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetFramebufferAttachmentParameterivEXTDel GetFramebufferAttachmentParameterivEXTPtr;
        
        // glGetFramebufferAttachmentParameterivOES
        private delegate void GetFramebufferAttachmentParameterivOESDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachment*/  attachment, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetFramebufferAttachmentParameterivOESDel GetFramebufferAttachmentParameterivOESPtr;
        
        // glGetFramebufferParameterfvAMD
        private delegate void GetFramebufferParameterfvAMDDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachmentParameterName*/  pname, uint  numsamples, uint  pixelindex, uint  size, float[]  values); private static GetFramebufferParameterfvAMDDel GetFramebufferParameterfvAMDPtr;
        
        // glGetFramebufferParameteriv
        private delegate void GetFramebufferParameterivDel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetFramebufferParameterivDel GetFramebufferParameterivPtr;
        
        // glGetFramebufferParameterivEXT
        private delegate void GetFramebufferParameterivEXTDel(uint /*Framebuffer*/  framebuffer, uint /*GetFramebufferParameter*/  pname, int[]  parameters); private static GetFramebufferParameterivEXTDel GetFramebufferParameterivEXTPtr;
        
        // glGetFramebufferPixelLocalStorageSizeEXT
        private delegate uint GetFramebufferPixelLocalStorageSizeEXTDel(uint /*FramebufferTarget*/  target); private static GetFramebufferPixelLocalStorageSizeEXTDel GetFramebufferPixelLocalStorageSizeEXTPtr;
        
        // glGetGraphicsResetStatus
        private delegate uint /*GraphicsResetStatus*/ GetGraphicsResetStatusDel(); private static GetGraphicsResetStatusDel GetGraphicsResetStatusPtr;
        
        // glGetGraphicsResetStatusARB
        private delegate uint /*GraphicsResetStatus*/ GetGraphicsResetStatusARBDel(); private static GetGraphicsResetStatusARBDel GetGraphicsResetStatusARBPtr;
        
        // glGetGraphicsResetStatusEXT
        private delegate uint /*GraphicsResetStatus*/ GetGraphicsResetStatusEXTDel(); private static GetGraphicsResetStatusEXTDel GetGraphicsResetStatusEXTPtr;
        
        // glGetGraphicsResetStatusKHR
        private delegate uint /*GraphicsResetStatus*/ GetGraphicsResetStatusKHRDel(); private static GetGraphicsResetStatusKHRDel GetGraphicsResetStatusKHRPtr;
        
        // glGetHandleARB
        private delegate IntPtr /*handleARB*/ GetHandleARBDel(uint  pname); private static GetHandleARBDel GetHandleARBPtr;
        
        // glGetHistogram
        private delegate void GetHistogramDel(uint /*HistogramTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  values); private static GetHistogramDel GetHistogramPtr;
        
        // glGetHistogramEXT
        private delegate void GetHistogramEXTDel(uint /*HistogramTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  values); private static GetHistogramEXTDel GetHistogramEXTPtr;
        
        // glGetHistogramParameterfv
        private delegate void GetHistogramParameterfvDel(uint /*HistogramTargetEXT*/  target, uint /*GetHistogramParameterPNameEXT*/  pname, float[]  parameters); private static GetHistogramParameterfvDel GetHistogramParameterfvPtr;
        
        // glGetHistogramParameterfvEXT
        private delegate void GetHistogramParameterfvEXTDel(uint /*HistogramTargetEXT*/  target, uint /*GetHistogramParameterPNameEXT*/  pname, float[]  parameters); private static GetHistogramParameterfvEXTDel GetHistogramParameterfvEXTPtr;
        
        // glGetHistogramParameteriv
        private delegate void GetHistogramParameterivDel(uint /*HistogramTargetEXT*/  target, uint /*GetHistogramParameterPNameEXT*/  pname, int[]  parameters); private static GetHistogramParameterivDel GetHistogramParameterivPtr;
        
        // glGetHistogramParameterivEXT
        private delegate void GetHistogramParameterivEXTDel(uint /*HistogramTargetEXT*/  target, uint /*GetHistogramParameterPNameEXT*/  pname, int[]  parameters); private static GetHistogramParameterivEXTDel GetHistogramParameterivEXTPtr;
        
        // glGetHistogramParameterxvOES
        private delegate void GetHistogramParameterxvOESDel(uint /*HistogramTargetEXT*/  target, uint /*GetHistogramParameterPNameEXT*/  pname, int[]  parameters); private static GetHistogramParameterxvOESDel GetHistogramParameterxvOESPtr;
        
        // glGetImageHandleARB
        private delegate ulong GetImageHandleARBDel(uint  texture, int  level, bool /*Boolean*/  layered, int  layer, uint /*PixelFormat*/  format); private static GetImageHandleARBDel GetImageHandleARBPtr;
        
        // glGetImageHandleNV
        private delegate ulong GetImageHandleNVDel(uint  texture, int  level, bool /*Boolean*/  layered, int  layer, uint /*PixelFormat*/  format); private static GetImageHandleNVDel GetImageHandleNVPtr;
        
        // glGetImageTransformParameterfvHP
        private delegate void GetImageTransformParameterfvHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, float[]  parameters); private static GetImageTransformParameterfvHPDel GetImageTransformParameterfvHPPtr;
        
        // glGetImageTransformParameterivHP
        private delegate void GetImageTransformParameterivHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, int[]  parameters); private static GetImageTransformParameterivHPDel GetImageTransformParameterivHPPtr;
        
        // glGetInfoLogARB
        private delegate void GetInfoLogARBDel(IntPtr /*handleARB*/  obj, uint  maxLength, uint[]  length, string  infoLog); private static GetInfoLogARBDel GetInfoLogARBPtr;
        
        // glGetInstrumentsSGIX
        private delegate int GetInstrumentsSGIXDel(); private static GetInstrumentsSGIXDel GetInstrumentsSGIXPtr;
        
        // glGetInteger64i_v
        private delegate void GetInteger64i_vDel(uint  target, uint  index, long[]  data); private static GetInteger64i_vDel GetInteger64i_vPtr;
        
        // glGetInteger64v
        private delegate void GetInteger64vDel(uint /*GetPName*/  pname, long[]  data); private static GetInteger64vDel GetInteger64vPtr;
        
        // glGetInteger64vAPPLE
        private delegate void GetInteger64vAPPLEDel(uint /*GetPName*/  pname, long[]  parameters); private static GetInteger64vAPPLEDel GetInteger64vAPPLEPtr;
        
        // glGetInteger64vEXT
        private delegate void GetInteger64vEXTDel(uint /*GetPName*/  pname, long[]  data); private static GetInteger64vEXTDel GetInteger64vEXTPtr;
        
        // glGetIntegerIndexedvEXT
        private delegate void GetIntegerIndexedvEXTDel(uint  target, uint  index, int[]  data); private static GetIntegerIndexedvEXTDel GetIntegerIndexedvEXTPtr;
        
        // glGetIntegeri_v
        private delegate void GetIntegeri_vDel(uint  target, uint  index, int[]  data); private static GetIntegeri_vDel GetIntegeri_vPtr;
        
        // glGetIntegeri_vEXT
        private delegate void GetIntegeri_vEXTDel(uint  target, uint  index, int[]  data); private static GetIntegeri_vEXTDel GetIntegeri_vEXTPtr;
        
        // glGetIntegerui64i_vNV
        private delegate void GetIntegerui64i_vNVDel(uint  value, uint  index, ulong[]  result); private static GetIntegerui64i_vNVDel GetIntegerui64i_vNVPtr;
        
        // glGetIntegerui64vNV
        private delegate void GetIntegerui64vNVDel(uint  value, ulong[]  result); private static GetIntegerui64vNVDel GetIntegerui64vNVPtr;
        
        // glGetIntegerv
        private delegate void GetIntegervDel(uint /*GetPName*/  pname, int[]  data); private static GetIntegervDel GetIntegervPtr;
        
        // glGetInternalformatSampleivNV
        private delegate void GetInternalformatSampleivNVDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  samples, uint /*InternalFormatPName*/  pname, uint  count, int[]  parameters); private static GetInternalformatSampleivNVDel GetInternalformatSampleivNVPtr;
        
        // glGetInternalformati64v
        private delegate void GetInternalformati64vDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint /*InternalFormatPName*/  pname, uint  count, long[]  parameters); private static GetInternalformati64vDel GetInternalformati64vPtr;
        
        // glGetInternalformativ
        private delegate void GetInternalformativDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint /*InternalFormatPName*/  pname, uint  count, int[]  parameters); private static GetInternalformativDel GetInternalformativPtr;
        
        // glGetInvariantBooleanvEXT
        private delegate void GetInvariantBooleanvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, bool[] /*Boolean*/  data); private static GetInvariantBooleanvEXTDel GetInvariantBooleanvEXTPtr;
        
        // glGetInvariantFloatvEXT
        private delegate void GetInvariantFloatvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, float[]  data); private static GetInvariantFloatvEXTDel GetInvariantFloatvEXTPtr;
        
        // glGetInvariantIntegervEXT
        private delegate void GetInvariantIntegervEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, int[]  data); private static GetInvariantIntegervEXTDel GetInvariantIntegervEXTPtr;
        
        // glGetLightfv
        private delegate void GetLightfvDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, float[]  parameters); private static GetLightfvDel GetLightfvPtr;
        
        // glGetLightiv
        private delegate void GetLightivDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static GetLightivDel GetLightivPtr;
        
        // glGetLightxOES
        private delegate void GetLightxOESDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static GetLightxOESDel GetLightxOESPtr;
        
        // glGetLightxv
        private delegate void GetLightxvDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static GetLightxvDel GetLightxvPtr;
        
        // glGetLightxvOES
        private delegate void GetLightxvOESDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static GetLightxvOESDel GetLightxvOESPtr;
        
        // glGetListParameterfvSGIX
        private delegate void GetListParameterfvSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, float[] /*CheckedFloat32*/  parameters); private static GetListParameterfvSGIXDel GetListParameterfvSGIXPtr;
        
        // glGetListParameterivSGIX
        private delegate void GetListParameterivSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static GetListParameterivSGIXDel GetListParameterivSGIXPtr;
        
        // glGetLocalConstantBooleanvEXT
        private delegate void GetLocalConstantBooleanvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, bool[] /*Boolean*/  data); private static GetLocalConstantBooleanvEXTDel GetLocalConstantBooleanvEXTPtr;
        
        // glGetLocalConstantFloatvEXT
        private delegate void GetLocalConstantFloatvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, float[]  data); private static GetLocalConstantFloatvEXTDel GetLocalConstantFloatvEXTPtr;
        
        // glGetLocalConstantIntegervEXT
        private delegate void GetLocalConstantIntegervEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, int[]  data); private static GetLocalConstantIntegervEXTDel GetLocalConstantIntegervEXTPtr;
        
        // glGetMapAttribParameterfvNV
        private delegate void GetMapAttribParameterfvNVDel(uint /*EvalTargetNV*/  target, uint  index, uint /*MapAttribParameterNV*/  pname, float[]  parameters); private static GetMapAttribParameterfvNVDel GetMapAttribParameterfvNVPtr;
        
        // glGetMapAttribParameterivNV
        private delegate void GetMapAttribParameterivNVDel(uint /*EvalTargetNV*/  target, uint  index, uint /*MapAttribParameterNV*/  pname, int[]  parameters); private static GetMapAttribParameterivNVDel GetMapAttribParameterivNVPtr;
        
        // glGetMapControlPointsNV
        private delegate void GetMapControlPointsNVDel(uint /*EvalTargetNV*/  target, uint  index, uint /*MapTypeNV*/  type, uint  ustride, uint  vstride, bool /*Boolean*/  packed, IntPtr  points); private static GetMapControlPointsNVDel GetMapControlPointsNVPtr;
        
        // glGetMapParameterfvNV
        private delegate void GetMapParameterfvNVDel(uint /*EvalTargetNV*/  target, uint /*MapParameterNV*/  pname, float[]  parameters); private static GetMapParameterfvNVDel GetMapParameterfvNVPtr;
        
        // glGetMapParameterivNV
        private delegate void GetMapParameterivNVDel(uint /*EvalTargetNV*/  target, uint /*MapParameterNV*/  pname, int[]  parameters); private static GetMapParameterivNVDel GetMapParameterivNVPtr;
        
        // glGetMapdv
        private delegate void GetMapdvDel(uint /*MapTarget*/  target, uint /*GetMapQuery*/  query, double[]  v); private static GetMapdvDel GetMapdvPtr;
        
        // glGetMapfv
        private delegate void GetMapfvDel(uint /*MapTarget*/  target, uint /*GetMapQuery*/  query, float[]  v); private static GetMapfvDel GetMapfvPtr;
        
        // glGetMapiv
        private delegate void GetMapivDel(uint /*MapTarget*/  target, uint /*GetMapQuery*/  query, int[]  v); private static GetMapivDel GetMapivPtr;
        
        // glGetMapxvOES
        private delegate void GetMapxvOESDel(uint /*MapTarget*/  target, uint /*GetMapQuery*/  query, int[]  v); private static GetMapxvOESDel GetMapxvOESPtr;
        
        // glGetMaterialfv
        private delegate void GetMaterialfvDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float[]  parameters); private static GetMaterialfvDel GetMaterialfvPtr;
        
        // glGetMaterialiv
        private delegate void GetMaterialivDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  parameters); private static GetMaterialivDel GetMaterialivPtr;
        
        // glGetMaterialxOES
        private delegate void GetMaterialxOESDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int  param); private static GetMaterialxOESDel GetMaterialxOESPtr;
        
        // glGetMaterialxv
        private delegate void GetMaterialxvDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  parameters); private static GetMaterialxvDel GetMaterialxvPtr;
        
        // glGetMaterialxvOES
        private delegate void GetMaterialxvOESDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  parameters); private static GetMaterialxvOESDel GetMaterialxvOESPtr;
        
        // glGetMemoryObjectDetachedResourcesuivNV
        private delegate void GetMemoryObjectDetachedResourcesuivNVDel(uint  memory, uint  pname, int  first, uint  count, uint[]  parameters); private static GetMemoryObjectDetachedResourcesuivNVDel GetMemoryObjectDetachedResourcesuivNVPtr;
        
        // glGetMemoryObjectParameterivEXT
        private delegate void GetMemoryObjectParameterivEXTDel(uint  memoryObject, uint /*MemoryObjectParameterName*/  pname, int[]  parameters); private static GetMemoryObjectParameterivEXTDel GetMemoryObjectParameterivEXTPtr;
        
        // glGetMinmax
        private delegate void GetMinmaxDel(uint /*MinmaxTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  values); private static GetMinmaxDel GetMinmaxPtr;
        
        // glGetMinmaxEXT
        private delegate void GetMinmaxEXTDel(uint /*MinmaxTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  values); private static GetMinmaxEXTDel GetMinmaxEXTPtr;
        
        // glGetMinmaxParameterfv
        private delegate void GetMinmaxParameterfvDel(uint /*MinmaxTargetEXT*/  target, uint /*GetMinmaxParameterPNameEXT*/  pname, float[]  parameters); private static GetMinmaxParameterfvDel GetMinmaxParameterfvPtr;
        
        // glGetMinmaxParameterfvEXT
        private delegate void GetMinmaxParameterfvEXTDel(uint /*MinmaxTargetEXT*/  target, uint /*GetMinmaxParameterPNameEXT*/  pname, float[]  parameters); private static GetMinmaxParameterfvEXTDel GetMinmaxParameterfvEXTPtr;
        
        // glGetMinmaxParameteriv
        private delegate void GetMinmaxParameterivDel(uint /*MinmaxTargetEXT*/  target, uint /*GetMinmaxParameterPNameEXT*/  pname, int[]  parameters); private static GetMinmaxParameterivDel GetMinmaxParameterivPtr;
        
        // glGetMinmaxParameterivEXT
        private delegate void GetMinmaxParameterivEXTDel(uint /*MinmaxTargetEXT*/  target, uint /*GetMinmaxParameterPNameEXT*/  pname, int[]  parameters); private static GetMinmaxParameterivEXTDel GetMinmaxParameterivEXTPtr;
        
        // glGetMultiTexEnvfvEXT
        private delegate void GetMultiTexEnvfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float[]  parameters); private static GetMultiTexEnvfvEXTDel GetMultiTexEnvfvEXTPtr;
        
        // glGetMultiTexEnvivEXT
        private delegate void GetMultiTexEnvivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static GetMultiTexEnvivEXTDel GetMultiTexEnvivEXTPtr;
        
        // glGetMultiTexGendvEXT
        private delegate void GetMultiTexGendvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double[]  parameters); private static GetMultiTexGendvEXTDel GetMultiTexGendvEXTPtr;
        
        // glGetMultiTexGenfvEXT
        private delegate void GetMultiTexGenfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[]  parameters); private static GetMultiTexGenfvEXTDel GetMultiTexGenfvEXTPtr;
        
        // glGetMultiTexGenivEXT
        private delegate void GetMultiTexGenivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static GetMultiTexGenivEXTDel GetMultiTexGenivEXTPtr;
        
        // glGetMultiTexImageEXT
        private delegate void GetMultiTexImageEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static GetMultiTexImageEXTDel GetMultiTexImageEXTPtr;
        
        // glGetMultiTexLevelParameterfvEXT
        private delegate void GetMultiTexLevelParameterfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetMultiTexLevelParameterfvEXTDel GetMultiTexLevelParameterfvEXTPtr;
        
        // glGetMultiTexLevelParameterivEXT
        private delegate void GetMultiTexLevelParameterivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetMultiTexLevelParameterivEXTDel GetMultiTexLevelParameterivEXTPtr;
        
        // glGetMultiTexParameterIivEXT
        private delegate void GetMultiTexParameterIivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetMultiTexParameterIivEXTDel GetMultiTexParameterIivEXTPtr;
        
        // glGetMultiTexParameterIuivEXT
        private delegate void GetMultiTexParameterIuivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetMultiTexParameterIuivEXTDel GetMultiTexParameterIuivEXTPtr;
        
        // glGetMultiTexParameterfvEXT
        private delegate void GetMultiTexParameterfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetMultiTexParameterfvEXTDel GetMultiTexParameterfvEXTPtr;
        
        // glGetMultiTexParameterivEXT
        private delegate void GetMultiTexParameterivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetMultiTexParameterivEXTDel GetMultiTexParameterivEXTPtr;
        
        // glGetMultisamplefv
        private delegate void GetMultisamplefvDel(uint /*GetMultisamplePNameNV*/  pname, uint  index, float[]  val); private static GetMultisamplefvDel GetMultisamplefvPtr;
        
        // glGetMultisamplefvNV
        private delegate void GetMultisamplefvNVDel(uint /*GetMultisamplePNameNV*/  pname, uint  index, float[]  val); private static GetMultisamplefvNVDel GetMultisamplefvNVPtr;
        
        // glGetNamedBufferParameteri64v
        private delegate void GetNamedBufferParameteri64vDel(uint  buffer, uint /*BufferPNameARB*/  pname, long[]  parameters); private static GetNamedBufferParameteri64vDel GetNamedBufferParameteri64vPtr;
        
        // glGetNamedBufferParameteriv
        private delegate void GetNamedBufferParameterivDel(uint  buffer, uint /*BufferPNameARB*/  pname, int[]  parameters); private static GetNamedBufferParameterivDel GetNamedBufferParameterivPtr;
        
        // glGetNamedBufferParameterivEXT
        private delegate void GetNamedBufferParameterivEXTDel(uint  buffer, uint /*BufferPNameARB*/  pname, int[]  parameters); private static GetNamedBufferParameterivEXTDel GetNamedBufferParameterivEXTPtr;
        
        // glGetNamedBufferParameterui64vNV
        private delegate void GetNamedBufferParameterui64vNVDel(uint  buffer, uint /*BufferPNameARB*/  pname, ulong[]  parameters); private static GetNamedBufferParameterui64vNVDel GetNamedBufferParameterui64vNVPtr;
        
        // glGetNamedBufferPointerv
        private delegate void GetNamedBufferPointervDel(uint  buffer, uint /*BufferPointerNameARB*/  pname, IntPtr  parameters); private static GetNamedBufferPointervDel GetNamedBufferPointervPtr;
        
        // glGetNamedBufferPointervEXT
        private delegate void GetNamedBufferPointervEXTDel(uint  buffer, uint /*BufferPointerNameARB*/  pname, IntPtr  parameters); private static GetNamedBufferPointervEXTDel GetNamedBufferPointervEXTPtr;
        
        // glGetNamedBufferSubData
        private delegate void GetNamedBufferSubDataDel(uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  size, IntPtr  data); private static GetNamedBufferSubDataDel GetNamedBufferSubDataPtr;
        
        // glGetNamedBufferSubDataEXT
        private delegate void GetNamedBufferSubDataEXTDel(uint  buffer, IntPtr  offset, IntPtr  size, IntPtr  data); private static GetNamedBufferSubDataEXTDel GetNamedBufferSubDataEXTPtr;
        
        // glGetNamedFramebufferParameterfvAMD
        private delegate void GetNamedFramebufferParameterfvAMDDel(uint  framebuffer, uint  pname, uint  numsamples, uint  pixelindex, uint  size, float[]  values); private static GetNamedFramebufferParameterfvAMDDel GetNamedFramebufferParameterfvAMDPtr;
        
        // glGetNamedFramebufferAttachmentParameteriv
        private delegate void GetNamedFramebufferAttachmentParameterivDel(uint  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetNamedFramebufferAttachmentParameterivDel GetNamedFramebufferAttachmentParameterivPtr;
        
        // glGetNamedFramebufferAttachmentParameterivEXT
        private delegate void GetNamedFramebufferAttachmentParameterivEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetNamedFramebufferAttachmentParameterivEXTDel GetNamedFramebufferAttachmentParameterivEXTPtr;
        
        // glGetNamedFramebufferParameteriv
        private delegate void GetNamedFramebufferParameterivDel(uint  framebuffer, uint /*GetFramebufferParameter*/  pname, int[]  param); private static GetNamedFramebufferParameterivDel GetNamedFramebufferParameterivPtr;
        
        // glGetNamedFramebufferParameterivEXT
        private delegate void GetNamedFramebufferParameterivEXTDel(uint /*Framebuffer*/  framebuffer, uint /*GetFramebufferParameter*/  pname, int[]  parameters); private static GetNamedFramebufferParameterivEXTDel GetNamedFramebufferParameterivEXTPtr;
        
        // glGetNamedProgramLocalParameterIivEXT
        private delegate void GetNamedProgramLocalParameterIivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static GetNamedProgramLocalParameterIivEXTDel GetNamedProgramLocalParameterIivEXTPtr;
        
        // glGetNamedProgramLocalParameterIuivEXT
        private delegate void GetNamedProgramLocalParameterIuivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static GetNamedProgramLocalParameterIuivEXTDel GetNamedProgramLocalParameterIuivEXTPtr;
        
        // glGetNamedProgramLocalParameterdvEXT
        private delegate void GetNamedProgramLocalParameterdvEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static GetNamedProgramLocalParameterdvEXTDel GetNamedProgramLocalParameterdvEXTPtr;
        
        // glGetNamedProgramLocalParameterfvEXT
        private delegate void GetNamedProgramLocalParameterfvEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static GetNamedProgramLocalParameterfvEXTDel GetNamedProgramLocalParameterfvEXTPtr;
        
        // glGetNamedProgramStringEXT
        private delegate void GetNamedProgramStringEXTDel(uint  program, uint /*ProgramTarget*/  target, uint /*ProgramStringProperty*/  pname, IntPtr  str); private static GetNamedProgramStringEXTDel GetNamedProgramStringEXTPtr;
        
        // glGetNamedProgramivEXT
        private delegate void GetNamedProgramivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint /*ProgramPropertyARB*/  pname, int[]  parameters); private static GetNamedProgramivEXTDel GetNamedProgramivEXTPtr;
        
        // glGetNamedRenderbufferParameteriv
        private delegate void GetNamedRenderbufferParameterivDel(uint  renderbuffer, uint /*RenderbufferParameterName*/  pname, int[]  parameters); private static GetNamedRenderbufferParameterivDel GetNamedRenderbufferParameterivPtr;
        
        // glGetNamedRenderbufferParameterivEXT
        private delegate void GetNamedRenderbufferParameterivEXTDel(uint /*Renderbuffer*/  renderbuffer, uint /*RenderbufferParameterName*/  pname, int[]  parameters); private static GetNamedRenderbufferParameterivEXTDel GetNamedRenderbufferParameterivEXTPtr;
        
        // glGetNamedStringARB
        private delegate void GetNamedStringARBDel(int  namelen, string  name, uint  bufSize, int[]  stringlen, string  str); private static GetNamedStringARBDel GetNamedStringARBPtr;
        
        // glGetNamedStringivARB
        private delegate void GetNamedStringivARBDel(int  namelen, string  name, uint  pname, int[]  parameters); private static GetNamedStringivARBDel GetNamedStringivARBPtr;
        
        // glGetNextPerfQueryIdINTEL
        private delegate void GetNextPerfQueryIdINTELDel(uint  queryId, uint[]  nextQueryId); private static GetNextPerfQueryIdINTELDel GetNextPerfQueryIdINTELPtr;
        
        // glGetObjectBufferfvATI
        private delegate void GetObjectBufferfvATIDel(uint  buffer, uint /*ArrayObjectPNameATI*/  pname, float[]  parameters); private static GetObjectBufferfvATIDel GetObjectBufferfvATIPtr;
        
        // glGetObjectBufferivATI
        private delegate void GetObjectBufferivATIDel(uint  buffer, uint /*ArrayObjectPNameATI*/  pname, int[]  parameters); private static GetObjectBufferivATIDel GetObjectBufferivATIPtr;
        
        // glGetObjectLabel
        private delegate void GetObjectLabelDel(uint /*ObjectIdentifier*/  identifier, uint  name, uint  bufSize, uint[]  length, string  label); private static GetObjectLabelDel GetObjectLabelPtr;
        
        // glGetObjectLabelEXT
        private delegate void GetObjectLabelEXTDel(uint  type, uint  obj, uint  bufSize, uint[]  length, string  label); private static GetObjectLabelEXTDel GetObjectLabelEXTPtr;
        
        // glGetObjectLabelKHR
        private delegate void GetObjectLabelKHRDel(uint  identifier, uint  name, uint  bufSize, uint[]  length, string  label); private static GetObjectLabelKHRDel GetObjectLabelKHRPtr;
        
        // glGetObjectParameterfvARB
        private delegate void GetObjectParameterfvARBDel(IntPtr /*handleARB*/  obj, uint  pname, float[]  parameters); private static GetObjectParameterfvARBDel GetObjectParameterfvARBPtr;
        
        // glGetObjectParameterivAPPLE
        private delegate void GetObjectParameterivAPPLEDel(uint  objectType, uint  name, uint  pname, int[]  parameters); private static GetObjectParameterivAPPLEDel GetObjectParameterivAPPLEPtr;
        
        // glGetObjectParameterivARB
        private delegate void GetObjectParameterivARBDel(IntPtr /*handleARB*/  obj, uint  pname, int[]  parameters); private static GetObjectParameterivARBDel GetObjectParameterivARBPtr;
        
        // glGetObjectPtrLabel
        private delegate void GetObjectPtrLabelDel(IntPtr  ptr, uint  bufSize, uint[]  length, string  label); private static GetObjectPtrLabelDel GetObjectPtrLabelPtr;
        
        // glGetObjectPtrLabelKHR
        private delegate void GetObjectPtrLabelKHRDel(IntPtr  ptr, uint  bufSize, uint[]  length, string  label); private static GetObjectPtrLabelKHRDel GetObjectPtrLabelKHRPtr;
        
        // glGetOcclusionQueryivNV
        private delegate void GetOcclusionQueryivNVDel(uint  id, uint /*OcclusionQueryParameterNameNV*/  pname, int[]  parameters); private static GetOcclusionQueryivNVDel GetOcclusionQueryivNVPtr;
        
        // glGetOcclusionQueryuivNV
        private delegate void GetOcclusionQueryuivNVDel(uint  id, uint /*OcclusionQueryParameterNameNV*/  pname, uint[]  parameters); private static GetOcclusionQueryuivNVDel GetOcclusionQueryuivNVPtr;
        
        // glGetPathColorGenfvNV
        private delegate void GetPathColorGenfvNVDel(uint /*PathColor*/  color, uint /*PathGenMode*/  pname, float[]  value); private static GetPathColorGenfvNVDel GetPathColorGenfvNVPtr;
        
        // glGetPathColorGenivNV
        private delegate void GetPathColorGenivNVDel(uint /*PathColor*/  color, uint /*PathGenMode*/  pname, int[]  value); private static GetPathColorGenivNVDel GetPathColorGenivNVPtr;
        
        // glGetPathCommandsNV
        private delegate void GetPathCommandsNVDel(uint /*Path*/  path, byte[] /*PathCommand*/  commands); private static GetPathCommandsNVDel GetPathCommandsNVPtr;
        
        // glGetPathCoordsNV
        private delegate void GetPathCoordsNVDel(uint /*Path*/  path, float[]  coords); private static GetPathCoordsNVDel GetPathCoordsNVPtr;
        
        // glGetPathDashArrayNV
        private delegate void GetPathDashArrayNVDel(uint /*Path*/  path, float[]  dashArray); private static GetPathDashArrayNVDel GetPathDashArrayNVPtr;
        
        // glGetPathLengthNV
        private delegate float GetPathLengthNVDel(uint /*Path*/  path, uint  startSegment, uint  numSegments); private static GetPathLengthNVDel GetPathLengthNVPtr;
        
        // glGetPathMetricRangeNV
        private delegate void GetPathMetricRangeNVDel(uint /*PathMetricMask*/  metricQueryMask, uint /*Path*/  firstPathName, uint  numPaths, uint  stride, float[]  metrics); private static GetPathMetricRangeNVDel GetPathMetricRangeNVPtr;
        
        // glGetPathMetricsNV
        private delegate void GetPathMetricsNVDel(uint /*PathMetricMask*/  metricQueryMask, uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, uint  stride, float[]  metrics); private static GetPathMetricsNVDel GetPathMetricsNVPtr;
        
        // glGetPathParameterfvNV
        private delegate void GetPathParameterfvNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, float[]  value); private static GetPathParameterfvNVDel GetPathParameterfvNVPtr;
        
        // glGetPathParameterivNV
        private delegate void GetPathParameterivNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, int[]  value); private static GetPathParameterivNVDel GetPathParameterivNVPtr;
        
        // glGetPathSpacingNV
        private delegate void GetPathSpacingNVDel(uint /*PathListMode*/  pathListMode, uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, float  advanceScale, float  kerningScale, uint /*PathTransformType*/  transformType, float[]  returnedSpacing); private static GetPathSpacingNVDel GetPathSpacingNVPtr;
        
        // glGetPathTexGenfvNV
        private delegate void GetPathTexGenfvNVDel(uint /*TextureUnit*/  texCoordSet, uint /*PathGenMode*/  pname, float[]  value); private static GetPathTexGenfvNVDel GetPathTexGenfvNVPtr;
        
        // glGetPathTexGenivNV
        private delegate void GetPathTexGenivNVDel(uint /*TextureUnit*/  texCoordSet, uint /*PathGenMode*/  pname, int[]  value); private static GetPathTexGenivNVDel GetPathTexGenivNVPtr;
        
        // glGetPerfCounterInfoINTEL
        private delegate void GetPerfCounterInfoINTELDel(uint  queryId, uint  counterId, uint  counterNameLength, string  counterName, uint  counterDescLength, string  counterDesc, uint[]  counterOffset, uint[]  counterDataSize, uint[]  counterTypeEnum, uint[]  counterDataTypeEnum, ulong[]  rawCounterMaxValue); private static GetPerfCounterInfoINTELDel GetPerfCounterInfoINTELPtr;
        
        // glGetPerfMonitorCounterDataAMD
        private delegate void GetPerfMonitorCounterDataAMDDel(uint  monitor, uint  pname, uint  dataSize, uint[]  data, int[]  bytesWritten); private static GetPerfMonitorCounterDataAMDDel GetPerfMonitorCounterDataAMDPtr;
        
        // glGetPerfMonitorCounterInfoAMD
        private delegate void GetPerfMonitorCounterInfoAMDDel(uint  group, uint  counter, uint  pname, IntPtr  data); private static GetPerfMonitorCounterInfoAMDDel GetPerfMonitorCounterInfoAMDPtr;
        
        // glGetPerfMonitorCounterStringAMD
        private delegate void GetPerfMonitorCounterStringAMDDel(uint  group, uint  counter, uint  bufSize, uint[]  length, string  counterString); private static GetPerfMonitorCounterStringAMDDel GetPerfMonitorCounterStringAMDPtr;
        
        // glGetPerfMonitorCountersAMD
        private delegate void GetPerfMonitorCountersAMDDel(uint  group, int[]  numCounters, int[]  maxActiveCounters, uint  counterSize, uint[]  counters); private static GetPerfMonitorCountersAMDDel GetPerfMonitorCountersAMDPtr;
        
        // glGetPerfMonitorGroupStringAMD
        private delegate void GetPerfMonitorGroupStringAMDDel(uint  group, uint  bufSize, uint[]  length, string  groupString); private static GetPerfMonitorGroupStringAMDDel GetPerfMonitorGroupStringAMDPtr;
        
        // glGetPerfMonitorGroupsAMD
        private delegate void GetPerfMonitorGroupsAMDDel(int[]  numGroups, uint  groupsSize, uint[]  groups); private static GetPerfMonitorGroupsAMDDel GetPerfMonitorGroupsAMDPtr;
        
        // glGetPerfQueryDataINTEL
        private delegate void GetPerfQueryDataINTELDel(uint  queryHandle, uint  flags, uint  dataSize, IntPtr  data, uint[]  bytesWritten); private static GetPerfQueryDataINTELDel GetPerfQueryDataINTELPtr;
        
        // glGetPerfQueryIdByNameINTEL
        private delegate void GetPerfQueryIdByNameINTELDel(string  queryName, uint[]  queryId); private static GetPerfQueryIdByNameINTELDel GetPerfQueryIdByNameINTELPtr;
        
        // glGetPerfQueryInfoINTEL
        private delegate void GetPerfQueryInfoINTELDel(uint  queryId, uint  queryNameLength, string  queryName, uint[]  dataSize, uint[]  noCounters, uint[]  noInstances, uint[]  capsMask); private static GetPerfQueryInfoINTELDel GetPerfQueryInfoINTELPtr;
        
        // glGetPixelMapfv
        private delegate void GetPixelMapfvDel(uint /*PixelMap*/  map, float[]  values); private static GetPixelMapfvDel GetPixelMapfvPtr;
        
        // glGetPixelMapuiv
        private delegate void GetPixelMapuivDel(uint /*PixelMap*/  map, uint[]  values); private static GetPixelMapuivDel GetPixelMapuivPtr;
        
        // glGetPixelMapusv
        private delegate void GetPixelMapusvDel(uint /*PixelMap*/  map, ushort[]  values); private static GetPixelMapusvDel GetPixelMapusvPtr;
        
        // glGetPixelMapxv
        private delegate void GetPixelMapxvDel(uint /*PixelMap*/  map, int  size, int[]  values); private static GetPixelMapxvDel GetPixelMapxvPtr;
        
        // glGetPixelTexGenParameterfvSGIS
        private delegate void GetPixelTexGenParameterfvSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, float[] /*CheckedFloat32*/  parameters); private static GetPixelTexGenParameterfvSGISDel GetPixelTexGenParameterfvSGISPtr;
        
        // glGetPixelTexGenParameterivSGIS
        private delegate void GetPixelTexGenParameterivSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, int[] /*CheckedInt32*/  parameters); private static GetPixelTexGenParameterivSGISDel GetPixelTexGenParameterivSGISPtr;
        
        // glGetPixelTransformParameterfvEXT
        private delegate void GetPixelTransformParameterfvEXTDel(uint  target, uint  pname, float[]  parameters); private static GetPixelTransformParameterfvEXTDel GetPixelTransformParameterfvEXTPtr;
        
        // glGetPixelTransformParameterivEXT
        private delegate void GetPixelTransformParameterivEXTDel(uint  target, uint  pname, int[]  parameters); private static GetPixelTransformParameterivEXTDel GetPixelTransformParameterivEXTPtr;
        
        // glGetPointerIndexedvEXT
        private delegate void GetPointerIndexedvEXTDel(uint  target, uint  index, IntPtr  data); private static GetPointerIndexedvEXTDel GetPointerIndexedvEXTPtr;
        
        // glGetPointeri_vEXT
        private delegate void GetPointeri_vEXTDel(uint  pname, uint  index, IntPtr  parameters); private static GetPointeri_vEXTDel GetPointeri_vEXTPtr;
        
        // glGetPointerv
        private delegate void GetPointervDel(uint /*GetPointervPName*/  pname, IntPtr  parameters); private static GetPointervDel GetPointervPtr;
        
        // glGetPointervEXT
        private delegate void GetPointervEXTDel(uint /*GetPointervPName*/  pname, IntPtr  parameters); private static GetPointervEXTDel GetPointervEXTPtr;
        
        // glGetPointervKHR
        private delegate void GetPointervKHRDel(uint  pname, IntPtr  parameters); private static GetPointervKHRDel GetPointervKHRPtr;
        
        // glGetPolygonStipple
        private delegate void GetPolygonStippleDel(byte[]  mask); private static GetPolygonStippleDel GetPolygonStipplePtr;
        
        // glGetProgramBinary
        private delegate void GetProgramBinaryDel(uint  program, uint  bufSize, uint[]  length, uint[]  binaryFormat, IntPtr  binary); private static GetProgramBinaryDel GetProgramBinaryPtr;
        
        // glGetProgramBinaryOES
        private delegate void GetProgramBinaryOESDel(uint  program, uint  bufSize, uint[]  length, uint[]  binaryFormat, IntPtr  binary); private static GetProgramBinaryOESDel GetProgramBinaryOESPtr;
        
        // glGetProgramEnvParameterIivNV
        private delegate void GetProgramEnvParameterIivNVDel(uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static GetProgramEnvParameterIivNVDel GetProgramEnvParameterIivNVPtr;
        
        // glGetProgramEnvParameterIuivNV
        private delegate void GetProgramEnvParameterIuivNVDel(uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static GetProgramEnvParameterIuivNVDel GetProgramEnvParameterIuivNVPtr;
        
        // glGetProgramEnvParameterdvARB
        private delegate void GetProgramEnvParameterdvARBDel(uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static GetProgramEnvParameterdvARBDel GetProgramEnvParameterdvARBPtr;
        
        // glGetProgramEnvParameterfvARB
        private delegate void GetProgramEnvParameterfvARBDel(uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static GetProgramEnvParameterfvARBDel GetProgramEnvParameterfvARBPtr;
        
        // glGetProgramInfoLog
        private delegate void GetProgramInfoLogDel(uint  program, uint  bufSize, uint[]  length, string  infoLog); private static GetProgramInfoLogDel GetProgramInfoLogPtr;
        
        // glGetProgramInterfaceiv
        private delegate void GetProgramInterfaceivDel(uint  program, uint /*ProgramInterface*/  programInterface, uint /*ProgramInterfacePName*/  pname, int[]  parameters); private static GetProgramInterfaceivDel GetProgramInterfaceivPtr;
        
        // glGetProgramLocalParameterIivNV
        private delegate void GetProgramLocalParameterIivNVDel(uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static GetProgramLocalParameterIivNVDel GetProgramLocalParameterIivNVPtr;
        
        // glGetProgramLocalParameterIuivNV
        private delegate void GetProgramLocalParameterIuivNVDel(uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static GetProgramLocalParameterIuivNVDel GetProgramLocalParameterIuivNVPtr;
        
        // glGetProgramLocalParameterdvARB
        private delegate void GetProgramLocalParameterdvARBDel(uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static GetProgramLocalParameterdvARBDel GetProgramLocalParameterdvARBPtr;
        
        // glGetProgramLocalParameterfvARB
        private delegate void GetProgramLocalParameterfvARBDel(uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static GetProgramLocalParameterfvARBDel GetProgramLocalParameterfvARBPtr;
        
        // glGetProgramNamedParameterdvNV
        private delegate void GetProgramNamedParameterdvNVDel(uint  id, uint  len, byte[]  name, double[]  parameters); private static GetProgramNamedParameterdvNVDel GetProgramNamedParameterdvNVPtr;
        
        // glGetProgramNamedParameterfvNV
        private delegate void GetProgramNamedParameterfvNVDel(uint  id, uint  len, byte[]  name, float[]  parameters); private static GetProgramNamedParameterfvNVDel GetProgramNamedParameterfvNVPtr;
        
        // glGetProgramParameterdvNV
        private delegate void GetProgramParameterdvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, uint /*VertexAttribEnumNV*/  pname, double[]  parameters); private static GetProgramParameterdvNVDel GetProgramParameterdvNVPtr;
        
        // glGetProgramParameterfvNV
        private delegate void GetProgramParameterfvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, uint /*VertexAttribEnumNV*/  pname, float[]  parameters); private static GetProgramParameterfvNVDel GetProgramParameterfvNVPtr;
        
        // glGetProgramPipelineInfoLog
        private delegate void GetProgramPipelineInfoLogDel(uint  pipeline, uint  bufSize, uint[]  length, string  infoLog); private static GetProgramPipelineInfoLogDel GetProgramPipelineInfoLogPtr;
        
        // glGetProgramPipelineInfoLogEXT
        private delegate void GetProgramPipelineInfoLogEXTDel(uint  pipeline, uint  bufSize, uint[]  length, string  infoLog); private static GetProgramPipelineInfoLogEXTDel GetProgramPipelineInfoLogEXTPtr;
        
        // glGetProgramPipelineiv
        private delegate void GetProgramPipelineivDel(uint  pipeline, uint /*PipelineParameterName*/  pname, int[]  parameters); private static GetProgramPipelineivDel GetProgramPipelineivPtr;
        
        // glGetProgramPipelineivEXT
        private delegate void GetProgramPipelineivEXTDel(uint  pipeline, uint /*PipelineParameterName*/  pname, int[]  parameters); private static GetProgramPipelineivEXTDel GetProgramPipelineivEXTPtr;
        
        // glGetProgramResourceIndex
        private delegate uint GetProgramResourceIndexDel(uint  program, uint /*ProgramInterface*/  programInterface, string  name); private static GetProgramResourceIndexDel GetProgramResourceIndexPtr;
        
        // glGetProgramResourceLocation
        private delegate int GetProgramResourceLocationDel(uint  program, uint /*ProgramInterface*/  programInterface, string  name); private static GetProgramResourceLocationDel GetProgramResourceLocationPtr;
        
        // glGetProgramResourceLocationIndex
        private delegate int GetProgramResourceLocationIndexDel(uint  program, uint /*ProgramInterface*/  programInterface, string  name); private static GetProgramResourceLocationIndexDel GetProgramResourceLocationIndexPtr;
        
        // glGetProgramResourceLocationIndexEXT
        private delegate int GetProgramResourceLocationIndexEXTDel(uint  program, uint /*ProgramInterface*/  programInterface, string  name); private static GetProgramResourceLocationIndexEXTDel GetProgramResourceLocationIndexEXTPtr;
        
        // glGetProgramResourceName
        private delegate void GetProgramResourceNameDel(uint  program, uint /*ProgramInterface*/  programInterface, uint  index, uint  bufSize, uint[]  length, string  name); private static GetProgramResourceNameDel GetProgramResourceNamePtr;
        
        // glGetProgramResourcefvNV
        private delegate void GetProgramResourcefvNVDel(uint  program, uint /*ProgramInterface*/  programInterface, uint  index, uint  propCount, uint[]  props, uint  count, uint[]  length, float[]  parameters); private static GetProgramResourcefvNVDel GetProgramResourcefvNVPtr;
        
        // glGetProgramResourceiv
        private delegate void GetProgramResourceivDel(uint  program, uint /*ProgramInterface*/  programInterface, uint  index, uint  propCount, uint[] /*ProgramResourceProperty*/  props, uint  count, uint[]  length, int[]  parameters); private static GetProgramResourceivDel GetProgramResourceivPtr;
        
        // glGetProgramStageiv
        private delegate void GetProgramStageivDel(uint  program, uint /*ShaderType*/  shadertype, uint /*ProgramStagePName*/  pname, int[]  values); private static GetProgramStageivDel GetProgramStageivPtr;
        
        // glGetProgramStringARB
        private delegate void GetProgramStringARBDel(uint /*ProgramTarget*/  target, uint /*ProgramStringProperty*/  pname, IntPtr  str); private static GetProgramStringARBDel GetProgramStringARBPtr;
        
        // glGetProgramStringNV
        private delegate void GetProgramStringNVDel(uint  id, uint /*VertexAttribEnumNV*/  pname, byte[] /*ProgramCharacterNV*/  program); private static GetProgramStringNVDel GetProgramStringNVPtr;
        
        // glGetProgramSubroutineParameteruivNV
        private delegate void GetProgramSubroutineParameteruivNVDel(uint  target, uint  index, uint[]  param); private static GetProgramSubroutineParameteruivNVDel GetProgramSubroutineParameteruivNVPtr;
        
        // glGetProgramiv
        private delegate void GetProgramivDel(uint  program, uint /*ProgramPropertyARB*/  pname, int[]  parameters); private static GetProgramivDel GetProgramivPtr;
        
        // glGetProgramivARB
        private delegate void GetProgramivARBDel(uint /*ProgramTarget*/  target, uint /*ProgramPropertyARB*/  pname, int[]  parameters); private static GetProgramivARBDel GetProgramivARBPtr;
        
        // glGetProgramivNV
        private delegate void GetProgramivNVDel(uint  id, uint /*VertexAttribEnumNV*/  pname, int[]  parameters); private static GetProgramivNVDel GetProgramivNVPtr;
        
        // glGetQueryBufferObjecti64v
        private delegate void GetQueryBufferObjecti64vDel(uint  id, uint  buffer, uint /*QueryObjectParameterName*/  pname, IntPtr  offset); private static GetQueryBufferObjecti64vDel GetQueryBufferObjecti64vPtr;
        
        // glGetQueryBufferObjectiv
        private delegate void GetQueryBufferObjectivDel(uint  id, uint  buffer, uint /*QueryObjectParameterName*/  pname, IntPtr  offset); private static GetQueryBufferObjectivDel GetQueryBufferObjectivPtr;
        
        // glGetQueryBufferObjectui64v
        private delegate void GetQueryBufferObjectui64vDel(uint  id, uint  buffer, uint /*QueryObjectParameterName*/  pname, IntPtr  offset); private static GetQueryBufferObjectui64vDel GetQueryBufferObjectui64vPtr;
        
        // glGetQueryBufferObjectuiv
        private delegate void GetQueryBufferObjectuivDel(uint  id, uint  buffer, uint /*QueryObjectParameterName*/  pname, IntPtr  offset); private static GetQueryBufferObjectuivDel GetQueryBufferObjectuivPtr;
        
        // glGetQueryIndexediv
        private delegate void GetQueryIndexedivDel(uint /*QueryTarget*/  target, uint  index, uint /*QueryParameterName*/  pname, int[]  parameters); private static GetQueryIndexedivDel GetQueryIndexedivPtr;
        
        // glGetQueryObjecti64v
        private delegate void GetQueryObjecti64vDel(uint  id, uint /*QueryObjectParameterName*/  pname, long[]  parameters); private static GetQueryObjecti64vDel GetQueryObjecti64vPtr;
        
        // glGetQueryObjecti64vEXT
        private delegate void GetQueryObjecti64vEXTDel(uint  id, uint /*QueryObjectParameterName*/  pname, long[]  parameters); private static GetQueryObjecti64vEXTDel GetQueryObjecti64vEXTPtr;
        
        // glGetQueryObjectiv
        private delegate void GetQueryObjectivDel(uint  id, uint /*QueryObjectParameterName*/  pname, int[]  parameters); private static GetQueryObjectivDel GetQueryObjectivPtr;
        
        // glGetQueryObjectivARB
        private delegate void GetQueryObjectivARBDel(uint  id, uint /*QueryObjectParameterName*/  pname, int[]  parameters); private static GetQueryObjectivARBDel GetQueryObjectivARBPtr;
        
        // glGetQueryObjectivEXT
        private delegate void GetQueryObjectivEXTDel(uint  id, uint /*QueryObjectParameterName*/  pname, int[]  parameters); private static GetQueryObjectivEXTDel GetQueryObjectivEXTPtr;
        
        // glGetQueryObjectui64v
        private delegate void GetQueryObjectui64vDel(uint  id, uint /*QueryObjectParameterName*/  pname, ulong[]  parameters); private static GetQueryObjectui64vDel GetQueryObjectui64vPtr;
        
        // glGetQueryObjectui64vEXT
        private delegate void GetQueryObjectui64vEXTDel(uint  id, uint /*QueryObjectParameterName*/  pname, ulong[]  parameters); private static GetQueryObjectui64vEXTDel GetQueryObjectui64vEXTPtr;
        
        // glGetQueryObjectuiv
        private delegate void GetQueryObjectuivDel(uint  id, uint /*QueryObjectParameterName*/  pname, uint[]  parameters); private static GetQueryObjectuivDel GetQueryObjectuivPtr;
        
        // glGetQueryObjectuivARB
        private delegate void GetQueryObjectuivARBDel(uint  id, uint /*QueryObjectParameterName*/  pname, uint[]  parameters); private static GetQueryObjectuivARBDel GetQueryObjectuivARBPtr;
        
        // glGetQueryObjectuivEXT
        private delegate void GetQueryObjectuivEXTDel(uint  id, uint /*QueryObjectParameterName*/  pname, uint[]  parameters); private static GetQueryObjectuivEXTDel GetQueryObjectuivEXTPtr;
        
        // glGetQueryiv
        private delegate void GetQueryivDel(uint /*QueryTarget*/  target, uint /*QueryParameterName*/  pname, int[]  parameters); private static GetQueryivDel GetQueryivPtr;
        
        // glGetQueryivARB
        private delegate void GetQueryivARBDel(uint /*QueryTarget*/  target, uint /*QueryParameterName*/  pname, int[]  parameters); private static GetQueryivARBDel GetQueryivARBPtr;
        
        // glGetQueryivEXT
        private delegate void GetQueryivEXTDel(uint /*QueryTarget*/  target, uint /*QueryParameterName*/  pname, int[]  parameters); private static GetQueryivEXTDel GetQueryivEXTPtr;
        
        // glGetRenderbufferParameteriv
        private delegate void GetRenderbufferParameterivDel(uint /*RenderbufferTarget*/  target, uint /*RenderbufferParameterName*/  pname, int[]  parameters); private static GetRenderbufferParameterivDel GetRenderbufferParameterivPtr;
        
        // glGetRenderbufferParameterivEXT
        private delegate void GetRenderbufferParameterivEXTDel(uint /*RenderbufferTarget*/  target, uint /*RenderbufferParameterName*/  pname, int[]  parameters); private static GetRenderbufferParameterivEXTDel GetRenderbufferParameterivEXTPtr;
        
        // glGetRenderbufferParameterivOES
        private delegate void GetRenderbufferParameterivOESDel(uint /*RenderbufferTarget*/  target, uint /*RenderbufferParameterName*/  pname, int[]  parameters); private static GetRenderbufferParameterivOESDel GetRenderbufferParameterivOESPtr;
        
        // glGetSamplerParameterIiv
        private delegate void GetSamplerParameterIivDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  parameters); private static GetSamplerParameterIivDel GetSamplerParameterIivPtr;
        
        // glGetSamplerParameterIivEXT
        private delegate void GetSamplerParameterIivEXTDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  parameters); private static GetSamplerParameterIivEXTDel GetSamplerParameterIivEXTPtr;
        
        // glGetSamplerParameterIivOES
        private delegate void GetSamplerParameterIivOESDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  parameters); private static GetSamplerParameterIivOESDel GetSamplerParameterIivOESPtr;
        
        // glGetSamplerParameterIuiv
        private delegate void GetSamplerParameterIuivDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  parameters); private static GetSamplerParameterIuivDel GetSamplerParameterIuivPtr;
        
        // glGetSamplerParameterIuivEXT
        private delegate void GetSamplerParameterIuivEXTDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  parameters); private static GetSamplerParameterIuivEXTDel GetSamplerParameterIuivEXTPtr;
        
        // glGetSamplerParameterIuivOES
        private delegate void GetSamplerParameterIuivOESDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  parameters); private static GetSamplerParameterIuivOESDel GetSamplerParameterIuivOESPtr;
        
        // glGetSamplerParameterfv
        private delegate void GetSamplerParameterfvDel(uint  sampler, uint /*SamplerParameterF*/  pname, float[]  parameters); private static GetSamplerParameterfvDel GetSamplerParameterfvPtr;
        
        // glGetSamplerParameteriv
        private delegate void GetSamplerParameterivDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  parameters); private static GetSamplerParameterivDel GetSamplerParameterivPtr;
        
        // glGetSemaphoreParameterui64vEXT
        private delegate void GetSemaphoreParameterui64vEXTDel(uint  semaphore, uint /*SemaphoreParameterName*/  pname, ulong[]  parameters); private static GetSemaphoreParameterui64vEXTDel GetSemaphoreParameterui64vEXTPtr;
        
        // glGetSeparableFilter
        private delegate void GetSeparableFilterDel(uint /*SeparableTargetEXT*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  row, IntPtr  column, IntPtr  span); private static GetSeparableFilterDel GetSeparableFilterPtr;
        
        // glGetSeparableFilterEXT
        private delegate void GetSeparableFilterEXTDel(uint /*SeparableTargetEXT*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  row, IntPtr  column, IntPtr  span); private static GetSeparableFilterEXTDel GetSeparableFilterEXTPtr;
        
        // glGetShaderInfoLog
        private delegate void GetShaderInfoLogDel(uint  shader, uint  bufSize, uint[]  length, string  infoLog); private static GetShaderInfoLogDel GetShaderInfoLogPtr;
        
        // glGetShaderPrecisionFormat
        private delegate void GetShaderPrecisionFormatDel(uint /*ShaderType*/  shadertype, uint /*PrecisionType*/  precisiontype, int[]  range, int[]  precision); private static GetShaderPrecisionFormatDel GetShaderPrecisionFormatPtr;
        
        // glGetShaderSource
        private delegate void GetShaderSourceDel(uint  shader, uint  bufSize, uint[]  length, string  source); private static GetShaderSourceDel GetShaderSourcePtr;
        
        // glGetShaderSourceARB
        private delegate void GetShaderSourceARBDel(IntPtr /*handleARB*/  obj, uint  maxLength, uint[]  length, string  source); private static GetShaderSourceARBDel GetShaderSourceARBPtr;
        
        // glGetShaderiv
        private delegate void GetShaderivDel(uint  shader, uint /*ShaderParameterName*/  pname, int[]  parameters); private static GetShaderivDel GetShaderivPtr;
        
        // glGetShadingRateImagePaletteNV
        private delegate void GetShadingRateImagePaletteNVDel(uint  viewport, uint  entry, uint[]  rate); private static GetShadingRateImagePaletteNVDel GetShadingRateImagePaletteNVPtr;
        
        // glGetShadingRateSampleLocationivNV
        private delegate void GetShadingRateSampleLocationivNVDel(uint  rate, uint  samples, uint  index, int[]  location); private static GetShadingRateSampleLocationivNVDel GetShadingRateSampleLocationivNVPtr;
        
        // glGetSharpenTexFuncSGIS
        private delegate void GetSharpenTexFuncSGISDel(uint /*TextureTarget*/  target, float[]  points); private static GetSharpenTexFuncSGISDel GetSharpenTexFuncSGISPtr;
        
        // glGetStageIndexNV
        private delegate ushort GetStageIndexNVDel(uint /*ShaderType*/  shadertype); private static GetStageIndexNVDel GetStageIndexNVPtr;
        
        // glGetString
        private delegate byte /*String*/ GetStringDel(uint /*StringName*/  name); private static GetStringDel GetStringPtr;
        
        // glGetStringi
        private delegate byte /*String*/ GetStringiDel(uint /*StringName*/  name, uint  index); private static GetStringiDel GetStringiPtr;
        
        // glGetSubroutineIndex
        private delegate uint GetSubroutineIndexDel(uint  program, uint /*ShaderType*/  shadertype, string  name); private static GetSubroutineIndexDel GetSubroutineIndexPtr;
        
        // glGetSubroutineUniformLocation
        private delegate int GetSubroutineUniformLocationDel(uint  program, uint /*ShaderType*/  shadertype, string  name); private static GetSubroutineUniformLocationDel GetSubroutineUniformLocationPtr;
        
        // glGetSynciv
        private delegate void GetSyncivDel(IntPtr /*sync*/  sync, uint /*SyncParameterName*/  pname, uint  count, uint[]  length, int[]  values); private static GetSyncivDel GetSyncivPtr;
        
        // glGetSyncivAPPLE
        private delegate void GetSyncivAPPLEDel(IntPtr  sync, uint /*SyncParameterName*/  pname, uint  count, uint[]  length, int[]  values); private static GetSyncivAPPLEDel GetSyncivAPPLEPtr;
        
        // glGetTexBumpParameterfvATI
        private delegate void GetTexBumpParameterfvATIDel(uint /*GetTexBumpParameterATI*/  pname, float[]  param); private static GetTexBumpParameterfvATIDel GetTexBumpParameterfvATIPtr;
        
        // glGetTexBumpParameterivATI
        private delegate void GetTexBumpParameterivATIDel(uint /*GetTexBumpParameterATI*/  pname, int[]  param); private static GetTexBumpParameterivATIDel GetTexBumpParameterivATIPtr;
        
        // glGetTexEnvfv
        private delegate void GetTexEnvfvDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float[]  parameters); private static GetTexEnvfvDel GetTexEnvfvPtr;
        
        // glGetTexEnviv
        private delegate void GetTexEnvivDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static GetTexEnvivDel GetTexEnvivPtr;
        
        // glGetTexEnvxv
        private delegate void GetTexEnvxvDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static GetTexEnvxvDel GetTexEnvxvPtr;
        
        // glGetTexEnvxvOES
        private delegate void GetTexEnvxvOESDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static GetTexEnvxvOESDel GetTexEnvxvOESPtr;
        
        // glGetTexFilterFuncSGIS
        private delegate void GetTexFilterFuncSGISDel(uint /*TextureTarget*/  target, uint /*TextureFilterSGIS*/  filter, float[]  weights); private static GetTexFilterFuncSGISDel GetTexFilterFuncSGISPtr;
        
        // glGetTexGendv
        private delegate void GetTexGendvDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double[]  parameters); private static GetTexGendvDel GetTexGendvPtr;
        
        // glGetTexGenfv
        private delegate void GetTexGenfvDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[]  parameters); private static GetTexGenfvDel GetTexGenfvPtr;
        
        // glGetTexGenfvOES
        private delegate void GetTexGenfvOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[]  parameters); private static GetTexGenfvOESDel GetTexGenfvOESPtr;
        
        // glGetTexGeniv
        private delegate void GetTexGenivDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static GetTexGenivDel GetTexGenivPtr;
        
        // glGetTexGenivOES
        private delegate void GetTexGenivOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static GetTexGenivOESDel GetTexGenivOESPtr;
        
        // glGetTexGenxvOES
        private delegate void GetTexGenxvOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static GetTexGenxvOESDel GetTexGenxvOESPtr;
        
        // glGetTexImage
        private delegate void GetTexImageDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static GetTexImageDel GetTexImagePtr;
        
        // glGetTexLevelParameterfv
        private delegate void GetTexLevelParameterfvDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTexLevelParameterfvDel GetTexLevelParameterfvPtr;
        
        // glGetTexLevelParameteriv
        private delegate void GetTexLevelParameterivDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexLevelParameterivDel GetTexLevelParameterivPtr;
        
        // glGetTexLevelParameterxvOES
        private delegate void GetTexLevelParameterxvOESDel(uint /*TextureTarget*/  target, int  level, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexLevelParameterxvOESDel GetTexLevelParameterxvOESPtr;
        
        // glGetTexParameterIiv
        private delegate void GetTexParameterIivDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterIivDel GetTexParameterIivPtr;
        
        // glGetTexParameterIivEXT
        private delegate void GetTexParameterIivEXTDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterIivEXTDel GetTexParameterIivEXTPtr;
        
        // glGetTexParameterIivOES
        private delegate void GetTexParameterIivOESDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterIivOESDel GetTexParameterIivOESPtr;
        
        // glGetTexParameterIuiv
        private delegate void GetTexParameterIuivDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetTexParameterIuivDel GetTexParameterIuivPtr;
        
        // glGetTexParameterIuivEXT
        private delegate void GetTexParameterIuivEXTDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetTexParameterIuivEXTDel GetTexParameterIuivEXTPtr;
        
        // glGetTexParameterIuivOES
        private delegate void GetTexParameterIuivOESDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetTexParameterIuivOESDel GetTexParameterIuivOESPtr;
        
        // glGetTexParameterPointervAPPLE
        private delegate void GetTexParameterPointervAPPLEDel(uint  target, uint  pname, IntPtr  parameters); private static GetTexParameterPointervAPPLEDel GetTexParameterPointervAPPLEPtr;
        
        // glGetTexParameterfv
        private delegate void GetTexParameterfvDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTexParameterfvDel GetTexParameterfvPtr;
        
        // glGetTexParameteriv
        private delegate void GetTexParameterivDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterivDel GetTexParameterivPtr;
        
        // glGetTexParameterxv
        private delegate void GetTexParameterxvDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterxvDel GetTexParameterxvPtr;
        
        // glGetTexParameterxvOES
        private delegate void GetTexParameterxvOESDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTexParameterxvOESDel GetTexParameterxvOESPtr;
        
        // glGetTextureHandleARB
        private delegate ulong GetTextureHandleARBDel(uint  texture); private static GetTextureHandleARBDel GetTextureHandleARBPtr;
        
        // glGetTextureHandleIMG
        private delegate ulong GetTextureHandleIMGDel(uint  texture); private static GetTextureHandleIMGDel GetTextureHandleIMGPtr;
        
        // glGetTextureHandleNV
        private delegate ulong GetTextureHandleNVDel(uint  texture); private static GetTextureHandleNVDel GetTextureHandleNVPtr;
        
        // glGetTextureImage
        private delegate void GetTextureImageDel(uint  texture, int  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  pixels); private static GetTextureImageDel GetTextureImagePtr;
        
        // glGetTextureImageEXT
        private delegate void GetTextureImageEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static GetTextureImageEXTDel GetTextureImageEXTPtr;
        
        // glGetTextureLevelParameterfv
        private delegate void GetTextureLevelParameterfvDel(uint  texture, int  level, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTextureLevelParameterfvDel GetTextureLevelParameterfvPtr;
        
        // glGetTextureLevelParameterfvEXT
        private delegate void GetTextureLevelParameterfvEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTextureLevelParameterfvEXTDel GetTextureLevelParameterfvEXTPtr;
        
        // glGetTextureLevelParameteriv
        private delegate void GetTextureLevelParameterivDel(uint  texture, int  level, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureLevelParameterivDel GetTextureLevelParameterivPtr;
        
        // glGetTextureLevelParameterivEXT
        private delegate void GetTextureLevelParameterivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureLevelParameterivEXTDel GetTextureLevelParameterivEXTPtr;
        
        // glGetTextureParameterIiv
        private delegate void GetTextureParameterIivDel(uint  texture, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureParameterIivDel GetTextureParameterIivPtr;
        
        // glGetTextureParameterIivEXT
        private delegate void GetTextureParameterIivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureParameterIivEXTDel GetTextureParameterIivEXTPtr;
        
        // glGetTextureParameterIuiv
        private delegate void GetTextureParameterIuivDel(uint  texture, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetTextureParameterIuivDel GetTextureParameterIuivPtr;
        
        // glGetTextureParameterIuivEXT
        private delegate void GetTextureParameterIuivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, uint[]  parameters); private static GetTextureParameterIuivEXTDel GetTextureParameterIuivEXTPtr;
        
        // glGetTextureParameterfv
        private delegate void GetTextureParameterfvDel(uint  texture, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTextureParameterfvDel GetTextureParameterfvPtr;
        
        // glGetTextureParameterfvEXT
        private delegate void GetTextureParameterfvEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, float[]  parameters); private static GetTextureParameterfvEXTDel GetTextureParameterfvEXTPtr;
        
        // glGetTextureParameteriv
        private delegate void GetTextureParameterivDel(uint  texture, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureParameterivDel GetTextureParameterivPtr;
        
        // glGetTextureParameterivEXT
        private delegate void GetTextureParameterivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static GetTextureParameterivEXTDel GetTextureParameterivEXTPtr;
        
        // glGetTextureSamplerHandleARB
        private delegate ulong GetTextureSamplerHandleARBDel(uint  texture, uint  sampler); private static GetTextureSamplerHandleARBDel GetTextureSamplerHandleARBPtr;
        
        // glGetTextureSamplerHandleIMG
        private delegate ulong GetTextureSamplerHandleIMGDel(uint  texture, uint  sampler); private static GetTextureSamplerHandleIMGDel GetTextureSamplerHandleIMGPtr;
        
        // glGetTextureSamplerHandleNV
        private delegate ulong GetTextureSamplerHandleNVDel(uint  texture, uint  sampler); private static GetTextureSamplerHandleNVDel GetTextureSamplerHandleNVPtr;
        
        // glGetTextureSubImage
        private delegate void GetTextureSubImageDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  pixels); private static GetTextureSubImageDel GetTextureSubImagePtr;
        
        // glGetTrackMatrixivNV
        private delegate void GetTrackMatrixivNVDel(uint /*VertexAttribEnumNV*/  target, uint  address, uint /*VertexAttribEnumNV*/  pname, int[]  parameters); private static GetTrackMatrixivNVDel GetTrackMatrixivNVPtr;
        
        // glGetTransformFeedbackVarying
        private delegate void GetTransformFeedbackVaryingDel(uint  program, uint  index, uint  bufSize, uint[]  length, uint[]  size, uint[] /*AttributeType*/  type, string  name); private static GetTransformFeedbackVaryingDel GetTransformFeedbackVaryingPtr;
        
        // glGetTransformFeedbackVaryingEXT
        private delegate void GetTransformFeedbackVaryingEXTDel(uint  program, uint  index, uint  bufSize, uint[]  length, uint[]  size, uint[] /*AttributeType*/  type, string  name); private static GetTransformFeedbackVaryingEXTDel GetTransformFeedbackVaryingEXTPtr;
        
        // glGetTransformFeedbackVaryingNV
        private delegate void GetTransformFeedbackVaryingNVDel(uint  program, uint  index, int[]  location); private static GetTransformFeedbackVaryingNVDel GetTransformFeedbackVaryingNVPtr;
        
        // glGetTransformFeedbacki64_v
        private delegate void GetTransformFeedbacki64_vDel(uint  xfb, uint /*TransformFeedbackPName*/  pname, uint  index, long[]  param); private static GetTransformFeedbacki64_vDel GetTransformFeedbacki64_vPtr;
        
        // glGetTransformFeedbacki_v
        private delegate void GetTransformFeedbacki_vDel(uint  xfb, uint /*TransformFeedbackPName*/  pname, uint  index, int[]  param); private static GetTransformFeedbacki_vDel GetTransformFeedbacki_vPtr;
        
        // glGetTransformFeedbackiv
        private delegate void GetTransformFeedbackivDel(uint  xfb, uint /*TransformFeedbackPName*/  pname, int[]  param); private static GetTransformFeedbackivDel GetTransformFeedbackivPtr;
        
        // glGetTranslatedShaderSourceANGLE
        private delegate void GetTranslatedShaderSourceANGLEDel(uint  shader, uint  bufSize, uint[]  length, string  source); private static GetTranslatedShaderSourceANGLEDel GetTranslatedShaderSourceANGLEPtr;
        
        // glGetUniformBlockIndex
        private delegate uint GetUniformBlockIndexDel(uint  program, string  uniformBlockName); private static GetUniformBlockIndexDel GetUniformBlockIndexPtr;
        
        // glGetUniformBufferSizeEXT
        private delegate int GetUniformBufferSizeEXTDel(uint  program, int  location); private static GetUniformBufferSizeEXTDel GetUniformBufferSizeEXTPtr;
        
        // glGetUniformIndices
        private delegate void GetUniformIndicesDel(uint  program, uint  uniformCount, string  uniformNames, uint[]  uniformIndices); private static GetUniformIndicesDel GetUniformIndicesPtr;
        
        // glGetUniformLocation
        private delegate int GetUniformLocationDel(uint  program, string  name); private static GetUniformLocationDel GetUniformLocationPtr;
        
        // glGetUniformLocationARB
        private delegate int GetUniformLocationARBDel(IntPtr /*handleARB*/  programObj, string  name); private static GetUniformLocationARBDel GetUniformLocationARBPtr;
        
        // glGetUniformOffsetEXT
        private delegate IntPtr /*BufferOffset*/ GetUniformOffsetEXTDel(uint  program, int  location); private static GetUniformOffsetEXTDel GetUniformOffsetEXTPtr;
        
        // glGetUniformSubroutineuiv
        private delegate void GetUniformSubroutineuivDel(uint /*ShaderType*/  shadertype, int  location, uint[]  parameters); private static GetUniformSubroutineuivDel GetUniformSubroutineuivPtr;
        
        // glGetUniformdv
        private delegate void GetUniformdvDel(uint  program, int  location, double[]  parameters); private static GetUniformdvDel GetUniformdvPtr;
        
        // glGetUniformfv
        private delegate void GetUniformfvDel(uint  program, int  location, float[]  parameters); private static GetUniformfvDel GetUniformfvPtr;
        
        // glGetUniformfvARB
        private delegate void GetUniformfvARBDel(IntPtr /*handleARB*/  programObj, int  location, float[]  parameters); private static GetUniformfvARBDel GetUniformfvARBPtr;
        
        // glGetUniformi64vARB
        private delegate void GetUniformi64vARBDel(uint  program, int  location, long[]  parameters); private static GetUniformi64vARBDel GetUniformi64vARBPtr;
        
        // glGetUniformi64vNV
        private delegate void GetUniformi64vNVDel(uint  program, int  location, long[]  parameters); private static GetUniformi64vNVDel GetUniformi64vNVPtr;
        
        // glGetUniformiv
        private delegate void GetUniformivDel(uint  program, int  location, int[]  parameters); private static GetUniformivDel GetUniformivPtr;
        
        // glGetUniformivARB
        private delegate void GetUniformivARBDel(IntPtr /*handleARB*/  programObj, int  location, int[]  parameters); private static GetUniformivARBDel GetUniformivARBPtr;
        
        // glGetUniformui64vARB
        private delegate void GetUniformui64vARBDel(uint  program, int  location, ulong[]  parameters); private static GetUniformui64vARBDel GetUniformui64vARBPtr;
        
        // glGetUniformui64vNV
        private delegate void GetUniformui64vNVDel(uint  program, int  location, ulong[]  parameters); private static GetUniformui64vNVDel GetUniformui64vNVPtr;
        
        // glGetUniformuiv
        private delegate void GetUniformuivDel(uint  program, int  location, uint[]  parameters); private static GetUniformuivDel GetUniformuivPtr;
        
        // glGetUniformuivEXT
        private delegate void GetUniformuivEXTDel(uint  program, int  location, uint[]  parameters); private static GetUniformuivEXTDel GetUniformuivEXTPtr;
        
        // glGetUnsignedBytevEXT
        private delegate void GetUnsignedBytevEXTDel(uint /*GetPName*/  pname, byte[]  data); private static GetUnsignedBytevEXTDel GetUnsignedBytevEXTPtr;
        
        // glGetUnsignedBytei_vEXT
        private delegate void GetUnsignedBytei_vEXTDel(uint  target, uint  index, byte[]  data); private static GetUnsignedBytei_vEXTDel GetUnsignedBytei_vEXTPtr;
        
        // glGetVariantArrayObjectfvATI
        private delegate void GetVariantArrayObjectfvATIDel(uint  id, uint /*ArrayObjectPNameATI*/  pname, float[]  parameters); private static GetVariantArrayObjectfvATIDel GetVariantArrayObjectfvATIPtr;
        
        // glGetVariantArrayObjectivATI
        private delegate void GetVariantArrayObjectivATIDel(uint  id, uint /*ArrayObjectPNameATI*/  pname, int[]  parameters); private static GetVariantArrayObjectivATIDel GetVariantArrayObjectivATIPtr;
        
        // glGetVariantBooleanvEXT
        private delegate void GetVariantBooleanvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, bool[] /*Boolean*/  data); private static GetVariantBooleanvEXTDel GetVariantBooleanvEXTPtr;
        
        // glGetVariantFloatvEXT
        private delegate void GetVariantFloatvEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, float[]  data); private static GetVariantFloatvEXTDel GetVariantFloatvEXTPtr;
        
        // glGetVariantIntegervEXT
        private delegate void GetVariantIntegervEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, int[]  data); private static GetVariantIntegervEXTDel GetVariantIntegervEXTPtr;
        
        // glGetVariantPointervEXT
        private delegate void GetVariantPointervEXTDel(uint  id, uint /*GetVariantValueEXT*/  value, IntPtr  data); private static GetVariantPointervEXTDel GetVariantPointervEXTPtr;
        
        // glGetVaryingLocationNV
        private delegate int GetVaryingLocationNVDel(uint  program, string  name); private static GetVaryingLocationNVDel GetVaryingLocationNVPtr;
        
        // glGetVertexArrayIndexed64iv
        private delegate void GetVertexArrayIndexed64ivDel(uint  vaobj, uint  index, uint /*VertexArrayPName*/  pname, long[]  param); private static GetVertexArrayIndexed64ivDel GetVertexArrayIndexed64ivPtr;
        
        // glGetVertexArrayIndexediv
        private delegate void GetVertexArrayIndexedivDel(uint  vaobj, uint  index, uint /*VertexArrayPName*/  pname, int[]  param); private static GetVertexArrayIndexedivDel GetVertexArrayIndexedivPtr;
        
        // glGetVertexArrayIntegeri_vEXT
        private delegate void GetVertexArrayIntegeri_vEXTDel(uint  vaobj, uint  index, uint /*VertexArrayPName*/  pname, int[]  param); private static GetVertexArrayIntegeri_vEXTDel GetVertexArrayIntegeri_vEXTPtr;
        
        // glGetVertexArrayIntegervEXT
        private delegate void GetVertexArrayIntegervEXTDel(uint  vaobj, uint /*VertexArrayPName*/  pname, int[]  param); private static GetVertexArrayIntegervEXTDel GetVertexArrayIntegervEXTPtr;
        
        // glGetVertexArrayPointeri_vEXT
        private delegate void GetVertexArrayPointeri_vEXTDel(uint  vaobj, uint  index, uint /*VertexArrayPName*/  pname, IntPtr  param); private static GetVertexArrayPointeri_vEXTDel GetVertexArrayPointeri_vEXTPtr;
        
        // glGetVertexArrayPointervEXT
        private delegate void GetVertexArrayPointervEXTDel(uint  vaobj, uint /*VertexArrayPName*/  pname, IntPtr  param); private static GetVertexArrayPointervEXTDel GetVertexArrayPointervEXTPtr;
        
        // glGetVertexArrayiv
        private delegate void GetVertexArrayivDel(uint  vaobj, uint /*VertexArrayPName*/  pname, int[]  param); private static GetVertexArrayivDel GetVertexArrayivPtr;
        
        // glGetVertexAttribArrayObjectfvATI
        private delegate void GetVertexAttribArrayObjectfvATIDel(uint  index, uint /*ArrayObjectPNameATI*/  pname, float[]  parameters); private static GetVertexAttribArrayObjectfvATIDel GetVertexAttribArrayObjectfvATIPtr;
        
        // glGetVertexAttribArrayObjectivATI
        private delegate void GetVertexAttribArrayObjectivATIDel(uint  index, uint /*ArrayObjectPNameATI*/  pname, int[]  parameters); private static GetVertexAttribArrayObjectivATIDel GetVertexAttribArrayObjectivATIPtr;
        
        // glGetVertexAttribIiv
        private delegate void GetVertexAttribIivDel(uint  index, uint /*VertexAttribEnum*/  pname, int[]  parameters); private static GetVertexAttribIivDel GetVertexAttribIivPtr;
        
        // glGetVertexAttribIivEXT
        private delegate void GetVertexAttribIivEXTDel(uint  index, uint /*VertexAttribEnum*/  pname, int[]  parameters); private static GetVertexAttribIivEXTDel GetVertexAttribIivEXTPtr;
        
        // glGetVertexAttribIuiv
        private delegate void GetVertexAttribIuivDel(uint  index, uint /*VertexAttribEnum*/  pname, uint[]  parameters); private static GetVertexAttribIuivDel GetVertexAttribIuivPtr;
        
        // glGetVertexAttribIuivEXT
        private delegate void GetVertexAttribIuivEXTDel(uint  index, uint /*VertexAttribEnum*/  pname, uint[]  parameters); private static GetVertexAttribIuivEXTDel GetVertexAttribIuivEXTPtr;
        
        // glGetVertexAttribLdv
        private delegate void GetVertexAttribLdvDel(uint  index, uint /*VertexAttribEnum*/  pname, double[]  parameters); private static GetVertexAttribLdvDel GetVertexAttribLdvPtr;
        
        // glGetVertexAttribLdvEXT
        private delegate void GetVertexAttribLdvEXTDel(uint  index, uint /*VertexAttribEnum*/  pname, double[]  parameters); private static GetVertexAttribLdvEXTDel GetVertexAttribLdvEXTPtr;
        
        // glGetVertexAttribLi64vNV
        private delegate void GetVertexAttribLi64vNVDel(uint  index, uint /*VertexAttribEnum*/  pname, long[]  parameters); private static GetVertexAttribLi64vNVDel GetVertexAttribLi64vNVPtr;
        
        // glGetVertexAttribLui64vARB
        private delegate void GetVertexAttribLui64vARBDel(uint  index, uint /*VertexAttribEnum*/  pname, ulong[]  parameters); private static GetVertexAttribLui64vARBDel GetVertexAttribLui64vARBPtr;
        
        // glGetVertexAttribLui64vNV
        private delegate void GetVertexAttribLui64vNVDel(uint  index, uint /*VertexAttribEnum*/  pname, ulong[]  parameters); private static GetVertexAttribLui64vNVDel GetVertexAttribLui64vNVPtr;
        
        // glGetVertexAttribPointerv
        private delegate void GetVertexAttribPointervDel(uint  index, uint /*VertexAttribPointerPropertyARB*/  pname, IntPtr  pointer); private static GetVertexAttribPointervDel GetVertexAttribPointervPtr;
        
        // glGetVertexAttribPointervARB
        private delegate void GetVertexAttribPointervARBDel(uint  index, uint /*VertexAttribPointerPropertyARB*/  pname, IntPtr  pointer); private static GetVertexAttribPointervARBDel GetVertexAttribPointervARBPtr;
        
        // glGetVertexAttribPointervNV
        private delegate void GetVertexAttribPointervNVDel(uint  index, uint /*VertexAttribEnumNV*/  pname, IntPtr  pointer); private static GetVertexAttribPointervNVDel GetVertexAttribPointervNVPtr;
        
        // glGetVertexAttribdv
        private delegate void GetVertexAttribdvDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, double[]  parameters); private static GetVertexAttribdvDel GetVertexAttribdvPtr;
        
        // glGetVertexAttribdvARB
        private delegate void GetVertexAttribdvARBDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, double[]  parameters); private static GetVertexAttribdvARBDel GetVertexAttribdvARBPtr;
        
        // glGetVertexAttribdvNV
        private delegate void GetVertexAttribdvNVDel(uint  index, uint /*VertexAttribEnumNV*/  pname, double[]  parameters); private static GetVertexAttribdvNVDel GetVertexAttribdvNVPtr;
        
        // glGetVertexAttribfv
        private delegate void GetVertexAttribfvDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, float[]  parameters); private static GetVertexAttribfvDel GetVertexAttribfvPtr;
        
        // glGetVertexAttribfvARB
        private delegate void GetVertexAttribfvARBDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, float[]  parameters); private static GetVertexAttribfvARBDel GetVertexAttribfvARBPtr;
        
        // glGetVertexAttribfvNV
        private delegate void GetVertexAttribfvNVDel(uint  index, uint /*VertexAttribEnumNV*/  pname, float[]  parameters); private static GetVertexAttribfvNVDel GetVertexAttribfvNVPtr;
        
        // glGetVertexAttribiv
        private delegate void GetVertexAttribivDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, int[]  parameters); private static GetVertexAttribivDel GetVertexAttribivPtr;
        
        // glGetVertexAttribivARB
        private delegate void GetVertexAttribivARBDel(uint  index, uint /*VertexAttribPropertyARB*/  pname, int[]  parameters); private static GetVertexAttribivARBDel GetVertexAttribivARBPtr;
        
        // glGetVertexAttribivNV
        private delegate void GetVertexAttribivNVDel(uint  index, uint /*VertexAttribEnumNV*/  pname, int[]  parameters); private static GetVertexAttribivNVDel GetVertexAttribivNVPtr;
        
        // glGetVideoCaptureStreamdvNV
        private delegate void GetVideoCaptureStreamdvNVDel(uint  video_capture_slot, uint  stream, uint  pname, double[]  parameters); private static GetVideoCaptureStreamdvNVDel GetVideoCaptureStreamdvNVPtr;
        
        // glGetVideoCaptureStreamfvNV
        private delegate void GetVideoCaptureStreamfvNVDel(uint  video_capture_slot, uint  stream, uint  pname, float[]  parameters); private static GetVideoCaptureStreamfvNVDel GetVideoCaptureStreamfvNVPtr;
        
        // glGetVideoCaptureStreamivNV
        private delegate void GetVideoCaptureStreamivNVDel(uint  video_capture_slot, uint  stream, uint  pname, int[]  parameters); private static GetVideoCaptureStreamivNVDel GetVideoCaptureStreamivNVPtr;
        
        // glGetVideoCaptureivNV
        private delegate void GetVideoCaptureivNVDel(uint  video_capture_slot, uint  pname, int[]  parameters); private static GetVideoCaptureivNVDel GetVideoCaptureivNVPtr;
        
        // glGetVideoi64vNV
        private delegate void GetVideoi64vNVDel(uint  video_slot, uint  pname, long[]  parameters); private static GetVideoi64vNVDel GetVideoi64vNVPtr;
        
        // glGetVideoivNV
        private delegate void GetVideoivNVDel(uint  video_slot, uint  pname, int[]  parameters); private static GetVideoivNVDel GetVideoivNVPtr;
        
        // glGetVideoui64vNV
        private delegate void GetVideoui64vNVDel(uint  video_slot, uint  pname, ulong[]  parameters); private static GetVideoui64vNVDel GetVideoui64vNVPtr;
        
        // glGetVideouivNV
        private delegate void GetVideouivNVDel(uint  video_slot, uint  pname, uint[]  parameters); private static GetVideouivNVDel GetVideouivNVPtr;
        
        // glGetnColorTable
        private delegate void GetnColorTableDel(uint /*ColorTableTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  table); private static GetnColorTableDel GetnColorTablePtr;
        
        // glGetnColorTableARB
        private delegate void GetnColorTableARBDel(uint /*ColorTableTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  table); private static GetnColorTableARBDel GetnColorTableARBPtr;
        
        // glGetnCompressedTexImage
        private delegate void GetnCompressedTexImageDel(uint /*TextureTarget*/  target, int  lod, uint  bufSize, IntPtr  pixels); private static GetnCompressedTexImageDel GetnCompressedTexImagePtr;
        
        // glGetnCompressedTexImageARB
        private delegate void GetnCompressedTexImageARBDel(uint /*TextureTarget*/  target, int  lod, uint  bufSize, IntPtr  img); private static GetnCompressedTexImageARBDel GetnCompressedTexImageARBPtr;
        
        // glGetnConvolutionFilter
        private delegate void GetnConvolutionFilterDel(uint /*ConvolutionTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  image); private static GetnConvolutionFilterDel GetnConvolutionFilterPtr;
        
        // glGetnConvolutionFilterARB
        private delegate void GetnConvolutionFilterARBDel(uint /*ConvolutionTarget*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  image); private static GetnConvolutionFilterARBDel GetnConvolutionFilterARBPtr;
        
        // glGetnHistogram
        private delegate void GetnHistogramDel(uint /*HistogramTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  values); private static GetnHistogramDel GetnHistogramPtr;
        
        // glGetnHistogramARB
        private delegate void GetnHistogramARBDel(uint /*HistogramTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  values); private static GetnHistogramARBDel GetnHistogramARBPtr;
        
        // glGetnMapdv
        private delegate void GetnMapdvDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, double[]  v); private static GetnMapdvDel GetnMapdvPtr;
        
        // glGetnMapdvARB
        private delegate void GetnMapdvARBDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, double[]  v); private static GetnMapdvARBDel GetnMapdvARBPtr;
        
        // glGetnMapfv
        private delegate void GetnMapfvDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, float[]  v); private static GetnMapfvDel GetnMapfvPtr;
        
        // glGetnMapfvARB
        private delegate void GetnMapfvARBDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, float[]  v); private static GetnMapfvARBDel GetnMapfvARBPtr;
        
        // glGetnMapiv
        private delegate void GetnMapivDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, int[]  v); private static GetnMapivDel GetnMapivPtr;
        
        // glGetnMapivARB
        private delegate void GetnMapivARBDel(uint /*MapTarget*/  target, uint /*MapQuery*/  query, uint  bufSize, int[]  v); private static GetnMapivARBDel GetnMapivARBPtr;
        
        // glGetnMinmax
        private delegate void GetnMinmaxDel(uint /*MinmaxTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  values); private static GetnMinmaxDel GetnMinmaxPtr;
        
        // glGetnMinmaxARB
        private delegate void GetnMinmaxARBDel(uint /*MinmaxTargetEXT*/  target, bool /*Boolean*/  reset, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  values); private static GetnMinmaxARBDel GetnMinmaxARBPtr;
        
        // glGetnPixelMapfv
        private delegate void GetnPixelMapfvDel(uint /*PixelMap*/  map, uint  bufSize, float[]  values); private static GetnPixelMapfvDel GetnPixelMapfvPtr;
        
        // glGetnPixelMapfvARB
        private delegate void GetnPixelMapfvARBDel(uint /*PixelMap*/  map, uint  bufSize, float[]  values); private static GetnPixelMapfvARBDel GetnPixelMapfvARBPtr;
        
        // glGetnPixelMapuiv
        private delegate void GetnPixelMapuivDel(uint /*PixelMap*/  map, uint  bufSize, uint[]  values); private static GetnPixelMapuivDel GetnPixelMapuivPtr;
        
        // glGetnPixelMapuivARB
        private delegate void GetnPixelMapuivARBDel(uint /*PixelMap*/  map, uint  bufSize, uint[]  values); private static GetnPixelMapuivARBDel GetnPixelMapuivARBPtr;
        
        // glGetnPixelMapusv
        private delegate void GetnPixelMapusvDel(uint /*PixelMap*/  map, uint  bufSize, ushort[]  values); private static GetnPixelMapusvDel GetnPixelMapusvPtr;
        
        // glGetnPixelMapusvARB
        private delegate void GetnPixelMapusvARBDel(uint /*PixelMap*/  map, uint  bufSize, ushort[]  values); private static GetnPixelMapusvARBDel GetnPixelMapusvARBPtr;
        
        // glGetnPolygonStipple
        private delegate void GetnPolygonStippleDel(uint  bufSize, byte[]  pattern); private static GetnPolygonStippleDel GetnPolygonStipplePtr;
        
        // glGetnPolygonStippleARB
        private delegate void GetnPolygonStippleARBDel(uint  bufSize, byte[]  pattern); private static GetnPolygonStippleARBDel GetnPolygonStippleARBPtr;
        
        // glGetnSeparableFilter
        private delegate void GetnSeparableFilterDel(uint /*SeparableTargetEXT*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  rowBufSize, IntPtr  row, uint  columnBufSize, IntPtr  column, IntPtr  span); private static GetnSeparableFilterDel GetnSeparableFilterPtr;
        
        // glGetnSeparableFilterARB
        private delegate void GetnSeparableFilterARBDel(uint /*SeparableTargetEXT*/  target, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  rowBufSize, IntPtr  row, uint  columnBufSize, IntPtr  column, IntPtr  span); private static GetnSeparableFilterARBDel GetnSeparableFilterARBPtr;
        
        // glGetnTexImage
        private delegate void GetnTexImageDel(uint /*TextureTarget*/  target, int  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  pixels); private static GetnTexImageDel GetnTexImagePtr;
        
        // glGetnTexImageARB
        private delegate void GetnTexImageARBDel(uint /*TextureTarget*/  target, int  level, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  img); private static GetnTexImageARBDel GetnTexImageARBPtr;
        
        // glGetnUniformdv
        private delegate void GetnUniformdvDel(uint  program, int  location, uint  bufSize, double[]  parameters); private static GetnUniformdvDel GetnUniformdvPtr;
        
        // glGetnUniformdvARB
        private delegate void GetnUniformdvARBDel(uint  program, int  location, uint  bufSize, double[]  parameters); private static GetnUniformdvARBDel GetnUniformdvARBPtr;
        
        // glGetnUniformfv
        private delegate void GetnUniformfvDel(uint  program, int  location, uint  bufSize, float[]  parameters); private static GetnUniformfvDel GetnUniformfvPtr;
        
        // glGetnUniformfvARB
        private delegate void GetnUniformfvARBDel(uint  program, int  location, uint  bufSize, float[]  parameters); private static GetnUniformfvARBDel GetnUniformfvARBPtr;
        
        // glGetnUniformfvEXT
        private delegate void GetnUniformfvEXTDel(uint  program, int  location, uint  bufSize, float[]  parameters); private static GetnUniformfvEXTDel GetnUniformfvEXTPtr;
        
        // glGetnUniformfvKHR
        private delegate void GetnUniformfvKHRDel(uint  program, int  location, uint  bufSize, float[]  parameters); private static GetnUniformfvKHRDel GetnUniformfvKHRPtr;
        
        // glGetnUniformi64vARB
        private delegate void GetnUniformi64vARBDel(uint  program, int  location, uint  bufSize, long[]  parameters); private static GetnUniformi64vARBDel GetnUniformi64vARBPtr;
        
        // glGetnUniformiv
        private delegate void GetnUniformivDel(uint  program, int  location, uint  bufSize, int[]  parameters); private static GetnUniformivDel GetnUniformivPtr;
        
        // glGetnUniformivARB
        private delegate void GetnUniformivARBDel(uint  program, int  location, uint  bufSize, int[]  parameters); private static GetnUniformivARBDel GetnUniformivARBPtr;
        
        // glGetnUniformivEXT
        private delegate void GetnUniformivEXTDel(uint  program, int  location, uint  bufSize, int[]  parameters); private static GetnUniformivEXTDel GetnUniformivEXTPtr;
        
        // glGetnUniformivKHR
        private delegate void GetnUniformivKHRDel(uint  program, int  location, uint  bufSize, int[]  parameters); private static GetnUniformivKHRDel GetnUniformivKHRPtr;
        
        // glGetnUniformui64vARB
        private delegate void GetnUniformui64vARBDel(uint  program, int  location, uint  bufSize, ulong[]  parameters); private static GetnUniformui64vARBDel GetnUniformui64vARBPtr;
        
        // glGetnUniformuiv
        private delegate void GetnUniformuivDel(uint  program, int  location, uint  bufSize, uint[]  parameters); private static GetnUniformuivDel GetnUniformuivPtr;
        
        // glGetnUniformuivARB
        private delegate void GetnUniformuivARBDel(uint  program, int  location, uint  bufSize, uint[]  parameters); private static GetnUniformuivARBDel GetnUniformuivARBPtr;
        
        // glGetnUniformuivKHR
        private delegate void GetnUniformuivKHRDel(uint  program, int  location, uint  bufSize, uint[]  parameters); private static GetnUniformuivKHRDel GetnUniformuivKHRPtr;
        
        // glGlobalAlphaFactorbSUN
        private delegate void GlobalAlphaFactorbSUNDel(sbyte  factor); private static GlobalAlphaFactorbSUNDel GlobalAlphaFactorbSUNPtr;
        
        // glGlobalAlphaFactordSUN
        private delegate void GlobalAlphaFactordSUNDel(double  factor); private static GlobalAlphaFactordSUNDel GlobalAlphaFactordSUNPtr;
        
        // glGlobalAlphaFactorfSUN
        private delegate void GlobalAlphaFactorfSUNDel(float  factor); private static GlobalAlphaFactorfSUNDel GlobalAlphaFactorfSUNPtr;
        
        // glGlobalAlphaFactoriSUN
        private delegate void GlobalAlphaFactoriSUNDel(int  factor); private static GlobalAlphaFactoriSUNDel GlobalAlphaFactoriSUNPtr;
        
        // glGlobalAlphaFactorsSUN
        private delegate void GlobalAlphaFactorsSUNDel(short  factor); private static GlobalAlphaFactorsSUNDel GlobalAlphaFactorsSUNPtr;
        
        // glGlobalAlphaFactorubSUN
        private delegate void GlobalAlphaFactorubSUNDel(byte  factor); private static GlobalAlphaFactorubSUNDel GlobalAlphaFactorubSUNPtr;
        
        // glGlobalAlphaFactoruiSUN
        private delegate void GlobalAlphaFactoruiSUNDel(uint  factor); private static GlobalAlphaFactoruiSUNDel GlobalAlphaFactoruiSUNPtr;
        
        // glGlobalAlphaFactorusSUN
        private delegate void GlobalAlphaFactorusSUNDel(ushort  factor); private static GlobalAlphaFactorusSUNDel GlobalAlphaFactorusSUNPtr;
        
        // glHint
        private delegate void HintDel(uint /*HintTarget*/  target, uint /*HintMode*/  mode); private static HintDel HintPtr;
        
        // glHintPGI
        private delegate void HintPGIDel(uint /*HintTargetPGI*/  target, int  mode); private static HintPGIDel HintPGIPtr;
        
        // glHistogram
        private delegate void HistogramDel(uint /*HistogramTargetEXT*/  target, uint  width, uint /*InternalFormat*/  internalformat, bool /*Boolean*/  sink); private static HistogramDel HistogramPtr;
        
        // glHistogramEXT
        private delegate void HistogramEXTDel(uint /*HistogramTargetEXT*/  target, uint  width, uint /*InternalFormat*/  internalformat, bool /*Boolean*/  sink); private static HistogramEXTDel HistogramEXTPtr;
        
        // glIglooInterfaceSGIX
        private delegate void IglooInterfaceSGIXDel(uint  pname, IntPtr  parameters); private static IglooInterfaceSGIXDel IglooInterfaceSGIXPtr;
        
        // glImageTransformParameterfHP
        private delegate void ImageTransformParameterfHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, float  param); private static ImageTransformParameterfHPDel ImageTransformParameterfHPPtr;
        
        // glImageTransformParameterfvHP
        private delegate void ImageTransformParameterfvHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, float[]  parameters); private static ImageTransformParameterfvHPDel ImageTransformParameterfvHPPtr;
        
        // glImageTransformParameteriHP
        private delegate void ImageTransformParameteriHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, int  param); private static ImageTransformParameteriHPDel ImageTransformParameteriHPPtr;
        
        // glImageTransformParameterivHP
        private delegate void ImageTransformParameterivHPDel(uint /*ImageTransformTargetHP*/  target, uint /*ImageTransformPNameHP*/  pname, int[]  parameters); private static ImageTransformParameterivHPDel ImageTransformParameterivHPPtr;
        
        // glImportMemoryFdEXT
        private delegate void ImportMemoryFdEXTDel(uint  memory, ulong  size, uint /*ExternalHandleType*/  handleType, int  fd); private static ImportMemoryFdEXTDel ImportMemoryFdEXTPtr;
        
        // glImportMemoryWin32HandleEXT
        private delegate void ImportMemoryWin32HandleEXTDel(uint  memory, ulong  size, uint /*ExternalHandleType*/  handleType, IntPtr  handle); private static ImportMemoryWin32HandleEXTDel ImportMemoryWin32HandleEXTPtr;
        
        // glImportMemoryWin32NameEXT
        private delegate void ImportMemoryWin32NameEXTDel(uint  memory, ulong  size, uint /*ExternalHandleType*/  handleType, IntPtr  name); private static ImportMemoryWin32NameEXTDel ImportMemoryWin32NameEXTPtr;
        
        // glImportSemaphoreFdEXT
        private delegate void ImportSemaphoreFdEXTDel(uint  semaphore, uint /*ExternalHandleType*/  handleType, int  fd); private static ImportSemaphoreFdEXTDel ImportSemaphoreFdEXTPtr;
        
        // glImportSemaphoreWin32HandleEXT
        private delegate void ImportSemaphoreWin32HandleEXTDel(uint  semaphore, uint /*ExternalHandleType*/  handleType, IntPtr  handle); private static ImportSemaphoreWin32HandleEXTDel ImportSemaphoreWin32HandleEXTPtr;
        
        // glImportSemaphoreWin32NameEXT
        private delegate void ImportSemaphoreWin32NameEXTDel(uint  semaphore, uint /*ExternalHandleType*/  handleType, IntPtr  name); private static ImportSemaphoreWin32NameEXTDel ImportSemaphoreWin32NameEXTPtr;
        
        // glImportSyncEXT
        private delegate IntPtr /*sync*/ ImportSyncEXTDel(uint  external_sync_type, IntPtr  external_sync, uint  flags); private static ImportSyncEXTDel ImportSyncEXTPtr;
        
        // glIndexFormatNV
        private delegate void IndexFormatNVDel(uint  type, uint  stride); private static IndexFormatNVDel IndexFormatNVPtr;
        
        // glIndexFuncEXT
        private delegate void IndexFuncEXTDel(uint /*IndexFunctionEXT*/  func, float /*ClampedFloat32*/  refVal); private static IndexFuncEXTDel IndexFuncEXTPtr;
        
        // glIndexMask
        private delegate void IndexMaskDel(uint /*MaskedColorIndexValueI*/  mask); private static IndexMaskDel IndexMaskPtr;
        
        // glIndexMaterialEXT
        private delegate void IndexMaterialEXTDel(uint /*MaterialFace*/  face, uint /*IndexMaterialParameterEXT*/  mode); private static IndexMaterialEXTDel IndexMaterialEXTPtr;
        
        // glIndexPointer
        private delegate void IndexPointerDel(uint /*IndexPointerType*/  type, uint  stride, IntPtr  pointer); private static IndexPointerDel IndexPointerPtr;
        
        // glIndexPointerEXT
        private delegate void IndexPointerEXTDel(uint /*IndexPointerType*/  type, uint  stride, uint  count, IntPtr  pointer); private static IndexPointerEXTDel IndexPointerEXTPtr;
        
        // glIndexPointerListIBM
        private delegate void IndexPointerListIBMDel(uint /*IndexPointerType*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static IndexPointerListIBMDel IndexPointerListIBMPtr;
        
        // glIndexd
        private delegate void IndexdDel(double /*ColorIndexValueD*/  c); private static IndexdDel IndexdPtr;
        
        // glIndexdv
        private delegate void IndexdvDel(double[] /*ColorIndexValueD*/  c); private static IndexdvDel IndexdvPtr;
        
        // glIndexf
        private delegate void IndexfDel(float /*ColorIndexValueF*/  c); private static IndexfDel IndexfPtr;
        
        // glIndexfv
        private delegate void IndexfvDel(float[] /*ColorIndexValueF*/  c); private static IndexfvDel IndexfvPtr;
        
        // glIndexi
        private delegate void IndexiDel(int /*ColorIndexValueI*/  c); private static IndexiDel IndexiPtr;
        
        // glIndexiv
        private delegate void IndexivDel(int[] /*ColorIndexValueI*/  c); private static IndexivDel IndexivPtr;
        
        // glIndexs
        private delegate void IndexsDel(short /*ColorIndexValueS*/  c); private static IndexsDel IndexsPtr;
        
        // glIndexsv
        private delegate void IndexsvDel(short[] /*ColorIndexValueS*/  c); private static IndexsvDel IndexsvPtr;
        
        // glIndexub
        private delegate void IndexubDel(byte /*ColorIndexValueUB*/  c); private static IndexubDel IndexubPtr;
        
        // glIndexubv
        private delegate void IndexubvDel(byte[] /*ColorIndexValueUB*/  c); private static IndexubvDel IndexubvPtr;
        
        // glIndexxOES
        private delegate void IndexxOESDel(int  component); private static IndexxOESDel IndexxOESPtr;
        
        // glIndexxvOES
        private delegate void IndexxvOESDel(int[]  component); private static IndexxvOESDel IndexxvOESPtr;
        
        // glInitNames
        private delegate void InitNamesDel(); private static InitNamesDel InitNamesPtr;
        
        // glInsertComponentEXT
        private delegate void InsertComponentEXTDel(uint  res, uint  src, uint  num); private static InsertComponentEXTDel InsertComponentEXTPtr;
        
        // glInsertEventMarkerEXT
        private delegate void InsertEventMarkerEXTDel(uint  length, string  marker); private static InsertEventMarkerEXTDel InsertEventMarkerEXTPtr;
        
        // glInstrumentsBufferSGIX
        private delegate void InstrumentsBufferSGIXDel(uint  size, int[]  buffer); private static InstrumentsBufferSGIXDel InstrumentsBufferSGIXPtr;
        
        // glInterleavedArrays
        private delegate void InterleavedArraysDel(uint /*InterleavedArrayFormat*/  format, uint  stride, IntPtr  pointer); private static InterleavedArraysDel InterleavedArraysPtr;
        
        // glInterpolatePathsNV
        private delegate void InterpolatePathsNVDel(uint /*Path*/  resultPath, uint /*Path*/  pathA, uint /*Path*/  pathB, float  weight); private static InterpolatePathsNVDel InterpolatePathsNVPtr;
        
        // glInvalidateBufferData
        private delegate void InvalidateBufferDataDel(uint  buffer); private static InvalidateBufferDataDel InvalidateBufferDataPtr;
        
        // glInvalidateBufferSubData
        private delegate void InvalidateBufferSubDataDel(uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  length); private static InvalidateBufferSubDataDel InvalidateBufferSubDataPtr;
        
        // glInvalidateFramebuffer
        private delegate void InvalidateFramebufferDel(uint /*FramebufferTarget*/  target, uint  numAttachments, uint[] /*InvalidateFramebufferAttachment*/  attachments); private static InvalidateFramebufferDel InvalidateFramebufferPtr;
        
        // glInvalidateNamedFramebufferData
        private delegate void InvalidateNamedFramebufferDataDel(uint  framebuffer, uint  numAttachments, uint[] /*FramebufferAttachment*/  attachments); private static InvalidateNamedFramebufferDataDel InvalidateNamedFramebufferDataPtr;
        
        // glInvalidateNamedFramebufferSubData
        private delegate void InvalidateNamedFramebufferSubDataDel(uint  framebuffer, uint  numAttachments, uint[] /*FramebufferAttachment*/  attachments, int  x, int  y, uint  width, uint  height); private static InvalidateNamedFramebufferSubDataDel InvalidateNamedFramebufferSubDataPtr;
        
        // glInvalidateSubFramebuffer
        private delegate void InvalidateSubFramebufferDel(uint /*FramebufferTarget*/  target, uint  numAttachments, uint[] /*InvalidateFramebufferAttachment*/  attachments, int  x, int  y, uint  width, uint  height); private static InvalidateSubFramebufferDel InvalidateSubFramebufferPtr;
        
        // glInvalidateTexImage
        private delegate void InvalidateTexImageDel(uint  texture, int  level); private static InvalidateTexImageDel InvalidateTexImagePtr;
        
        // glInvalidateTexSubImage
        private delegate void InvalidateTexSubImageDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth); private static InvalidateTexSubImageDel InvalidateTexSubImagePtr;
        
        // glIsAsyncMarkerSGIX
        private delegate bool /*Boolean*/ IsAsyncMarkerSGIXDel(uint  marker); private static IsAsyncMarkerSGIXDel IsAsyncMarkerSGIXPtr;
        
        // glIsBuffer
        private delegate bool /*Boolean*/ IsBufferDel(uint  buffer); private static IsBufferDel IsBufferPtr;
        
        // glIsBufferARB
        private delegate bool /*Boolean*/ IsBufferARBDel(uint  buffer); private static IsBufferARBDel IsBufferARBPtr;
        
        // glIsBufferResidentNV
        private delegate bool /*Boolean*/ IsBufferResidentNVDel(uint  target); private static IsBufferResidentNVDel IsBufferResidentNVPtr;
        
        // glIsCommandListNV
        private delegate bool /*Boolean*/ IsCommandListNVDel(uint  list); private static IsCommandListNVDel IsCommandListNVPtr;
        
        // glIsEnabled
        private delegate bool /*Boolean*/ IsEnabledDel(uint /*EnableCap*/  cap); private static IsEnabledDel IsEnabledPtr;
        
        // glIsEnabledIndexedEXT
        private delegate bool /*Boolean*/ IsEnabledIndexedEXTDel(uint /*EnableCap*/  target, uint  index); private static IsEnabledIndexedEXTDel IsEnabledIndexedEXTPtr;
        
        // glIsEnabledi
        private delegate bool /*Boolean*/ IsEnablediDel(uint /*EnableCap*/  target, uint  index); private static IsEnablediDel IsEnablediPtr;
        
        // glIsEnablediEXT
        private delegate bool /*Boolean*/ IsEnablediEXTDel(uint /*EnableCap*/  target, uint  index); private static IsEnablediEXTDel IsEnablediEXTPtr;
        
        // glIsEnablediNV
        private delegate bool /*Boolean*/ IsEnablediNVDel(uint /*EnableCap*/  target, uint  index); private static IsEnablediNVDel IsEnablediNVPtr;
        
        // glIsEnablediOES
        private delegate bool /*Boolean*/ IsEnablediOESDel(uint /*EnableCap*/  target, uint  index); private static IsEnablediOESDel IsEnablediOESPtr;
        
        // glIsFenceAPPLE
        private delegate bool /*Boolean*/ IsFenceAPPLEDel(uint /*FenceNV*/  fence); private static IsFenceAPPLEDel IsFenceAPPLEPtr;
        
        // glIsFenceNV
        private delegate bool /*Boolean*/ IsFenceNVDel(uint /*FenceNV*/  fence); private static IsFenceNVDel IsFenceNVPtr;
        
        // glIsFramebuffer
        private delegate bool /*Boolean*/ IsFramebufferDel(uint  framebuffer); private static IsFramebufferDel IsFramebufferPtr;
        
        // glIsFramebufferEXT
        private delegate bool /*Boolean*/ IsFramebufferEXTDel(uint  framebuffer); private static IsFramebufferEXTDel IsFramebufferEXTPtr;
        
        // glIsFramebufferOES
        private delegate bool /*Boolean*/ IsFramebufferOESDel(uint  framebuffer); private static IsFramebufferOESDel IsFramebufferOESPtr;
        
        // glIsImageHandleResidentARB
        private delegate bool /*Boolean*/ IsImageHandleResidentARBDel(ulong  handle); private static IsImageHandleResidentARBDel IsImageHandleResidentARBPtr;
        
        // glIsImageHandleResidentNV
        private delegate bool /*Boolean*/ IsImageHandleResidentNVDel(ulong  handle); private static IsImageHandleResidentNVDel IsImageHandleResidentNVPtr;
        
        // glIsList
        private delegate bool /*Boolean*/ IsListDel(uint /*List*/  list); private static IsListDel IsListPtr;
        
        // glIsMemoryObjectEXT
        private delegate bool /*Boolean*/ IsMemoryObjectEXTDel(uint  memoryObject); private static IsMemoryObjectEXTDel IsMemoryObjectEXTPtr;
        
        // glIsNameAMD
        private delegate bool /*Boolean*/ IsNameAMDDel(uint  identifier, uint  name); private static IsNameAMDDel IsNameAMDPtr;
        
        // glIsNamedBufferResidentNV
        private delegate bool /*Boolean*/ IsNamedBufferResidentNVDel(uint  buffer); private static IsNamedBufferResidentNVDel IsNamedBufferResidentNVPtr;
        
        // glIsNamedStringARB
        private delegate bool /*Boolean*/ IsNamedStringARBDel(int  namelen, string  name); private static IsNamedStringARBDel IsNamedStringARBPtr;
        
        // glIsObjectBufferATI
        private delegate bool /*Boolean*/ IsObjectBufferATIDel(uint  buffer); private static IsObjectBufferATIDel IsObjectBufferATIPtr;
        
        // glIsOcclusionQueryNV
        private delegate bool /*Boolean*/ IsOcclusionQueryNVDel(uint  id); private static IsOcclusionQueryNVDel IsOcclusionQueryNVPtr;
        
        // glIsPathNV
        private delegate bool /*Boolean*/ IsPathNVDel(uint /*Path*/  path); private static IsPathNVDel IsPathNVPtr;
        
        // glIsPointInFillPathNV
        private delegate bool /*Boolean*/ IsPointInFillPathNVDel(uint /*Path*/  path, uint /*MaskedStencilValue*/  mask, float  x, float  y); private static IsPointInFillPathNVDel IsPointInFillPathNVPtr;
        
        // glIsPointInStrokePathNV
        private delegate bool /*Boolean*/ IsPointInStrokePathNVDel(uint /*Path*/  path, float  x, float  y); private static IsPointInStrokePathNVDel IsPointInStrokePathNVPtr;
        
        // glIsProgram
        private delegate bool /*Boolean*/ IsProgramDel(uint  program); private static IsProgramDel IsProgramPtr;
        
        // glIsProgramARB
        private delegate bool /*Boolean*/ IsProgramARBDel(uint  program); private static IsProgramARBDel IsProgramARBPtr;
        
        // glIsProgramNV
        private delegate bool /*Boolean*/ IsProgramNVDel(uint  id); private static IsProgramNVDel IsProgramNVPtr;
        
        // glIsProgramPipeline
        private delegate bool /*Boolean*/ IsProgramPipelineDel(uint  pipeline); private static IsProgramPipelineDel IsProgramPipelinePtr;
        
        // glIsProgramPipelineEXT
        private delegate bool /*Boolean*/ IsProgramPipelineEXTDel(uint  pipeline); private static IsProgramPipelineEXTDel IsProgramPipelineEXTPtr;
        
        // glIsQuery
        private delegate bool /*Boolean*/ IsQueryDel(uint  id); private static IsQueryDel IsQueryPtr;
        
        // glIsQueryARB
        private delegate bool /*Boolean*/ IsQueryARBDel(uint  id); private static IsQueryARBDel IsQueryARBPtr;
        
        // glIsQueryEXT
        private delegate bool /*Boolean*/ IsQueryEXTDel(uint  id); private static IsQueryEXTDel IsQueryEXTPtr;
        
        // glIsRenderbuffer
        private delegate bool /*Boolean*/ IsRenderbufferDel(uint  renderbuffer); private static IsRenderbufferDel IsRenderbufferPtr;
        
        // glIsRenderbufferEXT
        private delegate bool /*Boolean*/ IsRenderbufferEXTDel(uint  renderbuffer); private static IsRenderbufferEXTDel IsRenderbufferEXTPtr;
        
        // glIsRenderbufferOES
        private delegate bool /*Boolean*/ IsRenderbufferOESDel(uint  renderbuffer); private static IsRenderbufferOESDel IsRenderbufferOESPtr;
        
        // glIsSemaphoreEXT
        private delegate bool /*Boolean*/ IsSemaphoreEXTDel(uint  semaphore); private static IsSemaphoreEXTDel IsSemaphoreEXTPtr;
        
        // glIsSampler
        private delegate bool /*Boolean*/ IsSamplerDel(uint  sampler); private static IsSamplerDel IsSamplerPtr;
        
        // glIsShader
        private delegate bool /*Boolean*/ IsShaderDel(uint  shader); private static IsShaderDel IsShaderPtr;
        
        // glIsStateNV
        private delegate bool /*Boolean*/ IsStateNVDel(uint  state); private static IsStateNVDel IsStateNVPtr;
        
        // glIsSync
        private delegate bool /*Boolean*/ IsSyncDel(IntPtr /*sync*/  sync); private static IsSyncDel IsSyncPtr;
        
        // glIsSyncAPPLE
        private delegate bool /*Boolean*/ IsSyncAPPLEDel(IntPtr  sync); private static IsSyncAPPLEDel IsSyncAPPLEPtr;
        
        // glIsTexture
        private delegate bool /*Boolean*/ IsTextureDel(uint /*Texture*/  texture); private static IsTextureDel IsTexturePtr;
        
        // glIsTextureEXT
        private delegate bool /*Boolean*/ IsTextureEXTDel(uint /*Texture*/  texture); private static IsTextureEXTDel IsTextureEXTPtr;
        
        // glIsTextureHandleResidentARB
        private delegate bool /*Boolean*/ IsTextureHandleResidentARBDel(ulong  handle); private static IsTextureHandleResidentARBDel IsTextureHandleResidentARBPtr;
        
        // glIsTextureHandleResidentNV
        private delegate bool /*Boolean*/ IsTextureHandleResidentNVDel(ulong  handle); private static IsTextureHandleResidentNVDel IsTextureHandleResidentNVPtr;
        
        // glIsTransformFeedback
        private delegate bool /*Boolean*/ IsTransformFeedbackDel(uint  id); private static IsTransformFeedbackDel IsTransformFeedbackPtr;
        
        // glIsTransformFeedbackNV
        private delegate bool /*Boolean*/ IsTransformFeedbackNVDel(uint  id); private static IsTransformFeedbackNVDel IsTransformFeedbackNVPtr;
        
        // glIsVariantEnabledEXT
        private delegate bool /*Boolean*/ IsVariantEnabledEXTDel(uint  id, uint /*VariantCapEXT*/  cap); private static IsVariantEnabledEXTDel IsVariantEnabledEXTPtr;
        
        // glIsVertexArray
        private delegate bool /*Boolean*/ IsVertexArrayDel(uint  array); private static IsVertexArrayDel IsVertexArrayPtr;
        
        // glIsVertexArrayAPPLE
        private delegate bool /*Boolean*/ IsVertexArrayAPPLEDel(uint  array); private static IsVertexArrayAPPLEDel IsVertexArrayAPPLEPtr;
        
        // glIsVertexArrayOES
        private delegate bool /*Boolean*/ IsVertexArrayOESDel(uint  array); private static IsVertexArrayOESDel IsVertexArrayOESPtr;
        
        // glIsVertexAttribEnabledAPPLE
        private delegate bool /*Boolean*/ IsVertexAttribEnabledAPPLEDel(uint  index, uint  pname); private static IsVertexAttribEnabledAPPLEDel IsVertexAttribEnabledAPPLEPtr;
        
        // glLGPUCopyImageSubDataNVX
        private delegate void LGPUCopyImageSubDataNVXDel(uint  sourceGpu, uint  destinationGpuMask, uint  srcName, uint  srcTarget, int  srcLevel, int  srcX, int  srxY, int  srcZ, uint  dstName, uint  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  width, uint  height, uint  depth); private static LGPUCopyImageSubDataNVXDel LGPUCopyImageSubDataNVXPtr;
        
        // glLGPUInterlockNVX
        private delegate void LGPUInterlockNVXDel(); private static LGPUInterlockNVXDel LGPUInterlockNVXPtr;
        
        // glLGPUNamedBufferSubDataNVX
        private delegate void LGPUNamedBufferSubDataNVXDel(uint  gpuMask, uint  buffer, IntPtr  offset, IntPtr  size, IntPtr  data); private static LGPUNamedBufferSubDataNVXDel LGPUNamedBufferSubDataNVXPtr;
        
        // glLabelObjectEXT
        private delegate void LabelObjectEXTDel(uint  type, uint  obj, uint  length, string  label); private static LabelObjectEXTDel LabelObjectEXTPtr;
        
        // glLightEnviSGIX
        private delegate void LightEnviSGIXDel(uint /*LightEnvParameterSGIX*/  pname, int /*CheckedInt32*/  param); private static LightEnviSGIXDel LightEnviSGIXPtr;
        
        // glLightModelf
        private delegate void LightModelfDel(uint /*LightModelParameter*/  pname, float  param); private static LightModelfDel LightModelfPtr;
        
        // glLightModelfv
        private delegate void LightModelfvDel(uint /*LightModelParameter*/  pname, float[]  parameters); private static LightModelfvDel LightModelfvPtr;
        
        // glLightModeli
        private delegate void LightModeliDel(uint /*LightModelParameter*/  pname, int  param); private static LightModeliDel LightModeliPtr;
        
        // glLightModeliv
        private delegate void LightModelivDel(uint /*LightModelParameter*/  pname, int[]  parameters); private static LightModelivDel LightModelivPtr;
        
        // glLightModelx
        private delegate void LightModelxDel(uint /*LightModelParameter*/  pname, int  param); private static LightModelxDel LightModelxPtr;
        
        // glLightModelxOES
        private delegate void LightModelxOESDel(uint /*LightModelParameter*/  pname, int  param); private static LightModelxOESDel LightModelxOESPtr;
        
        // glLightModelxv
        private delegate void LightModelxvDel(uint /*LightModelParameter*/  pname, int[]  param); private static LightModelxvDel LightModelxvPtr;
        
        // glLightModelxvOES
        private delegate void LightModelxvOESDel(uint /*LightModelParameter*/  pname, int[]  param); private static LightModelxvOESDel LightModelxvOESPtr;
        
        // glLightf
        private delegate void LightfDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, float /*CheckedFloat32*/  param); private static LightfDel LightfPtr;
        
        // glLightfv
        private delegate void LightfvDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static LightfvDel LightfvPtr;
        
        // glLighti
        private delegate void LightiDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int /*CheckedInt32*/  param); private static LightiDel LightiPtr;
        
        // glLightiv
        private delegate void LightivDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static LightivDel LightivPtr;
        
        // glLightx
        private delegate void LightxDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int  param); private static LightxDel LightxPtr;
        
        // glLightxOES
        private delegate void LightxOESDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int  param); private static LightxOESDel LightxOESPtr;
        
        // glLightxv
        private delegate void LightxvDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static LightxvDel LightxvPtr;
        
        // glLightxvOES
        private delegate void LightxvOESDel(uint /*LightName*/  light, uint /*LightParameter*/  pname, int[]  parameters); private static LightxvOESDel LightxvOESPtr;
        
        // glLineStipple
        private delegate void LineStippleDel(int /*CheckedInt32*/  factor, ushort /*LineStipple*/  pattern); private static LineStippleDel LineStipplePtr;
        
        // glLineWidth
        private delegate void LineWidthDel(float /*CheckedFloat32*/  width); private static LineWidthDel LineWidthPtr;
        
        // glLineWidthx
        private delegate void LineWidthxDel(int  width); private static LineWidthxDel LineWidthxPtr;
        
        // glLineWidthxOES
        private delegate void LineWidthxOESDel(int  width); private static LineWidthxOESDel LineWidthxOESPtr;
        
        // glLinkProgram
        private delegate void LinkProgramDel(uint  program); private static LinkProgramDel LinkProgramPtr;
        
        // glLinkProgramARB
        private delegate void LinkProgramARBDel(IntPtr /*handleARB*/  programObj); private static LinkProgramARBDel LinkProgramARBPtr;
        
        // glListBase
        private delegate void ListBaseDel(uint /*List*/  basis); private static ListBaseDel ListBasePtr;
        
        // glListDrawCommandsStatesClientNV
        private delegate void ListDrawCommandsStatesClientNVDel(uint  list, uint  segment, IntPtr  indirects, uint[]  sizes, uint[]  states, uint[]  fbos, uint  count); private static ListDrawCommandsStatesClientNVDel ListDrawCommandsStatesClientNVPtr;
        
        // glListParameterfSGIX
        private delegate void ListParameterfSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, float /*CheckedFloat32*/  param); private static ListParameterfSGIXDel ListParameterfSGIXPtr;
        
        // glListParameterfvSGIX
        private delegate void ListParameterfvSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, float[] /*CheckedFloat32*/  parameters); private static ListParameterfvSGIXDel ListParameterfvSGIXPtr;
        
        // glListParameteriSGIX
        private delegate void ListParameteriSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, int /*CheckedInt32*/  param); private static ListParameteriSGIXDel ListParameteriSGIXPtr;
        
        // glListParameterivSGIX
        private delegate void ListParameterivSGIXDel(uint /*List*/  list, uint /*ListParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static ListParameterivSGIXDel ListParameterivSGIXPtr;
        
        // glLoadIdentity
        private delegate void LoadIdentityDel(); private static LoadIdentityDel LoadIdentityPtr;
        
        // glLoadIdentityDeformationMapSGIX
        private delegate void LoadIdentityDeformationMapSGIXDel(uint /*FfdMaskSGIX*/  mask); private static LoadIdentityDeformationMapSGIXDel LoadIdentityDeformationMapSGIXPtr;
        
        // glLoadMatrixd
        private delegate void LoadMatrixdDel(double[]  m); private static LoadMatrixdDel LoadMatrixdPtr;
        
        // glLoadMatrixf
        private delegate void LoadMatrixfDel(float[]  m); private static LoadMatrixfDel LoadMatrixfPtr;
        
        // glLoadMatrixx
        private delegate void LoadMatrixxDel(int[]  m); private static LoadMatrixxDel LoadMatrixxPtr;
        
        // glLoadMatrixxOES
        private delegate void LoadMatrixxOESDel(int[]  m); private static LoadMatrixxOESDel LoadMatrixxOESPtr;
        
        // glLoadName
        private delegate void LoadNameDel(uint /*SelectName*/  name); private static LoadNameDel LoadNamePtr;
        
        // glLoadPaletteFromModelViewMatrixOES
        private delegate void LoadPaletteFromModelViewMatrixOESDel(); private static LoadPaletteFromModelViewMatrixOESDel LoadPaletteFromModelViewMatrixOESPtr;
        
        // glLoadProgramNV
        private delegate void LoadProgramNVDel(uint /*VertexAttribEnumNV*/  target, uint  id, uint  len, byte[]  program); private static LoadProgramNVDel LoadProgramNVPtr;
        
        // glLoadTransposeMatrixd
        private delegate void LoadTransposeMatrixdDel(double[]  m); private static LoadTransposeMatrixdDel LoadTransposeMatrixdPtr;
        
        // glLoadTransposeMatrixdARB
        private delegate void LoadTransposeMatrixdARBDel(double[]  m); private static LoadTransposeMatrixdARBDel LoadTransposeMatrixdARBPtr;
        
        // glLoadTransposeMatrixf
        private delegate void LoadTransposeMatrixfDel(float[]  m); private static LoadTransposeMatrixfDel LoadTransposeMatrixfPtr;
        
        // glLoadTransposeMatrixfARB
        private delegate void LoadTransposeMatrixfARBDel(float[]  m); private static LoadTransposeMatrixfARBDel LoadTransposeMatrixfARBPtr;
        
        // glLoadTransposeMatrixxOES
        private delegate void LoadTransposeMatrixxOESDel(int[]  m); private static LoadTransposeMatrixxOESDel LoadTransposeMatrixxOESPtr;
        
        // glLockArraysEXT
        private delegate void LockArraysEXTDel(int  first, uint  count); private static LockArraysEXTDel LockArraysEXTPtr;
        
        // glLogicOp
        private delegate void LogicOpDel(uint /*LogicOp*/  opcode); private static LogicOpDel LogicOpPtr;
        
        // glMakeBufferNonResidentNV
        private delegate void MakeBufferNonResidentNVDel(uint  target); private static MakeBufferNonResidentNVDel MakeBufferNonResidentNVPtr;
        
        // glMakeBufferResidentNV
        private delegate void MakeBufferResidentNVDel(uint  target, uint  access); private static MakeBufferResidentNVDel MakeBufferResidentNVPtr;
        
        // glMakeImageHandleNonResidentARB
        private delegate void MakeImageHandleNonResidentARBDel(ulong  handle); private static MakeImageHandleNonResidentARBDel MakeImageHandleNonResidentARBPtr;
        
        // glMakeImageHandleNonResidentNV
        private delegate void MakeImageHandleNonResidentNVDel(ulong  handle); private static MakeImageHandleNonResidentNVDel MakeImageHandleNonResidentNVPtr;
        
        // glMakeImageHandleResidentARB
        private delegate void MakeImageHandleResidentARBDel(ulong  handle, uint  access); private static MakeImageHandleResidentARBDel MakeImageHandleResidentARBPtr;
        
        // glMakeImageHandleResidentNV
        private delegate void MakeImageHandleResidentNVDel(ulong  handle, uint  access); private static MakeImageHandleResidentNVDel MakeImageHandleResidentNVPtr;
        
        // glMakeNamedBufferNonResidentNV
        private delegate void MakeNamedBufferNonResidentNVDel(uint  buffer); private static MakeNamedBufferNonResidentNVDel MakeNamedBufferNonResidentNVPtr;
        
        // glMakeNamedBufferResidentNV
        private delegate void MakeNamedBufferResidentNVDel(uint  buffer, uint  access); private static MakeNamedBufferResidentNVDel MakeNamedBufferResidentNVPtr;
        
        // glMakeTextureHandleNonResidentARB
        private delegate void MakeTextureHandleNonResidentARBDel(ulong  handle); private static MakeTextureHandleNonResidentARBDel MakeTextureHandleNonResidentARBPtr;
        
        // glMakeTextureHandleNonResidentNV
        private delegate void MakeTextureHandleNonResidentNVDel(ulong  handle); private static MakeTextureHandleNonResidentNVDel MakeTextureHandleNonResidentNVPtr;
        
        // glMakeTextureHandleResidentARB
        private delegate void MakeTextureHandleResidentARBDel(ulong  handle); private static MakeTextureHandleResidentARBDel MakeTextureHandleResidentARBPtr;
        
        // glMakeTextureHandleResidentNV
        private delegate void MakeTextureHandleResidentNVDel(ulong  handle); private static MakeTextureHandleResidentNVDel MakeTextureHandleResidentNVPtr;
        
        // glMap1d
        private delegate void Map1dDel(uint /*MapTarget*/  target, double /*CoordD*/  u1, double /*CoordD*/  u2, int  stride, int /*CheckedInt32*/  order, double[] /*CoordD*/  points); private static Map1dDel Map1dPtr;
        
        // glMap1f
        private delegate void Map1fDel(uint /*MapTarget*/  target, float /*CoordF*/  u1, float /*CoordF*/  u2, int  stride, int /*CheckedInt32*/  order, float[] /*CoordF*/  points); private static Map1fDel Map1fPtr;
        
        // glMap1xOES
        private delegate void Map1xOESDel(uint /*MapTarget*/  target, int  u1, int  u2, int  stride, int  order, int  points); private static Map1xOESDel Map1xOESPtr;
        
        // glMap2d
        private delegate void Map2dDel(uint /*MapTarget*/  target, double /*CoordD*/  u1, double /*CoordD*/  u2, int  ustride, int /*CheckedInt32*/  uorder, double /*CoordD*/  v1, double /*CoordD*/  v2, int  vstride, int /*CheckedInt32*/  vorder, double[] /*CoordD*/  points); private static Map2dDel Map2dPtr;
        
        // glMap2f
        private delegate void Map2fDel(uint /*MapTarget*/  target, float /*CoordF*/  u1, float /*CoordF*/  u2, int  ustride, int /*CheckedInt32*/  uorder, float /*CoordF*/  v1, float /*CoordF*/  v2, int  vstride, int /*CheckedInt32*/  vorder, float[] /*CoordF*/  points); private static Map2fDel Map2fPtr;
        
        // glMap2xOES
        private delegate void Map2xOESDel(uint /*MapTarget*/  target, int  u1, int  u2, int  ustride, int  uorder, int  v1, int  v2, int  vstride, int  vorder, int  points); private static Map2xOESDel Map2xOESPtr;
        
        // glMapBuffer
        private delegate void MapBufferDel(uint /*BufferTargetARB*/  target, uint /*BufferAccessARB*/  access); private static MapBufferDel MapBufferPtr;
        
        // glMapBufferARB
        private delegate void MapBufferARBDel(uint /*BufferTargetARB*/  target, uint /*BufferAccessARB*/  access); private static MapBufferARBDel MapBufferARBPtr;
        
        // glMapBufferOES
        private delegate void MapBufferOESDel(uint /*BufferTargetARB*/  target, uint /*BufferAccessARB*/  access); private static MapBufferOESDel MapBufferOESPtr;
        
        // glMapBufferRange
        private delegate void MapBufferRangeDel(uint /*BufferTargetARB*/  target, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  length, uint /*MapBufferAccessMask*/  access); private static MapBufferRangeDel MapBufferRangePtr;
        
        // glMapBufferRangeEXT
        private delegate void MapBufferRangeEXTDel(uint /*BufferTargetARB*/  target, IntPtr  offset, IntPtr  length, uint /*MapBufferAccessMask*/  access); private static MapBufferRangeEXTDel MapBufferRangeEXTPtr;
        
        // glMapControlPointsNV
        private delegate void MapControlPointsNVDel(uint /*EvalTargetNV*/  target, uint  index, uint /*MapTypeNV*/  type, uint  ustride, uint  vstride, int /*CheckedInt32*/  uorder, int /*CheckedInt32*/  vorder, bool /*Boolean*/  packed, IntPtr  points); private static MapControlPointsNVDel MapControlPointsNVPtr;
        
        // glMapGrid1d
        private delegate void MapGrid1dDel(int  un, double /*CoordD*/  u1, double /*CoordD*/  u2); private static MapGrid1dDel MapGrid1dPtr;
        
        // glMapGrid1f
        private delegate void MapGrid1fDel(int  un, float /*CoordF*/  u1, float /*CoordF*/  u2); private static MapGrid1fDel MapGrid1fPtr;
        
        // glMapGrid1xOES
        private delegate void MapGrid1xOESDel(int  n, int  u1, int  u2); private static MapGrid1xOESDel MapGrid1xOESPtr;
        
        // glMapGrid2d
        private delegate void MapGrid2dDel(int  un, double /*CoordD*/  u1, double /*CoordD*/  u2, int  vn, double /*CoordD*/  v1, double /*CoordD*/  v2); private static MapGrid2dDel MapGrid2dPtr;
        
        // glMapGrid2f
        private delegate void MapGrid2fDel(int  un, float /*CoordF*/  u1, float /*CoordF*/  u2, int  vn, float /*CoordF*/  v1, float /*CoordF*/  v2); private static MapGrid2fDel MapGrid2fPtr;
        
        // glMapGrid2xOES
        private delegate void MapGrid2xOESDel(int  n, int  u1, int  u2, int  v1, int  v2); private static MapGrid2xOESDel MapGrid2xOESPtr;
        
        // glMapNamedBuffer
        private delegate void MapNamedBufferDel(uint  buffer, uint /*BufferAccessARB*/  access); private static MapNamedBufferDel MapNamedBufferPtr;
        
        // glMapNamedBufferEXT
        private delegate void MapNamedBufferEXTDel(uint  buffer, uint /*BufferAccessARB*/  access); private static MapNamedBufferEXTDel MapNamedBufferEXTPtr;
        
        // glMapNamedBufferRange
        private delegate void MapNamedBufferRangeDel(uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  length, uint /*MapBufferAccessMask*/  access); private static MapNamedBufferRangeDel MapNamedBufferRangePtr;
        
        // glMapNamedBufferRangeEXT
        private delegate void MapNamedBufferRangeEXTDel(uint  buffer, IntPtr  offset, IntPtr  length, uint /*MapBufferAccessMask*/  access); private static MapNamedBufferRangeEXTDel MapNamedBufferRangeEXTPtr;
        
        // glMapObjectBufferATI
        private delegate void MapObjectBufferATIDel(uint  buffer); private static MapObjectBufferATIDel MapObjectBufferATIPtr;
        
        // glMapParameterfvNV
        private delegate void MapParameterfvNVDel(uint /*EvalTargetNV*/  target, uint /*MapParameterNV*/  pname, float[] /*CheckedFloat32*/  parameters); private static MapParameterfvNVDel MapParameterfvNVPtr;
        
        // glMapParameterivNV
        private delegate void MapParameterivNVDel(uint /*EvalTargetNV*/  target, uint /*MapParameterNV*/  pname, int[] /*CheckedInt32*/  parameters); private static MapParameterivNVDel MapParameterivNVPtr;
        
        // glMapTexture2DINTEL
        private delegate void MapTexture2DINTELDel(uint  texture, int  level, uint  access, int[]  stride, uint[]  layout); private static MapTexture2DINTELDel MapTexture2DINTELPtr;
        
        // glMapVertexAttrib1dAPPLE
        private delegate void MapVertexAttrib1dAPPLEDel(uint  index, uint  size, double /*CoordD*/  u1, double /*CoordD*/  u2, int  stride, int /*CheckedInt32*/  order, double[] /*CoordD*/  points); private static MapVertexAttrib1dAPPLEDel MapVertexAttrib1dAPPLEPtr;
        
        // glMapVertexAttrib1fAPPLE
        private delegate void MapVertexAttrib1fAPPLEDel(uint  index, uint  size, float /*CoordF*/  u1, float /*CoordF*/  u2, int  stride, int /*CheckedInt32*/  order, float[] /*CoordF*/  points); private static MapVertexAttrib1fAPPLEDel MapVertexAttrib1fAPPLEPtr;
        
        // glMapVertexAttrib2dAPPLE
        private delegate void MapVertexAttrib2dAPPLEDel(uint  index, uint  size, double /*CoordD*/  u1, double /*CoordD*/  u2, int  ustride, int /*CheckedInt32*/  uorder, double /*CoordD*/  v1, double /*CoordD*/  v2, int  vstride, int /*CheckedInt32*/  vorder, double[] /*CoordD*/  points); private static MapVertexAttrib2dAPPLEDel MapVertexAttrib2dAPPLEPtr;
        
        // glMapVertexAttrib2fAPPLE
        private delegate void MapVertexAttrib2fAPPLEDel(uint  index, uint  size, float /*CoordF*/  u1, float /*CoordF*/  u2, int  ustride, int /*CheckedInt32*/  uorder, float /*CoordF*/  v1, float /*CoordF*/  v2, int  vstride, int /*CheckedInt32*/  vorder, float[] /*CoordF*/  points); private static MapVertexAttrib2fAPPLEDel MapVertexAttrib2fAPPLEPtr;
        
        // glMaterialf
        private delegate void MaterialfDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float /*CheckedFloat32*/  param); private static MaterialfDel MaterialfPtr;
        
        // glMaterialfv
        private delegate void MaterialfvDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static MaterialfvDel MaterialfvPtr;
        
        // glMateriali
        private delegate void MaterialiDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int /*CheckedInt32*/  param); private static MaterialiDel MaterialiPtr;
        
        // glMaterialiv
        private delegate void MaterialivDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static MaterialivDel MaterialivPtr;
        
        // glMaterialx
        private delegate void MaterialxDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int  param); private static MaterialxDel MaterialxPtr;
        
        // glMaterialxOES
        private delegate void MaterialxOESDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int  param); private static MaterialxOESDel MaterialxOESPtr;
        
        // glMaterialxv
        private delegate void MaterialxvDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  param); private static MaterialxvDel MaterialxvPtr;
        
        // glMaterialxvOES
        private delegate void MaterialxvOESDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  pname, int[]  param); private static MaterialxvOESDel MaterialxvOESPtr;
        
        // glMatrixFrustumEXT
        private delegate void MatrixFrustumEXTDel(uint /*MatrixMode*/  mode, double  left, double  right, double  bottom, double  top, double  zNear, double  zFar); private static MatrixFrustumEXTDel MatrixFrustumEXTPtr;
        
        // glMatrixIndexPointerARB
        private delegate void MatrixIndexPointerARBDel(int  size, uint /*MatrixIndexPointerTypeARB*/  type, uint  stride, IntPtr  pointer); private static MatrixIndexPointerARBDel MatrixIndexPointerARBPtr;
        
        // glMatrixIndexPointerOES
        private delegate void MatrixIndexPointerOESDel(int  size, uint /*MatrixIndexPointerTypeARB*/  type, uint  stride, IntPtr  pointer); private static MatrixIndexPointerOESDel MatrixIndexPointerOESPtr;
        
        // glMatrixIndexubvARB
        private delegate void MatrixIndexubvARBDel(int  size, byte[]  indices); private static MatrixIndexubvARBDel MatrixIndexubvARBPtr;
        
        // glMatrixIndexuivARB
        private delegate void MatrixIndexuivARBDel(int  size, uint[]  indices); private static MatrixIndexuivARBDel MatrixIndexuivARBPtr;
        
        // glMatrixIndexusvARB
        private delegate void MatrixIndexusvARBDel(int  size, ushort[]  indices); private static MatrixIndexusvARBDel MatrixIndexusvARBPtr;
        
        // glMatrixLoad3x2fNV
        private delegate void MatrixLoad3x2fNVDel(uint  matrixMode, float[]  m); private static MatrixLoad3x2fNVDel MatrixLoad3x2fNVPtr;
        
        // glMatrixLoad3x3fNV
        private delegate void MatrixLoad3x3fNVDel(uint  matrixMode, float[]  m); private static MatrixLoad3x3fNVDel MatrixLoad3x3fNVPtr;
        
        // glMatrixLoadIdentityEXT
        private delegate void MatrixLoadIdentityEXTDel(uint /*MatrixMode*/  mode); private static MatrixLoadIdentityEXTDel MatrixLoadIdentityEXTPtr;
        
        // glMatrixLoadTranspose3x3fNV
        private delegate void MatrixLoadTranspose3x3fNVDel(uint  matrixMode, float[]  m); private static MatrixLoadTranspose3x3fNVDel MatrixLoadTranspose3x3fNVPtr;
        
        // glMatrixLoadTransposedEXT
        private delegate void MatrixLoadTransposedEXTDel(uint /*MatrixMode*/  mode, double[]  m); private static MatrixLoadTransposedEXTDel MatrixLoadTransposedEXTPtr;
        
        // glMatrixLoadTransposefEXT
        private delegate void MatrixLoadTransposefEXTDel(uint /*MatrixMode*/  mode, float[]  m); private static MatrixLoadTransposefEXTDel MatrixLoadTransposefEXTPtr;
        
        // glMatrixLoaddEXT
        private delegate void MatrixLoaddEXTDel(uint /*MatrixMode*/  mode, double[]  m); private static MatrixLoaddEXTDel MatrixLoaddEXTPtr;
        
        // glMatrixLoadfEXT
        private delegate void MatrixLoadfEXTDel(uint /*MatrixMode*/  mode, float[]  m); private static MatrixLoadfEXTDel MatrixLoadfEXTPtr;
        
        // glMatrixMode
        private delegate void MatrixModeDel(uint /*MatrixMode*/  mode); private static MatrixModeDel MatrixModePtr;
        
        // glMatrixMult3x2fNV
        private delegate void MatrixMult3x2fNVDel(uint  matrixMode, float[]  m); private static MatrixMult3x2fNVDel MatrixMult3x2fNVPtr;
        
        // glMatrixMult3x3fNV
        private delegate void MatrixMult3x3fNVDel(uint  matrixMode, float[]  m); private static MatrixMult3x3fNVDel MatrixMult3x3fNVPtr;
        
        // glMatrixMultTranspose3x3fNV
        private delegate void MatrixMultTranspose3x3fNVDel(uint  matrixMode, float[]  m); private static MatrixMultTranspose3x3fNVDel MatrixMultTranspose3x3fNVPtr;
        
        // glMatrixMultTransposedEXT
        private delegate void MatrixMultTransposedEXTDel(uint /*MatrixMode*/  mode, double[]  m); private static MatrixMultTransposedEXTDel MatrixMultTransposedEXTPtr;
        
        // glMatrixMultTransposefEXT
        private delegate void MatrixMultTransposefEXTDel(uint /*MatrixMode*/  mode, float[]  m); private static MatrixMultTransposefEXTDel MatrixMultTransposefEXTPtr;
        
        // glMatrixMultdEXT
        private delegate void MatrixMultdEXTDel(uint /*MatrixMode*/  mode, double[]  m); private static MatrixMultdEXTDel MatrixMultdEXTPtr;
        
        // glMatrixMultfEXT
        private delegate void MatrixMultfEXTDel(uint /*MatrixMode*/  mode, float[]  m); private static MatrixMultfEXTDel MatrixMultfEXTPtr;
        
        // glMatrixOrthoEXT
        private delegate void MatrixOrthoEXTDel(uint /*MatrixMode*/  mode, double  left, double  right, double  bottom, double  top, double  zNear, double  zFar); private static MatrixOrthoEXTDel MatrixOrthoEXTPtr;
        
        // glMatrixPopEXT
        private delegate void MatrixPopEXTDel(uint /*MatrixMode*/  mode); private static MatrixPopEXTDel MatrixPopEXTPtr;
        
        // glMatrixPushEXT
        private delegate void MatrixPushEXTDel(uint /*MatrixMode*/  mode); private static MatrixPushEXTDel MatrixPushEXTPtr;
        
        // glMatrixRotatedEXT
        private delegate void MatrixRotatedEXTDel(uint /*MatrixMode*/  mode, double  angle, double  x, double  y, double  z); private static MatrixRotatedEXTDel MatrixRotatedEXTPtr;
        
        // glMatrixRotatefEXT
        private delegate void MatrixRotatefEXTDel(uint /*MatrixMode*/  mode, float  angle, float  x, float  y, float  z); private static MatrixRotatefEXTDel MatrixRotatefEXTPtr;
        
        // glMatrixScaledEXT
        private delegate void MatrixScaledEXTDel(uint /*MatrixMode*/  mode, double  x, double  y, double  z); private static MatrixScaledEXTDel MatrixScaledEXTPtr;
        
        // glMatrixScalefEXT
        private delegate void MatrixScalefEXTDel(uint /*MatrixMode*/  mode, float  x, float  y, float  z); private static MatrixScalefEXTDel MatrixScalefEXTPtr;
        
        // glMatrixTranslatedEXT
        private delegate void MatrixTranslatedEXTDel(uint /*MatrixMode*/  mode, double  x, double  y, double  z); private static MatrixTranslatedEXTDel MatrixTranslatedEXTPtr;
        
        // glMatrixTranslatefEXT
        private delegate void MatrixTranslatefEXTDel(uint /*MatrixMode*/  mode, float  x, float  y, float  z); private static MatrixTranslatefEXTDel MatrixTranslatefEXTPtr;
        
        // glMaxShaderCompilerThreadsKHR
        private delegate void MaxShaderCompilerThreadsKHRDel(uint  count); private static MaxShaderCompilerThreadsKHRDel MaxShaderCompilerThreadsKHRPtr;
        
        // glMaxShaderCompilerThreadsARB
        private delegate void MaxShaderCompilerThreadsARBDel(uint  count); private static MaxShaderCompilerThreadsARBDel MaxShaderCompilerThreadsARBPtr;
        
        // glMemoryBarrier
        private delegate void MemoryBarrierDel(uint /*MemoryBarrierMask*/  barriers); private static MemoryBarrierDel MemoryBarrierPtr;
        
        // glMemoryBarrierByRegion
        private delegate void MemoryBarrierByRegionDel(uint /*MemoryBarrierMask*/  barriers); private static MemoryBarrierByRegionDel MemoryBarrierByRegionPtr;
        
        // glMemoryBarrierEXT
        private delegate void MemoryBarrierEXTDel(uint /*MemoryBarrierMask*/  barriers); private static MemoryBarrierEXTDel MemoryBarrierEXTPtr;
        
        // glMemoryObjectParameterivEXT
        private delegate void MemoryObjectParameterivEXTDel(uint  memoryObject, uint /*MemoryObjectParameterName*/  pname, int[]  parameters); private static MemoryObjectParameterivEXTDel MemoryObjectParameterivEXTPtr;
        
        // glMinSampleShading
        private delegate void MinSampleShadingDel(float /*ColorF*/  value); private static MinSampleShadingDel MinSampleShadingPtr;
        
        // glMinSampleShadingARB
        private delegate void MinSampleShadingARBDel(float /*ColorF*/  value); private static MinSampleShadingARBDel MinSampleShadingARBPtr;
        
        // glMinSampleShadingOES
        private delegate void MinSampleShadingOESDel(float /*ColorF*/  value); private static MinSampleShadingOESDel MinSampleShadingOESPtr;
        
        // glMinmax
        private delegate void MinmaxDel(uint /*MinmaxTargetEXT*/  target, uint /*InternalFormat*/  internalformat, bool /*Boolean*/  sink); private static MinmaxDel MinmaxPtr;
        
        // glMinmaxEXT
        private delegate void MinmaxEXTDel(uint /*MinmaxTargetEXT*/  target, uint /*InternalFormat*/  internalformat, bool /*Boolean*/  sink); private static MinmaxEXTDel MinmaxEXTPtr;
        
        // glMultMatrixd
        private delegate void MultMatrixdDel(double[]  m); private static MultMatrixdDel MultMatrixdPtr;
        
        // glMultMatrixf
        private delegate void MultMatrixfDel(float[]  m); private static MultMatrixfDel MultMatrixfPtr;
        
        // glMultMatrixx
        private delegate void MultMatrixxDel(int[]  m); private static MultMatrixxDel MultMatrixxPtr;
        
        // glMultMatrixxOES
        private delegate void MultMatrixxOESDel(int[]  m); private static MultMatrixxOESDel MultMatrixxOESPtr;
        
        // glMultTransposeMatrixd
        private delegate void MultTransposeMatrixdDel(double[]  m); private static MultTransposeMatrixdDel MultTransposeMatrixdPtr;
        
        // glMultTransposeMatrixdARB
        private delegate void MultTransposeMatrixdARBDel(double[]  m); private static MultTransposeMatrixdARBDel MultTransposeMatrixdARBPtr;
        
        // glMultTransposeMatrixf
        private delegate void MultTransposeMatrixfDel(float[]  m); private static MultTransposeMatrixfDel MultTransposeMatrixfPtr;
        
        // glMultTransposeMatrixfARB
        private delegate void MultTransposeMatrixfARBDel(float[]  m); private static MultTransposeMatrixfARBDel MultTransposeMatrixfARBPtr;
        
        // glMultTransposeMatrixxOES
        private delegate void MultTransposeMatrixxOESDel(int[]  m); private static MultTransposeMatrixxOESDel MultTransposeMatrixxOESPtr;
        
        // glMultiDrawArrays
        private delegate void MultiDrawArraysDel(uint /*PrimitiveType*/  mode, int[]  first, uint[]  count, uint  drawcount); private static MultiDrawArraysDel MultiDrawArraysPtr;
        
        // glMultiDrawArraysEXT
        private delegate void MultiDrawArraysEXTDel(uint /*PrimitiveType*/  mode, int[]  first, uint[]  count, uint  primcount); private static MultiDrawArraysEXTDel MultiDrawArraysEXTPtr;
        
        // glMultiDrawArraysIndirect
        private delegate void MultiDrawArraysIndirectDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, uint  drawcount, uint  stride); private static MultiDrawArraysIndirectDel MultiDrawArraysIndirectPtr;
        
        // glMultiDrawArraysIndirectAMD
        private delegate void MultiDrawArraysIndirectAMDDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, uint  primcount, uint  stride); private static MultiDrawArraysIndirectAMDDel MultiDrawArraysIndirectAMDPtr;
        
        // glMultiDrawArraysIndirectBindlessCountNV
        private delegate void MultiDrawArraysIndirectBindlessCountNVDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, uint  drawCount, uint  maxDrawCount, uint  stride, int  vertexBufferCount); private static MultiDrawArraysIndirectBindlessCountNVDel MultiDrawArraysIndirectBindlessCountNVPtr;
        
        // glMultiDrawArraysIndirectBindlessNV
        private delegate void MultiDrawArraysIndirectBindlessNVDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, uint  drawCount, uint  stride, int  vertexBufferCount); private static MultiDrawArraysIndirectBindlessNVDel MultiDrawArraysIndirectBindlessNVPtr;
        
        // glMultiDrawArraysIndirectCount
        private delegate void MultiDrawArraysIndirectCountDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, IntPtr  drawcount, uint  maxdrawcount, uint  stride); private static MultiDrawArraysIndirectCountDel MultiDrawArraysIndirectCountPtr;
        
        // glMultiDrawArraysIndirectCountARB
        private delegate void MultiDrawArraysIndirectCountARBDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, IntPtr  drawcount, uint  maxdrawcount, uint  stride); private static MultiDrawArraysIndirectCountARBDel MultiDrawArraysIndirectCountARBPtr;
        
        // glMultiDrawArraysIndirectEXT
        private delegate void MultiDrawArraysIndirectEXTDel(uint /*PrimitiveType*/  mode, IntPtr  indirect, uint  drawcount, uint  stride); private static MultiDrawArraysIndirectEXTDel MultiDrawArraysIndirectEXTPtr;
        
        // glMultiDrawElementArrayAPPLE
        private delegate void MultiDrawElementArrayAPPLEDel(uint /*PrimitiveType*/  mode, int[]  first, uint[]  count, uint  primcount); private static MultiDrawElementArrayAPPLEDel MultiDrawElementArrayAPPLEPtr;
        
        // glMultiDrawElements
        private delegate void MultiDrawElementsDel(uint /*PrimitiveType*/  mode, uint[]  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  drawcount); private static MultiDrawElementsDel MultiDrawElementsPtr;
        
        // glMultiDrawElementsBaseVertex
        private delegate void MultiDrawElementsBaseVertexDel(uint /*PrimitiveType*/  mode, uint[]  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  drawcount, int[]  basevertex); private static MultiDrawElementsBaseVertexDel MultiDrawElementsBaseVertexPtr;
        
        // glMultiDrawElementsBaseVertexEXT
        private delegate void MultiDrawElementsBaseVertexEXTDel(uint /*PrimitiveType*/  mode, uint[]  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  primcount, int[]  basevertex); private static MultiDrawElementsBaseVertexEXTDel MultiDrawElementsBaseVertexEXTPtr;
        
        // glMultiDrawElementsEXT
        private delegate void MultiDrawElementsEXTDel(uint /*PrimitiveType*/  mode, uint[]  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  primcount); private static MultiDrawElementsEXTDel MultiDrawElementsEXTPtr;
        
        // glMultiDrawElementsIndirect
        private delegate void MultiDrawElementsIndirectDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, uint  drawcount, uint  stride); private static MultiDrawElementsIndirectDel MultiDrawElementsIndirectPtr;
        
        // glMultiDrawElementsIndirectAMD
        private delegate void MultiDrawElementsIndirectAMDDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, uint  primcount, uint  stride); private static MultiDrawElementsIndirectAMDDel MultiDrawElementsIndirectAMDPtr;
        
        // glMultiDrawElementsIndirectBindlessCountNV
        private delegate void MultiDrawElementsIndirectBindlessCountNVDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, uint  drawCount, uint  maxDrawCount, uint  stride, int  vertexBufferCount); private static MultiDrawElementsIndirectBindlessCountNVDel MultiDrawElementsIndirectBindlessCountNVPtr;
        
        // glMultiDrawElementsIndirectBindlessNV
        private delegate void MultiDrawElementsIndirectBindlessNVDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, uint  drawCount, uint  stride, int  vertexBufferCount); private static MultiDrawElementsIndirectBindlessNVDel MultiDrawElementsIndirectBindlessNVPtr;
        
        // glMultiDrawElementsIndirectCount
        private delegate void MultiDrawElementsIndirectCountDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, IntPtr  drawcount, uint  maxdrawcount, uint  stride); private static MultiDrawElementsIndirectCountDel MultiDrawElementsIndirectCountPtr;
        
        // glMultiDrawElementsIndirectCountARB
        private delegate void MultiDrawElementsIndirectCountARBDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, IntPtr  drawcount, uint  maxdrawcount, uint  stride); private static MultiDrawElementsIndirectCountARBDel MultiDrawElementsIndirectCountARBPtr;
        
        // glMultiDrawElementsIndirectEXT
        private delegate void MultiDrawElementsIndirectEXTDel(uint /*PrimitiveType*/  mode, uint /*DrawElementsType*/  type, IntPtr  indirect, uint  drawcount, uint  stride); private static MultiDrawElementsIndirectEXTDel MultiDrawElementsIndirectEXTPtr;
        
        // glMultiDrawMeshTasksIndirectNV
        private delegate void MultiDrawMeshTasksIndirectNVDel(IntPtr  indirect, uint  drawcount, uint  stride); private static MultiDrawMeshTasksIndirectNVDel MultiDrawMeshTasksIndirectNVPtr;
        
        // glMultiDrawMeshTasksIndirectCountNV
        private delegate void MultiDrawMeshTasksIndirectCountNVDel(IntPtr  indirect, IntPtr  drawcount, uint  maxdrawcount, uint  stride); private static MultiDrawMeshTasksIndirectCountNVDel MultiDrawMeshTasksIndirectCountNVPtr;
        
        // glMultiDrawRangeElementArrayAPPLE
        private delegate void MultiDrawRangeElementArrayAPPLEDel(uint /*PrimitiveType*/  mode, uint  start, uint  end, int[]  first, uint[]  count, uint  primcount); private static MultiDrawRangeElementArrayAPPLEDel MultiDrawRangeElementArrayAPPLEPtr;
        
        // glMultiModeDrawArraysIBM
        private delegate void MultiModeDrawArraysIBMDel(uint[] /*PrimitiveType*/  mode, int[]  first, uint[]  count, uint  primcount, int  modestride); private static MultiModeDrawArraysIBMDel MultiModeDrawArraysIBMPtr;
        
        // glMultiModeDrawElementsIBM
        private delegate void MultiModeDrawElementsIBMDel(uint[] /*PrimitiveType*/  mode, uint[]  count, uint /*DrawElementsType*/  type, IntPtr  indices, uint  primcount, int  modestride); private static MultiModeDrawElementsIBMDel MultiModeDrawElementsIBMPtr;
        
        // glMultiTexBufferEXT
        private delegate void MultiTexBufferEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint  internalformat, uint  buffer); private static MultiTexBufferEXTDel MultiTexBufferEXTPtr;
        
        // glMultiTexCoord1bOES
        private delegate void MultiTexCoord1bOESDel(uint /*TextureUnit*/  texture, sbyte  s); private static MultiTexCoord1bOESDel MultiTexCoord1bOESPtr;
        
        // glMultiTexCoord1bvOES
        private delegate void MultiTexCoord1bvOESDel(uint /*TextureUnit*/  texture, sbyte[]  coords); private static MultiTexCoord1bvOESDel MultiTexCoord1bvOESPtr;
        
        // glMultiTexCoord1d
        private delegate void MultiTexCoord1dDel(uint /*TextureUnit*/  target, double /*CoordD*/  s); private static MultiTexCoord1dDel MultiTexCoord1dPtr;
        
        // glMultiTexCoord1dARB
        private delegate void MultiTexCoord1dARBDel(uint /*TextureUnit*/  target, double /*CoordD*/  s); private static MultiTexCoord1dARBDel MultiTexCoord1dARBPtr;
        
        // glMultiTexCoord1dv
        private delegate void MultiTexCoord1dvDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord1dvDel MultiTexCoord1dvPtr;
        
        // glMultiTexCoord1dvARB
        private delegate void MultiTexCoord1dvARBDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord1dvARBDel MultiTexCoord1dvARBPtr;
        
        // glMultiTexCoord1f
        private delegate void MultiTexCoord1fDel(uint /*TextureUnit*/  target, float /*CoordF*/  s); private static MultiTexCoord1fDel MultiTexCoord1fPtr;
        
        // glMultiTexCoord1fARB
        private delegate void MultiTexCoord1fARBDel(uint /*TextureUnit*/  target, float /*CoordF*/  s); private static MultiTexCoord1fARBDel MultiTexCoord1fARBPtr;
        
        // glMultiTexCoord1fv
        private delegate void MultiTexCoord1fvDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord1fvDel MultiTexCoord1fvPtr;
        
        // glMultiTexCoord1fvARB
        private delegate void MultiTexCoord1fvARBDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord1fvARBDel MultiTexCoord1fvARBPtr;
        
        // glMultiTexCoord1hNV
        private delegate void MultiTexCoord1hNVDel(uint /*TextureUnit*/  target, ushort /*Half16NV*/  s); private static MultiTexCoord1hNVDel MultiTexCoord1hNVPtr;
        
        // glMultiTexCoord1hvNV
        private delegate void MultiTexCoord1hvNVDel(uint /*TextureUnit*/  target, ushort[] /*Half16NV*/  v); private static MultiTexCoord1hvNVDel MultiTexCoord1hvNVPtr;
        
        // glMultiTexCoord1i
        private delegate void MultiTexCoord1iDel(uint /*TextureUnit*/  target, int /*CoordI*/  s); private static MultiTexCoord1iDel MultiTexCoord1iPtr;
        
        // glMultiTexCoord1iARB
        private delegate void MultiTexCoord1iARBDel(uint /*TextureUnit*/  target, int /*CoordI*/  s); private static MultiTexCoord1iARBDel MultiTexCoord1iARBPtr;
        
        // glMultiTexCoord1iv
        private delegate void MultiTexCoord1ivDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord1ivDel MultiTexCoord1ivPtr;
        
        // glMultiTexCoord1ivARB
        private delegate void MultiTexCoord1ivARBDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord1ivARBDel MultiTexCoord1ivARBPtr;
        
        // glMultiTexCoord1s
        private delegate void MultiTexCoord1sDel(uint /*TextureUnit*/  target, short /*CoordS*/  s); private static MultiTexCoord1sDel MultiTexCoord1sPtr;
        
        // glMultiTexCoord1sARB
        private delegate void MultiTexCoord1sARBDel(uint /*TextureUnit*/  target, short /*CoordS*/  s); private static MultiTexCoord1sARBDel MultiTexCoord1sARBPtr;
        
        // glMultiTexCoord1sv
        private delegate void MultiTexCoord1svDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord1svDel MultiTexCoord1svPtr;
        
        // glMultiTexCoord1svARB
        private delegate void MultiTexCoord1svARBDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord1svARBDel MultiTexCoord1svARBPtr;
        
        // glMultiTexCoord1xOES
        private delegate void MultiTexCoord1xOESDel(uint /*TextureUnit*/  texture, int  s); private static MultiTexCoord1xOESDel MultiTexCoord1xOESPtr;
        
        // glMultiTexCoord1xvOES
        private delegate void MultiTexCoord1xvOESDel(uint /*TextureUnit*/  texture, int[]  coords); private static MultiTexCoord1xvOESDel MultiTexCoord1xvOESPtr;
        
        // glMultiTexCoord2bOES
        private delegate void MultiTexCoord2bOESDel(uint /*TextureUnit*/  texture, sbyte  s, sbyte  t); private static MultiTexCoord2bOESDel MultiTexCoord2bOESPtr;
        
        // glMultiTexCoord2bvOES
        private delegate void MultiTexCoord2bvOESDel(uint /*TextureUnit*/  texture, sbyte[]  coords); private static MultiTexCoord2bvOESDel MultiTexCoord2bvOESPtr;
        
        // glMultiTexCoord2d
        private delegate void MultiTexCoord2dDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t); private static MultiTexCoord2dDel MultiTexCoord2dPtr;
        
        // glMultiTexCoord2dARB
        private delegate void MultiTexCoord2dARBDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t); private static MultiTexCoord2dARBDel MultiTexCoord2dARBPtr;
        
        // glMultiTexCoord2dv
        private delegate void MultiTexCoord2dvDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord2dvDel MultiTexCoord2dvPtr;
        
        // glMultiTexCoord2dvARB
        private delegate void MultiTexCoord2dvARBDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord2dvARBDel MultiTexCoord2dvARBPtr;
        
        // glMultiTexCoord2f
        private delegate void MultiTexCoord2fDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t); private static MultiTexCoord2fDel MultiTexCoord2fPtr;
        
        // glMultiTexCoord2fARB
        private delegate void MultiTexCoord2fARBDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t); private static MultiTexCoord2fARBDel MultiTexCoord2fARBPtr;
        
        // glMultiTexCoord2fv
        private delegate void MultiTexCoord2fvDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord2fvDel MultiTexCoord2fvPtr;
        
        // glMultiTexCoord2fvARB
        private delegate void MultiTexCoord2fvARBDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord2fvARBDel MultiTexCoord2fvARBPtr;
        
        // glMultiTexCoord2hNV
        private delegate void MultiTexCoord2hNVDel(uint /*TextureUnit*/  target, ushort /*Half16NV*/  s, ushort /*Half16NV*/  t); private static MultiTexCoord2hNVDel MultiTexCoord2hNVPtr;
        
        // glMultiTexCoord2hvNV
        private delegate void MultiTexCoord2hvNVDel(uint /*TextureUnit*/  target, ushort[] /*Half16NV*/  v); private static MultiTexCoord2hvNVDel MultiTexCoord2hvNVPtr;
        
        // glMultiTexCoord2i
        private delegate void MultiTexCoord2iDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t); private static MultiTexCoord2iDel MultiTexCoord2iPtr;
        
        // glMultiTexCoord2iARB
        private delegate void MultiTexCoord2iARBDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t); private static MultiTexCoord2iARBDel MultiTexCoord2iARBPtr;
        
        // glMultiTexCoord2iv
        private delegate void MultiTexCoord2ivDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord2ivDel MultiTexCoord2ivPtr;
        
        // glMultiTexCoord2ivARB
        private delegate void MultiTexCoord2ivARBDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord2ivARBDel MultiTexCoord2ivARBPtr;
        
        // glMultiTexCoord2s
        private delegate void MultiTexCoord2sDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t); private static MultiTexCoord2sDel MultiTexCoord2sPtr;
        
        // glMultiTexCoord2sARB
        private delegate void MultiTexCoord2sARBDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t); private static MultiTexCoord2sARBDel MultiTexCoord2sARBPtr;
        
        // glMultiTexCoord2sv
        private delegate void MultiTexCoord2svDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord2svDel MultiTexCoord2svPtr;
        
        // glMultiTexCoord2svARB
        private delegate void MultiTexCoord2svARBDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord2svARBDel MultiTexCoord2svARBPtr;
        
        // glMultiTexCoord2xOES
        private delegate void MultiTexCoord2xOESDel(uint /*TextureUnit*/  texture, int  s, int  t); private static MultiTexCoord2xOESDel MultiTexCoord2xOESPtr;
        
        // glMultiTexCoord2xvOES
        private delegate void MultiTexCoord2xvOESDel(uint /*TextureUnit*/  texture, int[]  coords); private static MultiTexCoord2xvOESDel MultiTexCoord2xvOESPtr;
        
        // glMultiTexCoord3bOES
        private delegate void MultiTexCoord3bOESDel(uint /*TextureUnit*/  texture, sbyte  s, sbyte  t, sbyte  r); private static MultiTexCoord3bOESDel MultiTexCoord3bOESPtr;
        
        // glMultiTexCoord3bvOES
        private delegate void MultiTexCoord3bvOESDel(uint /*TextureUnit*/  texture, sbyte[]  coords); private static MultiTexCoord3bvOESDel MultiTexCoord3bvOESPtr;
        
        // glMultiTexCoord3d
        private delegate void MultiTexCoord3dDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r); private static MultiTexCoord3dDel MultiTexCoord3dPtr;
        
        // glMultiTexCoord3dARB
        private delegate void MultiTexCoord3dARBDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r); private static MultiTexCoord3dARBDel MultiTexCoord3dARBPtr;
        
        // glMultiTexCoord3dv
        private delegate void MultiTexCoord3dvDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord3dvDel MultiTexCoord3dvPtr;
        
        // glMultiTexCoord3dvARB
        private delegate void MultiTexCoord3dvARBDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord3dvARBDel MultiTexCoord3dvARBPtr;
        
        // glMultiTexCoord3f
        private delegate void MultiTexCoord3fDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r); private static MultiTexCoord3fDel MultiTexCoord3fPtr;
        
        // glMultiTexCoord3fARB
        private delegate void MultiTexCoord3fARBDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r); private static MultiTexCoord3fARBDel MultiTexCoord3fARBPtr;
        
        // glMultiTexCoord3fv
        private delegate void MultiTexCoord3fvDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord3fvDel MultiTexCoord3fvPtr;
        
        // glMultiTexCoord3fvARB
        private delegate void MultiTexCoord3fvARBDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord3fvARBDel MultiTexCoord3fvARBPtr;
        
        // glMultiTexCoord3hNV
        private delegate void MultiTexCoord3hNVDel(uint /*TextureUnit*/  target, ushort /*Half16NV*/  s, ushort /*Half16NV*/  t, ushort /*Half16NV*/  r); private static MultiTexCoord3hNVDel MultiTexCoord3hNVPtr;
        
        // glMultiTexCoord3hvNV
        private delegate void MultiTexCoord3hvNVDel(uint /*TextureUnit*/  target, ushort[] /*Half16NV*/  v); private static MultiTexCoord3hvNVDel MultiTexCoord3hvNVPtr;
        
        // glMultiTexCoord3i
        private delegate void MultiTexCoord3iDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r); private static MultiTexCoord3iDel MultiTexCoord3iPtr;
        
        // glMultiTexCoord3iARB
        private delegate void MultiTexCoord3iARBDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r); private static MultiTexCoord3iARBDel MultiTexCoord3iARBPtr;
        
        // glMultiTexCoord3iv
        private delegate void MultiTexCoord3ivDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord3ivDel MultiTexCoord3ivPtr;
        
        // glMultiTexCoord3ivARB
        private delegate void MultiTexCoord3ivARBDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord3ivARBDel MultiTexCoord3ivARBPtr;
        
        // glMultiTexCoord3s
        private delegate void MultiTexCoord3sDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r); private static MultiTexCoord3sDel MultiTexCoord3sPtr;
        
        // glMultiTexCoord3sARB
        private delegate void MultiTexCoord3sARBDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r); private static MultiTexCoord3sARBDel MultiTexCoord3sARBPtr;
        
        // glMultiTexCoord3sv
        private delegate void MultiTexCoord3svDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord3svDel MultiTexCoord3svPtr;
        
        // glMultiTexCoord3svARB
        private delegate void MultiTexCoord3svARBDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord3svARBDel MultiTexCoord3svARBPtr;
        
        // glMultiTexCoord3xOES
        private delegate void MultiTexCoord3xOESDel(uint /*TextureUnit*/  texture, int  s, int  t, int  r); private static MultiTexCoord3xOESDel MultiTexCoord3xOESPtr;
        
        // glMultiTexCoord3xvOES
        private delegate void MultiTexCoord3xvOESDel(uint /*TextureUnit*/  texture, int[]  coords); private static MultiTexCoord3xvOESDel MultiTexCoord3xvOESPtr;
        
        // glMultiTexCoord4bOES
        private delegate void MultiTexCoord4bOESDel(uint /*TextureUnit*/  texture, sbyte  s, sbyte  t, sbyte  r, sbyte  q); private static MultiTexCoord4bOESDel MultiTexCoord4bOESPtr;
        
        // glMultiTexCoord4bvOES
        private delegate void MultiTexCoord4bvOESDel(uint /*TextureUnit*/  texture, sbyte[]  coords); private static MultiTexCoord4bvOESDel MultiTexCoord4bvOESPtr;
        
        // glMultiTexCoord4d
        private delegate void MultiTexCoord4dDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r, double /*CoordD*/  q); private static MultiTexCoord4dDel MultiTexCoord4dPtr;
        
        // glMultiTexCoord4dARB
        private delegate void MultiTexCoord4dARBDel(uint /*TextureUnit*/  target, double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r, double /*CoordD*/  q); private static MultiTexCoord4dARBDel MultiTexCoord4dARBPtr;
        
        // glMultiTexCoord4dv
        private delegate void MultiTexCoord4dvDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord4dvDel MultiTexCoord4dvPtr;
        
        // glMultiTexCoord4dvARB
        private delegate void MultiTexCoord4dvARBDel(uint /*TextureUnit*/  target, double[] /*CoordD*/  v); private static MultiTexCoord4dvARBDel MultiTexCoord4dvARBPtr;
        
        // glMultiTexCoord4f
        private delegate void MultiTexCoord4fDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r, float /*CoordF*/  q); private static MultiTexCoord4fDel MultiTexCoord4fPtr;
        
        // glMultiTexCoord4fARB
        private delegate void MultiTexCoord4fARBDel(uint /*TextureUnit*/  target, float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r, float /*CoordF*/  q); private static MultiTexCoord4fARBDel MultiTexCoord4fARBPtr;
        
        // glMultiTexCoord4fv
        private delegate void MultiTexCoord4fvDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord4fvDel MultiTexCoord4fvPtr;
        
        // glMultiTexCoord4fvARB
        private delegate void MultiTexCoord4fvARBDel(uint /*TextureUnit*/  target, float[] /*CoordF*/  v); private static MultiTexCoord4fvARBDel MultiTexCoord4fvARBPtr;
        
        // glMultiTexCoord4hNV
        private delegate void MultiTexCoord4hNVDel(uint /*TextureUnit*/  target, ushort /*Half16NV*/  s, ushort /*Half16NV*/  t, ushort /*Half16NV*/  r, ushort /*Half16NV*/  q); private static MultiTexCoord4hNVDel MultiTexCoord4hNVPtr;
        
        // glMultiTexCoord4hvNV
        private delegate void MultiTexCoord4hvNVDel(uint /*TextureUnit*/  target, ushort[] /*Half16NV*/  v); private static MultiTexCoord4hvNVDel MultiTexCoord4hvNVPtr;
        
        // glMultiTexCoord4i
        private delegate void MultiTexCoord4iDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r, int /*CoordI*/  q); private static MultiTexCoord4iDel MultiTexCoord4iPtr;
        
        // glMultiTexCoord4iARB
        private delegate void MultiTexCoord4iARBDel(uint /*TextureUnit*/  target, int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r, int /*CoordI*/  q); private static MultiTexCoord4iARBDel MultiTexCoord4iARBPtr;
        
        // glMultiTexCoord4iv
        private delegate void MultiTexCoord4ivDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord4ivDel MultiTexCoord4ivPtr;
        
        // glMultiTexCoord4ivARB
        private delegate void MultiTexCoord4ivARBDel(uint /*TextureUnit*/  target, int[] /*CoordI*/  v); private static MultiTexCoord4ivARBDel MultiTexCoord4ivARBPtr;
        
        // glMultiTexCoord4s
        private delegate void MultiTexCoord4sDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r, short /*CoordS*/  q); private static MultiTexCoord4sDel MultiTexCoord4sPtr;
        
        // glMultiTexCoord4sARB
        private delegate void MultiTexCoord4sARBDel(uint /*TextureUnit*/  target, short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r, short /*CoordS*/  q); private static MultiTexCoord4sARBDel MultiTexCoord4sARBPtr;
        
        // glMultiTexCoord4sv
        private delegate void MultiTexCoord4svDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord4svDel MultiTexCoord4svPtr;
        
        // glMultiTexCoord4svARB
        private delegate void MultiTexCoord4svARBDel(uint /*TextureUnit*/  target, short[] /*CoordS*/  v); private static MultiTexCoord4svARBDel MultiTexCoord4svARBPtr;
        
        // glMultiTexCoord4x
        private delegate void MultiTexCoord4xDel(uint /*TextureUnit*/  texture, int  s, int  t, int  r, int  q); private static MultiTexCoord4xDel MultiTexCoord4xPtr;
        
        // glMultiTexCoord4xOES
        private delegate void MultiTexCoord4xOESDel(uint /*TextureUnit*/  texture, int  s, int  t, int  r, int  q); private static MultiTexCoord4xOESDel MultiTexCoord4xOESPtr;
        
        // glMultiTexCoord4xvOES
        private delegate void MultiTexCoord4xvOESDel(uint /*TextureUnit*/  texture, int[]  coords); private static MultiTexCoord4xvOESDel MultiTexCoord4xvOESPtr;
        
        // glMultiTexCoordP1ui
        private delegate void MultiTexCoordP1uiDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint  coords); private static MultiTexCoordP1uiDel MultiTexCoordP1uiPtr;
        
        // glMultiTexCoordP1uiv
        private delegate void MultiTexCoordP1uivDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint[]  coords); private static MultiTexCoordP1uivDel MultiTexCoordP1uivPtr;
        
        // glMultiTexCoordP2ui
        private delegate void MultiTexCoordP2uiDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint  coords); private static MultiTexCoordP2uiDel MultiTexCoordP2uiPtr;
        
        // glMultiTexCoordP2uiv
        private delegate void MultiTexCoordP2uivDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint[]  coords); private static MultiTexCoordP2uivDel MultiTexCoordP2uivPtr;
        
        // glMultiTexCoordP3ui
        private delegate void MultiTexCoordP3uiDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint  coords); private static MultiTexCoordP3uiDel MultiTexCoordP3uiPtr;
        
        // glMultiTexCoordP3uiv
        private delegate void MultiTexCoordP3uivDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint[]  coords); private static MultiTexCoordP3uivDel MultiTexCoordP3uivPtr;
        
        // glMultiTexCoordP4ui
        private delegate void MultiTexCoordP4uiDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint  coords); private static MultiTexCoordP4uiDel MultiTexCoordP4uiPtr;
        
        // glMultiTexCoordP4uiv
        private delegate void MultiTexCoordP4uivDel(uint /*TextureUnit*/  texture, uint /*TexCoordPointerType*/  type, uint[]  coords); private static MultiTexCoordP4uivDel MultiTexCoordP4uivPtr;
        
        // glMultiTexCoordPointerEXT
        private delegate void MultiTexCoordPointerEXTDel(uint /*TextureUnit*/  texunit, int  size, uint /*TexCoordPointerType*/  type, uint  stride, IntPtr  pointer); private static MultiTexCoordPointerEXTDel MultiTexCoordPointerEXTPtr;
        
        // glMultiTexEnvfEXT
        private delegate void MultiTexEnvfEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float /*CheckedFloat32*/  param); private static MultiTexEnvfEXTDel MultiTexEnvfEXTPtr;
        
        // glMultiTexEnvfvEXT
        private delegate void MultiTexEnvfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static MultiTexEnvfvEXTDel MultiTexEnvfvEXTPtr;
        
        // glMultiTexEnviEXT
        private delegate void MultiTexEnviEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int /*CheckedInt32*/  param); private static MultiTexEnviEXTDel MultiTexEnviEXTPtr;
        
        // glMultiTexEnvivEXT
        private delegate void MultiTexEnvivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static MultiTexEnvivEXTDel MultiTexEnvivEXTPtr;
        
        // glMultiTexGendEXT
        private delegate void MultiTexGendEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double  param); private static MultiTexGendEXTDel MultiTexGendEXTPtr;
        
        // glMultiTexGendvEXT
        private delegate void MultiTexGendvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double[]  parameters); private static MultiTexGendvEXTDel MultiTexGendvEXTPtr;
        
        // glMultiTexGenfEXT
        private delegate void MultiTexGenfEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float /*CheckedFloat32*/  param); private static MultiTexGenfEXTDel MultiTexGenfEXTPtr;
        
        // glMultiTexGenfvEXT
        private delegate void MultiTexGenfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static MultiTexGenfvEXTDel MultiTexGenfvEXTPtr;
        
        // glMultiTexGeniEXT
        private delegate void MultiTexGeniEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int /*CheckedInt32*/  param); private static MultiTexGeniEXTDel MultiTexGeniEXTPtr;
        
        // glMultiTexGenivEXT
        private delegate void MultiTexGenivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static MultiTexGenivEXTDel MultiTexGenivEXTPtr;
        
        // glMultiTexImage1DEXT
        private delegate void MultiTexImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexImage1DEXTDel MultiTexImage1DEXTPtr;
        
        // glMultiTexImage2DEXT
        private delegate void MultiTexImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexImage2DEXTDel MultiTexImage2DEXTPtr;
        
        // glMultiTexImage3DEXT
        private delegate void MultiTexImage3DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexImage3DEXTDel MultiTexImage3DEXTPtr;
        
        // glMultiTexParameterIivEXT
        private delegate void MultiTexParameterIivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static MultiTexParameterIivEXTDel MultiTexParameterIivEXTPtr;
        
        // glMultiTexParameterIuivEXT
        private delegate void MultiTexParameterIuivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, uint[]  parameters); private static MultiTexParameterIuivEXTDel MultiTexParameterIuivEXTPtr;
        
        // glMultiTexParameterfEXT
        private delegate void MultiTexParameterfEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float /*CheckedFloat32*/  param); private static MultiTexParameterfEXTDel MultiTexParameterfEXTPtr;
        
        // glMultiTexParameterfvEXT
        private delegate void MultiTexParameterfvEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float[] /*CheckedFloat32*/  parameters); private static MultiTexParameterfvEXTDel MultiTexParameterfvEXTPtr;
        
        // glMultiTexParameteriEXT
        private delegate void MultiTexParameteriEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int /*CheckedInt32*/  param); private static MultiTexParameteriEXTDel MultiTexParameteriEXTPtr;
        
        // glMultiTexParameterivEXT
        private delegate void MultiTexParameterivEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static MultiTexParameterivEXTDel MultiTexParameterivEXTPtr;
        
        // glMultiTexRenderbufferEXT
        private delegate void MultiTexRenderbufferEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, uint  renderbuffer); private static MultiTexRenderbufferEXTDel MultiTexRenderbufferEXTPtr;
        
        // glMultiTexSubImage1DEXT
        private delegate void MultiTexSubImage1DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexSubImage1DEXTDel MultiTexSubImage1DEXTPtr;
        
        // glMultiTexSubImage2DEXT
        private delegate void MultiTexSubImage2DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexSubImage2DEXTDel MultiTexSubImage2DEXTPtr;
        
        // glMultiTexSubImage3DEXT
        private delegate void MultiTexSubImage3DEXTDel(uint /*TextureUnit*/  texunit, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static MultiTexSubImage3DEXTDel MultiTexSubImage3DEXTPtr;
        
        // glMulticastBarrierNV
        private delegate void MulticastBarrierNVDel(); private static MulticastBarrierNVDel MulticastBarrierNVPtr;
        
        // glMulticastBlitFramebufferNV
        private delegate void MulticastBlitFramebufferNVDel(uint  srcGpu, uint  dstGpu, int  srcX0, int  srcY0, int  srcX1, int  srcY1, int  dstX0, int  dstY0, int  dstX1, int  dstY1, uint /*ClearBufferMask*/  mask, uint  filter); private static MulticastBlitFramebufferNVDel MulticastBlitFramebufferNVPtr;
        
        // glMulticastBufferSubDataNV
        private delegate void MulticastBufferSubDataNVDel(uint  gpuMask, uint  buffer, IntPtr  offset, IntPtr  size, IntPtr  data); private static MulticastBufferSubDataNVDel MulticastBufferSubDataNVPtr;
        
        // glMulticastCopyBufferSubDataNV
        private delegate void MulticastCopyBufferSubDataNVDel(uint  readGpu, uint  writeGpuMask, uint  readBuffer, uint  writeBuffer, IntPtr  readOffset, IntPtr  writeOffset, IntPtr  size); private static MulticastCopyBufferSubDataNVDel MulticastCopyBufferSubDataNVPtr;
        
        // glMulticastCopyImageSubDataNV
        private delegate void MulticastCopyImageSubDataNVDel(uint  srcGpu, uint  dstGpuMask, uint  srcName, uint  srcTarget, int  srcLevel, int  srcX, int  srcY, int  srcZ, uint  dstName, uint  dstTarget, int  dstLevel, int  dstX, int  dstY, int  dstZ, uint  srcWidth, uint  srcHeight, uint  srcDepth); private static MulticastCopyImageSubDataNVDel MulticastCopyImageSubDataNVPtr;
        
        // glMulticastFramebufferSampleLocationsfvNV
        private delegate void MulticastFramebufferSampleLocationsfvNVDel(uint  gpu, uint  framebuffer, uint  start, uint  count, float[]  v); private static MulticastFramebufferSampleLocationsfvNVDel MulticastFramebufferSampleLocationsfvNVPtr;
        
        // glMulticastGetQueryObjecti64vNV
        private delegate void MulticastGetQueryObjecti64vNVDel(uint  gpu, uint  id, uint  pname, long[]  parameters); private static MulticastGetQueryObjecti64vNVDel MulticastGetQueryObjecti64vNVPtr;
        
        // glMulticastGetQueryObjectivNV
        private delegate void MulticastGetQueryObjectivNVDel(uint  gpu, uint  id, uint  pname, int[]  parameters); private static MulticastGetQueryObjectivNVDel MulticastGetQueryObjectivNVPtr;
        
        // glMulticastGetQueryObjectui64vNV
        private delegate void MulticastGetQueryObjectui64vNVDel(uint  gpu, uint  id, uint  pname, ulong[]  parameters); private static MulticastGetQueryObjectui64vNVDel MulticastGetQueryObjectui64vNVPtr;
        
        // glMulticastGetQueryObjectuivNV
        private delegate void MulticastGetQueryObjectuivNVDel(uint  gpu, uint  id, uint  pname, uint[]  parameters); private static MulticastGetQueryObjectuivNVDel MulticastGetQueryObjectuivNVPtr;
        
        // glMulticastScissorArrayvNVX
        private delegate void MulticastScissorArrayvNVXDel(uint  gpu, uint  first, uint  count, int[]  v); private static MulticastScissorArrayvNVXDel MulticastScissorArrayvNVXPtr;
        
        // glMulticastViewportArrayvNVX
        private delegate void MulticastViewportArrayvNVXDel(uint  gpu, uint  first, uint  count, float[]  v); private static MulticastViewportArrayvNVXDel MulticastViewportArrayvNVXPtr;
        
        // glMulticastViewportPositionWScaleNVX
        private delegate void MulticastViewportPositionWScaleNVXDel(uint  gpu, uint  index, float  xcoeff, float  ycoeff); private static MulticastViewportPositionWScaleNVXDel MulticastViewportPositionWScaleNVXPtr;
        
        // glMulticastWaitSyncNV
        private delegate void MulticastWaitSyncNVDel(uint  signalGpu, uint  waitGpuMask); private static MulticastWaitSyncNVDel MulticastWaitSyncNVPtr;
        
        // glNamedBufferAttachMemoryNV
        private delegate void NamedBufferAttachMemoryNVDel(uint  buffer, uint  memory, ulong  offset); private static NamedBufferAttachMemoryNVDel NamedBufferAttachMemoryNVPtr;
        
        // glNamedBufferData
        private delegate void NamedBufferDataDel(uint  buffer, IntPtr /*BufferSize*/  size, IntPtr  data, uint /*VertexBufferObjectUsage*/  usage); private static NamedBufferDataDel NamedBufferDataPtr;
        
        // glNamedBufferDataEXT
        private delegate void NamedBufferDataEXTDel(uint  buffer, IntPtr  size, IntPtr  data, uint /*VertexBufferObjectUsage*/  usage); private static NamedBufferDataEXTDel NamedBufferDataEXTPtr;
        
        // glNamedBufferPageCommitmentARB
        private delegate void NamedBufferPageCommitmentARBDel(uint  buffer, IntPtr  offset, IntPtr  size, bool /*Boolean*/  commit); private static NamedBufferPageCommitmentARBDel NamedBufferPageCommitmentARBPtr;
        
        // glNamedBufferPageCommitmentEXT
        private delegate void NamedBufferPageCommitmentEXTDel(uint  buffer, IntPtr  offset, IntPtr  size, bool /*Boolean*/  commit); private static NamedBufferPageCommitmentEXTDel NamedBufferPageCommitmentEXTPtr;
        
        // glNamedBufferStorage
        private delegate void NamedBufferStorageDel(uint  buffer, IntPtr /*BufferSize*/  size, IntPtr  data, uint /*BufferStorageMask*/  flags); private static NamedBufferStorageDel NamedBufferStoragePtr;
        
        // glNamedBufferStorageExternalEXT
        private delegate void NamedBufferStorageExternalEXTDel(uint  buffer, IntPtr  offset, IntPtr  size, IntPtr /*GLeglClientBufferEXT*/  clientBuffer, uint /*BufferStorageMask*/  flags); private static NamedBufferStorageExternalEXTDel NamedBufferStorageExternalEXTPtr;
        
        // glNamedBufferStorageEXT
        private delegate void NamedBufferStorageEXTDel(uint  buffer, IntPtr /*BufferSize*/  size, IntPtr  data, uint /*BufferStorageMask*/  flags); private static NamedBufferStorageEXTDel NamedBufferStorageEXTPtr;
        
        // glNamedBufferStorageMemEXT
        private delegate void NamedBufferStorageMemEXTDel(uint  buffer, IntPtr /*BufferSize*/  size, uint  memory, ulong  offset); private static NamedBufferStorageMemEXTDel NamedBufferStorageMemEXTPtr;
        
        // glNamedBufferSubData
        private delegate void NamedBufferSubDataDel(uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  size, IntPtr  data); private static NamedBufferSubDataDel NamedBufferSubDataPtr;
        
        // glNamedBufferSubDataEXT
        private delegate void NamedBufferSubDataEXTDel(uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  size, IntPtr  data); private static NamedBufferSubDataEXTDel NamedBufferSubDataEXTPtr;
        
        // glNamedCopyBufferSubDataEXT
        private delegate void NamedCopyBufferSubDataEXTDel(uint  readBuffer, uint  writeBuffer, IntPtr  readOffset, IntPtr  writeOffset, IntPtr  size); private static NamedCopyBufferSubDataEXTDel NamedCopyBufferSubDataEXTPtr;
        
        // glNamedFramebufferDrawBuffer
        private delegate void NamedFramebufferDrawBufferDel(uint  framebuffer, uint /*ColorBuffer*/  buf); private static NamedFramebufferDrawBufferDel NamedFramebufferDrawBufferPtr;
        
        // glNamedFramebufferDrawBuffers
        private delegate void NamedFramebufferDrawBuffersDel(uint  framebuffer, uint  n, uint[] /*ColorBuffer*/  bufs); private static NamedFramebufferDrawBuffersDel NamedFramebufferDrawBuffersPtr;
        
        // glNamedFramebufferParameteri
        private delegate void NamedFramebufferParameteriDel(uint  framebuffer, uint /*FramebufferParameterName*/  pname, int  param); private static NamedFramebufferParameteriDel NamedFramebufferParameteriPtr;
        
        // glNamedFramebufferParameteriEXT
        private delegate void NamedFramebufferParameteriEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferParameterName*/  pname, int  param); private static NamedFramebufferParameteriEXTDel NamedFramebufferParameteriEXTPtr;
        
        // glNamedFramebufferReadBuffer
        private delegate void NamedFramebufferReadBufferDel(uint  framebuffer, uint /*ColorBuffer*/  src); private static NamedFramebufferReadBufferDel NamedFramebufferReadBufferPtr;
        
        // glNamedFramebufferRenderbuffer
        private delegate void NamedFramebufferRenderbufferDel(uint  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*RenderbufferTarget*/  renderbuffertarget, uint  renderbuffer); private static NamedFramebufferRenderbufferDel NamedFramebufferRenderbufferPtr;
        
        // glNamedFramebufferRenderbufferEXT
        private delegate void NamedFramebufferRenderbufferEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*RenderbufferTarget*/  renderbuffertarget, uint /*Renderbuffer*/  renderbuffer); private static NamedFramebufferRenderbufferEXTDel NamedFramebufferRenderbufferEXTPtr;
        
        // glNamedFramebufferSampleLocationsfvARB
        private delegate void NamedFramebufferSampleLocationsfvARBDel(uint  framebuffer, uint  start, uint  count, float[]  v); private static NamedFramebufferSampleLocationsfvARBDel NamedFramebufferSampleLocationsfvARBPtr;
        
        // glNamedFramebufferSampleLocationsfvNV
        private delegate void NamedFramebufferSampleLocationsfvNVDel(uint  framebuffer, uint  start, uint  count, float[]  v); private static NamedFramebufferSampleLocationsfvNVDel NamedFramebufferSampleLocationsfvNVPtr;
        
        // glNamedFramebufferTexture
        private delegate void NamedFramebufferTextureDel(uint  framebuffer, uint /*FramebufferAttachment*/  attachment, uint  texture, int  level); private static NamedFramebufferTextureDel NamedFramebufferTexturePtr;
        
        // glNamedFramebufferSamplePositionsfvAMD
        private delegate void NamedFramebufferSamplePositionsfvAMDDel(uint  framebuffer, uint  numsamples, uint  pixelindex, float[]  values); private static NamedFramebufferSamplePositionsfvAMDDel NamedFramebufferSamplePositionsfvAMDPtr;
        
        // glNamedFramebufferTexture1DEXT
        private delegate void NamedFramebufferTexture1DEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static NamedFramebufferTexture1DEXTDel NamedFramebufferTexture1DEXTPtr;
        
        // glNamedFramebufferTexture2DEXT
        private delegate void NamedFramebufferTexture2DEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static NamedFramebufferTexture2DEXTDel NamedFramebufferTexture2DEXTPtr;
        
        // glNamedFramebufferTexture3DEXT
        private delegate void NamedFramebufferTexture3DEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*TextureTarget*/  textarget, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  zoffset); private static NamedFramebufferTexture3DEXTDel NamedFramebufferTexture3DEXTPtr;
        
        // glNamedFramebufferTextureEXT
        private delegate void NamedFramebufferTextureEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level); private static NamedFramebufferTextureEXTDel NamedFramebufferTextureEXTPtr;
        
        // glNamedFramebufferTextureFaceEXT
        private delegate void NamedFramebufferTextureFaceEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, uint /*TextureTarget*/  face); private static NamedFramebufferTextureFaceEXTDel NamedFramebufferTextureFaceEXTPtr;
        
        // glNamedFramebufferTextureLayer
        private delegate void NamedFramebufferTextureLayerDel(uint  framebuffer, uint /*FramebufferAttachment*/  attachment, uint  texture, int  level, int  layer); private static NamedFramebufferTextureLayerDel NamedFramebufferTextureLayerPtr;
        
        // glNamedFramebufferTextureLayerEXT
        private delegate void NamedFramebufferTextureLayerEXTDel(uint /*Framebuffer*/  framebuffer, uint /*FramebufferAttachment*/  attachment, uint /*Texture*/  texture, int /*CheckedInt32*/  level, int /*CheckedInt32*/  layer); private static NamedFramebufferTextureLayerEXTDel NamedFramebufferTextureLayerEXTPtr;
        
        // glNamedProgramLocalParameter4dEXT
        private delegate void NamedProgramLocalParameter4dEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, double  x, double  y, double  z, double  w); private static NamedProgramLocalParameter4dEXTDel NamedProgramLocalParameter4dEXTPtr;
        
        // glNamedProgramLocalParameter4dvEXT
        private delegate void NamedProgramLocalParameter4dvEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static NamedProgramLocalParameter4dvEXTDel NamedProgramLocalParameter4dvEXTPtr;
        
        // glNamedProgramLocalParameter4fEXT
        private delegate void NamedProgramLocalParameter4fEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, float  x, float  y, float  z, float  w); private static NamedProgramLocalParameter4fEXTDel NamedProgramLocalParameter4fEXTPtr;
        
        // glNamedProgramLocalParameter4fvEXT
        private delegate void NamedProgramLocalParameter4fvEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static NamedProgramLocalParameter4fvEXTDel NamedProgramLocalParameter4fvEXTPtr;
        
        // glNamedProgramLocalParameterI4iEXT
        private delegate void NamedProgramLocalParameterI4iEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, int  x, int  y, int  z, int  w); private static NamedProgramLocalParameterI4iEXTDel NamedProgramLocalParameterI4iEXTPtr;
        
        // glNamedProgramLocalParameterI4ivEXT
        private delegate void NamedProgramLocalParameterI4ivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static NamedProgramLocalParameterI4ivEXTDel NamedProgramLocalParameterI4ivEXTPtr;
        
        // glNamedProgramLocalParameterI4uiEXT
        private delegate void NamedProgramLocalParameterI4uiEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint  x, uint  y, uint  z, uint  w); private static NamedProgramLocalParameterI4uiEXTDel NamedProgramLocalParameterI4uiEXTPtr;
        
        // glNamedProgramLocalParameterI4uivEXT
        private delegate void NamedProgramLocalParameterI4uivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static NamedProgramLocalParameterI4uivEXTDel NamedProgramLocalParameterI4uivEXTPtr;
        
        // glNamedProgramLocalParameters4fvEXT
        private delegate void NamedProgramLocalParameters4fvEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint  count, float[]  parameters); private static NamedProgramLocalParameters4fvEXTDel NamedProgramLocalParameters4fvEXTPtr;
        
        // glNamedProgramLocalParametersI4ivEXT
        private delegate void NamedProgramLocalParametersI4ivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint  count, int[]  parameters); private static NamedProgramLocalParametersI4ivEXTDel NamedProgramLocalParametersI4ivEXTPtr;
        
        // glNamedProgramLocalParametersI4uivEXT
        private delegate void NamedProgramLocalParametersI4uivEXTDel(uint  program, uint /*ProgramTarget*/  target, uint  index, uint  count, uint[]  parameters); private static NamedProgramLocalParametersI4uivEXTDel NamedProgramLocalParametersI4uivEXTPtr;
        
        // glNamedProgramStringEXT
        private delegate void NamedProgramStringEXTDel(uint  program, uint /*ProgramTarget*/  target, uint /*ProgramFormat*/  format, uint  len, IntPtr  str); private static NamedProgramStringEXTDel NamedProgramStringEXTPtr;
        
        // glNamedRenderbufferStorage
        private delegate void NamedRenderbufferStorageDel(uint  renderbuffer, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageDel NamedRenderbufferStoragePtr;
        
        // glNamedRenderbufferStorageEXT
        private delegate void NamedRenderbufferStorageEXTDel(uint /*Renderbuffer*/  renderbuffer, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageEXTDel NamedRenderbufferStorageEXTPtr;
        
        // glNamedRenderbufferStorageMultisample
        private delegate void NamedRenderbufferStorageMultisampleDel(uint  renderbuffer, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageMultisampleDel NamedRenderbufferStorageMultisamplePtr;
        
        // glNamedRenderbufferStorageMultisampleAdvancedAMD
        private delegate void NamedRenderbufferStorageMultisampleAdvancedAMDDel(uint /*Renderbuffer*/  renderbuffer, uint  samples, uint  storageSamples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageMultisampleAdvancedAMDDel NamedRenderbufferStorageMultisampleAdvancedAMDPtr;
        
        // glNamedRenderbufferStorageMultisampleCoverageEXT
        private delegate void NamedRenderbufferStorageMultisampleCoverageEXTDel(uint /*Renderbuffer*/  renderbuffer, uint  coverageSamples, uint  colorSamples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageMultisampleCoverageEXTDel NamedRenderbufferStorageMultisampleCoverageEXTPtr;
        
        // glNamedRenderbufferStorageMultisampleEXT
        private delegate void NamedRenderbufferStorageMultisampleEXTDel(uint /*Renderbuffer*/  renderbuffer, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static NamedRenderbufferStorageMultisampleEXTDel NamedRenderbufferStorageMultisampleEXTPtr;
        
        // glNamedStringARB
        private delegate void NamedStringARBDel(uint  type, int  namelen, string  name, int  stringlen, string  str); private static NamedStringARBDel NamedStringARBPtr;
        
        // glNewList
        private delegate void NewListDel(uint /*List*/  list, uint /*ListMode*/  mode); private static NewListDel NewListPtr;
        
        // glNewObjectBufferATI
        private delegate uint NewObjectBufferATIDel(uint  size, IntPtr  pointer, uint /*ArrayObjectUsageATI*/  usage); private static NewObjectBufferATIDel NewObjectBufferATIPtr;
        
        // glNormal3b
        private delegate void Normal3bDel(sbyte  nx, sbyte  ny, sbyte  nz); private static Normal3bDel Normal3bPtr;
        
        // glNormal3bv
        private delegate void Normal3bvDel(sbyte[]  v); private static Normal3bvDel Normal3bvPtr;
        
        // glNormal3d
        private delegate void Normal3dDel(double /*CoordD*/  nx, double /*CoordD*/  ny, double /*CoordD*/  nz); private static Normal3dDel Normal3dPtr;
        
        // glNormal3dv
        private delegate void Normal3dvDel(double[] /*CoordD*/  v); private static Normal3dvDel Normal3dvPtr;
        
        // glNormal3f
        private delegate void Normal3fDel(float /*CoordF*/  nx, float /*CoordF*/  ny, float /*CoordF*/  nz); private static Normal3fDel Normal3fPtr;
        
        // glNormal3fVertex3fSUN
        private delegate void Normal3fVertex3fSUNDel(float  nx, float  ny, float  nz, float  x, float  y, float  z); private static Normal3fVertex3fSUNDel Normal3fVertex3fSUNPtr;
        
        // glNormal3fVertex3fvSUN
        private delegate void Normal3fVertex3fvSUNDel(float[]  n, float[]  v); private static Normal3fVertex3fvSUNDel Normal3fVertex3fvSUNPtr;
        
        // glNormal3fv
        private delegate void Normal3fvDel(float[] /*CoordF*/  v); private static Normal3fvDel Normal3fvPtr;
        
        // glNormal3hNV
        private delegate void Normal3hNVDel(ushort /*Half16NV*/  nx, ushort /*Half16NV*/  ny, ushort /*Half16NV*/  nz); private static Normal3hNVDel Normal3hNVPtr;
        
        // glNormal3hvNV
        private delegate void Normal3hvNVDel(ushort[] /*Half16NV*/  v); private static Normal3hvNVDel Normal3hvNVPtr;
        
        // glNormal3i
        private delegate void Normal3iDel(int  nx, int  ny, int  nz); private static Normal3iDel Normal3iPtr;
        
        // glNormal3iv
        private delegate void Normal3ivDel(int[]  v); private static Normal3ivDel Normal3ivPtr;
        
        // glNormal3s
        private delegate void Normal3sDel(short  nx, short  ny, short  nz); private static Normal3sDel Normal3sPtr;
        
        // glNormal3sv
        private delegate void Normal3svDel(short[]  v); private static Normal3svDel Normal3svPtr;
        
        // glNormal3x
        private delegate void Normal3xDel(int  nx, int  ny, int  nz); private static Normal3xDel Normal3xPtr;
        
        // glNormal3xOES
        private delegate void Normal3xOESDel(int  nx, int  ny, int  nz); private static Normal3xOESDel Normal3xOESPtr;
        
        // glNormal3xvOES
        private delegate void Normal3xvOESDel(int[]  coords); private static Normal3xvOESDel Normal3xvOESPtr;
        
        // glNormalFormatNV
        private delegate void NormalFormatNVDel(uint  type, uint  stride); private static NormalFormatNVDel NormalFormatNVPtr;
        
        // glNormalP3ui
        private delegate void NormalP3uiDel(uint /*NormalPointerType*/  type, uint  coords); private static NormalP3uiDel NormalP3uiPtr;
        
        // glNormalP3uiv
        private delegate void NormalP3uivDel(uint /*NormalPointerType*/  type, uint[]  coords); private static NormalP3uivDel NormalP3uivPtr;
        
        // glNormalPointer
        private delegate void NormalPointerDel(uint /*NormalPointerType*/  type, uint  stride, IntPtr  pointer); private static NormalPointerDel NormalPointerPtr;
        
        // glNormalPointerEXT
        private delegate void NormalPointerEXTDel(uint /*NormalPointerType*/  type, uint  stride, uint  count, IntPtr  pointer); private static NormalPointerEXTDel NormalPointerEXTPtr;
        
        // glNormalPointerListIBM
        private delegate void NormalPointerListIBMDel(uint /*NormalPointerType*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static NormalPointerListIBMDel NormalPointerListIBMPtr;
        
        // glNormalPointervINTEL
        private delegate void NormalPointervINTELDel(uint /*NormalPointerType*/  type, IntPtr  pointer); private static NormalPointervINTELDel NormalPointervINTELPtr;
        
        // glNormalStream3bATI
        private delegate void NormalStream3bATIDel(uint /*VertexStreamATI*/  stream, sbyte  nx, sbyte  ny, sbyte  nz); private static NormalStream3bATIDel NormalStream3bATIPtr;
        
        // glNormalStream3bvATI
        private delegate void NormalStream3bvATIDel(uint /*VertexStreamATI*/  stream, sbyte[]  coords); private static NormalStream3bvATIDel NormalStream3bvATIPtr;
        
        // glNormalStream3dATI
        private delegate void NormalStream3dATIDel(uint /*VertexStreamATI*/  stream, double  nx, double  ny, double  nz); private static NormalStream3dATIDel NormalStream3dATIPtr;
        
        // glNormalStream3dvATI
        private delegate void NormalStream3dvATIDel(uint /*VertexStreamATI*/  stream, double[]  coords); private static NormalStream3dvATIDel NormalStream3dvATIPtr;
        
        // glNormalStream3fATI
        private delegate void NormalStream3fATIDel(uint /*VertexStreamATI*/  stream, float  nx, float  ny, float  nz); private static NormalStream3fATIDel NormalStream3fATIPtr;
        
        // glNormalStream3fvATI
        private delegate void NormalStream3fvATIDel(uint /*VertexStreamATI*/  stream, float[]  coords); private static NormalStream3fvATIDel NormalStream3fvATIPtr;
        
        // glNormalStream3iATI
        private delegate void NormalStream3iATIDel(uint /*VertexStreamATI*/  stream, int  nx, int  ny, int  nz); private static NormalStream3iATIDel NormalStream3iATIPtr;
        
        // glNormalStream3ivATI
        private delegate void NormalStream3ivATIDel(uint /*VertexStreamATI*/  stream, int[]  coords); private static NormalStream3ivATIDel NormalStream3ivATIPtr;
        
        // glNormalStream3sATI
        private delegate void NormalStream3sATIDel(uint /*VertexStreamATI*/  stream, short  nx, short  ny, short  nz); private static NormalStream3sATIDel NormalStream3sATIPtr;
        
        // glNormalStream3svATI
        private delegate void NormalStream3svATIDel(uint /*VertexStreamATI*/  stream, short[]  coords); private static NormalStream3svATIDel NormalStream3svATIPtr;
        
        // glObjectLabel
        private delegate void ObjectLabelDel(uint /*ObjectIdentifier*/  identifier, uint  name, uint  length, string  label); private static ObjectLabelDel ObjectLabelPtr;
        
        // glObjectLabelKHR
        private delegate void ObjectLabelKHRDel(uint /*ObjectIdentifier*/  identifier, uint  name, uint  length, string  label); private static ObjectLabelKHRDel ObjectLabelKHRPtr;
        
        // glObjectPtrLabel
        private delegate void ObjectPtrLabelDel(IntPtr  ptr, uint  length, string  label); private static ObjectPtrLabelDel ObjectPtrLabelPtr;
        
        // glObjectPtrLabelKHR
        private delegate void ObjectPtrLabelKHRDel(IntPtr  ptr, uint  length, string  label); private static ObjectPtrLabelKHRDel ObjectPtrLabelKHRPtr;
        
        // glObjectPurgeableAPPLE
        private delegate uint ObjectPurgeableAPPLEDel(uint  objectType, uint  name, uint  option); private static ObjectPurgeableAPPLEDel ObjectPurgeableAPPLEPtr;
        
        // glObjectUnpurgeableAPPLE
        private delegate uint ObjectUnpurgeableAPPLEDel(uint  objectType, uint  name, uint  option); private static ObjectUnpurgeableAPPLEDel ObjectUnpurgeableAPPLEPtr;
        
        // glOrtho
        private delegate void OrthoDel(double  left, double  right, double  bottom, double  top, double  zNear, double  zFar); private static OrthoDel OrthoPtr;
        
        // glOrthof
        private delegate void OrthofDel(float  l, float  r, float  b, float  t, float  n, float  f); private static OrthofDel OrthofPtr;
        
        // glOrthofOES
        private delegate void OrthofOESDel(float  l, float  r, float  b, float  t, float  n, float  f); private static OrthofOESDel OrthofOESPtr;
        
        // glOrthox
        private delegate void OrthoxDel(int  l, int  r, int  b, int  t, int  n, int  f); private static OrthoxDel OrthoxPtr;
        
        // glOrthoxOES
        private delegate void OrthoxOESDel(int  l, int  r, int  b, int  t, int  n, int  f); private static OrthoxOESDel OrthoxOESPtr;
        
        // glPNTrianglesfATI
        private delegate void PNTrianglesfATIDel(uint /*PNTrianglesPNameATI*/  pname, float  param); private static PNTrianglesfATIDel PNTrianglesfATIPtr;
        
        // glPNTrianglesiATI
        private delegate void PNTrianglesiATIDel(uint /*PNTrianglesPNameATI*/  pname, int  param); private static PNTrianglesiATIDel PNTrianglesiATIPtr;
        
        // glPassTexCoordATI
        private delegate void PassTexCoordATIDel(uint  dst, uint  coord, uint /*SwizzleOpATI*/  swizzle); private static PassTexCoordATIDel PassTexCoordATIPtr;
        
        // glPassThrough
        private delegate void PassThroughDel(float /*FeedbackElement*/  token); private static PassThroughDel PassThroughPtr;
        
        // glPassThroughxOES
        private delegate void PassThroughxOESDel(int  token); private static PassThroughxOESDel PassThroughxOESPtr;
        
        // glPatchParameterfv
        private delegate void PatchParameterfvDel(uint /*PatchParameterName*/  pname, float[]  values); private static PatchParameterfvDel PatchParameterfvPtr;
        
        // glPatchParameteri
        private delegate void PatchParameteriDel(uint /*PatchParameterName*/  pname, int  value); private static PatchParameteriDel PatchParameteriPtr;
        
        // glPatchParameteriEXT
        private delegate void PatchParameteriEXTDel(uint /*PatchParameterName*/  pname, int  value); private static PatchParameteriEXTDel PatchParameteriEXTPtr;
        
        // glPatchParameteriOES
        private delegate void PatchParameteriOESDel(uint /*PatchParameterName*/  pname, int  value); private static PatchParameteriOESDel PatchParameteriOESPtr;
        
        // glPathColorGenNV
        private delegate void PathColorGenNVDel(uint /*PathColor*/  color, uint /*PathGenMode*/  genMode, uint /*PathColorFormat*/  colorFormat, float[]  coeffs); private static PathColorGenNVDel PathColorGenNVPtr;
        
        // glPathCommandsNV
        private delegate void PathCommandsNVDel(uint /*Path*/  path, uint  numCommands, byte[] /*PathCommand*/  commands, uint  numCoords, uint /*PathCoordType*/  coordType, IntPtr  coords); private static PathCommandsNVDel PathCommandsNVPtr;
        
        // glPathCoordsNV
        private delegate void PathCoordsNVDel(uint /*Path*/  path, uint  numCoords, uint /*PathCoordType*/  coordType, IntPtr  coords); private static PathCoordsNVDel PathCoordsNVPtr;
        
        // glPathCoverDepthFuncNV
        private delegate void PathCoverDepthFuncNVDel(uint /*DepthFunction*/  func); private static PathCoverDepthFuncNVDel PathCoverDepthFuncNVPtr;
        
        // glPathDashArrayNV
        private delegate void PathDashArrayNVDel(uint /*Path*/  path, uint  dashCount, float[]  dashArray); private static PathDashArrayNVDel PathDashArrayNVPtr;
        
        // glPathFogGenNV
        private delegate void PathFogGenNVDel(uint /*PathGenMode*/  genMode); private static PathFogGenNVDel PathFogGenNVPtr;
        
        // glPathGlyphIndexArrayNV
        private delegate uint PathGlyphIndexArrayNVDel(uint  firstPathName, uint  fontTarget, IntPtr  fontName, uint /*PathFontStyle*/  fontStyle, uint  firstGlyphIndex, uint  numGlyphs, uint  pathParameterTemplate, float  emScale); private static PathGlyphIndexArrayNVDel PathGlyphIndexArrayNVPtr;
        
        // glPathGlyphIndexRangeNV
        private delegate uint PathGlyphIndexRangeNVDel(uint  fontTarget, IntPtr  fontName, uint /*PathFontStyle*/  fontStyle, uint  pathParameterTemplate, float  emScale, uint  baseAndCount); private static PathGlyphIndexRangeNVDel PathGlyphIndexRangeNVPtr;
        
        // glPathGlyphRangeNV
        private delegate void PathGlyphRangeNVDel(uint /*Path*/  firstPathName, uint /*PathFontTarget*/  fontTarget, IntPtr  fontName, uint /*PathFontStyle*/  fontStyle, uint  firstGlyph, uint  numGlyphs, uint /*PathHandleMissingGlyphs*/  handleMissingGlyphs, uint /*Path*/  pathParameterTemplate, float  emScale); private static PathGlyphRangeNVDel PathGlyphRangeNVPtr;
        
        // glPathGlyphsNV
        private delegate void PathGlyphsNVDel(uint /*Path*/  firstPathName, uint /*PathFontTarget*/  fontTarget, IntPtr  fontName, uint /*PathFontStyle*/  fontStyle, uint  numGlyphs, uint /*PathElementType*/  type, IntPtr  charcodes, uint /*PathHandleMissingGlyphs*/  handleMissingGlyphs, uint /*Path*/  pathParameterTemplate, float  emScale); private static PathGlyphsNVDel PathGlyphsNVPtr;
        
        // glPathMemoryGlyphIndexArrayNV
        private delegate uint PathMemoryGlyphIndexArrayNVDel(uint  firstPathName, uint  fontTarget, IntPtr  fontSize, IntPtr  fontData, uint  faceIndex, uint  firstGlyphIndex, uint  numGlyphs, uint  pathParameterTemplate, float  emScale); private static PathMemoryGlyphIndexArrayNVDel PathMemoryGlyphIndexArrayNVPtr;
        
        // glPathParameterfNV
        private delegate void PathParameterfNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, float  value); private static PathParameterfNVDel PathParameterfNVPtr;
        
        // glPathParameterfvNV
        private delegate void PathParameterfvNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, float[]  value); private static PathParameterfvNVDel PathParameterfvNVPtr;
        
        // glPathParameteriNV
        private delegate void PathParameteriNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, int  value); private static PathParameteriNVDel PathParameteriNVPtr;
        
        // glPathParameterivNV
        private delegate void PathParameterivNVDel(uint /*Path*/  path, uint /*PathParameter*/  pname, int[]  value); private static PathParameterivNVDel PathParameterivNVPtr;
        
        // glPathStencilDepthOffsetNV
        private delegate void PathStencilDepthOffsetNVDel(float  factor, float  units); private static PathStencilDepthOffsetNVDel PathStencilDepthOffsetNVPtr;
        
        // glPathStencilFuncNV
        private delegate void PathStencilFuncNVDel(uint /*StencilFunction*/  func, int /*ClampedStencilValue*/  refVal, uint /*MaskedStencilValue*/  mask); private static PathStencilFuncNVDel PathStencilFuncNVPtr;
        
        // glPathStringNV
        private delegate void PathStringNVDel(uint /*Path*/  path, uint /*PathStringFormat*/  format, uint  length, IntPtr  pathString); private static PathStringNVDel PathStringNVPtr;
        
        // glPathSubCommandsNV
        private delegate void PathSubCommandsNVDel(uint /*Path*/  path, uint  commandStart, uint  commandsToDelete, uint  numCommands, byte[] /*PathCommand*/  commands, uint  numCoords, uint /*PathCoordType*/  coordType, IntPtr  coords); private static PathSubCommandsNVDel PathSubCommandsNVPtr;
        
        // glPathSubCoordsNV
        private delegate void PathSubCoordsNVDel(uint /*Path*/  path, uint  coordStart, uint  numCoords, uint /*PathCoordType*/  coordType, IntPtr  coords); private static PathSubCoordsNVDel PathSubCoordsNVPtr;
        
        // glPathTexGenNV
        private delegate void PathTexGenNVDel(uint /*PathColor*/  texCoordSet, uint /*PathGenMode*/  genMode, int  components, float[]  coeffs); private static PathTexGenNVDel PathTexGenNVPtr;
        
        // glPauseTransformFeedback
        private delegate void PauseTransformFeedbackDel(); private static PauseTransformFeedbackDel PauseTransformFeedbackPtr;
        
        // glPauseTransformFeedbackNV
        private delegate void PauseTransformFeedbackNVDel(); private static PauseTransformFeedbackNVDel PauseTransformFeedbackNVPtr;
        
        // glPixelDataRangeNV
        private delegate void PixelDataRangeNVDel(uint /*PixelDataRangeTargetNV*/  target, uint  length, IntPtr  pointer); private static PixelDataRangeNVDel PixelDataRangeNVPtr;
        
        // glPixelMapfv
        private delegate void PixelMapfvDel(uint /*PixelMap*/  map, uint /*CheckedInt32*/  mapsize, float[]  values); private static PixelMapfvDel PixelMapfvPtr;
        
        // glPixelMapuiv
        private delegate void PixelMapuivDel(uint /*PixelMap*/  map, uint /*CheckedInt32*/  mapsize, uint[]  values); private static PixelMapuivDel PixelMapuivPtr;
        
        // glPixelMapusv
        private delegate void PixelMapusvDel(uint /*PixelMap*/  map, uint /*CheckedInt32*/  mapsize, ushort[]  values); private static PixelMapusvDel PixelMapusvPtr;
        
        // glPixelMapx
        private delegate void PixelMapxDel(uint /*PixelMap*/  map, int  size, int[]  values); private static PixelMapxDel PixelMapxPtr;
        
        // glPixelStoref
        private delegate void PixelStorefDel(uint /*PixelStoreParameter*/  pname, float /*CheckedFloat32*/  param); private static PixelStorefDel PixelStorefPtr;
        
        // glPixelStorei
        private delegate void PixelStoreiDel(uint /*PixelStoreParameter*/  pname, int /*CheckedInt32*/  param); private static PixelStoreiDel PixelStoreiPtr;
        
        // glPixelStorex
        private delegate void PixelStorexDel(uint /*PixelStoreParameter*/  pname, int  param); private static PixelStorexDel PixelStorexPtr;
        
        // glPixelTexGenParameterfSGIS
        private delegate void PixelTexGenParameterfSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, float /*CheckedFloat32*/  param); private static PixelTexGenParameterfSGISDel PixelTexGenParameterfSGISPtr;
        
        // glPixelTexGenParameterfvSGIS
        private delegate void PixelTexGenParameterfvSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, float[] /*CheckedFloat32*/  parameters); private static PixelTexGenParameterfvSGISDel PixelTexGenParameterfvSGISPtr;
        
        // glPixelTexGenParameteriSGIS
        private delegate void PixelTexGenParameteriSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, int /*CheckedInt32*/  param); private static PixelTexGenParameteriSGISDel PixelTexGenParameteriSGISPtr;
        
        // glPixelTexGenParameterivSGIS
        private delegate void PixelTexGenParameterivSGISDel(uint /*PixelTexGenParameterNameSGIS*/  pname, int[] /*CheckedInt32*/  parameters); private static PixelTexGenParameterivSGISDel PixelTexGenParameterivSGISPtr;
        
        // glPixelTexGenSGIX
        private delegate void PixelTexGenSGIXDel(uint /*PixelTexGenModeSGIX*/  mode); private static PixelTexGenSGIXDel PixelTexGenSGIXPtr;
        
        // glPixelTransferf
        private delegate void PixelTransferfDel(uint /*PixelTransferParameter*/  pname, float /*CheckedFloat32*/  param); private static PixelTransferfDel PixelTransferfPtr;
        
        // glPixelTransferi
        private delegate void PixelTransferiDel(uint /*PixelTransferParameter*/  pname, int /*CheckedInt32*/  param); private static PixelTransferiDel PixelTransferiPtr;
        
        // glPixelTransferxOES
        private delegate void PixelTransferxOESDel(uint /*PixelTransferParameter*/  pname, int  param); private static PixelTransferxOESDel PixelTransferxOESPtr;
        
        // glPixelTransformParameterfEXT
        private delegate void PixelTransformParameterfEXTDel(uint /*PixelTransformTargetEXT*/  target, uint /*PixelTransformPNameEXT*/  pname, float  param); private static PixelTransformParameterfEXTDel PixelTransformParameterfEXTPtr;
        
        // glPixelTransformParameterfvEXT
        private delegate void PixelTransformParameterfvEXTDel(uint /*PixelTransformTargetEXT*/  target, uint /*PixelTransformPNameEXT*/  pname, float[]  parameters); private static PixelTransformParameterfvEXTDel PixelTransformParameterfvEXTPtr;
        
        // glPixelTransformParameteriEXT
        private delegate void PixelTransformParameteriEXTDel(uint /*PixelTransformTargetEXT*/  target, uint /*PixelTransformPNameEXT*/  pname, int  param); private static PixelTransformParameteriEXTDel PixelTransformParameteriEXTPtr;
        
        // glPixelTransformParameterivEXT
        private delegate void PixelTransformParameterivEXTDel(uint /*PixelTransformTargetEXT*/  target, uint /*PixelTransformPNameEXT*/  pname, int[]  parameters); private static PixelTransformParameterivEXTDel PixelTransformParameterivEXTPtr;
        
        // glPixelZoom
        private delegate void PixelZoomDel(float  xfactor, float  yfactor); private static PixelZoomDel PixelZoomPtr;
        
        // glPixelZoomxOES
        private delegate void PixelZoomxOESDel(int  xfactor, int  yfactor); private static PixelZoomxOESDel PixelZoomxOESPtr;
        
        // glPointAlongPathNV
        private delegate bool /*Boolean*/ PointAlongPathNVDel(uint /*Path*/  path, uint  startSegment, uint  numSegments, float  distance, float[]  x, float[]  y, float[]  tangentX, float[]  tangentY); private static PointAlongPathNVDel PointAlongPathNVPtr;
        
        // glPointParameterf
        private delegate void PointParameterfDel(uint /*PointParameterNameARB*/  pname, float /*CheckedFloat32*/  param); private static PointParameterfDel PointParameterfPtr;
        
        // glPointParameterfARB
        private delegate void PointParameterfARBDel(uint /*PointParameterNameARB*/  pname, float /*CheckedFloat32*/  param); private static PointParameterfARBDel PointParameterfARBPtr;
        
        // glPointParameterfEXT
        private delegate void PointParameterfEXTDel(uint /*PointParameterNameARB*/  pname, float /*CheckedFloat32*/  param); private static PointParameterfEXTDel PointParameterfEXTPtr;
        
        // glPointParameterfSGIS
        private delegate void PointParameterfSGISDel(uint /*PointParameterNameARB*/  pname, float /*CheckedFloat32*/  param); private static PointParameterfSGISDel PointParameterfSGISPtr;
        
        // glPointParameterfv
        private delegate void PointParameterfvDel(uint /*PointParameterNameARB*/  pname, float[] /*CheckedFloat32*/  parameters); private static PointParameterfvDel PointParameterfvPtr;
        
        // glPointParameterfvARB
        private delegate void PointParameterfvARBDel(uint /*PointParameterNameARB*/  pname, float[] /*CheckedFloat32*/  parameters); private static PointParameterfvARBDel PointParameterfvARBPtr;
        
        // glPointParameterfvEXT
        private delegate void PointParameterfvEXTDel(uint /*PointParameterNameARB*/  pname, float[] /*CheckedFloat32*/  parameters); private static PointParameterfvEXTDel PointParameterfvEXTPtr;
        
        // glPointParameterfvSGIS
        private delegate void PointParameterfvSGISDel(uint /*PointParameterNameARB*/  pname, float[] /*CheckedFloat32*/  parameters); private static PointParameterfvSGISDel PointParameterfvSGISPtr;
        
        // glPointParameteri
        private delegate void PointParameteriDel(uint /*PointParameterNameARB*/  pname, int  param); private static PointParameteriDel PointParameteriPtr;
        
        // glPointParameteriNV
        private delegate void PointParameteriNVDel(uint /*PointParameterNameARB*/  pname, int  param); private static PointParameteriNVDel PointParameteriNVPtr;
        
        // glPointParameteriv
        private delegate void PointParameterivDel(uint /*PointParameterNameARB*/  pname, int[]  parameters); private static PointParameterivDel PointParameterivPtr;
        
        // glPointParameterivNV
        private delegate void PointParameterivNVDel(uint /*PointParameterNameARB*/  pname, int[]  parameters); private static PointParameterivNVDel PointParameterivNVPtr;
        
        // glPointParameterx
        private delegate void PointParameterxDel(uint /*PointParameterNameARB*/  pname, int  param); private static PointParameterxDel PointParameterxPtr;
        
        // glPointParameterxOES
        private delegate void PointParameterxOESDel(uint /*PointParameterNameARB*/  pname, int  param); private static PointParameterxOESDel PointParameterxOESPtr;
        
        // glPointParameterxv
        private delegate void PointParameterxvDel(uint /*PointParameterNameARB*/  pname, int[]  parameters); private static PointParameterxvDel PointParameterxvPtr;
        
        // glPointParameterxvOES
        private delegate void PointParameterxvOESDel(uint /*PointParameterNameARB*/  pname, int[]  parameters); private static PointParameterxvOESDel PointParameterxvOESPtr;
        
        // glPointSize
        private delegate void PointSizeDel(float /*CheckedFloat32*/  size); private static PointSizeDel PointSizePtr;
        
        // glPointSizePointerOES
        private delegate void PointSizePointerOESDel(uint  type, uint  stride, IntPtr  pointer); private static PointSizePointerOESDel PointSizePointerOESPtr;
        
        // glPointSizex
        private delegate void PointSizexDel(int  size); private static PointSizexDel PointSizexPtr;
        
        // glPointSizexOES
        private delegate void PointSizexOESDel(int  size); private static PointSizexOESDel PointSizexOESPtr;
        
        // glPollAsyncSGIX
        private delegate int PollAsyncSGIXDel(uint[]  markerp); private static PollAsyncSGIXDel PollAsyncSGIXPtr;
        
        // glPollInstrumentsSGIX
        private delegate int PollInstrumentsSGIXDel(int[]  marker_p); private static PollInstrumentsSGIXDel PollInstrumentsSGIXPtr;
        
        // glPolygonMode
        private delegate void PolygonModeDel(uint /*MaterialFace*/  face, uint /*PolygonMode*/  mode); private static PolygonModeDel PolygonModePtr;
        
        // glPolygonModeNV
        private delegate void PolygonModeNVDel(uint /*MaterialFace*/  face, uint /*PolygonMode*/  mode); private static PolygonModeNVDel PolygonModeNVPtr;
        
        // glPolygonOffset
        private delegate void PolygonOffsetDel(float  factor, float  units); private static PolygonOffsetDel PolygonOffsetPtr;
        
        // glPolygonOffsetClamp
        private delegate void PolygonOffsetClampDel(float  factor, float  units, float  clamp); private static PolygonOffsetClampDel PolygonOffsetClampPtr;
        
        // glPolygonOffsetClampEXT
        private delegate void PolygonOffsetClampEXTDel(float  factor, float  units, float  clamp); private static PolygonOffsetClampEXTDel PolygonOffsetClampEXTPtr;
        
        // glPolygonOffsetEXT
        private delegate void PolygonOffsetEXTDel(float  factor, float  bias); private static PolygonOffsetEXTDel PolygonOffsetEXTPtr;
        
        // glPolygonOffsetx
        private delegate void PolygonOffsetxDel(int  factor, int  units); private static PolygonOffsetxDel PolygonOffsetxPtr;
        
        // glPolygonOffsetxOES
        private delegate void PolygonOffsetxOESDel(int  factor, int  units); private static PolygonOffsetxOESDel PolygonOffsetxOESPtr;
        
        // glPolygonStipple
        private delegate void PolygonStippleDel(byte[]  mask); private static PolygonStippleDel PolygonStipplePtr;
        
        // glPopAttrib
        private delegate void PopAttribDel(); private static PopAttribDel PopAttribPtr;
        
        // glPopClientAttrib
        private delegate void PopClientAttribDel(); private static PopClientAttribDel PopClientAttribPtr;
        
        // glPopDebugGroup
        private delegate void PopDebugGroupDel(); private static PopDebugGroupDel PopDebugGroupPtr;
        
        // glPopDebugGroupKHR
        private delegate void PopDebugGroupKHRDel(); private static PopDebugGroupKHRDel PopDebugGroupKHRPtr;
        
        // glPopGroupMarkerEXT
        private delegate void PopGroupMarkerEXTDel(); private static PopGroupMarkerEXTDel PopGroupMarkerEXTPtr;
        
        // glPopMatrix
        private delegate void PopMatrixDel(); private static PopMatrixDel PopMatrixPtr;
        
        // glPopName
        private delegate void PopNameDel(); private static PopNameDel PopNamePtr;
        
        // glPresentFrameDualFillNV
        private delegate void PresentFrameDualFillNVDel(uint  video_slot, ulong  minPresentTime, uint  beginPresentTimeId, uint  presentDurationId, uint  type, uint  target0, uint  fill0, uint  target1, uint  fill1, uint  target2, uint  fill2, uint  target3, uint  fill3); private static PresentFrameDualFillNVDel PresentFrameDualFillNVPtr;
        
        // glPresentFrameKeyedNV
        private delegate void PresentFrameKeyedNVDel(uint  video_slot, ulong  minPresentTime, uint  beginPresentTimeId, uint  presentDurationId, uint  type, uint  target0, uint  fill0, uint  key0, uint  target1, uint  fill1, uint  key1); private static PresentFrameKeyedNVDel PresentFrameKeyedNVPtr;
        
        // glPrimitiveBoundingBox
        private delegate void PrimitiveBoundingBoxDel(float  minX, float  minY, float  minZ, float  minW, float  maxX, float  maxY, float  maxZ, float  maxW); private static PrimitiveBoundingBoxDel PrimitiveBoundingBoxPtr;
        
        // glPrimitiveBoundingBoxARB
        private delegate void PrimitiveBoundingBoxARBDel(float  minX, float  minY, float  minZ, float  minW, float  maxX, float  maxY, float  maxZ, float  maxW); private static PrimitiveBoundingBoxARBDel PrimitiveBoundingBoxARBPtr;
        
        // glPrimitiveBoundingBoxEXT
        private delegate void PrimitiveBoundingBoxEXTDel(float  minX, float  minY, float  minZ, float  minW, float  maxX, float  maxY, float  maxZ, float  maxW); private static PrimitiveBoundingBoxEXTDel PrimitiveBoundingBoxEXTPtr;
        
        // glPrimitiveBoundingBoxOES
        private delegate void PrimitiveBoundingBoxOESDel(float  minX, float  minY, float  minZ, float  minW, float  maxX, float  maxY, float  maxZ, float  maxW); private static PrimitiveBoundingBoxOESDel PrimitiveBoundingBoxOESPtr;
        
        // glPrimitiveRestartIndex
        private delegate void PrimitiveRestartIndexDel(uint  index); private static PrimitiveRestartIndexDel PrimitiveRestartIndexPtr;
        
        // glPrimitiveRestartIndexNV
        private delegate void PrimitiveRestartIndexNVDel(uint  index); private static PrimitiveRestartIndexNVDel PrimitiveRestartIndexNVPtr;
        
        // glPrimitiveRestartNV
        private delegate void PrimitiveRestartNVDel(); private static PrimitiveRestartNVDel PrimitiveRestartNVPtr;
        
        // glPrioritizeTextures
        private delegate void PrioritizeTexturesDel(uint  n, uint[] /*Texture*/  textures, float[]  priorities); private static PrioritizeTexturesDel PrioritizeTexturesPtr;
        
        // glPrioritizeTexturesEXT
        private delegate void PrioritizeTexturesEXTDel(uint  n, uint[] /*Texture*/  textures, float[] /*ClampedFloat32*/  priorities); private static PrioritizeTexturesEXTDel PrioritizeTexturesEXTPtr;
        
        // glPrioritizeTexturesxOES
        private delegate void PrioritizeTexturesxOESDel(uint  n, uint[]  textures, int[] /*ClampedFixed*/  priorities); private static PrioritizeTexturesxOESDel PrioritizeTexturesxOESPtr;
        
        // glProgramBinary
        private delegate void ProgramBinaryDel(uint  program, uint  binaryFormat, IntPtr  binary, uint  length); private static ProgramBinaryDel ProgramBinaryPtr;
        
        // glProgramBinaryOES
        private delegate void ProgramBinaryOESDel(uint  program, uint  binaryFormat, IntPtr  binary, int  length); private static ProgramBinaryOESDel ProgramBinaryOESPtr;
        
        // glProgramBufferParametersIivNV
        private delegate void ProgramBufferParametersIivNVDel(uint /*ProgramTarget*/  target, uint  bindingIndex, uint  wordIndex, uint  count, int[]  parameters); private static ProgramBufferParametersIivNVDel ProgramBufferParametersIivNVPtr;
        
        // glProgramBufferParametersIuivNV
        private delegate void ProgramBufferParametersIuivNVDel(uint /*ProgramTarget*/  target, uint  bindingIndex, uint  wordIndex, uint  count, uint[]  parameters); private static ProgramBufferParametersIuivNVDel ProgramBufferParametersIuivNVPtr;
        
        // glProgramBufferParametersfvNV
        private delegate void ProgramBufferParametersfvNVDel(uint /*ProgramTarget*/  target, uint  bindingIndex, uint  wordIndex, uint  count, float[]  parameters); private static ProgramBufferParametersfvNVDel ProgramBufferParametersfvNVPtr;
        
        // glProgramEnvParameter4dARB
        private delegate void ProgramEnvParameter4dARBDel(uint /*ProgramTarget*/  target, uint  index, double  x, double  y, double  z, double  w); private static ProgramEnvParameter4dARBDel ProgramEnvParameter4dARBPtr;
        
        // glProgramEnvParameter4dvARB
        private delegate void ProgramEnvParameter4dvARBDel(uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static ProgramEnvParameter4dvARBDel ProgramEnvParameter4dvARBPtr;
        
        // glProgramEnvParameter4fARB
        private delegate void ProgramEnvParameter4fARBDel(uint /*ProgramTarget*/  target, uint  index, float  x, float  y, float  z, float  w); private static ProgramEnvParameter4fARBDel ProgramEnvParameter4fARBPtr;
        
        // glProgramEnvParameter4fvARB
        private delegate void ProgramEnvParameter4fvARBDel(uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static ProgramEnvParameter4fvARBDel ProgramEnvParameter4fvARBPtr;
        
        // glProgramEnvParameterI4iNV
        private delegate void ProgramEnvParameterI4iNVDel(uint /*ProgramTarget*/  target, uint  index, int  x, int  y, int  z, int  w); private static ProgramEnvParameterI4iNVDel ProgramEnvParameterI4iNVPtr;
        
        // glProgramEnvParameterI4ivNV
        private delegate void ProgramEnvParameterI4ivNVDel(uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static ProgramEnvParameterI4ivNVDel ProgramEnvParameterI4ivNVPtr;
        
        // glProgramEnvParameterI4uiNV
        private delegate void ProgramEnvParameterI4uiNVDel(uint /*ProgramTarget*/  target, uint  index, uint  x, uint  y, uint  z, uint  w); private static ProgramEnvParameterI4uiNVDel ProgramEnvParameterI4uiNVPtr;
        
        // glProgramEnvParameterI4uivNV
        private delegate void ProgramEnvParameterI4uivNVDel(uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static ProgramEnvParameterI4uivNVDel ProgramEnvParameterI4uivNVPtr;
        
        // glProgramEnvParameters4fvEXT
        private delegate void ProgramEnvParameters4fvEXTDel(uint /*ProgramTarget*/  target, uint  index, uint  count, float[]  parameters); private static ProgramEnvParameters4fvEXTDel ProgramEnvParameters4fvEXTPtr;
        
        // glProgramEnvParametersI4ivNV
        private delegate void ProgramEnvParametersI4ivNVDel(uint /*ProgramTarget*/  target, uint  index, uint  count, int[]  parameters); private static ProgramEnvParametersI4ivNVDel ProgramEnvParametersI4ivNVPtr;
        
        // glProgramEnvParametersI4uivNV
        private delegate void ProgramEnvParametersI4uivNVDel(uint /*ProgramTarget*/  target, uint  index, uint  count, uint[]  parameters); private static ProgramEnvParametersI4uivNVDel ProgramEnvParametersI4uivNVPtr;
        
        // glProgramLocalParameter4dARB
        private delegate void ProgramLocalParameter4dARBDel(uint /*ProgramTarget*/  target, uint  index, double  x, double  y, double  z, double  w); private static ProgramLocalParameter4dARBDel ProgramLocalParameter4dARBPtr;
        
        // glProgramLocalParameter4dvARB
        private delegate void ProgramLocalParameter4dvARBDel(uint /*ProgramTarget*/  target, uint  index, double[]  parameters); private static ProgramLocalParameter4dvARBDel ProgramLocalParameter4dvARBPtr;
        
        // glProgramLocalParameter4fARB
        private delegate void ProgramLocalParameter4fARBDel(uint /*ProgramTarget*/  target, uint  index, float  x, float  y, float  z, float  w); private static ProgramLocalParameter4fARBDel ProgramLocalParameter4fARBPtr;
        
        // glProgramLocalParameter4fvARB
        private delegate void ProgramLocalParameter4fvARBDel(uint /*ProgramTarget*/  target, uint  index, float[]  parameters); private static ProgramLocalParameter4fvARBDel ProgramLocalParameter4fvARBPtr;
        
        // glProgramLocalParameterI4iNV
        private delegate void ProgramLocalParameterI4iNVDel(uint /*ProgramTarget*/  target, uint  index, int  x, int  y, int  z, int  w); private static ProgramLocalParameterI4iNVDel ProgramLocalParameterI4iNVPtr;
        
        // glProgramLocalParameterI4ivNV
        private delegate void ProgramLocalParameterI4ivNVDel(uint /*ProgramTarget*/  target, uint  index, int[]  parameters); private static ProgramLocalParameterI4ivNVDel ProgramLocalParameterI4ivNVPtr;
        
        // glProgramLocalParameterI4uiNV
        private delegate void ProgramLocalParameterI4uiNVDel(uint /*ProgramTarget*/  target, uint  index, uint  x, uint  y, uint  z, uint  w); private static ProgramLocalParameterI4uiNVDel ProgramLocalParameterI4uiNVPtr;
        
        // glProgramLocalParameterI4uivNV
        private delegate void ProgramLocalParameterI4uivNVDel(uint /*ProgramTarget*/  target, uint  index, uint[]  parameters); private static ProgramLocalParameterI4uivNVDel ProgramLocalParameterI4uivNVPtr;
        
        // glProgramLocalParameters4fvEXT
        private delegate void ProgramLocalParameters4fvEXTDel(uint /*ProgramTarget*/  target, uint  index, uint  count, float[]  parameters); private static ProgramLocalParameters4fvEXTDel ProgramLocalParameters4fvEXTPtr;
        
        // glProgramLocalParametersI4ivNV
        private delegate void ProgramLocalParametersI4ivNVDel(uint /*ProgramTarget*/  target, uint  index, uint  count, int[]  parameters); private static ProgramLocalParametersI4ivNVDel ProgramLocalParametersI4ivNVPtr;
        
        // glProgramLocalParametersI4uivNV
        private delegate void ProgramLocalParametersI4uivNVDel(uint /*ProgramTarget*/  target, uint  index, uint  count, uint[]  parameters); private static ProgramLocalParametersI4uivNVDel ProgramLocalParametersI4uivNVPtr;
        
        // glProgramNamedParameter4dNV
        private delegate void ProgramNamedParameter4dNVDel(uint  id, uint  len, byte[]  name, double  x, double  y, double  z, double  w); private static ProgramNamedParameter4dNVDel ProgramNamedParameter4dNVPtr;
        
        // glProgramNamedParameter4dvNV
        private delegate void ProgramNamedParameter4dvNVDel(uint  id, uint  len, byte[]  name, double[]  v); private static ProgramNamedParameter4dvNVDel ProgramNamedParameter4dvNVPtr;
        
        // glProgramNamedParameter4fNV
        private delegate void ProgramNamedParameter4fNVDel(uint  id, uint  len, byte[]  name, float  x, float  y, float  z, float  w); private static ProgramNamedParameter4fNVDel ProgramNamedParameter4fNVPtr;
        
        // glProgramNamedParameter4fvNV
        private delegate void ProgramNamedParameter4fvNVDel(uint  id, uint  len, byte[]  name, float[]  v); private static ProgramNamedParameter4fvNVDel ProgramNamedParameter4fvNVPtr;
        
        // glProgramParameter4dNV
        private delegate void ProgramParameter4dNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, double  x, double  y, double  z, double  w); private static ProgramParameter4dNVDel ProgramParameter4dNVPtr;
        
        // glProgramParameter4dvNV
        private delegate void ProgramParameter4dvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, double[]  v); private static ProgramParameter4dvNVDel ProgramParameter4dvNVPtr;
        
        // glProgramParameter4fNV
        private delegate void ProgramParameter4fNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, float  x, float  y, float  z, float  w); private static ProgramParameter4fNVDel ProgramParameter4fNVPtr;
        
        // glProgramParameter4fvNV
        private delegate void ProgramParameter4fvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, float[]  v); private static ProgramParameter4fvNVDel ProgramParameter4fvNVPtr;
        
        // glProgramParameteri
        private delegate void ProgramParameteriDel(uint  program, uint /*ProgramParameterPName*/  pname, int  value); private static ProgramParameteriDel ProgramParameteriPtr;
        
        // glProgramParameteriARB
        private delegate void ProgramParameteriARBDel(uint  program, uint /*ProgramParameterPName*/  pname, int  value); private static ProgramParameteriARBDel ProgramParameteriARBPtr;
        
        // glProgramParameteriEXT
        private delegate void ProgramParameteriEXTDel(uint  program, uint /*ProgramParameterPName*/  pname, int  value); private static ProgramParameteriEXTDel ProgramParameteriEXTPtr;
        
        // glProgramParameters4dvNV
        private delegate void ProgramParameters4dvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, uint  count, double[]  v); private static ProgramParameters4dvNVDel ProgramParameters4dvNVPtr;
        
        // glProgramParameters4fvNV
        private delegate void ProgramParameters4fvNVDel(uint /*VertexAttribEnumNV*/  target, uint  index, uint  count, float[]  v); private static ProgramParameters4fvNVDel ProgramParameters4fvNVPtr;
        
        // glProgramPathFragmentInputGenNV
        private delegate void ProgramPathFragmentInputGenNVDel(uint  program, int  location, uint  genMode, int  components, float[]  coeffs); private static ProgramPathFragmentInputGenNVDel ProgramPathFragmentInputGenNVPtr;
        
        // glProgramStringARB
        private delegate void ProgramStringARBDel(uint /*ProgramTarget*/  target, uint /*ProgramFormat*/  format, uint  len, IntPtr  str); private static ProgramStringARBDel ProgramStringARBPtr;
        
        // glProgramSubroutineParametersuivNV
        private delegate void ProgramSubroutineParametersuivNVDel(uint  target, uint  count, uint[]  parameters); private static ProgramSubroutineParametersuivNVDel ProgramSubroutineParametersuivNVPtr;
        
        // glProgramUniform1d
        private delegate void ProgramUniform1dDel(uint  program, int  location, double  v0); private static ProgramUniform1dDel ProgramUniform1dPtr;
        
        // glProgramUniform1dEXT
        private delegate void ProgramUniform1dEXTDel(uint  program, int  location, double  x); private static ProgramUniform1dEXTDel ProgramUniform1dEXTPtr;
        
        // glProgramUniform1dv
        private delegate void ProgramUniform1dvDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform1dvDel ProgramUniform1dvPtr;
        
        // glProgramUniform1dvEXT
        private delegate void ProgramUniform1dvEXTDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform1dvEXTDel ProgramUniform1dvEXTPtr;
        
        // glProgramUniform1f
        private delegate void ProgramUniform1fDel(uint  program, int  location, float  v0); private static ProgramUniform1fDel ProgramUniform1fPtr;
        
        // glProgramUniform1fEXT
        private delegate void ProgramUniform1fEXTDel(uint  program, int  location, float  v0); private static ProgramUniform1fEXTDel ProgramUniform1fEXTPtr;
        
        // glProgramUniform1fv
        private delegate void ProgramUniform1fvDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform1fvDel ProgramUniform1fvPtr;
        
        // glProgramUniform1fvEXT
        private delegate void ProgramUniform1fvEXTDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform1fvEXTDel ProgramUniform1fvEXTPtr;
        
        // glProgramUniform1i
        private delegate void ProgramUniform1iDel(uint  program, int  location, int  v0); private static ProgramUniform1iDel ProgramUniform1iPtr;
        
        // glProgramUniform1i64ARB
        private delegate void ProgramUniform1i64ARBDel(uint  program, int  location, long  x); private static ProgramUniform1i64ARBDel ProgramUniform1i64ARBPtr;
        
        // glProgramUniform1i64NV
        private delegate void ProgramUniform1i64NVDel(uint  program, int  location, long  x); private static ProgramUniform1i64NVDel ProgramUniform1i64NVPtr;
        
        // glProgramUniform1i64vARB
        private delegate void ProgramUniform1i64vARBDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform1i64vARBDel ProgramUniform1i64vARBPtr;
        
        // glProgramUniform1i64vNV
        private delegate void ProgramUniform1i64vNVDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform1i64vNVDel ProgramUniform1i64vNVPtr;
        
        // glProgramUniform1iEXT
        private delegate void ProgramUniform1iEXTDel(uint  program, int  location, int  v0); private static ProgramUniform1iEXTDel ProgramUniform1iEXTPtr;
        
        // glProgramUniform1iv
        private delegate void ProgramUniform1ivDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform1ivDel ProgramUniform1ivPtr;
        
        // glProgramUniform1ivEXT
        private delegate void ProgramUniform1ivEXTDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform1ivEXTDel ProgramUniform1ivEXTPtr;
        
        // glProgramUniform1ui
        private delegate void ProgramUniform1uiDel(uint  program, int  location, uint  v0); private static ProgramUniform1uiDel ProgramUniform1uiPtr;
        
        // glProgramUniform1ui64ARB
        private delegate void ProgramUniform1ui64ARBDel(uint  program, int  location, ulong  x); private static ProgramUniform1ui64ARBDel ProgramUniform1ui64ARBPtr;
        
        // glProgramUniform1ui64NV
        private delegate void ProgramUniform1ui64NVDel(uint  program, int  location, ulong  x); private static ProgramUniform1ui64NVDel ProgramUniform1ui64NVPtr;
        
        // glProgramUniform1ui64vARB
        private delegate void ProgramUniform1ui64vARBDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform1ui64vARBDel ProgramUniform1ui64vARBPtr;
        
        // glProgramUniform1ui64vNV
        private delegate void ProgramUniform1ui64vNVDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform1ui64vNVDel ProgramUniform1ui64vNVPtr;
        
        // glProgramUniform1uiEXT
        private delegate void ProgramUniform1uiEXTDel(uint  program, int  location, uint  v0); private static ProgramUniform1uiEXTDel ProgramUniform1uiEXTPtr;
        
        // glProgramUniform1uiv
        private delegate void ProgramUniform1uivDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform1uivDel ProgramUniform1uivPtr;
        
        // glProgramUniform1uivEXT
        private delegate void ProgramUniform1uivEXTDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform1uivEXTDel ProgramUniform1uivEXTPtr;
        
        // glProgramUniform2d
        private delegate void ProgramUniform2dDel(uint  program, int  location, double  v0, double  v1); private static ProgramUniform2dDel ProgramUniform2dPtr;
        
        // glProgramUniform2dEXT
        private delegate void ProgramUniform2dEXTDel(uint  program, int  location, double  x, double  y); private static ProgramUniform2dEXTDel ProgramUniform2dEXTPtr;
        
        // glProgramUniform2dv
        private delegate void ProgramUniform2dvDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform2dvDel ProgramUniform2dvPtr;
        
        // glProgramUniform2dvEXT
        private delegate void ProgramUniform2dvEXTDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform2dvEXTDel ProgramUniform2dvEXTPtr;
        
        // glProgramUniform2f
        private delegate void ProgramUniform2fDel(uint  program, int  location, float  v0, float  v1); private static ProgramUniform2fDel ProgramUniform2fPtr;
        
        // glProgramUniform2fEXT
        private delegate void ProgramUniform2fEXTDel(uint  program, int  location, float  v0, float  v1); private static ProgramUniform2fEXTDel ProgramUniform2fEXTPtr;
        
        // glProgramUniform2fv
        private delegate void ProgramUniform2fvDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform2fvDel ProgramUniform2fvPtr;
        
        // glProgramUniform2fvEXT
        private delegate void ProgramUniform2fvEXTDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform2fvEXTDel ProgramUniform2fvEXTPtr;
        
        // glProgramUniform2i
        private delegate void ProgramUniform2iDel(uint  program, int  location, int  v0, int  v1); private static ProgramUniform2iDel ProgramUniform2iPtr;
        
        // glProgramUniform2i64ARB
        private delegate void ProgramUniform2i64ARBDel(uint  program, int  location, long  x, long  y); private static ProgramUniform2i64ARBDel ProgramUniform2i64ARBPtr;
        
        // glProgramUniform2i64NV
        private delegate void ProgramUniform2i64NVDel(uint  program, int  location, long  x, long  y); private static ProgramUniform2i64NVDel ProgramUniform2i64NVPtr;
        
        // glProgramUniform2i64vARB
        private delegate void ProgramUniform2i64vARBDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform2i64vARBDel ProgramUniform2i64vARBPtr;
        
        // glProgramUniform2i64vNV
        private delegate void ProgramUniform2i64vNVDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform2i64vNVDel ProgramUniform2i64vNVPtr;
        
        // glProgramUniform2iEXT
        private delegate void ProgramUniform2iEXTDel(uint  program, int  location, int  v0, int  v1); private static ProgramUniform2iEXTDel ProgramUniform2iEXTPtr;
        
        // glProgramUniform2iv
        private delegate void ProgramUniform2ivDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform2ivDel ProgramUniform2ivPtr;
        
        // glProgramUniform2ivEXT
        private delegate void ProgramUniform2ivEXTDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform2ivEXTDel ProgramUniform2ivEXTPtr;
        
        // glProgramUniform2ui
        private delegate void ProgramUniform2uiDel(uint  program, int  location, uint  v0, uint  v1); private static ProgramUniform2uiDel ProgramUniform2uiPtr;
        
        // glProgramUniform2ui64ARB
        private delegate void ProgramUniform2ui64ARBDel(uint  program, int  location, ulong  x, ulong  y); private static ProgramUniform2ui64ARBDel ProgramUniform2ui64ARBPtr;
        
        // glProgramUniform2ui64NV
        private delegate void ProgramUniform2ui64NVDel(uint  program, int  location, ulong  x, ulong  y); private static ProgramUniform2ui64NVDel ProgramUniform2ui64NVPtr;
        
        // glProgramUniform2ui64vARB
        private delegate void ProgramUniform2ui64vARBDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform2ui64vARBDel ProgramUniform2ui64vARBPtr;
        
        // glProgramUniform2ui64vNV
        private delegate void ProgramUniform2ui64vNVDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform2ui64vNVDel ProgramUniform2ui64vNVPtr;
        
        // glProgramUniform2uiEXT
        private delegate void ProgramUniform2uiEXTDel(uint  program, int  location, uint  v0, uint  v1); private static ProgramUniform2uiEXTDel ProgramUniform2uiEXTPtr;
        
        // glProgramUniform2uiv
        private delegate void ProgramUniform2uivDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform2uivDel ProgramUniform2uivPtr;
        
        // glProgramUniform2uivEXT
        private delegate void ProgramUniform2uivEXTDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform2uivEXTDel ProgramUniform2uivEXTPtr;
        
        // glProgramUniform3d
        private delegate void ProgramUniform3dDel(uint  program, int  location, double  v0, double  v1, double  v2); private static ProgramUniform3dDel ProgramUniform3dPtr;
        
        // glProgramUniform3dEXT
        private delegate void ProgramUniform3dEXTDel(uint  program, int  location, double  x, double  y, double  z); private static ProgramUniform3dEXTDel ProgramUniform3dEXTPtr;
        
        // glProgramUniform3dv
        private delegate void ProgramUniform3dvDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform3dvDel ProgramUniform3dvPtr;
        
        // glProgramUniform3dvEXT
        private delegate void ProgramUniform3dvEXTDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform3dvEXTDel ProgramUniform3dvEXTPtr;
        
        // glProgramUniform3f
        private delegate void ProgramUniform3fDel(uint  program, int  location, float  v0, float  v1, float  v2); private static ProgramUniform3fDel ProgramUniform3fPtr;
        
        // glProgramUniform3fEXT
        private delegate void ProgramUniform3fEXTDel(uint  program, int  location, float  v0, float  v1, float  v2); private static ProgramUniform3fEXTDel ProgramUniform3fEXTPtr;
        
        // glProgramUniform3fv
        private delegate void ProgramUniform3fvDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform3fvDel ProgramUniform3fvPtr;
        
        // glProgramUniform3fvEXT
        private delegate void ProgramUniform3fvEXTDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform3fvEXTDel ProgramUniform3fvEXTPtr;
        
        // glProgramUniform3i
        private delegate void ProgramUniform3iDel(uint  program, int  location, int  v0, int  v1, int  v2); private static ProgramUniform3iDel ProgramUniform3iPtr;
        
        // glProgramUniform3i64ARB
        private delegate void ProgramUniform3i64ARBDel(uint  program, int  location, long  x, long  y, long  z); private static ProgramUniform3i64ARBDel ProgramUniform3i64ARBPtr;
        
        // glProgramUniform3i64NV
        private delegate void ProgramUniform3i64NVDel(uint  program, int  location, long  x, long  y, long  z); private static ProgramUniform3i64NVDel ProgramUniform3i64NVPtr;
        
        // glProgramUniform3i64vARB
        private delegate void ProgramUniform3i64vARBDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform3i64vARBDel ProgramUniform3i64vARBPtr;
        
        // glProgramUniform3i64vNV
        private delegate void ProgramUniform3i64vNVDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform3i64vNVDel ProgramUniform3i64vNVPtr;
        
        // glProgramUniform3iEXT
        private delegate void ProgramUniform3iEXTDel(uint  program, int  location, int  v0, int  v1, int  v2); private static ProgramUniform3iEXTDel ProgramUniform3iEXTPtr;
        
        // glProgramUniform3iv
        private delegate void ProgramUniform3ivDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform3ivDel ProgramUniform3ivPtr;
        
        // glProgramUniform3ivEXT
        private delegate void ProgramUniform3ivEXTDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform3ivEXTDel ProgramUniform3ivEXTPtr;
        
        // glProgramUniform3ui
        private delegate void ProgramUniform3uiDel(uint  program, int  location, uint  v0, uint  v1, uint  v2); private static ProgramUniform3uiDel ProgramUniform3uiPtr;
        
        // glProgramUniform3ui64ARB
        private delegate void ProgramUniform3ui64ARBDel(uint  program, int  location, ulong  x, ulong  y, ulong  z); private static ProgramUniform3ui64ARBDel ProgramUniform3ui64ARBPtr;
        
        // glProgramUniform3ui64NV
        private delegate void ProgramUniform3ui64NVDel(uint  program, int  location, ulong  x, ulong  y, ulong  z); private static ProgramUniform3ui64NVDel ProgramUniform3ui64NVPtr;
        
        // glProgramUniform3ui64vARB
        private delegate void ProgramUniform3ui64vARBDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform3ui64vARBDel ProgramUniform3ui64vARBPtr;
        
        // glProgramUniform3ui64vNV
        private delegate void ProgramUniform3ui64vNVDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform3ui64vNVDel ProgramUniform3ui64vNVPtr;
        
        // glProgramUniform3uiEXT
        private delegate void ProgramUniform3uiEXTDel(uint  program, int  location, uint  v0, uint  v1, uint  v2); private static ProgramUniform3uiEXTDel ProgramUniform3uiEXTPtr;
        
        // glProgramUniform3uiv
        private delegate void ProgramUniform3uivDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform3uivDel ProgramUniform3uivPtr;
        
        // glProgramUniform3uivEXT
        private delegate void ProgramUniform3uivEXTDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform3uivEXTDel ProgramUniform3uivEXTPtr;
        
        // glProgramUniform4d
        private delegate void ProgramUniform4dDel(uint  program, int  location, double  v0, double  v1, double  v2, double  v3); private static ProgramUniform4dDel ProgramUniform4dPtr;
        
        // glProgramUniform4dEXT
        private delegate void ProgramUniform4dEXTDel(uint  program, int  location, double  x, double  y, double  z, double  w); private static ProgramUniform4dEXTDel ProgramUniform4dEXTPtr;
        
        // glProgramUniform4dv
        private delegate void ProgramUniform4dvDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform4dvDel ProgramUniform4dvPtr;
        
        // glProgramUniform4dvEXT
        private delegate void ProgramUniform4dvEXTDel(uint  program, int  location, uint  count, double[]  value); private static ProgramUniform4dvEXTDel ProgramUniform4dvEXTPtr;
        
        // glProgramUniform4f
        private delegate void ProgramUniform4fDel(uint  program, int  location, float  v0, float  v1, float  v2, float  v3); private static ProgramUniform4fDel ProgramUniform4fPtr;
        
        // glProgramUniform4fEXT
        private delegate void ProgramUniform4fEXTDel(uint  program, int  location, float  v0, float  v1, float  v2, float  v3); private static ProgramUniform4fEXTDel ProgramUniform4fEXTPtr;
        
        // glProgramUniform4fv
        private delegate void ProgramUniform4fvDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform4fvDel ProgramUniform4fvPtr;
        
        // glProgramUniform4fvEXT
        private delegate void ProgramUniform4fvEXTDel(uint  program, int  location, uint  count, float[]  value); private static ProgramUniform4fvEXTDel ProgramUniform4fvEXTPtr;
        
        // glProgramUniform4i
        private delegate void ProgramUniform4iDel(uint  program, int  location, int  v0, int  v1, int  v2, int  v3); private static ProgramUniform4iDel ProgramUniform4iPtr;
        
        // glProgramUniform4i64ARB
        private delegate void ProgramUniform4i64ARBDel(uint  program, int  location, long  x, long  y, long  z, long  w); private static ProgramUniform4i64ARBDel ProgramUniform4i64ARBPtr;
        
        // glProgramUniform4i64NV
        private delegate void ProgramUniform4i64NVDel(uint  program, int  location, long  x, long  y, long  z, long  w); private static ProgramUniform4i64NVDel ProgramUniform4i64NVPtr;
        
        // glProgramUniform4i64vARB
        private delegate void ProgramUniform4i64vARBDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform4i64vARBDel ProgramUniform4i64vARBPtr;
        
        // glProgramUniform4i64vNV
        private delegate void ProgramUniform4i64vNVDel(uint  program, int  location, uint  count, long[]  value); private static ProgramUniform4i64vNVDel ProgramUniform4i64vNVPtr;
        
        // glProgramUniform4iEXT
        private delegate void ProgramUniform4iEXTDel(uint  program, int  location, int  v0, int  v1, int  v2, int  v3); private static ProgramUniform4iEXTDel ProgramUniform4iEXTPtr;
        
        // glProgramUniform4iv
        private delegate void ProgramUniform4ivDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform4ivDel ProgramUniform4ivPtr;
        
        // glProgramUniform4ivEXT
        private delegate void ProgramUniform4ivEXTDel(uint  program, int  location, uint  count, int[]  value); private static ProgramUniform4ivEXTDel ProgramUniform4ivEXTPtr;
        
        // glProgramUniform4ui
        private delegate void ProgramUniform4uiDel(uint  program, int  location, uint  v0, uint  v1, uint  v2, uint  v3); private static ProgramUniform4uiDel ProgramUniform4uiPtr;
        
        // glProgramUniform4ui64ARB
        private delegate void ProgramUniform4ui64ARBDel(uint  program, int  location, ulong  x, ulong  y, ulong  z, ulong  w); private static ProgramUniform4ui64ARBDel ProgramUniform4ui64ARBPtr;
        
        // glProgramUniform4ui64NV
        private delegate void ProgramUniform4ui64NVDel(uint  program, int  location, ulong  x, ulong  y, ulong  z, ulong  w); private static ProgramUniform4ui64NVDel ProgramUniform4ui64NVPtr;
        
        // glProgramUniform4ui64vARB
        private delegate void ProgramUniform4ui64vARBDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform4ui64vARBDel ProgramUniform4ui64vARBPtr;
        
        // glProgramUniform4ui64vNV
        private delegate void ProgramUniform4ui64vNVDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniform4ui64vNVDel ProgramUniform4ui64vNVPtr;
        
        // glProgramUniform4uiEXT
        private delegate void ProgramUniform4uiEXTDel(uint  program, int  location, uint  v0, uint  v1, uint  v2, uint  v3); private static ProgramUniform4uiEXTDel ProgramUniform4uiEXTPtr;
        
        // glProgramUniform4uiv
        private delegate void ProgramUniform4uivDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform4uivDel ProgramUniform4uivPtr;
        
        // glProgramUniform4uivEXT
        private delegate void ProgramUniform4uivEXTDel(uint  program, int  location, uint  count, uint[]  value); private static ProgramUniform4uivEXTDel ProgramUniform4uivEXTPtr;
        
        // glProgramUniformHandleui64ARB
        private delegate void ProgramUniformHandleui64ARBDel(uint  program, int  location, ulong  value); private static ProgramUniformHandleui64ARBDel ProgramUniformHandleui64ARBPtr;
        
        // glProgramUniformHandleui64IMG
        private delegate void ProgramUniformHandleui64IMGDel(uint  program, int  location, ulong  value); private static ProgramUniformHandleui64IMGDel ProgramUniformHandleui64IMGPtr;
        
        // glProgramUniformHandleui64NV
        private delegate void ProgramUniformHandleui64NVDel(uint  program, int  location, ulong  value); private static ProgramUniformHandleui64NVDel ProgramUniformHandleui64NVPtr;
        
        // glProgramUniformHandleui64vARB
        private delegate void ProgramUniformHandleui64vARBDel(uint  program, int  location, uint  count, ulong[]  values); private static ProgramUniformHandleui64vARBDel ProgramUniformHandleui64vARBPtr;
        
        // glProgramUniformHandleui64vIMG
        private delegate void ProgramUniformHandleui64vIMGDel(uint  program, int  location, uint  count, ulong[]  values); private static ProgramUniformHandleui64vIMGDel ProgramUniformHandleui64vIMGPtr;
        
        // glProgramUniformHandleui64vNV
        private delegate void ProgramUniformHandleui64vNVDel(uint  program, int  location, uint  count, ulong[]  values); private static ProgramUniformHandleui64vNVDel ProgramUniformHandleui64vNVPtr;
        
        // glProgramUniformMatrix2dv
        private delegate void ProgramUniformMatrix2dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2dvDel ProgramUniformMatrix2dvPtr;
        
        // glProgramUniformMatrix2dvEXT
        private delegate void ProgramUniformMatrix2dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2dvEXTDel ProgramUniformMatrix2dvEXTPtr;
        
        // glProgramUniformMatrix2fv
        private delegate void ProgramUniformMatrix2fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2fvDel ProgramUniformMatrix2fvPtr;
        
        // glProgramUniformMatrix2fvEXT
        private delegate void ProgramUniformMatrix2fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2fvEXTDel ProgramUniformMatrix2fvEXTPtr;
        
        // glProgramUniformMatrix2x3dv
        private delegate void ProgramUniformMatrix2x3dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2x3dvDel ProgramUniformMatrix2x3dvPtr;
        
        // glProgramUniformMatrix2x3dvEXT
        private delegate void ProgramUniformMatrix2x3dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2x3dvEXTDel ProgramUniformMatrix2x3dvEXTPtr;
        
        // glProgramUniformMatrix2x3fv
        private delegate void ProgramUniformMatrix2x3fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2x3fvDel ProgramUniformMatrix2x3fvPtr;
        
        // glProgramUniformMatrix2x3fvEXT
        private delegate void ProgramUniformMatrix2x3fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2x3fvEXTDel ProgramUniformMatrix2x3fvEXTPtr;
        
        // glProgramUniformMatrix2x4dv
        private delegate void ProgramUniformMatrix2x4dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2x4dvDel ProgramUniformMatrix2x4dvPtr;
        
        // glProgramUniformMatrix2x4dvEXT
        private delegate void ProgramUniformMatrix2x4dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix2x4dvEXTDel ProgramUniformMatrix2x4dvEXTPtr;
        
        // glProgramUniformMatrix2x4fv
        private delegate void ProgramUniformMatrix2x4fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2x4fvDel ProgramUniformMatrix2x4fvPtr;
        
        // glProgramUniformMatrix2x4fvEXT
        private delegate void ProgramUniformMatrix2x4fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix2x4fvEXTDel ProgramUniformMatrix2x4fvEXTPtr;
        
        // glProgramUniformMatrix3dv
        private delegate void ProgramUniformMatrix3dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3dvDel ProgramUniformMatrix3dvPtr;
        
        // glProgramUniformMatrix3dvEXT
        private delegate void ProgramUniformMatrix3dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3dvEXTDel ProgramUniformMatrix3dvEXTPtr;
        
        // glProgramUniformMatrix3fv
        private delegate void ProgramUniformMatrix3fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3fvDel ProgramUniformMatrix3fvPtr;
        
        // glProgramUniformMatrix3fvEXT
        private delegate void ProgramUniformMatrix3fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3fvEXTDel ProgramUniformMatrix3fvEXTPtr;
        
        // glProgramUniformMatrix3x2dv
        private delegate void ProgramUniformMatrix3x2dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3x2dvDel ProgramUniformMatrix3x2dvPtr;
        
        // glProgramUniformMatrix3x2dvEXT
        private delegate void ProgramUniformMatrix3x2dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3x2dvEXTDel ProgramUniformMatrix3x2dvEXTPtr;
        
        // glProgramUniformMatrix3x2fv
        private delegate void ProgramUniformMatrix3x2fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3x2fvDel ProgramUniformMatrix3x2fvPtr;
        
        // glProgramUniformMatrix3x2fvEXT
        private delegate void ProgramUniformMatrix3x2fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3x2fvEXTDel ProgramUniformMatrix3x2fvEXTPtr;
        
        // glProgramUniformMatrix3x4dv
        private delegate void ProgramUniformMatrix3x4dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3x4dvDel ProgramUniformMatrix3x4dvPtr;
        
        // glProgramUniformMatrix3x4dvEXT
        private delegate void ProgramUniformMatrix3x4dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix3x4dvEXTDel ProgramUniformMatrix3x4dvEXTPtr;
        
        // glProgramUniformMatrix3x4fv
        private delegate void ProgramUniformMatrix3x4fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3x4fvDel ProgramUniformMatrix3x4fvPtr;
        
        // glProgramUniformMatrix3x4fvEXT
        private delegate void ProgramUniformMatrix3x4fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix3x4fvEXTDel ProgramUniformMatrix3x4fvEXTPtr;
        
        // glProgramUniformMatrix4dv
        private delegate void ProgramUniformMatrix4dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4dvDel ProgramUniformMatrix4dvPtr;
        
        // glProgramUniformMatrix4dvEXT
        private delegate void ProgramUniformMatrix4dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4dvEXTDel ProgramUniformMatrix4dvEXTPtr;
        
        // glProgramUniformMatrix4fv
        private delegate void ProgramUniformMatrix4fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4fvDel ProgramUniformMatrix4fvPtr;
        
        // glProgramUniformMatrix4fvEXT
        private delegate void ProgramUniformMatrix4fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4fvEXTDel ProgramUniformMatrix4fvEXTPtr;
        
        // glProgramUniformMatrix4x2dv
        private delegate void ProgramUniformMatrix4x2dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4x2dvDel ProgramUniformMatrix4x2dvPtr;
        
        // glProgramUniformMatrix4x2dvEXT
        private delegate void ProgramUniformMatrix4x2dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4x2dvEXTDel ProgramUniformMatrix4x2dvEXTPtr;
        
        // glProgramUniformMatrix4x2fv
        private delegate void ProgramUniformMatrix4x2fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4x2fvDel ProgramUniformMatrix4x2fvPtr;
        
        // glProgramUniformMatrix4x2fvEXT
        private delegate void ProgramUniformMatrix4x2fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4x2fvEXTDel ProgramUniformMatrix4x2fvEXTPtr;
        
        // glProgramUniformMatrix4x3dv
        private delegate void ProgramUniformMatrix4x3dvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4x3dvDel ProgramUniformMatrix4x3dvPtr;
        
        // glProgramUniformMatrix4x3dvEXT
        private delegate void ProgramUniformMatrix4x3dvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static ProgramUniformMatrix4x3dvEXTDel ProgramUniformMatrix4x3dvEXTPtr;
        
        // glProgramUniformMatrix4x3fv
        private delegate void ProgramUniformMatrix4x3fvDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4x3fvDel ProgramUniformMatrix4x3fvPtr;
        
        // glProgramUniformMatrix4x3fvEXT
        private delegate void ProgramUniformMatrix4x3fvEXTDel(uint  program, int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static ProgramUniformMatrix4x3fvEXTDel ProgramUniformMatrix4x3fvEXTPtr;
        
        // glProgramUniformui64NV
        private delegate void ProgramUniformui64NVDel(uint  program, int  location, ulong  value); private static ProgramUniformui64NVDel ProgramUniformui64NVPtr;
        
        // glProgramUniformui64vNV
        private delegate void ProgramUniformui64vNVDel(uint  program, int  location, uint  count, ulong[]  value); private static ProgramUniformui64vNVDel ProgramUniformui64vNVPtr;
        
        // glProgramVertexLimitNV
        private delegate void ProgramVertexLimitNVDel(uint /*ProgramTarget*/  target, int  limit); private static ProgramVertexLimitNVDel ProgramVertexLimitNVPtr;
        
        // glProvokingVertex
        private delegate void ProvokingVertexDel(uint /*VertexProvokingMode*/  mode); private static ProvokingVertexDel ProvokingVertexPtr;
        
        // glProvokingVertexEXT
        private delegate void ProvokingVertexEXTDel(uint /*VertexProvokingMode*/  mode); private static ProvokingVertexEXTDel ProvokingVertexEXTPtr;
        
        // glPushAttrib
        private delegate void PushAttribDel(uint /*AttribMask*/  mask); private static PushAttribDel PushAttribPtr;
        
        // glPushClientAttrib
        private delegate void PushClientAttribDel(uint /*ClientAttribMask*/  mask); private static PushClientAttribDel PushClientAttribPtr;
        
        // glPushClientAttribDefaultEXT
        private delegate void PushClientAttribDefaultEXTDel(uint /*ClientAttribMask*/  mask); private static PushClientAttribDefaultEXTDel PushClientAttribDefaultEXTPtr;
        
        // glPushDebugGroup
        private delegate void PushDebugGroupDel(uint /*DebugSource*/  source, uint  id, uint  length, string  message); private static PushDebugGroupDel PushDebugGroupPtr;
        
        // glPushDebugGroupKHR
        private delegate void PushDebugGroupKHRDel(uint /*DebugSource*/  source, uint  id, uint  length, string  message); private static PushDebugGroupKHRDel PushDebugGroupKHRPtr;
        
        // glPushGroupMarkerEXT
        private delegate void PushGroupMarkerEXTDel(uint  length, string  marker); private static PushGroupMarkerEXTDel PushGroupMarkerEXTPtr;
        
        // glPushMatrix
        private delegate void PushMatrixDel(); private static PushMatrixDel PushMatrixPtr;
        
        // glPushName
        private delegate void PushNameDel(uint /*SelectName*/  name); private static PushNameDel PushNamePtr;
        
        // glQueryCounter
        private delegate void QueryCounterDel(uint  id, uint /*QueryCounterTarget*/  target); private static QueryCounterDel QueryCounterPtr;
        
        // glQueryCounterEXT
        private delegate void QueryCounterEXTDel(uint  id, uint /*QueryCounterTarget*/  target); private static QueryCounterEXTDel QueryCounterEXTPtr;
        
        // glQueryMatrixxOES
        private delegate uint QueryMatrixxOESDel(int[]  mantissa, int[]  exponent); private static QueryMatrixxOESDel QueryMatrixxOESPtr;
        
        // glQueryObjectParameteruiAMD
        private delegate void QueryObjectParameteruiAMDDel(uint /*QueryTarget*/  target, uint  id, uint  pname, uint /*OcclusionQueryEventMaskAMD*/  param); private static QueryObjectParameteruiAMDDel QueryObjectParameteruiAMDPtr;
        
        // glQueryResourceNV
        private delegate int QueryResourceNVDel(uint  queryType, int  tagId, uint  count, int[]  buffer); private static QueryResourceNVDel QueryResourceNVPtr;
        
        // glQueryResourceTagNV
        private delegate void QueryResourceTagNVDel(int  tagId, string  tagString); private static QueryResourceTagNVDel QueryResourceTagNVPtr;
        
        // glRasterPos2d
        private delegate void RasterPos2dDel(double /*CoordD*/  x, double /*CoordD*/  y); private static RasterPos2dDel RasterPos2dPtr;
        
        // glRasterPos2dv
        private delegate void RasterPos2dvDel(double[] /*CoordD*/  v); private static RasterPos2dvDel RasterPos2dvPtr;
        
        // glRasterPos2f
        private delegate void RasterPos2fDel(float /*CoordF*/  x, float /*CoordF*/  y); private static RasterPos2fDel RasterPos2fPtr;
        
        // glRasterPos2fv
        private delegate void RasterPos2fvDel(float[] /*CoordF*/  v); private static RasterPos2fvDel RasterPos2fvPtr;
        
        // glRasterPos2i
        private delegate void RasterPos2iDel(int /*CoordI*/  x, int /*CoordI*/  y); private static RasterPos2iDel RasterPos2iPtr;
        
        // glRasterPos2iv
        private delegate void RasterPos2ivDel(int[] /*CoordI*/  v); private static RasterPos2ivDel RasterPos2ivPtr;
        
        // glRasterPos2s
        private delegate void RasterPos2sDel(short /*CoordS*/  x, short /*CoordS*/  y); private static RasterPos2sDel RasterPos2sPtr;
        
        // glRasterPos2sv
        private delegate void RasterPos2svDel(short[] /*CoordS*/  v); private static RasterPos2svDel RasterPos2svPtr;
        
        // glRasterPos2xOES
        private delegate void RasterPos2xOESDel(int  x, int  y); private static RasterPos2xOESDel RasterPos2xOESPtr;
        
        // glRasterPos2xvOES
        private delegate void RasterPos2xvOESDel(int[]  coords); private static RasterPos2xvOESDel RasterPos2xvOESPtr;
        
        // glRasterPos3d
        private delegate void RasterPos3dDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z); private static RasterPos3dDel RasterPos3dPtr;
        
        // glRasterPos3dv
        private delegate void RasterPos3dvDel(double[] /*CoordD*/  v); private static RasterPos3dvDel RasterPos3dvPtr;
        
        // glRasterPos3f
        private delegate void RasterPos3fDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z); private static RasterPos3fDel RasterPos3fPtr;
        
        // glRasterPos3fv
        private delegate void RasterPos3fvDel(float[] /*CoordF*/  v); private static RasterPos3fvDel RasterPos3fvPtr;
        
        // glRasterPos3i
        private delegate void RasterPos3iDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z); private static RasterPos3iDel RasterPos3iPtr;
        
        // glRasterPos3iv
        private delegate void RasterPos3ivDel(int[] /*CoordI*/  v); private static RasterPos3ivDel RasterPos3ivPtr;
        
        // glRasterPos3s
        private delegate void RasterPos3sDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z); private static RasterPos3sDel RasterPos3sPtr;
        
        // glRasterPos3sv
        private delegate void RasterPos3svDel(short[] /*CoordS*/  v); private static RasterPos3svDel RasterPos3svPtr;
        
        // glRasterPos3xOES
        private delegate void RasterPos3xOESDel(int  x, int  y, int  z); private static RasterPos3xOESDel RasterPos3xOESPtr;
        
        // glRasterPos3xvOES
        private delegate void RasterPos3xvOESDel(int[]  coords); private static RasterPos3xvOESDel RasterPos3xvOESPtr;
        
        // glRasterPos4d
        private delegate void RasterPos4dDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z, double /*CoordD*/  w); private static RasterPos4dDel RasterPos4dPtr;
        
        // glRasterPos4dv
        private delegate void RasterPos4dvDel(double[] /*CoordD*/  v); private static RasterPos4dvDel RasterPos4dvPtr;
        
        // glRasterPos4f
        private delegate void RasterPos4fDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z, float /*CoordF*/  w); private static RasterPos4fDel RasterPos4fPtr;
        
        // glRasterPos4fv
        private delegate void RasterPos4fvDel(float[] /*CoordF*/  v); private static RasterPos4fvDel RasterPos4fvPtr;
        
        // glRasterPos4i
        private delegate void RasterPos4iDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z, int /*CoordI*/  w); private static RasterPos4iDel RasterPos4iPtr;
        
        // glRasterPos4iv
        private delegate void RasterPos4ivDel(int[] /*CoordI*/  v); private static RasterPos4ivDel RasterPos4ivPtr;
        
        // glRasterPos4s
        private delegate void RasterPos4sDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z, short /*CoordS*/  w); private static RasterPos4sDel RasterPos4sPtr;
        
        // glRasterPos4sv
        private delegate void RasterPos4svDel(short[] /*CoordS*/  v); private static RasterPos4svDel RasterPos4svPtr;
        
        // glRasterPos4xOES
        private delegate void RasterPos4xOESDel(int  x, int  y, int  z, int  w); private static RasterPos4xOESDel RasterPos4xOESPtr;
        
        // glRasterPos4xvOES
        private delegate void RasterPos4xvOESDel(int[]  coords); private static RasterPos4xvOESDel RasterPos4xvOESPtr;
        
        // glRasterSamplesEXT
        private delegate void RasterSamplesEXTDel(uint  samples, bool /*Boolean*/  fixedsamplelocations); private static RasterSamplesEXTDel RasterSamplesEXTPtr;
        
        // glReadBuffer
        private delegate void ReadBufferDel(uint /*ReadBufferMode*/  src); private static ReadBufferDel ReadBufferPtr;
        
        // glReadBufferIndexedEXT
        private delegate void ReadBufferIndexedEXTDel(uint /*ReadBufferMode*/  src, int  index); private static ReadBufferIndexedEXTDel ReadBufferIndexedEXTPtr;
        
        // glReadBufferNV
        private delegate void ReadBufferNVDel(uint  mode); private static ReadBufferNVDel ReadBufferNVPtr;
        
        // glReadInstrumentsSGIX
        private delegate void ReadInstrumentsSGIXDel(int  marker); private static ReadInstrumentsSGIXDel ReadInstrumentsSGIXPtr;
        
        // glReadPixels
        private delegate void ReadPixelsDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static ReadPixelsDel ReadPixelsPtr;
        
        // glReadnPixels
        private delegate void ReadnPixelsDel(int  x, int  y, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  data); private static ReadnPixelsDel ReadnPixelsPtr;
        
        // glReadnPixelsARB
        private delegate void ReadnPixelsARBDel(int  x, int  y, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  data); private static ReadnPixelsARBDel ReadnPixelsARBPtr;
        
        // glReadnPixelsEXT
        private delegate void ReadnPixelsEXTDel(int  x, int  y, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  data); private static ReadnPixelsEXTDel ReadnPixelsEXTPtr;
        
        // glReadnPixelsKHR
        private delegate void ReadnPixelsKHRDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, uint  bufSize, IntPtr  data); private static ReadnPixelsKHRDel ReadnPixelsKHRPtr;
        
        // glReleaseKeyedMutexWin32EXT
        private delegate bool /*Boolean*/ ReleaseKeyedMutexWin32EXTDel(uint  memory, ulong  key); private static ReleaseKeyedMutexWin32EXTDel ReleaseKeyedMutexWin32EXTPtr;
        
        // glRectd
        private delegate void RectdDel(double /*CoordD*/  x1, double /*CoordD*/  y1, double /*CoordD*/  x2, double /*CoordD*/  y2); private static RectdDel RectdPtr;
        
        // glRectdv
        private delegate void RectdvDel(double[] /*CoordD*/  v1, double[] /*CoordD*/  v2); private static RectdvDel RectdvPtr;
        
        // glRectf
        private delegate void RectfDel(float /*CoordF*/  x1, float /*CoordF*/  y1, float /*CoordF*/  x2, float /*CoordF*/  y2); private static RectfDel RectfPtr;
        
        // glRectfv
        private delegate void RectfvDel(float[] /*CoordF*/  v1, float[] /*CoordF*/  v2); private static RectfvDel RectfvPtr;
        
        // glRecti
        private delegate void RectiDel(int /*CoordI*/  x1, int /*CoordI*/  y1, int /*CoordI*/  x2, int /*CoordI*/  y2); private static RectiDel RectiPtr;
        
        // glRectiv
        private delegate void RectivDel(int[] /*CoordI*/  v1, int[] /*CoordI*/  v2); private static RectivDel RectivPtr;
        
        // glRects
        private delegate void RectsDel(short /*CoordS*/  x1, short /*CoordS*/  y1, short /*CoordS*/  x2, short /*CoordS*/  y2); private static RectsDel RectsPtr;
        
        // glRectsv
        private delegate void RectsvDel(short[] /*CoordS*/  v1, short[] /*CoordS*/  v2); private static RectsvDel RectsvPtr;
        
        // glRectxOES
        private delegate void RectxOESDel(int  x1, int  y1, int  x2, int  y2); private static RectxOESDel RectxOESPtr;
        
        // glRectxvOES
        private delegate void RectxvOESDel(int[]  v1, int[]  v2); private static RectxvOESDel RectxvOESPtr;
        
        // glReferencePlaneSGIX
        private delegate void ReferencePlaneSGIXDel(double[]  equation); private static ReferencePlaneSGIXDel ReferencePlaneSGIXPtr;
        
        // glReleaseShaderCompiler
        private delegate void ReleaseShaderCompilerDel(); private static ReleaseShaderCompilerDel ReleaseShaderCompilerPtr;
        
        // glRenderGpuMaskNV
        private delegate void RenderGpuMaskNVDel(uint  mask); private static RenderGpuMaskNVDel RenderGpuMaskNVPtr;
        
        // glRenderMode
        private delegate int RenderModeDel(uint /*RenderingMode*/  mode); private static RenderModeDel RenderModePtr;
        
        // glRenderbufferStorage
        private delegate void RenderbufferStorageDel(uint /*RenderbufferTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageDel RenderbufferStoragePtr;
        
        // glRenderbufferStorageEXT
        private delegate void RenderbufferStorageEXTDel(uint /*RenderbufferTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageEXTDel RenderbufferStorageEXTPtr;
        
        // glRenderbufferStorageMultisample
        private delegate void RenderbufferStorageMultisampleDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleDel RenderbufferStorageMultisamplePtr;
        
        // glRenderbufferStorageMultisampleANGLE
        private delegate void RenderbufferStorageMultisampleANGLEDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleANGLEDel RenderbufferStorageMultisampleANGLEPtr;
        
        // glRenderbufferStorageMultisampleAPPLE
        private delegate void RenderbufferStorageMultisampleAPPLEDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleAPPLEDel RenderbufferStorageMultisampleAPPLEPtr;
        
        // glRenderbufferStorageMultisampleAdvancedAMD
        private delegate void RenderbufferStorageMultisampleAdvancedAMDDel(uint /*RenderbufferTarget*/  target, uint  samples, uint  storageSamples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleAdvancedAMDDel RenderbufferStorageMultisampleAdvancedAMDPtr;
        
        // glRenderbufferStorageMultisampleCoverageNV
        private delegate void RenderbufferStorageMultisampleCoverageNVDel(uint /*RenderbufferTarget*/  target, uint  coverageSamples, uint  colorSamples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleCoverageNVDel RenderbufferStorageMultisampleCoverageNVPtr;
        
        // glRenderbufferStorageMultisampleEXT
        private delegate void RenderbufferStorageMultisampleEXTDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleEXTDel RenderbufferStorageMultisampleEXTPtr;
        
        // glRenderbufferStorageMultisampleIMG
        private delegate void RenderbufferStorageMultisampleIMGDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleIMGDel RenderbufferStorageMultisampleIMGPtr;
        
        // glRenderbufferStorageMultisampleNV
        private delegate void RenderbufferStorageMultisampleNVDel(uint /*RenderbufferTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageMultisampleNVDel RenderbufferStorageMultisampleNVPtr;
        
        // glRenderbufferStorageOES
        private delegate void RenderbufferStorageOESDel(uint /*RenderbufferTarget*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static RenderbufferStorageOESDel RenderbufferStorageOESPtr;
        
        // glReplacementCodePointerSUN
        private delegate void ReplacementCodePointerSUNDel(uint /*ReplacementCodeTypeSUN*/  type, uint  stride, IntPtr  pointer); private static ReplacementCodePointerSUNDel ReplacementCodePointerSUNPtr;
        
        // glReplacementCodeubSUN
        private delegate void ReplacementCodeubSUNDel(byte  code); private static ReplacementCodeubSUNDel ReplacementCodeubSUNPtr;
        
        // glReplacementCodeubvSUN
        private delegate void ReplacementCodeubvSUNDel(byte[]  code); private static ReplacementCodeubvSUNDel ReplacementCodeubvSUNPtr;
        
        // glReplacementCodeuiColor3fVertex3fSUN
        private delegate void ReplacementCodeuiColor3fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  r, float  g, float  b, float  x, float  y, float  z); private static ReplacementCodeuiColor3fVertex3fSUNDel ReplacementCodeuiColor3fVertex3fSUNPtr;
        
        // glReplacementCodeuiColor3fVertex3fvSUN
        private delegate void ReplacementCodeuiColor3fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  c, float[]  v); private static ReplacementCodeuiColor3fVertex3fvSUNDel ReplacementCodeuiColor3fVertex3fvSUNPtr;
        
        // glReplacementCodeuiColor4fNormal3fVertex3fSUN
        private delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  r, float  g, float  b, float  a, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static ReplacementCodeuiColor4fNormal3fVertex3fSUNDel ReplacementCodeuiColor4fNormal3fVertex3fSUNPtr;
        
        // glReplacementCodeuiColor4fNormal3fVertex3fvSUN
        private delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  c, float[]  n, float[]  v); private static ReplacementCodeuiColor4fNormal3fVertex3fvSUNDel ReplacementCodeuiColor4fNormal3fVertex3fvSUNPtr;
        
        // glReplacementCodeuiColor4ubVertex3fSUN
        private delegate void ReplacementCodeuiColor4ubVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, byte  r, byte  g, byte  b, byte  a, float  x, float  y, float  z); private static ReplacementCodeuiColor4ubVertex3fSUNDel ReplacementCodeuiColor4ubVertex3fSUNPtr;
        
        // glReplacementCodeuiColor4ubVertex3fvSUN
        private delegate void ReplacementCodeuiColor4ubVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, byte[]  c, float[]  v); private static ReplacementCodeuiColor4ubVertex3fvSUNDel ReplacementCodeuiColor4ubVertex3fvSUNPtr;
        
        // glReplacementCodeuiNormal3fVertex3fSUN
        private delegate void ReplacementCodeuiNormal3fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static ReplacementCodeuiNormal3fVertex3fSUNDel ReplacementCodeuiNormal3fVertex3fSUNPtr;
        
        // glReplacementCodeuiNormal3fVertex3fvSUN
        private delegate void ReplacementCodeuiNormal3fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  n, float[]  v); private static ReplacementCodeuiNormal3fVertex3fvSUNDel ReplacementCodeuiNormal3fVertex3fvSUNPtr;
        
        // glReplacementCodeuiSUN
        private delegate void ReplacementCodeuiSUNDel(uint  code); private static ReplacementCodeuiSUNDel ReplacementCodeuiSUNPtr;
        
        // glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN
        private delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  s, float  t, float  r, float  g, float  b, float  a, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUNDel ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUNPtr;
        
        // glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN
        private delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  tc, float[]  c, float[]  n, float[]  v); private static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUNDel ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUNPtr;
        
        // glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN
        private delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  s, float  t, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUNDel ReplacementCodeuiTexCoord2fNormal3fVertex3fSUNPtr;
        
        // glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN
        private delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  tc, float[]  n, float[]  v); private static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUNDel ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUNPtr;
        
        // glReplacementCodeuiTexCoord2fVertex3fSUN
        private delegate void ReplacementCodeuiTexCoord2fVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  s, float  t, float  x, float  y, float  z); private static ReplacementCodeuiTexCoord2fVertex3fSUNDel ReplacementCodeuiTexCoord2fVertex3fSUNPtr;
        
        // glReplacementCodeuiTexCoord2fVertex3fvSUN
        private delegate void ReplacementCodeuiTexCoord2fVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  tc, float[]  v); private static ReplacementCodeuiTexCoord2fVertex3fvSUNDel ReplacementCodeuiTexCoord2fVertex3fvSUNPtr;
        
        // glReplacementCodeuiVertex3fSUN
        private delegate void ReplacementCodeuiVertex3fSUNDel(uint /*ReplacementCodeSUN*/  rc, float  x, float  y, float  z); private static ReplacementCodeuiVertex3fSUNDel ReplacementCodeuiVertex3fSUNPtr;
        
        // glReplacementCodeuiVertex3fvSUN
        private delegate void ReplacementCodeuiVertex3fvSUNDel(uint[] /*ReplacementCodeSUN*/  rc, float[]  v); private static ReplacementCodeuiVertex3fvSUNDel ReplacementCodeuiVertex3fvSUNPtr;
        
        // glReplacementCodeuivSUN
        private delegate void ReplacementCodeuivSUNDel(uint[]  code); private static ReplacementCodeuivSUNDel ReplacementCodeuivSUNPtr;
        
        // glReplacementCodeusSUN
        private delegate void ReplacementCodeusSUNDel(ushort  code); private static ReplacementCodeusSUNDel ReplacementCodeusSUNPtr;
        
        // glReplacementCodeusvSUN
        private delegate void ReplacementCodeusvSUNDel(ushort[]  code); private static ReplacementCodeusvSUNDel ReplacementCodeusvSUNPtr;
        
        // glRequestResidentProgramsNV
        private delegate void RequestResidentProgramsNVDel(uint  n, uint[]  programs); private static RequestResidentProgramsNVDel RequestResidentProgramsNVPtr;
        
        // glResetHistogram
        private delegate void ResetHistogramDel(uint /*HistogramTargetEXT*/  target); private static ResetHistogramDel ResetHistogramPtr;
        
        // glResetHistogramEXT
        private delegate void ResetHistogramEXTDel(uint /*HistogramTargetEXT*/  target); private static ResetHistogramEXTDel ResetHistogramEXTPtr;
        
        // glResetMemoryObjectParameterNV
        private delegate void ResetMemoryObjectParameterNVDel(uint  memory, uint  pname); private static ResetMemoryObjectParameterNVDel ResetMemoryObjectParameterNVPtr;
        
        // glResetMinmax
        private delegate void ResetMinmaxDel(uint /*MinmaxTargetEXT*/  target); private static ResetMinmaxDel ResetMinmaxPtr;
        
        // glResetMinmaxEXT
        private delegate void ResetMinmaxEXTDel(uint /*MinmaxTargetEXT*/  target); private static ResetMinmaxEXTDel ResetMinmaxEXTPtr;
        
        // glResizeBuffersMESA
        private delegate void ResizeBuffersMESADel(); private static ResizeBuffersMESADel ResizeBuffersMESAPtr;
        
        // glResolveDepthValuesNV
        private delegate void ResolveDepthValuesNVDel(); private static ResolveDepthValuesNVDel ResolveDepthValuesNVPtr;
        
        // glResolveMultisampleFramebufferAPPLE
        private delegate void ResolveMultisampleFramebufferAPPLEDel(); private static ResolveMultisampleFramebufferAPPLEDel ResolveMultisampleFramebufferAPPLEPtr;
        
        // glResumeTransformFeedback
        private delegate void ResumeTransformFeedbackDel(); private static ResumeTransformFeedbackDel ResumeTransformFeedbackPtr;
        
        // glResumeTransformFeedbackNV
        private delegate void ResumeTransformFeedbackNVDel(); private static ResumeTransformFeedbackNVDel ResumeTransformFeedbackNVPtr;
        
        // glRotated
        private delegate void RotatedDel(double  angle, double  x, double  y, double  z); private static RotatedDel RotatedPtr;
        
        // glRotatef
        private delegate void RotatefDel(float  angle, float  x, float  y, float  z); private static RotatefDel RotatefPtr;
        
        // glRotatex
        private delegate void RotatexDel(int  angle, int  x, int  y, int  z); private static RotatexDel RotatexPtr;
        
        // glRotatexOES
        private delegate void RotatexOESDel(int  angle, int  x, int  y, int  z); private static RotatexOESDel RotatexOESPtr;
        
        // glSampleCoverage
        private delegate void SampleCoverageDel(float  value, bool /*Boolean*/  invert); private static SampleCoverageDel SampleCoveragePtr;
        
        // glSampleCoverageARB
        private delegate void SampleCoverageARBDel(float  value, bool /*Boolean*/  invert); private static SampleCoverageARBDel SampleCoverageARBPtr;
        
        // glSampleCoveragex
        private delegate void SampleCoveragexDel(int /*GLclampx*/  value, bool /*Boolean*/  invert); private static SampleCoveragexDel SampleCoveragexPtr;
        
        // glSampleCoveragexOES
        private delegate void SampleCoveragexOESDel(int /*GLclampx*/  value, bool /*Boolean*/  invert); private static SampleCoveragexOESDel SampleCoveragexOESPtr;
        
        // glSampleMapATI
        private delegate void SampleMapATIDel(uint  dst, uint  interp, uint /*SwizzleOpATI*/  swizzle); private static SampleMapATIDel SampleMapATIPtr;
        
        // glSampleMaskEXT
        private delegate void SampleMaskEXTDel(float /*ClampedFloat32*/  value, bool /*Boolean*/  invert); private static SampleMaskEXTDel SampleMaskEXTPtr;
        
        // glSampleMaskIndexedNV
        private delegate void SampleMaskIndexedNVDel(uint  index, uint /*SampleMaskNV*/  mask); private static SampleMaskIndexedNVDel SampleMaskIndexedNVPtr;
        
        // glSampleMaskSGIS
        private delegate void SampleMaskSGISDel(float /*ClampedFloat32*/  value, bool /*Boolean*/  invert); private static SampleMaskSGISDel SampleMaskSGISPtr;
        
        // glSampleMaski
        private delegate void SampleMaskiDel(uint  maskNumber, uint  mask); private static SampleMaskiDel SampleMaskiPtr;
        
        // glSamplePatternEXT
        private delegate void SamplePatternEXTDel(uint /*SamplePatternEXT*/  pattern); private static SamplePatternEXTDel SamplePatternEXTPtr;
        
        // glSamplePatternSGIS
        private delegate void SamplePatternSGISDel(uint /*SamplePatternSGIS*/  pattern); private static SamplePatternSGISDel SamplePatternSGISPtr;
        
        // glSamplerParameterIiv
        private delegate void SamplerParameterIivDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  param); private static SamplerParameterIivDel SamplerParameterIivPtr;
        
        // glSamplerParameterIivEXT
        private delegate void SamplerParameterIivEXTDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  param); private static SamplerParameterIivEXTDel SamplerParameterIivEXTPtr;
        
        // glSamplerParameterIivOES
        private delegate void SamplerParameterIivOESDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  param); private static SamplerParameterIivOESDel SamplerParameterIivOESPtr;
        
        // glSamplerParameterIuiv
        private delegate void SamplerParameterIuivDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  param); private static SamplerParameterIuivDel SamplerParameterIuivPtr;
        
        // glSamplerParameterIuivEXT
        private delegate void SamplerParameterIuivEXTDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  param); private static SamplerParameterIuivEXTDel SamplerParameterIuivEXTPtr;
        
        // glSamplerParameterIuivOES
        private delegate void SamplerParameterIuivOESDel(uint  sampler, uint /*SamplerParameterI*/  pname, uint[]  param); private static SamplerParameterIuivOESDel SamplerParameterIuivOESPtr;
        
        // glSamplerParameterf
        private delegate void SamplerParameterfDel(uint  sampler, uint /*SamplerParameterF*/  pname, float  param); private static SamplerParameterfDel SamplerParameterfPtr;
        
        // glSamplerParameterfv
        private delegate void SamplerParameterfvDel(uint  sampler, uint /*SamplerParameterF*/  pname, float[]  param); private static SamplerParameterfvDel SamplerParameterfvPtr;
        
        // glSamplerParameteri
        private delegate void SamplerParameteriDel(uint  sampler, uint /*SamplerParameterI*/  pname, int  param); private static SamplerParameteriDel SamplerParameteriPtr;
        
        // glSamplerParameteriv
        private delegate void SamplerParameterivDel(uint  sampler, uint /*SamplerParameterI*/  pname, int[]  param); private static SamplerParameterivDel SamplerParameterivPtr;
        
        // glScaled
        private delegate void ScaledDel(double  x, double  y, double  z); private static ScaledDel ScaledPtr;
        
        // glScalef
        private delegate void ScalefDel(float  x, float  y, float  z); private static ScalefDel ScalefPtr;
        
        // glScalex
        private delegate void ScalexDel(int  x, int  y, int  z); private static ScalexDel ScalexPtr;
        
        // glScalexOES
        private delegate void ScalexOESDel(int  x, int  y, int  z); private static ScalexOESDel ScalexOESPtr;
        
        // glScissor
        private delegate void ScissorDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static ScissorDel ScissorPtr;
        
        // glScissorArrayv
        private delegate void ScissorArrayvDel(uint  first, uint  count, int[]  v); private static ScissorArrayvDel ScissorArrayvPtr;
        
        // glScissorArrayvNV
        private delegate void ScissorArrayvNVDel(uint  first, uint  count, int[]  v); private static ScissorArrayvNVDel ScissorArrayvNVPtr;
        
        // glScissorArrayvOES
        private delegate void ScissorArrayvOESDel(uint  first, uint  count, int[]  v); private static ScissorArrayvOESDel ScissorArrayvOESPtr;
        
        // glScissorExclusiveArrayvNV
        private delegate void ScissorExclusiveArrayvNVDel(uint  first, uint  count, int[]  v); private static ScissorExclusiveArrayvNVDel ScissorExclusiveArrayvNVPtr;
        
        // glScissorExclusiveNV
        private delegate void ScissorExclusiveNVDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static ScissorExclusiveNVDel ScissorExclusiveNVPtr;
        
        // glScissorIndexed
        private delegate void ScissorIndexedDel(uint  index, int  left, int  bottom, uint  width, uint  height); private static ScissorIndexedDel ScissorIndexedPtr;
        
        // glScissorIndexedNV
        private delegate void ScissorIndexedNVDel(uint  index, int  left, int  bottom, uint  width, uint  height); private static ScissorIndexedNVDel ScissorIndexedNVPtr;
        
        // glScissorIndexedOES
        private delegate void ScissorIndexedOESDel(uint  index, int  left, int  bottom, uint  width, uint  height); private static ScissorIndexedOESDel ScissorIndexedOESPtr;
        
        // glScissorIndexedv
        private delegate void ScissorIndexedvDel(uint  index, int[]  v); private static ScissorIndexedvDel ScissorIndexedvPtr;
        
        // glScissorIndexedvNV
        private delegate void ScissorIndexedvNVDel(uint  index, int[]  v); private static ScissorIndexedvNVDel ScissorIndexedvNVPtr;
        
        // glScissorIndexedvOES
        private delegate void ScissorIndexedvOESDel(uint  index, int[]  v); private static ScissorIndexedvOESDel ScissorIndexedvOESPtr;
        
        // glSecondaryColor3b
        private delegate void SecondaryColor3bDel(sbyte /*ColorB*/  red, sbyte /*ColorB*/  green, sbyte /*ColorB*/  blue); private static SecondaryColor3bDel SecondaryColor3bPtr;
        
        // glSecondaryColor3bEXT
        private delegate void SecondaryColor3bEXTDel(sbyte /*ColorB*/  red, sbyte /*ColorB*/  green, sbyte /*ColorB*/  blue); private static SecondaryColor3bEXTDel SecondaryColor3bEXTPtr;
        
        // glSecondaryColor3bv
        private delegate void SecondaryColor3bvDel(sbyte[] /*ColorB*/  v); private static SecondaryColor3bvDel SecondaryColor3bvPtr;
        
        // glSecondaryColor3bvEXT
        private delegate void SecondaryColor3bvEXTDel(sbyte[] /*ColorB*/  v); private static SecondaryColor3bvEXTDel SecondaryColor3bvEXTPtr;
        
        // glSecondaryColor3d
        private delegate void SecondaryColor3dDel(double /*ColorD*/  red, double /*ColorD*/  green, double /*ColorD*/  blue); private static SecondaryColor3dDel SecondaryColor3dPtr;
        
        // glSecondaryColor3dEXT
        private delegate void SecondaryColor3dEXTDel(double /*ColorD*/  red, double /*ColorD*/  green, double /*ColorD*/  blue); private static SecondaryColor3dEXTDel SecondaryColor3dEXTPtr;
        
        // glSecondaryColor3dv
        private delegate void SecondaryColor3dvDel(double[] /*ColorD*/  v); private static SecondaryColor3dvDel SecondaryColor3dvPtr;
        
        // glSecondaryColor3dvEXT
        private delegate void SecondaryColor3dvEXTDel(double[] /*ColorD*/  v); private static SecondaryColor3dvEXTDel SecondaryColor3dvEXTPtr;
        
        // glSecondaryColor3f
        private delegate void SecondaryColor3fDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue); private static SecondaryColor3fDel SecondaryColor3fPtr;
        
        // glSecondaryColor3fEXT
        private delegate void SecondaryColor3fEXTDel(float /*ColorF*/  red, float /*ColorF*/  green, float /*ColorF*/  blue); private static SecondaryColor3fEXTDel SecondaryColor3fEXTPtr;
        
        // glSecondaryColor3fv
        private delegate void SecondaryColor3fvDel(float[] /*ColorF*/  v); private static SecondaryColor3fvDel SecondaryColor3fvPtr;
        
        // glSecondaryColor3fvEXT
        private delegate void SecondaryColor3fvEXTDel(float[] /*ColorF*/  v); private static SecondaryColor3fvEXTDel SecondaryColor3fvEXTPtr;
        
        // glSecondaryColor3hNV
        private delegate void SecondaryColor3hNVDel(ushort /*Half16NV*/  red, ushort /*Half16NV*/  green, ushort /*Half16NV*/  blue); private static SecondaryColor3hNVDel SecondaryColor3hNVPtr;
        
        // glSecondaryColor3hvNV
        private delegate void SecondaryColor3hvNVDel(ushort[] /*Half16NV*/  v); private static SecondaryColor3hvNVDel SecondaryColor3hvNVPtr;
        
        // glSecondaryColor3i
        private delegate void SecondaryColor3iDel(int /*ColorI*/  red, int /*ColorI*/  green, int /*ColorI*/  blue); private static SecondaryColor3iDel SecondaryColor3iPtr;
        
        // glSecondaryColor3iEXT
        private delegate void SecondaryColor3iEXTDel(int /*ColorI*/  red, int /*ColorI*/  green, int /*ColorI*/  blue); private static SecondaryColor3iEXTDel SecondaryColor3iEXTPtr;
        
        // glSecondaryColor3iv
        private delegate void SecondaryColor3ivDel(int[] /*ColorI*/  v); private static SecondaryColor3ivDel SecondaryColor3ivPtr;
        
        // glSecondaryColor3ivEXT
        private delegate void SecondaryColor3ivEXTDel(int[] /*ColorI*/  v); private static SecondaryColor3ivEXTDel SecondaryColor3ivEXTPtr;
        
        // glSecondaryColor3s
        private delegate void SecondaryColor3sDel(short /*ColorS*/  red, short /*ColorS*/  green, short /*ColorS*/  blue); private static SecondaryColor3sDel SecondaryColor3sPtr;
        
        // glSecondaryColor3sEXT
        private delegate void SecondaryColor3sEXTDel(short /*ColorS*/  red, short /*ColorS*/  green, short /*ColorS*/  blue); private static SecondaryColor3sEXTDel SecondaryColor3sEXTPtr;
        
        // glSecondaryColor3sv
        private delegate void SecondaryColor3svDel(short[] /*ColorS*/  v); private static SecondaryColor3svDel SecondaryColor3svPtr;
        
        // glSecondaryColor3svEXT
        private delegate void SecondaryColor3svEXTDel(short[] /*ColorS*/  v); private static SecondaryColor3svEXTDel SecondaryColor3svEXTPtr;
        
        // glSecondaryColor3ub
        private delegate void SecondaryColor3ubDel(byte /*ColorUB*/  red, byte /*ColorUB*/  green, byte /*ColorUB*/  blue); private static SecondaryColor3ubDel SecondaryColor3ubPtr;
        
        // glSecondaryColor3ubEXT
        private delegate void SecondaryColor3ubEXTDel(byte /*ColorUB*/  red, byte /*ColorUB*/  green, byte /*ColorUB*/  blue); private static SecondaryColor3ubEXTDel SecondaryColor3ubEXTPtr;
        
        // glSecondaryColor3ubv
        private delegate void SecondaryColor3ubvDel(byte[] /*ColorUB*/  v); private static SecondaryColor3ubvDel SecondaryColor3ubvPtr;
        
        // glSecondaryColor3ubvEXT
        private delegate void SecondaryColor3ubvEXTDel(byte[] /*ColorUB*/  v); private static SecondaryColor3ubvEXTDel SecondaryColor3ubvEXTPtr;
        
        // glSecondaryColor3ui
        private delegate void SecondaryColor3uiDel(uint /*ColorUI*/  red, uint /*ColorUI*/  green, uint /*ColorUI*/  blue); private static SecondaryColor3uiDel SecondaryColor3uiPtr;
        
        // glSecondaryColor3uiEXT
        private delegate void SecondaryColor3uiEXTDel(uint /*ColorUI*/  red, uint /*ColorUI*/  green, uint /*ColorUI*/  blue); private static SecondaryColor3uiEXTDel SecondaryColor3uiEXTPtr;
        
        // glSecondaryColor3uiv
        private delegate void SecondaryColor3uivDel(uint[] /*ColorUI*/  v); private static SecondaryColor3uivDel SecondaryColor3uivPtr;
        
        // glSecondaryColor3uivEXT
        private delegate void SecondaryColor3uivEXTDel(uint[] /*ColorUI*/  v); private static SecondaryColor3uivEXTDel SecondaryColor3uivEXTPtr;
        
        // glSecondaryColor3us
        private delegate void SecondaryColor3usDel(ushort /*ColorUS*/  red, ushort /*ColorUS*/  green, ushort /*ColorUS*/  blue); private static SecondaryColor3usDel SecondaryColor3usPtr;
        
        // glSecondaryColor3usEXT
        private delegate void SecondaryColor3usEXTDel(ushort /*ColorUS*/  red, ushort /*ColorUS*/  green, ushort /*ColorUS*/  blue); private static SecondaryColor3usEXTDel SecondaryColor3usEXTPtr;
        
        // glSecondaryColor3usv
        private delegate void SecondaryColor3usvDel(ushort[] /*ColorUS*/  v); private static SecondaryColor3usvDel SecondaryColor3usvPtr;
        
        // glSecondaryColor3usvEXT
        private delegate void SecondaryColor3usvEXTDel(ushort[] /*ColorUS*/  v); private static SecondaryColor3usvEXTDel SecondaryColor3usvEXTPtr;
        
        // glSecondaryColorFormatNV
        private delegate void SecondaryColorFormatNVDel(int  size, uint /*ColorPointerType*/  type, uint  stride); private static SecondaryColorFormatNVDel SecondaryColorFormatNVPtr;
        
        // glSecondaryColorP3ui
        private delegate void SecondaryColorP3uiDel(uint /*ColorPointerType*/  type, uint  color); private static SecondaryColorP3uiDel SecondaryColorP3uiPtr;
        
        // glSecondaryColorP3uiv
        private delegate void SecondaryColorP3uivDel(uint /*ColorPointerType*/  type, uint[]  color); private static SecondaryColorP3uivDel SecondaryColorP3uivPtr;
        
        // glSecondaryColorPointer
        private delegate void SecondaryColorPointerDel(int  size, uint /*ColorPointerType*/  type, uint  stride, IntPtr  pointer); private static SecondaryColorPointerDel SecondaryColorPointerPtr;
        
        // glSecondaryColorPointerEXT
        private delegate void SecondaryColorPointerEXTDel(int  size, uint /*ColorPointerType*/  type, uint  stride, IntPtr  pointer); private static SecondaryColorPointerEXTDel SecondaryColorPointerEXTPtr;
        
        // glSecondaryColorPointerListIBM
        private delegate void SecondaryColorPointerListIBMDel(int  size, uint /*SecondaryColorPointerTypeIBM*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static SecondaryColorPointerListIBMDel SecondaryColorPointerListIBMPtr;
        
        // glSelectBuffer
        private delegate void SelectBufferDel(uint  size, uint[] /*SelectName*/  buffer); private static SelectBufferDel SelectBufferPtr;
        
        // glSelectPerfMonitorCountersAMD
        private delegate void SelectPerfMonitorCountersAMDDel(uint  monitor, bool /*Boolean*/  enable, uint  group, int  numCounters, uint[]  counterList); private static SelectPerfMonitorCountersAMDDel SelectPerfMonitorCountersAMDPtr;
        
        // glSemaphoreParameterui64vEXT
        private delegate void SemaphoreParameterui64vEXTDel(uint  semaphore, uint /*SemaphoreParameterName*/  pname, ulong[]  parameters); private static SemaphoreParameterui64vEXTDel SemaphoreParameterui64vEXTPtr;
        
        // glSeparableFilter2D
        private delegate void SeparableFilter2DDel(uint /*SeparableTargetEXT*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  row, IntPtr  column); private static SeparableFilter2DDel SeparableFilter2DPtr;
        
        // glSeparableFilter2DEXT
        private delegate void SeparableFilter2DEXTDel(uint /*SeparableTargetEXT*/  target, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  row, IntPtr  column); private static SeparableFilter2DEXTDel SeparableFilter2DEXTPtr;
        
        // glSetFenceAPPLE
        private delegate void SetFenceAPPLEDel(uint /*FenceNV*/  fence); private static SetFenceAPPLEDel SetFenceAPPLEPtr;
        
        // glSetFenceNV
        private delegate void SetFenceNVDel(uint /*FenceNV*/  fence, uint /*FenceConditionNV*/  condition); private static SetFenceNVDel SetFenceNVPtr;
        
        // glSetFragmentShaderConstantATI
        private delegate void SetFragmentShaderConstantATIDel(uint  dst, float[]  value); private static SetFragmentShaderConstantATIDel SetFragmentShaderConstantATIPtr;
        
        // glSetInvariantEXT
        private delegate void SetInvariantEXTDel(uint  id, uint /*ScalarType*/  type, IntPtr  addr); private static SetInvariantEXTDel SetInvariantEXTPtr;
        
        // glSetLocalConstantEXT
        private delegate void SetLocalConstantEXTDel(uint  id, uint /*ScalarType*/  type, IntPtr  addr); private static SetLocalConstantEXTDel SetLocalConstantEXTPtr;
        
        // glSetMultisamplefvAMD
        private delegate void SetMultisamplefvAMDDel(uint  pname, uint  index, float[]  val); private static SetMultisamplefvAMDDel SetMultisamplefvAMDPtr;
        
        // glShadeModel
        private delegate void ShadeModelDel(uint /*ShadingModel*/  mode); private static ShadeModelDel ShadeModelPtr;
        
        // glShaderBinary
        private delegate void ShaderBinaryDel(uint  count, uint[]  shaders, uint  binaryformat, IntPtr  binary, uint  length); private static ShaderBinaryDel ShaderBinaryPtr;
        
        // glShaderOp1EXT
        private delegate void ShaderOp1EXTDel(uint /*VertexShaderOpEXT*/  op, uint  res, uint  arg1); private static ShaderOp1EXTDel ShaderOp1EXTPtr;
        
        // glShaderOp2EXT
        private delegate void ShaderOp2EXTDel(uint /*VertexShaderOpEXT*/  op, uint  res, uint  arg1, uint  arg2); private static ShaderOp2EXTDel ShaderOp2EXTPtr;
        
        // glShaderOp3EXT
        private delegate void ShaderOp3EXTDel(uint /*VertexShaderOpEXT*/  op, uint  res, uint  arg1, uint  arg2, uint  arg3); private static ShaderOp3EXTDel ShaderOp3EXTPtr;
        
        // glShaderSource
        private delegate void ShaderSourceDel(uint  shader, uint  count, string  str, int[]  length); private static ShaderSourceDel ShaderSourcePtr;
        
        // glShaderSourceARB
        private delegate void ShaderSourceARBDel(IntPtr /*handleARB*/  shaderObj, uint  count, string  str, int[]  length); private static ShaderSourceARBDel ShaderSourceARBPtr;
        
        // glShaderStorageBlockBinding
        private delegate void ShaderStorageBlockBindingDel(uint  program, uint  storageBlockIndex, uint  storageBlockBinding); private static ShaderStorageBlockBindingDel ShaderStorageBlockBindingPtr;
        
        // glShadingRateImageBarrierNV
        private delegate void ShadingRateImageBarrierNVDel(bool /*Boolean*/  synchronize); private static ShadingRateImageBarrierNVDel ShadingRateImageBarrierNVPtr;
        
        // glShadingRateQCOM
        private delegate void ShadingRateQCOMDel(uint /*ShadingRateQCOM*/  rate); private static ShadingRateQCOMDel ShadingRateQCOMPtr;
        
        // glShadingRateImagePaletteNV
        private delegate void ShadingRateImagePaletteNVDel(uint  viewport, uint  first, uint  count, uint[]  rates); private static ShadingRateImagePaletteNVDel ShadingRateImagePaletteNVPtr;
        
        // glShadingRateSampleOrderNV
        private delegate void ShadingRateSampleOrderNVDel(uint  order); private static ShadingRateSampleOrderNVDel ShadingRateSampleOrderNVPtr;
        
        // glShadingRateSampleOrderCustomNV
        private delegate void ShadingRateSampleOrderCustomNVDel(uint  rate, uint  samples, int[]  locations); private static ShadingRateSampleOrderCustomNVDel ShadingRateSampleOrderCustomNVPtr;
        
        // glSharpenTexFuncSGIS
        private delegate void SharpenTexFuncSGISDel(uint /*TextureTarget*/  target, uint  n, float[]  points); private static SharpenTexFuncSGISDel SharpenTexFuncSGISPtr;
        
        // glSignalSemaphoreEXT
        private delegate void SignalSemaphoreEXTDel(uint  semaphore, uint  numBufferBarriers, uint[]  buffers, uint  numTextureBarriers, uint[]  textures, uint[] /*TextureLayout*/  dstLayouts); private static SignalSemaphoreEXTDel SignalSemaphoreEXTPtr;
        
        // glSignalSemaphoreui64NVX
        private delegate void SignalSemaphoreui64NVXDel(uint  signalGpu, uint  fenceObjectCount, uint[]  semaphoreArray, ulong[]  fenceValueArray); private static SignalSemaphoreui64NVXDel SignalSemaphoreui64NVXPtr;
        
        // glSpecializeShader
        private delegate void SpecializeShaderDel(uint  shader, string  pEntryPoint, uint  numSpecializationConstants, uint[]  pConstantIndex, uint[]  pConstantValue); private static SpecializeShaderDel SpecializeShaderPtr;
        
        // glSpecializeShaderARB
        private delegate void SpecializeShaderARBDel(uint  shader, string  pEntryPoint, uint  numSpecializationConstants, uint[]  pConstantIndex, uint[]  pConstantValue); private static SpecializeShaderARBDel SpecializeShaderARBPtr;
        
        // glSpriteParameterfSGIX
        private delegate void SpriteParameterfSGIXDel(uint /*SpriteParameterNameSGIX*/  pname, float /*CheckedFloat32*/  param); private static SpriteParameterfSGIXDel SpriteParameterfSGIXPtr;
        
        // glSpriteParameterfvSGIX
        private delegate void SpriteParameterfvSGIXDel(uint /*SpriteParameterNameSGIX*/  pname, float[] /*CheckedFloat32*/  parameters); private static SpriteParameterfvSGIXDel SpriteParameterfvSGIXPtr;
        
        // glSpriteParameteriSGIX
        private delegate void SpriteParameteriSGIXDel(uint /*SpriteParameterNameSGIX*/  pname, int /*CheckedInt32*/  param); private static SpriteParameteriSGIXDel SpriteParameteriSGIXPtr;
        
        // glSpriteParameterivSGIX
        private delegate void SpriteParameterivSGIXDel(uint /*SpriteParameterNameSGIX*/  pname, int[] /*CheckedInt32*/  parameters); private static SpriteParameterivSGIXDel SpriteParameterivSGIXPtr;
        
        // glStartInstrumentsSGIX
        private delegate void StartInstrumentsSGIXDel(); private static StartInstrumentsSGIXDel StartInstrumentsSGIXPtr;
        
        // glStartTilingQCOM
        private delegate void StartTilingQCOMDel(uint  x, uint  y, uint  width, uint  height, uint /*BufferBitQCOM*/  preserveMask); private static StartTilingQCOMDel StartTilingQCOMPtr;
        
        // glStateCaptureNV
        private delegate void StateCaptureNVDel(uint  state, uint  mode); private static StateCaptureNVDel StateCaptureNVPtr;
        
        // glStencilClearTagEXT
        private delegate void StencilClearTagEXTDel(uint  stencilTagBits, uint  stencilClearTag); private static StencilClearTagEXTDel StencilClearTagEXTPtr;
        
        // glStencilFillPathInstancedNV
        private delegate void StencilFillPathInstancedNVDel(uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, uint /*PathFillMode*/  fillMode, uint /*MaskedStencilValue*/  mask, uint /*PathTransformType*/  transformType, float[]  transformValues); private static StencilFillPathInstancedNVDel StencilFillPathInstancedNVPtr;
        
        // glStencilFillPathNV
        private delegate void StencilFillPathNVDel(uint /*Path*/  path, uint /*PathFillMode*/  fillMode, uint /*MaskedStencilValue*/  mask); private static StencilFillPathNVDel StencilFillPathNVPtr;
        
        // glStencilFunc
        private delegate void StencilFuncDel(uint /*StencilFunction*/  func, int /*StencilValue*/  refVal, uint /*MaskedStencilValue*/  mask); private static StencilFuncDel StencilFuncPtr;
        
        // glStencilFuncSeparate
        private delegate void StencilFuncSeparateDel(uint /*StencilFaceDirection*/  face, uint /*StencilFunction*/  func, int /*StencilValue*/  refVal, uint /*MaskedStencilValue*/  mask); private static StencilFuncSeparateDel StencilFuncSeparatePtr;
        
        // glStencilFuncSeparateATI
        private delegate void StencilFuncSeparateATIDel(uint /*StencilFunction*/  frontfunc, uint /*StencilFunction*/  backfunc, int /*ClampedStencilValue*/  refVal, uint /*MaskedStencilValue*/  mask); private static StencilFuncSeparateATIDel StencilFuncSeparateATIPtr;
        
        // glStencilMask
        private delegate void StencilMaskDel(uint /*MaskedStencilValue*/  mask); private static StencilMaskDel StencilMaskPtr;
        
        // glStencilMaskSeparate
        private delegate void StencilMaskSeparateDel(uint /*StencilFaceDirection*/  face, uint /*MaskedStencilValue*/  mask); private static StencilMaskSeparateDel StencilMaskSeparatePtr;
        
        // glStencilOp
        private delegate void StencilOpDel(uint /*StencilOp*/  fail, uint /*StencilOp*/  zfail, uint /*StencilOp*/  zpass); private static StencilOpDel StencilOpPtr;
        
        // glStencilOpSeparate
        private delegate void StencilOpSeparateDel(uint /*StencilFaceDirection*/  face, uint /*StencilOp*/  sfail, uint /*StencilOp*/  dpfail, uint /*StencilOp*/  dppass); private static StencilOpSeparateDel StencilOpSeparatePtr;
        
        // glStencilOpSeparateATI
        private delegate void StencilOpSeparateATIDel(uint /*StencilFaceDirection*/  face, uint /*StencilOp*/  sfail, uint /*StencilOp*/  dpfail, uint /*StencilOp*/  dppass); private static StencilOpSeparateATIDel StencilOpSeparateATIPtr;
        
        // glStencilOpValueAMD
        private delegate void StencilOpValueAMDDel(uint /*StencilFaceDirection*/  face, uint  value); private static StencilOpValueAMDDel StencilOpValueAMDPtr;
        
        // glStencilStrokePathInstancedNV
        private delegate void StencilStrokePathInstancedNVDel(uint  numPaths, uint /*PathElementType*/  pathNameType, IntPtr /*PathElement*/  paths, uint /*Path*/  pathBase, int /*StencilValue*/  reference, uint /*MaskedStencilValue*/  mask, uint /*PathTransformType*/  transformType, float[]  transformValues); private static StencilStrokePathInstancedNVDel StencilStrokePathInstancedNVPtr;
        
        // glStencilStrokePathNV
        private delegate void StencilStrokePathNVDel(uint /*Path*/  path, int /*StencilValue*/  reference, uint /*MaskedStencilValue*/  mask); private static StencilStrokePathNVDel StencilStrokePathNVPtr;
        
        // glStencilThenCoverFillPathInstancedNV
        private delegate void StencilThenCoverFillPathInstancedNVDel(uint  numPaths, uint  pathNameType, IntPtr  paths, uint  pathBase, uint  fillMode, uint  mask, uint  coverMode, uint  transformType, float[]  transformValues); private static StencilThenCoverFillPathInstancedNVDel StencilThenCoverFillPathInstancedNVPtr;
        
        // glStencilThenCoverFillPathNV
        private delegate void StencilThenCoverFillPathNVDel(uint  path, uint  fillMode, uint  mask, uint  coverMode); private static StencilThenCoverFillPathNVDel StencilThenCoverFillPathNVPtr;
        
        // glStencilThenCoverStrokePathInstancedNV
        private delegate void StencilThenCoverStrokePathInstancedNVDel(uint  numPaths, uint  pathNameType, IntPtr  paths, uint  pathBase, int  reference, uint  mask, uint  coverMode, uint  transformType, float[]  transformValues); private static StencilThenCoverStrokePathInstancedNVDel StencilThenCoverStrokePathInstancedNVPtr;
        
        // glStencilThenCoverStrokePathNV
        private delegate void StencilThenCoverStrokePathNVDel(uint  path, int  reference, uint  mask, uint  coverMode); private static StencilThenCoverStrokePathNVDel StencilThenCoverStrokePathNVPtr;
        
        // glStopInstrumentsSGIX
        private delegate void StopInstrumentsSGIXDel(int  marker); private static StopInstrumentsSGIXDel StopInstrumentsSGIXPtr;
        
        // glStringMarkerGREMEDY
        private delegate void StringMarkerGREMEDYDel(uint  len, IntPtr  str); private static StringMarkerGREMEDYDel StringMarkerGREMEDYPtr;
        
        // glSubpixelPrecisionBiasNV
        private delegate void SubpixelPrecisionBiasNVDel(uint  xbits, uint  ybits); private static SubpixelPrecisionBiasNVDel SubpixelPrecisionBiasNVPtr;
        
        // glSwizzleEXT
        private delegate void SwizzleEXTDel(uint  res, uint  inp, uint /*VertexShaderCoordOutEXT*/  outX, uint /*VertexShaderCoordOutEXT*/  outY, uint /*VertexShaderCoordOutEXT*/  outZ, uint /*VertexShaderCoordOutEXT*/  outW); private static SwizzleEXTDel SwizzleEXTPtr;
        
        // glSyncTextureINTEL
        private delegate void SyncTextureINTELDel(uint  texture); private static SyncTextureINTELDel SyncTextureINTELPtr;
        
        // glTagSampleBufferSGIX
        private delegate void TagSampleBufferSGIXDel(); private static TagSampleBufferSGIXDel TagSampleBufferSGIXPtr;
        
        // glTangent3bEXT
        private delegate void Tangent3bEXTDel(sbyte  tx, sbyte  ty, sbyte  tz); private static Tangent3bEXTDel Tangent3bEXTPtr;
        
        // glTangent3bvEXT
        private delegate void Tangent3bvEXTDel(sbyte[]  v); private static Tangent3bvEXTDel Tangent3bvEXTPtr;
        
        // glTangent3dEXT
        private delegate void Tangent3dEXTDel(double /*CoordD*/  tx, double /*CoordD*/  ty, double /*CoordD*/  tz); private static Tangent3dEXTDel Tangent3dEXTPtr;
        
        // glTangent3dvEXT
        private delegate void Tangent3dvEXTDel(double[] /*CoordD*/  v); private static Tangent3dvEXTDel Tangent3dvEXTPtr;
        
        // glTangent3fEXT
        private delegate void Tangent3fEXTDel(float /*CoordF*/  tx, float /*CoordF*/  ty, float /*CoordF*/  tz); private static Tangent3fEXTDel Tangent3fEXTPtr;
        
        // glTangent3fvEXT
        private delegate void Tangent3fvEXTDel(float[] /*CoordF*/  v); private static Tangent3fvEXTDel Tangent3fvEXTPtr;
        
        // glTangent3iEXT
        private delegate void Tangent3iEXTDel(int  tx, int  ty, int  tz); private static Tangent3iEXTDel Tangent3iEXTPtr;
        
        // glTangent3ivEXT
        private delegate void Tangent3ivEXTDel(int[]  v); private static Tangent3ivEXTDel Tangent3ivEXTPtr;
        
        // glTangent3sEXT
        private delegate void Tangent3sEXTDel(short  tx, short  ty, short  tz); private static Tangent3sEXTDel Tangent3sEXTPtr;
        
        // glTangent3svEXT
        private delegate void Tangent3svEXTDel(short[]  v); private static Tangent3svEXTDel Tangent3svEXTPtr;
        
        // glTangentPointerEXT
        private delegate void TangentPointerEXTDel(uint /*TangentPointerTypeEXT*/  type, uint  stride, IntPtr  pointer); private static TangentPointerEXTDel TangentPointerEXTPtr;
        
        // glTbufferMask3DFX
        private delegate void TbufferMask3DFXDel(uint  mask); private static TbufferMask3DFXDel TbufferMask3DFXPtr;
        
        // glTessellationFactorAMD
        private delegate void TessellationFactorAMDDel(float  factor); private static TessellationFactorAMDDel TessellationFactorAMDPtr;
        
        // glTessellationModeAMD
        private delegate void TessellationModeAMDDel(uint  mode); private static TessellationModeAMDDel TessellationModeAMDPtr;
        
        // glTestFenceAPPLE
        private delegate bool /*Boolean*/ TestFenceAPPLEDel(uint /*FenceNV*/  fence); private static TestFenceAPPLEDel TestFenceAPPLEPtr;
        
        // glTestFenceNV
        private delegate bool /*Boolean*/ TestFenceNVDel(uint /*FenceNV*/  fence); private static TestFenceNVDel TestFenceNVPtr;
        
        // glTestObjectAPPLE
        private delegate bool /*Boolean*/ TestObjectAPPLEDel(uint /*ObjectTypeAPPLE*/  obj, uint  name); private static TestObjectAPPLEDel TestObjectAPPLEPtr;
        
        // glTexAttachMemoryNV
        private delegate void TexAttachMemoryNVDel(uint /*TextureTarget*/  target, uint  memory, ulong  offset); private static TexAttachMemoryNVDel TexAttachMemoryNVPtr;
        
        // glTexBuffer
        private delegate void TexBufferDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer); private static TexBufferDel TexBufferPtr;
        
        // glTexBufferARB
        private delegate void TexBufferARBDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer); private static TexBufferARBDel TexBufferARBPtr;
        
        // glTexBufferEXT
        private delegate void TexBufferEXTDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer); private static TexBufferEXTDel TexBufferEXTPtr;
        
        // glTexBufferOES
        private delegate void TexBufferOESDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer); private static TexBufferOESDel TexBufferOESPtr;
        
        // glTexBufferRange
        private delegate void TexBufferRangeDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static TexBufferRangeDel TexBufferRangePtr;
        
        // glTexBufferRangeEXT
        private delegate void TexBufferRangeEXTDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static TexBufferRangeEXTDel TexBufferRangeEXTPtr;
        
        // glTexBufferRangeOES
        private delegate void TexBufferRangeOESDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static TexBufferRangeOESDel TexBufferRangeOESPtr;
        
        // glTexBumpParameterfvATI
        private delegate void TexBumpParameterfvATIDel(uint /*TexBumpParameterATI*/  pname, float[]  param); private static TexBumpParameterfvATIDel TexBumpParameterfvATIPtr;
        
        // glTexBumpParameterivATI
        private delegate void TexBumpParameterivATIDel(uint /*TexBumpParameterATI*/  pname, int[]  param); private static TexBumpParameterivATIDel TexBumpParameterivATIPtr;
        
        // glTexCoord1bOES
        private delegate void TexCoord1bOESDel(sbyte  s); private static TexCoord1bOESDel TexCoord1bOESPtr;
        
        // glTexCoord1bvOES
        private delegate void TexCoord1bvOESDel(sbyte[]  coords); private static TexCoord1bvOESDel TexCoord1bvOESPtr;
        
        // glTexCoord1d
        private delegate void TexCoord1dDel(double /*CoordD*/  s); private static TexCoord1dDel TexCoord1dPtr;
        
        // glTexCoord1dv
        private delegate void TexCoord1dvDel(double[] /*CoordD*/  v); private static TexCoord1dvDel TexCoord1dvPtr;
        
        // glTexCoord1f
        private delegate void TexCoord1fDel(float /*CoordF*/  s); private static TexCoord1fDel TexCoord1fPtr;
        
        // glTexCoord1fv
        private delegate void TexCoord1fvDel(float[] /*CoordF*/  v); private static TexCoord1fvDel TexCoord1fvPtr;
        
        // glTexCoord1hNV
        private delegate void TexCoord1hNVDel(ushort /*Half16NV*/  s); private static TexCoord1hNVDel TexCoord1hNVPtr;
        
        // glTexCoord1hvNV
        private delegate void TexCoord1hvNVDel(ushort[] /*Half16NV*/  v); private static TexCoord1hvNVDel TexCoord1hvNVPtr;
        
        // glTexCoord1i
        private delegate void TexCoord1iDel(int /*CoordI*/  s); private static TexCoord1iDel TexCoord1iPtr;
        
        // glTexCoord1iv
        private delegate void TexCoord1ivDel(int[] /*CoordI*/  v); private static TexCoord1ivDel TexCoord1ivPtr;
        
        // glTexCoord1s
        private delegate void TexCoord1sDel(short /*CoordS*/  s); private static TexCoord1sDel TexCoord1sPtr;
        
        // glTexCoord1sv
        private delegate void TexCoord1svDel(short[] /*CoordS*/  v); private static TexCoord1svDel TexCoord1svPtr;
        
        // glTexCoord1xOES
        private delegate void TexCoord1xOESDel(int  s); private static TexCoord1xOESDel TexCoord1xOESPtr;
        
        // glTexCoord1xvOES
        private delegate void TexCoord1xvOESDel(int[]  coords); private static TexCoord1xvOESDel TexCoord1xvOESPtr;
        
        // glTexCoord2bOES
        private delegate void TexCoord2bOESDel(sbyte  s, sbyte  t); private static TexCoord2bOESDel TexCoord2bOESPtr;
        
        // glTexCoord2bvOES
        private delegate void TexCoord2bvOESDel(sbyte[]  coords); private static TexCoord2bvOESDel TexCoord2bvOESPtr;
        
        // glTexCoord2d
        private delegate void TexCoord2dDel(double /*CoordD*/  s, double /*CoordD*/  t); private static TexCoord2dDel TexCoord2dPtr;
        
        // glTexCoord2dv
        private delegate void TexCoord2dvDel(double[] /*CoordD*/  v); private static TexCoord2dvDel TexCoord2dvPtr;
        
        // glTexCoord2f
        private delegate void TexCoord2fDel(float /*CoordF*/  s, float /*CoordF*/  t); private static TexCoord2fDel TexCoord2fPtr;
        
        // glTexCoord2fColor3fVertex3fSUN
        private delegate void TexCoord2fColor3fVertex3fSUNDel(float  s, float  t, float  r, float  g, float  b, float  x, float  y, float  z); private static TexCoord2fColor3fVertex3fSUNDel TexCoord2fColor3fVertex3fSUNPtr;
        
        // glTexCoord2fColor3fVertex3fvSUN
        private delegate void TexCoord2fColor3fVertex3fvSUNDel(float[]  tc, float[]  c, float[]  v); private static TexCoord2fColor3fVertex3fvSUNDel TexCoord2fColor3fVertex3fvSUNPtr;
        
        // glTexCoord2fColor4fNormal3fVertex3fSUN
        private delegate void TexCoord2fColor4fNormal3fVertex3fSUNDel(float  s, float  t, float  r, float  g, float  b, float  a, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static TexCoord2fColor4fNormal3fVertex3fSUNDel TexCoord2fColor4fNormal3fVertex3fSUNPtr;
        
        // glTexCoord2fColor4fNormal3fVertex3fvSUN
        private delegate void TexCoord2fColor4fNormal3fVertex3fvSUNDel(float[]  tc, float[]  c, float[]  n, float[]  v); private static TexCoord2fColor4fNormal3fVertex3fvSUNDel TexCoord2fColor4fNormal3fVertex3fvSUNPtr;
        
        // glTexCoord2fColor4ubVertex3fSUN
        private delegate void TexCoord2fColor4ubVertex3fSUNDel(float  s, float  t, byte  r, byte  g, byte  b, byte  a, float  x, float  y, float  z); private static TexCoord2fColor4ubVertex3fSUNDel TexCoord2fColor4ubVertex3fSUNPtr;
        
        // glTexCoord2fColor4ubVertex3fvSUN
        private delegate void TexCoord2fColor4ubVertex3fvSUNDel(float[]  tc, byte[]  c, float[]  v); private static TexCoord2fColor4ubVertex3fvSUNDel TexCoord2fColor4ubVertex3fvSUNPtr;
        
        // glTexCoord2fNormal3fVertex3fSUN
        private delegate void TexCoord2fNormal3fVertex3fSUNDel(float  s, float  t, float  nx, float  ny, float  nz, float  x, float  y, float  z); private static TexCoord2fNormal3fVertex3fSUNDel TexCoord2fNormal3fVertex3fSUNPtr;
        
        // glTexCoord2fNormal3fVertex3fvSUN
        private delegate void TexCoord2fNormal3fVertex3fvSUNDel(float[]  tc, float[]  n, float[]  v); private static TexCoord2fNormal3fVertex3fvSUNDel TexCoord2fNormal3fVertex3fvSUNPtr;
        
        // glTexCoord2fVertex3fSUN
        private delegate void TexCoord2fVertex3fSUNDel(float  s, float  t, float  x, float  y, float  z); private static TexCoord2fVertex3fSUNDel TexCoord2fVertex3fSUNPtr;
        
        // glTexCoord2fVertex3fvSUN
        private delegate void TexCoord2fVertex3fvSUNDel(float[]  tc, float[]  v); private static TexCoord2fVertex3fvSUNDel TexCoord2fVertex3fvSUNPtr;
        
        // glTexCoord2fv
        private delegate void TexCoord2fvDel(float[] /*CoordF*/  v); private static TexCoord2fvDel TexCoord2fvPtr;
        
        // glTexCoord2hNV
        private delegate void TexCoord2hNVDel(ushort /*Half16NV*/  s, ushort /*Half16NV*/  t); private static TexCoord2hNVDel TexCoord2hNVPtr;
        
        // glTexCoord2hvNV
        private delegate void TexCoord2hvNVDel(ushort[] /*Half16NV*/  v); private static TexCoord2hvNVDel TexCoord2hvNVPtr;
        
        // glTexCoord2i
        private delegate void TexCoord2iDel(int /*CoordI*/  s, int /*CoordI*/  t); private static TexCoord2iDel TexCoord2iPtr;
        
        // glTexCoord2iv
        private delegate void TexCoord2ivDel(int[] /*CoordI*/  v); private static TexCoord2ivDel TexCoord2ivPtr;
        
        // glTexCoord2s
        private delegate void TexCoord2sDel(short /*CoordS*/  s, short /*CoordS*/  t); private static TexCoord2sDel TexCoord2sPtr;
        
        // glTexCoord2sv
        private delegate void TexCoord2svDel(short[] /*CoordS*/  v); private static TexCoord2svDel TexCoord2svPtr;
        
        // glTexCoord2xOES
        private delegate void TexCoord2xOESDel(int  s, int  t); private static TexCoord2xOESDel TexCoord2xOESPtr;
        
        // glTexCoord2xvOES
        private delegate void TexCoord2xvOESDel(int[]  coords); private static TexCoord2xvOESDel TexCoord2xvOESPtr;
        
        // glTexCoord3bOES
        private delegate void TexCoord3bOESDel(sbyte  s, sbyte  t, sbyte  r); private static TexCoord3bOESDel TexCoord3bOESPtr;
        
        // glTexCoord3bvOES
        private delegate void TexCoord3bvOESDel(sbyte[]  coords); private static TexCoord3bvOESDel TexCoord3bvOESPtr;
        
        // glTexCoord3d
        private delegate void TexCoord3dDel(double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r); private static TexCoord3dDel TexCoord3dPtr;
        
        // glTexCoord3dv
        private delegate void TexCoord3dvDel(double[] /*CoordD*/  v); private static TexCoord3dvDel TexCoord3dvPtr;
        
        // glTexCoord3f
        private delegate void TexCoord3fDel(float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r); private static TexCoord3fDel TexCoord3fPtr;
        
        // glTexCoord3fv
        private delegate void TexCoord3fvDel(float[] /*CoordF*/  v); private static TexCoord3fvDel TexCoord3fvPtr;
        
        // glTexCoord3hNV
        private delegate void TexCoord3hNVDel(ushort /*Half16NV*/  s, ushort /*Half16NV*/  t, ushort /*Half16NV*/  r); private static TexCoord3hNVDel TexCoord3hNVPtr;
        
        // glTexCoord3hvNV
        private delegate void TexCoord3hvNVDel(ushort[] /*Half16NV*/  v); private static TexCoord3hvNVDel TexCoord3hvNVPtr;
        
        // glTexCoord3i
        private delegate void TexCoord3iDel(int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r); private static TexCoord3iDel TexCoord3iPtr;
        
        // glTexCoord3iv
        private delegate void TexCoord3ivDel(int[] /*CoordI*/  v); private static TexCoord3ivDel TexCoord3ivPtr;
        
        // glTexCoord3s
        private delegate void TexCoord3sDel(short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r); private static TexCoord3sDel TexCoord3sPtr;
        
        // glTexCoord3sv
        private delegate void TexCoord3svDel(short[] /*CoordS*/  v); private static TexCoord3svDel TexCoord3svPtr;
        
        // glTexCoord3xOES
        private delegate void TexCoord3xOESDel(int  s, int  t, int  r); private static TexCoord3xOESDel TexCoord3xOESPtr;
        
        // glTexCoord3xvOES
        private delegate void TexCoord3xvOESDel(int[]  coords); private static TexCoord3xvOESDel TexCoord3xvOESPtr;
        
        // glTexCoord4bOES
        private delegate void TexCoord4bOESDel(sbyte  s, sbyte  t, sbyte  r, sbyte  q); private static TexCoord4bOESDel TexCoord4bOESPtr;
        
        // glTexCoord4bvOES
        private delegate void TexCoord4bvOESDel(sbyte[]  coords); private static TexCoord4bvOESDel TexCoord4bvOESPtr;
        
        // glTexCoord4d
        private delegate void TexCoord4dDel(double /*CoordD*/  s, double /*CoordD*/  t, double /*CoordD*/  r, double /*CoordD*/  q); private static TexCoord4dDel TexCoord4dPtr;
        
        // glTexCoord4dv
        private delegate void TexCoord4dvDel(double[] /*CoordD*/  v); private static TexCoord4dvDel TexCoord4dvPtr;
        
        // glTexCoord4f
        private delegate void TexCoord4fDel(float /*CoordF*/  s, float /*CoordF*/  t, float /*CoordF*/  r, float /*CoordF*/  q); private static TexCoord4fDel TexCoord4fPtr;
        
        // glTexCoord4fColor4fNormal3fVertex4fSUN
        private delegate void TexCoord4fColor4fNormal3fVertex4fSUNDel(float  s, float  t, float  p, float  q, float  r, float  g, float  b, float  a, float  nx, float  ny, float  nz, float  x, float  y, float  z, float  w); private static TexCoord4fColor4fNormal3fVertex4fSUNDel TexCoord4fColor4fNormal3fVertex4fSUNPtr;
        
        // glTexCoord4fColor4fNormal3fVertex4fvSUN
        private delegate void TexCoord4fColor4fNormal3fVertex4fvSUNDel(float[]  tc, float[]  c, float[]  n, float[]  v); private static TexCoord4fColor4fNormal3fVertex4fvSUNDel TexCoord4fColor4fNormal3fVertex4fvSUNPtr;
        
        // glTexCoord4fVertex4fSUN
        private delegate void TexCoord4fVertex4fSUNDel(float  s, float  t, float  p, float  q, float  x, float  y, float  z, float  w); private static TexCoord4fVertex4fSUNDel TexCoord4fVertex4fSUNPtr;
        
        // glTexCoord4fVertex4fvSUN
        private delegate void TexCoord4fVertex4fvSUNDel(float[]  tc, float[]  v); private static TexCoord4fVertex4fvSUNDel TexCoord4fVertex4fvSUNPtr;
        
        // glTexCoord4fv
        private delegate void TexCoord4fvDel(float[] /*CoordF*/  v); private static TexCoord4fvDel TexCoord4fvPtr;
        
        // glTexCoord4hNV
        private delegate void TexCoord4hNVDel(ushort /*Half16NV*/  s, ushort /*Half16NV*/  t, ushort /*Half16NV*/  r, ushort /*Half16NV*/  q); private static TexCoord4hNVDel TexCoord4hNVPtr;
        
        // glTexCoord4hvNV
        private delegate void TexCoord4hvNVDel(ushort[] /*Half16NV*/  v); private static TexCoord4hvNVDel TexCoord4hvNVPtr;
        
        // glTexCoord4i
        private delegate void TexCoord4iDel(int /*CoordI*/  s, int /*CoordI*/  t, int /*CoordI*/  r, int /*CoordI*/  q); private static TexCoord4iDel TexCoord4iPtr;
        
        // glTexCoord4iv
        private delegate void TexCoord4ivDel(int[] /*CoordI*/  v); private static TexCoord4ivDel TexCoord4ivPtr;
        
        // glTexCoord4s
        private delegate void TexCoord4sDel(short /*CoordS*/  s, short /*CoordS*/  t, short /*CoordS*/  r, short /*CoordS*/  q); private static TexCoord4sDel TexCoord4sPtr;
        
        // glTexCoord4sv
        private delegate void TexCoord4svDel(short[] /*CoordS*/  v); private static TexCoord4svDel TexCoord4svPtr;
        
        // glTexCoord4xOES
        private delegate void TexCoord4xOESDel(int  s, int  t, int  r, int  q); private static TexCoord4xOESDel TexCoord4xOESPtr;
        
        // glTexCoord4xvOES
        private delegate void TexCoord4xvOESDel(int[]  coords); private static TexCoord4xvOESDel TexCoord4xvOESPtr;
        
        // glTexCoordFormatNV
        private delegate void TexCoordFormatNVDel(int  size, uint  type, uint  stride); private static TexCoordFormatNVDel TexCoordFormatNVPtr;
        
        // glTexCoordP1ui
        private delegate void TexCoordP1uiDel(uint /*TexCoordPointerType*/  type, uint  coords); private static TexCoordP1uiDel TexCoordP1uiPtr;
        
        // glTexCoordP1uiv
        private delegate void TexCoordP1uivDel(uint /*TexCoordPointerType*/  type, uint[]  coords); private static TexCoordP1uivDel TexCoordP1uivPtr;
        
        // glTexCoordP2ui
        private delegate void TexCoordP2uiDel(uint /*TexCoordPointerType*/  type, uint  coords); private static TexCoordP2uiDel TexCoordP2uiPtr;
        
        // glTexCoordP2uiv
        private delegate void TexCoordP2uivDel(uint /*TexCoordPointerType*/  type, uint[]  coords); private static TexCoordP2uivDel TexCoordP2uivPtr;
        
        // glTexCoordP3ui
        private delegate void TexCoordP3uiDel(uint /*TexCoordPointerType*/  type, uint  coords); private static TexCoordP3uiDel TexCoordP3uiPtr;
        
        // glTexCoordP3uiv
        private delegate void TexCoordP3uivDel(uint /*TexCoordPointerType*/  type, uint[]  coords); private static TexCoordP3uivDel TexCoordP3uivPtr;
        
        // glTexCoordP4ui
        private delegate void TexCoordP4uiDel(uint /*TexCoordPointerType*/  type, uint  coords); private static TexCoordP4uiDel TexCoordP4uiPtr;
        
        // glTexCoordP4uiv
        private delegate void TexCoordP4uivDel(uint /*TexCoordPointerType*/  type, uint[]  coords); private static TexCoordP4uivDel TexCoordP4uivPtr;
        
        // glTexCoordPointer
        private delegate void TexCoordPointerDel(int  size, uint /*TexCoordPointerType*/  type, uint  stride, IntPtr  pointer); private static TexCoordPointerDel TexCoordPointerPtr;
        
        // glTexCoordPointerEXT
        private delegate void TexCoordPointerEXTDel(int  size, uint /*TexCoordPointerType*/  type, uint  stride, uint  count, IntPtr  pointer); private static TexCoordPointerEXTDel TexCoordPointerEXTPtr;
        
        // glTexCoordPointerListIBM
        private delegate void TexCoordPointerListIBMDel(int  size, uint /*TexCoordPointerType*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static TexCoordPointerListIBMDel TexCoordPointerListIBMPtr;
        
        // glTexCoordPointervINTEL
        private delegate void TexCoordPointervINTELDel(int  size, uint /*VertexPointerType*/  type, IntPtr  pointer); private static TexCoordPointervINTELDel TexCoordPointervINTELPtr;
        
        // glTexEnvf
        private delegate void TexEnvfDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float /*CheckedFloat32*/  param); private static TexEnvfDel TexEnvfPtr;
        
        // glTexEnvfv
        private delegate void TexEnvfvDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static TexEnvfvDel TexEnvfvPtr;
        
        // glTexEnvi
        private delegate void TexEnviDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int /*CheckedInt32*/  param); private static TexEnviDel TexEnviPtr;
        
        // glTexEnviv
        private delegate void TexEnvivDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static TexEnvivDel TexEnvivPtr;
        
        // glTexEnvx
        private delegate void TexEnvxDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int  param); private static TexEnvxDel TexEnvxPtr;
        
        // glTexEnvxOES
        private delegate void TexEnvxOESDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int  param); private static TexEnvxOESDel TexEnvxOESPtr;
        
        // glTexEnvxv
        private delegate void TexEnvxvDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static TexEnvxvDel TexEnvxvPtr;
        
        // glTexEnvxvOES
        private delegate void TexEnvxvOESDel(uint /*TextureEnvTarget*/  target, uint /*TextureEnvParameter*/  pname, int[]  parameters); private static TexEnvxvOESDel TexEnvxvOESPtr;
        
        // glTexEstimateMotionQCOM
        private delegate void TexEstimateMotionQCOMDel(uint /*Texture*/  refVal, uint /*Texture*/  target, uint /*Texture*/  output); private static TexEstimateMotionQCOMDel TexEstimateMotionQCOMPtr;
        
        // glTexEstimateMotionRegionsQCOM
        private delegate void TexEstimateMotionRegionsQCOMDel(uint /*Texture*/  refVal, uint /*Texture*/  target, uint /*Texture*/  output, uint /*Texture*/  mask); private static TexEstimateMotionRegionsQCOMDel TexEstimateMotionRegionsQCOMPtr;
        
        // glTexFilterFuncSGIS
        private delegate void TexFilterFuncSGISDel(uint /*TextureTarget*/  target, uint /*TextureFilterSGIS*/  filter, uint  n, float[]  weights); private static TexFilterFuncSGISDel TexFilterFuncSGISPtr;
        
        // glTexGend
        private delegate void TexGendDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double  param); private static TexGendDel TexGendPtr;
        
        // glTexGendv
        private delegate void TexGendvDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, double[]  parameters); private static TexGendvDel TexGendvPtr;
        
        // glTexGenf
        private delegate void TexGenfDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float /*CheckedFloat32*/  param); private static TexGenfDel TexGenfPtr;
        
        // glTexGenfOES
        private delegate void TexGenfOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float  param); private static TexGenfOESDel TexGenfOESPtr;
        
        // glTexGenfv
        private delegate void TexGenfvDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[] /*CheckedFloat32*/  parameters); private static TexGenfvDel TexGenfvPtr;
        
        // glTexGenfvOES
        private delegate void TexGenfvOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, float[]  parameters); private static TexGenfvOESDel TexGenfvOESPtr;
        
        // glTexGeni
        private delegate void TexGeniDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int /*CheckedInt32*/  param); private static TexGeniDel TexGeniPtr;
        
        // glTexGeniOES
        private delegate void TexGeniOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int  param); private static TexGeniOESDel TexGeniOESPtr;
        
        // glTexGeniv
        private delegate void TexGenivDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[] /*CheckedInt32*/  parameters); private static TexGenivDel TexGenivPtr;
        
        // glTexGenivOES
        private delegate void TexGenivOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static TexGenivOESDel TexGenivOESPtr;
        
        // glTexGenxOES
        private delegate void TexGenxOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int  param); private static TexGenxOESDel TexGenxOESPtr;
        
        // glTexGenxvOES
        private delegate void TexGenxvOESDel(uint /*TextureCoordName*/  coord, uint /*TextureGenParameter*/  pname, int[]  parameters); private static TexGenxvOESDel TexGenxvOESPtr;
        
        // glTexImage1D
        private delegate void TexImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage1DDel TexImage1DPtr;
        
        // glTexImage2D
        private delegate void TexImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage2DDel TexImage2DPtr;
        
        // glTexImage2DMultisample
        private delegate void TexImage2DMultisampleDel(uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, bool /*Boolean*/  fixedsamplelocations); private static TexImage2DMultisampleDel TexImage2DMultisamplePtr;
        
        // glTexImage2DMultisampleCoverageNV
        private delegate void TexImage2DMultisampleCoverageNVDel(uint /*TextureTarget*/  target, uint  coverageSamples, uint  colorSamples, int  internalFormat, uint  width, uint  height, bool /*Boolean*/  fixedSampleLocations); private static TexImage2DMultisampleCoverageNVDel TexImage2DMultisampleCoverageNVPtr;
        
        // glTexImage3D
        private delegate void TexImage3DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage3DDel TexImage3DPtr;
        
        // glTexImage3DEXT
        private delegate void TexImage3DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage3DEXTDel TexImage3DEXTPtr;
        
        // glTexImage3DMultisample
        private delegate void TexImage3DMultisampleDel(uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedsamplelocations); private static TexImage3DMultisampleDel TexImage3DMultisamplePtr;
        
        // glTexImage3DMultisampleCoverageNV
        private delegate void TexImage3DMultisampleCoverageNVDel(uint /*TextureTarget*/  target, uint  coverageSamples, uint  colorSamples, int  internalFormat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedSampleLocations); private static TexImage3DMultisampleCoverageNVDel TexImage3DMultisampleCoverageNVPtr;
        
        // glTexImage3DOES
        private delegate void TexImage3DOESDel(uint /*TextureTarget*/  target, int  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage3DOESDel TexImage3DOESPtr;
        
        // glTexImage4DSGIS
        private delegate void TexImage4DSGISDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, uint  size4d, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexImage4DSGISDel TexImage4DSGISPtr;
        
        // glTexPageCommitmentARB
        private delegate void TexPageCommitmentARBDel(uint  target, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, bool /*Boolean*/  commit); private static TexPageCommitmentARBDel TexPageCommitmentARBPtr;
        
        // glTexPageCommitmentEXT
        private delegate void TexPageCommitmentEXTDel(uint  target, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, bool /*Boolean*/  commit); private static TexPageCommitmentEXTDel TexPageCommitmentEXTPtr;
        
        // glTexParameterIiv
        private delegate void TexParameterIivDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[]  parameters); private static TexParameterIivDel TexParameterIivPtr;
        
        // glTexParameterIivEXT
        private delegate void TexParameterIivEXTDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[]  parameters); private static TexParameterIivEXTDel TexParameterIivEXTPtr;
        
        // glTexParameterIivOES
        private delegate void TexParameterIivOESDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[]  parameters); private static TexParameterIivOESDel TexParameterIivOESPtr;
        
        // glTexParameterIuiv
        private delegate void TexParameterIuivDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, uint[]  parameters); private static TexParameterIuivDel TexParameterIuivPtr;
        
        // glTexParameterIuivEXT
        private delegate void TexParameterIuivEXTDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, uint[]  parameters); private static TexParameterIuivEXTDel TexParameterIuivEXTPtr;
        
        // glTexParameterIuivOES
        private delegate void TexParameterIuivOESDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, uint[]  parameters); private static TexParameterIuivOESDel TexParameterIuivOESPtr;
        
        // glTexParameterf
        private delegate void TexParameterfDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float /*CheckedFloat32*/  param); private static TexParameterfDel TexParameterfPtr;
        
        // glTexParameterfv
        private delegate void TexParameterfvDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float[] /*CheckedFloat32*/  parameters); private static TexParameterfvDel TexParameterfvPtr;
        
        // glTexParameteri
        private delegate void TexParameteriDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int /*CheckedInt32*/  param); private static TexParameteriDel TexParameteriPtr;
        
        // glTexParameteriv
        private delegate void TexParameterivDel(uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static TexParameterivDel TexParameterivPtr;
        
        // glTexParameterx
        private delegate void TexParameterxDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int  param); private static TexParameterxDel TexParameterxPtr;
        
        // glTexParameterxOES
        private delegate void TexParameterxOESDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int  param); private static TexParameterxOESDel TexParameterxOESPtr;
        
        // glTexParameterxv
        private delegate void TexParameterxvDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static TexParameterxvDel TexParameterxvPtr;
        
        // glTexParameterxvOES
        private delegate void TexParameterxvOESDel(uint /*TextureTarget*/  target, uint /*GetTextureParameter*/  pname, int[]  parameters); private static TexParameterxvOESDel TexParameterxvOESPtr;
        
        // glTexRenderbufferNV
        private delegate void TexRenderbufferNVDel(uint /*TextureTarget*/  target, uint  renderbuffer); private static TexRenderbufferNVDel TexRenderbufferNVPtr;
        
        // glTexStorage1D
        private delegate void TexStorage1DDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width); private static TexStorage1DDel TexStorage1DPtr;
        
        // glTexStorage1DEXT
        private delegate void TexStorage1DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width); private static TexStorage1DEXTDel TexStorage1DEXTPtr;
        
        // glTexStorage2D
        private delegate void TexStorage2DDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static TexStorage2DDel TexStorage2DPtr;
        
        // glTexStorage2DEXT
        private delegate void TexStorage2DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static TexStorage2DEXTDel TexStorage2DEXTPtr;
        
        // glTexStorage2DMultisample
        private delegate void TexStorage2DMultisampleDel(uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, bool /*Boolean*/  fixedsamplelocations); private static TexStorage2DMultisampleDel TexStorage2DMultisamplePtr;
        
        // glTexStorage3D
        private delegate void TexStorage3DDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth); private static TexStorage3DDel TexStorage3DPtr;
        
        // glTexStorage3DEXT
        private delegate void TexStorage3DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth); private static TexStorage3DEXTDel TexStorage3DEXTPtr;
        
        // glTexStorage3DMultisample
        private delegate void TexStorage3DMultisampleDel(uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedsamplelocations); private static TexStorage3DMultisampleDel TexStorage3DMultisamplePtr;
        
        // glTexStorage3DMultisampleOES
        private delegate void TexStorage3DMultisampleOESDel(uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedsamplelocations); private static TexStorage3DMultisampleOESDel TexStorage3DMultisampleOESPtr;
        
        // glTexStorageMem1DEXT
        private delegate void TexStorageMem1DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint  internalFormat, uint  width, uint  memory, ulong  offset); private static TexStorageMem1DEXTDel TexStorageMem1DEXTPtr;
        
        // glTexStorageMem2DEXT
        private delegate void TexStorageMem2DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint  internalFormat, uint  width, uint  height, uint  memory, ulong  offset); private static TexStorageMem2DEXTDel TexStorageMem2DEXTPtr;
        
        // glTexStorageMem2DMultisampleEXT
        private delegate void TexStorageMem2DMultisampleEXTDel(uint /*TextureTarget*/  target, uint  samples, uint  internalFormat, uint  width, uint  height, bool /*Boolean*/  fixedSampleLocations, uint  memory, ulong  offset); private static TexStorageMem2DMultisampleEXTDel TexStorageMem2DMultisampleEXTPtr;
        
        // glTexStorageMem3DEXT
        private delegate void TexStorageMem3DEXTDel(uint /*TextureTarget*/  target, uint  levels, uint  internalFormat, uint  width, uint  height, uint  depth, uint  memory, ulong  offset); private static TexStorageMem3DEXTDel TexStorageMem3DEXTPtr;
        
        // glTexStorageMem3DMultisampleEXT
        private delegate void TexStorageMem3DMultisampleEXTDel(uint /*TextureTarget*/  target, uint  samples, uint  internalFormat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedSampleLocations, uint  memory, ulong  offset); private static TexStorageMem3DMultisampleEXTDel TexStorageMem3DMultisampleEXTPtr;
        
        // glTexStorageSparseAMD
        private delegate void TexStorageSparseAMDDel(uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalFormat, uint  width, uint  height, uint  depth, uint  layers, uint /*TextureStorageMaskAMD*/  flags); private static TexStorageSparseAMDDel TexStorageSparseAMDPtr;
        
        // glTexSubImage1D
        private delegate void TexSubImage1DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage1DDel TexSubImage1DPtr;
        
        // glTexSubImage1DEXT
        private delegate void TexSubImage1DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage1DEXTDel TexSubImage1DEXTPtr;
        
        // glTexSubImage2D
        private delegate void TexSubImage2DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage2DDel TexSubImage2DPtr;
        
        // glTexSubImage2DEXT
        private delegate void TexSubImage2DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage2DEXTDel TexSubImage2DEXTPtr;
        
        // glTexSubImage3D
        private delegate void TexSubImage3DDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage3DDel TexSubImage3DPtr;
        
        // glTexSubImage3DEXT
        private delegate void TexSubImage3DEXTDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage3DEXTDel TexSubImage3DEXTPtr;
        
        // glTexSubImage3DOES
        private delegate void TexSubImage3DOESDel(uint /*TextureTarget*/  target, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage3DOESDel TexSubImage3DOESPtr;
        
        // glTexSubImage4DSGIS
        private delegate void TexSubImage4DSGISDel(uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, int /*CheckedInt32*/  woffset, uint  width, uint  height, uint  depth, uint  size4d, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TexSubImage4DSGISDel TexSubImage4DSGISPtr;
        
        // glTextureAttachMemoryNV
        private delegate void TextureAttachMemoryNVDel(uint  texture, uint  memory, ulong  offset); private static TextureAttachMemoryNVDel TextureAttachMemoryNVPtr;
        
        // glTextureBarrier
        private delegate void TextureBarrierDel(); private static TextureBarrierDel TextureBarrierPtr;
        
        // glTextureBarrierNV
        private delegate void TextureBarrierNVDel(); private static TextureBarrierNVDel TextureBarrierNVPtr;
        
        // glTextureBuffer
        private delegate void TextureBufferDel(uint  texture, uint /*InternalFormat*/  internalformat, uint  buffer); private static TextureBufferDel TextureBufferPtr;
        
        // glTextureBufferEXT
        private delegate void TextureBufferEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer); private static TextureBufferEXTDel TextureBufferEXTPtr;
        
        // glTextureBufferRange
        private delegate void TextureBufferRangeDel(uint  texture, uint /*InternalFormat*/  internalformat, uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  size); private static TextureBufferRangeDel TextureBufferRangePtr;
        
        // glTextureBufferRangeEXT
        private delegate void TextureBufferRangeEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*InternalFormat*/  internalformat, uint  buffer, IntPtr /*BufferOffset*/  offset, IntPtr /*BufferSize*/  size); private static TextureBufferRangeEXTDel TextureBufferRangeEXTPtr;
        
        // glTextureColorMaskSGIS
        private delegate void TextureColorMaskSGISDel(bool /*Boolean*/  red, bool /*Boolean*/  green, bool /*Boolean*/  blue, bool /*Boolean*/  alpha); private static TextureColorMaskSGISDel TextureColorMaskSGISPtr;
        
        // glTextureFoveationParametersQCOM
        private delegate void TextureFoveationParametersQCOMDel(uint /*Texture*/  texture, uint  layer, uint  focalPoint, float /*CheckedFloat32*/  focalX, float /*CheckedFloat32*/  focalY, float /*CheckedFloat32*/  gainX, float /*CheckedFloat32*/  gainY, float /*CheckedFloat32*/  foveaArea); private static TextureFoveationParametersQCOMDel TextureFoveationParametersQCOMPtr;
        
        // glTextureImage1DEXT
        private delegate void TextureImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureImage1DEXTDel TextureImage1DEXTPtr;
        
        // glTextureImage2DEXT
        private delegate void TextureImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureImage2DEXTDel TextureImage2DEXTPtr;
        
        // glTextureImage2DMultisampleCoverageNV
        private delegate void TextureImage2DMultisampleCoverageNVDel(uint  texture, uint /*TextureTarget*/  target, uint  coverageSamples, uint  colorSamples, int  internalFormat, uint  width, uint  height, bool /*Boolean*/  fixedSampleLocations); private static TextureImage2DMultisampleCoverageNVDel TextureImage2DMultisampleCoverageNVPtr;
        
        // glTextureImage2DMultisampleNV
        private delegate void TextureImage2DMultisampleNVDel(uint  texture, uint /*TextureTarget*/  target, uint  samples, int  internalFormat, uint  width, uint  height, bool /*Boolean*/  fixedSampleLocations); private static TextureImage2DMultisampleNVDel TextureImage2DMultisampleNVPtr;
        
        // glTextureImage3DEXT
        private delegate void TextureImage3DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, int /*CheckedInt32*/  border, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureImage3DEXTDel TextureImage3DEXTPtr;
        
        // glTextureImage3DMultisampleCoverageNV
        private delegate void TextureImage3DMultisampleCoverageNVDel(uint  texture, uint /*TextureTarget*/  target, uint  coverageSamples, uint  colorSamples, int  internalFormat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedSampleLocations); private static TextureImage3DMultisampleCoverageNVDel TextureImage3DMultisampleCoverageNVPtr;
        
        // glTextureImage3DMultisampleNV
        private delegate void TextureImage3DMultisampleNVDel(uint  texture, uint /*TextureTarget*/  target, uint  samples, int  internalFormat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedSampleLocations); private static TextureImage3DMultisampleNVDel TextureImage3DMultisampleNVPtr;
        
        // glTextureLightEXT
        private delegate void TextureLightEXTDel(uint /*LightTexturePNameEXT*/  pname); private static TextureLightEXTDel TextureLightEXTPtr;
        
        // glTextureMaterialEXT
        private delegate void TextureMaterialEXTDel(uint /*MaterialFace*/  face, uint /*MaterialParameter*/  mode); private static TextureMaterialEXTDel TextureMaterialEXTPtr;
        
        // glTextureNormalEXT
        private delegate void TextureNormalEXTDel(uint /*TextureNormalModeEXT*/  mode); private static TextureNormalEXTDel TextureNormalEXTPtr;
        
        // glTexturePageCommitmentEXT
        private delegate void TexturePageCommitmentEXTDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, bool /*Boolean*/  commit); private static TexturePageCommitmentEXTDel TexturePageCommitmentEXTPtr;
        
        // glTextureParameterIiv
        private delegate void TextureParameterIivDel(uint  texture, uint /*TextureParameterName*/  pname, int[]  parameters); private static TextureParameterIivDel TextureParameterIivPtr;
        
        // glTextureParameterIivEXT
        private delegate void TextureParameterIivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static TextureParameterIivEXTDel TextureParameterIivEXTPtr;
        
        // glTextureParameterIuiv
        private delegate void TextureParameterIuivDel(uint  texture, uint /*TextureParameterName*/  pname, uint[]  parameters); private static TextureParameterIuivDel TextureParameterIuivPtr;
        
        // glTextureParameterIuivEXT
        private delegate void TextureParameterIuivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, uint[]  parameters); private static TextureParameterIuivEXTDel TextureParameterIuivEXTPtr;
        
        // glTextureParameterf
        private delegate void TextureParameterfDel(uint  texture, uint /*TextureParameterName*/  pname, float  param); private static TextureParameterfDel TextureParameterfPtr;
        
        // glTextureParameterfEXT
        private delegate void TextureParameterfEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float /*CheckedFloat32*/  param); private static TextureParameterfEXTDel TextureParameterfEXTPtr;
        
        // glTextureParameterfv
        private delegate void TextureParameterfvDel(uint  texture, uint /*TextureParameterName*/  pname, float[]  param); private static TextureParameterfvDel TextureParameterfvPtr;
        
        // glTextureParameterfvEXT
        private delegate void TextureParameterfvEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, float[] /*CheckedFloat32*/  parameters); private static TextureParameterfvEXTDel TextureParameterfvEXTPtr;
        
        // glTextureParameteri
        private delegate void TextureParameteriDel(uint  texture, uint /*TextureParameterName*/  pname, int  param); private static TextureParameteriDel TextureParameteriPtr;
        
        // glTextureParameteriEXT
        private delegate void TextureParameteriEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int /*CheckedInt32*/  param); private static TextureParameteriEXTDel TextureParameteriEXTPtr;
        
        // glTextureParameteriv
        private delegate void TextureParameterivDel(uint  texture, uint /*TextureParameterName*/  pname, int[]  param); private static TextureParameterivDel TextureParameterivPtr;
        
        // glTextureParameterivEXT
        private delegate void TextureParameterivEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint /*TextureParameterName*/  pname, int[] /*CheckedInt32*/  parameters); private static TextureParameterivEXTDel TextureParameterivEXTPtr;
        
        // glTextureRangeAPPLE
        private delegate void TextureRangeAPPLEDel(uint  target, uint  length, IntPtr  pointer); private static TextureRangeAPPLEDel TextureRangeAPPLEPtr;
        
        // glTextureRenderbufferEXT
        private delegate void TextureRenderbufferEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint  renderbuffer); private static TextureRenderbufferEXTDel TextureRenderbufferEXTPtr;
        
        // glTextureStorage1D
        private delegate void TextureStorage1DDel(uint  texture, uint  levels, uint /*InternalFormat*/  internalformat, uint  width); private static TextureStorage1DDel TextureStorage1DPtr;
        
        // glTextureStorage1DEXT
        private delegate void TextureStorage1DEXTDel(uint  texture, uint  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width); private static TextureStorage1DEXTDel TextureStorage1DEXTPtr;
        
        // glTextureStorage2D
        private delegate void TextureStorage2DDel(uint  texture, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static TextureStorage2DDel TextureStorage2DPtr;
        
        // glTextureStorage2DEXT
        private delegate void TextureStorage2DEXTDel(uint  texture, uint  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height); private static TextureStorage2DEXTDel TextureStorage2DEXTPtr;
        
        // glTextureStorage2DMultisample
        private delegate void TextureStorage2DMultisampleDel(uint  texture, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, bool /*Boolean*/  fixedsamplelocations); private static TextureStorage2DMultisampleDel TextureStorage2DMultisamplePtr;
        
        // glTextureStorage2DMultisampleEXT
        private delegate void TextureStorage2DMultisampleEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, bool /*Boolean*/  fixedsamplelocations); private static TextureStorage2DMultisampleEXTDel TextureStorage2DMultisampleEXTPtr;
        
        // glTextureStorage3D
        private delegate void TextureStorage3DDel(uint  texture, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth); private static TextureStorage3DDel TextureStorage3DPtr;
        
        // glTextureStorage3DEXT
        private delegate void TextureStorage3DEXTDel(uint  texture, uint  target, uint  levels, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth); private static TextureStorage3DEXTDel TextureStorage3DEXTPtr;
        
        // glTextureStorage3DMultisample
        private delegate void TextureStorage3DMultisampleDel(uint  texture, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedsamplelocations); private static TextureStorage3DMultisampleDel TextureStorage3DMultisamplePtr;
        
        // glTextureStorage3DMultisampleEXT
        private delegate void TextureStorage3DMultisampleEXTDel(uint  texture, uint  target, uint  samples, uint /*InternalFormat*/  internalformat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedsamplelocations); private static TextureStorage3DMultisampleEXTDel TextureStorage3DMultisampleEXTPtr;
        
        // glTextureStorageMem1DEXT
        private delegate void TextureStorageMem1DEXTDel(uint  texture, uint  levels, uint  internalFormat, uint  width, uint  memory, ulong  offset); private static TextureStorageMem1DEXTDel TextureStorageMem1DEXTPtr;
        
        // glTextureStorageMem2DEXT
        private delegate void TextureStorageMem2DEXTDel(uint  texture, uint  levels, uint  internalFormat, uint  width, uint  height, uint  memory, ulong  offset); private static TextureStorageMem2DEXTDel TextureStorageMem2DEXTPtr;
        
        // glTextureStorageMem2DMultisampleEXT
        private delegate void TextureStorageMem2DMultisampleEXTDel(uint  texture, uint  samples, uint  internalFormat, uint  width, uint  height, bool /*Boolean*/  fixedSampleLocations, uint  memory, ulong  offset); private static TextureStorageMem2DMultisampleEXTDel TextureStorageMem2DMultisampleEXTPtr;
        
        // glTextureStorageMem3DEXT
        private delegate void TextureStorageMem3DEXTDel(uint  texture, uint  levels, uint  internalFormat, uint  width, uint  height, uint  depth, uint  memory, ulong  offset); private static TextureStorageMem3DEXTDel TextureStorageMem3DEXTPtr;
        
        // glTextureStorageMem3DMultisampleEXT
        private delegate void TextureStorageMem3DMultisampleEXTDel(uint  texture, uint  samples, uint  internalFormat, uint  width, uint  height, uint  depth, bool /*Boolean*/  fixedSampleLocations, uint  memory, ulong  offset); private static TextureStorageMem3DMultisampleEXTDel TextureStorageMem3DMultisampleEXTPtr;
        
        // glTextureStorageSparseAMD
        private delegate void TextureStorageSparseAMDDel(uint  texture, uint  target, uint /*InternalFormat*/  internalFormat, uint  width, uint  height, uint  depth, uint  layers, uint /*TextureStorageMaskAMD*/  flags); private static TextureStorageSparseAMDDel TextureStorageSparseAMDPtr;
        
        // glTextureSubImage1D
        private delegate void TextureSubImage1DDel(uint  texture, int  level, int  xoffset, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage1DDel TextureSubImage1DPtr;
        
        // glTextureSubImage1DEXT
        private delegate void TextureSubImage1DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, uint  width, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage1DEXTDel TextureSubImage1DEXTPtr;
        
        // glTextureSubImage2D
        private delegate void TextureSubImage2DDel(uint  texture, int  level, int  xoffset, int  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage2DDel TextureSubImage2DPtr;
        
        // glTextureSubImage2DEXT
        private delegate void TextureSubImage2DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, uint  width, uint  height, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage2DEXTDel TextureSubImage2DEXTPtr;
        
        // glTextureSubImage3D
        private delegate void TextureSubImage3DDel(uint  texture, int  level, int  xoffset, int  yoffset, int  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage3DDel TextureSubImage3DPtr;
        
        // glTextureSubImage3DEXT
        private delegate void TextureSubImage3DEXTDel(uint /*Texture*/  texture, uint /*TextureTarget*/  target, int /*CheckedInt32*/  level, int /*CheckedInt32*/  xoffset, int /*CheckedInt32*/  yoffset, int /*CheckedInt32*/  zoffset, uint  width, uint  height, uint  depth, uint /*PixelFormat*/  format, uint /*PixelType*/  type, IntPtr  pixels); private static TextureSubImage3DEXTDel TextureSubImage3DEXTPtr;
        
        // glTextureView
        private delegate void TextureViewDel(uint  texture, uint /*TextureTarget*/  target, uint  origtexture, uint /*InternalFormat*/  internalformat, uint  minlevel, uint  numlevels, uint  minlayer, uint  numlayers); private static TextureViewDel TextureViewPtr;
        
        // glTextureViewEXT
        private delegate void TextureViewEXTDel(uint  texture, uint /*TextureTarget*/  target, uint  origtexture, uint /*InternalFormat*/  internalformat, uint  minlevel, uint  numlevels, uint  minlayer, uint  numlayers); private static TextureViewEXTDel TextureViewEXTPtr;
        
        // glTextureViewOES
        private delegate void TextureViewOESDel(uint  texture, uint /*TextureTarget*/  target, uint  origtexture, uint /*InternalFormat*/  internalformat, uint  minlevel, uint  numlevels, uint  minlayer, uint  numlayers); private static TextureViewOESDel TextureViewOESPtr;
        
        // glTrackMatrixNV
        private delegate void TrackMatrixNVDel(uint /*VertexAttribEnumNV*/  target, uint  address, uint /*VertexAttribEnumNV*/  matrix, uint /*VertexAttribEnumNV*/  transform); private static TrackMatrixNVDel TrackMatrixNVPtr;
        
        // glTransformFeedbackAttribsNV
        private delegate void TransformFeedbackAttribsNVDel(uint  count, int[]  attribs, uint  bufferMode); private static TransformFeedbackAttribsNVDel TransformFeedbackAttribsNVPtr;
        
        // glTransformFeedbackBufferBase
        private delegate void TransformFeedbackBufferBaseDel(uint  xfb, uint  index, uint  buffer); private static TransformFeedbackBufferBaseDel TransformFeedbackBufferBasePtr;
        
        // glTransformFeedbackBufferRange
        private delegate void TransformFeedbackBufferRangeDel(uint  xfb, uint  index, uint  buffer, IntPtr  offset, IntPtr /*BufferSize*/  size); private static TransformFeedbackBufferRangeDel TransformFeedbackBufferRangePtr;
        
        // glTransformFeedbackStreamAttribsNV
        private delegate void TransformFeedbackStreamAttribsNVDel(uint  count, int[]  attribs, uint  nbuffers, int[]  bufstreams, uint  bufferMode); private static TransformFeedbackStreamAttribsNVDel TransformFeedbackStreamAttribsNVPtr;
        
        // glTransformFeedbackVaryings
        private delegate void TransformFeedbackVaryingsDel(uint  program, uint  count, string  varyings, uint /*TransformFeedbackBufferMode*/  bufferMode); private static TransformFeedbackVaryingsDel TransformFeedbackVaryingsPtr;
        
        // glTransformFeedbackVaryingsEXT
        private delegate void TransformFeedbackVaryingsEXTDel(uint  program, uint  count, string  varyings, uint  bufferMode); private static TransformFeedbackVaryingsEXTDel TransformFeedbackVaryingsEXTPtr;
        
        // glTransformFeedbackVaryingsNV
        private delegate void TransformFeedbackVaryingsNVDel(uint  program, uint  count, int[]  locations, uint  bufferMode); private static TransformFeedbackVaryingsNVDel TransformFeedbackVaryingsNVPtr;
        
        // glTransformPathNV
        private delegate void TransformPathNVDel(uint /*Path*/  resultPath, uint /*Path*/  srcPath, uint /*PathTransformType*/  transformType, float[]  transformValues); private static TransformPathNVDel TransformPathNVPtr;
        
        // glTranslated
        private delegate void TranslatedDel(double  x, double  y, double  z); private static TranslatedDel TranslatedPtr;
        
        // glTranslatef
        private delegate void TranslatefDel(float  x, float  y, float  z); private static TranslatefDel TranslatefPtr;
        
        // glTranslatex
        private delegate void TranslatexDel(int  x, int  y, int  z); private static TranslatexDel TranslatexPtr;
        
        // glTranslatexOES
        private delegate void TranslatexOESDel(int  x, int  y, int  z); private static TranslatexOESDel TranslatexOESPtr;
        
        // glUniform1d
        private delegate void Uniform1dDel(int  location, double  x); private static Uniform1dDel Uniform1dPtr;
        
        // glUniform1dv
        private delegate void Uniform1dvDel(int  location, uint  count, double[]  value); private static Uniform1dvDel Uniform1dvPtr;
        
        // glUniform1f
        private delegate void Uniform1fDel(int  location, float  v0); private static Uniform1fDel Uniform1fPtr;
        
        // glUniform1fARB
        private delegate void Uniform1fARBDel(int  location, float  v0); private static Uniform1fARBDel Uniform1fARBPtr;
        
        // glUniform1fv
        private delegate void Uniform1fvDel(int  location, uint  count, float[]  value); private static Uniform1fvDel Uniform1fvPtr;
        
        // glUniform1fvARB
        private delegate void Uniform1fvARBDel(int  location, uint  count, float[]  value); private static Uniform1fvARBDel Uniform1fvARBPtr;
        
        // glUniform1i
        private delegate void Uniform1iDel(int  location, int  v0); private static Uniform1iDel Uniform1iPtr;
        
        // glUniform1i64ARB
        private delegate void Uniform1i64ARBDel(int  location, long  x); private static Uniform1i64ARBDel Uniform1i64ARBPtr;
        
        // glUniform1i64NV
        private delegate void Uniform1i64NVDel(int  location, long  x); private static Uniform1i64NVDel Uniform1i64NVPtr;
        
        // glUniform1i64vARB
        private delegate void Uniform1i64vARBDel(int  location, uint  count, long[]  value); private static Uniform1i64vARBDel Uniform1i64vARBPtr;
        
        // glUniform1i64vNV
        private delegate void Uniform1i64vNVDel(int  location, uint  count, long[]  value); private static Uniform1i64vNVDel Uniform1i64vNVPtr;
        
        // glUniform1iARB
        private delegate void Uniform1iARBDel(int  location, int  v0); private static Uniform1iARBDel Uniform1iARBPtr;
        
        // glUniform1iv
        private delegate void Uniform1ivDel(int  location, uint  count, int[]  value); private static Uniform1ivDel Uniform1ivPtr;
        
        // glUniform1ivARB
        private delegate void Uniform1ivARBDel(int  location, uint  count, int[]  value); private static Uniform1ivARBDel Uniform1ivARBPtr;
        
        // glUniform1ui
        private delegate void Uniform1uiDel(int  location, uint  v0); private static Uniform1uiDel Uniform1uiPtr;
        
        // glUniform1ui64ARB
        private delegate void Uniform1ui64ARBDel(int  location, ulong  x); private static Uniform1ui64ARBDel Uniform1ui64ARBPtr;
        
        // glUniform1ui64NV
        private delegate void Uniform1ui64NVDel(int  location, ulong  x); private static Uniform1ui64NVDel Uniform1ui64NVPtr;
        
        // glUniform1ui64vARB
        private delegate void Uniform1ui64vARBDel(int  location, uint  count, ulong[]  value); private static Uniform1ui64vARBDel Uniform1ui64vARBPtr;
        
        // glUniform1ui64vNV
        private delegate void Uniform1ui64vNVDel(int  location, uint  count, ulong[]  value); private static Uniform1ui64vNVDel Uniform1ui64vNVPtr;
        
        // glUniform1uiEXT
        private delegate void Uniform1uiEXTDel(int  location, uint  v0); private static Uniform1uiEXTDel Uniform1uiEXTPtr;
        
        // glUniform1uiv
        private delegate void Uniform1uivDel(int  location, uint  count, uint[]  value); private static Uniform1uivDel Uniform1uivPtr;
        
        // glUniform1uivEXT
        private delegate void Uniform1uivEXTDel(int  location, uint  count, uint[]  value); private static Uniform1uivEXTDel Uniform1uivEXTPtr;
        
        // glUniform2d
        private delegate void Uniform2dDel(int  location, double  x, double  y); private static Uniform2dDel Uniform2dPtr;
        
        // glUniform2dv
        private delegate void Uniform2dvDel(int  location, uint  count, double[]  value); private static Uniform2dvDel Uniform2dvPtr;
        
        // glUniform2f
        private delegate void Uniform2fDel(int  location, float  v0, float  v1); private static Uniform2fDel Uniform2fPtr;
        
        // glUniform2fARB
        private delegate void Uniform2fARBDel(int  location, float  v0, float  v1); private static Uniform2fARBDel Uniform2fARBPtr;
        
        // glUniform2fv
        private delegate void Uniform2fvDel(int  location, uint  count, float[]  value); private static Uniform2fvDel Uniform2fvPtr;
        
        // glUniform2fvARB
        private delegate void Uniform2fvARBDel(int  location, uint  count, float[]  value); private static Uniform2fvARBDel Uniform2fvARBPtr;
        
        // glUniform2i
        private delegate void Uniform2iDel(int  location, int  v0, int  v1); private static Uniform2iDel Uniform2iPtr;
        
        // glUniform2i64ARB
        private delegate void Uniform2i64ARBDel(int  location, long  x, long  y); private static Uniform2i64ARBDel Uniform2i64ARBPtr;
        
        // glUniform2i64NV
        private delegate void Uniform2i64NVDel(int  location, long  x, long  y); private static Uniform2i64NVDel Uniform2i64NVPtr;
        
        // glUniform2i64vARB
        private delegate void Uniform2i64vARBDel(int  location, uint  count, long[]  value); private static Uniform2i64vARBDel Uniform2i64vARBPtr;
        
        // glUniform2i64vNV
        private delegate void Uniform2i64vNVDel(int  location, uint  count, long[]  value); private static Uniform2i64vNVDel Uniform2i64vNVPtr;
        
        // glUniform2iARB
        private delegate void Uniform2iARBDel(int  location, int  v0, int  v1); private static Uniform2iARBDel Uniform2iARBPtr;
        
        // glUniform2iv
        private delegate void Uniform2ivDel(int  location, uint  count, int[]  value); private static Uniform2ivDel Uniform2ivPtr;
        
        // glUniform2ivARB
        private delegate void Uniform2ivARBDel(int  location, uint  count, int[]  value); private static Uniform2ivARBDel Uniform2ivARBPtr;
        
        // glUniform2ui
        private delegate void Uniform2uiDel(int  location, uint  v0, uint  v1); private static Uniform2uiDel Uniform2uiPtr;
        
        // glUniform2ui64ARB
        private delegate void Uniform2ui64ARBDel(int  location, ulong  x, ulong  y); private static Uniform2ui64ARBDel Uniform2ui64ARBPtr;
        
        // glUniform2ui64NV
        private delegate void Uniform2ui64NVDel(int  location, ulong  x, ulong  y); private static Uniform2ui64NVDel Uniform2ui64NVPtr;
        
        // glUniform2ui64vARB
        private delegate void Uniform2ui64vARBDel(int  location, uint  count, ulong[]  value); private static Uniform2ui64vARBDel Uniform2ui64vARBPtr;
        
        // glUniform2ui64vNV
        private delegate void Uniform2ui64vNVDel(int  location, uint  count, ulong[]  value); private static Uniform2ui64vNVDel Uniform2ui64vNVPtr;
        
        // glUniform2uiEXT
        private delegate void Uniform2uiEXTDel(int  location, uint  v0, uint  v1); private static Uniform2uiEXTDel Uniform2uiEXTPtr;
        
        // glUniform2uiv
        private delegate void Uniform2uivDel(int  location, uint  count, uint[]  value); private static Uniform2uivDel Uniform2uivPtr;
        
        // glUniform2uivEXT
        private delegate void Uniform2uivEXTDel(int  location, uint  count, uint[]  value); private static Uniform2uivEXTDel Uniform2uivEXTPtr;
        
        // glUniform3d
        private delegate void Uniform3dDel(int  location, double  x, double  y, double  z); private static Uniform3dDel Uniform3dPtr;
        
        // glUniform3dv
        private delegate void Uniform3dvDel(int  location, uint  count, double[]  value); private static Uniform3dvDel Uniform3dvPtr;
        
        // glUniform3f
        private delegate void Uniform3fDel(int  location, float  v0, float  v1, float  v2); private static Uniform3fDel Uniform3fPtr;
        
        // glUniform3fARB
        private delegate void Uniform3fARBDel(int  location, float  v0, float  v1, float  v2); private static Uniform3fARBDel Uniform3fARBPtr;
        
        // glUniform3fv
        private delegate void Uniform3fvDel(int  location, uint  count, float[]  value); private static Uniform3fvDel Uniform3fvPtr;
        
        // glUniform3fvARB
        private delegate void Uniform3fvARBDel(int  location, uint  count, float[]  value); private static Uniform3fvARBDel Uniform3fvARBPtr;
        
        // glUniform3i
        private delegate void Uniform3iDel(int  location, int  v0, int  v1, int  v2); private static Uniform3iDel Uniform3iPtr;
        
        // glUniform3i64ARB
        private delegate void Uniform3i64ARBDel(int  location, long  x, long  y, long  z); private static Uniform3i64ARBDel Uniform3i64ARBPtr;
        
        // glUniform3i64NV
        private delegate void Uniform3i64NVDel(int  location, long  x, long  y, long  z); private static Uniform3i64NVDel Uniform3i64NVPtr;
        
        // glUniform3i64vARB
        private delegate void Uniform3i64vARBDel(int  location, uint  count, long[]  value); private static Uniform3i64vARBDel Uniform3i64vARBPtr;
        
        // glUniform3i64vNV
        private delegate void Uniform3i64vNVDel(int  location, uint  count, long[]  value); private static Uniform3i64vNVDel Uniform3i64vNVPtr;
        
        // glUniform3iARB
        private delegate void Uniform3iARBDel(int  location, int  v0, int  v1, int  v2); private static Uniform3iARBDel Uniform3iARBPtr;
        
        // glUniform3iv
        private delegate void Uniform3ivDel(int  location, uint  count, int[]  value); private static Uniform3ivDel Uniform3ivPtr;
        
        // glUniform3ivARB
        private delegate void Uniform3ivARBDel(int  location, uint  count, int[]  value); private static Uniform3ivARBDel Uniform3ivARBPtr;
        
        // glUniform3ui
        private delegate void Uniform3uiDel(int  location, uint  v0, uint  v1, uint  v2); private static Uniform3uiDel Uniform3uiPtr;
        
        // glUniform3ui64ARB
        private delegate void Uniform3ui64ARBDel(int  location, ulong  x, ulong  y, ulong  z); private static Uniform3ui64ARBDel Uniform3ui64ARBPtr;
        
        // glUniform3ui64NV
        private delegate void Uniform3ui64NVDel(int  location, ulong  x, ulong  y, ulong  z); private static Uniform3ui64NVDel Uniform3ui64NVPtr;
        
        // glUniform3ui64vARB
        private delegate void Uniform3ui64vARBDel(int  location, uint  count, ulong[]  value); private static Uniform3ui64vARBDel Uniform3ui64vARBPtr;
        
        // glUniform3ui64vNV
        private delegate void Uniform3ui64vNVDel(int  location, uint  count, ulong[]  value); private static Uniform3ui64vNVDel Uniform3ui64vNVPtr;
        
        // glUniform3uiEXT
        private delegate void Uniform3uiEXTDel(int  location, uint  v0, uint  v1, uint  v2); private static Uniform3uiEXTDel Uniform3uiEXTPtr;
        
        // glUniform3uiv
        private delegate void Uniform3uivDel(int  location, uint  count, uint[]  value); private static Uniform3uivDel Uniform3uivPtr;
        
        // glUniform3uivEXT
        private delegate void Uniform3uivEXTDel(int  location, uint  count, uint[]  value); private static Uniform3uivEXTDel Uniform3uivEXTPtr;
        
        // glUniform4d
        private delegate void Uniform4dDel(int  location, double  x, double  y, double  z, double  w); private static Uniform4dDel Uniform4dPtr;
        
        // glUniform4dv
        private delegate void Uniform4dvDel(int  location, uint  count, double[]  value); private static Uniform4dvDel Uniform4dvPtr;
        
        // glUniform4f
        private delegate void Uniform4fDel(int  location, float  v0, float  v1, float  v2, float  v3); private static Uniform4fDel Uniform4fPtr;
        
        // glUniform4fARB
        private delegate void Uniform4fARBDel(int  location, float  v0, float  v1, float  v2, float  v3); private static Uniform4fARBDel Uniform4fARBPtr;
        
        // glUniform4fv
        private delegate void Uniform4fvDel(int  location, uint  count, float[]  value); private static Uniform4fvDel Uniform4fvPtr;
        
        // glUniform4fvARB
        private delegate void Uniform4fvARBDel(int  location, uint  count, float[]  value); private static Uniform4fvARBDel Uniform4fvARBPtr;
        
        // glUniform4i
        private delegate void Uniform4iDel(int  location, int  v0, int  v1, int  v2, int  v3); private static Uniform4iDel Uniform4iPtr;
        
        // glUniform4i64ARB
        private delegate void Uniform4i64ARBDel(int  location, long  x, long  y, long  z, long  w); private static Uniform4i64ARBDel Uniform4i64ARBPtr;
        
        // glUniform4i64NV
        private delegate void Uniform4i64NVDel(int  location, long  x, long  y, long  z, long  w); private static Uniform4i64NVDel Uniform4i64NVPtr;
        
        // glUniform4i64vARB
        private delegate void Uniform4i64vARBDel(int  location, uint  count, long[]  value); private static Uniform4i64vARBDel Uniform4i64vARBPtr;
        
        // glUniform4i64vNV
        private delegate void Uniform4i64vNVDel(int  location, uint  count, long[]  value); private static Uniform4i64vNVDel Uniform4i64vNVPtr;
        
        // glUniform4iARB
        private delegate void Uniform4iARBDel(int  location, int  v0, int  v1, int  v2, int  v3); private static Uniform4iARBDel Uniform4iARBPtr;
        
        // glUniform4iv
        private delegate void Uniform4ivDel(int  location, uint  count, int[]  value); private static Uniform4ivDel Uniform4ivPtr;
        
        // glUniform4ivARB
        private delegate void Uniform4ivARBDel(int  location, uint  count, int[]  value); private static Uniform4ivARBDel Uniform4ivARBPtr;
        
        // glUniform4ui
        private delegate void Uniform4uiDel(int  location, uint  v0, uint  v1, uint  v2, uint  v3); private static Uniform4uiDel Uniform4uiPtr;
        
        // glUniform4ui64ARB
        private delegate void Uniform4ui64ARBDel(int  location, ulong  x, ulong  y, ulong  z, ulong  w); private static Uniform4ui64ARBDel Uniform4ui64ARBPtr;
        
        // glUniform4ui64NV
        private delegate void Uniform4ui64NVDel(int  location, ulong  x, ulong  y, ulong  z, ulong  w); private static Uniform4ui64NVDel Uniform4ui64NVPtr;
        
        // glUniform4ui64vARB
        private delegate void Uniform4ui64vARBDel(int  location, uint  count, ulong[]  value); private static Uniform4ui64vARBDel Uniform4ui64vARBPtr;
        
        // glUniform4ui64vNV
        private delegate void Uniform4ui64vNVDel(int  location, uint  count, ulong[]  value); private static Uniform4ui64vNVDel Uniform4ui64vNVPtr;
        
        // glUniform4uiEXT
        private delegate void Uniform4uiEXTDel(int  location, uint  v0, uint  v1, uint  v2, uint  v3); private static Uniform4uiEXTDel Uniform4uiEXTPtr;
        
        // glUniform4uiv
        private delegate void Uniform4uivDel(int  location, uint  count, uint[]  value); private static Uniform4uivDel Uniform4uivPtr;
        
        // glUniform4uivEXT
        private delegate void Uniform4uivEXTDel(int  location, uint  count, uint[]  value); private static Uniform4uivEXTDel Uniform4uivEXTPtr;
        
        // glUniformBlockBinding
        private delegate void UniformBlockBindingDel(uint  program, uint  uniformBlockIndex, uint  uniformBlockBinding); private static UniformBlockBindingDel UniformBlockBindingPtr;
        
        // glUniformBufferEXT
        private delegate void UniformBufferEXTDel(uint  program, int  location, uint  buffer); private static UniformBufferEXTDel UniformBufferEXTPtr;
        
        // glUniformHandleui64ARB
        private delegate void UniformHandleui64ARBDel(int  location, ulong  value); private static UniformHandleui64ARBDel UniformHandleui64ARBPtr;
        
        // glUniformHandleui64IMG
        private delegate void UniformHandleui64IMGDel(int  location, ulong  value); private static UniformHandleui64IMGDel UniformHandleui64IMGPtr;
        
        // glUniformHandleui64NV
        private delegate void UniformHandleui64NVDel(int  location, ulong  value); private static UniformHandleui64NVDel UniformHandleui64NVPtr;
        
        // glUniformHandleui64vARB
        private delegate void UniformHandleui64vARBDel(int  location, uint  count, ulong[]  value); private static UniformHandleui64vARBDel UniformHandleui64vARBPtr;
        
        // glUniformHandleui64vIMG
        private delegate void UniformHandleui64vIMGDel(int  location, uint  count, ulong[]  value); private static UniformHandleui64vIMGDel UniformHandleui64vIMGPtr;
        
        // glUniformHandleui64vNV
        private delegate void UniformHandleui64vNVDel(int  location, uint  count, ulong[]  value); private static UniformHandleui64vNVDel UniformHandleui64vNVPtr;
        
        // glUniformMatrix2dv
        private delegate void UniformMatrix2dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix2dvDel UniformMatrix2dvPtr;
        
        // glUniformMatrix2fv
        private delegate void UniformMatrix2fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2fvDel UniformMatrix2fvPtr;
        
        // glUniformMatrix2fvARB
        private delegate void UniformMatrix2fvARBDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2fvARBDel UniformMatrix2fvARBPtr;
        
        // glUniformMatrix2x3dv
        private delegate void UniformMatrix2x3dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix2x3dvDel UniformMatrix2x3dvPtr;
        
        // glUniformMatrix2x3fv
        private delegate void UniformMatrix2x3fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2x3fvDel UniformMatrix2x3fvPtr;
        
        // glUniformMatrix2x3fvNV
        private delegate void UniformMatrix2x3fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2x3fvNVDel UniformMatrix2x3fvNVPtr;
        
        // glUniformMatrix2x4dv
        private delegate void UniformMatrix2x4dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix2x4dvDel UniformMatrix2x4dvPtr;
        
        // glUniformMatrix2x4fv
        private delegate void UniformMatrix2x4fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2x4fvDel UniformMatrix2x4fvPtr;
        
        // glUniformMatrix2x4fvNV
        private delegate void UniformMatrix2x4fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix2x4fvNVDel UniformMatrix2x4fvNVPtr;
        
        // glUniformMatrix3dv
        private delegate void UniformMatrix3dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix3dvDel UniformMatrix3dvPtr;
        
        // glUniformMatrix3fv
        private delegate void UniformMatrix3fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3fvDel UniformMatrix3fvPtr;
        
        // glUniformMatrix3fvARB
        private delegate void UniformMatrix3fvARBDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3fvARBDel UniformMatrix3fvARBPtr;
        
        // glUniformMatrix3x2dv
        private delegate void UniformMatrix3x2dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix3x2dvDel UniformMatrix3x2dvPtr;
        
        // glUniformMatrix3x2fv
        private delegate void UniformMatrix3x2fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3x2fvDel UniformMatrix3x2fvPtr;
        
        // glUniformMatrix3x2fvNV
        private delegate void UniformMatrix3x2fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3x2fvNVDel UniformMatrix3x2fvNVPtr;
        
        // glUniformMatrix3x4dv
        private delegate void UniformMatrix3x4dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix3x4dvDel UniformMatrix3x4dvPtr;
        
        // glUniformMatrix3x4fv
        private delegate void UniformMatrix3x4fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3x4fvDel UniformMatrix3x4fvPtr;
        
        // glUniformMatrix3x4fvNV
        private delegate void UniformMatrix3x4fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix3x4fvNVDel UniformMatrix3x4fvNVPtr;
        
        // glUniformMatrix4dv
        private delegate void UniformMatrix4dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix4dvDel UniformMatrix4dvPtr;
        
        // glUniformMatrix4fv
        private delegate void UniformMatrix4fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4fvDel UniformMatrix4fvPtr;
        
        // glUniformMatrix4fvARB
        private delegate void UniformMatrix4fvARBDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4fvARBDel UniformMatrix4fvARBPtr;
        
        // glUniformMatrix4x2dv
        private delegate void UniformMatrix4x2dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix4x2dvDel UniformMatrix4x2dvPtr;
        
        // glUniformMatrix4x2fv
        private delegate void UniformMatrix4x2fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4x2fvDel UniformMatrix4x2fvPtr;
        
        // glUniformMatrix4x2fvNV
        private delegate void UniformMatrix4x2fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4x2fvNVDel UniformMatrix4x2fvNVPtr;
        
        // glUniformMatrix4x3dv
        private delegate void UniformMatrix4x3dvDel(int  location, uint  count, bool /*Boolean*/  transpose, double[]  value); private static UniformMatrix4x3dvDel UniformMatrix4x3dvPtr;
        
        // glUniformMatrix4x3fv
        private delegate void UniformMatrix4x3fvDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4x3fvDel UniformMatrix4x3fvPtr;
        
        // glUniformMatrix4x3fvNV
        private delegate void UniformMatrix4x3fvNVDel(int  location, uint  count, bool /*Boolean*/  transpose, float[]  value); private static UniformMatrix4x3fvNVDel UniformMatrix4x3fvNVPtr;
        
        // glUniformSubroutinesuiv
        private delegate void UniformSubroutinesuivDel(uint /*ShaderType*/  shadertype, uint  count, uint[]  indices); private static UniformSubroutinesuivDel UniformSubroutinesuivPtr;
        
        // glUniformui64NV
        private delegate void Uniformui64NVDel(int  location, ulong  value); private static Uniformui64NVDel Uniformui64NVPtr;
        
        // glUniformui64vNV
        private delegate void Uniformui64vNVDel(int  location, uint  count, ulong[]  value); private static Uniformui64vNVDel Uniformui64vNVPtr;
        
        // glUnlockArraysEXT
        private delegate void UnlockArraysEXTDel(); private static UnlockArraysEXTDel UnlockArraysEXTPtr;
        
        // glUnmapBuffer
        private delegate bool /*Boolean*/ UnmapBufferDel(uint /*BufferTargetARB*/  target); private static UnmapBufferDel UnmapBufferPtr;
        
        // glUnmapBufferARB
        private delegate bool /*Boolean*/ UnmapBufferARBDel(uint /*BufferTargetARB*/  target); private static UnmapBufferARBDel UnmapBufferARBPtr;
        
        // glUnmapBufferOES
        private delegate bool /*Boolean*/ UnmapBufferOESDel(uint  target); private static UnmapBufferOESDel UnmapBufferOESPtr;
        
        // glUnmapNamedBuffer
        private delegate bool /*Boolean*/ UnmapNamedBufferDel(uint  buffer); private static UnmapNamedBufferDel UnmapNamedBufferPtr;
        
        // glUnmapNamedBufferEXT
        private delegate bool /*Boolean*/ UnmapNamedBufferEXTDel(uint  buffer); private static UnmapNamedBufferEXTDel UnmapNamedBufferEXTPtr;
        
        // glUnmapObjectBufferATI
        private delegate void UnmapObjectBufferATIDel(uint  buffer); private static UnmapObjectBufferATIDel UnmapObjectBufferATIPtr;
        
        // glUnmapTexture2DINTEL
        private delegate void UnmapTexture2DINTELDel(uint  texture, int  level); private static UnmapTexture2DINTELDel UnmapTexture2DINTELPtr;
        
        // glUpdateObjectBufferATI
        private delegate void UpdateObjectBufferATIDel(uint  buffer, uint  offset, uint  size, IntPtr  pointer, uint /*PreserveModeATI*/  preserve); private static UpdateObjectBufferATIDel UpdateObjectBufferATIPtr;
        
        // glUploadGpuMaskNVX
        private delegate void UploadGpuMaskNVXDel(uint  mask); private static UploadGpuMaskNVXDel UploadGpuMaskNVXPtr;
        
        // glUseProgram
        private delegate void UseProgramDel(uint  program); private static UseProgramDel UseProgramPtr;
        
        // glUseProgramObjectARB
        private delegate void UseProgramObjectARBDel(IntPtr /*handleARB*/  programObj); private static UseProgramObjectARBDel UseProgramObjectARBPtr;
        
        // glUseProgramStages
        private delegate void UseProgramStagesDel(uint  pipeline, uint /*UseProgramStageMask*/  stages, uint  program); private static UseProgramStagesDel UseProgramStagesPtr;
        
        // glUseProgramStagesEXT
        private delegate void UseProgramStagesEXTDel(uint  pipeline, uint /*UseProgramStageMask*/  stages, uint  program); private static UseProgramStagesEXTDel UseProgramStagesEXTPtr;
        
        // glUseShaderProgramEXT
        private delegate void UseShaderProgramEXTDel(uint  type, uint  program); private static UseShaderProgramEXTDel UseShaderProgramEXTPtr;
        
        // glVDPAUFiniNV
        private delegate void VDPAUFiniNVDel(); private static VDPAUFiniNVDel VDPAUFiniNVPtr;
        
        // glVDPAUGetSurfaceivNV
        private delegate void VDPAUGetSurfaceivNVDel(IntPtr /*vdpauSurfaceNV*/  surface, uint  pname, uint  count, uint[]  length, int[]  values); private static VDPAUGetSurfaceivNVDel VDPAUGetSurfaceivNVPtr;
        
        // glVDPAUInitNV
        private delegate void VDPAUInitNVDel(IntPtr  vdpDevice, IntPtr  getProcAddress); private static VDPAUInitNVDel VDPAUInitNVPtr;
        
        // glVDPAUIsSurfaceNV
        private delegate bool /*Boolean*/ VDPAUIsSurfaceNVDel(IntPtr /*vdpauSurfaceNV*/  surface); private static VDPAUIsSurfaceNVDel VDPAUIsSurfaceNVPtr;
        
        // glVDPAUMapSurfacesNV
        private delegate void VDPAUMapSurfacesNVDel(uint  numSurfaces, IntPtr[] /*vdpauSurfaceNV*/  surfaces); private static VDPAUMapSurfacesNVDel VDPAUMapSurfacesNVPtr;
        
        // glVDPAURegisterOutputSurfaceNV
        private delegate IntPtr /*vdpauSurfaceNV*/ VDPAURegisterOutputSurfaceNVDel(IntPtr  vdpSurface, uint  target, uint  numTextureNames, uint[]  textureNames); private static VDPAURegisterOutputSurfaceNVDel VDPAURegisterOutputSurfaceNVPtr;
        
        // glVDPAURegisterVideoSurfaceNV
        private delegate IntPtr /*vdpauSurfaceNV*/ VDPAURegisterVideoSurfaceNVDel(IntPtr  vdpSurface, uint  target, uint  numTextureNames, uint[]  textureNames); private static VDPAURegisterVideoSurfaceNVDel VDPAURegisterVideoSurfaceNVPtr;
        
        // glVDPAURegisterVideoSurfaceWithPictureStructureNV
        private delegate IntPtr /*vdpauSurfaceNV*/ VDPAURegisterVideoSurfaceWithPictureStructureNVDel(IntPtr  vdpSurface, uint  target, uint  numTextureNames, uint[]  textureNames, bool /*Boolean*/  isFrameStructure); private static VDPAURegisterVideoSurfaceWithPictureStructureNVDel VDPAURegisterVideoSurfaceWithPictureStructureNVPtr;
        
        // glVDPAUSurfaceAccessNV
        private delegate void VDPAUSurfaceAccessNVDel(IntPtr /*vdpauSurfaceNV*/  surface, uint  access); private static VDPAUSurfaceAccessNVDel VDPAUSurfaceAccessNVPtr;
        
        // glVDPAUUnmapSurfacesNV
        private delegate void VDPAUUnmapSurfacesNVDel(uint  numSurface, IntPtr[] /*vdpauSurfaceNV*/  surfaces); private static VDPAUUnmapSurfacesNVDel VDPAUUnmapSurfacesNVPtr;
        
        // glVDPAUUnregisterSurfaceNV
        private delegate void VDPAUUnregisterSurfaceNVDel(IntPtr /*vdpauSurfaceNV*/  surface); private static VDPAUUnregisterSurfaceNVDel VDPAUUnregisterSurfaceNVPtr;
        
        // glValidateProgram
        private delegate void ValidateProgramDel(uint  program); private static ValidateProgramDel ValidateProgramPtr;
        
        // glValidateProgramARB
        private delegate void ValidateProgramARBDel(IntPtr /*handleARB*/  programObj); private static ValidateProgramARBDel ValidateProgramARBPtr;
        
        // glValidateProgramPipeline
        private delegate void ValidateProgramPipelineDel(uint  pipeline); private static ValidateProgramPipelineDel ValidateProgramPipelinePtr;
        
        // glValidateProgramPipelineEXT
        private delegate void ValidateProgramPipelineEXTDel(uint  pipeline); private static ValidateProgramPipelineEXTDel ValidateProgramPipelineEXTPtr;
        
        // glVariantArrayObjectATI
        private delegate void VariantArrayObjectATIDel(uint  id, uint /*ScalarType*/  type, uint  stride, uint  buffer, uint  offset); private static VariantArrayObjectATIDel VariantArrayObjectATIPtr;
        
        // glVariantPointerEXT
        private delegate void VariantPointerEXTDel(uint  id, uint /*ScalarType*/  type, uint  stride, IntPtr  addr); private static VariantPointerEXTDel VariantPointerEXTPtr;
        
        // glVariantbvEXT
        private delegate void VariantbvEXTDel(uint  id, sbyte[]  addr); private static VariantbvEXTDel VariantbvEXTPtr;
        
        // glVariantdvEXT
        private delegate void VariantdvEXTDel(uint  id, double[]  addr); private static VariantdvEXTDel VariantdvEXTPtr;
        
        // glVariantfvEXT
        private delegate void VariantfvEXTDel(uint  id, float[]  addr); private static VariantfvEXTDel VariantfvEXTPtr;
        
        // glVariantivEXT
        private delegate void VariantivEXTDel(uint  id, int[]  addr); private static VariantivEXTDel VariantivEXTPtr;
        
        // glVariantsvEXT
        private delegate void VariantsvEXTDel(uint  id, short[]  addr); private static VariantsvEXTDel VariantsvEXTPtr;
        
        // glVariantubvEXT
        private delegate void VariantubvEXTDel(uint  id, byte[]  addr); private static VariantubvEXTDel VariantubvEXTPtr;
        
        // glVariantuivEXT
        private delegate void VariantuivEXTDel(uint  id, uint[]  addr); private static VariantuivEXTDel VariantuivEXTPtr;
        
        // glVariantusvEXT
        private delegate void VariantusvEXTDel(uint  id, ushort[]  addr); private static VariantusvEXTDel VariantusvEXTPtr;
        
        // glVertex2bOES
        private delegate void Vertex2bOESDel(sbyte  x, sbyte  y); private static Vertex2bOESDel Vertex2bOESPtr;
        
        // glVertex2bvOES
        private delegate void Vertex2bvOESDel(sbyte[]  coords); private static Vertex2bvOESDel Vertex2bvOESPtr;
        
        // glVertex2d
        private delegate void Vertex2dDel(double /*CoordD*/  x, double /*CoordD*/  y); private static Vertex2dDel Vertex2dPtr;
        
        // glVertex2dv
        private delegate void Vertex2dvDel(double[] /*CoordD*/  v); private static Vertex2dvDel Vertex2dvPtr;
        
        // glVertex2f
        private delegate void Vertex2fDel(float /*CoordF*/  x, float /*CoordF*/  y); private static Vertex2fDel Vertex2fPtr;
        
        // glVertex2fv
        private delegate void Vertex2fvDel(float[] /*CoordF*/  v); private static Vertex2fvDel Vertex2fvPtr;
        
        // glVertex2hNV
        private delegate void Vertex2hNVDel(ushort /*Half16NV*/  x, ushort /*Half16NV*/  y); private static Vertex2hNVDel Vertex2hNVPtr;
        
        // glVertex2hvNV
        private delegate void Vertex2hvNVDel(ushort[] /*Half16NV*/  v); private static Vertex2hvNVDel Vertex2hvNVPtr;
        
        // glVertex2i
        private delegate void Vertex2iDel(int /*CoordI*/  x, int /*CoordI*/  y); private static Vertex2iDel Vertex2iPtr;
        
        // glVertex2iv
        private delegate void Vertex2ivDel(int[] /*CoordI*/  v); private static Vertex2ivDel Vertex2ivPtr;
        
        // glVertex2s
        private delegate void Vertex2sDel(short /*CoordS*/  x, short /*CoordS*/  y); private static Vertex2sDel Vertex2sPtr;
        
        // glVertex2sv
        private delegate void Vertex2svDel(short[] /*CoordS*/  v); private static Vertex2svDel Vertex2svPtr;
        
        // glVertex2xOES
        private delegate void Vertex2xOESDel(int  x); private static Vertex2xOESDel Vertex2xOESPtr;
        
        // glVertex2xvOES
        private delegate void Vertex2xvOESDel(int[]  coords); private static Vertex2xvOESDel Vertex2xvOESPtr;
        
        // glVertex3bOES
        private delegate void Vertex3bOESDel(sbyte  x, sbyte  y, sbyte  z); private static Vertex3bOESDel Vertex3bOESPtr;
        
        // glVertex3bvOES
        private delegate void Vertex3bvOESDel(sbyte[]  coords); private static Vertex3bvOESDel Vertex3bvOESPtr;
        
        // glVertex3d
        private delegate void Vertex3dDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z); private static Vertex3dDel Vertex3dPtr;
        
        // glVertex3dv
        private delegate void Vertex3dvDel(double[] /*CoordD*/  v); private static Vertex3dvDel Vertex3dvPtr;
        
        // glVertex3f
        private delegate void Vertex3fDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z); private static Vertex3fDel Vertex3fPtr;
        
        // glVertex3fv
        private delegate void Vertex3fvDel(float[] /*CoordF*/  v); private static Vertex3fvDel Vertex3fvPtr;
        
        // glVertex3hNV
        private delegate void Vertex3hNVDel(ushort /*Half16NV*/  x, ushort /*Half16NV*/  y, ushort /*Half16NV*/  z); private static Vertex3hNVDel Vertex3hNVPtr;
        
        // glVertex3hvNV
        private delegate void Vertex3hvNVDel(ushort[] /*Half16NV*/  v); private static Vertex3hvNVDel Vertex3hvNVPtr;
        
        // glVertex3i
        private delegate void Vertex3iDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z); private static Vertex3iDel Vertex3iPtr;
        
        // glVertex3iv
        private delegate void Vertex3ivDel(int[] /*CoordI*/  v); private static Vertex3ivDel Vertex3ivPtr;
        
        // glVertex3s
        private delegate void Vertex3sDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z); private static Vertex3sDel Vertex3sPtr;
        
        // glVertex3sv
        private delegate void Vertex3svDel(short[] /*CoordS*/  v); private static Vertex3svDel Vertex3svPtr;
        
        // glVertex3xOES
        private delegate void Vertex3xOESDel(int  x, int  y); private static Vertex3xOESDel Vertex3xOESPtr;
        
        // glVertex3xvOES
        private delegate void Vertex3xvOESDel(int[]  coords); private static Vertex3xvOESDel Vertex3xvOESPtr;
        
        // glVertex4bOES
        private delegate void Vertex4bOESDel(sbyte  x, sbyte  y, sbyte  z, sbyte  w); private static Vertex4bOESDel Vertex4bOESPtr;
        
        // glVertex4bvOES
        private delegate void Vertex4bvOESDel(sbyte[]  coords); private static Vertex4bvOESDel Vertex4bvOESPtr;
        
        // glVertex4d
        private delegate void Vertex4dDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z, double /*CoordD*/  w); private static Vertex4dDel Vertex4dPtr;
        
        // glVertex4dv
        private delegate void Vertex4dvDel(double[] /*CoordD*/  v); private static Vertex4dvDel Vertex4dvPtr;
        
        // glVertex4f
        private delegate void Vertex4fDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z, float /*CoordF*/  w); private static Vertex4fDel Vertex4fPtr;
        
        // glVertex4fv
        private delegate void Vertex4fvDel(float[] /*CoordF*/  v); private static Vertex4fvDel Vertex4fvPtr;
        
        // glVertex4hNV
        private delegate void Vertex4hNVDel(ushort /*Half16NV*/  x, ushort /*Half16NV*/  y, ushort /*Half16NV*/  z, ushort /*Half16NV*/  w); private static Vertex4hNVDel Vertex4hNVPtr;
        
        // glVertex4hvNV
        private delegate void Vertex4hvNVDel(ushort[] /*Half16NV*/  v); private static Vertex4hvNVDel Vertex4hvNVPtr;
        
        // glVertex4i
        private delegate void Vertex4iDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z, int /*CoordI*/  w); private static Vertex4iDel Vertex4iPtr;
        
        // glVertex4iv
        private delegate void Vertex4ivDel(int[] /*CoordI*/  v); private static Vertex4ivDel Vertex4ivPtr;
        
        // glVertex4s
        private delegate void Vertex4sDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z, short /*CoordS*/  w); private static Vertex4sDel Vertex4sPtr;
        
        // glVertex4sv
        private delegate void Vertex4svDel(short[] /*CoordS*/  v); private static Vertex4svDel Vertex4svPtr;
        
        // glVertex4xOES
        private delegate void Vertex4xOESDel(int  x, int  y, int  z); private static Vertex4xOESDel Vertex4xOESPtr;
        
        // glVertex4xvOES
        private delegate void Vertex4xvOESDel(int[]  coords); private static Vertex4xvOESDel Vertex4xvOESPtr;
        
        // glVertexArrayAttribBinding
        private delegate void VertexArrayAttribBindingDel(uint  vaobj, uint  attribindex, uint  bindingindex); private static VertexArrayAttribBindingDel VertexArrayAttribBindingPtr;
        
        // glVertexArrayAttribFormat
        private delegate void VertexArrayAttribFormatDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribType*/  type, bool /*Boolean*/  normalized, uint  relativeoffset); private static VertexArrayAttribFormatDel VertexArrayAttribFormatPtr;
        
        // glVertexArrayAttribIFormat
        private delegate void VertexArrayAttribIFormatDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribIType*/  type, uint  relativeoffset); private static VertexArrayAttribIFormatDel VertexArrayAttribIFormatPtr;
        
        // glVertexArrayAttribLFormat
        private delegate void VertexArrayAttribLFormatDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribLType*/  type, uint  relativeoffset); private static VertexArrayAttribLFormatDel VertexArrayAttribLFormatPtr;
        
        // glVertexArrayBindVertexBufferEXT
        private delegate void VertexArrayBindVertexBufferEXTDel(uint  vaobj, uint  bindingindex, uint  buffer, IntPtr /*BufferOffset*/  offset, uint  stride); private static VertexArrayBindVertexBufferEXTDel VertexArrayBindVertexBufferEXTPtr;
        
        // glVertexArrayBindingDivisor
        private delegate void VertexArrayBindingDivisorDel(uint  vaobj, uint  bindingindex, uint  divisor); private static VertexArrayBindingDivisorDel VertexArrayBindingDivisorPtr;
        
        // glVertexArrayColorOffsetEXT
        private delegate void VertexArrayColorOffsetEXTDel(uint  vaobj, uint  buffer, int  size, uint /*ColorPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayColorOffsetEXTDel VertexArrayColorOffsetEXTPtr;
        
        // glVertexArrayEdgeFlagOffsetEXT
        private delegate void VertexArrayEdgeFlagOffsetEXTDel(uint  vaobj, uint  buffer, uint  stride, IntPtr  offset); private static VertexArrayEdgeFlagOffsetEXTDel VertexArrayEdgeFlagOffsetEXTPtr;
        
        // glVertexArrayElementBuffer
        private delegate void VertexArrayElementBufferDel(uint  vaobj, uint  buffer); private static VertexArrayElementBufferDel VertexArrayElementBufferPtr;
        
        // glVertexArrayFogCoordOffsetEXT
        private delegate void VertexArrayFogCoordOffsetEXTDel(uint  vaobj, uint  buffer, uint /*FogCoordinatePointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayFogCoordOffsetEXTDel VertexArrayFogCoordOffsetEXTPtr;
        
        // glVertexArrayIndexOffsetEXT
        private delegate void VertexArrayIndexOffsetEXTDel(uint  vaobj, uint  buffer, uint /*IndexPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayIndexOffsetEXTDel VertexArrayIndexOffsetEXTPtr;
        
        // glVertexArrayMultiTexCoordOffsetEXT
        private delegate void VertexArrayMultiTexCoordOffsetEXTDel(uint  vaobj, uint  buffer, uint  texunit, int  size, uint /*TexCoordPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayMultiTexCoordOffsetEXTDel VertexArrayMultiTexCoordOffsetEXTPtr;
        
        // glVertexArrayNormalOffsetEXT
        private delegate void VertexArrayNormalOffsetEXTDel(uint  vaobj, uint  buffer, uint /*NormalPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayNormalOffsetEXTDel VertexArrayNormalOffsetEXTPtr;
        
        // glVertexArrayParameteriAPPLE
        private delegate void VertexArrayParameteriAPPLEDel(uint /*VertexArrayPNameAPPLE*/  pname, int  param); private static VertexArrayParameteriAPPLEDel VertexArrayParameteriAPPLEPtr;
        
        // glVertexArrayRangeAPPLE
        private delegate void VertexArrayRangeAPPLEDel(uint  length, IntPtr  pointer); private static VertexArrayRangeAPPLEDel VertexArrayRangeAPPLEPtr;
        
        // glVertexArrayRangeNV
        private delegate void VertexArrayRangeNVDel(uint  length, IntPtr  pointer); private static VertexArrayRangeNVDel VertexArrayRangeNVPtr;
        
        // glVertexArraySecondaryColorOffsetEXT
        private delegate void VertexArraySecondaryColorOffsetEXTDel(uint  vaobj, uint  buffer, int  size, uint /*ColorPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArraySecondaryColorOffsetEXTDel VertexArraySecondaryColorOffsetEXTPtr;
        
        // glVertexArrayTexCoordOffsetEXT
        private delegate void VertexArrayTexCoordOffsetEXTDel(uint  vaobj, uint  buffer, int  size, uint /*TexCoordPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayTexCoordOffsetEXTDel VertexArrayTexCoordOffsetEXTPtr;
        
        // glVertexArrayVertexAttribBindingEXT
        private delegate void VertexArrayVertexAttribBindingEXTDel(uint  vaobj, uint  attribindex, uint  bindingindex); private static VertexArrayVertexAttribBindingEXTDel VertexArrayVertexAttribBindingEXTPtr;
        
        // glVertexArrayVertexAttribDivisorEXT
        private delegate void VertexArrayVertexAttribDivisorEXTDel(uint  vaobj, uint  index, uint  divisor); private static VertexArrayVertexAttribDivisorEXTDel VertexArrayVertexAttribDivisorEXTPtr;
        
        // glVertexArrayVertexAttribFormatEXT
        private delegate void VertexArrayVertexAttribFormatEXTDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribType*/  type, bool /*Boolean*/  normalized, uint  relativeoffset); private static VertexArrayVertexAttribFormatEXTDel VertexArrayVertexAttribFormatEXTPtr;
        
        // glVertexArrayVertexAttribIFormatEXT
        private delegate void VertexArrayVertexAttribIFormatEXTDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribIType*/  type, uint  relativeoffset); private static VertexArrayVertexAttribIFormatEXTDel VertexArrayVertexAttribIFormatEXTPtr;
        
        // glVertexArrayVertexAttribIOffsetEXT
        private delegate void VertexArrayVertexAttribIOffsetEXTDel(uint  vaobj, uint  buffer, uint  index, int  size, uint /*VertexAttribType*/  type, uint  stride, IntPtr  offset); private static VertexArrayVertexAttribIOffsetEXTDel VertexArrayVertexAttribIOffsetEXTPtr;
        
        // glVertexArrayVertexAttribLFormatEXT
        private delegate void VertexArrayVertexAttribLFormatEXTDel(uint  vaobj, uint  attribindex, int  size, uint /*VertexAttribLType*/  type, uint  relativeoffset); private static VertexArrayVertexAttribLFormatEXTDel VertexArrayVertexAttribLFormatEXTPtr;
        
        // glVertexArrayVertexAttribLOffsetEXT
        private delegate void VertexArrayVertexAttribLOffsetEXTDel(uint  vaobj, uint  buffer, uint  index, int  size, uint /*VertexAttribLType*/  type, uint  stride, IntPtr /*BufferOffset*/  offset); private static VertexArrayVertexAttribLOffsetEXTDel VertexArrayVertexAttribLOffsetEXTPtr;
        
        // glVertexArrayVertexAttribOffsetEXT
        private delegate void VertexArrayVertexAttribOffsetEXTDel(uint  vaobj, uint  buffer, uint  index, int  size, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  stride, IntPtr  offset); private static VertexArrayVertexAttribOffsetEXTDel VertexArrayVertexAttribOffsetEXTPtr;
        
        // glVertexArrayVertexBindingDivisorEXT
        private delegate void VertexArrayVertexBindingDivisorEXTDel(uint  vaobj, uint  bindingindex, uint  divisor); private static VertexArrayVertexBindingDivisorEXTDel VertexArrayVertexBindingDivisorEXTPtr;
        
        // glVertexArrayVertexBuffer
        private delegate void VertexArrayVertexBufferDel(uint  vaobj, uint  bindingindex, uint  buffer, IntPtr  offset, uint  stride); private static VertexArrayVertexBufferDel VertexArrayVertexBufferPtr;
        
        // glVertexArrayVertexBuffers
        private delegate void VertexArrayVertexBuffersDel(uint  vaobj, uint  first, uint  count, uint[]  buffers, IntPtr[]  offsets, uint[]  strides); private static VertexArrayVertexBuffersDel VertexArrayVertexBuffersPtr;
        
        // glVertexArrayVertexOffsetEXT
        private delegate void VertexArrayVertexOffsetEXTDel(uint  vaobj, uint  buffer, int  size, uint /*VertexPointerType*/  type, uint  stride, IntPtr  offset); private static VertexArrayVertexOffsetEXTDel VertexArrayVertexOffsetEXTPtr;
        
        // glVertexAttrib1d
        private delegate void VertexAttrib1dDel(uint  index, double  x); private static VertexAttrib1dDel VertexAttrib1dPtr;
        
        // glVertexAttrib1dARB
        private delegate void VertexAttrib1dARBDel(uint  index, double  x); private static VertexAttrib1dARBDel VertexAttrib1dARBPtr;
        
        // glVertexAttrib1dNV
        private delegate void VertexAttrib1dNVDel(uint  index, double  x); private static VertexAttrib1dNVDel VertexAttrib1dNVPtr;
        
        // glVertexAttrib1dv
        private delegate void VertexAttrib1dvDel(uint  index, double[]  v); private static VertexAttrib1dvDel VertexAttrib1dvPtr;
        
        // glVertexAttrib1dvARB
        private delegate void VertexAttrib1dvARBDel(uint  index, double[]  v); private static VertexAttrib1dvARBDel VertexAttrib1dvARBPtr;
        
        // glVertexAttrib1dvNV
        private delegate void VertexAttrib1dvNVDel(uint  index, double[]  v); private static VertexAttrib1dvNVDel VertexAttrib1dvNVPtr;
        
        // glVertexAttrib1f
        private delegate void VertexAttrib1fDel(uint  index, float  x); private static VertexAttrib1fDel VertexAttrib1fPtr;
        
        // glVertexAttrib1fARB
        private delegate void VertexAttrib1fARBDel(uint  index, float  x); private static VertexAttrib1fARBDel VertexAttrib1fARBPtr;
        
        // glVertexAttrib1fNV
        private delegate void VertexAttrib1fNVDel(uint  index, float  x); private static VertexAttrib1fNVDel VertexAttrib1fNVPtr;
        
        // glVertexAttrib1fv
        private delegate void VertexAttrib1fvDel(uint  index, float[]  v); private static VertexAttrib1fvDel VertexAttrib1fvPtr;
        
        // glVertexAttrib1fvARB
        private delegate void VertexAttrib1fvARBDel(uint  index, float[]  v); private static VertexAttrib1fvARBDel VertexAttrib1fvARBPtr;
        
        // glVertexAttrib1fvNV
        private delegate void VertexAttrib1fvNVDel(uint  index, float[]  v); private static VertexAttrib1fvNVDel VertexAttrib1fvNVPtr;
        
        // glVertexAttrib1hNV
        private delegate void VertexAttrib1hNVDel(uint  index, ushort /*Half16NV*/  x); private static VertexAttrib1hNVDel VertexAttrib1hNVPtr;
        
        // glVertexAttrib1hvNV
        private delegate void VertexAttrib1hvNVDel(uint  index, ushort[] /*Half16NV*/  v); private static VertexAttrib1hvNVDel VertexAttrib1hvNVPtr;
        
        // glVertexAttrib1s
        private delegate void VertexAttrib1sDel(uint  index, short  x); private static VertexAttrib1sDel VertexAttrib1sPtr;
        
        // glVertexAttrib1sARB
        private delegate void VertexAttrib1sARBDel(uint  index, short  x); private static VertexAttrib1sARBDel VertexAttrib1sARBPtr;
        
        // glVertexAttrib1sNV
        private delegate void VertexAttrib1sNVDel(uint  index, short  x); private static VertexAttrib1sNVDel VertexAttrib1sNVPtr;
        
        // glVertexAttrib1sv
        private delegate void VertexAttrib1svDel(uint  index, short[]  v); private static VertexAttrib1svDel VertexAttrib1svPtr;
        
        // glVertexAttrib1svARB
        private delegate void VertexAttrib1svARBDel(uint  index, short[]  v); private static VertexAttrib1svARBDel VertexAttrib1svARBPtr;
        
        // glVertexAttrib1svNV
        private delegate void VertexAttrib1svNVDel(uint  index, short[]  v); private static VertexAttrib1svNVDel VertexAttrib1svNVPtr;
        
        // glVertexAttrib2d
        private delegate void VertexAttrib2dDel(uint  index, double  x, double  y); private static VertexAttrib2dDel VertexAttrib2dPtr;
        
        // glVertexAttrib2dARB
        private delegate void VertexAttrib2dARBDel(uint  index, double  x, double  y); private static VertexAttrib2dARBDel VertexAttrib2dARBPtr;
        
        // glVertexAttrib2dNV
        private delegate void VertexAttrib2dNVDel(uint  index, double  x, double  y); private static VertexAttrib2dNVDel VertexAttrib2dNVPtr;
        
        // glVertexAttrib2dv
        private delegate void VertexAttrib2dvDel(uint  index, double[]  v); private static VertexAttrib2dvDel VertexAttrib2dvPtr;
        
        // glVertexAttrib2dvARB
        private delegate void VertexAttrib2dvARBDel(uint  index, double[]  v); private static VertexAttrib2dvARBDel VertexAttrib2dvARBPtr;
        
        // glVertexAttrib2dvNV
        private delegate void VertexAttrib2dvNVDel(uint  index, double[]  v); private static VertexAttrib2dvNVDel VertexAttrib2dvNVPtr;
        
        // glVertexAttrib2f
        private delegate void VertexAttrib2fDel(uint  index, float  x, float  y); private static VertexAttrib2fDel VertexAttrib2fPtr;
        
        // glVertexAttrib2fARB
        private delegate void VertexAttrib2fARBDel(uint  index, float  x, float  y); private static VertexAttrib2fARBDel VertexAttrib2fARBPtr;
        
        // glVertexAttrib2fNV
        private delegate void VertexAttrib2fNVDel(uint  index, float  x, float  y); private static VertexAttrib2fNVDel VertexAttrib2fNVPtr;
        
        // glVertexAttrib2fv
        private delegate void VertexAttrib2fvDel(uint  index, float[]  v); private static VertexAttrib2fvDel VertexAttrib2fvPtr;
        
        // glVertexAttrib2fvARB
        private delegate void VertexAttrib2fvARBDel(uint  index, float[]  v); private static VertexAttrib2fvARBDel VertexAttrib2fvARBPtr;
        
        // glVertexAttrib2fvNV
        private delegate void VertexAttrib2fvNVDel(uint  index, float[]  v); private static VertexAttrib2fvNVDel VertexAttrib2fvNVPtr;
        
        // glVertexAttrib2hNV
        private delegate void VertexAttrib2hNVDel(uint  index, ushort /*Half16NV*/  x, ushort /*Half16NV*/  y); private static VertexAttrib2hNVDel VertexAttrib2hNVPtr;
        
        // glVertexAttrib2hvNV
        private delegate void VertexAttrib2hvNVDel(uint  index, ushort[] /*Half16NV*/  v); private static VertexAttrib2hvNVDel VertexAttrib2hvNVPtr;
        
        // glVertexAttrib2s
        private delegate void VertexAttrib2sDel(uint  index, short  x, short  y); private static VertexAttrib2sDel VertexAttrib2sPtr;
        
        // glVertexAttrib2sARB
        private delegate void VertexAttrib2sARBDel(uint  index, short  x, short  y); private static VertexAttrib2sARBDel VertexAttrib2sARBPtr;
        
        // glVertexAttrib2sNV
        private delegate void VertexAttrib2sNVDel(uint  index, short  x, short  y); private static VertexAttrib2sNVDel VertexAttrib2sNVPtr;
        
        // glVertexAttrib2sv
        private delegate void VertexAttrib2svDel(uint  index, short[]  v); private static VertexAttrib2svDel VertexAttrib2svPtr;
        
        // glVertexAttrib2svARB
        private delegate void VertexAttrib2svARBDel(uint  index, short[]  v); private static VertexAttrib2svARBDel VertexAttrib2svARBPtr;
        
        // glVertexAttrib2svNV
        private delegate void VertexAttrib2svNVDel(uint  index, short[]  v); private static VertexAttrib2svNVDel VertexAttrib2svNVPtr;
        
        // glVertexAttrib3d
        private delegate void VertexAttrib3dDel(uint  index, double  x, double  y, double  z); private static VertexAttrib3dDel VertexAttrib3dPtr;
        
        // glVertexAttrib3dARB
        private delegate void VertexAttrib3dARBDel(uint  index, double  x, double  y, double  z); private static VertexAttrib3dARBDel VertexAttrib3dARBPtr;
        
        // glVertexAttrib3dNV
        private delegate void VertexAttrib3dNVDel(uint  index, double  x, double  y, double  z); private static VertexAttrib3dNVDel VertexAttrib3dNVPtr;
        
        // glVertexAttrib3dv
        private delegate void VertexAttrib3dvDel(uint  index, double[]  v); private static VertexAttrib3dvDel VertexAttrib3dvPtr;
        
        // glVertexAttrib3dvARB
        private delegate void VertexAttrib3dvARBDel(uint  index, double[]  v); private static VertexAttrib3dvARBDel VertexAttrib3dvARBPtr;
        
        // glVertexAttrib3dvNV
        private delegate void VertexAttrib3dvNVDel(uint  index, double[]  v); private static VertexAttrib3dvNVDel VertexAttrib3dvNVPtr;
        
        // glVertexAttrib3f
        private delegate void VertexAttrib3fDel(uint  index, float  x, float  y, float  z); private static VertexAttrib3fDel VertexAttrib3fPtr;
        
        // glVertexAttrib3fARB
        private delegate void VertexAttrib3fARBDel(uint  index, float  x, float  y, float  z); private static VertexAttrib3fARBDel VertexAttrib3fARBPtr;
        
        // glVertexAttrib3fNV
        private delegate void VertexAttrib3fNVDel(uint  index, float  x, float  y, float  z); private static VertexAttrib3fNVDel VertexAttrib3fNVPtr;
        
        // glVertexAttrib3fv
        private delegate void VertexAttrib3fvDel(uint  index, float[]  v); private static VertexAttrib3fvDel VertexAttrib3fvPtr;
        
        // glVertexAttrib3fvARB
        private delegate void VertexAttrib3fvARBDel(uint  index, float[]  v); private static VertexAttrib3fvARBDel VertexAttrib3fvARBPtr;
        
        // glVertexAttrib3fvNV
        private delegate void VertexAttrib3fvNVDel(uint  index, float[]  v); private static VertexAttrib3fvNVDel VertexAttrib3fvNVPtr;
        
        // glVertexAttrib3hNV
        private delegate void VertexAttrib3hNVDel(uint  index, ushort /*Half16NV*/  x, ushort /*Half16NV*/  y, ushort /*Half16NV*/  z); private static VertexAttrib3hNVDel VertexAttrib3hNVPtr;
        
        // glVertexAttrib3hvNV
        private delegate void VertexAttrib3hvNVDel(uint  index, ushort[] /*Half16NV*/  v); private static VertexAttrib3hvNVDel VertexAttrib3hvNVPtr;
        
        // glVertexAttrib3s
        private delegate void VertexAttrib3sDel(uint  index, short  x, short  y, short  z); private static VertexAttrib3sDel VertexAttrib3sPtr;
        
        // glVertexAttrib3sARB
        private delegate void VertexAttrib3sARBDel(uint  index, short  x, short  y, short  z); private static VertexAttrib3sARBDel VertexAttrib3sARBPtr;
        
        // glVertexAttrib3sNV
        private delegate void VertexAttrib3sNVDel(uint  index, short  x, short  y, short  z); private static VertexAttrib3sNVDel VertexAttrib3sNVPtr;
        
        // glVertexAttrib3sv
        private delegate void VertexAttrib3svDel(uint  index, short[]  v); private static VertexAttrib3svDel VertexAttrib3svPtr;
        
        // glVertexAttrib3svARB
        private delegate void VertexAttrib3svARBDel(uint  index, short[]  v); private static VertexAttrib3svARBDel VertexAttrib3svARBPtr;
        
        // glVertexAttrib3svNV
        private delegate void VertexAttrib3svNVDel(uint  index, short[]  v); private static VertexAttrib3svNVDel VertexAttrib3svNVPtr;
        
        // glVertexAttrib4Nbv
        private delegate void VertexAttrib4NbvDel(uint  index, sbyte[]  v); private static VertexAttrib4NbvDel VertexAttrib4NbvPtr;
        
        // glVertexAttrib4NbvARB
        private delegate void VertexAttrib4NbvARBDel(uint  index, sbyte[]  v); private static VertexAttrib4NbvARBDel VertexAttrib4NbvARBPtr;
        
        // glVertexAttrib4Niv
        private delegate void VertexAttrib4NivDel(uint  index, int[]  v); private static VertexAttrib4NivDel VertexAttrib4NivPtr;
        
        // glVertexAttrib4NivARB
        private delegate void VertexAttrib4NivARBDel(uint  index, int[]  v); private static VertexAttrib4NivARBDel VertexAttrib4NivARBPtr;
        
        // glVertexAttrib4Nsv
        private delegate void VertexAttrib4NsvDel(uint  index, short[]  v); private static VertexAttrib4NsvDel VertexAttrib4NsvPtr;
        
        // glVertexAttrib4NsvARB
        private delegate void VertexAttrib4NsvARBDel(uint  index, short[]  v); private static VertexAttrib4NsvARBDel VertexAttrib4NsvARBPtr;
        
        // glVertexAttrib4Nub
        private delegate void VertexAttrib4NubDel(uint  index, byte  x, byte  y, byte  z, byte  w); private static VertexAttrib4NubDel VertexAttrib4NubPtr;
        
        // glVertexAttrib4NubARB
        private delegate void VertexAttrib4NubARBDel(uint  index, byte  x, byte  y, byte  z, byte  w); private static VertexAttrib4NubARBDel VertexAttrib4NubARBPtr;
        
        // glVertexAttrib4Nubv
        private delegate void VertexAttrib4NubvDel(uint  index, byte[]  v); private static VertexAttrib4NubvDel VertexAttrib4NubvPtr;
        
        // glVertexAttrib4NubvARB
        private delegate void VertexAttrib4NubvARBDel(uint  index, byte[]  v); private static VertexAttrib4NubvARBDel VertexAttrib4NubvARBPtr;
        
        // glVertexAttrib4Nuiv
        private delegate void VertexAttrib4NuivDel(uint  index, uint[]  v); private static VertexAttrib4NuivDel VertexAttrib4NuivPtr;
        
        // glVertexAttrib4NuivARB
        private delegate void VertexAttrib4NuivARBDel(uint  index, uint[]  v); private static VertexAttrib4NuivARBDel VertexAttrib4NuivARBPtr;
        
        // glVertexAttrib4Nusv
        private delegate void VertexAttrib4NusvDel(uint  index, ushort[]  v); private static VertexAttrib4NusvDel VertexAttrib4NusvPtr;
        
        // glVertexAttrib4NusvARB
        private delegate void VertexAttrib4NusvARBDel(uint  index, ushort[]  v); private static VertexAttrib4NusvARBDel VertexAttrib4NusvARBPtr;
        
        // glVertexAttrib4bv
        private delegate void VertexAttrib4bvDel(uint  index, sbyte[]  v); private static VertexAttrib4bvDel VertexAttrib4bvPtr;
        
        // glVertexAttrib4bvARB
        private delegate void VertexAttrib4bvARBDel(uint  index, sbyte[]  v); private static VertexAttrib4bvARBDel VertexAttrib4bvARBPtr;
        
        // glVertexAttrib4d
        private delegate void VertexAttrib4dDel(uint  index, double  x, double  y, double  z, double  w); private static VertexAttrib4dDel VertexAttrib4dPtr;
        
        // glVertexAttrib4dARB
        private delegate void VertexAttrib4dARBDel(uint  index, double  x, double  y, double  z, double  w); private static VertexAttrib4dARBDel VertexAttrib4dARBPtr;
        
        // glVertexAttrib4dNV
        private delegate void VertexAttrib4dNVDel(uint  index, double  x, double  y, double  z, double  w); private static VertexAttrib4dNVDel VertexAttrib4dNVPtr;
        
        // glVertexAttrib4dv
        private delegate void VertexAttrib4dvDel(uint  index, double[]  v); private static VertexAttrib4dvDel VertexAttrib4dvPtr;
        
        // glVertexAttrib4dvARB
        private delegate void VertexAttrib4dvARBDel(uint  index, double[]  v); private static VertexAttrib4dvARBDel VertexAttrib4dvARBPtr;
        
        // glVertexAttrib4dvNV
        private delegate void VertexAttrib4dvNVDel(uint  index, double[]  v); private static VertexAttrib4dvNVDel VertexAttrib4dvNVPtr;
        
        // glVertexAttrib4f
        private delegate void VertexAttrib4fDel(uint  index, float  x, float  y, float  z, float  w); private static VertexAttrib4fDel VertexAttrib4fPtr;
        
        // glVertexAttrib4fARB
        private delegate void VertexAttrib4fARBDel(uint  index, float  x, float  y, float  z, float  w); private static VertexAttrib4fARBDel VertexAttrib4fARBPtr;
        
        // glVertexAttrib4fNV
        private delegate void VertexAttrib4fNVDel(uint  index, float  x, float  y, float  z, float  w); private static VertexAttrib4fNVDel VertexAttrib4fNVPtr;
        
        // glVertexAttrib4fv
        private delegate void VertexAttrib4fvDel(uint  index, float[]  v); private static VertexAttrib4fvDel VertexAttrib4fvPtr;
        
        // glVertexAttrib4fvARB
        private delegate void VertexAttrib4fvARBDel(uint  index, float[]  v); private static VertexAttrib4fvARBDel VertexAttrib4fvARBPtr;
        
        // glVertexAttrib4fvNV
        private delegate void VertexAttrib4fvNVDel(uint  index, float[]  v); private static VertexAttrib4fvNVDel VertexAttrib4fvNVPtr;
        
        // glVertexAttrib4hNV
        private delegate void VertexAttrib4hNVDel(uint  index, ushort /*Half16NV*/  x, ushort /*Half16NV*/  y, ushort /*Half16NV*/  z, ushort /*Half16NV*/  w); private static VertexAttrib4hNVDel VertexAttrib4hNVPtr;
        
        // glVertexAttrib4hvNV
        private delegate void VertexAttrib4hvNVDel(uint  index, ushort[] /*Half16NV*/  v); private static VertexAttrib4hvNVDel VertexAttrib4hvNVPtr;
        
        // glVertexAttrib4iv
        private delegate void VertexAttrib4ivDel(uint  index, int[]  v); private static VertexAttrib4ivDel VertexAttrib4ivPtr;
        
        // glVertexAttrib4ivARB
        private delegate void VertexAttrib4ivARBDel(uint  index, int[]  v); private static VertexAttrib4ivARBDel VertexAttrib4ivARBPtr;
        
        // glVertexAttrib4s
        private delegate void VertexAttrib4sDel(uint  index, short  x, short  y, short  z, short  w); private static VertexAttrib4sDel VertexAttrib4sPtr;
        
        // glVertexAttrib4sARB
        private delegate void VertexAttrib4sARBDel(uint  index, short  x, short  y, short  z, short  w); private static VertexAttrib4sARBDel VertexAttrib4sARBPtr;
        
        // glVertexAttrib4sNV
        private delegate void VertexAttrib4sNVDel(uint  index, short  x, short  y, short  z, short  w); private static VertexAttrib4sNVDel VertexAttrib4sNVPtr;
        
        // glVertexAttrib4sv
        private delegate void VertexAttrib4svDel(uint  index, short[]  v); private static VertexAttrib4svDel VertexAttrib4svPtr;
        
        // glVertexAttrib4svARB
        private delegate void VertexAttrib4svARBDel(uint  index, short[]  v); private static VertexAttrib4svARBDel VertexAttrib4svARBPtr;
        
        // glVertexAttrib4svNV
        private delegate void VertexAttrib4svNVDel(uint  index, short[]  v); private static VertexAttrib4svNVDel VertexAttrib4svNVPtr;
        
        // glVertexAttrib4ubNV
        private delegate void VertexAttrib4ubNVDel(uint  index, byte /*ColorUB*/  x, byte /*ColorUB*/  y, byte /*ColorUB*/  z, byte /*ColorUB*/  w); private static VertexAttrib4ubNVDel VertexAttrib4ubNVPtr;
        
        // glVertexAttrib4ubv
        private delegate void VertexAttrib4ubvDel(uint  index, byte[]  v); private static VertexAttrib4ubvDel VertexAttrib4ubvPtr;
        
        // glVertexAttrib4ubvARB
        private delegate void VertexAttrib4ubvARBDel(uint  index, byte[]  v); private static VertexAttrib4ubvARBDel VertexAttrib4ubvARBPtr;
        
        // glVertexAttrib4ubvNV
        private delegate void VertexAttrib4ubvNVDel(uint  index, byte[] /*ColorUB*/  v); private static VertexAttrib4ubvNVDel VertexAttrib4ubvNVPtr;
        
        // glVertexAttrib4uiv
        private delegate void VertexAttrib4uivDel(uint  index, uint[]  v); private static VertexAttrib4uivDel VertexAttrib4uivPtr;
        
        // glVertexAttrib4uivARB
        private delegate void VertexAttrib4uivARBDel(uint  index, uint[]  v); private static VertexAttrib4uivARBDel VertexAttrib4uivARBPtr;
        
        // glVertexAttrib4usv
        private delegate void VertexAttrib4usvDel(uint  index, ushort[]  v); private static VertexAttrib4usvDel VertexAttrib4usvPtr;
        
        // glVertexAttrib4usvARB
        private delegate void VertexAttrib4usvARBDel(uint  index, ushort[]  v); private static VertexAttrib4usvARBDel VertexAttrib4usvARBPtr;
        
        // glVertexAttribArrayObjectATI
        private delegate void VertexAttribArrayObjectATIDel(uint  index, int  size, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  stride, uint  buffer, uint  offset); private static VertexAttribArrayObjectATIDel VertexAttribArrayObjectATIPtr;
        
        // glVertexAttribBinding
        private delegate void VertexAttribBindingDel(uint  attribindex, uint  bindingindex); private static VertexAttribBindingDel VertexAttribBindingPtr;
        
        // glVertexAttribDivisor
        private delegate void VertexAttribDivisorDel(uint  index, uint  divisor); private static VertexAttribDivisorDel VertexAttribDivisorPtr;
        
        // glVertexAttribDivisorANGLE
        private delegate void VertexAttribDivisorANGLEDel(uint  index, uint  divisor); private static VertexAttribDivisorANGLEDel VertexAttribDivisorANGLEPtr;
        
        // glVertexAttribDivisorARB
        private delegate void VertexAttribDivisorARBDel(uint  index, uint  divisor); private static VertexAttribDivisorARBDel VertexAttribDivisorARBPtr;
        
        // glVertexAttribDivisorEXT
        private delegate void VertexAttribDivisorEXTDel(uint  index, uint  divisor); private static VertexAttribDivisorEXTDel VertexAttribDivisorEXTPtr;
        
        // glVertexAttribDivisorNV
        private delegate void VertexAttribDivisorNVDel(uint  index, uint  divisor); private static VertexAttribDivisorNVDel VertexAttribDivisorNVPtr;
        
        // glVertexAttribFormat
        private delegate void VertexAttribFormatDel(uint  attribindex, int  size, uint /*VertexAttribType*/  type, bool /*Boolean*/  normalized, uint  relativeoffset); private static VertexAttribFormatDel VertexAttribFormatPtr;
        
        // glVertexAttribFormatNV
        private delegate void VertexAttribFormatNVDel(uint  index, int  size, uint /*VertexAttribType*/  type, bool /*Boolean*/  normalized, uint  stride); private static VertexAttribFormatNVDel VertexAttribFormatNVPtr;
        
        // glVertexAttribI1i
        private delegate void VertexAttribI1iDel(uint  index, int  x); private static VertexAttribI1iDel VertexAttribI1iPtr;
        
        // glVertexAttribI1iEXT
        private delegate void VertexAttribI1iEXTDel(uint  index, int  x); private static VertexAttribI1iEXTDel VertexAttribI1iEXTPtr;
        
        // glVertexAttribI1iv
        private delegate void VertexAttribI1ivDel(uint  index, int[]  v); private static VertexAttribI1ivDel VertexAttribI1ivPtr;
        
        // glVertexAttribI1ivEXT
        private delegate void VertexAttribI1ivEXTDel(uint  index, int[]  v); private static VertexAttribI1ivEXTDel VertexAttribI1ivEXTPtr;
        
        // glVertexAttribI1ui
        private delegate void VertexAttribI1uiDel(uint  index, uint  x); private static VertexAttribI1uiDel VertexAttribI1uiPtr;
        
        // glVertexAttribI1uiEXT
        private delegate void VertexAttribI1uiEXTDel(uint  index, uint  x); private static VertexAttribI1uiEXTDel VertexAttribI1uiEXTPtr;
        
        // glVertexAttribI1uiv
        private delegate void VertexAttribI1uivDel(uint  index, uint[]  v); private static VertexAttribI1uivDel VertexAttribI1uivPtr;
        
        // glVertexAttribI1uivEXT
        private delegate void VertexAttribI1uivEXTDel(uint  index, uint[]  v); private static VertexAttribI1uivEXTDel VertexAttribI1uivEXTPtr;
        
        // glVertexAttribI2i
        private delegate void VertexAttribI2iDel(uint  index, int  x, int  y); private static VertexAttribI2iDel VertexAttribI2iPtr;
        
        // glVertexAttribI2iEXT
        private delegate void VertexAttribI2iEXTDel(uint  index, int  x, int  y); private static VertexAttribI2iEXTDel VertexAttribI2iEXTPtr;
        
        // glVertexAttribI2iv
        private delegate void VertexAttribI2ivDel(uint  index, int[]  v); private static VertexAttribI2ivDel VertexAttribI2ivPtr;
        
        // glVertexAttribI2ivEXT
        private delegate void VertexAttribI2ivEXTDel(uint  index, int[]  v); private static VertexAttribI2ivEXTDel VertexAttribI2ivEXTPtr;
        
        // glVertexAttribI2ui
        private delegate void VertexAttribI2uiDel(uint  index, uint  x, uint  y); private static VertexAttribI2uiDel VertexAttribI2uiPtr;
        
        // glVertexAttribI2uiEXT
        private delegate void VertexAttribI2uiEXTDel(uint  index, uint  x, uint  y); private static VertexAttribI2uiEXTDel VertexAttribI2uiEXTPtr;
        
        // glVertexAttribI2uiv
        private delegate void VertexAttribI2uivDel(uint  index, uint[]  v); private static VertexAttribI2uivDel VertexAttribI2uivPtr;
        
        // glVertexAttribI2uivEXT
        private delegate void VertexAttribI2uivEXTDel(uint  index, uint[]  v); private static VertexAttribI2uivEXTDel VertexAttribI2uivEXTPtr;
        
        // glVertexAttribI3i
        private delegate void VertexAttribI3iDel(uint  index, int  x, int  y, int  z); private static VertexAttribI3iDel VertexAttribI3iPtr;
        
        // glVertexAttribI3iEXT
        private delegate void VertexAttribI3iEXTDel(uint  index, int  x, int  y, int  z); private static VertexAttribI3iEXTDel VertexAttribI3iEXTPtr;
        
        // glVertexAttribI3iv
        private delegate void VertexAttribI3ivDel(uint  index, int[]  v); private static VertexAttribI3ivDel VertexAttribI3ivPtr;
        
        // glVertexAttribI3ivEXT
        private delegate void VertexAttribI3ivEXTDel(uint  index, int[]  v); private static VertexAttribI3ivEXTDel VertexAttribI3ivEXTPtr;
        
        // glVertexAttribI3ui
        private delegate void VertexAttribI3uiDel(uint  index, uint  x, uint  y, uint  z); private static VertexAttribI3uiDel VertexAttribI3uiPtr;
        
        // glVertexAttribI3uiEXT
        private delegate void VertexAttribI3uiEXTDel(uint  index, uint  x, uint  y, uint  z); private static VertexAttribI3uiEXTDel VertexAttribI3uiEXTPtr;
        
        // glVertexAttribI3uiv
        private delegate void VertexAttribI3uivDel(uint  index, uint[]  v); private static VertexAttribI3uivDel VertexAttribI3uivPtr;
        
        // glVertexAttribI3uivEXT
        private delegate void VertexAttribI3uivEXTDel(uint  index, uint[]  v); private static VertexAttribI3uivEXTDel VertexAttribI3uivEXTPtr;
        
        // glVertexAttribI4bv
        private delegate void VertexAttribI4bvDel(uint  index, sbyte[]  v); private static VertexAttribI4bvDel VertexAttribI4bvPtr;
        
        // glVertexAttribI4bvEXT
        private delegate void VertexAttribI4bvEXTDel(uint  index, sbyte[]  v); private static VertexAttribI4bvEXTDel VertexAttribI4bvEXTPtr;
        
        // glVertexAttribI4i
        private delegate void VertexAttribI4iDel(uint  index, int  x, int  y, int  z, int  w); private static VertexAttribI4iDel VertexAttribI4iPtr;
        
        // glVertexAttribI4iEXT
        private delegate void VertexAttribI4iEXTDel(uint  index, int  x, int  y, int  z, int  w); private static VertexAttribI4iEXTDel VertexAttribI4iEXTPtr;
        
        // glVertexAttribI4iv
        private delegate void VertexAttribI4ivDel(uint  index, int[]  v); private static VertexAttribI4ivDel VertexAttribI4ivPtr;
        
        // glVertexAttribI4ivEXT
        private delegate void VertexAttribI4ivEXTDel(uint  index, int[]  v); private static VertexAttribI4ivEXTDel VertexAttribI4ivEXTPtr;
        
        // glVertexAttribI4sv
        private delegate void VertexAttribI4svDel(uint  index, short[]  v); private static VertexAttribI4svDel VertexAttribI4svPtr;
        
        // glVertexAttribI4svEXT
        private delegate void VertexAttribI4svEXTDel(uint  index, short[]  v); private static VertexAttribI4svEXTDel VertexAttribI4svEXTPtr;
        
        // glVertexAttribI4ubv
        private delegate void VertexAttribI4ubvDel(uint  index, byte[]  v); private static VertexAttribI4ubvDel VertexAttribI4ubvPtr;
        
        // glVertexAttribI4ubvEXT
        private delegate void VertexAttribI4ubvEXTDel(uint  index, byte[]  v); private static VertexAttribI4ubvEXTDel VertexAttribI4ubvEXTPtr;
        
        // glVertexAttribI4ui
        private delegate void VertexAttribI4uiDel(uint  index, uint  x, uint  y, uint  z, uint  w); private static VertexAttribI4uiDel VertexAttribI4uiPtr;
        
        // glVertexAttribI4uiEXT
        private delegate void VertexAttribI4uiEXTDel(uint  index, uint  x, uint  y, uint  z, uint  w); private static VertexAttribI4uiEXTDel VertexAttribI4uiEXTPtr;
        
        // glVertexAttribI4uiv
        private delegate void VertexAttribI4uivDel(uint  index, uint[]  v); private static VertexAttribI4uivDel VertexAttribI4uivPtr;
        
        // glVertexAttribI4uivEXT
        private delegate void VertexAttribI4uivEXTDel(uint  index, uint[]  v); private static VertexAttribI4uivEXTDel VertexAttribI4uivEXTPtr;
        
        // glVertexAttribI4usv
        private delegate void VertexAttribI4usvDel(uint  index, ushort[]  v); private static VertexAttribI4usvDel VertexAttribI4usvPtr;
        
        // glVertexAttribI4usvEXT
        private delegate void VertexAttribI4usvEXTDel(uint  index, ushort[]  v); private static VertexAttribI4usvEXTDel VertexAttribI4usvEXTPtr;
        
        // glVertexAttribIFormat
        private delegate void VertexAttribIFormatDel(uint  attribindex, int  size, uint /*VertexAttribIType*/  type, uint  relativeoffset); private static VertexAttribIFormatDel VertexAttribIFormatPtr;
        
        // glVertexAttribIFormatNV
        private delegate void VertexAttribIFormatNVDel(uint  index, int  size, uint /*VertexAttribIType*/  type, uint  stride); private static VertexAttribIFormatNVDel VertexAttribIFormatNVPtr;
        
        // glVertexAttribIPointer
        private delegate void VertexAttribIPointerDel(uint  index, int  size, uint /*VertexAttribIType*/  type, uint  stride, IntPtr  pointer); private static VertexAttribIPointerDel VertexAttribIPointerPtr;
        
        // glVertexAttribIPointerEXT
        private delegate void VertexAttribIPointerEXTDel(uint  index, int  size, uint /*VertexAttribIType*/  type, uint  stride, IntPtr  pointer); private static VertexAttribIPointerEXTDel VertexAttribIPointerEXTPtr;
        
        // glVertexAttribL1d
        private delegate void VertexAttribL1dDel(uint  index, double  x); private static VertexAttribL1dDel VertexAttribL1dPtr;
        
        // glVertexAttribL1dEXT
        private delegate void VertexAttribL1dEXTDel(uint  index, double  x); private static VertexAttribL1dEXTDel VertexAttribL1dEXTPtr;
        
        // glVertexAttribL1dv
        private delegate void VertexAttribL1dvDel(uint  index, double[]  v); private static VertexAttribL1dvDel VertexAttribL1dvPtr;
        
        // glVertexAttribL1dvEXT
        private delegate void VertexAttribL1dvEXTDel(uint  index, double[]  v); private static VertexAttribL1dvEXTDel VertexAttribL1dvEXTPtr;
        
        // glVertexAttribL1i64NV
        private delegate void VertexAttribL1i64NVDel(uint  index, long  x); private static VertexAttribL1i64NVDel VertexAttribL1i64NVPtr;
        
        // glVertexAttribL1i64vNV
        private delegate void VertexAttribL1i64vNVDel(uint  index, long[]  v); private static VertexAttribL1i64vNVDel VertexAttribL1i64vNVPtr;
        
        // glVertexAttribL1ui64ARB
        private delegate void VertexAttribL1ui64ARBDel(uint  index, ulong  x); private static VertexAttribL1ui64ARBDel VertexAttribL1ui64ARBPtr;
        
        // glVertexAttribL1ui64NV
        private delegate void VertexAttribL1ui64NVDel(uint  index, ulong  x); private static VertexAttribL1ui64NVDel VertexAttribL1ui64NVPtr;
        
        // glVertexAttribL1ui64vARB
        private delegate void VertexAttribL1ui64vARBDel(uint  index, ulong[]  v); private static VertexAttribL1ui64vARBDel VertexAttribL1ui64vARBPtr;
        
        // glVertexAttribL1ui64vNV
        private delegate void VertexAttribL1ui64vNVDel(uint  index, ulong[]  v); private static VertexAttribL1ui64vNVDel VertexAttribL1ui64vNVPtr;
        
        // glVertexAttribL2d
        private delegate void VertexAttribL2dDel(uint  index, double  x, double  y); private static VertexAttribL2dDel VertexAttribL2dPtr;
        
        // glVertexAttribL2dEXT
        private delegate void VertexAttribL2dEXTDel(uint  index, double  x, double  y); private static VertexAttribL2dEXTDel VertexAttribL2dEXTPtr;
        
        // glVertexAttribL2dv
        private delegate void VertexAttribL2dvDel(uint  index, double[]  v); private static VertexAttribL2dvDel VertexAttribL2dvPtr;
        
        // glVertexAttribL2dvEXT
        private delegate void VertexAttribL2dvEXTDel(uint  index, double[]  v); private static VertexAttribL2dvEXTDel VertexAttribL2dvEXTPtr;
        
        // glVertexAttribL2i64NV
        private delegate void VertexAttribL2i64NVDel(uint  index, long  x, long  y); private static VertexAttribL2i64NVDel VertexAttribL2i64NVPtr;
        
        // glVertexAttribL2i64vNV
        private delegate void VertexAttribL2i64vNVDel(uint  index, long[]  v); private static VertexAttribL2i64vNVDel VertexAttribL2i64vNVPtr;
        
        // glVertexAttribL2ui64NV
        private delegate void VertexAttribL2ui64NVDel(uint  index, ulong  x, ulong  y); private static VertexAttribL2ui64NVDel VertexAttribL2ui64NVPtr;
        
        // glVertexAttribL2ui64vNV
        private delegate void VertexAttribL2ui64vNVDel(uint  index, ulong[]  v); private static VertexAttribL2ui64vNVDel VertexAttribL2ui64vNVPtr;
        
        // glVertexAttribL3d
        private delegate void VertexAttribL3dDel(uint  index, double  x, double  y, double  z); private static VertexAttribL3dDel VertexAttribL3dPtr;
        
        // glVertexAttribL3dEXT
        private delegate void VertexAttribL3dEXTDel(uint  index, double  x, double  y, double  z); private static VertexAttribL3dEXTDel VertexAttribL3dEXTPtr;
        
        // glVertexAttribL3dv
        private delegate void VertexAttribL3dvDel(uint  index, double[]  v); private static VertexAttribL3dvDel VertexAttribL3dvPtr;
        
        // glVertexAttribL3dvEXT
        private delegate void VertexAttribL3dvEXTDel(uint  index, double[]  v); private static VertexAttribL3dvEXTDel VertexAttribL3dvEXTPtr;
        
        // glVertexAttribL3i64NV
        private delegate void VertexAttribL3i64NVDel(uint  index, long  x, long  y, long  z); private static VertexAttribL3i64NVDel VertexAttribL3i64NVPtr;
        
        // glVertexAttribL3i64vNV
        private delegate void VertexAttribL3i64vNVDel(uint  index, long[]  v); private static VertexAttribL3i64vNVDel VertexAttribL3i64vNVPtr;
        
        // glVertexAttribL3ui64NV
        private delegate void VertexAttribL3ui64NVDel(uint  index, ulong  x, ulong  y, ulong  z); private static VertexAttribL3ui64NVDel VertexAttribL3ui64NVPtr;
        
        // glVertexAttribL3ui64vNV
        private delegate void VertexAttribL3ui64vNVDel(uint  index, ulong[]  v); private static VertexAttribL3ui64vNVDel VertexAttribL3ui64vNVPtr;
        
        // glVertexAttribL4d
        private delegate void VertexAttribL4dDel(uint  index, double  x, double  y, double  z, double  w); private static VertexAttribL4dDel VertexAttribL4dPtr;
        
        // glVertexAttribL4dEXT
        private delegate void VertexAttribL4dEXTDel(uint  index, double  x, double  y, double  z, double  w); private static VertexAttribL4dEXTDel VertexAttribL4dEXTPtr;
        
        // glVertexAttribL4dv
        private delegate void VertexAttribL4dvDel(uint  index, double[]  v); private static VertexAttribL4dvDel VertexAttribL4dvPtr;
        
        // glVertexAttribL4dvEXT
        private delegate void VertexAttribL4dvEXTDel(uint  index, double[]  v); private static VertexAttribL4dvEXTDel VertexAttribL4dvEXTPtr;
        
        // glVertexAttribL4i64NV
        private delegate void VertexAttribL4i64NVDel(uint  index, long  x, long  y, long  z, long  w); private static VertexAttribL4i64NVDel VertexAttribL4i64NVPtr;
        
        // glVertexAttribL4i64vNV
        private delegate void VertexAttribL4i64vNVDel(uint  index, long[]  v); private static VertexAttribL4i64vNVDel VertexAttribL4i64vNVPtr;
        
        // glVertexAttribL4ui64NV
        private delegate void VertexAttribL4ui64NVDel(uint  index, ulong  x, ulong  y, ulong  z, ulong  w); private static VertexAttribL4ui64NVDel VertexAttribL4ui64NVPtr;
        
        // glVertexAttribL4ui64vNV
        private delegate void VertexAttribL4ui64vNVDel(uint  index, ulong[]  v); private static VertexAttribL4ui64vNVDel VertexAttribL4ui64vNVPtr;
        
        // glVertexAttribLFormat
        private delegate void VertexAttribLFormatDel(uint  attribindex, int  size, uint /*VertexAttribLType*/  type, uint  relativeoffset); private static VertexAttribLFormatDel VertexAttribLFormatPtr;
        
        // glVertexAttribLFormatNV
        private delegate void VertexAttribLFormatNVDel(uint  index, int  size, uint /*VertexAttribLType*/  type, uint  stride); private static VertexAttribLFormatNVDel VertexAttribLFormatNVPtr;
        
        // glVertexAttribLPointer
        private delegate void VertexAttribLPointerDel(uint  index, int  size, uint /*VertexAttribLType*/  type, uint  stride, IntPtr  pointer); private static VertexAttribLPointerDel VertexAttribLPointerPtr;
        
        // glVertexAttribLPointerEXT
        private delegate void VertexAttribLPointerEXTDel(uint  index, int  size, uint /*VertexAttribLType*/  type, uint  stride, IntPtr  pointer); private static VertexAttribLPointerEXTDel VertexAttribLPointerEXTPtr;
        
        // glVertexAttribP1ui
        private delegate void VertexAttribP1uiDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  value); private static VertexAttribP1uiDel VertexAttribP1uiPtr;
        
        // glVertexAttribP1uiv
        private delegate void VertexAttribP1uivDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint[]  value); private static VertexAttribP1uivDel VertexAttribP1uivPtr;
        
        // glVertexAttribP2ui
        private delegate void VertexAttribP2uiDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  value); private static VertexAttribP2uiDel VertexAttribP2uiPtr;
        
        // glVertexAttribP2uiv
        private delegate void VertexAttribP2uivDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint[]  value); private static VertexAttribP2uivDel VertexAttribP2uivPtr;
        
        // glVertexAttribP3ui
        private delegate void VertexAttribP3uiDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  value); private static VertexAttribP3uiDel VertexAttribP3uiPtr;
        
        // glVertexAttribP3uiv
        private delegate void VertexAttribP3uivDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint[]  value); private static VertexAttribP3uivDel VertexAttribP3uivPtr;
        
        // glVertexAttribP4ui
        private delegate void VertexAttribP4uiDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  value); private static VertexAttribP4uiDel VertexAttribP4uiPtr;
        
        // glVertexAttribP4uiv
        private delegate void VertexAttribP4uivDel(uint  index, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint[]  value); private static VertexAttribP4uivDel VertexAttribP4uivPtr;
        
        // glVertexAttribParameteriAMD
        private delegate void VertexAttribParameteriAMDDel(uint  index, uint  pname, int  param); private static VertexAttribParameteriAMDDel VertexAttribParameteriAMDPtr;
        
        // glVertexAttribPointer
        private delegate void VertexAttribPointerDel(uint  index, int  size, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  stride, IntPtr  pointer); private static VertexAttribPointerDel VertexAttribPointerPtr;
        
        // glVertexAttribPointerARB
        private delegate void VertexAttribPointerARBDel(uint  index, int  size, uint /*VertexAttribPointerType*/  type, bool /*Boolean*/  normalized, uint  stride, IntPtr  pointer); private static VertexAttribPointerARBDel VertexAttribPointerARBPtr;
        
        // glVertexAttribPointerNV
        private delegate void VertexAttribPointerNVDel(uint  index, int  fsize, uint /*VertexAttribEnumNV*/  type, uint  stride, IntPtr  pointer); private static VertexAttribPointerNVDel VertexAttribPointerNVPtr;
        
        // glVertexAttribs1dvNV
        private delegate void VertexAttribs1dvNVDel(uint  index, uint  count, double[]  v); private static VertexAttribs1dvNVDel VertexAttribs1dvNVPtr;
        
        // glVertexAttribs1fvNV
        private delegate void VertexAttribs1fvNVDel(uint  index, uint  count, float[]  v); private static VertexAttribs1fvNVDel VertexAttribs1fvNVPtr;
        
        // glVertexAttribs1hvNV
        private delegate void VertexAttribs1hvNVDel(uint  index, uint  n, ushort[] /*Half16NV*/  v); private static VertexAttribs1hvNVDel VertexAttribs1hvNVPtr;
        
        // glVertexAttribs1svNV
        private delegate void VertexAttribs1svNVDel(uint  index, uint  count, short[]  v); private static VertexAttribs1svNVDel VertexAttribs1svNVPtr;
        
        // glVertexAttribs2dvNV
        private delegate void VertexAttribs2dvNVDel(uint  index, uint  count, double[]  v); private static VertexAttribs2dvNVDel VertexAttribs2dvNVPtr;
        
        // glVertexAttribs2fvNV
        private delegate void VertexAttribs2fvNVDel(uint  index, uint  count, float[]  v); private static VertexAttribs2fvNVDel VertexAttribs2fvNVPtr;
        
        // glVertexAttribs2hvNV
        private delegate void VertexAttribs2hvNVDel(uint  index, uint  n, ushort[] /*Half16NV*/  v); private static VertexAttribs2hvNVDel VertexAttribs2hvNVPtr;
        
        // glVertexAttribs2svNV
        private delegate void VertexAttribs2svNVDel(uint  index, uint  count, short[]  v); private static VertexAttribs2svNVDel VertexAttribs2svNVPtr;
        
        // glVertexAttribs3dvNV
        private delegate void VertexAttribs3dvNVDel(uint  index, uint  count, double[]  v); private static VertexAttribs3dvNVDel VertexAttribs3dvNVPtr;
        
        // glVertexAttribs3fvNV
        private delegate void VertexAttribs3fvNVDel(uint  index, uint  count, float[]  v); private static VertexAttribs3fvNVDel VertexAttribs3fvNVPtr;
        
        // glVertexAttribs3hvNV
        private delegate void VertexAttribs3hvNVDel(uint  index, uint  n, ushort[] /*Half16NV*/  v); private static VertexAttribs3hvNVDel VertexAttribs3hvNVPtr;
        
        // glVertexAttribs3svNV
        private delegate void VertexAttribs3svNVDel(uint  index, uint  count, short[]  v); private static VertexAttribs3svNVDel VertexAttribs3svNVPtr;
        
        // glVertexAttribs4dvNV
        private delegate void VertexAttribs4dvNVDel(uint  index, uint  count, double[]  v); private static VertexAttribs4dvNVDel VertexAttribs4dvNVPtr;
        
        // glVertexAttribs4fvNV
        private delegate void VertexAttribs4fvNVDel(uint  index, uint  count, float[]  v); private static VertexAttribs4fvNVDel VertexAttribs4fvNVPtr;
        
        // glVertexAttribs4hvNV
        private delegate void VertexAttribs4hvNVDel(uint  index, uint  n, ushort[] /*Half16NV*/  v); private static VertexAttribs4hvNVDel VertexAttribs4hvNVPtr;
        
        // glVertexAttribs4svNV
        private delegate void VertexAttribs4svNVDel(uint  index, uint  count, short[]  v); private static VertexAttribs4svNVDel VertexAttribs4svNVPtr;
        
        // glVertexAttribs4ubvNV
        private delegate void VertexAttribs4ubvNVDel(uint  index, uint  count, byte[] /*ColorUB*/  v); private static VertexAttribs4ubvNVDel VertexAttribs4ubvNVPtr;
        
        // glVertexBindingDivisor
        private delegate void VertexBindingDivisorDel(uint  bindingindex, uint  divisor); private static VertexBindingDivisorDel VertexBindingDivisorPtr;
        
        // glVertexBlendARB
        private delegate void VertexBlendARBDel(int  count); private static VertexBlendARBDel VertexBlendARBPtr;
        
        // glVertexBlendEnvfATI
        private delegate void VertexBlendEnvfATIDel(uint /*VertexStreamATI*/  pname, float  param); private static VertexBlendEnvfATIDel VertexBlendEnvfATIPtr;
        
        // glVertexBlendEnviATI
        private delegate void VertexBlendEnviATIDel(uint /*VertexStreamATI*/  pname, int  param); private static VertexBlendEnviATIDel VertexBlendEnviATIPtr;
        
        // glVertexFormatNV
        private delegate void VertexFormatNVDel(int  size, uint /*VertexPointerType*/  type, uint  stride); private static VertexFormatNVDel VertexFormatNVPtr;
        
        // glVertexP2ui
        private delegate void VertexP2uiDel(uint /*VertexPointerType*/  type, uint  value); private static VertexP2uiDel VertexP2uiPtr;
        
        // glVertexP2uiv
        private delegate void VertexP2uivDel(uint /*VertexPointerType*/  type, uint[]  value); private static VertexP2uivDel VertexP2uivPtr;
        
        // glVertexP3ui
        private delegate void VertexP3uiDel(uint /*VertexPointerType*/  type, uint  value); private static VertexP3uiDel VertexP3uiPtr;
        
        // glVertexP3uiv
        private delegate void VertexP3uivDel(uint /*VertexPointerType*/  type, uint[]  value); private static VertexP3uivDel VertexP3uivPtr;
        
        // glVertexP4ui
        private delegate void VertexP4uiDel(uint /*VertexPointerType*/  type, uint  value); private static VertexP4uiDel VertexP4uiPtr;
        
        // glVertexP4uiv
        private delegate void VertexP4uivDel(uint /*VertexPointerType*/  type, uint[]  value); private static VertexP4uivDel VertexP4uivPtr;
        
        // glVertexPointer
        private delegate void VertexPointerDel(int  size, uint /*VertexPointerType*/  type, uint  stride, IntPtr  pointer); private static VertexPointerDel VertexPointerPtr;
        
        // glVertexPointerEXT
        private delegate void VertexPointerEXTDel(int  size, uint /*VertexPointerType*/  type, uint  stride, uint  count, IntPtr  pointer); private static VertexPointerEXTDel VertexPointerEXTPtr;
        
        // glVertexPointerListIBM
        private delegate void VertexPointerListIBMDel(int  size, uint /*VertexPointerType*/  type, int  stride, IntPtr  pointer, int  ptrstride); private static VertexPointerListIBMDel VertexPointerListIBMPtr;
        
        // glVertexPointervINTEL
        private delegate void VertexPointervINTELDel(int  size, uint /*VertexPointerType*/  type, IntPtr  pointer); private static VertexPointervINTELDel VertexPointervINTELPtr;
        
        // glVertexStream1dATI
        private delegate void VertexStream1dATIDel(uint /*VertexStreamATI*/  stream, double  x); private static VertexStream1dATIDel VertexStream1dATIPtr;
        
        // glVertexStream1dvATI
        private delegate void VertexStream1dvATIDel(uint /*VertexStreamATI*/  stream, double[]  coords); private static VertexStream1dvATIDel VertexStream1dvATIPtr;
        
        // glVertexStream1fATI
        private delegate void VertexStream1fATIDel(uint /*VertexStreamATI*/  stream, float  x); private static VertexStream1fATIDel VertexStream1fATIPtr;
        
        // glVertexStream1fvATI
        private delegate void VertexStream1fvATIDel(uint /*VertexStreamATI*/  stream, float[]  coords); private static VertexStream1fvATIDel VertexStream1fvATIPtr;
        
        // glVertexStream1iATI
        private delegate void VertexStream1iATIDel(uint /*VertexStreamATI*/  stream, int  x); private static VertexStream1iATIDel VertexStream1iATIPtr;
        
        // glVertexStream1ivATI
        private delegate void VertexStream1ivATIDel(uint /*VertexStreamATI*/  stream, int[]  coords); private static VertexStream1ivATIDel VertexStream1ivATIPtr;
        
        // glVertexStream1sATI
        private delegate void VertexStream1sATIDel(uint /*VertexStreamATI*/  stream, short  x); private static VertexStream1sATIDel VertexStream1sATIPtr;
        
        // glVertexStream1svATI
        private delegate void VertexStream1svATIDel(uint /*VertexStreamATI*/  stream, short[]  coords); private static VertexStream1svATIDel VertexStream1svATIPtr;
        
        // glVertexStream2dATI
        private delegate void VertexStream2dATIDel(uint /*VertexStreamATI*/  stream, double  x, double  y); private static VertexStream2dATIDel VertexStream2dATIPtr;
        
        // glVertexStream2dvATI
        private delegate void VertexStream2dvATIDel(uint /*VertexStreamATI*/  stream, double[]  coords); private static VertexStream2dvATIDel VertexStream2dvATIPtr;
        
        // glVertexStream2fATI
        private delegate void VertexStream2fATIDel(uint /*VertexStreamATI*/  stream, float  x, float  y); private static VertexStream2fATIDel VertexStream2fATIPtr;
        
        // glVertexStream2fvATI
        private delegate void VertexStream2fvATIDel(uint /*VertexStreamATI*/  stream, float[]  coords); private static VertexStream2fvATIDel VertexStream2fvATIPtr;
        
        // glVertexStream2iATI
        private delegate void VertexStream2iATIDel(uint /*VertexStreamATI*/  stream, int  x, int  y); private static VertexStream2iATIDel VertexStream2iATIPtr;
        
        // glVertexStream2ivATI
        private delegate void VertexStream2ivATIDel(uint /*VertexStreamATI*/  stream, int[]  coords); private static VertexStream2ivATIDel VertexStream2ivATIPtr;
        
        // glVertexStream2sATI
        private delegate void VertexStream2sATIDel(uint /*VertexStreamATI*/  stream, short  x, short  y); private static VertexStream2sATIDel VertexStream2sATIPtr;
        
        // glVertexStream2svATI
        private delegate void VertexStream2svATIDel(uint /*VertexStreamATI*/  stream, short[]  coords); private static VertexStream2svATIDel VertexStream2svATIPtr;
        
        // glVertexStream3dATI
        private delegate void VertexStream3dATIDel(uint /*VertexStreamATI*/  stream, double  x, double  y, double  z); private static VertexStream3dATIDel VertexStream3dATIPtr;
        
        // glVertexStream3dvATI
        private delegate void VertexStream3dvATIDel(uint /*VertexStreamATI*/  stream, double[]  coords); private static VertexStream3dvATIDel VertexStream3dvATIPtr;
        
        // glVertexStream3fATI
        private delegate void VertexStream3fATIDel(uint /*VertexStreamATI*/  stream, float  x, float  y, float  z); private static VertexStream3fATIDel VertexStream3fATIPtr;
        
        // glVertexStream3fvATI
        private delegate void VertexStream3fvATIDel(uint /*VertexStreamATI*/  stream, float[]  coords); private static VertexStream3fvATIDel VertexStream3fvATIPtr;
        
        // glVertexStream3iATI
        private delegate void VertexStream3iATIDel(uint /*VertexStreamATI*/  stream, int  x, int  y, int  z); private static VertexStream3iATIDel VertexStream3iATIPtr;
        
        // glVertexStream3ivATI
        private delegate void VertexStream3ivATIDel(uint /*VertexStreamATI*/  stream, int[]  coords); private static VertexStream3ivATIDel VertexStream3ivATIPtr;
        
        // glVertexStream3sATI
        private delegate void VertexStream3sATIDel(uint /*VertexStreamATI*/  stream, short  x, short  y, short  z); private static VertexStream3sATIDel VertexStream3sATIPtr;
        
        // glVertexStream3svATI
        private delegate void VertexStream3svATIDel(uint /*VertexStreamATI*/  stream, short[]  coords); private static VertexStream3svATIDel VertexStream3svATIPtr;
        
        // glVertexStream4dATI
        private delegate void VertexStream4dATIDel(uint /*VertexStreamATI*/  stream, double  x, double  y, double  z, double  w); private static VertexStream4dATIDel VertexStream4dATIPtr;
        
        // glVertexStream4dvATI
        private delegate void VertexStream4dvATIDel(uint /*VertexStreamATI*/  stream, double[]  coords); private static VertexStream4dvATIDel VertexStream4dvATIPtr;
        
        // glVertexStream4fATI
        private delegate void VertexStream4fATIDel(uint /*VertexStreamATI*/  stream, float  x, float  y, float  z, float  w); private static VertexStream4fATIDel VertexStream4fATIPtr;
        
        // glVertexStream4fvATI
        private delegate void VertexStream4fvATIDel(uint /*VertexStreamATI*/  stream, float[]  coords); private static VertexStream4fvATIDel VertexStream4fvATIPtr;
        
        // glVertexStream4iATI
        private delegate void VertexStream4iATIDel(uint /*VertexStreamATI*/  stream, int  x, int  y, int  z, int  w); private static VertexStream4iATIDel VertexStream4iATIPtr;
        
        // glVertexStream4ivATI
        private delegate void VertexStream4ivATIDel(uint /*VertexStreamATI*/  stream, int[]  coords); private static VertexStream4ivATIDel VertexStream4ivATIPtr;
        
        // glVertexStream4sATI
        private delegate void VertexStream4sATIDel(uint /*VertexStreamATI*/  stream, short  x, short  y, short  z, short  w); private static VertexStream4sATIDel VertexStream4sATIPtr;
        
        // glVertexStream4svATI
        private delegate void VertexStream4svATIDel(uint /*VertexStreamATI*/  stream, short[]  coords); private static VertexStream4svATIDel VertexStream4svATIPtr;
        
        // glVertexWeightPointerEXT
        private delegate void VertexWeightPointerEXTDel(int  size, uint /*VertexWeightPointerTypeEXT*/  type, uint  stride, IntPtr  pointer); private static VertexWeightPointerEXTDel VertexWeightPointerEXTPtr;
        
        // glVertexWeightfEXT
        private delegate void VertexWeightfEXTDel(float  weight); private static VertexWeightfEXTDel VertexWeightfEXTPtr;
        
        // glVertexWeightfvEXT
        private delegate void VertexWeightfvEXTDel(float[]  weight); private static VertexWeightfvEXTDel VertexWeightfvEXTPtr;
        
        // glVertexWeighthNV
        private delegate void VertexWeighthNVDel(ushort /*Half16NV*/  weight); private static VertexWeighthNVDel VertexWeighthNVPtr;
        
        // glVertexWeighthvNV
        private delegate void VertexWeighthvNVDel(ushort[] /*Half16NV*/  weight); private static VertexWeighthvNVDel VertexWeighthvNVPtr;
        
        // glVideoCaptureNV
        private delegate uint VideoCaptureNVDel(uint  video_capture_slot, uint[]  sequence_num, ulong[]  capture_time); private static VideoCaptureNVDel VideoCaptureNVPtr;
        
        // glVideoCaptureStreamParameterdvNV
        private delegate void VideoCaptureStreamParameterdvNVDel(uint  video_capture_slot, uint  stream, uint  pname, double[]  parameters); private static VideoCaptureStreamParameterdvNVDel VideoCaptureStreamParameterdvNVPtr;
        
        // glVideoCaptureStreamParameterfvNV
        private delegate void VideoCaptureStreamParameterfvNVDel(uint  video_capture_slot, uint  stream, uint  pname, float[]  parameters); private static VideoCaptureStreamParameterfvNVDel VideoCaptureStreamParameterfvNVPtr;
        
        // glVideoCaptureStreamParameterivNV
        private delegate void VideoCaptureStreamParameterivNVDel(uint  video_capture_slot, uint  stream, uint  pname, int[]  parameters); private static VideoCaptureStreamParameterivNVDel VideoCaptureStreamParameterivNVPtr;
        
        // glViewport
        private delegate void ViewportDel(int /*WinCoord*/  x, int /*WinCoord*/  y, uint  width, uint  height); private static ViewportDel ViewportPtr;
        
        // glViewportArrayv
        private delegate void ViewportArrayvDel(uint  first, uint  count, float[]  v); private static ViewportArrayvDel ViewportArrayvPtr;
        
        // glViewportArrayvNV
        private delegate void ViewportArrayvNVDel(uint  first, uint  count, float[]  v); private static ViewportArrayvNVDel ViewportArrayvNVPtr;
        
        // glViewportArrayvOES
        private delegate void ViewportArrayvOESDel(uint  first, uint  count, float[]  v); private static ViewportArrayvOESDel ViewportArrayvOESPtr;
        
        // glViewportIndexedf
        private delegate void ViewportIndexedfDel(uint  index, float  x, float  y, float  w, float  h); private static ViewportIndexedfDel ViewportIndexedfPtr;
        
        // glViewportIndexedfOES
        private delegate void ViewportIndexedfOESDel(uint  index, float  x, float  y, float  w, float  h); private static ViewportIndexedfOESDel ViewportIndexedfOESPtr;
        
        // glViewportIndexedfNV
        private delegate void ViewportIndexedfNVDel(uint  index, float  x, float  y, float  w, float  h); private static ViewportIndexedfNVDel ViewportIndexedfNVPtr;
        
        // glViewportIndexedfv
        private delegate void ViewportIndexedfvDel(uint  index, float[]  v); private static ViewportIndexedfvDel ViewportIndexedfvPtr;
        
        // glViewportIndexedfvOES
        private delegate void ViewportIndexedfvOESDel(uint  index, float[]  v); private static ViewportIndexedfvOESDel ViewportIndexedfvOESPtr;
        
        // glViewportIndexedfvNV
        private delegate void ViewportIndexedfvNVDel(uint  index, float[]  v); private static ViewportIndexedfvNVDel ViewportIndexedfvNVPtr;
        
        // glViewportPositionWScaleNV
        private delegate void ViewportPositionWScaleNVDel(uint  index, float  xcoeff, float  ycoeff); private static ViewportPositionWScaleNVDel ViewportPositionWScaleNVPtr;
        
        // glViewportSwizzleNV
        private delegate void ViewportSwizzleNVDel(uint  index, uint  swizzlex, uint  swizzley, uint  swizzlez, uint  swizzlew); private static ViewportSwizzleNVDel ViewportSwizzleNVPtr;
        
        // glWaitSemaphoreEXT
        private delegate void WaitSemaphoreEXTDel(uint  semaphore, uint  numBufferBarriers, uint[]  buffers, uint  numTextureBarriers, uint[]  textures, uint[] /*TextureLayout*/  srcLayouts); private static WaitSemaphoreEXTDel WaitSemaphoreEXTPtr;
        
        // glWaitSemaphoreui64NVX
        private delegate void WaitSemaphoreui64NVXDel(uint  waitGpu, uint  fenceObjectCount, uint[]  semaphoreArray, ulong[]  fenceValueArray); private static WaitSemaphoreui64NVXDel WaitSemaphoreui64NVXPtr;
        
        // glWaitSync
        private delegate void WaitSyncDel(IntPtr /*sync*/  sync, uint  flags, ulong  timeout); private static WaitSyncDel WaitSyncPtr;
        
        // glWaitSyncAPPLE
        private delegate void WaitSyncAPPLEDel(IntPtr  sync, uint  flags, ulong  timeout); private static WaitSyncAPPLEDel WaitSyncAPPLEPtr;
        
        // glWeightPathsNV
        private delegate void WeightPathsNVDel(uint /*Path*/  resultPath, uint  numPaths, uint[] /*Path*/  paths, float[]  weights); private static WeightPathsNVDel WeightPathsNVPtr;
        
        // glWeightPointerARB
        private delegate void WeightPointerARBDel(int  size, uint /*WeightPointerTypeARB*/  type, uint  stride, IntPtr  pointer); private static WeightPointerARBDel WeightPointerARBPtr;
        
        // glWeightPointerOES
        private delegate void WeightPointerOESDel(int  size, uint  type, uint  stride, IntPtr  pointer); private static WeightPointerOESDel WeightPointerOESPtr;
        
        // glWeightbvARB
        private delegate void WeightbvARBDel(int  size, sbyte[]  weights); private static WeightbvARBDel WeightbvARBPtr;
        
        // glWeightdvARB
        private delegate void WeightdvARBDel(int  size, double[]  weights); private static WeightdvARBDel WeightdvARBPtr;
        
        // glWeightfvARB
        private delegate void WeightfvARBDel(int  size, float[]  weights); private static WeightfvARBDel WeightfvARBPtr;
        
        // glWeightivARB
        private delegate void WeightivARBDel(int  size, int[]  weights); private static WeightivARBDel WeightivARBPtr;
        
        // glWeightsvARB
        private delegate void WeightsvARBDel(int  size, short[]  weights); private static WeightsvARBDel WeightsvARBPtr;
        
        // glWeightubvARB
        private delegate void WeightubvARBDel(int  size, byte[]  weights); private static WeightubvARBDel WeightubvARBPtr;
        
        // glWeightuivARB
        private delegate void WeightuivARBDel(int  size, uint[]  weights); private static WeightuivARBDel WeightuivARBPtr;
        
        // glWeightusvARB
        private delegate void WeightusvARBDel(int  size, ushort[]  weights); private static WeightusvARBDel WeightusvARBPtr;
        
        // glWindowPos2d
        private delegate void WindowPos2dDel(double /*CoordD*/  x, double /*CoordD*/  y); private static WindowPos2dDel WindowPos2dPtr;
        
        // glWindowPos2dARB
        private delegate void WindowPos2dARBDel(double /*CoordD*/  x, double /*CoordD*/  y); private static WindowPos2dARBDel WindowPos2dARBPtr;
        
        // glWindowPos2dMESA
        private delegate void WindowPos2dMESADel(double /*CoordD*/  x, double /*CoordD*/  y); private static WindowPos2dMESADel WindowPos2dMESAPtr;
        
        // glWindowPos2dv
        private delegate void WindowPos2dvDel(double[] /*CoordD*/  v); private static WindowPos2dvDel WindowPos2dvPtr;
        
        // glWindowPos2dvARB
        private delegate void WindowPos2dvARBDel(double[] /*CoordD*/  v); private static WindowPos2dvARBDel WindowPos2dvARBPtr;
        
        // glWindowPos2dvMESA
        private delegate void WindowPos2dvMESADel(double[] /*CoordD*/  v); private static WindowPos2dvMESADel WindowPos2dvMESAPtr;
        
        // glWindowPos2f
        private delegate void WindowPos2fDel(float /*CoordF*/  x, float /*CoordF*/  y); private static WindowPos2fDel WindowPos2fPtr;
        
        // glWindowPos2fARB
        private delegate void WindowPos2fARBDel(float /*CoordF*/  x, float /*CoordF*/  y); private static WindowPos2fARBDel WindowPos2fARBPtr;
        
        // glWindowPos2fMESA
        private delegate void WindowPos2fMESADel(float /*CoordF*/  x, float /*CoordF*/  y); private static WindowPos2fMESADel WindowPos2fMESAPtr;
        
        // glWindowPos2fv
        private delegate void WindowPos2fvDel(float[] /*CoordF*/  v); private static WindowPos2fvDel WindowPos2fvPtr;
        
        // glWindowPos2fvARB
        private delegate void WindowPos2fvARBDel(float[] /*CoordF*/  v); private static WindowPos2fvARBDel WindowPos2fvARBPtr;
        
        // glWindowPos2fvMESA
        private delegate void WindowPos2fvMESADel(float[] /*CoordF*/  v); private static WindowPos2fvMESADel WindowPos2fvMESAPtr;
        
        // glWindowPos2i
        private delegate void WindowPos2iDel(int /*CoordI*/  x, int /*CoordI*/  y); private static WindowPos2iDel WindowPos2iPtr;
        
        // glWindowPos2iARB
        private delegate void WindowPos2iARBDel(int /*CoordI*/  x, int /*CoordI*/  y); private static WindowPos2iARBDel WindowPos2iARBPtr;
        
        // glWindowPos2iMESA
        private delegate void WindowPos2iMESADel(int /*CoordI*/  x, int /*CoordI*/  y); private static WindowPos2iMESADel WindowPos2iMESAPtr;
        
        // glWindowPos2iv
        private delegate void WindowPos2ivDel(int[] /*CoordI*/  v); private static WindowPos2ivDel WindowPos2ivPtr;
        
        // glWindowPos2ivARB
        private delegate void WindowPos2ivARBDel(int[] /*CoordI*/  v); private static WindowPos2ivARBDel WindowPos2ivARBPtr;
        
        // glWindowPos2ivMESA
        private delegate void WindowPos2ivMESADel(int[] /*CoordI*/  v); private static WindowPos2ivMESADel WindowPos2ivMESAPtr;
        
        // glWindowPos2s
        private delegate void WindowPos2sDel(short /*CoordS*/  x, short /*CoordS*/  y); private static WindowPos2sDel WindowPos2sPtr;
        
        // glWindowPos2sARB
        private delegate void WindowPos2sARBDel(short /*CoordS*/  x, short /*CoordS*/  y); private static WindowPos2sARBDel WindowPos2sARBPtr;
        
        // glWindowPos2sMESA
        private delegate void WindowPos2sMESADel(short /*CoordS*/  x, short /*CoordS*/  y); private static WindowPos2sMESADel WindowPos2sMESAPtr;
        
        // glWindowPos2sv
        private delegate void WindowPos2svDel(short[] /*CoordS*/  v); private static WindowPos2svDel WindowPos2svPtr;
        
        // glWindowPos2svARB
        private delegate void WindowPos2svARBDel(short[] /*CoordS*/  v); private static WindowPos2svARBDel WindowPos2svARBPtr;
        
        // glWindowPos2svMESA
        private delegate void WindowPos2svMESADel(short[] /*CoordS*/  v); private static WindowPos2svMESADel WindowPos2svMESAPtr;
        
        // glWindowPos3d
        private delegate void WindowPos3dDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z); private static WindowPos3dDel WindowPos3dPtr;
        
        // glWindowPos3dARB
        private delegate void WindowPos3dARBDel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z); private static WindowPos3dARBDel WindowPos3dARBPtr;
        
        // glWindowPos3dMESA
        private delegate void WindowPos3dMESADel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z); private static WindowPos3dMESADel WindowPos3dMESAPtr;
        
        // glWindowPos3dv
        private delegate void WindowPos3dvDel(double[] /*CoordD*/  v); private static WindowPos3dvDel WindowPos3dvPtr;
        
        // glWindowPos3dvARB
        private delegate void WindowPos3dvARBDel(double[] /*CoordD*/  v); private static WindowPos3dvARBDel WindowPos3dvARBPtr;
        
        // glWindowPos3dvMESA
        private delegate void WindowPos3dvMESADel(double[] /*CoordD*/  v); private static WindowPos3dvMESADel WindowPos3dvMESAPtr;
        
        // glWindowPos3f
        private delegate void WindowPos3fDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z); private static WindowPos3fDel WindowPos3fPtr;
        
        // glWindowPos3fARB
        private delegate void WindowPos3fARBDel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z); private static WindowPos3fARBDel WindowPos3fARBPtr;
        
        // glWindowPos3fMESA
        private delegate void WindowPos3fMESADel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z); private static WindowPos3fMESADel WindowPos3fMESAPtr;
        
        // glWindowPos3fv
        private delegate void WindowPos3fvDel(float[] /*CoordF*/  v); private static WindowPos3fvDel WindowPos3fvPtr;
        
        // glWindowPos3fvARB
        private delegate void WindowPos3fvARBDel(float[] /*CoordF*/  v); private static WindowPos3fvARBDel WindowPos3fvARBPtr;
        
        // glWindowPos3fvMESA
        private delegate void WindowPos3fvMESADel(float[] /*CoordF*/  v); private static WindowPos3fvMESADel WindowPos3fvMESAPtr;
        
        // glWindowPos3i
        private delegate void WindowPos3iDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z); private static WindowPos3iDel WindowPos3iPtr;
        
        // glWindowPos3iARB
        private delegate void WindowPos3iARBDel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z); private static WindowPos3iARBDel WindowPos3iARBPtr;
        
        // glWindowPos3iMESA
        private delegate void WindowPos3iMESADel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z); private static WindowPos3iMESADel WindowPos3iMESAPtr;
        
        // glWindowPos3iv
        private delegate void WindowPos3ivDel(int[] /*CoordI*/  v); private static WindowPos3ivDel WindowPos3ivPtr;
        
        // glWindowPos3ivARB
        private delegate void WindowPos3ivARBDel(int[] /*CoordI*/  v); private static WindowPos3ivARBDel WindowPos3ivARBPtr;
        
        // glWindowPos3ivMESA
        private delegate void WindowPos3ivMESADel(int[] /*CoordI*/  v); private static WindowPos3ivMESADel WindowPos3ivMESAPtr;
        
        // glWindowPos3s
        private delegate void WindowPos3sDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z); private static WindowPos3sDel WindowPos3sPtr;
        
        // glWindowPos3sARB
        private delegate void WindowPos3sARBDel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z); private static WindowPos3sARBDel WindowPos3sARBPtr;
        
        // glWindowPos3sMESA
        private delegate void WindowPos3sMESADel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z); private static WindowPos3sMESADel WindowPos3sMESAPtr;
        
        // glWindowPos3sv
        private delegate void WindowPos3svDel(short[] /*CoordS*/  v); private static WindowPos3svDel WindowPos3svPtr;
        
        // glWindowPos3svARB
        private delegate void WindowPos3svARBDel(short[] /*CoordS*/  v); private static WindowPos3svARBDel WindowPos3svARBPtr;
        
        // glWindowPos3svMESA
        private delegate void WindowPos3svMESADel(short[] /*CoordS*/  v); private static WindowPos3svMESADel WindowPos3svMESAPtr;
        
        // glWindowPos4dMESA
        private delegate void WindowPos4dMESADel(double /*CoordD*/  x, double /*CoordD*/  y, double /*CoordD*/  z, double /*CoordD*/  w); private static WindowPos4dMESADel WindowPos4dMESAPtr;
        
        // glWindowPos4dvMESA
        private delegate void WindowPos4dvMESADel(double[] /*CoordD*/  v); private static WindowPos4dvMESADel WindowPos4dvMESAPtr;
        
        // glWindowPos4fMESA
        private delegate void WindowPos4fMESADel(float /*CoordF*/  x, float /*CoordF*/  y, float /*CoordF*/  z, float /*CoordF*/  w); private static WindowPos4fMESADel WindowPos4fMESAPtr;
        
        // glWindowPos4fvMESA
        private delegate void WindowPos4fvMESADel(float[] /*CoordF*/  v); private static WindowPos4fvMESADel WindowPos4fvMESAPtr;
        
        // glWindowPos4iMESA
        private delegate void WindowPos4iMESADel(int /*CoordI*/  x, int /*CoordI*/  y, int /*CoordI*/  z, int /*CoordI*/  w); private static WindowPos4iMESADel WindowPos4iMESAPtr;
        
        // glWindowPos4ivMESA
        private delegate void WindowPos4ivMESADel(int[] /*CoordI*/  v); private static WindowPos4ivMESADel WindowPos4ivMESAPtr;
        
        // glWindowPos4sMESA
        private delegate void WindowPos4sMESADel(short /*CoordS*/  x, short /*CoordS*/  y, short /*CoordS*/  z, short /*CoordS*/  w); private static WindowPos4sMESADel WindowPos4sMESAPtr;
        
        // glWindowPos4svMESA
        private delegate void WindowPos4svMESADel(short[] /*CoordS*/  v); private static WindowPos4svMESADel WindowPos4svMESAPtr;
        
        // glWindowRectanglesEXT
        private delegate void WindowRectanglesEXTDel(uint  mode, uint  count, int[]  box); private static WindowRectanglesEXTDel WindowRectanglesEXTPtr;
        
        // glWriteMaskEXT
        private delegate void WriteMaskEXTDel(uint  res, uint  inp, uint /*VertexShaderWriteMaskEXT*/  outX, uint /*VertexShaderWriteMaskEXT*/  outY, uint /*VertexShaderWriteMaskEXT*/  outZ, uint /*VertexShaderWriteMaskEXT*/  outW); private static WriteMaskEXTDel WriteMaskEXTPtr;
        
        // glDrawVkImageNV
        private delegate void DrawVkImageNVDel(ulong  vkImage, uint  sampler, float  x0, float  y0, float  x1, float  y1, float  z, float  s0, float  t0, float  s1, float  t1); private static DrawVkImageNVDel DrawVkImageNVPtr;
        
        // glGetVkProcAddrNV
        private delegate IntPtr /*GLVULKANPROCNV*/ GetVkProcAddrNVDel(string  name); private static GetVkProcAddrNVDel GetVkProcAddrNVPtr;
        
        // glWaitVkSemaphoreNV
        private delegate void WaitVkSemaphoreNVDel(ulong  vkSemaphore); private static WaitVkSemaphoreNVDel WaitVkSemaphoreNVPtr;
        
        // glSignalVkSemaphoreNV
        private delegate void SignalVkSemaphoreNVDel(ulong  vkSemaphore); private static SignalVkSemaphoreNVDel SignalVkSemaphoreNVPtr;
        
        // glSignalVkFenceNV
        private delegate void SignalVkFenceNVDel(ulong  vkFence); private static SignalVkFenceNVDel SignalVkFenceNVPtr;
        
        // glFramebufferParameteriMESA
        private delegate void FramebufferParameteriMESADel(uint /*FramebufferTarget*/  target, uint /*FramebufferParameterName*/  pname, int  param); private static FramebufferParameteriMESADel FramebufferParameteriMESAPtr;
        
        // glGetFramebufferParameterivMESA
        private delegate void GetFramebufferParameterivMESADel(uint /*FramebufferTarget*/  target, uint /*FramebufferAttachmentParameterName*/  pname, int[]  parameters); private static GetFramebufferParameterivMESADel GetFramebufferParameterivMESAPtr;
        

    }
}
