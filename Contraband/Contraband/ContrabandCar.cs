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
            passengers = generator.Next(1, 5); //detta ger ett slump värde mellan 1-4
            switch (passengers) //chansen över hur många contraband man har med i bilen
            {
                case 1:
                    contrabandAmount = 1;
                    break;

                case 2:
                    contrabandAmount = generator.Next(1, 3); //1-2
                    break;

                case 3:
                    contrabandAmount = generator.Next(1, 4); //1-3
                    break;

                case 4:
                    contrabandAmount = generator.Next(1, 5); //1-4
                    break;
            }
        }
    }
}
