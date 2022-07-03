using System;

namespace MathLib
{
    // https://graph.reshish.ru/
    public static class RespawnFunctions
    {
        // (abs(5*sin(0.2*x))+3*sqrt(x))
        public static double GrowingSinusoida(double x)
        {
            return Math.Abs(5 * Math.Sin(0.2 * x) + 3 * Math.Sqrt(x));
        }

        //x/20+frac(x/10)*3
        public static double LinearWaves(double x)
        {
            return x / 20 + (x % 10) * 3;
        }

        //sqrt(x)
        public static double Parabola(double x)
        {
            return Math.Sqrt(x);
        }

        //sqrt(x - ctg(x)^sin(x))
        public static double AlcoholicParabola(double x)
        {
            double y = Math.Sqrt(x - Math.Pow(1.0 / Math.Tan(x), Math.Sin(x)));
            return Double.IsNaN(y) ? 0 : y;
        }

        public static double Linear(double x)
        {
            return x / 10;
        }
    }
}
