using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal class Bulldog : Dog
    {
        int myTimeAttackPeople { get; set; }
        internal Bulldog(string name = "Spike", int age = 4, string sound = "WOF", string color = "Brindle", string species = "Dog", double biteForce = 305.0, int timeAttackPeople = 0) : base(name, age, sound, color, species, biteForce)
        {
            myTimeAttackPeople = timeAttackPeople;
        }

        internal void AttackPeople()
        {
            Console.WriteLine($"my {myAnimalName} attack {myTimeAttackPeople} people per day with a bite force of {myBiteForce}, because it is a {mySpecies}");
        }
    }
}
