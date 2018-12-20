using System;
namespace RpgText1
{
    public class Guerrier : Character
    {
        public Guerrier() : base()
        {
            //Money = 100;
            //Health = 100;
        }

        public override Enums.CharacterTypes CharacterType => Enums.CharacterTypes.Guerrier;


}
}
