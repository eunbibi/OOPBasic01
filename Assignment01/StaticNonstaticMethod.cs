using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment01
{
    public class StaticNonstaticMethod
    {
        //this is a static method
        //can't be used with objects but access diretly without making an object

        int a = 1;
        const int ab = 2;
        static int abc = 3;

        public static void VariableTest()
        {
            //The only error among above three variables
            //-> because in a static method, you can only use static & const(once you define it, you can't change the value of this variable) variables
            //Console.WriteLine(a);

            Console.WriteLine(ab);
            Console.WriteLine(abc);
        }
        public static int calculation123(int x, int y)
        {
            int val = x * y;
            return val;
        }

        //this is a non-static(=instance method)
        public int calcul(int x, int y)
        {
            int val = x * y;
            return val;
        }
    }
}
