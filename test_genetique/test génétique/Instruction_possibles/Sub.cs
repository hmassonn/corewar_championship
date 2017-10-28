using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Sub : Instruction
    {
        public Sub() : base ()
        {
            red_code = "sub";
            para_possible.Add(new Registre());
            para_possible.Add(new Registre());
            para_possible.Add(new Registre());

        }
    }
}
