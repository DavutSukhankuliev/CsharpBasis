using System;

namespace Task_14._1
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"{this.GetType()} {Name}");
            Say();
        }
    }
}