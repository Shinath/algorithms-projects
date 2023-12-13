using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ANW
{
    public partial class ANW : Form
    {
        public static double a;
        public static double b;
        public static double d;
        public static int T;
        public static int l;

        private Algorithm algorithm;

        public ANW()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            chart.Series["x"].Points.Clear();
            try
            {
                a = double.Parse(textBoxA.Text);
                b = double.Parse(textBoxB.Text);
                d = double.Parse(comboBoxD.Text);
                T = Int32.Parse(textBoxT.Text);
                l = Helper.getChromosomeLen();
            }
            catch
            {
                clearAllBoxes();
            }
            algorithm = new Algorithm(this);
            write(algorithm.results);
            algorithm.results.Sort();
            drawChart(algorithm.results);
            
        }

        private void clearAllBoxes()
        {
            textBoxA.Text = string.Empty;
            textBoxB.Text = string.Empty;
            textBoxT.Text = string.Empty;
            comboBoxD.Text = "0,01";
            chart.Series["x"].Points.Clear();
        }

        public void write(List<double> results)
        {
            using (StreamWriter sw = File.CreateText(@"solutions.txt"))
            {
                foreach (double pair in results)
                {
                    sw.WriteLine(pair + " " + Helper.intToBin(Helper.realToInt(pair)) + " " + Helper.getFunctionValue(pair));
                }
            }
                
        } 
        
        private void drawChart(List<double> results)
        {
            foreach(double x in results)
            {
                chart.Series["x"].Points.AddXY(Helper.RoundNumberWithD(x), Helper.getFunctionValue(x));
            }
        }
    }
}
