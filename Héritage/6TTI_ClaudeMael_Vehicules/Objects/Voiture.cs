using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Vehicules.Objects
{
    internal class Voiture : Vehicule
    {

        private string _motorisation;
        private bool _gps;

        public string Motorisation
        {
            get { return _motorisation; }

        }

        public bool Gps
        {
            get { return _gps; }
        }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base (modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public override string Affiche()
        {
            return "Modèle : " + _modele + "\nMarque : " + _marque + "\nCouleur : " + _couleur + "\nPrix : " + _prix + "\nMotorisation : " + _motorisation + "\nGPS : " + _gps;
        }
    }
}
