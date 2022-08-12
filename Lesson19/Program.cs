using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=123,Name="Dell",TypeOfCPU="x64", AmountOfRAM=1, HardDiskCapasity=100,VideoCardMemory=1,Price=30000, Quantity=10},
                new Computer(){Code=234,Name="HP",TypeOfCPU="x86", AmountOfRAM=2, HardDiskCapasity=800,VideoCardMemory=2,Price=45000, Quantity=30},
                new Computer(){Code=456,Name="Asus",TypeOfCPU="x86", AmountOfRAM=4, HardDiskCapasity=300,VideoCardMemory=3,Price=40000, Quantity=44},
                new Computer(){Code=765,Name="Samsung",TypeOfCPU="x86", AmountOfRAM=6, HardDiskCapasity=400,VideoCardMemory=4,Price=42000, Quantity=3},
                new Computer(){Code=652,Name="Sony",TypeOfCPU="x86", AmountOfRAM=8, HardDiskCapasity=120,VideoCardMemory=5,Price=25000, Quantity=67},
                new Computer(){Code=498,Name="Samsung",TypeOfCPU="x86", AmountOfRAM=12, HardDiskCapasity=140,VideoCardMemory=6,Price=23000, Quantity=1},
                new Computer(){Code=982,Name="HP",TypeOfCPU="x86", AmountOfRAM=24, HardDiskCapasity=156,VideoCardMemory=3,Price=24000, Quantity=7},
                new Computer(){Code=392,Name="Dell",TypeOfCPU="x64", AmountOfRAM=36, HardDiskCapasity=150,VideoCardMemory=6,Price=22000, Quantity=32},
                new Computer(){Code=941,Name="Dell",TypeOfCPU="x86", AmountOfRAM=16, HardDiskCapasity=400,VideoCardMemory=2,Price=41000, Quantity=2}
            };
            Console.WriteLine("Введите тип процессора");
            string typeOfCPU = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.TypeOfCPU == typeOfCPU).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем ОЗУ");
            byte amountOfRAM = Convert.ToByte(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.AmountOfRAM >= amountOfRAM).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.TypeOfCPU);
            foreach (IGrouping<string, Computer> g in computers4)
            {
                Console.WriteLine(g.Key);
                foreach (Computer c in g)
                {
                    Console.WriteLine($"{c.Name} {c.TypeOfCPU} {c.AmountOfRAM} {c.HardDiskCapasity} {c.VideoCardMemory} {c.Price} {c.Quantity}");
                }
            }

            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Name} {computer5.TypeOfCPU} {computer5.AmountOfRAM} {computer5.HardDiskCapasity} {computer5.VideoCardMemory} {computer5.Price} {computer5.Quantity}");
            Computer computer6 = computers.OrderByDescending(x => x.Price).LastOrDefault();
            Console.WriteLine($"{computer6.Name} {computer6.TypeOfCPU} {computer6.AmountOfRAM} {computer6.HardDiskCapasity} {computer6.VideoCardMemory} {computer6.Price} {computer6.Quantity}");
            Console.WriteLine(computers.Any(x => x.Quantity >= 30));

            Console.ReadKey();
        }
        static void Print (List<Computer> computers)
        {
            foreach(Computer c in computers)
            {
                Console.WriteLine($"{c.Name} {c.TypeOfCPU} {c.AmountOfRAM} {c.HardDiskCapasity} {c.VideoCardMemory} {c.Price} {c.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
