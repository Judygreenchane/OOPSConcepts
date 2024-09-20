using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class NumericInputError : UserError            // 3.2 Question 3
    {
        public override string UEMessage()                   // 3.2 Question 4
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
