using _6TTI_ClaudeMael_Livres.Objets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Livres_2.Objets
{
    internal class Personne
    {

        private string _nom;
        private string _prenom;
        private List<Emprunt> _emprunts;

        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }
        public List<Emprunt> Emprunts { get { return _emprunts; } set { _emprunts = value; } }

        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
            _emprunts = new List<Emprunt>();
        }

        public string Emprunte(Livre livre, Bibliotheque biblio)
        {
            Emprunt emprunt = new Emprunt(livre, this);
            _emprunts.Add(emprunt);
            biblio.Emprunts.Add(emprunt);
            return "livre emprunté";
        }

        public string Rendre(Emprunt emprunt, Bibliotheque biblio)
        {
            _emprunts.Remove(emprunt);
            biblio.Emprunts.Remove(emprunt);
            emprunt = null;
            return "le livre a été rendu";
        }

    }
}
