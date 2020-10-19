using UnityEngine;

namespace Cofdream.ExpandFunction
{
    public static class ExpandFunction
    {
        #region String Expand
        public static string Format(this string str, string arg0)
        {
            return string.Format(str, arg0);
        }
        public static string Format(this string str, string arg0, string arg1)
        {
            return string.Format(str, arg0, arg1);
        }
        public static string Format(this string str, string arg0, string arg1, string arg2)
        {
            return string.Format(str, arg0, arg1, arg2);
        }
        public static string Format(this string str, params string[] args)
        {
            return string.Format(str, args);
        }
        #endregion
    }
}