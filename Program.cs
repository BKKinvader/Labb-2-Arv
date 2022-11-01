using System;

namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog Lukas = new Dog("Lukas",5,"Male",true,"Brown",4);
            Console.WriteLine(Lukas.PrintType());
            Lukas.PrintInfo();
            Console.WriteLine(Lukas.Healthy());
            Console.WriteLine(Lukas.Run());
            Console.WriteLine(Lukas.Sleep());
            Console.WriteLine(Lukas.MakeSound());
            Console.WriteLine("--------&&-------");

            Shiba_inu Tim = new Shiba_inu("Tim", 10, "Male", false, "White", 2, 40);
            Console.WriteLine(Tim.PrintType());
            Tim.PrintInfo();
            Console.WriteLine(Tim.Healthy());
            Console.WriteLine(Tim.Sleep());
            Console.WriteLine(Tim.MakeSound());
            Console.WriteLine("--------&&-------");

            BullDog Viktor = new BullDog("Viktor", 10, "Male", false, "White", 2);
            BullDog ViktorS = new BullDog("Bacon");
            Console.WriteLine(Viktor.PrintType());
            Viktor.PrintInfo();
            Console.WriteLine(Viktor.Healthy());
            Console.WriteLine(Viktor.Sleep());
            Console.WriteLine("Viktors favorit snack: " + ViktorS.FavSnack());
            Console.WriteLine(Viktor.MakeSound());
            Console.WriteLine("--------&&-------");




            Cat Misse = new Cat("Misse", 3, "Female", true, "Blue", 2);
            Console.WriteLine(Misse.PrintType());
            Misse.PrintInfo();
            Console.WriteLine(Misse.Healthy());
            Console.WriteLine(Misse.MakeSound());


            Console.WriteLine("--------&&-------");







        }
    }
}
