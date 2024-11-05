using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Vehicules.Objects
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _estElectrique;

        public string Type { get { return _type; } }
        public bool EstElectrique { get { return _estElectrique; } }

        public Velo(string type, bool estElectrique, string modele, string marque, string couleur, decimal prix) : base (modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

        public override string Affiche()
        {
            return "Modèle : " + _modele + "\nMarque : " + _marque + "\nCouleur : " + _couleur + "\nPrix : " + _prix + "\nType : " + _type + "\nElectrique : " + _estElectrique;
        }
    }
}
