using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Xor : Instruction
    {
        public new string red_code = "xor";

        public Xor(List<Parameter> parameters = null) : base(parameters)
        {
        }
    }
}
