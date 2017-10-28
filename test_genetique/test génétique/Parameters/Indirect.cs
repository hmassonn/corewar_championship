using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_génétique.Parameters
{
    public class Indirect : Parameter
    {
        public const char RED_CODE = null;

        public const int VALUE_MIN = -4000;
        public const int VALUE_MAX = 4000;

        public Indirect(string value) : base (value)
        {

        }

    }
}
