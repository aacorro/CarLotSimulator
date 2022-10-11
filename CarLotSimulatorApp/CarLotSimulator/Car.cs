using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
            public int Year { get; set; }
            public string Make { get; set; }    
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string Honknoise { get; set; }
            public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }




        public Car( int yearInput, 
                    string makeInput, 
                    string modelInput, 
                    string engineNoiseInput, 
                    string honkNoiseInput, 
                    bool isDriveableInput)
        {
            Year = yearInput;
            Make = makeInput;
            Model = modelInput;
            EngineNoise = engineNoiseInput;
            Honknoise = honkNoiseInput;
            IsDriveable = isDriveableInput;
        }   
         
        





    }
}
