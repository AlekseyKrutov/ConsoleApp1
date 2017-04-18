using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Car
        {
            public const int MaxSpeed = 100;
            public int CurrentSpeed { get; set; }
            public string PetName { get; set; }
            private bool CarrIsDead;
            private Radio TheMusicBox = new Radio();

            public Car()
            {
            }
            public Car(string name, int speed)
            {
                CurrentSpeed = speed;
                PetName = name;
            }
            public void CrankTunes(bool state)
            {
                TheMusicBox.TurnOn(state);
            }
            public void Accelerate(int delta)
            {
                if (CarrIsDead)
                    Console.WriteLine("{0} is out of order", PetName);
                else
                    CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    CarrIsDead = true;
                    Exception ex =  new Exception(string.Format("{0} had overheated!", PetName));
                    ex.HelpLink = "https://vk.com/krutov_aleksey";
                    ex.Data.Add("Time Stamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot!");
                    throw ex;
                }
                else
                    Console.WriteLine(">= currentspeed {0} ", CurrentSpeed);
            }
        }
        class Radio
        {
            public void TurnOn (bool on)
            {
                if (on)
                    Console.WriteLine("Jamming...");
                else
                    Console.WriteLine("Quiet time...");
            }
        }
}
