using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    internal class Mouse : Animal
    {
        public string _food = "Cheese";
        public string _mouse = "Mouse";
        public Mouse(string name, int age, string gender, bool hungry, string color, string food) : base(name, age, gender, hungry, color)
        {
            _food = food;
        }

        public string MakeSound()
        {
            Console.WriteLine("Tryck Enter för att lyssna på ljud");
            Console.ReadLine();
            return $"{_name} Säger González";
        }

        public void MouseVsCat()
        {

            Console.WriteLine("Mouse vs Cat:");
            Console.WriteLine("Tryck enter för att kasta tärning");
            Console.ReadLine();
            Random rnd = new Random();
            int num = rnd.Next(1,6);
            Console.WriteLine(num);
            if (num == 2 || num == 4 || num == 6)
            {
                Console.WriteLine("Musen Dödade Tom(Katten)");
            }
            else
            {
                Console.WriteLine("Musen dog :´(");
            }


        }


        public string PrintType()
        {
            return _mouse;
        }

    }
}
