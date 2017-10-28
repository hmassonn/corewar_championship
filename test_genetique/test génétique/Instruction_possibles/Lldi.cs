using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Lldi_ : Instruction
    {
        public const string RED_CODE = "lldi";

        public Lldi_(List<Parameter> parameters = null) : base(parameters)
        {

        }
    }
}
