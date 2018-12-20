using System;
namespace RpgText1
{
    public class Menu
    {

        public Menu()
        {
            PrintMenu();

            int choix = AskChoice(1, 4);
            switch(choix)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    APropos();
                    break;
                case 4:
                    Quit();
                    break;
            }

        }

        public static void PrintMenu()
        {
            Console.WriteLine("MAIN MENU :");
            Console.WriteLine("1. Create New Game");
            Console.WriteLine("2. Load Saved Game");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Exit");
            //Console.ReadLine();
        }


        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result>max || result <min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        public void StartGame()
        {
            string NomJoueur;
            Console.WriteLine("Comment s'appelle votre joueur ?");
            NomJoueur = Console.ReadLine();
            Console.WriteLine("Bonjour " + NomJoueur);

            Console.WriteLine("The game will start");
        }

        public void Load()
        {
            Console.WriteLine("NOT FUNCTIONNAL FOR THE MOMENT");
        }

        public void APropos()
        {
            Console.WriteLine("Section A Propos");
        }

        public void Quit()
        {

        }

  
    }
}