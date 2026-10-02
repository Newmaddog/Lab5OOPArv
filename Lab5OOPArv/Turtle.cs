using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal class Turtle : Animal
    {
        double mySpeed { get; set; }


        internal Turtle(string name = "Turtle", int age = 10, string sound = "Hiss", string color = "Green", string species = "Turtle", double speed = 0.2) : base(name, age, sound, color, species)
        {
            mySpeed = speed;
        }

        internal void Running()
        {
            Console.WriteLine($"my {mySpecies} is runnin {mySpeed} M per sec because it's name is {myAnimalName}");
        }
    }
}
