using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets
{
    internal class Ecole
    {

        private string _codeEcole;
        private string _siteInternet;
        private List<Salle> _listeSalles;
        private List<Departement> _listeDepartements;

        public string CodeEcole { get { return _codeEcole; } }

        public string Site { get { return _siteInternet; } set { _siteInternet = value; } }
        public List<Salle> ListeSalles { get { return _listeSalles; } set { _listeSalles = value; } }

        public List<Departement> ListeDepartements { get { return _listeDepartements; } set { _listeDepartements = value; } }

        public Ecole(string codeEcole, string siteInternet, List<Salle> listeSalles, List<Departement> listeDepartements)
        {
            _codeEcole = codeEcole;
            _siteInternet = siteInternet;
            ListeSalles = listeSalles;
            ListeDepartements = listeDepartements;

        }


        public void AjouterDepartement(Departement departement)
        {
            _listeDepartements.Add(departement);
        }

        public string AfficherDepartements()
        {
            string msg = "";
            foreach (Departement departement in ListeDepartements)
            {
                msg += departement.Nom + "\n";
            }
            return msg;
        }
    }
}
