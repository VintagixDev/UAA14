using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _6TTI_ClaudeMael_ACT3
{

    public struct Methodes
    {
        

        public void ResoudreTrinome(double a, double b, double c, out string type)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                type = "Il n'y a pas de résultat";
            }
            else if (delta == 0)
            {

                double x1 = -b / (2 * a);
                type = "Le résultat est " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                type = "Les résultats sont " + x1 + " et " + x2;
            }

            
            
        }
    }
}
