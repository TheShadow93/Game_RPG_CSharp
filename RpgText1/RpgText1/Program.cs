using System;

namespace RpgText1
{
    class Program
    {


        static void Main(string[] args)
        {
            ICharacter mainUser = new ICharacter();
            //IntroStory(mainUser);

            //BeginOfTheGame(mainUser);


            Console.ReadKey();
        }

        private static void Fight(mainUser)
        {
            ICharacter enemy = GenerateEnnemy();
        }

        private static void BeginOfTheGame(ICharacter character)
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
            } while (TypeChar != "A" && TypeChar != "B" && TypeChar != "C");

            switch (TypeChar)
            {
                case "A":
                    character = new Guerrier();
                    break;
                case "B":
                    character.CharacterType = Enums.CharacterTypes.Mage;
                    break;
                case "C":
                    character.CharacterType = Enums.CharacterTypes.Paysans;
                    break;
            }

        }

        static void IntroStory(ICharacter character)
        {
            Console.WriteLine("Quel est ton nom ?");
            character.Name = Console.ReadLine();

            Console.WriteLine(character.Name + ", bienvenue dans le jeu"); 

        }
    }
}
