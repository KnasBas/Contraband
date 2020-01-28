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
            Random generator = new Random();
            Car c1 = new Car();
            CleanCar cleanc1 = new CleanCar();
            ContrabandCar contrac1 = new ContrabandCar();
            string answer = Console.ReadLine();
            int amount = 0;
            bool howMany = int.TryParse(answer, out amount);
            while(!howMany || amount <= 0) //felsökning, ser till att spelaren måste ge ett giltigt svar
            {
                Console.WriteLine("Ogiltigt svar!");
                answer = Console.ReadLine();
                howMany = int.TryParse(answer, out amount);
            }
            List<int> carlist = new List<int>(amount);
            while (1 > 0)
            {
                Console.WriteLine("Vilken ska du titta på? [0-" + carlist.Count() + "]"); //får inte riktigt count att fungera tror jag skapar listans indexering på ett felaktigt sätt.
                answer = Console.ReadLine();
                int car = 0;
                bool whichCar = int.TryParse(answer, out car);
                while (!whichCar || car > amount && car < amount)
                {
                    Console.WriteLine("Ogiltigt svar!");
                    answer = Console.ReadLine();
                    whichCar = int.TryParse(answer, out car);
                }

                int possibility = generator.Next(1); // 50% chans generator

                if(possibility == 0) //checkar bilen via chans ifall den blir clean eller contraband. Men klassen kommer ihåg vilken bil du angett
                {
                    contrac1.Examine(car);
                }
                if(possibility == 1)
                {
                    cleanc1.Examine(car);
                }
                
            }                     
            Console.ReadLine();

            /*List<string> carlist = new List<string>(); //skapas en list för bilarna
            for (int i = 0; i > amount; i++)
            {
                int tempparameter = generator.Next(1);
                if (tempparameter == 0)
                {
                    carlist.Add("cleanc1"); //lägger till så många bilar för varje lista
                }
                else if (tempparameter == 1)
                {
                    carlist.Add("contrac1"); //lägger till så många bilar för varje lista
                }
            }*/


        }
    }
}
