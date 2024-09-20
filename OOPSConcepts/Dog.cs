using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Dog : Animal
    {
        public bool  Clever {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override string Stats()              // //Question 2
        {

            return "Dog  has properties Name,weight,Age and Clever";
        }
        public string  OptionalMethod()    // Question 15
        {
            return "OptionalString";
        }
    }
}
