/*
 This source file is a part of the project YAGL.
 Copyright (c) 2020 Pavel Melnikov.
 Distributed under the MIT License (http://opensource.org/licenses/MIT).
 See LICENSE.txt for the full license text.
*/

using System.Text.RegularExpressions;

namespace Yagl.GL.Generator.Utilities
{
    public static class Text
    {
        public static string RemoveDuplicatedWhitespaces(this string str)
        {
            return str != null ? Regex.Replace(str, @"\s{2,}", " ") : null;
        }
    }
}