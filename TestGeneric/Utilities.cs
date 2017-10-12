using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //This is a generic method in a non-generic class. This is perfectly fine.
        public T Max<T>(T a, T b) where T : IComparable  //Means T is IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
