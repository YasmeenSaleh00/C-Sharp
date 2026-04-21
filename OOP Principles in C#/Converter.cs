using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_in_C_
{
    public class Converter
    {
        public static double ConvertFormCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) +32;
        }
        public static double ConvertFormKilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }

    }
}
