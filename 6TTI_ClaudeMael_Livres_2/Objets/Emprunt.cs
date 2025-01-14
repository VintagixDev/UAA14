using _6TTI_ClaudeMael_Livres.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Livres_2.Objets
{
    internal class Emprunt
    {

        private Livre _livre;
        private DateTime _time;
        private Personne _personne;

        public Livre Livre { get { return _livre; } }
        public DateTime Time { get { return _time; } }
        public Personne Personne { get { return _personne; } }

        public Emprunt(Livre livre, Personne personne)
        {
            _livre = livre;
            _time = DateTime.Now;
            _personne = personne;
        }

        public string Description()
        {
            return _personne.Nom + " a emprunté le livre " + _livre.Titre + " le " + _time;
        }

    }
}
