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
        public string value { get; set; }

        //public string redcode = "Z";
        public virtual string redcode => "z";

        public const int VALUE_MIN = 0;
        public const int VALUE_MAX = 1;

        public Parameter (string value)
        {
            this.value = value;
        }

        public virtual string toString()
        {
            return redcode + value;
        }

        public virtual string getRedCode()
        {
            return redcode;
        }
    }
}
