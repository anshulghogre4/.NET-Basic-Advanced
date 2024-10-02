using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwelve
{
    internal class Dog:Animal
    {
     

        public string Sound2 { get; set; } ="Greeerrr!";
        public Dog(string name, string sound, string owner, string sound2) : base(name, sound, owner)
        {
            Sound2 = sound2;
        }
        public override void MakesSound()
        {
            // base.MakesSound();// this will call the base's class's virtual method

            Console.WriteLine($"{Name} say {Sound} and {Sound2}");
        }
    }
}

