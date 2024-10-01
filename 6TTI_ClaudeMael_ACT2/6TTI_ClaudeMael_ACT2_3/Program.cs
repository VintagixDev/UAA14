using _6TTI_ClaudeMael_ACT2_3.Objets;
using System.Numerics;

namespace _6TTI_ClaudeMael_ACT2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeatProg;
            string nUser;
            double reel;
            double imaginaire;
            double reelSecondaire;
            double imaginaireSecondaire;
            SandwichMaker SM = new SandwichMaker();

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans le programme ! \n\n1 = Cercle\n2 = Complexe\n3 = Sandwich");


                switch (Console.ReadKey().Key)
                {

                    // CERCLE
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        double rayon;
                        do
                        {
                            Console.WriteLine("Veuillez entrer le rayon du cercle.");
                            nUser = Console.ReadLine();
                        } while (!double.TryParse(nUser, out rayon));

                        Cercle cercle = new Cercle(rayon);

                        Console.WriteLine("Le cercle de rayon " + cercle.Rayon + " a un périmètre de " + cercle.CalculePerimetre().ToString("F") + " et une aire de " + cercle.CalculeAire().ToString("F"));
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Avec un cercle de rayon diminué de moitié :");
                        Cercle cercle2 = new Cercle(rayon / 2);
                        Console.WriteLine("Le cercle de rayon " + cercle2.Rayon + " a un périmètre de " + cercle2.CalculePerimetre().ToString("F") + " et une aire de " + cercle2.CalculeAire().ToString("F"));
                        break;


                    // COMPLEXE
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        LireDouble("Que vaut la partie réelle du complexe de départ ?", out reel);
                        LireDouble("Que vaut la partie complexe du complexe de départ ?", out imaginaire);

                        Complexe complexe = new Complexe(reel, imaginaire);
                        Console.WriteLine("Le premier complexe : " + complexe.AfficheComplexe() + " a pour module : " + complexe.CalculeModule().ToString("F"));
                        Console.WriteLine("\nEncodez un second nombre complexe:");

                        LireDouble("Que vaut la partie réelle du second complexe  ?", out reelSecondaire);
                        LireDouble("Que vaut la partie complexe du second complexe ", out imaginaireSecondaire);
                        Complexe complexeSecondaire = new Complexe(reelSecondaire, imaginaireSecondaire);
                        Console.WriteLine("Le second complexe est : " + complexeSecondaire.AfficheComplexe());

                        complexe.Ajoute(complexeSecondaire);
                        Console.WriteLine("Le premier complexe devient : " + complexe.AfficheComplexe() + " après l'ajout du second");

                        break;

                    // SANDWICH
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine(SM.composeSandwich());
                        break;
                    
                    // PERSONNE
                    case ConsoleKey.NumPad4:

                    default:
                        break;
                }

               
                Console.WriteLine("\nAppuyez sur Espace continuer, appuyez sur une autre touche pour arrêter");
                repeatProg = Console.ReadLine();
                

            } while (repeatProg == " ");

        }

        static void LireDouble(string question, out double value)
        {
            string nUser;
            do
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            } while (!double.TryParse(nUser, out value));
        }
    }
}