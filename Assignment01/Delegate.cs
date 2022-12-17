using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Delegate
    {
        /// <summary>
        /// Delegate:
        /// When you wanna make a variable to use function
        /// 
        /// A variable holdaing function
        /// </summary>
        
        //create a delegate type
        //define delegate return type, name(parameters);
        //should be all matched w FuncTest function
        delegate void MyDelegate();
        delegate int AddDelegate(int a, int b);

        //int GetAge_Kr()
        public delegate int CalculDelegate();

        //Constructor
        public Delegate()
        {
            MyDelegate myDel;
            myDel = FuncTest;

            //Error! can't call FuncTest1
            //parameter is different!
            //myDel = FuncTest1;

            //calling delegate
            myDel();
            //--------------------------------------

            //instance화
            //putting function to a delegate variable
            AddDelegate addDel = AddTest;
            AddTest(1, 4);

            ShowMenu(GetAge_Kr);
            ShowMenu(GetAge_International);
        }

        // a function
        public void FuncTest()
        {

        }
        public int AddTest(int a, int b)
        {
            return a + b;
        }


        /*Age calculation example(International age vs Korean age)*/

        //Menu will appear differntly based on their age
        public void ShowMenu(CalculDelegate GetAge)
        {
            int age = GetAge();

            if (age >= 20)
            {
                //showing liquir menu
            }
            else
            { 
                // non-adult menu
            }
        }

        private int GetAge_Kr()
        {
            //Bring DOB from DB
            //(Current date - DOB)+ 1;

            return 0;
        }
        private int GetAge_International()
        {
            //Bring DOB from DB
            //(Current date - DOB);

            return 0;
        }
    }
}
