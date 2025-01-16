using _6TTI_ClaudeMael_Livres_2.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Livres.Objets
{
    internal class Bibliotheque
    {

        private List<Livre> _livres;
        private List<Emprunt> _emprunts;
        public List<Livre> Livres { get { return _livres; } set { _livres = value; } }
        public List<Emprunt> Emprunts { get { return _emprunts; } set { _emprunts = value; } }
        public Bibliotheque()
        {
            _livres = new List<Livre>();
            _emprunts = new List<Emprunt>();
        }

        public string Ajoute(Livre livre)
        {
            _livres.Add(livre);
            return livre.Titre + " a été ajouté à la bibliothèque";
        }

        public string SupprimeLivreAbime()
        {
            _livres.RemoveAll((livre) => livre.Etat == 0);
            return "Les livres abimés ont été enlevés de la bibliothèque";
        }

        public string Inventaire()
        {
            string inv = "\nListe des livres:\n\n";
            foreach(Livre livre in _livres)
            {
                inv += "Titre: " + livre.Titre + "\nAuteur:" + livre.Auteur + "\nEtat: " + livre.Etat + "\n------------------------\n";
            }
            return inv;
        }

        public Emprunt Emprunte(Livre livre, Personne personne )
        {
            Emprunt emprunt = new Emprunt(livre, personne);
            personne.Emprunts.Add(emprunt);
            _emprunts.Add(emprunt);
             Console.WriteLine("livre emprunté");
            return emprunt;
        }

        public string Rendre(Emprunt emprunt)
        {
            emprunt.Personne.Emprunts.Remove(emprunt);
            _emprunts.Remove(emprunt);
            emprunt = null;
            return "le livre a été rendu";
        }

        public string ListeEmprunts()
        {
            string inv = "\nListe emprunts:\n";
            foreach (Emprunt emprunt in _emprunts)
            {
                inv += "Titre: " + emprunt.Livre.Titre + "\nDate: " + emprunt.Time + "\nPersonne: "+ emprunt.Personne.Nom + "\n------------------------\n";
            }
            return inv;
        }

    }
}
