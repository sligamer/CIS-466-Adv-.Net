using System;

namespace CIS466Group1FinalProject
{
    class Program
    {
        #region properties
        public static Dice dice { get; set; }
        public static Character hero { get; set; }
        public static Character monster { get; set; }
        public static int battleCount { get; set; }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Lets Battle!");
            dice = new Dice();
            buildCharacteres();
            doBattle();
            displayResult(hero, monster);
            Console.ReadKey();
        }

        #region static methods
        static void buildCharacteres()
        {
            hero = new Character() { Name = "Hero", Health = 100, DamageMaximum = 20, AttackBonus = true };
            monster = new Character() { Name = "Monster", Health = 100, DamageMaximum = 20, AttackBonus = true };
        }
        static void doBattle()
        {
            battleCount = 1;
            while (hero.Health >= 0 || monster.Health >= 0)
            {               
                // monster attack first
                int mA = monster.Attack(dice);
                Console.WriteLine("Monster Battle Roll");
                Console.WriteLine("Attack = {0}", mA);
                monster.Attack(dice);
                hero.Defend(mA);

                // hero attack second
                hero.Attack(dice);
                int hA = hero.Attack(dice);
                Console.WriteLine("Hero Battle Roll");
                Console.WriteLine("Attack = {0}", mA);
                monster.Defend(hA);
                
                battleCount++;
            }
        }
        static void displayResult(Character hero, Character monster)
        {
            Console.WriteLine("Battle #: {0}", battleCount);
            Console.WriteLine("Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}", 
                hero.Name, hero.Health, hero.DamageMaximum, hero.AttackBonus);
            Console.WriteLine("Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}", 
                monster.Name, monster.Health, monster.DamageMaximum, monster.AttackBonus);
        }
        #endregion
    }
}
