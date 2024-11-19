using _6TTI_ClaudeMael_Employe.Objects;

namespace _6TTI_ClaudeMael_Employe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double chiffreAffaire = 1500000;

            Employe[] employes = new Employe[10];
            employes[0] = new Ouvrier("12/04/24", "353", "Corda", "Andras", "05/09/05", 15);
            employes[1] = new Ouvrier("02/03/21", "122", "Bechet", "Ludo", "10/10/07", 1200);
            employes[2] = new Ouvrier("15/10/22", "153", "Constant", "Louka", "14/04/07", 1250);
            employes[3] = new Ouvrier("23/02/24", "436", "Brahy", "Adrien", "22/06/06", 1200);
            employes[4] = new Ouvrier("22/12/23", "551", "Ponchot", "Nicolas", "31/12/22", 1150);
            employes[5] = new Cadre(1, "111", "Caa", "Alex", "11/11/21");
            employes[6] = new Cadre(3, "435", "ZZ", "dazd", "12/11/21");
            employes[7] = new Cadre(4, "984", "ss", "dgfdgf", "13/11/21");
            employes[8] = new Directeur(10, chiffreAffaire, "12", "Claude", "Mael", "07/04/05");
            employes[9] = new Directeur(5, chiffreAffaire, "51", "Pelerin", "Terry", "10/01/06");

            foreach(Employe employe in employes)
            {
                Console.WriteLine(employe.Afficher());
            }
        }
    }
}