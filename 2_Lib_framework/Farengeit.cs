using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lib_framework
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
