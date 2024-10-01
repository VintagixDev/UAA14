using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_ACT2_3.Objets
{
    internal class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double Rayon
        {
            get { return _rayon; }

        }

        public double CalculeAire()
        {
            return Math.PI * _rayon * _rayon;

        }

        public double CalculePerimetre()
        {
            return 2 * Math.PI * _rayon;
        }


    }
}
