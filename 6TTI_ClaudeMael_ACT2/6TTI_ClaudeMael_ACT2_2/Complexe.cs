using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_ACT2_2
{
    internal class Complexe
    {

        private double _reel;
        private double _imaginaire;
        public Complexe(double reel, double imaginaire)
        {
            _reel = reel;
            _imaginaire = imaginaire;
        }

        public double Reel
        {
            get { return _reel; } 
            set { _reel = value; }
        }

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }

        public string AfficheComplexe()
        {
            return "("+ _reel + ", "+ _imaginaire + ")";
        }

        public double CalculeModule()
        {
            return Math.Sqrt(Math.Pow(_reel, 2) + Math.Pow(_imaginaire, 2));
        }

        public void Ajoute(Complexe complexe)
        {
            _reel += complexe._reel;
            _imaginaire += complexe._imaginaire;
        }

    }
}
