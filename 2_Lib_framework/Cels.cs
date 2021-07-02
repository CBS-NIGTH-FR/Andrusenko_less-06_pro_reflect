using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lib_framework
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
