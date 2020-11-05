using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car c");
            Car c = new Car(true);
            c.SteerLeft();

            Console.WriteLine("car car");
            Car car = new Car();
            car.Start();
            Console.WriteLine(car.IsOn);
            car.SteerLeft();
            car.SteerRight();
            //with private set it doesnt work
            //
            car.Stop();
            Console.WriteLine(car.IsOn);


            Console.WriteLine("MotorBike moto");
            MotorBike moto = new MotorBike();
            moto.Start();
            Console.WriteLine(moto.IsOn);
            moto.SteerLeft();

            Console.WriteLine("MotorBike moto2");
            MotorBike moto2 = new MotorBike(true);
            Console.WriteLine(moto2.IsOn);
            moto2.SteerLeft();
            moto2.Stop();
            Console.WriteLine(moto2.IsOn);
            

            Console.ReadLine();

        }
    }
}
