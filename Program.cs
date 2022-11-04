using System;

namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog Lukas = new Dog("Lukas",5,"Male",true,"Brown",4);
            Console.WriteLine(Lukas.PrintAnimal());
            Lukas.PrintInfo();
            Console.WriteLine(Lukas.Healthy());
            Console.WriteLine(Lukas.Run());
            Console.WriteLine(Lukas.Sleep());
            Console.WriteLine(Lukas.MakeSound());
            Lukas.DogAttack();
            Console.WriteLine("--------&&-------");

            Shiba_inu Tim = new Shiba_inu("Tim", 10, "Male", false, "White", 2, 40);
            Console.WriteLine(Tim.PrintAnimal());
            Tim.PrintRace();
            Tim.PrintInfo();
            Console.WriteLine(Tim.Healthy());
            Console.WriteLine(Tim.Sleep());
            Console.WriteLine(Tim.MakeSound());
            Console.WriteLine("--------&&-------");

            BullDog Viktor = new BullDog("Viktor", 10, "Male", false, "White", 2, "Bacon");
            Console.WriteLine(Viktor.PrintAnimal());
            Viktor.PrintRace();
            Viktor.PrintInfo();
            Console.WriteLine(Viktor.Healthy());
            Console.WriteLine(Viktor.Sleep());
            Console.WriteLine(Viktor.FavSnack());
            Console.WriteLine(Viktor.MakeSound());
            Console.WriteLine("--------&&-------");


            Cat Misse = new Cat("Misse", 3, "Female", true, "Blue", 2);
            Console.WriteLine(Misse.PrintType());
            Misse.PrintInfo();
            Console.WriteLine(Misse.Healthy());
            Console.WriteLine(Misse.MakeSound());


            Console.WriteLine("--------&&-------");

            Mouse musen = new Mouse("Jerry", 3, "Male", true, "brown", "Cheese");
            Console.WriteLine(musen.PrintType());
            musen.PrintInfo();
            musen.MouseVsCat();
            Console.WriteLine(musen.MakeSound());






        }
    }
}
