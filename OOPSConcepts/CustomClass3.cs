﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class CustomClass3 : UserError
    {
        public override string UEMessage()
        {
            return "Usererror message from custom class3";
        }
    }
}
