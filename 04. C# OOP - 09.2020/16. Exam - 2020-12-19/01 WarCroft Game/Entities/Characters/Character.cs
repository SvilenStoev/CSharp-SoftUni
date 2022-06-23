using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.

        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;
        private double abilityPoints;
        private Bag bag;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                this.name = value;
            }
        }

        public double BaseHealth
        {
            get
            {
                return this.baseHealth;
            }
            private set
            {
                this.baseHealth = value;
            }
        }

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public double BaseArmor
        {
            get
            {
                return this.baseArmor;
            }
            private set
            {
                this.baseArmor = value;
            }
        }

        public double Armor
        {
            get
            {
                return this.armor;
            }
            private set
            {
                this.armor = value;
            }
        }

        public double AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            private set
            {
                this.abilityPoints = value;
            }
        }

        public Bag Bag
        {
            get
            {
                return this.bag;
            }
            private set
            {
                this.bag = value;
            }
        }

        public bool IsAlive { get; set; } = true;

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            if (this.Armor >= hitPoints)
            {
                this.Armor -= hitPoints;
            }
            else if (this.Armor < hitPoints)
            {
                double leftPoints = hitPoints - this.Armor;

                this.Armor = 0;

                if (this.Health <= leftPoints)
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
                else
                {
                    this.Health -= leftPoints;
                }
            }
        }

        public void UseItem(Item item)
        {
            this.EnsureAlive();

            item.AffectCharacter(this);
        }

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }
    }
}