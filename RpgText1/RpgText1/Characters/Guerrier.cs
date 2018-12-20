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

        public Guerrier(string name) : base()
        {
            this.Name = name;
        }

        public override Enums.CharacterTypes CharacterType => Enums.CharacterTypes.Guerrier;


}
}
