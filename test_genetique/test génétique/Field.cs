using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public class Field
    {
        
        public int Min { get; private set; }
        public int Max { get; private set; }

        public Field (int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}
