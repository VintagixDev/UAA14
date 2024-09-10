namespace _6TTI_ClaudeMael_POO_ACT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Methodes methods = new Methodes();
            do
            {

                Console.WriteLine("1 | Créer une lampe\n" +
                    "2 | Créer un interrupteur\n" +
                    "3 | Utiliser un interrupteur\n\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.NumPad1:
                        methods.CreerLampe();
                        break;
                    case ConsoleKey.NumPad2:
                        methods.CreerInterrupteur();
                        break;
                    case ConsoleKey.NumPad3:
                        methods.UtiliserInterrupteur();
                        break;
                    default: break;
                }
            } while (true);

        }
    }
}