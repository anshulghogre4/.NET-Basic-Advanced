using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PartTwelve
{
    internal class Cat :Animal
    {

        public string Sound2 { get; set; } = "Mewowwww!";
        public Cat(string name, string sound, string owner, string sound2) : base(name, sound, owner)
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
