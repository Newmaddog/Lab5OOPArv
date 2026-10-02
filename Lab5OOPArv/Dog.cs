using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal class Dog : Animal
    {
        internal double myBiteForce { get; set; }
        //string myDogType { get; set; }

        internal Dog(string name = "Buddy", int age = 2, string sound = "wof", string color = "Brown", string species = "Dog", double biteForce = 250.0) : base(name, age, sound, color, species)
        {
            myBiteForce = biteForce;
        }

        internal void Attack()
        {
            Console.WriteLine($"my {myAnimalName} bite hard it's strenght is {myBiteForce}");
        }
    }
}
