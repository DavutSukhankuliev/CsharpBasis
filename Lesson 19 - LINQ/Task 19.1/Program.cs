using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Task_19._1
{
    /* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,
     частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, 
     стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. 
     Создать список, содержащий 6-10 записей с различным набором значений характеристик.

    Определить:

    - все компьютеры с указанным процессором. Название процессора запросить у пользователя;

    - все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

    - вывести весь список, отсортированный по увеличению стоимости;

    - вывести весь список, сгруппированный по типу процессора;

    - найти самый дорогой и самый бюджетный компьютер;

    - есть ли хотя бы один компьютер в количестве не менее 30 штук?*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<ComputerModel> computerModels = new List<ComputerModel>()
            {
                new ComputerModel(){Name = "Dell", CPUType = "Intel", CPUClock = 5, RAM = 32, Storage = 1024, GPUMemory = 8, Price = 300, Number = 5},
                new ComputerModel(){Name = "Acer", CPUType = "AMD", CPUClock = 5, RAM = 64, Storage = 2024, GPUMemory = 10, Price = 500, Number = 3},
                new ComputerModel(){Name = "HP", CPUType = "Intel", CPUClock = 3, RAM = 16, Storage = 512, GPUMemory = 2, Price = 100, Number = 20},
                new ComputerModel(){Name = "Asus", CPUType = "Intel", CPUClock = 5, RAM = 64, Storage = 2024, GPUMemory = 12, Price = 600, Number = 3},
                new ComputerModel(){Name = "MSI", CPUType = "AMD", CPUClock = 4, RAM = 16, Storage = 1024, GPUMemory = 4, Price = 200, Number = 10},
                new ComputerModel(){Name = "Apple", CPUType = "M1", CPUClock = 5, RAM = 64, Storage = 4096, GPUMemory = 24, Price = 1600, Number = 1},
            };

            Console.WriteLine("Введите марку процессора");
            var cpuName = Console.ReadLine();
            List<ComputerModel> computerModels1 = computerModels.Where(x => x.CPUType == cpuName).ToList();
            Print(computerModels1);
            
            Console.WriteLine("Введите объем ОЗУ");
            var ram = Convert.ToInt32(Console.ReadLine());
            List<ComputerModel> computerModels2 = computerModels.Where(x => x.RAM >= ram).ToList();
            Print(computerModels2);

            Console.WriteLine("Сортирвока по стоимости");
            List<ComputerModel> computerModels3 = computerModels.OrderBy(x => x.Price).ToList();
            Print(computerModels3);

            Console.WriteLine("Группировка по CPU");
            IEnumerable<IGrouping<string, ComputerModel>> computerModels4 = computerModels.GroupBy(x => x.CPUType);
            foreach (var group in computerModels4)
            {
                Console.WriteLine(group.Key);
                foreach (var computerModel in group)
                {
                    Console.WriteLine($"Марка: {computerModel.Name}\t" +
                                      $"Процессор: {computerModel.CPUType}\t" +
                                      $"Частота: {computerModel.CPUClock} Ghz\t" +
                                      $"ОЗУ: {computerModel.RAM} GB\t" +
                                      $"Память: {computerModel.Storage} GB\t" +
                                      $"GPU: {computerModel.GPUMemory} GB\t" +
                                      $"Стоимость: {computerModel.Price}\t" +
                                      $"В наличии: {computerModel.Number}");
                }
            }
            
            Console.WriteLine("Самый дорогой и дешевый по стоимости");
            List<ComputerModel> computerModels5 = new List<ComputerModel>();
            computerModels5.Add(computerModels.OrderBy(x => x.Price).ToList().FirstOrDefault());
            computerModels5.Add(computerModels.OrderByDescending(x => x.Price).ToList().FirstOrDefault());
            Print(computerModels5);
            
            Console.WriteLine("есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computerModels.Any(x => x.Number >= 30 ));
            Console.ReadKey();
        }

        static void Print(List<ComputerModel> computerModels)
        {
            foreach (var computerModel in computerModels)
            {
                Console.WriteLine($"Марка: {computerModel.Name}\t" +
                                  $"Процессор: {computerModel.CPUType}\t" +
                                  $"Частота: {computerModel.CPUClock} Ghz\t" +
                                  $"ОЗУ: {computerModel.RAM} GB\t" +
                                  $"Память: {computerModel.Storage} GB\t" +
                                  $"GPU: {computerModel.GPUMemory} GB\t" +
                                  $"Стоимость: {computerModel.Price}\t" +
                                  $"В наличии: {computerModel.Number}");
            }
        }
    }

    internal class ComputerModel
    {
        public string Name { get; set; }
        public string CPUType { get; set; }
        public int CPUClock { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public int GPUMemory { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
    }
}