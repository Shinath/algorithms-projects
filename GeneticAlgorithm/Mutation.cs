using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Mutation
    {
        public string xbin;
        public List<int> mutatedGenes = new List<int>();
        public string afterMutation;

        public Mutation(string xbin)
        {
            this.xbin = xbin;
            selectRandomGenes();
            Mutate();
        }

        private void selectRandomGenes()
        {
            for(int i = 0; i < GUIForm.l; i++)
            {
                double r = Algorithm.GetRandomDoubleNumber(0, 1);
                if (r < GUIForm.Pm)
                {
                    mutatedGenes.Add(i);
                }
            }
        }

        private void Mutate()
        {
            if (mutatedGenes != null)
            {
                for (int i = 0; i < xbin.Length; i++)
                {
                    if (mutatedGenes.Contains(i))
                    {
                        afterMutation += switchGene(xbin[i]);
                    }
                    else
                    {
                        afterMutation += xbin[i];
                    }
                }
            }
        }

        private char switchGene(char gene)
        {
            if(gene == '0')
            {
                return '1';
            }
            return '0';
        }
    }
}
