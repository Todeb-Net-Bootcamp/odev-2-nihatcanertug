using System;

namespace PatikaDev_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Instrument guitar = new Guitar();
            guitar.Brand = "Antonio Giuliani CL6";
            guitar.Description = "This is classic guitar";
            guitar.Price = 500;

            Instrument violin = new Violin();
            violin.Brand = "Ashton";
            violin.Description = "This is classic violin";
            violin.Price = 750;

            Musician musician = new Musician();
            musician.Name = "";
            musician.Surname = "";
            musician.Age = 26;

            Console.WriteLine($"Guitar : \n{guitar.Brand}\n{guitar.Description}{guitar.Price}");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Violin : \n{violin.Brand}\n{violin.Description}\n{violin.Price}");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Musician : \n{musician.Name}\n{musician.Surname}\n{musician.Age}\n{musician.Instruments}");


            Console.ReadKey();

        }
    }
}
