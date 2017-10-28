using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction
{
    class Live : Instruction
    {

        public Live () : base ()
        {
            this.para.Add(new Direct(4));

        }

    }
}
