using System;
using System.Collections.Generic;

namespace GeneticAlgorithm
{
    class Algorithm
    {
        public Person[] population;
        public List<Person> populationAfterSelection = new List<Person>();
        public List<Pair> pairs = new List<Pair>();
        public Person elitePerson;

        public Algorithm(Person[] population)
        {
            if (population == null || population.Length == 0)
            {
                generatePopulation();
            }
            else
            {
                this.population = population;
            }
            setElitePerson();
            setGFunctionValueForPopulation(getMin());
            setPValueForPopulation(getSum());
            setQValueForPopulation();
            setRValueForPopulation();
            selection();
            setParenthood();
            matchPairs();
        }

        private void setElitePerson()
        {
            elitePerson = population[0];
            foreach(Person person in population)
            {
                if (person.Fx > elitePerson.Fx)
                {
                    elitePerson = person;
                }
            }
        }
        public static int GetRandomIntNumber(int ceil, int floor = 1)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            return rand.Next(floor, ceil);
        }
        public static double GetRandomDoubleNumber(double minimum, double maximum)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public string searchKid(Person parent)
        {
            if (parent.pairIndex.HasValue && parent.pairIndex.Value < pairs.Count)
            {
                Pair couple = pairs[parent.pairIndex.Value];
                if (couple.pair[0].x == parent.x)
                {
                    return couple.kids[0];
                }
                return couple.kids[1];
            }
            return null;
        }

        public string searchPc(Person parent)
        {
            if (parent.pairIndex.HasValue && parent.pairIndex.Value < pairs.Count)
            {
                return pairs[parent.pairIndex.Value].pc.ToString();
            }
            return null;
        }
        private void generatePopulation()
        {
            population = new Person[GUIForm.N];
            for (int i = 0; i < GUIForm.N; i++)
            {
                population[i] = new Person();
            }
        }
        public static string listToString(List<int> genes)
        {
            for(int i = 0; i < genes.Count; i++)
            {
                genes[i]++;
            }
            return String.Join(",", genes);
        }

        private double getMin()
        {
            double min = 0;
            foreach(Person p in population)
            {
                if (p.Fx < min)
                {
                    min = p.Fx;
                }
            }
            return min;
        }

        private void setGFunctionValueForPopulation(double min)
        {
            foreach(Person p in population)
            {
                p.Gx = p.Fx - min + GUIForm.d;
            }
        }

        private double getSum()
        {
            double sum = 0;
            foreach(Person p in population)
            {
                sum += p.Gx;
            }
            return sum;
        }

        private void setPValueForPopulation(double sum)
        {
            foreach(Person p in population)
            {
                p.p = p.Gx / sum;
            }
        }

        private void setQValueForPopulation()
        {
            double sum = 0;
            foreach( Person p in population)
            {
                sum += p.p;
                p.q = sum;
            }
        }

        private void setRValueForPopulation()
        {
            foreach( Person p in population)
            {
                p.r = GetRandomDoubleNumber(0, 1);
            }
        }

        private void selection()
        {
            foreach(Person person in population)
            { 
                foreach(Person maybeSelectedPerson in population)
                { 
                    if(person.r < maybeSelectedPerson.q && !populationAfterSelection.Contains(maybeSelectedPerson))
                    {
                        populationAfterSelection.Add(maybeSelectedPerson);
                        break;
                    }
                    else if (person.r < maybeSelectedPerson.q && populationAfterSelection.Contains(maybeSelectedPerson))
                    {
                        populationAfterSelection.Add(new Person(maybeSelectedPerson));
                        break;
                    }
                }
            }
        }

        private void setParenthood()
        {
            foreach(Person p in populationAfterSelection)
            {
                double r = GetRandomDoubleNumber(0, 1);
                if(r < GUIForm.Pk)
                {
                    p.isParent = true;
                }
            }
        }

        private void matchPairs()
        {
            List<Person> pair = new List<Person>();
            int indexCounter = 0;
            foreach(Person p in populationAfterSelection)
            {
                if (pair.Count < 2 && p.isParent == true)
                {
                    pair.Add(p);
                    p.pairIndex = indexCounter;
                }
                if (pair.Count == 2)
                {
                    pairs.Add(new Pair(pair[0], pair[1]));
                    indexCounter++;
                    pair.Clear();
                }
            }
        }
    }
}
