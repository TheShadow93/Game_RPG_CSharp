using System;

namespace RpgText1
{
    class Program
    {


        static void Main(string[] args)
        {
            Character mainUser = new Character();
            IntroStory(mainUser);

            BeginOfTheGame();

            Console.ReadKey();
        }

        private static void BeginOfTheGame()
        {

            string TypeChar;

            do
            {
                //Console.Clear();
                Console.WriteLine("Quel joueur voulez vous etre ?");
                Console.WriteLine("A) Guerrier");
                Console.WriteLine("B) Mage");
                Console.WriteLine("C) Paysan");

                TypeChar = Console.ReadLine().ToUpper();
                Console.Clear();

                Console.WriteLine(TypeChar);
            } while (TypeChar == "A" || TypeChar == "B" || TypeChar == "C");

            switch (TypeChar)
            {
                case "A":
                    break;
                case "B":
                    break;
                case "C":
                    break;
            }

        }

        static void IntroStory(Character character)
        {
            Console.WriteLine("Quel est ton nom ?");
            character.Name = Console.ReadLine();

            Console.WriteLine(character.Name + ", bienvenue dans le jeu"); 

        }
    }
}
