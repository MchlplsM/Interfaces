using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class MotorBike : AutoMobile
    {
        public MotorBike()
        {

        }

        public MotorBike(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        //Method
        public void Break()
        {
            Console.WriteLine("The motorbike is breaking");
        }
        public override void SteerLeft()// Have to use override for abstraction
        {
            Console.WriteLine("The motorbike is steering left.");
        }
        public override void SteerRight()// Have to use override for abstraction
        {
            Console.WriteLine("The motorbike is steering right.");
        }
        public override void Steer(bool steerLeft)
        {

        }
    }
}
