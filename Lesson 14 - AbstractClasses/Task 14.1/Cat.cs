using System;

namespace Task_14._1
{
    public class Cat : Animal
    {
        public override string Name { get; set; }
        
        public Cat(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Мяу!");
        }
    }
}