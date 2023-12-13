using System.Collections.Generic;
using System.Threading.Tasks;

namespace Particle_Swarm
{
    class Algorithm
    {
        public List<Particle> particles = new List<Particle>();
        public List<double> tBest = new List<double>();
        public List<double> tAvg = new List<double>();
        public List<double> tWorst = new List<double>();
        public PSO pso;

        public Algorithm(PSO pso)
        {   
            this.pso = pso;
            Run();
            pso.drawChartA(tBest, "MAX");
            pso.drawChartA(tWorst, "MIN");
            pso.drawChart(tAvg, "AVG"); 
        }
        public void Run()
        {
            for (int i = 0; i < PSO.N; i++)
            {
                particles.Add(new Particle());
            }

            for (int i = 0; i < PSO.T; i++)
            {
                tAvg.Add(getAvg());
                tBest.Add(getMax());
                tWorst.Add(getMin());
                printPoints();
                Task.WaitAll(Task.Delay(100));
                foreach (Particle particle in particles)
                {
                    double particleVall = MathHelpers.getFunctionValue(particle.x);
                    // szukanie najlepszej dotychczas znalezionej przez cząsteczkę pozycji 
                    if (particleVall > MathHelpers.getFunctionValue(particle.b))
                    {
                        particle.b = particle.x;
                    }

                    //funkcja zwracająca najlepsza pozycje z sąsiedztwa
                    particle.getNeighborhood(particles);
                    particle.bg = particle.getNeighborhoodBest();
                    if (particleVall > MathHelpers.getFunctionValue(particle.bg))
                    {
                        particle.bg = particle.x;
                    }
                }

                foreach (Particle particle in particles)
                {
                    particle.v = MathHelpers.GetVector(particle);
                    if ((particle.x + particle.v) > PSO.b)
                    {
                        particle.x = PSO.b;
                    }
                    else if ((particle.x + particle.v) < PSO.a)
                    {
                        particle.x = PSO.a;
                    }
                    else
                    {
                        particle.x = MathHelpers.RoundNumberWithD(particle.x + particle.v);
                    }
                }
            }
            
        }

        public double getMax()
        {
            double max = particles[0].x;
            foreach (Particle particle in particles)
            {
                if (MathHelpers.getFunctionValue(particle.x) > MathHelpers.getFunctionValue(max))
                {
                    max = particle.x;
                }
            }
            return max;
        }

        public double getMin()
        {
            double min = particles[0].x;
            foreach (Particle particle in particles)
            {
                if (MathHelpers.getFunctionValue(particle.x) < MathHelpers.getFunctionValue(min))
                {
                    min = particle.x;
                }
            }
            return min;
        }

        public double getAvg()
        {
            double avg = 0;
            foreach (Particle particle in particles)
            {
                avg += MathHelpers.getFunctionValue(particle.x);
            }
            return avg / PSO.N;
        }

        private void printPoints()
        {
            pso.animation.Series["x"].Points.Clear();
            pso.animation.Series["bestX"].Points.Clear();
            foreach (Particle particle in particles)
            {
                pso.animation.Series["x"].Points.AddXY(particle.x, MathHelpers.getFunctionValue(particle.x));
            }
            double max = getMax();
            pso.animation.Series["bestX"].Points.AddXY(max, MathHelpers.getFunctionValue(max));
        }
    }
}
