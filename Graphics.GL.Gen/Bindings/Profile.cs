/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

// ReSharper disable InconsistentNaming

namespace Yagl.Gl.Generator.Bindings
{
    public enum Profile
    {
        Unknown = 0,
        
        // OpenGL 1.x.
        GL_1_0 = 100,
        GL_1_1 = 110,
        GL_1_2 = 120,
        GL_1_3 = 130,
        GL_1_4 = 140,
        GL_1_5 = 150,
        
        // OpenGL 2.x.
        GL_2_0 = 200,
        GL_2_1 = 210,
        
        // OpenGL 3.x.
        GL_3_0 = 300,
        GL_3_1 = 310,
        GL_3_1_Undep = 311,
        GL_3_2_Core = 320,
        GL_3_2_Compatibility = 321,
        GL_3_3_Core = 330,
        GL_3_3_Compatibility = 331,

        // OpenGL 4.x.
        GL_4_0_Core = 400,
        GL_4_0_Compatibility = 401,
        GL_4_1_Core = 410,
        GL_4_1_Compatibility = 411,
        GL_4_2_Core = 420,
        GL_4_2_Compatibility = 421,
        GL_4_3_Core = 430,
        GL_4_3_Compatibility = 431,
        GL_4_4_Core = 440,
        GL_4_4_Compatibility = 441,
        GL_4_5_Core = 450,
        GL_4_5_Compatibility = 451,
        GL_4_6_Core = 460,
        GL_4_6_Compatibility = 461,

        // OpenGL ES 1.x.
        GL_ES_1_0 = 1100,
        GL_ES_1_1 = 1100,
        
        // OpenGL ES 2.x.
        GL_ES_2_0 = 1100,
        
        // OpenGL ES 3.x.
        GL_ES_3_0 = 1100,
        GL_ES_3_1 = 1100,
        GL_ES_3_2 = 1100,
        

    }
}