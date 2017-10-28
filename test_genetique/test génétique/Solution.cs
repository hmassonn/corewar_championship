using System;
using System.Collections.Generic;
namespace test_génétique
{ 
    public class Solution : IComparable
    {
        public double X { get; private set; }
        public double Y { get; private set; }//C'est deux la sont temporaire, c'est la que ton taf commence. Sur ce bloc il faut que tu me mette tt les variable de ton probléme d'optimisation
        //Tu peut pt méttre tes instruction en string ( juste un ID, si tu a mieux ... ben c'est mieux ^^)

        public ID Id { get; private set; } // C'est le "code bar" de la solution. ca va nous permettre de suivre les solution tt au long de l'algo


        public int Nb_succes { get; private set; } 

        //Constructeur
        public Solution(double x, double y, ID id)
        {
            this.X = x;
            this.X = y;// ces deux vont virer

            this.Id = id;//Toujour le traceur de solution


            Exemple_ecris_en_red_code();//on balance la sauce
        }
           
        //Laisse ca pour l'instant, ca marche avec le IComparable, ca va me permetre de trier selon 14 critére facilement et rapidement sans avoir a faire un méthodes dédier. NB succes sea dasn un premier temp le nombre de victoire
        public int CompareTo(object obj)
        {
            if (this.Nb_succes < (obj as Solution).Nb_succes)
                return -1;
            if (this.Nb_succes > (obj as Solution).Nb_succes)
                return 1;
            return 0;
        }


        // Ici il faut que tu métte tt les méthode qui vont construire ta solution
        //Il faut dra que tu mette ce qui ecris en red code etc etc
        //----------------------------------------------------------------------------------------



        public void Exemple_ecris_en_red_code()
        {
          

        }


        //voila, tu me fait ca avec a peut prés ce formalisme ( comme ca je m'y retrouve^^) je modifirais la factory, randomyser, et le génétique
        //PS: je te file la classe ID aussi, si tu veut faire des tests












    }
}
