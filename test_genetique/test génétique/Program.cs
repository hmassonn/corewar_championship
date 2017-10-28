using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using test_génétique.Instruction_possibles;
using test_génétique.Parameters;

namespace test_génétique
{
    class Program
    {
        static void Main(string[] args)
        {
            // rates are to be optimyze latter on
            double selection_rate = 0.5;
            double hybridation_rate = 2;
            double mutation_rate = 0.01;

            int begining_pop = 100;
            int nb_generation = 300;

            readFile();

            //Console.ReadKey();
            /*Field range = new Field(10, 20);
            Randomyzer randomyse = new Randomyzer(range);
            Factory facto = new Factory(randomyse);
            Genetics Darwin = new Genetics(randomyse, facto, range, nb_generation, begining_pop, hybridation_rate, mutation_rate, selection_rate);

            Champion Champ = Darwin.Run_genetics();*/
          
        }

        public static void readFile()
        {
            int width = 0;

            string path = @"D:\Hugo\corewar_championship\ressources\champstest\Asombra.cor.dmp";

            // Init str_instruction list
            List<Instruction> listInstructions = new List<Instruction>();

            //System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(@path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                // If it's a comment line then go to the next one
                if (line[0] == '.' || line== "" ) //TODO pensser a ignorer les lignes vides
                    continue;

                // clean the line
                line = line.Replace("\t", "");

                // Separate the str_instruction from the str_parameters.Split(',');
                string str_instruction = line.Substring(0, line.IndexOf(' '));
                string str_parameters = line.Substring(line.IndexOf(' '), line.Length- line.IndexOf(' '));

                // Init param list
                List<Parameter> listParameters = new List<Parameter>();

                // Separate each param (separated by ',')
                foreach (string str_parameter in str_parameters.Split(','))
                {
                    string str_parameter_ = str_parameter.Replace(" ", "");
                   
                    // Define str_parameter_'s value
                    string parameter_value = str_parameter_.Replace("%", "");
                    parameter_value = parameter_value.Replace("r", "");
                    

                    Parameter parameter;
                    // Define str_parameter_'s type
                    if (str_parameter_.IndexOf('%') > -1)
                        parameter = new Direct(parameter_value);
                    else if (str_parameter_.IndexOf('r') > -1)
                        parameter = new Registre(parameter_value);
                    else
                        parameter = new Indirect(parameter_value);

                    parameter.value = parameter_value;
                    listParameters.Add(parameter);
                }
                listInstructions.Add(new Instruction(listParameters));
                width++;
            }


            Champion champion = new Champion(listInstructions);

            file.Close();

            

        }
    }

}
