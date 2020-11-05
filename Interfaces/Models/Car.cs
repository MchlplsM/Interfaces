using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Car : AutoMobile
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
        public void Break()
        {
            Console.WriteLine("The car is breaking");
        }
        public override void SteerLeft() // Have to use override for abstraction
        {
            Console.WriteLine("The car is steering left.");
        }
        public override void SteerRight()// Have to use override for abstraction
        {
            Console.WriteLine("The car is steering right.");
        }
        public override void Steer(bool steerLeft)
        {

        }
    }
}
