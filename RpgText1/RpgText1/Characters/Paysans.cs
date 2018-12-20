using System;
namespace RpgText1
{
    public class Paysans : Character
    {
        public Paysans() : base()
        {
            //Money = 100;
            //Health = 100;
        }

        public Paysans(string name) : base()
        {
            this.Name = name;
        }

        public override Enums.CharacterTypes CharacterType => Enums.CharacterTypes.Guerrier;

    }
}
