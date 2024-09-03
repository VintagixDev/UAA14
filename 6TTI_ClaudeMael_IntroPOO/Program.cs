using System.Diagnostics;
using System.Text;

namespace _6TTI_ClaudeMael_IntroPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Chien chien = new Chien(3, "Yuki", "Samoyède", 5, 2, "caca", false);
                Console.WriteLine("1: Manger\n" +
                    "2: Boire\n" +
                    "3: Vieillir\n" +
                    "4: Se blesser\n" +
                    "5: FaireSesBesoin\n" +
                    "6: Mourir");
            do
            {






                string nUser;
                int input;
                do
                {

                    nUser = Console.ReadLine();
                } while (!int.TryParse(nUser, out input));


                switch (input)
                {
                    case 1:
                        Console.WriteLine(chien.Manger());
                        break;
                    case 2:
                        Console.WriteLine(chien.Boire());
                        break;
                    case 3:
                        Console.WriteLine("Le chien avait " + chien.getAge() + " ans");
                        chien.Vieillir();
                        Console.WriteLine("Il a maintenant " + chien.getAge() + " ans");


                        break;
                    case 4:
                        Console.WriteLine(chien.SeBlesser());
                        break;
                    case 5:
                        Console.WriteLine(chien.FaireSesBesoins());
                        break;
                    case 6:

                        Console.WriteLine(chien.Mourir());
                        break;
                    default: break;
                }
            } while (true);

        }

    }
}