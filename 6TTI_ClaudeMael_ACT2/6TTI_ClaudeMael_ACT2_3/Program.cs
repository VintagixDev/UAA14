using _6TTI_ClaudeMael_ACT2_3.Objets;
using System;
using System.Numerics;
using System.Text;

namespace _6TTI_ClaudeMael_ACT2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string repeatProg;
            string nUser;
           
            SandwichMaker SM = new SandwichMaker();

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans le programme ! \n\n1 = Cercle\n2 = Complexe\n3 = Sandwich\n4 = Porte monnaie");


                switch (Console.ReadKey().Key)
                {
                    
                    // CERCLE
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Init_Cercle();
                        break;


                    // COMPLEXE
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Init_Complexe();
                        break;

                    // SANDWICH
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine(SM.composeSandwich());
                        break;
                    
                    // PERSONNE
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Init_PersonneBanque();
                        break;
                    default:
                        break;
                }

               
                Console.WriteLine("\nAppuyez sur Espace continuer, appuyez sur une autre touche pour arrêter");
                repeatProg = Console.ReadLine();
                

            } while (repeatProg == " ");

        }

        static void Init_PersonneBanque()
        {
            string nom1;
            string nom2;
            string message;
            string nUser;

            double argent1;
            double argent2;
            double montant;

            Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !\n------------------------------------------\n\n");

            Console.WriteLine("Première personne, quelle est votre nom ?");
            nom1 = Console.ReadLine();
            LireDouble("Tapez une somme d'argent en euros.", out argent1);

            Console.WriteLine("\nDeuxième personne, quelle est votre nom ?");
            nom2 = Console.ReadLine();
            LireDouble("Tapez une somme d'argent en euros.", out argent2);

            Personne personne1 = new Personne(nom1, argent1);
            Personne personne2 = new Personne(nom2, argent2);

            Console.WriteLine("\n"+personne1.Nom + ", combien voulez-vous donner à " + personne2.Nom + "?");
            LireDouble("Tapez une somme d'argent en euros.", out montant);

            message = personne1.Verser(personne2, montant);
            Console.WriteLine(message);

            Console.WriteLine(personne1.AfficheInfos());
            Console.WriteLine(personne2.AfficheInfos());

            Console.WriteLine("\n" + personne2.Nom + ", combien voulez-vous donner à " + personne1.Nom + "?");
            LireDouble("Tapez une somme d'argent en euros.", out montant);

            message = personne2.Verser(personne1, montant);
            Console.WriteLine(message);

            Console.WriteLine("\nVoulez-vous ajouter de l'argent au porte feuille de " + personne1.Nom + " ? (Tapez sur espace pour Oui)");
            nUser = Console.ReadLine();
            if (nUser == " ")
            {
                Console.WriteLine("\nCombien voulez-vous ajouter?");
                LireDouble("Tapez une somme d'argent en euros.", out montant);
                personne1.Ajoute(montant);
                Console.WriteLine(personne1.AfficheInfos());
                Console.WriteLine(personne2.AfficheInfos());

            }

            Console.WriteLine("\nTapez sur espace pour recommencer avec deux autres personnes ?");
            nUser = Console.ReadLine();
            if (nUser == " ")
            {
                Console.Clear();
                Init_PersonneBanque();
            }
        }

        static void Init_Cercle()
        {
            double rayon;
            string nUser;
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

        }
        
        static void Init_Complexe()
        {

            double reel;
            double imaginaire;
            double reelSecondaire;
            double imaginaireSecondaire;

            
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