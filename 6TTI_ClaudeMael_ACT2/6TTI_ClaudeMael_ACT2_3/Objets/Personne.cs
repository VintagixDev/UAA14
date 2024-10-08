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

        public string Verser(Personne person, double montant)
        {
            if(montant > _argent)
            {
                return "Vous n'avez pas assez sur votre compte pour effectuer cette transaction.";
            }

            person._argent += montant;
            _argent -= montant;
            return "Ajout effectué !";
        }

        public string Ajoute(double montant)
        {
            _argent += montant;
            return "Vous avez ajouté " + montant + "€ au compte de " + _nom + ". Cette personne a maintenant " + _argent + "€.";
        }

        public string AfficheInfos()
        {
            return _nom + " a " + _argent + "€ dans son porte monnaie.";
        }
    }
}
