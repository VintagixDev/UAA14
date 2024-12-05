using Org.BouncyCastle.Bcpg;
using System.Data;

namespace _6TTI_ClaudeMael_MySQL
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char repeatProg;
            BDDMethodes bdd = new BDDMethodes();
            DataSet ds = new DataSet();
            string nUser;

            int bienId;

            do
            {
                Console.Clear();
                bdd.AfficherMainText();
                bdd.LireInt("", out int choice);
                switch (choice)
                {
                    case 1:
                        bdd.GetAllBiens(out ds);
                        Console.Clear();
                        bdd.AfficherMainText();
                        Console.WriteLine(bdd.ConcateneDataSet(ds));

                        break;

                    case 2:
                        Console.Clear();
                        bdd.AfficherMainText();
                        bdd.LireInt("Veuillez choisir l'ID de votre bien", out bienId);
                        bdd.GetBienFromID(out ds, bienId);
                        Console.WriteLine(bdd.ConcateneDataSet(ds));
                        break;
                    
                    case 3:
                        Console.Clear();
                        bdd.AfficherMainText();
                        Console.WriteLine("Entrez le nom de votre bien");
                        string nom = Console.ReadLine();
                        bdd.LireInt("Entrez la taille de votre bien", out int taille);
                        bdd.LireInt("Entrez le prix de votre bien", out int prix);
                        Console.WriteLine("Entrez le nom de la ville où se trouve votre bien");
                        string ville = Console.ReadLine();

                        bdd.AddBien(nom, taille, prix, ville);
                        Console.WriteLine("Bien ajouté à la liste");
                        break;
                    case 4:
                        Console.Clear();
                        bdd.AfficherMainText();
                        bdd.LireInt("Veuillez choisir l'ID de votre bien", out bienId);

                        Console.WriteLine("Veuillez choisir son nouveau nom");
                        string nouveauNom = Console.ReadLine();
                        bdd.UpdateBien(bienId, nouveauNom);
                        Console.WriteLine("Bien modifié !");

                        break;
                    case 5:
                        Console.Clear();
                        bdd.AfficherMainText();
                        bdd.LireInt("Veuillez choisir l'ID de votre bien", out bienId);
                        bdd.RemoveBien(bienId);
                        Console.WriteLine("Bien supprimé !");
                        break;

                }




                Console.WriteLine("Voulez-vous recommencer le programme ? O = Oui");
                nUser = Console.ReadLine();
                while(!char.TryParse(nUser, out repeatProg))
                {
                    Console.WriteLine("Entrée incorrecte; Voulez-vous recommencer le programme ? O = Oui");
                    nUser = Console.ReadLine();
                }

            } while (char.ToUpper(repeatProg) == 'O'); ;
        }

        
    }
}