using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_génétique
{
    public class Field
    {
        public List<string> Instruction { get; private set; }
        public List<string> Parameters { get; private set; }

        public int Min { get; private set; }
        public int Max { get; private set; }

        public Field (List<string> instruction, List<string> parameters, int min, int max)
        {
            this.Instruction = instruction;
            this.Parameters = parameters;
            this.Min = min;
            this.Max = max;
            this.Instruction = instruction;
            this.Parameters = parameters;
            fill_instruction();
            fill_parameters();
        }



        public void fill_instruction()
        {
            Instruction.Add("waiting'");

            
        }

        public void fill_parameters()
        {
            Parameters.Add("waiting");

        }


    }
}
