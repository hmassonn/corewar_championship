using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
   public class Factory
    {
        public Randomyzer Randomyse { get; private set; }
        public List<Champion> random_pop;
    
        public Factory(Randomyzer randomyse)
        {
            this.Randomyse = randomyse;
            random_pop = new List<Champion>();
        }


        public void Generate_solutions(int count)
        {
            for (int i = 0; i < count; i++)
                random_pop.Add(Randomyse.Next_solution( i));
        }



    }
}
