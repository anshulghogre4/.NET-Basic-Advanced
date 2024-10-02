using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwelve
{
    abstract class Shape
    {
        //abstract class can not be intanctiated
        //but we can define props and methods here which can be overriden
        public string Name { get; set; }
        public virtual void GetInfo() //non abstract method which can be override and not measn it's optional toovveride
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double area(); //here abstract method must be overriden and it does not contain any body
    }
}
