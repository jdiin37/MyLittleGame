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

        public bool Attack(IHero useHero, IBaseHero targetMoster)
        {
            
            int damage = (int)(useHero.GetStr() * damageM);

            Console.WriteLine("對 {0} , 使用 {1}, 造成 {2} 點傷害", 
                targetMoster.GetName(),
                this.GetName(),
                damage);
            targetMoster.LoseHp(damage);

            if(targetMoster.LoseHp(damage) <= 0)
            {
                Console.WriteLine("{0} 死亡",
                targetMoster.GetName());
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
    }
}
