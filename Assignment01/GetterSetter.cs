using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    //Let's pretend its a Movie class
    internal class GetterSetter
    {
        public string title;
        public string director;
        //only inside of its class can access to private
        private string rating;

        //constructor
        public GetterSetter(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            //rating = aRating;
            //To call the setter Rating use this one
            Rating = aRating;
        }

        //Getter and Setter: to allow accessing it from another class
        /// <summary>
        /// getter and setter is not a function
        /// but property.
        /// so it doesnt have round braket. after its name()
        ///It makes class secured. good for invalidading
        /// </summary>
        public string Rating
        {
            //when rating is called this will be returned
            get { return rating; }
            //allow to set the rating
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}