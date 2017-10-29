using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Add_ : Instruction
    {
        public new string red_code = "add";

        public Add_(List<Parameter> parameters = null) : base (parameters)
        {
            /*
            para_possible.Add(new Registre());
            para_possible.Add(new Registre());
            para_possible.Add(new Registre());
            */

        }
    }
}
