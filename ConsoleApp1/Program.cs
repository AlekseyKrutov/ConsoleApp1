using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("Lesha", 1, 200);
            emp.GiveBonus(20);
            emp.DisplayStats();
            emp.Setname("StasikPedorasikBleati");
            emp.DisplayStats();

            Console.ReadLine();
        }
    }
}
