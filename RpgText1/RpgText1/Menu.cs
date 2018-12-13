using System;
namespace RpgText1
{
    public class Menu
    {

        public Menu()
        {
            PrintMenu();
            int choix = AskChoice(0, 3);
            switch(choix)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    APropos();
                    break;
                case 3:
                    Quit();
                    break;
            }
        }

        public void PrintMenu()
        {
            //TODO Faire l'affichage
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

        }

        public void Load()
        {

        }

        public void APropos()
        {

        }

        public void Quit()
        {

        }
    }
}
