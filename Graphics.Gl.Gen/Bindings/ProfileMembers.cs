/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Collections.Generic;
using Yagl.Gl.Generator.Spec;

namespace Yagl.Gl.Generator.Bindings
{
    public class ProfileMembers
    {
        public Profile Profile { get; set; }
        public List<EnumItem> Constants { get; set; }
        public List<Command> Commands { get; set; }
        
        
    }
}