﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passengers = generator.Next(1, 4); //detta ger ett slump värde mellan 1-3
            contrabandAmount = 0;
        }
    }
}
