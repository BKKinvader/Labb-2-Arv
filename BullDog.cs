using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    internal class BullDog : Dog
    {
        protected string _FSnack;

        public BullDog()
        {

        }

        public BullDog(string fsnack)
        {
            _FSnack = fsnack;
        }

        public BullDog(string name, int age, string gender, bool hungry, string color, int legs) : base(name, age, gender, hungry, color,legs) // base är för att ta med ARV från Animal
        {
            
        }

        public string FavSnack()
        {
            return _FSnack;
        }
    }
}
