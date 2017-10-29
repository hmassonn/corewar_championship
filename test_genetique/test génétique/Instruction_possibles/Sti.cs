using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Sti : Instruction
    {
        public new string red_code = "sti";

        public Sti(List<Parameter> parameters = null) : base(parameters)
        {
          List<string> possible_combination_1 = new List<string>{"T_REG", "T_REG", "T_DIR"};
          List<string> possible_combination_2 = new List<string>{"T_REG", "T_REG", "T_REG"};

          List<string> possible_combination_3 = new List<string>{"T_REG", "T_DIR", "T_DIR"};
          List<string> possible_combination_4 = new List<string>{"T_REG", "T_DIR", "T_REG"};

          List<string> possible_combination_5 = new List<string>{"T_REG", "T_IND", "T_REG"};
          List<string> possible_combination_6 = new List<string>{"T_REG", "T_IND", "T_REG"};

          parameters_possible_combinations.Add(possible_combination_1);
          parameters_possible_combinations.Add(possible_combination_2);
          parameters_possible_combinations.Add(possible_combination_3);
          parameters_possible_combinations.Add(possible_combination_4);
          parameters_possible_combinations.Add(possible_combination_5);
          parameters_possible_combinations.Add(possible_combination_6);
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
