using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCar
{
    public class Engine : IEngine
    {
        public bool IsRunning => EngineState;

        private bool EngineState { get; set; } = false;

        public void Consume(double liters)
        {
            Console.WriteLine("consume engine");
        }

        public void Start()
        {
            EngineState = true;
        }

        public void Stop()
        {
            EngineState = false;
        }
    }
}
