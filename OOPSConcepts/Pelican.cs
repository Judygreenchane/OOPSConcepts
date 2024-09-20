using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts                          // 3.3 Question 8
{
    internal class Pelican : Bird     // Here no  implentation of  the abstact method (DoSound() in Animal class) is needed since this Pelican class 
                                      // inherits direcly from Bird class and not directly from Animal class.
    {
        public int LengthOfBeak { get ; set; }    // 3.3 Question 9
    }
}
