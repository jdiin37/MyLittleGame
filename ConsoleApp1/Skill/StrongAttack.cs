using ConsoleApp1.BaseInterface;
using System;

namespace ConsoleApp1.Skill
{
    class StrongAttack : ISkill
    {
        string Name = "強力攻擊";

        //傷害倍率
        double damageM = 1.8;

        int costMp = 0;

        public bool Attack(IBaseHero useHero, IBaseHero targetGuy)
        {
            
            int damage = (int)(useHero.GetStr() * damageM - targetGuy.GetDefense());
            if (damage <= 1) damage = 1;
            Console.WriteLine("{0} 對 {1} , 使用 {2}, 造成 {3} 點傷害",
                useHero.GetName(),
                targetGuy.GetName(),
                this.GetName(),
                damage);

            if(targetGuy.LoseHp(damage) <= 0)
            {
                Console.WriteLine("{0} 死亡 !!!",
                targetGuy.GetName());
            }

            return true;
        }

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
    }
}
