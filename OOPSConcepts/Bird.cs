using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Bird : Animal                    // 3.3 Question 5
    {
        // 3.3 Question 13
        //During the development if we come to a conclusion  that all birds need a new attribute, then we will
        // Place it in the Bird class.Then all the childclass inheriting from this Bird class(eg.Plikan,Flamingo,Swan) will get the new property.
        public float WingSpan {  get; set; }             // 3.3 Question 6

        public override void DoSound()                   // 3.3 Question 7
        {
            Console.WriteLine("Koo! Koo!");
        }
        public override string Stats()              //Question 2
        {

            return "Bird  has properties Name,weight,Age and WingSpan";
        }
    }
}
