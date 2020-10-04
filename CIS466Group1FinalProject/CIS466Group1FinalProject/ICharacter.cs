namespace CIS466Group1FinalProject
{
    public interface ICharacter
    {
        int Attack(Dice dice);
        void Defend(int damage);
    }
}