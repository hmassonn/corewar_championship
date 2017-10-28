using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Ldi : Instruction
    {
        public const string RED_CODE = "ldi";

        public Ldi(List<Parameter> parameters) : base (parameters)
        {
        }
    }
}
