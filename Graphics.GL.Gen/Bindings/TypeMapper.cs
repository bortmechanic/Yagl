/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable UnusedAutoPropertyAccessor.Global

using System.Collections.Generic;
using System.Linq;
using Yagl.GL.Generator.Spec;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Bindings
{
    public static class TypeMapper
    {
        private static readonly Dictionary<string, TypeMap> Mapping = new Dictionary<string, TypeMap>();
        private static readonly string[] SkipList = {"khrplatform"};

        public static void Init()
        {
            Mapping.Clear();

            // OpenGL base types.
            // https://www.khronos.org/opengl/wiki/OpenGL_Type
            Mapping.Add("GLboolean", new TypeMap {Name = "GLboolean", Type = "byte"});
            Mapping.Add("GLbyte", new TypeMap {Name = "GLbyte", Type = "sbyte"});
            Mapping.Add("GLubyte", new TypeMap {Name = "GLubyte", Type = "byte"});
            Mapping.Add("GLshort", new TypeMap {Name = "GLshort", Type = "short"});
            Mapping.Add("GLushort", new TypeMap {Name = "GLushort", Type = "ushort"});
            Mapping.Add("GLint", new TypeMap {Name = "GLint", Type = "int"});
            Mapping.Add("GLuint", new TypeMap {Name = "GLuint", Type = "uint"});
            Mapping.Add("GLfixed", new TypeMap {Name = "GLfixed", Type = "int"});
            Mapping.Add("GLint64", new TypeMap {Name = "GLint64", Type = "long"});
            Mapping.Add("GLuint64", new TypeMap {Name = "GLuint64", Type = "ulong"});
            Mapping.Add("GLsizei", new TypeMap { Name = "GLsizei", Type = "uint" });
            Mapping.Add("GLenum", new TypeMap {Name = "GLenum", Type = "uint"});
            Mapping.Add("GLintptr", new TypeMap { Name = "GLintptr", Type = "IntPtr" });
            Mapping.Add("GLsizeiptr", new TypeMap { Name = "GLsizeiptr", Type = "UIntPtr" });
            Mapping.Add("GLsync", new TypeMap { Name = "GLsync", Type = "IntPtr" });
            Mapping.Add("GLbitfield", new TypeMap {Name = "GLbitfield", Type = "uint"});
            Mapping.Add("bitmask", new TypeMap {Name = "GLbitfield", Type = "uint"});
            Mapping.Add("GLhalf", new TypeMap { Name = "GLhalf", Type = "ushort" });
            Mapping.Add("GLfloat", new TypeMap { Name = "GLfloat", Type = "float" });
            Mapping.Add("GLclampf", new TypeMap { Name = "GLclampf", Type = "float" });
            Mapping.Add("GLdouble", new TypeMap { Name = "GLdouble", Type = "double" });
            Mapping.Add("GLclampd", new TypeMap { Name = "GLclampd", Type = "double" });
            
            Mapping.Add("GLvoid", new TypeMap {Name = "GLvoid", Type = "void"});
            Mapping.Add("GLclampx", new TypeMap { Name = "GLclampx", Type = "int" });
            Mapping.Add("GLchar", new TypeMap { Name = "GLchar", Type = "char" });

            Mapping.Add("GLcharARB", new TypeMap { Name = "GLcharARB", Type = "char" });
            Mapping.Add("GLintptrARB", new TypeMap { Name = "GLintptrARB", Type = "IntPtr" });
            Mapping.Add("GLsizeiptrARB", new TypeMap { Name = "GLsizeiptrARB", Type = "UIntPtr" });
            Mapping.Add("GLhandleARB", new TypeMap { Name = "GLhandleARB", Type = "UIntPtr" });
            Mapping.Add("GLhalfARB", new TypeMap { Name = "GLhalfARB", Type = "ushort" });
            Mapping.Add("GLhalfNV", new TypeMap { Name = "GLhalfNV", Type = "ushort" });
            Mapping.Add("GLint64EXT", new TypeMap {Name = "GLint64EXT", Type = "long"});
            Mapping.Add("GLuint64EXT", new TypeMap {Name = "GLuint64EXT", Type = "ulong"});
            Mapping.Add("GLeglClientBufferEXT", new TypeMap { Name = "GLeglClientBufferEXT", Type = "IntPtr" });
            Mapping.Add("GLeglImageOES", new TypeMap { Name = "GLeglImageOES", Type = "IntPtr" });
            Mapping.Add("struct _cl_context", new TypeMap { Name = "struct _cl_context", Type = "IntPtr" });
            Mapping.Add("struct _cl_event", new TypeMap { Name = "struct _cl_event", Type = "IntPtr" });
            Mapping.Add("GLvdpauSurfaceNV", new TypeMap { Name = "GLvdpauSurfaceNV", Type = "IntPtr" });
            
            Mapping.Add("GLDEBUGPROC", new TypeMap { Name = "GLDEBUGPROC", Type = "???" });
            Mapping.Add("GLDEBUGPROCARB", new TypeMap { Name = "GLDEBUGPROCARB", Type = "???" });
            Mapping.Add("GLDEBUGPROCKHR", new TypeMap { Name = "GLDEBUGPROCKHR", Type = "???" });
            Mapping.Add("GLDEBUGPROCAMD", new TypeMap { Name = "GLDEBUGPROCAMD", Type = "???" });
            Mapping.Add("GLVULKANPROCNV", new TypeMap { Name = "GLVULKANPROCNV", Type = "???" });
            
            Mapping.Add("const void *", new TypeMap { Name = "const void *", Type = "byte[]" });
            Mapping.Add("const GLboolean *", new TypeMap { Name = "const GLboolean *", Type = "byte[]" });
            Mapping.Add("const GLchar *", new TypeMap { Name = "const GLchar *", Type = "string" });
            Mapping.Add("const GLbyte *", new TypeMap { Name = "const GLbyte *", Type = "sbyte[]" });
            Mapping.Add("const GLubyte *", new TypeMap { Name = "const GLubyte *", Type = "byte[]" });
            Mapping.Add("const GLshort *", new TypeMap { Name = "const GLshort *", Type = "short[]" });
            Mapping.Add("const GLushort *", new TypeMap { Name = "const GLushort *", Type = "ushort[]" });
            Mapping.Add("const GLint *", new TypeMap { Name = "const GLint *", Type = "int[]"});
            Mapping.Add("const GLuint *", new TypeMap { Name = "const GLuint *", Type = "uint[]" });
            Mapping.Add("const GLfloat *", new TypeMap { Name = "const GLfloat *", Type = "float[]"});
            Mapping.Add("const GLdouble *", new TypeMap { Name = "const GLdouble *", Type = "double[]" });
            
            Mapping.Add("void *", new TypeMap { Name = "void *", Type = "ref byte[]" });
            Mapping.Add("GLboolean *", new TypeMap { Name = "GLboolean *", Type = "ref byte[]" });
            Mapping.Add("GLbyte *", new TypeMap { Name = "GLbyte *", Type = "ref sbyte[]" });
            Mapping.Add("GLubyte *", new TypeMap { Name = "GLubyte *", Type = "ref byte[]" });
            Mapping.Add("GLshort *", new TypeMap { Name = "GLshort *", Type = "ref short[]" });
            Mapping.Add("GLushort *", new TypeMap { Name = "GLushort *", Type = "ref ushort[]" });
            Mapping.Add("GLint *", new TypeMap { Name = "GLint *", Type = "ref int[]" });
            Mapping.Add("GLuint *", new TypeMap { Name = "GLuint *", Type = "ref uint[]" });
            Mapping.Add("GLfloat *", new TypeMap { Name = "GLfloat *", Type = "ref float[]" });
            Mapping.Add("GLdouble *", new TypeMap { Name = "GLdouble *", Type = "ref double[]" });

        }

        public static void Check(Specification spec)
        {
            Log.Info("Processing TYPES");
            foreach (var type in spec.Types)
            {
                if (SkipList.Contains(type.Name)) continue;
                var tm = GetType(type.Name);
                Log.Info($"  {type.Name} -> {tm?.Type ?? "..."}");
                if (tm == null)
                    Log.Error($"  No mapping found for type {type.Name}.");
            }
            Log.Info("DONE.");
            Log.Info();
        }

        public static TypeMap GetType(string type)
        {
            if (Mapping.TryGetValue(type, out var tm))
                return tm;
            Log.Error($"  Type mapping for '{type}' has not been found.");
            return new TypeMap {Name = type, Type = "?????"};
        }

        public class TypeMap
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }
    }
}