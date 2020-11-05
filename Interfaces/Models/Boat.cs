using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile, IAutoMobileActions, IBoatActions
    {
        //Constructor
        public Boat()
        {

        }
        public Boat(bool IsOn)
        {
            this.IsOn = IsOn;
        }
        //Method
        public void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }

        public void SteerLeft()
        {
            Console.WriteLine("The boat is steering left.");
            this.Bool_Steering = true;
            Console.WriteLine(this.Bool_Steering);
        }

        public void SteerRight()
        {
            Console.WriteLine("The boat is steering right.");
            this.Bool_Steering = false;
            Console.WriteLine(this.Bool_Steering);
        }
        //public void Steer(bool steerLeft)
        //{
        //    
        //}
    }
}
