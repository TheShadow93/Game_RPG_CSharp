using System;
namespace RpgText1
{
    public class Mage : Character
    {
        public Mage():base()
        {
            //Money = 100;
            //Health = 100;
        }

        public Mage(string name) : base()
        {
            this.Name = name;
        }

        public override Enums.CharacterTypes CharacterType => Enums.CharacterTypes.Guerrier;
    }
}
