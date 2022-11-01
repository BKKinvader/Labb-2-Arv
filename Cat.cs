using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Labb_2_Arv
{
    internal class Cat : Animal
    {
        
        protected string _cat = "Cat";
        protected int _ears = 2;

        // Defaultkontrukttor
        public Cat()
        {

        }

        public Cat(string name, int age, string gender, bool hungry, string color, int ears) : base(name, age, gender, hungry, color) // base är för att ta med ARV från Animal
        {
            _ears = ears;

        }

        public string MakeSound()
        {
            Console.WriteLine("Tryck Enter för att lyssna på ljud");
            Console.ReadLine();
            return $"{_name} Säger Meeeeeaaaaw";
        }

        public virtual string Healthy()
        {
            if (_ears == 2)
                return $"{_name} har 2 öron";
            else
                return $"{_name} har inte alla öron";



        }

        public string PrintType()
        {
            return _cat;
        }

        
    }
}
