using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class StringLengthCaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {

            if (x == null && y == null) return 0;
            if (x is null) return -1;
            if (y is null) return 1;

            return x.ToLower().CompareTo(y.ToLower());
        }
    }
}
