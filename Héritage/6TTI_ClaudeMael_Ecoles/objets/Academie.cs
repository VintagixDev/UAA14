using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets
{
    internal class Academie
    {

        private string _nom;
        private List<Ecole> _listeEcoles;

        public string Nom { get { return _nom; } }
        public List<Ecole> ListeEcole { get { return _listeEcoles; } set { _listeEcoles = value; } }

        public Academie(string nom)
        {
            _nom = nom;
        }


        public void AjouterEcole(Ecole ecole)
        {
            _listeEcoles.Add(ecole);
        }

        public string AfficherEcoles()
        {
            string msg = "";
            foreach(Ecole ecole in _listeEcoles)
            {
                msg += ecole.CodeEcole + " | " + ecole.Site +"\n";
            }
            return msg;
        }
    }
}
