using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion : Item
    {
        public HealthPotion() 
            : base(5)
        {

        }

        //TODO
        public override void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

            if (character.Health + 20 >= character.BaseHealth)
            {
                character.Health = character.BaseHealth;
            }

            character.Health += 20;
        }
    }
}
