using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Animaux.Objects
{
    internal class Chien : Animal
    {

        public Chien(string nom, string naissance, int puce, double taille, bool concours) : base(nom, naissance, puce, taille, concours)
        {
            
        }

        public string Aboyer()
        {
            return _nom + " aboie";
        }

    }
}
