using System;
using System.Collections.Generic;
using System.Text;

namespace CIS466Group1FinalProject
{
    public class Character: ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            // max random number that can be generated
            dice.Sides = 50;
            return dice.Roll();
        }
        //TODO: add the attack bonus
        public void Defend(int damage)
        {
            if (damage <= DamageMaximum)
                this.Health -= damage;
            else
                this.Health -= DamageMaximum;
        }
    }
}
