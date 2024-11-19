using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Parallelepipede.Objets
{
    internal class Parallelepipede
    {
        protected string _couleur;

        public string Couleur { get { return _couleur; } }

        public Parallelepipede(string couleur)
        {
            _couleur = couleur;
        }

        public virtual string CalculeSurface()
        {
            return "";
        }

        public virtual string CalculePerimetre()
        {
            return "";
        }
    }
}
