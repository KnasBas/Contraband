using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        public int passengers;
        public int contrabandAmount = 0;
        public bool alreadyChecked = false;
        public static Random generator = new Random();
        private List<int> carlist = new List<int>();

        public bool Examine(int car)
        {            
            if (carlist.Contains(car)) // en list som checkar ifall bilen har blivit kollad förut
            {
                Console.WriteLine("Redan checkad");
            }
            else
            {
                carlist.Add(car);            

                int detected = 0;
                switch (contrabandAmount)
                {

                    case 0:
                        detected = 0;
                        break;

                    case 1:
                        detected = generator.Next(1, 5); //1-4 25% risk att bli upptäckt
                        break;

                    case 2:
                        detected = generator.Next(1, 4); // 33%
                        break;

                    case 3:
                        detected = generator.Next(1, 3); //50%
                        break;

                    case 4:
                        detected = 1;
                        break;

                }
                if (detected == 1) //en enekl check ifall bilen har contraband //risk baserat beroende på hur många passengers man hade
                {
                    Console.WriteLine("Bilen hade contraband");
                }
                else if (detected != 1)
                {
                    Console.WriteLine("Bilen har inga contraband");
                }

            }

            return alreadyChecked;
        }
    }
}
