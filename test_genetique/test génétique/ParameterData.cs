using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public struct ParameterData
    {
        public string type { get; private set; }
        public string value { get; private set; }

        public ParameterData(string type, string value)
        {
            this.type = type;
            this.value = value;
        }
    }
}
