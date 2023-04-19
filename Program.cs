using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            // makes a car object
            car.Make = "Ford";
            // Make of car
            car.Model = "Mustang";
            // Model of car 
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");
            //print out the type car 
            
            Car car2 = new Car();
            // makes a car object
            car2.Make = "Nisson";
            // Model of car 
            car2.Model = "SkyLine";
            // Model of car 
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");
            // print out the type of car 
            

        }
    }
}
