using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffe Kur");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummycoffe = new CoffeMechine(coffe, water);

      
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            String result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

 
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);


            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

   
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);


            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("Check " + yummycoffe.checkAvailability());
        }
    }
}
