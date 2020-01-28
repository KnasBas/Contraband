using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class ContrabandCar : Car
    {
       public ContrabandCar()
       {
            passengers = generetor.Next(1, 5); //detta ger ett slump värde mellan 1-4
       }
    }
}
