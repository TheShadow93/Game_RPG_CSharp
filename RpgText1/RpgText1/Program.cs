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
            Console.WriteLine("Quel joueur voulez vous etre ?");
            Console.WriteLine("A) Guerrier");
            Console.WriteLine("B) Mage");
            Console.WriteLine("C) Paysan");

            char TypeCharacter = Console.ReadKey().KeyChar;
        }

        static void IntroStory(Character character)
        {
            Console.WriteLine("Quel est ton nom ?");
            character.Name = Console.ReadLine();

            Console.WriteLine(character.Name + ", bienvenue dans le jeu"); 

        }
    }
}
