using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //x Create a seperate class file called Car
            //x Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //x Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

            //x The methods should take one string parameter: the respective noise property


            //x Now that the Car class is created we can instanciate 3 new cars
            //x Set the properties for each of the cars

            //x Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.


            var lot = new CarLot();


            Car toyota = new Car();
            toyota.Year = 2010;
            toyota.Make = "Toyota";
            toyota.Model = "Tacome";
            toyota.EngineNoise = "vroom";
            toyota.Honknoise = "peett";
            toyota.IsDriveable = true;

            lot.Cars.Add(toyota);


            Car honda = new Car()
            {
                Year = 2011,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "brmmp",
                Honknoise = "beep",
                IsDriveable = true
            };

            lot.Cars.Add(honda);


            Car ford = new Car(2012, "Ford", "Fusion", "prumm", "beett", false);
            lot.Cars.Add(ford);


            //x Call each of the methods for each car

            toyota.MakeEngineNoise(toyota.EngineNoise);
            honda.MakeEngineNoise(honda.EngineNoise);
            ford.MakeEngineNoise(ford.EngineNoise);



            //*************BONUS*************//

            //x Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //x Create a CarLot class
            //x It should have at least one property: a List of cars
            //x At the end iterate through the list printing each of car's Year, Make, and Model to the console



            Console.WriteLine($"Number of cars in inventory: {CarLot.numberOfCars}");
     
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }



            
        }
    }
}
