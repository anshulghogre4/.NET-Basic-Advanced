using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwelve
{
    internal class Animal
    {
      

        public string Name { get; set; }
        public string  Sound { get; set; }
        public string Owner { get; set; }
        public Animal(string name, string sound, string owner) { 
        Name = name;
        Sound = sound;
        Owner = owner;
        }
     
        public virtual void MakesSound()
        {
            Console.WriteLine($"{Name} says {Sound} and owned by {Owner}");
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }

    }
}
