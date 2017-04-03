using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        
        public Employee () {}
        public Employee (string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }
        public string GetName()
        {
            return empName;
        }
        public void Setname(string name)
        {
            if (name.Length < 16)
                Console.WriteLine("Error name < 16!");
            else
                empName = name;
        }
    }
}
