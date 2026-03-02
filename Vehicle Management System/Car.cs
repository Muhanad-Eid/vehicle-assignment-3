using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System
{
    public class Car : VehicleBase
    {
        public Car(string brand) : base(brand)
        {
        }
        public override void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }
        public override double CalculateFuelConsumption(double distance)
        {
            distance = distance / 100;
            return distance;
        }
    }
}
