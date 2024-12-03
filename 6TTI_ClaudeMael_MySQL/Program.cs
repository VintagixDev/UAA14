using System.Data;

namespace _6TTI_ClaudeMael_MySQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BDDMethodes bdd = new BDDMethodes();
            DataSet ds = new DataSet();

            //bdd.GetAllBiens(out ds);

            bdd.GetBienFromID(out ds, 1);
            Console.WriteLine(bdd.ConcateneDataSet(ds));

            //bdd.UpdateBien(1, "Villa St. Maurice");
            //bdd.AddBien("Dark Castle", 150, 523321, "Castle Town");
            //bdd.RemoveBien(30);
        }
    }
}