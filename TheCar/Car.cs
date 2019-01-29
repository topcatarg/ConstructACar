using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCar
{
    public class Car : ICar
    {
        public IFuelTankDisplay fuelTankDisplay;

        private IEngine engine;

        private IFuelTank fuelTank;

        public Car()
        {

        }

        public Car(double fuelLevel)
        {

        }

        public bool EngineIsRunning => throw new NotImplementedException();

        public void EngineStart()
        {
            throw new NotImplementedException();
        }

        public void EngineStop()
        {
            throw new NotImplementedException();
        }

        public void Refuel(double liters)
        {
            throw new NotImplementedException();
        }

        public void RunningIdle()
        {
            throw new NotImplementedException();
        }
    }

   

    

   
}
