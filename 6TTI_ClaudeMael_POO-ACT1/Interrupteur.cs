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


        public string getCode()
        {
            return _code;
        }
    }
}
