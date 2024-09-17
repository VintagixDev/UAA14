using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_POO_ACT1
{
    internal class Interrupteur
    {

        private string _code;
        public Interrupteur(string code)
        {
            _code = code;
        }


        public string Code
        {
            get{ return _code; }
           
        }

        public string Allumer(Lampe lampe)
        {
            lampe.State = true; 
            return "La lampe est maintenant allumée";
        }

        public string Eteindre(Lampe lampe)
        {
            lampe.State = false;
            return "La lampe est maintenant éteinte";
        }
    }
}
