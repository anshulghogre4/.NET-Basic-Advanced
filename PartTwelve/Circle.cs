using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwelve
{
    internal class Circle : Shape
    {
        public double  Radius { get; set; }
        public Circle(double radius) //as you can see abstract classs cosntructor is not there
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has a radius of {Radius}");
        }
    }
}
