﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Instruction_possibles;

namespace test_génétique
{
    public class Field
    {
        public List<Instruction> Instruction { get; private set; }
        public List<string> Parameters { get; private set; }

        public int Min { get; private set; }
        public int Max { get; private set; }

        public Field (List<Instruction> instruction, List<string> parameters, int min, int max)
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
         

            
        }

        public void fill_parameters()
        {
            Parameters.Add("waiting");

        }


    }
}
