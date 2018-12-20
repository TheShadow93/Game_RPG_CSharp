using System;
namespace RpgText1
{
    public class Ennemy : ICharacter
    {
        public Ennemy()
        {
            Level = 1;
            Health = 100;
            Money = 10;
        }

        public string Name { get; set; }
        public virtual Enums.CharacterTypes CharacterType => Enums.CharacterTypes.None;
        public int Health { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

      

    }
}
