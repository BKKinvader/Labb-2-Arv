using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Labb_2_Arv
{
    internal class Cat : Animal
    {   
        public readonly string _Animal;  
        public readonly string _Race;
        



        public Cat()
        {
            _Animal = "Cat";
            _Race = "Ragdoll";
        }

        public Cat(string _name, int _age, string _gender, bool _grooming, bool _feed) : base(_name, _age, _gender, _grooming, _feed)
        {
            
        }

        public void PrintCatInfo()
        {
            Console.WriteLine("Animal: {0}", _Animal);
            Console.WriteLine("Race: {0}", _Race);
            

        }


        public void makeSound()
        {
            string enter = Console.ReadLine();
            switch (enter)
            {
                case "":
                    Console.WriteLine("Katten säger: Meaw Meaw");
                    break;
            }
        }



    }
}
