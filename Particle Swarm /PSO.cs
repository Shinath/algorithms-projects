using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Particle_Swarm
{
    public partial class PSO : Form
    {
        public static double a;
        public static double b;
        public static double d;
        public static int N;
        public static int T;
        public static int l;
        public static double c1;
        public static double c2;
        public static double c3;
        public static int neighborsPercent;

        public PSO()
        {
            InitializeComponent();
        }

        private void clearAllBoxes()
        {
            textBoxA.Text = string.Empty;
            textBoxB.Text = string.Empty;
            textBoxT.Text = string.Empty;
            comboBox1.Text = "0,01";
            clearChartPoints();
        }

        private void clearChartPoints()
        {
            chart.Series["MAX"].Points.Clear();
            chart.Series["AVG"].Points.Clear();
            chart.Series["MIN"].Points.Clear();
            animation.Series["x"].Points.Clear();
            animation.Series["bestX"].Points.Clear();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            clearChartPoints();
            try
            {
                a = double.Parse(textBoxA.Text);
                b = double.Parse(textBoxB.Text);
                d = 0.001;
                N = Int32.Parse(textBoxN.Text);
                T = Int32.Parse(textBoxT.Text);
                c1 = double.Parse(textBoxC1.Text);
                c2 = double.Parse(textBoxC2.Text);
                c3 = double.Parse(textBoxC3.Text);
                neighborsPercent = Int32.Parse(textBoxBg.Text);
                l = MathHelpers.getChromosomeLen();
                double x = MathHelpers.GetRandomDoubleNumber();
                animation.ChartAreas[0].AxisX.Minimum = a;
                animation.ChartAreas[0].AxisX.Maximum = b;
            }
            catch
            {
                clearAllBoxes();
            }
            Algorithm algorithm = new Algorithm(this);
        }

        public void drawChart(List<double> particles, string series)
        {
            for(int i = 0; i < particles.Count; i++)
            {
                chart.Series[series].Points.AddXY(i + 1, particles[i]);
            }
        }

        public void drawChartA(List<double> particles, string series)
        {
            for (int i = 0; i < particles.Count; i++)
            {
                chart.Series[series].Points.AddXY(i + 1, MathHelpers.getFunctionValue(particles[i]));
            }
        }
    }
}
