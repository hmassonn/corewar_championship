﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    class Live : Instruction
    {
        public Live () : base ()
        {
            red_code = "live";
            para_possible.Add(new Direct());
        }

    }
}
