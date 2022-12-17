using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //This is a static class
    //Let's pretend it works like a Person Class 
    public static class StaticNonstaticClass
    {
        //All of the members should be static
        //Static class can't be inherited
        //Static class can't be instantiated

        public static string Firstname;
        public static string Lastname;

        //error!
        ///static class can't have instance constructor
        /*static StaticNonstaticClass(string argFn, string argLn) 
        {
            Firstname= argFn;
            Lastname= argLn;
        }*/
        
        //This is a static constructor
        //static constructor should be parameterless
        static StaticNonstaticClass()
        {
            Firstname= "Anna";
            Lastname = "Seo";
        }

        public static string FormatFullname()
        {
            return $"{Firstname} - {Lastname}";
        }

        
    }
}
