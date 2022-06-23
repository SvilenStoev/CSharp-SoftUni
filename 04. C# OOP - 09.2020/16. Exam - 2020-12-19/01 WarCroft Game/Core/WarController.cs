using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private readonly List<Character> party;
        private readonly Stack<Item> pool;

        public WarController()
        {
            this.party = new List<Character>();
            this.pool = new Stack<Item>();
        }

        public string JoinParty(string[] args)
        {
            Character character = null;

            if (args[0] == "Warrior")
            {
                character = new Warrior(args[1]);

            }
            else if (args[0] == "Priest")
            {
                character = new Priest(args[1]);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, args[0]));
            }

            this.party.Add(character);
            return string.Format(SuccessMessages.JoinParty, args[1]);
        }

        public string AddItemToPool(string[] args)
        {
            Item item = null;

            if (args[0] == "HealthPotion")
            {
                item = new HealthPotion();

            }
            else if (args[0] == "FirePotion")
            {
                item = new FirePotion();
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, args[0]));
            }

            this.pool.Push(item);
            return string.Format(SuccessMessages.AddItemToPool, args[0]);
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            if (!this.party.Any(c => c.Name == characterName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }

            var currCharacter = this.party.FirstOrDefault(c => c.Name == characterName);

            if (!this.pool.Any())
            {
                throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

            Item item = this.pool.Pop();

            currCharacter.Bag.AddItem(item);

            return string.Format(SuccessMessages.PickUpItem, characterName, item.GetType().Name);
        }

        public string UseItem(string[] args)
        {
            string charName = args[0];
            string itemName = args[1];

            if (!this.party.Any(c => c.Name == charName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, charName));
            }

            var currCharacter = this.party.FirstOrDefault(c => c.Name == charName);

            Item currItem = currCharacter.Bag.GetItem(itemName);

            currCharacter.UseItem(currItem);

            return string.Format(SuccessMessages.UsedItem, charName, itemName);
        }

        public string GetStats()
        {
            var sortedCharacters = this.party.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health).ToList();

            var sb = new StringBuilder();

            

            foreach (var character in sortedCharacters)
            {
                string isAlive = "Alive";

                if (character.IsAlive)
                {
                    isAlive = "Alive";
                }
                else
                {
                    isAlive = "Dead";
                }

                sb.AppendLine(string.Format(SuccessMessages.CharacterStats,
                    character.Name,
                    character.Health.ToString("F0"),
                    character.BaseHealth.ToString("F0"),
                    character.Armor.ToString("F0"),
                    character.BaseArmor.ToString("F0"),
                    isAlive));
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string attackTargetName = args[1];

            if (!this.party.Any(c => c.Name == attackerName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackerName));
            }
            
            if (!this.party.Any(c => c.Name == attackTargetName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackTargetName));
            }

            var attacker = this.party.FirstOrDefault(c => c.Name == attackerName);
            var attackTarget = this.party.FirstOrDefault(c => c.Name == attackTargetName);

            if (attacker.GetType().Name != "Warrior" || !attacker.IsAlive)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }

            Warrior attackerWarior = (Warrior)attacker;
            attackerWarior.Attack(attackTarget);

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(SuccessMessages.AttackCharacter,
                attackerName,
                attackTargetName,
                attackerWarior.AbilityPoints.ToString("F0"),
                attackTargetName,
                attackTarget.Health.ToString("F0"),
                attackTarget.BaseHealth.ToString("F0"),
                attackTarget.Armor.ToString("F0"),
                attackTarget.BaseArmor.ToString("F0")
                ));

            if (!attackTarget.IsAlive)
            {
                sb.AppendLine(string.Format(SuccessMessages.AttackKillsCharacter, attackTargetName));
            }

            return sb.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            if (!this.party.Any(c => c.Name == healerName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healerName));
            }
            
            if (!this.party.Any(c => c.Name == healingReceiverName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healingReceiverName));
            }

            var healer = this.party.FirstOrDefault(h => h.Name == healerName);
            var receiverHeal = this.party.FirstOrDefault(h => h.Name == healingReceiverName);

            if (healer.GetType().Name != "Priest" || !healer.IsAlive)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, healerName));
            }

            Priest healerPriest = (Priest)healer;
            healerPriest.Heal(receiverHeal);

            var sb = new StringBuilder();

            sb.AppendLine(string.Format(SuccessMessages.HealCharacter,
                healerName,
                healingReceiverName,
                healerPriest.AbilityPoints.ToString("F0"),
                healingReceiverName,
                receiverHeal.Health.ToString("F0")
                ));

            if (!receiverHeal.IsAlive)
            {
                sb.AppendLine(string.Format(SuccessMessages.AttackKillsCharacter, healingReceiverName));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
