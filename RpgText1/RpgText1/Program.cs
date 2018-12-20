using System;

namespace RpgText1
{
    class Program
    {


        static void Main(string[] args)
        {
            string name = IntroStory();

            ICharacter character = BeginOfTheGame();
            Fight(character);


            Console.ReadKey();
        }
         
        private static void Fight(ICharacter mainUser)
        {
            Ennemy TheMonster = new Ennemy();

            //Pour la bataille jusqu'a la defaite de quelqu'un
            do
            {

            } while (mainUser.Health > 0 && TheMonster.Health > 0);
        }

        private static ICharacter BeginOfTheGame()
        {
            ICharacter character = null;
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
                    character = new Mage();
                    break;
                case "C":
                    character = new Paysans();
                    break;
            }
            return character;

        }

        private static string IntroStory()
        {
            Console.WriteLine("Quel est ton nom ?");
            string name = Console.ReadLine();

            Console.WriteLine(name + ", bienvenue dans le jeu");

            return name;

        }
    }
}
