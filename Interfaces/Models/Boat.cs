using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class Boat : AutoMobile
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
        public override void Reverse()
        {
            Console.WriteLine("The boat is reversing");
        }
        public override void Steer(bool steerLeft)
        {
            
        }

        public override void SteerLeft()
        {
            throw new NotImplementedException();
        }

        public override void SteerRight()
        {
            throw new NotImplementedException();
        }
    }
}
