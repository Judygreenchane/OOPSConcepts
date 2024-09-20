using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Horse :Animal
    {
        public bool IsFast { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh! Neigh!");
        }
        public override string Stats()
        {

            return "Horse has properties Name,weight,Age and IsFast";
        }

    }
}
