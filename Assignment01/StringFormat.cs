using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class StringFormat
    {
        public string name = "Anna";
        public string today = DateTime.Today.ToString("dd/MM/yyyy");

        public void preferedStringFormat()
        {
            Console.WriteLine($"2. Hello {name}, today is {today}");
        }
        public void notPreferedStringFormat()
        {
            Console.WriteLine("3. Hello " + name + ", today is " + today);
        }
    }
}
