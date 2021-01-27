using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmperAndVolts
{
    class VoltOmAmper
    {
        double volt, om;
        public VoltOmAmper(string a, string b) { volt = double.Parse(a); om = double.Parse(b); }
        public double getVolts() { return volt; }
        public double getOm() { return om; }
        public double getAmper() { return Math.Round(volt / om, 3); }
    }
}
