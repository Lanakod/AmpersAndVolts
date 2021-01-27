using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmperAndVolts
{
    class AmperOmWatt
    {
        double amper, om;
        public AmperOmWatt(string a, string b) { amper = double.Parse(a); om = double.Parse(b); }
        public double getAmpers() { return amper; }
        public double getOm() { return om; }
        public double getWatts() { return Math.Round( Math.Pow(amper, 2) * om , 3); }
    }
}
