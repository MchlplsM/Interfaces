using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class MotorBike : AutoMobile, IAutoMobileActions, IMotorBikeActions
    {
        public MotorBike()
        {

        }

        public MotorBike(bool IsOn)
        {
            this.IsOn = IsOn;
        }

        //Method
        
        public void SteerLeft()// Have to use override for abstraction
        {
            Console.WriteLine("The motorbike is steering left.");
            this.Bool_Steering = true;
            Console.WriteLine(this.Bool_Steering);
        }
        public void SteerRight()// Have to use override for abstraction
        {
            Console.WriteLine("The motorbike is steering right.");
            this.Bool_Steering = false;
            Console.WriteLine(this.Bool_Steering);
        }
        public void Steer(bool steerLeft)
        {

        }
        public void Break()
        {
            Console.WriteLine("The motorbike is breaking");
        }
    }
}
