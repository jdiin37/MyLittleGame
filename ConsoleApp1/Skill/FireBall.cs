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
    class FireBall : ISkill
    {
        string Name = "火球術";

        //傷害倍率
        int damageM = 2;
        int costMp = 10;

        public bool Attack(IHero useHero, IBaseHero targetMoster)
        {
            if (!useHero.CheckMp(costMp))
            {
                Console.WriteLine("MP 不足");
                return false;
            }

            useHero.LoseMp(10);
            int damage = useHero.GetInt() * damageM;

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
            return 1;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
