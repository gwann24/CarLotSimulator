using System;
using Cars;
using Microsoft.VisualBasic;    

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            Car Car1 = new Car();
            Car1.Year = 2023;
            Car1.Make = "Telsa";
            Car1.Model = "Model 3";
            Car1.EngineNoise = "Whirring";
            Car1.HonkNoise = "Beep";
            Car1.IsDrivable = true;

            Console.WriteLine($"A {Car1.Year} {Car1.Make} {Car1.Model}:");
            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHornNoise(Car1.HonkNoise);
            Console.WriteLine("\n");

            Car Car2 = new Car() { Year = 1968, Make = "Chevy", Model = "Covette", EngineNoise = "Vroom", HonkNoise = "Honk", IsDrivable = true };
            Console.WriteLine($"A {Car2.Year} {Car2.Make} {Car2.Model}:");
            Car2.MakeEngineNoise(Car2.EngineNoise);
            Car2.MakeHornNoise(Car2.HonkNoise);
            Console.WriteLine("\n");

            Car Car3 = new Car(1969, "Dodge", "Charger", "Roaring", "Dixie", true);
            Console.WriteLine($"A {Car3.Year} {Car3.Make} {Car3.Model}:");
            Car3.MakeEngineNoise(Car3.EngineNoise);
            Car3.MakeHornNoise(Car3.HonkNoise);
            Console.WriteLine("\n");

            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
