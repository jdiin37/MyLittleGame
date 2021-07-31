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
    class FireBall : ASkill
    {

        public FireBall()
        {
            Name = "火球術";
            damageM = 2.0;
            costMp = 10;
        }


        public override void Attack(IBaseHero useHero, IBaseHero targetGuy)
        {
            useHero.LoseMp(costMp);
            int damage = (int)(useHero.GetInt() * damageM);
            if (damage <= 1) damage = 1;

            base.AttackResult(useHero, targetGuy, damage);
        }
    }
}
