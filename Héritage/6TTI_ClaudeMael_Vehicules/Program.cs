using _6TTI_ClaudeMael_Vehicules.Objects;

namespace _6TTI_ClaudeMael_Vehicules
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicule vehicule = new Vehicule("308", "Peugeot", "bleu", 28000);
            Console.WriteLine(vehicule.Affiche());
            Console.WriteLine("------------");
            Voiture voiture = new Voiture("motorisé", true, "TT", "Audi", "Bleu", 80000);
            Console.WriteLine(voiture.Affiche());
            Console.WriteLine("------------");
            Velo velo = new Velo("BMX", false, "bmxencore", "bmxmarque", "noir", 150);
            Console.WriteLine(velo.Affiche());

        }
    }
}