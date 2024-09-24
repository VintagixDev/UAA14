namespace _6TTI_ClaudeMael_ACT2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nUser;
            double rayon;
            do
            {
                Console.WriteLine("Veuillez entrer le rayon du cercle.");
                nUser = Console.ReadLine();
            } while (!double.TryParse(nUser, out rayon));

            Cercle cercle = new Cercle(rayon);

            Console.WriteLine("Le cercle de rayon " + cercle.Rayon + " a un périmètre de " + cercle.CalculePerimetre() + " et une aire de " + cercle.CalculeAire());
            Console.WriteLine("--------------------");
            Console.WriteLine("Avec un cercle de rayon diminué de moitié :");
            Cercle cercle2 = new Cercle(rayon/2);
            Console.WriteLine("Le cercle de rayon " + cercle2.Rayon + " a un périmètre de " + cercle2.CalculePerimetre() + " et une aire de " + cercle2.CalculeAire());
        }
    }
}