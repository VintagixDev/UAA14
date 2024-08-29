using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_Ex2
{
    public struct Methodes
    {
        public void LireDouble(int i, out double x)
        {
            string nUser;
            do
            {
                Console.WriteLine("nombre n°"+i);
                nUser = Console.ReadLine();
            } while (!double.TryParse(nUser, out x));
        }

        public void CustomConsole(ConsoleColor bgColor, ConsoleColor textColor)
        {
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = textColor;
        
        }
    }
}
