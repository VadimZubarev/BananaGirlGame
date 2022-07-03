using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Randomizer
    {
        private Random r = new Random();

        public double Noize(double x, double power = 0.1)
        {
            return x * (1 - power / 2 + r.NextDouble() * power);
        }
    }
}
