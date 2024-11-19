using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Employe.Objects
{
    internal class Employe
    {

        protected string _matricule;
        protected string _nom;
        protected string _prenom;
        protected string _birthdate;

        protected double _salary;

        public string Matricule { get { return _matricule; } set {  _matricule = value; } }
        public string Nom { get { return _nom; } }
        public string Prenom { get { return _prenom; } }
        public string Birthdate { get { return _birthdate; } }

        public double Salary { get { return _salary; } set { _salary = value; } }

        public Employe(string matricule, string nom, string prenom, string birthdate)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _birthdate = birthdate;
        }

        public string Afficher()
        {
            return "Matricule : " + _matricule +
                "\nNom Prénom : " + _nom + " " + _prenom + "" +
                "\nDate de naissance : " + _birthdate +
                "\nSalaire : " + _salary +
                "\n------------------------------------------";
        }

    }
}
