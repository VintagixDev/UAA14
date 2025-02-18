using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets.Personnes
{
    internal class Enseignant : Personne
    {

        private DateTime _datePriseFonction;
        private string _matiere;
        private List<Cours> _listeCours;

        public Enseignant(string nom, string prenom, string email, string telephone, DateTime datePriseFonction, string matiere, List<Cours> listeCours) : base(nom, prenom, email, telephone)
        {
            _datePriseFonction = datePriseFonction;
            _matiere = matiere;
            _listeCours = listeCours;
        }

        public void AjouterCours(Cours cours)
        {
            _listeCours.Add(cours);
        }

        public override string Infos()
        {
            return "Nom: " + _nom +
               "\nPrénom: " + _prenom +
               "\nEmail: " + _email +
               "\nTéléphone: " + _telephone +
               "\nPrise de fonction: " + _datePriseFonction;
        }
    }
}
