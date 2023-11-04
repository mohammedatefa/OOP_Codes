using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_seven_oop
{
    class Car : IVehicle, IDrivable
    {
        private int gasolineAmount;

        public Car(int startingGasolineAmount)
        {
            gasolineAmount = startingGasolineAmount;
        }

        public void Drive()
        {
            if (gasolineAmount > 0)
            {
                Console.WriteLine("The car is driving");
            }
        }

        public bool Refuel(int amountOfGasoline)
        {
            gasolineAmount += amountOfGasoline;
            return true;
        }

        void IDrivable.Move() { }

        void IDrivable.Accelerate() { }
       

        void IDrivable.Drive() { }
      ///////commit
    }


}
