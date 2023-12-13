using System;
using System.Globalization;

namespace ANW
{
    class Helper
    {
        // L
        public static int getChromosomeLen()
        {
            return Convert.ToInt32(Math.Ceiling(Math.Log(((ANW.b - ANW.a) / ANW.d + 1.0), 2)));
        }

        //function value from x real
        public static double getFunctionValue(double x)
        {
            return x % 1.0 * (Math.Cos(20.0 * Math.PI * x) - Math.Sin(x));
        }

        public static int realToInt(double x)
        {
            double xint = ((1.0 / (ANW.b - ANW.a)) * (x - ANW.a) * (Math.Pow(2, ANW.l) - 1.0));
            return (int)Math.Round(xint);
        }

        public static string intToBin(int x)
        {
            return Convert.ToString(x, 2).PadLeft(ANW.l, '0');
        }
        public static double intToReal(int x)
        {
            return (((ANW.b - ANW.a) * x) / (Math.Pow(2, ANW.l) - 1.0)) + ANW.a;
        }

        public static int binToInt(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }

        public static double GetRandomDoubleNumber()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.NextDouble() * (ANW.b - ANW.a) + ANW.a;
        }
        public static double RoundNumberWithD(double x)
        {
            return Math.Round(x, ANW.d.ToString(new CultureInfo("es-ES")).Split(',')[1].Length);
        }

    }
}
