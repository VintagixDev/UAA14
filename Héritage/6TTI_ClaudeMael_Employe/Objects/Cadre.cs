using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Employe.Objects
{
    internal class Cadre : Employe
    {
        private int _indice;

        public int Indice { get { return _indice; } }
    
        public Cadre(int indice, string matricule, string nom, string prenom, string birthdate) : base(matricule, nom, prenom, birthdate)
        {
            _indice = indice;
            switch (indice)
            {
                case 1:
                    _salary = 13000;
                    break;
                case 2:
                    _salary = 15000;
                    break;
                case 3:
                    _salary = 17000;
                    break;
                case 4:
                    _salary = 20000;
                    break;
                default: break;
            }
        }
    
    }
}
