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
        public int costMp = 10;

        public bool Attack(IBaseHero useHero, IBaseHero targetMoster)
        {
            useHero.LoseMp(10);
            int damage = useHero.GetInt() * damageM;

            Console.WriteLine("{0} 對 {1} , 使用 {2}, 造成 {3} 點傷害",
                useHero.GetName(),
                targetMoster.GetName(),
                this.GetName(),
                damage);

            if(targetMoster.LoseHp(damage) <= 0)
            {
                Console.WriteLine("{0} 死亡!!!",
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

        public int GetCostMp()
        {
            return this.costMp;
        }
    }
}
