using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class TextInputError : UserError          // 3.2 Question 5

    {
        public override string UEMessage()              // 3.2 Question 6
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
