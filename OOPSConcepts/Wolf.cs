using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Wolf : Animal
    {
        public bool Crooked { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Woo! Woo!");
        }
        public override string Stats()
        {

            return "Wolf  has properties Name,weight,Age and Crooked";
        }
    }
}
