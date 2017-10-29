using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Ldi : Instruction
    {
        public new string red_code = "ldi";

        public Ldi(List<Parameter> parameters = null) : base (parameters)
        {
          // Define the differents scenario
          List<string> possible_combination_1 = new List<string>{"T_REG", "T_DIR", "T_REG"};
          List<string> possible_combination_2 = new List<string>{"T_REG", "T_REG", "T_REG"};

          List<string> possible_combination_3 = new List<string>{"T_DIR", "T_DIR", "T_REG"};
          List<string> possible_combination_4 = new List<string>{"T_DIR", "T_REG", "T_REG"};

          List<string> possible_combination_5 = new List<string>{"T_IND", "T_DIR", "T_REG"};
          List<string> possible_combination_6 = new List<string>{"T_IND", "T_REG", "T_REG"};

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
