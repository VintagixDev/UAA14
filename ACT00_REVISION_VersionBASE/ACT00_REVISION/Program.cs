using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE
            MethodesDuProjet methods = new MethodesDuProjet();
            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            string infos;
            // instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);


                // ordonner les côtés => APPEL ORDONNECOTES
                methods.OrdonneCotes(ref c1, ref c2, ref c3);
                // ...
                // série de test (voir consignes)
                ok = methods.Triangle(c1, c2, c3);
                if (ok)
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    methods.Affiche(ok, "triangle", out infos);
                    Console.WriteLine(infos);

                    ok = methods.Equi(c1, c2, c3);
                    if (ok)
                    {
                        methods.Affiche(ok, "equilateral", out infos);
                        Console.WriteLine(infos);

                    }
                    else
                    {
                        methods.Affiche(ok, "equilateral", out infos);
                        Console.WriteLine(infos);
                        ok = methods.TriangleRectangle(c1, c2, c3);
                        if (ok)
                        {
                            methods.Affiche(ok, "rectangle", out infos);
                            Console.WriteLine(infos);
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            methods.Affiche(ok, "triangle", out infos);
                            Console.WriteLine(infos);
                            // vérification du cas isocèle et affichage dans le cas positif

                            methods.Isocele(c1, c2, c3, out ok);
                            if (ok)
                            {
                                methods.Affiche(ok, "isocele", out infos);
                                Console.WriteLine(infos);
                            }
                            else
                            {
                                methods.Affiche(ok, "isocele", out infos);
                                Console.WriteLine(infos);
                            }
                        }
                        
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    methods.Affiche(false, "triangle", out infos);
                    Console.WriteLine(infos);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
