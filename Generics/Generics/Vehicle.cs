using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Vehicle : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double QuarterMileTime { get; set; }

        private Random random;

        public Vehicle(string make, string model, double quartermiletime )
        {
            Make = make;
            Model = model;
            QuarterMileTime = quartermiletime;
            random = new Random();
        }

        public double getQuarterMileTimeWithRandom()
        {
            return QuarterMileTime + ( random.Next(400) / 100.0 );
        }

        public string getDescription()
        {
            return $"{Make} {Model}";
        }
    }
}
