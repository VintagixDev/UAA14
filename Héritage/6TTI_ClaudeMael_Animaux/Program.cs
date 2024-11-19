using _6TTI_ClaudeMael_Animaux.Objects;

namespace _6TTI_ClaudeMael_Animaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat chat1 = new Chat("pipou", "3 janvier 2020", 1, 34, false);
            /*Console.WriteLine(chat.Miauler());
            Console.WriteLine(chat.Ronronner());
            Console.WriteLine(chat.Dormir());
            Console.WriteLine(chat.Manger());
            Console.WriteLine("-----------");*/

            Chien chien = new Chien("Flocon", "24 septembre 2018", 3, 42, true);
            /*Console.WriteLine(chien.Aboyer());
            Console.WriteLine(chien.Dormir());
            Console.WriteLine(chien.Manger());
            Console.WriteLine("-----------");*/
            Lapin lapin = new Lapin(5, "Sunny", "05 octobre 2024", 4, 15, false);
            /*Console.WriteLine(lapin.FaireBonds());
            Console.WriteLine(lapin.Dormir());
            Console.WriteLine(lapin.Manger());*/

            Animal[] animaux = new Animal[5];
            animaux[0] = chien;
            animaux[1] = lapin;
            animaux[2] = chat1;
            animaux[3] = new Chat("David", "5 mai 2017", 1, 32, false);
            animaux[4] = new Chien("Sydney", "17 octobre 2015", 0, 50, true);

            for(int i = 0; i < animaux.Length; i++)
            {
                if (animaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.Miauler());
                }
            }


        }
    }
}