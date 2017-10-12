using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    //where T : IComparable //Interface
    //where T : Product     //Class
    //where T : struct      //Value Type
    //where T : class       //Reference Type
    //where T : new()       //Has default constructor
    public class GenericUtilities<T> where T : IComparable, new() //Means T is IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //This is a generic method in a non-generic class. This is perfectly fine.
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T(); //Can only do this when new() constraint is applied, because the compiler does not know what T is 
        }
    }
}
