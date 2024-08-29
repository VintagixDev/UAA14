namespace _6TTI_ClaudeMael_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Methodes methods = new Methodes();
            
            methods.CustomConsole(ConsoleColor.Black, ConsoleColor.Cyan);


            double[] table = new double[10];
            double x;

            Console.WriteLine("Entrez 10 nombres afin d'en ressortir la moyenne:");
            for(int i = 0; i < table.Length; i++) 
            {
                methods.LireDouble(i+1, out x);
                table[i] = x;

            }
            double addition = 0;
            for(int i = 0;i < table.Length; i++)
            {
                addition += table[i]; 
            }
            double final = addition/table.Length;
            Console.WriteLine("\nMoyenne de tous ces nombres: " + final);

        }
    }
}