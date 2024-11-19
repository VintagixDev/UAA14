using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Employe.Objects
{
    internal class Ouvrier : Employe
    {

        private string _entryDate;

        public string EntryDate { get { return _entryDate; } }

        public Ouvrier(string entryDate, string matricule, string nom, string prenom, string birthdate, double salary) : base(matricule, nom, prenom, birthdate)
        {
            _entryDate = entryDate;
            _salary = salary;
        }


    }
}
