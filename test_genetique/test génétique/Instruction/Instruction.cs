using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction
{
    public class Instruction
    {
        public string type_I { get; private set; }
        public List <Param> para { get; protected set; }
        public int weight_I { get; private set; }

        public Instruction ()
        {
            this.para = new List<Param>();

        }



    }
}
