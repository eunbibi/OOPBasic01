using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //Let's say its a book class 
    //special method, whenever we create obj,
    //it will be called
    internal class Constructor
    {
        public string title;
        public string author;
        public int pages;

        //if the name is same as class and public
        //then it means its constructor
        public Constructor()
        {
            Console.WriteLine("\nCreating Book");
        }
        public Constructor(string aTitle, string anAuthor, int aPage)
        {
            title = aTitle;
            author= anAuthor;
            pages = aPage;
        }
    }    
}
