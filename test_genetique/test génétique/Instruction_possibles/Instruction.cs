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
        public List<Parameter> parameters { get; set; }

        public int weight_I { get; private set; }

        public string red_code = "d";

        public Instruction (List<Parameter> parameters = null)
        {
            this.parameters = parameters;
        }

        public virtual string toString()
        {
            string res = red_code + " ";

            foreach(Parameter parameter in parameters)
            {
                res+= parameter.toString()+", ";
            }

            res = res.Substring(0, res.Length-2); //TODO :: vérifier si la taille est OK

            return res;
        }
    }
}
