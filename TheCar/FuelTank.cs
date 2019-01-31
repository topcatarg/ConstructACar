using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCar
{
    public class FuelTank : IFuelTank
    {
        public double FillLevel => Math.Round(Gas,2);

        public bool IsOnReserve => Gas < 5;

        public bool IsComplete => Gas == MaxTank;

        private readonly double MaxTank = 60;

        private double Gas { get; set; }

        public FuelTank(double liters)
        {
            if (liters < 0)
            {
                Gas = 0;
            }
            else if (liters > MaxTank)
            {
                Gas = MaxTank;
            }
            else
            {
                Gas = liters;
            }
        }

        public void Consume(double liters)
        {
            if (Gas - liters < 0)
            {
                Gas = 0;
            }
            else
            {
                Gas -= liters;
            }
        }

        public void Refuel(double liters)
        {
            if (liters < 0)
                return;
            if (liters + Gas > MaxTank)
            {
                Gas = MaxTank;
            }
            else
            {
                Gas += liters;
            }
        }
    }
}
