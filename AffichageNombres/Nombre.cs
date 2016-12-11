using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffichageNombres
{
    public class Nombre
    {

        public String trois { get; set; }
        public String cinq { get; set; }
        public String sept { get; set; }
        String nombre = "";

        public Nombre()
        {
            this.trois = "Foo";
            this.cinq = "Bar";
            this.sept = "Qix";

        }

        /// <summary>
        ///methode qui retourne true si un nombre val et divisible par un nombre div
        /// </summary>
        /// <param name="val">nombre qu'on veut diviser</param>
        /// <param name="div">diviseur</param>
        /// <returns>true ou false</returns>
        public Boolean SimpleDiv(int val, int div)
        {
            return val % div == 0;
        }



        /// <summary>
        /// methode qui retourne l'quivalent d'un chiffre soit Foo ,soit Bar ,soit Qix en fonction du parametre val
        /// </summary>
        /// <param name="val"></param>
        /// <returns>chaine de caractére</returns>
        public String chek(int val)
        {
            if (val == 3) return "Foo";
            if (val == 5) return "Bar";
            if (val == 7) return "Qix";
            return "";
        }
        /// <summary>
        /// une methode qui retourne la transofrmation d'un chiffre s'il est divisible par 3 et(ou) 5 et(ou) 7
        /// en tenant compte de l'ordre de divisibilité 3,5 et7
        /// </summary>
        /// <param name="val">le nombre à evalué</param>
        /// <returns>chaine de caractére </returns>
        /// 
        public String divisibilité(int val)
        {
            Boolean exist = false;

            this.nombre = "";
            int[] T = new int[3] { 3, 5, 7 };
            Boolean[] TMP = new Boolean[3] { false, false, false };

            for (int i = 0; i < T.Length && !TMP[i]; i++)
            {
                if (SimpleDiv(val, T[i]))
                {
                    exist = true;
                    TMP[i] = true;
                    nombre += chek(T[i]);
                    for (int j = 0; j < T.Length; j++)
                    {
                        if (i != j)
                        {
                            if (SimpleDiv(val, T[j]))
                            {

                                nombre += chek(T[j]);
                                TMP[j] = true;
                            }

                        }
                    }

                }

            }
            if (!exist)
            {
                nombre += val;
            }
            return nombre;
        }


        /// <summary>
        /// methode qui retorune la transformation d'un nombre : si le chiffre contient l'une des valeur suivantes:
        /// 3,5,7 donc on affiche respectivement Foo,Bar,Qix.
        /// </summary>
        /// <param name="val">le nombre à evaluer</param>
        /// <returns>chaine de caractére</returns>
        public String Contenu(int val)
        {

            this.nombre = "";
            String Nbr = val + "";

            char[] T = Nbr.ToCharArray();

            foreach (var item in T)
            {

                if (item == '3') { nombre += this.trois; }
                if (item == '5') { nombre += this.cinq; }
                if (item == '7') { nombre += this.sept; }
            }

            return nombre;
        }

        /// <summary>
        /// cette methode permet de tester la divisibilité d'un nombre par 3 ,5 ,7 tout d'abord 
        /// puis elle verifie le contenu de ce nombre 
        /// </summary>
        /// <param name="val">le nombre à evaluer</param>
        /// <returns>chaine de caractere </returns>
        /// 
        public String DivisibilitePuisContenu(int val)
        {
            String Chaine = this.divisibilité(val);
            String chaine2 = this.Contenu(val);

            int n;
            if (int.TryParse(Chaine, out n))
            {
                if (!chaine2.Equals(""))
                {
                    return chaine2;
                }
                else
                {
                    return Chaine;
                }
            }


            return Chaine + chaine2;
        }

        /// <summary>
        /// methode qui permet d'afficher les 100 premier nombre de 
        /// 1 à 100
        /// </summary>
        public void Affichage(int val)
        {
            int i = 1;
            while (i < val)
            {
                Console.WriteLine(DivisibilitePuisContenu(i));
                i++;
            }
        }
    }
}
