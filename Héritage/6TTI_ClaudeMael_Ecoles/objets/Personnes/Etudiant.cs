using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets.Personnes
{
    internal class Etudiant : Personne
    {

        private int _anneeEntree;
        private List<InfoCours> _listeCours;

        public int AnneeEntree { get { return _anneeEntree; } }

        public List<InfoCours> ListeCours { get { return _listeCours; } set { _listeCours = value; } }

        public Etudiant(string nom, string prenom, string email, string telephone, int anneeEntree, List<InfoCours> listeCours) : base(nom, prenom, email, telephone)
        {

            _anneeEntree = anneeEntree;
            ListeCours = listeCours;
        }


        public double CalculerMoyenneGenerale()
        {
            double note = 0;
            foreach (InfoCours infos in ListeCours)
            {
                note += infos.note;
            }
            return note / ListeCours.Count;
        }


        public string AfficherMatiereNotees()
        {

            return "";
        }

        public override string Infos()
        {
            return "Nom: " + _nom +
               "\nPrénom: " + _prenom +
               "\nEmail: " + _email +
               "\nTéléphone: " + _telephone +
               "\nAnnée d'entrée: " + _anneeEntree;


        }


    }
}
