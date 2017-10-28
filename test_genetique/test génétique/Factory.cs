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

    
        public Factory(Randomyzer randomyse)
        {
            this.Randomyse = randomyse;
        }


        public void Generate_solutions(int count, Field field)
        {
            List<Champion> new_population = new List<Champion>();

            for (int i = 0; i < count; i++)
                new_population.Add(Randomyse.Next_solution(field, i));


        }



    }
}
