using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //Let's pretend it's a chef class
    //It's a super class
    internal class Inheritance
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
        //virtual: this can be ovetwritten in any subclasses
        public virtual void MackSpecialDish()
        {
            Console.WriteLine("The Chef makes todays dish");
        }
    }
   
}
