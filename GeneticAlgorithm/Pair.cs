using System.Collections.Generic;

namespace GeneticAlgorithm
{
    class Pair
    {
        public List<Person> pair = new List<Person>();
        public int pc;
        public List<string> kids = new List<string>(); //lista ludzi przy t turach, tworzenie nowego obiektu Persona dla każdego dziecka

        public Pair(Person person1, params Person[] person2)
        {
            pair.Add(person1);
            pair.Add(person2[0]);
            pc = Algorithm.GetRandomIntNumber(GUIForm.l);
            if(person2.Length != 0)
            {
                breeding();
            }
            
        }

        private void breeding()
        {
            string part1 = pair[0].xbin.Substring(0, pc);
            string part2 = pair[1].xbin.Substring(pc);
            kids.Add(part1 + part2);

            part1 = pair[1].xbin.Substring(0, pc);
            part2 = pair[0].xbin.Substring(pc);
            kids.Add(part1 + part2);
        }
    }
}
