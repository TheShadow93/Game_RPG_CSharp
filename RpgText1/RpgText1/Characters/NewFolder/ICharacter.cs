using System;
namespace RpgText1
{
    interface ICharacter
    {
        string Name { get; set; }
        Enums.CharacterTypes CharacterType { get; }
        int Health { get; set; }
        int Money { get; set; }
        int Level { get; set; }

    }
}
