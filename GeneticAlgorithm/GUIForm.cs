using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class GUIForm : Form
    {
        public static double a;
        public static double b;
        public static double d;
        public static int N;
        public static int l;
        public static double Pk;
        public static double Pm;
        public static bool elite;
        public static int T;

        private Algorithm algorithm;

        public GUIForm()
        {
            InitializeComponent();
            comboBoxD.SelectedIndex = 2;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            removeAllRows();
            setAllValues();
            algorithm = new Algorithm(new Person[] {});
            generateAllRowsToMainBoard();
            generateAllRowsToBreedingBoard();
            for (int i = 0; i < T; i++)
            {
                next();
            }
        }

        private void setAllValues()
        {
            try
            {
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);
                d = Double.Parse(comboBoxD.GetItemText(comboBoxD.SelectedItem), new CultureInfo("es-ES"));
                N = Convert.ToInt32(textBoxN.Text);
                Pk = Double.Parse(textBoxPk.Text, new CultureInfo("es-ES"));
                Pm = Double.Parse(textBoxPm.Text, new CultureInfo("es-ES"));
                l = getChromosomeLen();
                elite = elitaCheckBox.Checked;
                T = Convert.ToInt32(textBoxT.Text);
            }
            catch (FormatException)
            {
                clearAllTextBoxes();
            }
        }
        private void addNewRowToMainBoard(int lp, Person person)
        {
            mainDashboard.Rows.Add(lp, person.x, person.Fx, person.Gx, person.p, person.q, person.r);
        }

        private void generateAllRowsToMainBoard()
        {
            int lp = 0;
            foreach(Person person in algorithm.population)
            {
                addNewRowToMainBoard(lp, person);
                lp++;
            }
        }


        private void addNewRowToBreedingBoard(Person person)
        {
            if (person.isParent == true && person.pairIndex.Value < algorithm.pairs.Count())
            {
                string kid = algorithm.searchKid(person);
                Mutation mutation = new Mutation(kid);
                int kidAfterMutation = Person.binToInt(mutation.xbin);
                breedingDashboard.Rows.Add(person.x, person.xbin, person.xbin, algorithm.searchPc(person), kid, kid, Algorithm.listToString(mutation.mutatedGenes), mutation.afterMutation, Math.Round(Person.intToReal(kidAfterMutation), d.ToString(new CultureInfo("es-ES")).Split(',')[1].Length), Person.functionValue(kidAfterMutation));
            }
            else
            {
                breedingDashboard.Rows.Add(person.x, person.xbin, null, null, null, person.xbin, null, person.xbin, Math.Round(Person.intToReal(Person.binToInt(person.xbin)), d.ToString(new CultureInfo("es-ES")).Split(',')[1].Length), person.Fx);
            }
        }
        private void generateAllRowsToBreedingBoard()
        {
            foreach (Person person in algorithm.populationAfterSelection)
            {
                addNewRowToBreedingBoard(person);
            }
        }

        private void clearAllTextBoxes()
        {
            textBoxA.Text = null;
            textBoxB.Text = null;
            textBoxN.Text = null;
            comboBoxD.Text = null;
            textBoxPk.Text = null;
            textBoxPm.Text = null;
            elitaCheckBox.Checked = true;
            textBoxT.Text = null;
        }

        private void removeAllRows()
        {
            mainDashboard.Rows.Clear();
            breedingDashboard.Rows.Clear();
        }
              
        private int getChromosomeLen()
        {
            return Convert.ToInt32(Math.Ceiling(Math.Log(((b - a) / d + 1.0), 2)));
        }

        private void next()
        {
            Person[] newPopulation = getKidsList();
            if (elite)
            {
                includeElite(newPopulation);
                algorithm = new Algorithm(newPopulation);
            }
            else
            {
                algorithm = new Algorithm(newPopulation);
            }
            removeAllRows();
            generateAllRowsToMainBoard();
            generateAllRowsToBreedingBoard();
        }

        private void includeElite(Person[] newPopulation)
        {
            if (!newPopulation.Contains(algorithm.elitePerson))
            {
                int randNumber = Algorithm.GetRandomIntNumber(N, 0);
                Person randomPerson = newPopulation[randNumber];
                if (randomPerson.Fx < algorithm.elitePerson.Fx)
                {
                    newPopulation[randNumber] = algorithm.elitePerson;
                }
            }
        }

        private Person[] getKidsList()
        {
            Person[] persons = new Person[N];
            for (int i = 0; i < N; i++)
            {
                persons[i] = new Person(Double.Parse(breedingDashboard.Rows[i].Cells[8].Value.ToString()));
            }
            return persons;
        }
    }
}
