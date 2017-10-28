using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public class ID
    {
        public int Nb_gen { get; private set; }
        public int Nb_ind { get; private set; }
        public int Nb_mut { get; private set; }

        public ID(int gen, int ind, int mut)
        {
            Nb_gen = gen;
            Nb_ind = ind;
            Nb_mut = mut;
        }

        public new string ToString()
        {
            return "Generation: " + Nb_gen + " Individu: " + Nb_ind + " Mutation: " + Nb_mut;
        }

    }
}
