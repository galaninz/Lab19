using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Id=1, Name="Dell", Processor = "Intel", Frequency = 3.2, RAM = 16, Storage = 500, VRAM = 4, Price = 15000, Quantity = 1},
                new Computer(){Id=2, Name="Lenovo", Processor = "AMD", Frequency = 3.6, RAM = 32, Storage = 1000, VRAM = 8, Price = 30000, Quantity = 2},
                new Computer(){Id=3, Name=String.Empty, Processor = "Baikal", Frequency = 1.2, RAM = 64, Storage = 240, VRAM = 24, Price = 150000, Quantity = 3},
                new Computer(){Id=4, Name="Dell", Processor = "AMD", Frequency = 4.0, RAM = 12, Storage = 500, VRAM = 6, Price = 25000, Quantity = 2},
                new Computer(){Id=5, Name="DEXP", Processor = "Intel", Frequency = 3.8, RAM = 16, Storage = 2000, VRAM = 12, Price = 45000, Quantity = 2},
                new Computer(){Id=6, Name="Dell", Processor = "Intel", Frequency = 3.2, RAM = 32, Storage = 1000, VRAM = 8, Price = 39000, Quantity = 1},
            };
            //Console.WriteLine("Введите наименование процессора");
            //string name = Console.ReadLine();
            //List<Computer> computers1 = computers.Where(x => x.Processor == name).ToList();
            //Print(computers1);

            //Console.WriteLine("Введите минимальный обьем ОЗУ");
            //int ram = Convert.ToInt32(Console.ReadLine());
            //List<Computer> computers2 = computers.Where(x => x.RAM >= ram).ToList();
            //Print(computers2);

            Console.WriteLine("Сортировка по цене");
            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            Console.WriteLine("Сортировка сгруппированная по производителю процессора");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Processor);
            foreach (IGrouping<string, Computer> group in computers4)
            {
                Console.WriteLine(group.Key);
                foreach (Computer c in group)
                {
                    Console.WriteLine($"{c.Id} {c.Name} {c.Processor} {c.Frequency} {c.RAM} {c.Storage} {c.VRAM} {c.Price} {c.Quantity}\n");
                }
            }

            Console.WriteLine("Самый дешевый");
            Computer computers5 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computers5.Id} {computers5.Name} {computers5.Processor} {computers5.Frequency} {computers5.RAM} {computers5.Storage} {computers5.VRAM} {computers5.Price} {computers5.Quantity}\n");

            Console.WriteLine("Самый дорогой");
            Computer computers6 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computers6.Id} {computers6.Name} {computers6.Processor} {computers6.Frequency} {computers6.RAM} {computers6.Storage} {computers6.VRAM} {computers6.Price} {computers6.Quantity}\n");

            Console.WriteLine("Есть ли компьютер в количестве не менее 30 штук");
            Console.WriteLine(computers.Any(x => x.Quantity >= 30));

            Console.ReadKey();
        }

        static void Print(List<Computer> computers)
        {
            foreach(Computer c in computers)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Processor} {c.Frequency} {c.RAM} {c.Storage} {c.VRAM} {c.Price} {c.Quantity}\n");
            }
        }
    }
}
