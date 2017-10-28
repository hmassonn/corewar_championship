using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Instruction_possibles;

namespace test_génétique.Parameters
{
    public abstract class Parameter
    {
        public int weight { get; set; }
        public string type { get; set; }
        public string value { get; set; }
      

        public Parameter (string value)
        {
            this.type = type;
            this.value = value;
        }
    }
}
