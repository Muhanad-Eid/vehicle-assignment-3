using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Management_System
{
    internal interface IVehicle
    {
        void Start();
        void Stop();
        double CalculateFuelConsumption(double distance);    
    }
}
