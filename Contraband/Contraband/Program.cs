using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många bilar du vill checka (minst 1)");
            Car c1 = new Car();
            string answer = Console.ReadLine();
            int amount = 0;
            bool howMany = int.TryParse(answer, out amount);
            while(!howMany || amount <= 0)
            {
                Console.WriteLine("Ogiltigt svar!");
                answer = Console.ReadLine();
                howMany = int.TryParse(answer, out amount);
            }
            List<int> carlist = new List<int>();
            for (int i = 0; i > amount; i++)
            {
                carlist.Add(i);
            }
            Console.WriteLine("Vilken ska du titta på? [0-" + carlist.Count + "]");
            answer = Console.ReadLine();
            int car = 0;
            bool whichCar = int.TryParse(answer, out car);
            while (!whichCar || car > amount && car < amount)
            {
                Console.WriteLine("Ogiltigt svar!");
                answer = Console.ReadLine();
                whichCar = int.TryParse(answer, out car);
            }

            c1.Examine(car);



           

        }
    }
}
