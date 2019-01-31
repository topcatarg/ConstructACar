using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCar
{
    public class FuelTankDisplay : IFuelTankDisplay
    {
        public double FillLevel => fuelTank.FillLevel;

        public bool IsOnReserve => fuelTank.IsOnReserve;

        public bool IsComplete => fuelTank.IsComplete;

        private IFuelTank fuelTank;

        public FuelTankDisplay(IFuelTank fuelTank)
        {
            this.fuelTank = fuelTank;
        }

    }
}
