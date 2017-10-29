﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Ld : Instruction
    {
        public new string red_code = "ld";

        public Ld(List<Parameter> parameters = null) : base (parameters)
        {
            red_code = "ld";
            /*
            if (entre[0][0] == "dir")
                para_possible.Add(new Direct( entre[0][1] ));
            else if (entre[0][0] == "ind")
                para_possible.Add(new Indirect(entre[0][1]));
            para_possible.Add(new Registre());
            */
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
