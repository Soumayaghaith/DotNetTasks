﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }
}
