using System;
using System.Collections.Generic;
using System.Text;

namespace DLLfile
{
    public class Converting
    {
        public double ConvertToGrams(double ounces)
        {
            double grams = ounces * 28.34952;
            return grams;
        }

        public double ConvertToOunces(double grams)
        {
            double ounces = grams / 28.34952;
            return ounces;
        }
    }
}
