using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2_Arv
{
    internal class Dog2 : Dog
    {

        public string _Race2;
        public Dog2()
        {
            _Animal = "Dog";
            _Race2 = "BullDog";
            _Wild = false;
        }
        
        public void PrintDog2Info()
        {
            Console.WriteLine("Animal: {0}", _Animal);
            Console.WriteLine("Race: {0}", _Race2);
            Console.WriteLine("Wild: {0}", _Wild);

        }
    }
}
