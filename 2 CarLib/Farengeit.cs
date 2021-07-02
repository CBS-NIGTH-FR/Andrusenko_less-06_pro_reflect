using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CarLib
{
    class Farengeit
    {
        protected double tempFar;
        protected double tempC;
        public double TempFar
        {
            get { return tempFar; }
        }
        public double TempC
        {
            set { tempC = value; }
        }
        public double GetFarengeitTemp(double tempC)
        {
            return 1.8 * tempC + 32;
        }

    }
}
