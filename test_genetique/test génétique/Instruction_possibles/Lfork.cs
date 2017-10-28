using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Lfork_ : Instruction
    {
        public Lfork_(List<Parameter> parameters) : base (parameters)
        {
            red_code = "lfork";
           // para_possible.Add(new Direct ());
        }
    }
}
