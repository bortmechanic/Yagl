// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable CollectionNeverQueried.Global

using System.Collections.Generic;
using System.Xml.Linq;
using Yagl.GL.Generator.Utilities;

namespace Yagl.GL.Generator.Spec
{
    public class Comments : List<string>
    {
        public void Parse(XElement element)
        {
            Log.Info("Description.");
            var comment = element?.Value;
            if (string.IsNullOrWhiteSpace(comment))
                Log.Error("  Comment is missing or empty.");
            else
                Log.Debug(comment);//.Substring(0, 200));
            Add(comment);
            Log.Info("DONE.");
            Log.Info();
        }
    }
}