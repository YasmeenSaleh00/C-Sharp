using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public class VisitorCounter
    {
        public static int Count;
        
        public VisitorCounter()
        {
            Count++;
        }
    }
}
