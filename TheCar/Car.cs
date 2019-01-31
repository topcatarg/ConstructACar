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

        private const double FuelConsumption = 0.0003;

        public Car()
        {
            SetupCar(20);
        }

        public Car(double fuelLevel)
        {
            SetupCar(fuelLevel);
        }

        private void SetupCar(double fuellevel)
        {
            engine = new Engine();
            fuelTank = new FuelTank(fuellevel);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
        }

        public bool EngineIsRunning => engine.IsRunning;

        public void EngineStart()
        {
            if (fuelTank.FillLevel > 0)
                engine.Start();
        }

        public void EngineStop()
        {
            engine.Stop();
        }

        public void Refuel(double liters)
        {
            if (liters < 0)
                return;
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            if (engine.IsRunning)
                fuelTank.Consume(FuelConsumption);
            if (fuelTank.FillLevel == 0)
                engine.Stop();
        }
    }

   

    

   
}
