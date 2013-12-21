using System;

namespace CodeArt.Common.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this Object source)
        {
            return source == null;
        }

        public static bool IsNotNull(this Object source)
        {
            return source != null;
        }
    }
}
