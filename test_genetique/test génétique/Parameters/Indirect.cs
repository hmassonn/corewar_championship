using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_génétique.Parameters
{
    public class Indirect : Parameter
    {
        public override string redcode => "";

        public const int VALUE_MIN = -4000;
        public const int VALUE_MAX = 4000;

        public Indirect(string value) : base (value)
        {

        }

        public static string getRedCode()
        {
            return "";
        }

    }
}
