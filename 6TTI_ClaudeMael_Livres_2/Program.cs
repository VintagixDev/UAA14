using _6TTI_ClaudeMael_Livres.Objets;
using _6TTI_ClaudeMael_Livres_2.Objets;
using System.Security.Cryptography.X509Certificates;

namespace _6TTI_ClaudeMael_Livres_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque bibliotheque = new Bibliotheque();
            List<Personne> personnes = new List<Personne>();

            bool continuer = true;
            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();
                TraiterChoix(choix, bibliotheque, personnes);
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
                Console.Clear();
            }   

            static void AfficherMenu()
            {
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1. Ajouter un livre");
                Console.WriteLine("2. Afficher l'inventaire de la bibliothèque");
                Console.WriteLine("3. Créer une personne");
                Console.WriteLine("4. Emprunter un livre");
                Console.WriteLine("5. Rendre un livre");
                Console.WriteLine("6. Afficher les emprunts d'un utilisateur");
                Console.WriteLine("7. Dégrader l'état d'un livre");
                Console.WriteLine("8. Quitter");
                Console.Write("Votre choix : ");
            }

            static void TraiterChoix(string choix, Bibliotheque bibliotheque, List<Personne> personnes)
            {
                switch (choix)
                {
                    case "1":
                        AjouterLivre(bibliotheque);
                        break;
                    case "2":
                        AfficherInventaire(bibliotheque);
                        break;
                    case "3":
                        CreerPersonne(personnes);
                        break;
                    case "4":
                        EmprunterLivre(bibliotheque, personnes);
                        break;
                    case "5":
                        RendreLivre(bibliotheque);
                        break;
                   /* case "6":
                        AfficherEmpruntsUtilisateur();
                        break;
                    case "7":
                        DegraderLivre();
                        break;
                    case "8":
                        Environment.Exit(0);
                        break;*/
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }

            static void AjouterLivre(Bibliotheque bibliotheque)
            {
                Console.WriteLine("Nom du livre:");
                string nom = Console.ReadLine();
                Console.WriteLine("Nom de l'auteur");
                string auteur = Console.ReadLine();
                byte etatInt;
                do
                {

                Console.WriteLine("Etat (0-5): ");
                string etat = Console.ReadLine();
                while (!byte.TryParse(etat, out etatInt))
                {
                    Console.WriteLine("Etat (0-5)");
                    etat = Console.ReadLine();
                }
                }while(!(etatInt >= 0 && etatInt <= 5));
                Livre livre = new Livre(auteur, nom, etatInt);
                Console.WriteLine();
                Console.WriteLine(bibliotheque.Ajoute(livre));
           
            }

            static void AfficherInventaire(Bibliotheque bibliotheque)
            {
                Console.WriteLine(bibliotheque.Inventaire());
            }

            static void CreerPersonne(List<Personne> personnes)
            {
                Console.WriteLine("Nommez le nom de votre personne:");
                string nom = Console.ReadLine();

                Console.WriteLine("Nommez le prénom de personne:");
                string prenom = Console.ReadLine();
                personnes.Add(new Personne(nom, prenom));
            }

            static void EmprunterLivre(Bibliotheque bibliotheque, List<Personne> personnes)
            {
                Livre livre = choixLivre(bibliotheque);
                Personne personne = choixPersonne(bibliotheque, personnes);
                Emprunt emprunt = bibliotheque.Emprunte(livre, personne);
                Console.WriteLine(livre.Titre + " emprunté par " + personne.Prenom);
            }

            static void RendreLivre(Bibliotheque bibliotheque)
            {
                Console.WriteLine("Liste de emprunts (" + bibliotheque.Emprunts.Count + "): ");
                for (int i = 0; i < bibliotheque.Emprunts.Count; i++)
                {
                    Console.WriteLine($"{i}. {bibliotheque.Emprunts[i].Livre.Titre} - {bibliotheque.Emprunts[i].Personne.Prenom}");
                }
                int result;
                do
                {

                    LireInt("Votre choix:", out result);
                } while (result < 0 || !(result < bibliotheque.Emprunts.Count));
                bibliotheque.Emprunts.Remove(bibliotheque.Emprunts[result]);
                Console.WriteLine("Livre rendu");
            }

            static Personne choixPersonne(Bibliotheque bibliotheque, List<Personne> personnes)
            {
                Console.WriteLine("Liste de personnes (" + personnes.Count + "): ");
                for (int i = 0; i < personnes.Count; i++)
                {
                    Console.WriteLine($"{i}. {personnes[i].Nom}");
                }
                int result;
                do
                {

                    LireInt("Votre choix:", out result);
                } while (result < 0 || !(result < personnes.Count));
                Personne personne = personnes[result];
                return personne;

            }

            static Livre choixLivre(Bibliotheque bibliotheque)
            {
                Console.WriteLine("Liste de livres (" + bibliotheque.Livres.Count + "): ");
                for (int i = 0; i < bibliotheque.Livres.Count; i++)
                {
                    Console.WriteLine($"{i}. {bibliotheque.Livres[i].Titre}");
                }
                int result;
                do
                {

                LireInt("Votre choix:", out result);
                } while (result < 0 || !(result < bibliotheque.Livres.Count));
                Livre livre = bibliotheque.Livres[result];
                return livre;

            }


            static void LireInt(string question, out int result)
            {
                Console.WriteLine(question);
                string etat = Console.ReadLine();
                while (!int.TryParse(etat, out result))
                {
                    Console.WriteLine(question);
                    etat = Console.ReadLine();
                }
            }
        }
    }
}