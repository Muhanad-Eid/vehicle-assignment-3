using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System
{
    public abstract class VehicleBase : IVehicle
    {
        public VehicleBase(string brand) { 
            this.Brand = brand;
        }
        public virtual double CalculateFuelConsumption(double distance)
        {
            return distance*10;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }


        public abstract void Stop();
        public  string Brand { get;set; }
        public void Log(string message) 
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }

    }
}
