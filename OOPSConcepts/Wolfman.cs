using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Wolfman : Wolf, IPerson              // 3.3 Question 11
    {
        public void Talk()                              // 3.3 Question 12
        {
            Console.WriteLine("I am a Wolf man");
        }
    }
}
