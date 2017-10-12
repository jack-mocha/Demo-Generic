using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            var largerInt = utilities.Max<int>(5, 3);

            GenericUtilities<int> genericUtilities = new GenericUtilities<int>();
            var gLargerInt = genericUtilities.Max(5, 3);

            GenericDictionary<int, Book> genericDictionary = new GenericDictionary<int, Book>();
            genericDictionary.CreatePair(1, new Book { Isbn = "ISO123121" });

            var number1 = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + number1.HasValue);
            Console.WriteLine("Value: " + number1.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value? " + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());
        }


    }


}
