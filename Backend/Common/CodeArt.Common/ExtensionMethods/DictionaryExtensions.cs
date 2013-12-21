using System.Collections.Generic;

namespace CodeArt.Common.ExtensionMethods
{
    public static class DictionaryExtensions
    {
        public static void AddRange<TK, TV>(this Dictionary<TK, TV> source, Dictionary<TK, TV> collection)
        {
            foreach (var item in collection)
            {
                source.Add(item.Key, item.Value);
            }
        }
    }
}
