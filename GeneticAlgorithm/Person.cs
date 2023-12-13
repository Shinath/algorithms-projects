using System;
using System.Globalization;

namespace GeneticAlgorithm
{
    class Person
    {
        public double x;
        public double Fx;
        public string xbin;
        public int xint;

        public double Gx;
        public double p;
        public double q;
        public double r;

        public bool isParent = false;
        public Nullable<int> pairIndex;

        public Person(Nullable<double> x = null)
        {
            if (x == null)
            {
                this.x = Math.Round(Algorithm.GetRandomDoubleNumber(GUIForm.a, GUIForm.b), GUIForm.d.ToString(new CultureInfo("es-ES")).Split(',')[1].Length);
            }
            else
            {
                this.x = x.Value;
            }
            Fx = getFunctionValue();
            xint = realToInt();
            xbin = intToBin();
        }

        public Person(Person person)
        {
            this.x = person.x;
            Fx = getFunctionValue();
            xint = realToInt();
            xbin = intToBin();
        }

        private double getFunctionValue()
        {
            return x % 1.0 * (Math.Cos(20.0 * Math.PI * x) - Math.Sin(x));
        }

        private int realToInt()
        {
            double xint = ((1.0 / (GUIForm.b - GUIForm.a)) * (x - GUIForm.a) * (Math.Pow(2, GUIForm.l) - 1.0));
            return (int)Math.Round(xint);
        }

        private string intToBin()
        {
            return Convert.ToString(xint, 2).PadLeft(GUIForm.l, '0');
        }


        //Statici do dzieci TODO na tury 
        public static double intToReal(int xint)
        {
            return (((GUIForm.b - GUIForm.a) * xint) / (Math.Pow(2, GUIForm.l) - 1.0)) + GUIForm.a;
        }

        public static int binToInt(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }
        public static double functionValue(int x)
        {
            double real = (((GUIForm.b - GUIForm.a) * x) / (Math.Pow(2, GUIForm.l) - 1.0)) + GUIForm.a;
            return real % 1.0 * (Math.Cos(20.0 * Math.PI * real) - Math.Sin(real));
        }

    }
}
