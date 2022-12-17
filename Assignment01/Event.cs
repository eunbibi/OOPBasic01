using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Event
    {
        //event 예제
        //delegate 선언
        public delegate void EventHandler(string msg);



        public event EventHandler SomethingHappend;
        public void DoSomething(int num)
        {
            int temp = num % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(String.Format("{0}: clap", num));
            }
        }
    }
}
