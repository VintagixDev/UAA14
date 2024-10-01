using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_ACT2_3.Objets
{


    internal class Personne
    {

        private string _nom;
        private double _argent;

        public Personne(string nom, double argent)
        {
            _nom = nom;
            _argent = argent;
        }


        public string Nom
        {
            get { return _nom; }
        }
        public double Argent
        {
            get { return _argent; }
            set { _argent = value; }
        }
    }
}
