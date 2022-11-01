using System;

namespace Labb_2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog D1 = new Dog();
            D1.PrintDogInfo();
            Dog D2 = new Dog("Lukas",5,"Male",true,true);
            D2.PrintInfo();
            Console.WriteLine("Press enter to make sound");
            D2.makeSound();
            Console.WriteLine("--------&&-------");

            Dog2 D3 = new Dog2();
            D3.PrintDog2Info();
            Dog D4 = new Dog("Thomas", 10, "Male", false, false);
            D4.PrintInfo();
            Console.WriteLine("Press enter to make sound");
            D4.makeSound();

            Console.WriteLine("--------&&-------");

            Cat C1 = new Cat();
            C1.PrintCatInfo();
            Cat C = new Cat("Thomas", 7, "Male", false, true);
            C.PrintInfo();
            Console.WriteLine("Press enter to make sound");
            C.makeSound();



            //// Skapa nya djur med inmatadevärde
            //Animal S = new Animal("Dog","Shiba inu", 35, 2005);
            //S.PrintInfo();
            //Console.WriteLine("----------&&------------");

            //Console.WriteLine("Vad är det för typ av djur ?");
            //string AType = Console.ReadLine();

            //Console.WriteLine("Vad är det för ras ?");
            //string Race = Console.ReadLine();

            //Console.WriteLine("Hur lång är den ?");
            //float Height = float.Parse(Console.ReadLine());

            //Console.WriteLine("När va den född");
            //int Birth = int.Parse(Console.ReadLine());

            //Animal N = new Animal(AType, Race, Height, Birth);


        }
    }
}
