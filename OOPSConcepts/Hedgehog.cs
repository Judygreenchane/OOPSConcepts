using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Hedgehog :Animal
    {
        public int  NoOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("GGG! GGG!");
        }
        public override string Stats()
        {

            return "Hedgehog  has properties Name,weight,Age and NoOfSpikes";
        }
    }
}
