namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Jas", 5, "Wof", "Black", "Dog", 50);
            Bulldog bulldog = new Bulldog("BullWolf", 6, "WOF", "BlackBrun", "Bulldog", 100, 5);
            Chihuahua chihuahua = new Chihuahua("pipChu", 3, "WOOOF", "Blonde", "Chihuahua", 10, 5);
            Rabbit rabbit = new Rabbit("Las", 2, "pip", "White", "Rabbit", 20);
            Turtle turtle = new Turtle("Turtle", 100, "shh", "Green", "Turtle", 3);


            dog.Eat();
            dog.makeSound();
            dog.Sleep();
            dog.Attack();

            Console.WriteLine("\n-----------------------------------\n");

            bulldog.Eat();
            bulldog.makeSound();
            bulldog.Sleep();
            bulldog.Attack();
            bulldog.AttackPeople();

            Console.WriteLine("\n-----------------------------------\n");

            chihuahua.Eat();
            chihuahua.makeSound();
            chihuahua.Sleep();
            chihuahua.Attack();
            chihuahua.Bark();

            Console.WriteLine("\n-----------------------------------\n");

            rabbit.Eat();
            rabbit.makeSound();
            rabbit.Sleep();
            rabbit.Jump();

            Console.WriteLine("\n-----------------------------------\n");

            turtle.Eat();
            turtle.makeSound();
            turtle.Sleep();
            turtle.Running();
        }
    }
}
