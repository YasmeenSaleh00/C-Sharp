using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{


    public class AirConditioner : Appliance

    {
        public override void TurnOff()
        {
            Console.WriteLine($"{BrandName} AC: Shutdown complete.");
        }



        public override void TurnOn()
        {
            Console.WriteLine($"{BrandName} AC: Cooling mode activated.");
        }
    }
}
