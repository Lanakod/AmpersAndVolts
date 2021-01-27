using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmperAndVolts
{
    class MassSpeedEnergy
    {
        double mass, speed;
        public MassSpeedEnergy(string a, string b) { mass = double.Parse(a); speed = double.Parse(b); }
        public double getMass() { return mass; }
        public double getSpeed() { return speed; }
        public double getEnergy() { return Math.Round( (Math.Pow(speed, 2) * mass) / 2, 3); }
    }
}
