using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    class Program
    {
        static void Main(string[] args)
        {
            // rates are to be optimyze latter on
            double selection_rate = 0.5;
            double hybridation_rate = 2;
            double mutation_rate = 0.1;

            int begining_pop = 100;
            int nb_generation = 300;


            Field range = new Field(10, 20);
            Randomyzer randomyse = new Randomyzer(range);
            Factory facto = new Factory(randomyse);
            Genetics Darwin = new Genetics(randomyse, facto, range, nb_generation, begining_pop, hybridation_rate, mutation_rate, selection_rate);

            Solution Champ = Darwin.Run_genetics();
        }
    }
}
