using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Employee
    {
        public class BenefitPackage
        {
            public double ComputePayDeduction()
            {
                return 0.25;
            }
        }
        private BenefitPackage empBenefits = new BenefitPackage();
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
    }

    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager()
        {
        }
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
                        : base (fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock options: {0}", StockOptions);
        }
    }

    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
        public SalesPerson()
        {
        }
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) 
                            : base (fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
    }
}
