using ConsoleApp1.BaseInterface;

namespace ConsoleApp1
{
    public interface ISkill
    {
        public void Attack(IBaseHero useHero,IBaseHero targetMoster);

        public string GetName();

        public int GetId();

        public int GetCostMp();
    }
}
