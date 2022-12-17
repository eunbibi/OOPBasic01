using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class DataType
    {
        public static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        public static void ChangeReferenceType()
        {
            int[] array = { 1, 2 };
            int[] array2 = array;

            array2[1] = 3;

            Console.WriteLine($"array: {{{array[0]}, {array[1]}}}");
            Console.WriteLine($"array2: {{{array[0]}, {array[1]}}}");
        }
    }
}