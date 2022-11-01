using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Labb_2_Arv
{
    internal class Dog : Animal
    {
        public string _Animal;
        public string _Race;
        public bool _Wild;
        

        // Defaultkontrukttor
        public Dog()
        {
            _Animal = "Dog";
            _Race = "Shiba inu";
            _Wild = true;
        }


       

        public Dog(string _name, int _age, string _gender, bool _grooming, bool _feed) : base(_name, _age, _gender, _grooming, _feed) // base är för att ta med ARV från Animal
        {
          
        }

        public void PrintDogInfo()
        {
            Console.WriteLine("Animal: {0}", _Animal);
            Console.WriteLine("Race: {0}", _Race);
            Console.WriteLine("Wild: {0}", _Wild);

        }



        public void makeSound()
        {
            string enter = Console.ReadLine();
            switch (enter)
            {
                case "":
                    Console.WriteLine("Hunden säger: Woff Woff");
                    break;
            }
        }
    }
}
