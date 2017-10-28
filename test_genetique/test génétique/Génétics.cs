using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public class Genetics
    {
        public Randomyzer Randomyse { get; private set; }
        public Factory Facto { get; private set; }
        public Field Range { get; private set; }

        public double Selection_rate { get; private set; }
        public double Mutation_rate { get; private set; }
        public double Hybridation_rate { get; private set; }
        public int Begin_pop { get; private set; }
        public int Generation_max { get; private set; }
        public int Generation_nb { get; private set; }

        public List<Champion> Population { get; private set; }
        public List<Champion> Bests_solution { get; private set; }


        /// <summary>
        /// Genetics algorithm
        /// </summary>
        /// <param name="randomyse">Separat class to creat a random solution</param>
        /// <param name="facto">To creat the begin pop</param>
        /// <param name="champ">Boundary of the problem</param>
        /// <param name="nb_iter">Nombre d'itération</param>
        /// <param name="begin_pop">Population de départ</param>
        /// <param name="hyb_rate">Taux d'hybridation (à paramétrer dans un deuxiem temps)</param>
        /// <param name="mut_rate">Taux de mutation (à paramétrer dans un deuxiem temps)</param>
        /// <param name="sel_rate">Taux de selection (à paramétrer dans un deuxiem temps)</param>
        public Genetics(Randomyzer randomyse, Factory facto, Field field, int nb_iter, int begin_pop, double hyb_rate, double mut_rate, double sel_rate)
        {
            this.Randomyse = randomyse;
            this.Facto = facto;
            this.Range = field;

            Begin_pop = begin_pop;
            Generation_max = nb_iter;
            Selection_rate = sel_rate;
            Hybridation_rate = hyb_rate;
            Mutation_rate = mut_rate;

            Bests_solution = new List<Champion>();
            Population = new List<Champion>();

            Generation_nb = 0;
        }

        public Champion Run_genetics()
        {
            List<Champion> Elits = new List<Champion>();
            List<Champion> Population_after_Hybridation = new List<Champion>();
            List<Champion> Population_after_Mutation = new List<Champion>();

            Facto.Generate_solutions(Begin_pop, Range);

            // Begining of iterations
            //----------------------------------------------------------------------------------------
            for (int i = 0; i < Generation_max; i++)
            {
                // Ranking 
                //----------------------------------------------------------------------------------------
                //TODO Set the Selection criteria and the rancking system
                Population.Sort();

                // Selection (Elitism)
                //----------------------------------------------------------------------------------------
                Elits = Evolution.Elitism(Population, Selection_rate);
                Population = new List<Champion>(Elits);
                Elits.Clear();

                // Hybridation
                //---------------------------------------------------------------------------------------- 
                Population_after_Hybridation = Evolution.Hybridation(Population, Hybridation_rate, Generation_nb++);
                Population = new List<Champion>(Population_after_Hybridation);
                Population_after_Hybridation.Clear();

                // Mutation
                //----------------------------------------------------------------------------------------
                Population_after_Mutation = Evolution.Mutation(Randomyse, Population, Range, Mutation_rate, Generation_nb);
                Population = new List<Champion>(Population_after_Hybridation);
                Population_after_Mutation.Clear();
            }

            // add a last rancking session
            Population.Sort();
            //returning the best of the Population after "nb iterations"
            return Population[0];
        }
    }
}
