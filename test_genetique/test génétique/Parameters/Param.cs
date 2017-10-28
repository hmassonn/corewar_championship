using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique.Parameters
{
    public abstract class Param
    {
        public int weight_P { get; private set; }
        public string type_P { get; private set; }

        public Param ()
        {

        }


    }
}
