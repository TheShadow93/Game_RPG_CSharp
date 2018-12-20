using System;
namespace RpgText1
{
    public class Character
    {


        public Character()
        {
            Money = 1;
            Health = 100;
        }

        public string Name { get; set; }
        public Enums.CharacterTypes CharacterType { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

    }
}
