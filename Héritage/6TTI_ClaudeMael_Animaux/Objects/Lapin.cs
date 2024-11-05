using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Animaux.Objects
{
    internal class Lapin : Animal
    {

        private double _oreilleTaille;
        
        public double OreilleTaille { get { return _oreilleTaille; } set { _oreilleTaille = value;} }

        public Lapin(double oreilleTaille, string nom, string naissance, int puce, double taille, bool concours) : base(nom, naissance, puce, taille, concours)
        {
            _oreilleTaille = oreilleTaille;
        }

        public string FaireBonds()
        {
            return _nom + " fait des bonds";
        }

    }
}
