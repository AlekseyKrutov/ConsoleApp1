using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public partial class Employee
    {
        private string empName;
        private int empId;
        private float currPay;
        private int empAge;
        private readonly string SocialSecurityNumber;

        public Employee() {}
        public Employee(string name, int id, float pay) :this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            SocialSecurityNumber = ssn;
        }
        

        public string Name {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Erroe! Name must be less than 16 characters");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empId; }
            set { empId = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Age: {0}", Age);
        }
        public override string ToString()
        {
            string newFormat = string.Format("Name: {0}\nID: {1}\nPay: {2}\nAge: {3}\n", Name, ID, Pay, Age);
            return newFormat;
        }
    }
}
