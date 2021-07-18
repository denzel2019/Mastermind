using System;



class Motus
{
    static void Main()
    {

        string[] mots = { "GENDARME", "ANTIDOTE", "MERCREDI", "BURINAIT", "VENDREDI", "CONNECTA", "AVANCERA", "CREMEUSE", "MATCHERA", "BANLIEUE", "MONUMENT" };


        Random rnd = new Random();
        int x = rnd.Next(11);  // creates a number between 0 and 10

        Console.WriteLine(mots[x]);

        string motSaisi;
        string nomJoueur;
        Console.WriteLine("******Mastermind******");
        Console.WriteLine("**********************************");
        //Nom du Joueur
        Console.WriteLine("Entrez le nom du joueur : ");
        nomJoueur = Console.ReadLine();

        Console.WriteLine("Entrez un mot en majuscule de 8 lettres: ");
        motSaisi = Console.ReadLine();

        int nbEssais = 0;
        int nbEssaisMax = 5;

        do
        {
            //Boucle pour recommencer jusqu'à la solution
            while (motSaisi != mots[x] && nbEssais < nbEssaisMax)
            {
                //Boucle pour épeler
                for (int i = 0; i < mots[x].Length; i++)
                {
                    if (motSaisi.Substring(i, 1) == mots[x].Substring(i, 1))
                    {
                        //Couleurs
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.White;
                        //Epelle les lettres
                        Console.Write(motSaisi.Substring(i, 1));
                        //Timer
                        System.Threading.Thread.Sleep(100);
                    }
                    else
                        //Couleurs pour les mauvaises lettres
                        Console.BackgroundColor = ConsoleColor.Red;
                    //Epelle les lettres 
                    Console.Write(" ");
                    //Timer
                    System.Threading.Thread.Sleep(100);
                }

                //Incrémentation du nb de tentatives
                nbEssais++;

                //Instructions avec retour à la ligne
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Retente ta chance " + nbEssais);
                motSaisi = Console.ReadLine();

            }

            //Contrôle positif et négatif
            if (mots[x] == motSaisi)
            {
                Console.WriteLine($"Bravo {nomJoueur}, tu as trouvé!");
                break;
            }
            Console.WriteLine($"Tu as raté {nomJoueur}, looser! GAME OVER!");
            Console.WriteLine($"Le mot a trouvé était {mots[x]}");
        }

        //Sortie au bout de 5 essais infructueux
        while (nbEssais != nbEssaisMax);
        //Fin du jeu
        Console.WriteLine("Fin de partie.");
        Console.ReadLine();
    }
}