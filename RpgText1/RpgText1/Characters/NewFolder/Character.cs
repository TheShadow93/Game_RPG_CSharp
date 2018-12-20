using System;
namespace RpgText1
{
    public class Character : ICharacter
    {
        public Character()
        {
            Money = 100;
            Health = 100;
        }

        public string Name { get; set; }
        public virtual Enums.CharacterTypes CharacterType => Enums.CharacterTypes.None;
        public int Health { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

    }
}
