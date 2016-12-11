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
    }
}
