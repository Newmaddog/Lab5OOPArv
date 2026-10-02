using System;
using System.Collections.Generic;
using System.Text;

namespace OOPArv
{
    internal class Rabbit : Animal
    {
        double myJumpHeight { get; set; }
        internal Rabbit(string name = "Squick", int age = 1, string sound = "Squeak", string color = "White", string species = "Rabbit", double jumpHeight = 0.5) : base(name, age, sound, color, species) 
        {
            myJumpHeight = jumpHeight;
        
        }
       
        internal void Jump()
        {
            Console.WriteLine($"my {myAnimalName} is jump height is {myJumpHeight}");
        }
       
    }
}
