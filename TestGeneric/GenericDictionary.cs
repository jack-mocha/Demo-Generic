using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class GenericDictionary<TKey, TValue> where TKey : IComparable, new() where TValue : new() // Multiple constraints. new() means it needs to have a default constructor, and has to be specified last
    {
        public void CreatePair(TKey key, TValue val)
        {
            var k = key;
            var v = val;
        }
    }
}
