using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Livres.Objets
{
    internal class Livre
    {

        private string _titre;
        private string _auteur;
        private byte _etat;

        public string Titre { get { return _titre; } }
        public string Auteur { get { return _auteur; } }

        public byte Etat { get { return _etat; } set { _etat = value; } }

        public Livre(string titre, string auteur, byte etat)
        {
            _titre = titre;
            _auteur = auteur;
            _etat = etat;
        }

        public string Degrade()
        {
            if(_etat > 0)
            {
                _etat--;
                return "le livre a été dégradé: " + _etat;
            }
            return "le livre est déjà dans un état pitoyable";

        }

        public string Description()
        {
            return "Titre: " + _titre
                + "\nAuteur: " + _auteur
                + "\nEtat: " + _etat;
        }
    }
}
