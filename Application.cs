using System;

namespace Dog_EAF
{
    class Application
    {
        static void Main(string[] args)
        {
            Dog Spot = new Dog();
            Console.WriteLine(Spot.ToString());
            Spot.SetName("Spot2");
            Spot.SetAge(2);
            Console.WriteLine(Spot.ToString());
            Spot.SetName("Spot");
            Console.WriteLine(Spot.GetName());

            Dog BoatDog = new Dog(4, "Chica");
            Console.WriteLine(BoatDog.ToString() + "\nChica is " + BoatDog.CalcDogYears() + " in dog years.");

            Console.WriteLine("\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
