using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_génétique.Parameters
{
    public class Registre : Parameter
    {       
        public override string redcode => "r";

        public const int VALUE_MIN = 1;
        public const int VALUE_MAX = 16;

        public Registre(string value) : base(value)
        {

        }

        public  static string getRedCode()
        {
            return "r";
        }
    }
}
