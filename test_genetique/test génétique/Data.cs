using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public struct Data
    {
        public int IntegerData { get; private set; }
        public string StringData { get; private set; }

        public Data(int intValue, string strValue)
        {
            IntegerData = intValue;
            StringData = strValue;
        }

        
    }
}
