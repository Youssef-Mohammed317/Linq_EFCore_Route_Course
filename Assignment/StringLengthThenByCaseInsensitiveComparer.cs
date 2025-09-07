using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class StringLengthThenByCaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            // handle null
            if (x is null && y is null) return 0;
            if (x is null) return -1;
            if (y is null) return 1;

            // length first
            if (x.Length > y.Length) return 1;
            if (x.Length < y.Length) return -1;
            // they are equal
            // handle alph
            //return string.Compare(x, y, StringComparison.OrdinalIgnoreCase); // built in class
            return string.Compare(x, y, ignoreCase: true); // case insensitive 
        }
    }
}
