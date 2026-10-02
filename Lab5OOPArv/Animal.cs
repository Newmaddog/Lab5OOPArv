using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal  class Animal
    {
        internal string myAnimalName {  get; set; } 
        internal int myAge { get; set; }
        internal string mySound { get; set; }
        internal string myColor { get; set; }
        internal string mySpecies { get; set; }

        internal Animal(string name = "Animal", int age = 5, string sound = "Sound", string color = "Nothing", string species = "Animal")
        {
            myAnimalName = name;
            myAge = age;
            mySound = sound;
            myColor = color;
            mySpecies = species;
        }

        internal void Eat()  
        {
            Console.WriteLine($"my {myAnimalName} is eating");
        }

        internal void makeSound()
        {
            Console.WriteLine($"my {myAnimalName} makes the {mySound} because it is a {mySpecies} animal");
        }

        internal void Sleep()
        {
            Console.WriteLine($"my {myAnimalName} is sleeping now!!!");
        }

    }
}
