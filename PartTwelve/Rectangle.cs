using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PartTwelve
{
    internal class Rectangle :Shape
    {
        public double Length { get; set; }
        public double  Width { get; set; }
        public Rectangle(double length, double width) //as you can see abstract classs cosntructor is not there
        {
            Name = "Circle";
            Length = length;
            Width = width;
        }

        public override double area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has a length of {Length} and width is of {Width}");
        }
    }
}
