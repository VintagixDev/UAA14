using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Animaux.Objects
{
    internal class Chat : Animal
    {
        public Chat(string nom, string naissance, int puce, double taille, bool concours) : base(nom, naissance, puce, taille, concours)
        {

        }

        public string Miauler()
        {
            return _nom + " miaule";
        }
        public string Ronronner()
        {
            return _nom + " ronronne";
        }

        public override string Manger()
        {
            return _nom + " mange des croquettes";
        }
    }
}
