using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Live : Instruction
    {
        public const string RED_CODE = "live";

        public Live(List<Parameter> parameters = null) : base(parameters)
        {
            //para_possible.Add(new Direct());
        }

    }
}
