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

        public const char RED_CODE = 'Z';

        public const string VALUE_MIN = 0;
        public const string VALUE_MAX = 1;

        public Parameter (string value)
        {
            this.value = value;
        }

        public void toString()
        {
            return this.RED_CODE+this.value;
        }
    }
}
