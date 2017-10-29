using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Or_ : Instruction
    {
        public new string red_code = "or";

        public Or_(List<Parameter> parameters = null) : base(parameters)
        {

        }
    }
}
