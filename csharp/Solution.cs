using System;
using System.Collections.Generic;
namespace test_genetique
{ 
    public class Solution : IComparable
    {
        // public double X { get; private set; }
        // public double Y { get; private set; }
        // public ID Id { get; private set; }
        // public int Nb_succes { get; private set; } 


        //          edit
        public string Code { get; private set; }
        //          edit


        // public Solution(double x, double y, ID id)
        public Solution()
        {
            // this.X = x;
            // this.X = y;
            // this.Id = id;
            this.Code = "";

            Exemple_ecris_en_red_code();
            printf(this.Code);
        }
           
        // public int CompareTo(object obj)
        // {
        //     if (this.Nb_succes < (obj as Solution).Nb_succes)
        //         return -1;
        //     if (this.Nb_succes > (obj as Solution).Nb_succes)
        //         return 1;
        //     return 0;
        // }


        //       edit
        //      on cree le red code
        public void Exemple_ecris_en_red_code()
        {
            while (Ending(this.Code))
            {
                Add_code();
            }
        }

        // si le champion est asser grand on renvoi 1
        public int Ending()
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
        // public string Param(int possibles)
        // {
        //     if possibles
        // }

        // les ordres
        public string ft_live()
        {
            return "live: %1\n";
        }

        // public string ft_ld()
        // {
        //     return "ld: ";
        // }
        //       edit


    }
}
