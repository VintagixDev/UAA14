using _6TTI_ClaudeMael_Livres.Objets;

namespace _6TTI_ClaudeMael_Livres
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            Livre livre1 = new Livre("aa", "Mael", 1);
            Console.WriteLine(livre1.Degrade());
            Console.WriteLine(livre1.Description());
            Bibliotheque biblio = new Bibliotheque();

            Console.WriteLine(biblio.Ajoute(livre1));

            Console.WriteLine(biblio.Inventaire());
            Console.WriteLine(biblio.SupprimeLivreAbime());
            Console.WriteLine(biblio.Inventaire());

        }
    }
}