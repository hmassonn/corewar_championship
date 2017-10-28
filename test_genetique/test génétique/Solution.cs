using System;
using System.Collections.Generic;
namespace test_génétique
{
    public class Champion : IComparable
    {
        // Hugo est un gros lard
        public double X { get; private set; }
        public double Y { get; private set; }//C'est deux la sont temporaire, c'est la que ton taf commence. Sur ce bloc il faut que tu me mette tt les variable de ton probléme d'optimisation
        //Tu peut pt méttre tes instruction en string ( juste un ID, si tu a mieux ... ben c'est mieux ^^)
        public string Code { get; private set; }
        public bool End { get; private set; }


        public List<string> Instruction { get; private set; }

        public ID Id { get; private set; } // C'est le "code bar" de la solution. ca va nous permettre de suivre les solution tt au long de l'algo


        public int Nb_succes { get; private set; }

        //Constructeur
        public Champion(double x, double y, ID id)
        {
            this.X = x;
            this.X = y;// ces deux vont virer

            this.Id = id;//Toujour le traceur de solution


            //Exemple_ecris_en_red_code();//on balance la sauce

            //Ending();
        }

        //Laisse ca pour l'instant, ca marche avec le IComparable, ca va me permetre de trier selon 14 critére facilement et rapidement sans avoir a faire un méthodes dédier. NB succes sea dasn un premier temp le nombre de victoire
        public int CompareTo(object obj)
        {
            if (this.Nb_succes < (obj as Champion).Nb_succes)
                return -1;
            if (this.Nb_succes > (obj as Champion).Nb_succes)
                return 1;
            return 0;
        }


        // Ici il faut que tu métte tt les méthode qui vont construire ta solution
        //Il faut dra que tu mette ce qui ecris en red code etc etc
        //----------------------------------------------------------------------------------------


        //voila, tu me fait ca avec a peut prés ce formalisme ( comme ca je m'y retrouve^^) je modifirais la factory, randomyser, et le génétique
        //PS: je te file la classe ID aussi, si tu veut faire des tests

        /*

           //  on cree le red code
           public void Exemple_ecris_en_red_code()
           {
               while (Ending(this.Code))
               {
                   Add_code();
               }
           }

           // si le champion est asser grand on renvoi 1
           public bool Ending()
           {
               int i = 0, nb_line = 0;

               while (this.Code[i])
               {
                   if (this.Code[i] == "\n")
                       nb_line += 1;
                   i++;
               }
               if (nb_line > 9)
                   return (0);
               return (1);
           }

           // on ajoute du code tant que le champion est trop petit
           public void Add_code()
           {
               this.Code += ft_live();
           }

           // les parametres
           public string Param(int possibles)
           {
               if possibles == 1

                   return only_direct();
               else if possibles == 2

                   return only_indirect();
               else if possibles == 3

                   return only_register();
               else if possibles == 4

                   return dir_ind();
               else if possibles == 5

                   return dir_reg();
               else if possibles == 6

                   return ind_reg();
               else if possibles == 7

                   return dir_ind_reg();
               return "error param";
           }

           public string only_direct()
           {
               valu = random(0, 4294967295);

               return valu.to_str;
           }

           public string only_indirect()
           {
               valu = random(-100, 500);

               return valu.to_str;
           }

           public string only_register()
           {
               valu = random(1, 16);

               return "r" + valu.to_str;
           }

           public string dir_ind()
           {
               return only_direct() || only_indirect();
           }

           public string dir_reg()
           {
               return only_direct() || only_register();
           }

           public string ind_reg()
           {
               return only_indirect() || only_register();
           }

           public string dir_ind_reg()
           {
               return only_direct() || only_indirect() || only_register;
           }

           // les ordres
           public string ft_live()
           {
               string str = "live: ";
               string param = add_param(1);
               str += param;
               str += "\n";

               return str;
           }

           // public string ft_ld()
           // {
           //     return "ld: ";
           // }
           //       edit


       }
       */









    }
}
