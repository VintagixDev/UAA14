using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets
{
    internal class Cours
    {

        private string _nom;
        private Salle _salle;
        private List<double> _listeNotes;

        public Cours(string nom, Salle salle)
        {
            _nom = nom;
            _salle = salle;
            _listeNotes = new List<double>();
        }


        public void AjouterNote(double note)
        {
            _listeNotes.Add(note);
        }

        public double CalculerMoyenneCours()
        {
            double numerateur = 0;
            foreach(double note in _listeNotes)
            {
                numerateur += note;
            }
            return numerateur/_listeNotes.Count;
        }

    }
}
