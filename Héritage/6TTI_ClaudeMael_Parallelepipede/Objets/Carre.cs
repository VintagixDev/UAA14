using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Parallelepipede.Objets
{
    internal class Carre : Parallelepipede
    {

        private double _cote;

        public double Cote { get { return _cote; } }

        public Carre(double cote, string couleur) : base(couleur)
        {
            _cote = cote;
        }

        public override string CalculePerimetre()
        {
            return "Le périmètre de ce carré est " + 4 * _cote;
        }

        public override string CalculeSurface()
        {
            return "La surface de ce carré est " + _cote * _cote;
        }
    }
}
