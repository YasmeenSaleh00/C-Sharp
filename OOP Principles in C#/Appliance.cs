using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public abstract class Appliance
    {
        public string BrandName { get; set; }
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
