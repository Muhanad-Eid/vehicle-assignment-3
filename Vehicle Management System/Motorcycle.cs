using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System
{
    public class Motorcycle: VehicleBase
    {
        public Motorcycle(string brand) : base(brand)
        {
        }

        public override void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }
    }
}
