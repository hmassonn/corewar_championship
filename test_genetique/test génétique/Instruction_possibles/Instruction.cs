using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_génétique.Parameters;

namespace test_génétique
{
    public class Instruction
    {
        //public string type_I { get; private set; }
        public List <Parameter> para_possible { get; protected set; }
        public List<Parameter> parameters { get; protected set; }

        public int weight_I { get; private set; }

        public string red_code { get; protected set; }

        public const string RED_CODE = "default";

        public Instruction (List<Parameter> parameters)
        {
            this.parameters = parameters;
        }

        public string toString()
        {
            string res = this.RED_CODE +" ";

            foreach(Parameter parameter in parameters)
            {
                res+= parameter.toString()+", ";
            }

            res = res.Substring(0, res.length-2); //TODO :: vérifier si la taille est OK
        }
    }
}
