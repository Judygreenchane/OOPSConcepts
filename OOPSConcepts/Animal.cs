
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    // 3.3 Question 14
    //If all animals need a new attribute then we will put the attribute in Animal class. So Animal class contain all the 
    //properties common to all animals ( subclass that inherit from  animal)
    internal abstract class Animal                          //3.3  Question 1
    {
        public string Name { get; set; } = string.Empty;    //3.3  Question 2
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();                     //3.3  Question 3

        public virtual string Stats()                      // 3.3 Question 1
        {
            return "From Animal class";
        }
       
        public Animal()                                    // 3.3 Question 4
        {

        }
    }

     

}
