using _6TTI_ClaudeMael_Ecoles.objets.Personnes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets
{
    internal class Departement
    {

        private string _nom;
        private string _matiere;
        private List<Personnes.Enseignant> _listeEnseignants;

        public string Nom { get { return _nom; } }
        public string Matiere { get { return _matiere; } }
        public List<Personnes.Enseignant> ListeEnseignants { get { return _listeEnseignants; } set { _listeEnseignants = value; } }


        public Departement(string nom, string matiere)
        {
            _nom = nom;
            _matiere = matiere;
            _listeEnseignants = new List<Personnes.Enseignant>();
        }

        public void AjouterEnseignant(Enseignant enseignant)
        {
            _listeEnseignants.Add(enseignant);
        }
    }
}
