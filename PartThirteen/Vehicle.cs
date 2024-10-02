using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThirteen
{
    internal class Vehicle : IVehicle
    {
     

        public string BrandName { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brandName,int wheels, double speed)
        {
            BrandName = brandName;
            Wheels = wheels;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"the {BrandName} moves forward at {Speed}");
        }

        public void Stop()
        {
            Console.WriteLine($"the {BrandName} stop now");
            Speed = 0;

        }
    }
}
