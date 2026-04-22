using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public class WashingMachine : Appliance
    {
        public override void TurnOff()
        {
            Console.WriteLine($"{BrandName} Washing Machine: Stopping the wash cycle.");
        }

        public override void TurnOn()
        {
            Console.WriteLine($"{BrandName} Washing Machine: Starting a wash cycle...");
        }

    }

}
