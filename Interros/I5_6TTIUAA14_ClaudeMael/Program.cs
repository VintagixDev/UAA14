using I5_6TTIUAA14_ClaudeMael.Objets;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace I5_6TTIUAA14_ClaudeMael
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<PaintBallGun> paintBallGuns = new List<PaintBallGun>();
            for(int i = 0; i < 20; i++)
            {
                paintBallGuns.Add(new PaintBallGun());
            }
            Joueur joueur = new Joueur("Maël", paintBallGuns.Last()); // Prendre la dernière arme de la liste
            paintBallGuns.RemoveAt(paintBallGuns.Count-1); // Supprimer la dernière arme de la liste

          

            Console.WriteLine("Bienvenue dans ce jeu de tire... Vous démarrez avec 30 cartouches en poche." +
            "\n=====================================================");
            bool repeatProg = true;
            string nUser;
            do
            {
                Console.WriteLine(AfficherMenu());
                nUser = Console.ReadLine();
                Console.Clear();
                switch (nUser)
                {
                    case " ": // Tirer
                        Console.WriteLine(joueur.Tire());
                        break;
                    case "r": // Recharger
                        Console.WriteLine(joueur.Recharge());
                        break;
                    case "v": // Voir les poches
                        Console.WriteLine(joueur.VerifiePoche());
                        break;
                    case "+": // Reprendre des cartouches
                        Console.WriteLine(joueur.ReprendreCartouches());
                        break;
                    case "q": // Quitter le programme
                        repeatProg = false;
                        break;
                    default:
                        break;
                }
            } while (repeatProg == true);

        }

        /// <summary>
        /// Afficher le menu du jeu
        /// </summary>
        /// <returns></returns>
        static string AfficherMenu()
        {
            return 
                "\n\nEspace pour tirer," +
                "\nr pour recharger," +
                "\nv pour voir combien il reste de munitions en poche et dans le chargeur," +
                "\n+ pour reprendre des munitions," +
                "\nq pour quitter" +
                "\n\n--->";
        }
    }
}