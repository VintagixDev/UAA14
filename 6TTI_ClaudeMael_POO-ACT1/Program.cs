namespace _6TTI_ClaudeMael_POO_ACT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Methodes methods = new Methodes();
            Random random = new Random();
            Lampe lampe = new Lampe("A1", "rouge");
            Interrupteur interrupteur = new Interrupteur("A1");

            Lampe[] mesLampes = new Lampe[10];
            Interrupteur[] mesInterrupteurs = new Interrupteur[10];

            interrupteur.Eteindre(lampe);
            Console.WriteLine(lampe.State);

            string[] color = ["rouge", "bleu", "vert", "violet", "jaune", "rose", "orange"];

            for (int i = 0; i < 10; i++)
            {

                mesLampes[i] = new Lampe("A" + i, color[random.Next(0, color.Length-1)]);
                mesInterrupteurs[i] = new Interrupteur("A" + i);
            }

            do
            {

                int codeInt;
                string code;
                do
                {
                    Console.WriteLine("Choisissez une lampe que vous voulez allumer/éteindre (1-10)");
                    code = Console.ReadLine();

                } while (!int.TryParse(code, out codeInt) && codeInt > 10);

                char action;
                string userInput;
                do
                {
                    Console.WriteLine("a = allumer, e = eteindre");
                    userInput = Console.ReadLine();

                } while (!char.TryParse(userInput, out action) && !(action == 'a' || action == 'e'));

                switch (action)
                {
                    case 'a':

                        mesInterrupteurs[codeInt].Allumer(mesLampes[codeInt]);
                        Console.WriteLine("Etat de la lampe A" + codeInt + " : Allumée");
                        break;
                    case 'e':
                        mesInterrupteurs[codeInt].Eteindre(mesLampes[codeInt]);
                        Console.WriteLine("Etat de la lampe A" + codeInt + " : Éteinte");
                        break;
                    default: break;
                }
            } while (true);

        }
    }
}