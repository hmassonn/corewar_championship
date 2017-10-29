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
       
        public Randomyzer( )
        {
          
        }

        public Champion Next_solution (int Nb_individual)
        {
            return null;
            //return new Champion(Random_Cara1(field), Random_Cara2(field), new ID (0,Nb_individual++,0));
        }


        public int Coin ()
        {
            return rdm.Next(0, 1);
        }

    }
}
