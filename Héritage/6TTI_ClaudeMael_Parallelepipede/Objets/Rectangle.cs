using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Parallelepipede.Objets
{
    internal class Rectangle : Parallelepipede
    {

        private double _longueur;
        private double _largeur;

        public double Longueur { get { return _longueur; } }
        public double Largeur { get { return _largeur; } }

        public Rectangle(double longueur, double largeur, string couleur) : base(couleur)
        {
            _longueur = longueur;
            _largeur = largeur;
        }


        public override string CalculeSurface()
        {
            return "La surface de ce rectangle est " + _longueur * _largeur;
        }
        public override string CalculePerimetre()
        {
            return "Le périmètre de ce rectangle est " + (_longueur * _largeur) * 2;
        }

        

    }
}
