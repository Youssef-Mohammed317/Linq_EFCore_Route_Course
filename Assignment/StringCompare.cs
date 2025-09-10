using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class StringComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null) return false;
            //if(x.Length != y.Length) return false;
            //bool flag = false;
            //foreach (var c in x)
            //{
            //    flag = false;
            //    foreach (var b in y)
            //    {
            //        if (c == b)
            //        {
            //            flag = true;
            //        }
            //    }
            //    if (!flag)
            //        break;
            //}
            //return flag;
            return string.Concat(x.OrderBy(c => c)).ToLower() == string.Concat(y.OrderBy(c => c)).ToLower();
        }
        public int GetHashCode([DisallowNull] string obj)
        {
            if (obj == null) return 0;
            return string.Concat(obj.OrderBy(c => c)).GetHashCode();
        }
    }
}
