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
            /*
            para_possible.Add(new Registre());
            para_possible.Add(new Indirect());
            para_possible.Add(new Registre());
            */
        }
    }
}
