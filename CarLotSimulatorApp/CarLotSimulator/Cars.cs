using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public Car()
        {

        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }
        public void MakeEngineNoise(string sound)
        {
            Console.WriteLine($"Engine makes a {sound} noise.");
        }
        public void MakeHornNoise(string sound)
        {
            Console.WriteLine($"Horn goes {sound}.");
        }
    }
}
