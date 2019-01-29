using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCar
{
    public class FuelTank : IFuelTank
    {
        public double FillLevel => throw new NotImplementedException();

        public bool IsOnReserve => throw new NotImplementedException();

        public bool IsComplete => throw new NotImplementedException();

        public void Consume(double liters)
        {
            throw new NotImplementedException();
        }

        public void Refuel(double liters)
        {
            throw new NotImplementedException();
        }
    }
}
