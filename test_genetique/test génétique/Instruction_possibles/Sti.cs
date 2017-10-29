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

        }
    }
}
