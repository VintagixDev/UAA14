using _6TTI_ClaudeMael_Livres.Objets;
using _6TTI_ClaudeMael_Livres_2.Objets;

namespace _6TTI_ClaudeMael_Livres_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livre livre = new Livre("aaa", "acds", 5);
            Bibliotheque biblio = new Bibliotheque();
            biblio.Ajoute(livre);
            Personne personne = new Personne("Mael", "Claude");
            Console.WriteLine(personne.Emprunte(livre, biblio));
            Console.WriteLine(biblio.ListeEmprunts());

        }
    }
}