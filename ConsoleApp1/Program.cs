using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Car myCar = new Car("2109", 0);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 12; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                if (e.Data != null)
                {
                    foreach (DictionaryEntry de in e.Data)
                    {
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                    }
                }
                Console.WriteLine("Error!");
                Console.WriteLine("Member Name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
