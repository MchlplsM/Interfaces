using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class AutoMobile 
    {
        // filed - ALWAYS private
        private bool _isOn;
        private bool _bool_steering;
        //private string _name;


        // property - ALWAYS public except
        // set cause we have a method for this.
        public bool IsOn
        {
            get { return _isOn; }
            private protected set { _isOn = value; } // για να δωσω access σε inheritance θα βαλω private protected
        }

        public bool Bool_Steering
        {
            get { return _bool_steering; }
            protected internal set { _bool_steering = value; }
        }
        //public string Name
        //{
        //    get { return _name; }
        //    private protected set { _name = value; }
        //}

        //---------Constructor
        public AutoMobile()
        {

        }
        public AutoMobile(bool IsOn)
        {
            this._isOn = IsOn;
        }

        //---------Method
        public void Start()
        {
            this._isOn = true;
        }

        //with privare set, it doesn't work
        //car.IsOn = false;

        public void Stop()
        {
            this._isOn = false;
        }

        //No need for these as you can find them on Interface
        //abstract public void SteerLeft();
        //abstract public void SteerRight();
        //abstract public void Steer(bool steerLeft);
        //abstract public void Reverse();
    }
}
