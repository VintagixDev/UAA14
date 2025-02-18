using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets
{
    internal class Salle
    {

        private string _nom;
        private int _nombrePlaces;

        public string Nom { get { return Nom; } }
        public int NombrePlaces { get { return NombrePlaces; } set { _nombrePlaces = value; } }

        public Salle(string nom, int nombrePlace) 
        {
            _nom = nom;
            _nombrePlaces = nombrePlace;
        }

        public string Infos()
        {
            return "Nom: " + _nom +
                "\nNombre de places: " + _nombrePlaces;
        }
    }
}
