// See https://aka.ms/new-console-template for more information
using System;


namespace coursApp1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            var random = new Random();
            var AllMonstres = new List<string>{
                "Loup enragé",
                "Golem de pierre",
                "Zombie",
                "Gobelin",
                "Dragon"};
            int choice = random.Next(AllMonstres.Count);

            Monstre monstre = new Monstre(AllMonstres[choice]);
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {

                //Tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }
                //Tour du personnage
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
            }

            if (victoire)
            {
                monPerso.gagnerExperience(5);

                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques());

                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivant ? (O/N)");
                    string saisie = Console.ReadLine().ToUpper();
                    if(saisie == "O")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if(saisie == "N")
                    {
                        Environment.Exit(0);
                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("tu as perdu....");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            string joueur = "Joueur";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Jeu de Role");
            Console.WriteLine();
            Console.WriteLine("Quitter le jeu :");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();
            Console.WriteLine("Quelle est votre nom aventurier?");
            joueur = Console.ReadLine();
            if (joueur != "")
            {
                Console.WriteLine();
                Console.WriteLine("Choisis ta classe: ");
                Console.WriteLine("1. Guerrier");
                Console.WriteLine("2. Sorcier");
                Console.WriteLine("3. Archer");
                Console.WriteLine();
            }
            else
            {
                joueur = "Joueur";
                Console.WriteLine();
                Console.WriteLine("Choisis ta classe: ");
                Console.WriteLine("1. Guerrier");
                Console.WriteLine("2. Sorcier");
                Console.WriteLine("3. Archer");
                Console.WriteLine();
            }
            
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier(joueur));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Sorcier !");
                    Console.WriteLine();
                    Jouer(new Sorcier(joueur));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Archer !");
                    Console.WriteLine();
                    Jouer(new Archer(joueur));
                    break;
                case "4":
                    break;
            }
        }
    }
}