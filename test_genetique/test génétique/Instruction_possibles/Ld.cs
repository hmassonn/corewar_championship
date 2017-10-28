﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Ld : Instruction
    {

        public Ld( ) : base ()
        {
            red_code = "ld";

            if (entre[0][0] == "dir")
                para_possible.Add(new Direct( entre[0][1] ));
            else if (entre[0][0] == "ind")
                para_possible.Add(new Indirect(entre[0][1]));
            para_possible.Add(new Registre());
        }
    }
}
