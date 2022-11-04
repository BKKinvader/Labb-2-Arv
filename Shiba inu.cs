using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    internal class Shiba_inu : Dog
    {

        protected int _teeth = 42;
        protected string _Race = "Shiba inu";

        public Shiba_inu()
        {
            
        }

        public Shiba_inu(string name, int age, string gender, bool hungry, string color, int legs, int teeth) : base(name, age, gender, hungry, color, legs) 
        {
            this._teeth = teeth;
        }

        public override string Healthy()
        {
            if (_teeth == 42 && _legs == 4)
                return $"{_name} är 100% friskt";
            else if (_teeth < 42 && _legs < 4)
                return $"{_name} fattas några tänder eller ben";
            else
                return $"{_name} är inte friskt";
        }
        public void PrintRace()
        {
            Console.WriteLine(_Race);
        }


    }
}
