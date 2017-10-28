using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Lld_ : Instruction
    {
        public const string RED_CODE = "lld";

        public Lld_(List<Parameter> parameters) : base(parameters)
        {
        }
    }
}
