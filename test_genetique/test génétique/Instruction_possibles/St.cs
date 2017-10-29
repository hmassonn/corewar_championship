using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class St : Instruction
    {
        public new string red_code = "st";

        public St(List<Parameter> parameters = null) : base(parameters)
        {
          List<string> possible_combination_1 = new List<string>{"T_REG", "T_IND"};
          List<string> possible_combination_2 = new List<string>{"T_REG", "T_REG"};

          parameters_possible_combinations.Add(possible_combination_1);
          parameters_possible_combinations.Add(possible_combination_2);
        }

        public override string toString()
        {
            string res = red_code + " ";

            foreach (Parameter parameter in parameters)
            {
                res += parameter.toString() + ", ";
            }

            res = res.Substring(0, res.Length - 2); //TODO :: vérifier si la taille est OK

            return res;
        }
    }
}
