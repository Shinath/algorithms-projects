using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANW
{
    class Algorithm
    {
        public List<double> results = new List<double>();
        private ANW anw;

        public Algorithm(ANW anw)
        {
            this.anw = anw;
            for(int i = 0; i < ANW.T; i++)
            {
                bool local = false;
                double vc = Helper.RoundNumberWithD(Helper.GetRandomDoubleNumber());
                string vc_bin = Helper.intToBin(Helper.realToInt(vc));

                while(!local)
                {
                    List<double> kids = new List<double>();
                    for (int j = 0; j < ANW.l; j++)
                    {
                        double kid = Helper.intToReal(Helper.binToInt(switchBit(j, vc_bin)));
                        kids.Add(kid);
                    }
                    
                    double maxVn = max(kids);
                    if(Helper.getFunctionValue(vc) < Helper.getFunctionValue(maxVn))
                    {
                        vc = maxVn;
                        vc_bin = Helper.intToBin(Helper.realToInt(vc));
                    }
                    else
                    {
                        local= true;
                    }
                }
                results.Add(Helper.RoundNumberWithD(vc));
            }
        }

        private string switchBit(int index, string vc)
        {
            List<char> chars = vc.ToList();
            switch (chars[index])
            {
                case '1':
                    chars[index] = '0';
                    break;
                case '0':
                    chars[index] = '1';
                    break;
            }
            return String.Join("", chars);
        }

        private double max(List<double> kids)
        {
            double max = kids[0];
            foreach(double key in kids)
            {
                if (Helper.getFunctionValue(key) > Helper.getFunctionValue(max))
                {
                    max = key;
                }
            }
            return max;
        }
    }
}
