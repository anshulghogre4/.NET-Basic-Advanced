using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal(string name = "no name")
        {
            Name = name;
        }
        //generics are defiend by a unknown letter "T"
        //where T represetns the unknown data type 
        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double db = Convert.ToDouble(num1);
            double db2 = Convert.ToDouble(num2);
            Console.WriteLine($"{db} + {db2} = {db + db2}");

        }

    }
}
