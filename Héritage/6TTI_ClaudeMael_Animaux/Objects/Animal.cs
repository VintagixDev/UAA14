using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Animaux.Objects
{
    internal class Animal
    {

        protected string _nom;
        protected string _naissance;
        protected int _puce;
        protected double _taille;
        protected bool _concours;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public string Naissance { get { return _naissance; } }
        public int Puce { get { return _puce; } }
        public double Taille { get { return _taille; } set { _taille = value; } }
        public bool Concours { get { return _concours; } set { _concours = value; } }


        public Animal(string nom, string naissance, int puce, double taille, bool concours)
        {
            _nom = nom;
            _naissance = naissance;
            _puce = puce;
            _taille = taille;
            _concours = concours;   
        }

        public string Dormir()
        {
            return _nom + " s'endors...";
        }

        public virtual string Manger()
        {
            return _nom + " mange...";
        }

    }
}
