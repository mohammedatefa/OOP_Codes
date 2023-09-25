using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_seven_oop
{
    internal interface IVehicle
    {
        void Drive();
        bool Refuel(int amountOfGasoline);
    }
}
