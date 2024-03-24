namespace Task_14._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Cat("Василий");
            Animal dog = new Dog("Шарик");
            
            cat.ShowInfo();
            dog.ShowInfo();
        }
    }
}