using System;

namespace Task_14._1
{
    public class Dog : Animal
    {
        public override string Name { get; set; }
        
        public Dog(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Гав!");
        }
    }
}