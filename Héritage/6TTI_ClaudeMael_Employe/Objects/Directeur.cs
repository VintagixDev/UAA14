using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Employe.Objects
{
    internal class Directeur : Employe
    {

        private int _percentage;

        public int Percentage { get { return _percentage; } }

        public Directeur(int percentage, double chiffreAffaire, string matricule, string nom, string prenom, string birthdate) : base(matricule, nom, prenom, birthdate)
        {
            _percentage = percentage;
            _salary = chiffreAffaire * (percentage/100);
        }

    }
}
