using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Labb_2_Arv
{
    public class Animal
    {
  
        public readonly string _Name;
        public readonly int _Age;
        public readonly string _Gender;
        public readonly bool _Grooming = true;
        public readonly bool _Feed;
        



        // Defaultkontrukttor
        public Animal() { }

        //Kontrukltor med inmatade värden
        public Animal(string _name, int _age, string _gender, bool _grooming, bool _feed)
        {
            
            this._Name = _name;
            this._Age = _age;
            this._Gender = _gender;
            this._Grooming = _grooming;
            this._Feed = _feed;
        }

        public void PrintInfo()
        {
            
            Console.WriteLine("Name: " + _Name);
            Console.WriteLine("Age: " + _Age);
            Console.WriteLine("Gender: " + _Gender);
            Console.WriteLine("Need Grooming: " + _Grooming);
            Console.WriteLine("Is Hungry: " + _Feed);
            

        }



    }

}
