using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Labb_2_Arv
{
    internal class Dog : Animal
    {
        protected int _legs = 4;
        protected string _dog = "Dog";

        // Defaultkontrukttor
        public Dog()
        {
            
        }

        public Dog(string name, int age, string gender, bool hungry, string color, int legs) : base(name, age, gender, hungry, color) // base är för att ta med ARV från Animal
        {
            _legs = legs;
            
        }

        public string MakeSound()
        {
            Console.WriteLine("Tryck Enter för att lyssna på ljud");
            Console.ReadLine();
            return $"{_name} Säger Woff";
        }

        public virtual string Healthy()
        {
            if (_legs == 4)
                return $"{_name} är 100% friskt";
            else
                return $"{_name} är inte 100% friskt";



        }

        public string PrintType()
        {
            return _dog;
        }


    }
}
