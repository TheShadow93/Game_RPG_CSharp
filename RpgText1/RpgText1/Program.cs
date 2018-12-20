using System;

namespace RpgText1
{
    class Program
    {


        static void Main(string[] args)
        {
            string a =  First();
            string name = IntroStory();

            ICharacter character = BeginOfTheGame(name);
            Fight(character);


            Console.ReadKey();
        }
         
        private static bool Fight(ICharacter mainUser)
        {
            Ennemy TheMonster = new Ennemy();

            //Bataille jusqu'a la defaite de quelqu'un
            do
            {
                var attack = 10;

                TheMonster.Health = TheMonster.Health - attack;


                Console.WriteLine($"{mainUser.PlayerInfo} {TheMonster.Health}\nL'ennemi a perdu {attack} points !");
                Console.ReadKey();

                Console.Clear();

            } while (mainUser.Health > 0 && TheMonster.Health > 0);

            if (mainUser.Health <=0)
            {
                GameOver();
            }
            else if (TheMonster.Health <= 0)
            {
                Console.WriteLine("Vous avez gagné !");
            }
            return false;
        }

        private static void GameOver()
        {
            throw new NotImplementedException();
        }

        private static ICharacter BeginOfTheGame(string characterName)
        {
            ICharacter character = null;
            string TypeChar;

            do
            {
                //Console.Clear(); 
                Console.WriteLine(characterName + ", quel joueur veux tu etre ?");
                Console.WriteLine("A) Guerrier");
                Console.WriteLine("B) Mage");
                Console.WriteLine("C) Paysan");

                TypeChar = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (TypeChar != "A" && TypeChar != "B" && TypeChar != "C");

            switch (TypeChar)
            {
                case "A":
                    character = new Guerrier(characterName);
                    break;
                case "B":
                    character = new Mage(characterName);
                    break;
                case "C":
                    character = new Paysans(characterName);
                    break;
            }
            Console.Clear();
            return character;

        }

        private static string IntroStory()
        {


            Console.WriteLine("Quel est ton nom ?");
            string name = Console.ReadLine();

            Console.WriteLine(name + ", bienvenue dans le jeu");
            Console.WriteLine("Tu es dans une foret froide et sombre. Pour en sortir, tu dois vaincre le monstre de la foret. Je te souhaite Bon Courage ahahahah.");

            return name;

        }

        private static string First()
        {
            string a;
            a = " ";
            PrintMenu();
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
                    
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
            return a;

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
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        public static void Load()
        {
            Console.WriteLine("NOT FUNCTIONNAL FOR THE MOMENT");
            System.Environment.Exit(1);
        }

        public static void APropos()
        {
            Console.WriteLine("CE JEU VOUS EST PROPOSE PAR SUMEET SINGH");
            PrintMenu();
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
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

        public static void Quit()
        {
            System.Environment.Exit(1);
        }
    }
}
