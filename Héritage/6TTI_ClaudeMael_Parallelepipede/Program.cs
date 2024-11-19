using _6TTI_ClaudeMael_Parallelepipede.Objets;

namespace _6TTI_ClaudeMael_Parallelepipede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carre carre = new Carre(3, "bleu");
            Rectangle rectangle = new Rectangle(5, 2, "rouge");

            Console.WriteLine(carre.CalculePerimetre());
            Console.WriteLine(carre.CalculeSurface());

            Console.WriteLine(rectangle.CalculeSurface());
            Console.WriteLine(rectangle.CalculePerimetre());
        }
    }
}