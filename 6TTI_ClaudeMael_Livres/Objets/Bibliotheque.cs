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

        public List<Livre> Livres { get { return _livres; } set { _livres = value; } }

        public Bibliotheque()
        {
            _livres = new List<Livre>();
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
            string inv = "";
            foreach(Livre livre in _livres)
            {
                inv += "Titre: " + livre.Titre + "\nAuteur:" + livre.Auteur + "\nEtat: " + livre.Etat + "\n------------------------\n";
            }
            return inv;
        }

    }
}
