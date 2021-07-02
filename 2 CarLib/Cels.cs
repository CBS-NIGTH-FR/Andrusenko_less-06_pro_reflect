using System;
using System.Collections.Generic;
using System.Text;

namespace _2_CarLib
{
    class Cels
    {
        protected double tempFar;
        protected double tempC;

        public double TempC
        {
            get { return tempC; }
        }
        public double TempFar
        {
            set { tempFar = value; }
        }
        public double GetCelsTemp(double tempFar)
        {
            return 0.55 * (tempFar - 32);
        }
    }
}
