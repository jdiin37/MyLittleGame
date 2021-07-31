using ConsoleApp1.BaseInterface;
using System;

namespace ConsoleApp1.Skill
{
    abstract public class ASkill:ISkill
    {
        public string Name;

        //傷害倍率
        public double damageM;

        public int costMp;


        public int GetId()
        {
            return 0;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetCostMp()
        {
            return this.costMp;
        }

        protected void AttackResult(IBaseHero useHero, IBaseHero targetGuy,int damage)
        {
            Console.WriteLine("{0} 對 {1} , 使用 {2}, 造成 {3} 點傷害",
                useHero.GetName(),
                targetGuy.GetName(),
                this.GetName(),
                damage);

            if (targetGuy.LoseHp(damage) <= 0)
            {
                Console.WriteLine("{0} 死亡 !!!",
                targetGuy.GetName());
            }

        }

        abstract public void Attack(IBaseHero useHero, IBaseHero targetGuy);
    }
}
