using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Labb_2_Arv
{
    public class Animal
    {
  
        public readonly string _name;
        public readonly int _age;
        public readonly string _gender;
        public readonly bool _hungry = true;
        public readonly string _color;
        



        // Defaultcontructor
        public Animal() { }

        //Constructor 
        public Animal(string name, int age, string gender, bool hungry, string color)
        {
            
            this._name = name;
            this._age = age;
            this._gender = gender;
            this._hungry = hungry;
            this._color = color;
        }

        public string Run()
        {
            return $"{_name} Springer.";
        }

        public string Sleep()
        {
            if (_hungry == false)
            {
                return $"{_name} Sover gött";
            }
            else
            {
                return $"{_name} Kan inte sova för {_name} är hungrig";
            }
        
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {_name}");
            Console.WriteLine($"Ålder: {_age}");
            Console.WriteLine($"Kön: {_gender}");
            Console.WriteLine($"Hungrig: {_hungry}");
            Console.WriteLine($"Färg: {_color}");
        }

       



    }

}
