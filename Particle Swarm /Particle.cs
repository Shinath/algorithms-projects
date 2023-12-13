using System;
using System.Collections.Generic;
using System.Linq;

namespace Particle_Swarm
{
    class Particle
    {
        public double x;
        public double v;
        public double b;
        public double bg;
        public Dictionary<Particle, double> neighborhood = new Dictionary<Particle, double>(); 

        public Particle()
        {
            x = MathHelpers.RoundNumberWithD(MathHelpers.GetRandomDoubleNumber());
            v = 0;
            b = x;
            bg = x;
        }

        public void getNeighborhood(List<Particle> global)
        {
            neighborhood.Clear();
            int neighborsSize = Convert.ToInt32(PSO.N * PSO.neighborsPercent / 100);
            Dictionary<Particle, double> globalWithDistance = new Dictionary<Particle, double>();

            foreach (Particle neighbor in global)
            {
                double distance = Math.Abs(x - neighbor.x);
                globalWithDistance.Add(neighbor, distance);
            }

            globalWithDistance = globalWithDistance.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int i = 0;
            foreach(KeyValuePair<Particle, double> pair in globalWithDistance)
            {
                if (i < neighborsSize)
                {
                    neighborhood.Add(pair.Key, pair.Value);
                    i++;
                }
                else
                {
                    break;
                }
            }
        }

        public double getNeighborhoodBest()
        {
            double best = x;
            foreach(Particle neighbor in neighborhood.Keys)
            {
                if(MathHelpers.getFunctionValue(neighbor.bg) > MathHelpers.getFunctionValue(best))
                {
                    best = neighbor.bg;
                }
            }
            return best;
        }

    }
}
