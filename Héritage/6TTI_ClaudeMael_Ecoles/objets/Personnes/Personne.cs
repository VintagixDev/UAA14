using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ecoles.objets.Personnes
{
    internal class Personne
    {

        protected string _nom;
        protected string _prenom;
        protected string _email;
        protected string _telephone;

        public Personne(string nom, string prenom, string email, string telephone)
        {
            _nom = nom;
            _prenom = prenom;
            _email = email;
            _telephone = telephone;
        }


        public virtual string Infos()
        {
            return "Nom: " + _nom +
                "\nPrénom: " + _prenom +
                "\nEmail: " + _email +
                "\nTéléphone: " + _telephone;
        }

    }
}
