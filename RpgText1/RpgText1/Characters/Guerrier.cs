using System;
namespace RpgText1
{
    public class Guerrier : Character
    {
        public Characte
        {
            Money = 100;
            Health = 100;
        }
    public string Name { get; set; }
    public Enums.CharacterTypes CharacterType => Enums.CharacterTypes.Guerrier;
    public int Health { get; set; }
    public int Money { get; set; }
    public int Level { get; set; }


}
}
