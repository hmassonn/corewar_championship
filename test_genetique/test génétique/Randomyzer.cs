using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public class Randomyzer
    {
        private Random rdm = new Random(); // Making the random object global because we used to create many randoms quickly.
                                           // This causes random seeds to be the same, so randoms objects gave the same values.
                                           // Making one global random instance avoids this problem.
      
        public Field Bornes { get; private set; }


        public Randomyzer( Field bornes)
        {
            this.Bornes = bornes;
        }

        public Champion Next_solution(Field field, int Nb_individual)
        {
            return new Champion(Random_Cara1(field), Random_Cara2(field), new ID (0,Nb_individual++,0));
        }


        public double Random_Cara1(Field field)
        {
            return rdm.Next(field.Min, field.Min);
        }


        public double Random_Cara2(Field field)
        {
            return rdm.Next(field.Min, field.Max);
        }


    }
}
