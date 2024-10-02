using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerators
{
    public class Box
    {
        //operator overloading
        /*Operator overloading in C# allows you to redefine or "overload" the behavior of operators (such as +, -, *, /, ==, etc.) for user-defined types like classes or structs. By overloading an operator, you enable custom behavior when the operator is used with instances of your type, making them work similarly to built-in types (e.g., integers, floats, etc.)
        */


        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }

        public Box() : this(1, 1, 1) { }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box() { 
            Length = box1.Length + box2.Length,
            Width = box1.Width + box2.Width,
            Breadth = box1.Breadth + box2.Breadth
            };

            return box;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };

            return box;
        }


        public static bool operator ==(Box box1, Box box2)
        {
            if (box1.Length == box2.Length && box1.Width == box2.Width && box1.Breadth == box2.Breadth)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
         // == requires != also be there
        public static bool operator !=(Box box1, Box box2)
        {
            if (box1.Length != box2.Length && box1.Width != box2.Width && box1.Breadth != box2.Breadth)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //to convert datatype or wise versa

        public static explicit operator int(Box box) { 
            return (int)(box.Length + box.Width +  box.Breadth);
        }

        public static implicit operator Box(int i)
        {
            return new Box(i,i,i);
        }
    }
}
