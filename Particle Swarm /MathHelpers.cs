using System;
using System.Globalization;

namespace Particle_Swarm
{
    class MathHelpers
    {

        public static int getChromosomeLen()
        {
            return Convert.ToInt32(Math.Ceiling(Math.Log(((PSO.b - PSO.a) / PSO.d + 1.0), 2)));
        }

        public static double getFunctionValue(double x)
        {
            return x % 1.0 * (Math.Cos(20.0 * Math.PI * x) - Math.Sin(x));
        }

        /*public static int realToInt(double x)
        {
            double xint = ((1.0 / (PSO.b - PSO.a)) * (x - PSO.a) * (Math.Pow(2, PSO.l) - 1.0));
            return (int)Math.Round(xint);
        }

        public static string intToBin(int x)
        {
            return Convert.ToString(x, 2).PadLeft(PSO.l, '0');
        }
        public static double intToReal(int x)
        {
            return (((PSO.b - PSO.a) * x) / (Math.Pow(2, PSO.l) - 1.0)) + PSO.a;
        }

        public static int binToInt(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }
        */
        public static double GetRandomDoubleNumber()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.NextDouble() * (PSO.b - PSO.a) + PSO.a;
        }

        public static double RoundNumberWithD(double x)
        {
            return Math.Round(x, PSO.d.ToString(new CultureInfo("es-ES")).Split(',')[1].Length);
        }

        public static double GetVector(Particle particle)
        {
            Random random = new Random();
            double r1 = random.NextDouble();
            double r2 = random.NextDouble();
            double r3 = random.NextDouble();
            return PSO.c1 * r1 * particle.v + PSO.c2 * r2 * (particle.b - particle.x) + PSO.c3 * r3 * (particle.bg - particle.x);
        }
    }
}
