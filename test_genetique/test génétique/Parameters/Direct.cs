using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_génétique.Parameters
{
    public class Direct : Parameter
    {
        public string red_code = "%";

        public const int VALUE_MIN = -4000;
        public const long VALUE_MAX = 4294967295;

        public Direct(string value) : base(value)
        {

        }

        public static string getRedCode()
        {
            return "%";
        }

        public new string toString()
        {
            return "%" + this.value;
            //return base.toString();
        }
    }
}
