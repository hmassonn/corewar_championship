using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Lfork_ : Instruction
    {
        public new string red_code = "lfork";

        public Lfork_(List<Parameter> parameters = null) : base (parameters)
        {
           // para_possible.Add(new Direct ());
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
