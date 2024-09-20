using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("KKK! KKK!");
        }
        public override string Stats()
        {

            return "Worm has properties Name,weight,Age and IsPoisonous";
        }

    }
}
