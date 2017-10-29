using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Sub : Instruction
    {
        public new string red_code = "sub";

        public Sub(List<Parameter> parameters = null) : base(parameters)
        {
          List<string> possible_combination_1 = new List<string>{"T_REG", "T_REG", "T_REG"};

          parameters_possible_combinations.Add(possible_combination_1);

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
