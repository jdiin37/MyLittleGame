using ConsoleApp1.BaseInterface;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Skill
{
    class NormalAttack : ISkill
    {
        string Name = "普通攻擊";

        //傷害倍率
        double damageM = 1.2;

        int costMp = 0;

        public bool Attack(IBaseHero useHero, IBaseHero targetGuy)
        {
            
            int damage = (int)(useHero.GetStr() * damageM - targetGuy.GetDefense());

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
