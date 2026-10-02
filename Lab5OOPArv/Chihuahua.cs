using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal class Chihuahua : Dog
    {
        internal int myTimeBarkADay { get; set; }
        internal Chihuahua(string name = "Tiny", int age = 1, string sound = "Wooof", string color = "Tan", string species = "Dog", double biteForce = 100.0, int timeBarkADay = 50) : base(name, age, sound, color, species, biteForce)
        {
            myTimeBarkADay = timeBarkADay;
        }

        internal void Bark()
        {
            Console.WriteLine($"my {myAnimalName} bark {myTimeBarkADay} a day, because it is a {mySpecies}");
        }
    }
}
