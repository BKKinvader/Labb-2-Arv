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
        protected int _dogattack = 20;
        // Defaultkontrukttor
        public Dog()
        {
            
        }

        public Dog(string name, int age, string gender, bool hungry, string color, int legs) : base(name, age, gender, hungry, color) // base är för att ta med ARV från Animal
        {
            this._legs = legs;
            
        }

        public string MakeSound()
        {
            Console.WriteLine("Tryck Enter för att lyssna på {0}",_name);
            Console.ReadLine();
            return $"{_name} Säger Woff";
        }

        public virtual string Healthy()
        {
            if (_legs == 4)
                return $"{_name} har 4 ben och är 100% friskt";
            else
                return $"{_name} fattas några ben och är inte 100% friskt";



        }
        public void DogAttack()
        {
            int CatHP = 99;
            int HP = 0;


            
            bool failsafe = true;
            do
            {
                Console.WriteLine("Vill du attackera en katt eller skippa genom att trycka på enter?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "JA")
                {
                    Console.WriteLine("Skriv din damage mellan 1 - 100"); 
                    int damage = int.Parse(Console.ReadLine());
                    HP = CatHP - damage;
                    failsafe = false;
                    Console.Clear();

                }
                else
                {
                    failsafe = false;
                    Console.Clear();
                }
            }
            while (failsafe);

            if (HP < 0)
                {
                    Console.WriteLine("Katten är död");
                    
                }
                else
                {
                    Console.WriteLine("Katten lever");
                }

           

        }

        public string PrintAnimal()
        {
            return _dog;
        }


    }
}
