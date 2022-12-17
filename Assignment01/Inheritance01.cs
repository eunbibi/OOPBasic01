using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //Let's pretent it's an Italian chef class
    //this Italian chef all can do as just regular chef

    //inherite all the functionality from parent class
    internal class Inheritance01: Inheritance
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        //method overriding
        public override void MackSpecialDish()
        {
            Console.WriteLine("The chef makes pizza");
        }
    }
   
}
