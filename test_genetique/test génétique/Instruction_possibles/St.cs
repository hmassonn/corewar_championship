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

        public St(List<Parameter> parameters) : base(parameters)
        {
            red_code = "st";
            /*
            para_possible.Add(new Registre());
            para_possible.Add(new Indirect());
            para_possible.Add(new Registre());
            */

        }
    }
}
