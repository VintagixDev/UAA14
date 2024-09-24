using System.Net.Security;

namespace _6TTI_ClaudeMael_ACT2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reel;
            double imaginaire;
            double reelSecondaire;
            double imaginaireSecondaire;
            char repeatProg;

            do
            {

                LireDouble("Que vaut la partie réelle du complexe de départ ?", out reel);
                LireDouble("Que vaut la partie complexe du complexe de départ ?", out imaginaire);

                Complexe complexe = new Complexe(reel, imaginaire);
                Console.WriteLine("Le premier complexe : " + complexe.AfficheComplexe() + " a pour module : " + complexe.CalculeModule());
                Console.WriteLine("\nEncodez un second nombre complexe:");

                LireDouble("Que vaut la partie réelle du second complexe  ?", out reelSecondaire);
                LireDouble("Que vaut la partie complexe du second complexe ", out imaginaireSecondaire);
                Complexe complexeSecondaire = new Complexe(reelSecondaire, imaginaireSecondaire);
                Console.WriteLine("Le second complexe est : " + complexeSecondaire.AfficheComplexe());

                complexe.Ajoute(complexeSecondaire);
                Console.WriteLine("Le premier complexe devient : " + complexe.AfficheComplexe() + " après l'ajout du second");
            } while (repeatProg == 'O');

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