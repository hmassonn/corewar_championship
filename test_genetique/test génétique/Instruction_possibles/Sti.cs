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
        public const string RED_CODE = "sti";

        public Sti(List<Parameter> parameters) : base(parameters)
        {

        }
    }
}
