﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique.Instruction_possibles
{
    public class Instruction
    {
        public string type_I { get; private set; }
        public List <Param> para_possible { get; protected set; }
        public int weight_I { get; private set; }
        public string red_code { get; protected set; }
        public List<Data> data { get; protected set; }


        public Instruction ()
        {
            this.para_possible = new List<Param>();

        }



    }
}
