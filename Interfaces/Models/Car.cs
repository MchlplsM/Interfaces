using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : AutoMobile, IAutoMobileActions, ICarActions
    {
        //Constructor
        public Car()
        {

        }

        public Car(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        //Method
        public void SteerLeft() // Have to use override for abstraction
        {
            Console.WriteLine("The car is steering left.");
            this.Bool_Steering = true;
            Console.WriteLine(this.Bool_Steering);
        }
        public void SteerRight()// Have to use override for abstraction
        {
            Console.WriteLine("The car is steering right.");
            this.Bool_Steering = false;
            Console.WriteLine(this.Bool_Steering);
        }
        public void Break()
        {
            Console.WriteLine("The car is breaking");
        }
        public void Reverse()
        {
            Console.WriteLine("The car is reversing");
        }

        //public void Steer(bool steerLeft)
        //{

        //}
    }
}
