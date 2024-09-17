using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_POO_ACT1
{
    public struct Methodes
    {
        public void CreerLampe()
        {
            Console.Clear();
            Console.WriteLine("Entrez le code de la lampe (ex: A1, A2, B1...)");
            string code = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Entrez la couleur de la lampe");
            string color = Console.ReadLine();

            Lampe lampe = new Lampe(code, color);
            Console.WriteLine("Lampe créée.");

        }

        public void CreerInterrupteur()
        {
            Console.Clear();
            Console.WriteLine("Entrez le code de l'interrupteur (ex: A1, A2, B1...)");
            string code = Console.ReadLine();

            

            Interrupteur interrupteur = new Interrupteur(code);
            
        }

        public void UtiliserInterrupteur()
        {
            Console.Clear();
            Console.WriteLine("Veuillez entrer le code de l'interrupteur");
            string code = Console.ReadLine();


            

        }
    }
}
