using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    internal class BullDog : Dog
    {
        protected string _FSnack;
        protected string _Race = "BullDog";
        public BullDog()
        {

        }

        public BullDog(string name, int age, string gender, bool hungry, string color, int legs, string fsnack) : base(name, age, gender, hungry, color,legs) 
        {
            this._FSnack = fsnack;
        }

        public string FavSnack()
        {
            return $"{_name}s Favorit snack är {_FSnack}";
        }

        public void PrintRace()
        {
            Console.WriteLine(_Race);
        }
    }
}
