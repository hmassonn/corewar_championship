using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public static class Evolution
    {
        public static List<Solution> Elitism(List<Solution> Population, double Selection_rate)
        {
            int number_to_select = (int)Math.Round(Population.Count * Selection_rate);
            List<Solution> Population_after_selection = new List<Solution>();

            for (int i = 0; i < number_to_select; i++)
            {
                Population_after_selection.Add(Population[i]);
            }

            Population = new List<Solution>(Population_after_selection);
            Population_after_selection.Clear();

            return Population_after_selection;
        }

        public static Solution Lucky_Wheel(List<Solution> Candidates)
        {
            // To creat a lucky wheel, porprieties of Geometric sequence are used.

            List<double> sequence_terms = new List<double>(); // stacking the terms of the Geometric sequence.
            double n0 = 1; // first term.
            double ni = n0; // use to compute terms.
            double common_ratio = 1.20; // the reason of the Geometric sequence. Care, this ration have a direct impact on the génétics optimisation
            double Sum_Geometric_sequence = 0; // The sum of the Geometric sequence.

            double Wheel = 360; // Wheel ==360°

            List<double> part_wheel = new List<double>(); // Stacking all part of the wheel ( section of he wheel in °).
            List<double> position_wheel = new List<double>(); // tacking alls the potition on the wheel (position in °, the first is 0° the last is 360°).

            Solution winner = null; // intialising the object solution.

            //Building the Geometric sequence (depending of the size of the population).
            sequence_terms.Add(n0);
            for (int i = 1; i < Candidates.Count; i++)
            {
                ni *= common_ratio;
                sequence_terms.Add(ni);
            }

            // Computing the sum of the Geometric sequence (usefull to build the lucky wheel)
            Sum_Geometric_sequence = (n0 * (1 - Math.Pow(common_ratio, sequence_terms.Count)) / (1 - common_ratio));

            // Setting the size of each part of the wheel depending of the size of the population and the common ration. The next part will be: "common ration" biger than the previous one, etc ....
            foreach (double terms in sequence_terms)
            {
                part_wheel.Add((terms * Wheel) / Sum_Geometric_sequence);
            }

            // the Whell is build from the smallest to the bigest. It is better to reverse it for the picking
            part_wheel.Reverse();

            //Building the wheel
            double pos = 0;
            foreach (double pr in part_wheel)
            {
                position_wheel.Add(pos);
                pos += pr;
            }
            position_wheel.Add(Wheel);

            //Running the wheel
            Random rdm = new Random();
            double draw = rdm.NextDouble() * Wheel;

            //Locating the draw and picking it on the wheel
            for (int i = 1; i <= position_wheel.Count; i++)
            {
                if (draw > position_wheel[i - 1] && draw < position_wheel[i])
                    winner = Candidates[i - 1];
            }
            return winner;
        }

        public static List<Solution> Hybridation(List<Solution> Population, double hybridation_rate, int generation)
        {
            List<Solution> Kids = new List<Solution>();
            int number_to_hybrid = (int)Math.Round(Population.Count * hybridation_rate);
            Random random = new Random(); // May be a mistake with random set this way, have a check on it!
            int nb_individual = 0;


            for (int i = 0; i <= number_to_hybrid; i++)
            {
                Solution parent1 = Lucky_Wheel(Population);
                Solution parent2 = Lucky_Wheel(Population);

                while (parent1.Id == parent2.Id)
                    parent2 = Lucky_Wheel(Population);

                double cara1;
                double cara2;

                int coin1 = random.Next(0, 1);
                if (coin1 == 0)
                    cara1 = parent1.X;
                else
                    cara1 = parent2.X;

                int coin2 = random.Next(0, 1);
                if (coin2 == 0)
                    cara2 = parent1.Y;
                else
                    cara2 = parent2.Y;
                Kids.Add(new Solution(cara1, cara2, new ID(generation, nb_individual++, 0)));
            }
            foreach (Solution S in Kids)
                Population.Add(S);

            return Population;
        }

        public static List<Solution> Mutation(Randomyzer randomyse, List<Solution> Population,Field field, double mutation_rate, int generation)
        {
            int number_to_mutate = (int)Math.Round(Population.Count * mutation_rate);
            List<Solution> Population_after_Mutation = new List<Solution>(Population);

            for (int i = 0; i < number_to_mutate; i++)
            {
                Solution Mutant;
                double cara1;
                double cara2;

                Random rdm = new Random();
                int draw = rdm.Next(1, Population.Count - 1); // to avoid to pick the best Solution


                int coin1 = rdm.Next(0, 1);
                int coin2 = rdm.Next(0, 1);

                cara1 = Population[draw].X;
                if (coin1 == 1)
                    cara1 = randomyse.Random_Cara1(field);
                cara2 = Population[draw].Y;
                if (coin2 == 1)
                    cara2 = randomyse.Random_Cara2(field);
                Mutant = new Solution(cara1, cara2, new ID(Population[draw].Id.Nb_gen, Population[draw].Id.Nb_gen, Population[draw].Id.Nb_mut+1));
                Population.Remove(Population[draw]);
                Population_after_Mutation.Remove(Population_after_Mutation[draw]);
                Population_after_Mutation.Add(Mutant);
            }
            return Population_after_Mutation;
        }
    }
}
