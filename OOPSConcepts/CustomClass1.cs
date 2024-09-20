using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class CustomClass1 : UserError             // 3.2 Question 9
    {
        public override string UEMessage()
        {
            return "Usererror message from custom class1";
        }
    }
}
