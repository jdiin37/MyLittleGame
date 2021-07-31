using ConsoleApp1.BaseInterface;
using System;

namespace ConsoleApp1.Skill
{
    class StrongAttack : ASkill
    {

        public StrongAttack()
        {
            Name = "強力攻擊";
            damageM = 1.8;
            costMp = 0;
        }


        public override void Attack(IBaseHero useHero, IBaseHero targetGuy)
        {
            int damage = (int)(useHero.GetStr() * damageM - targetGuy.GetDefense());
            if (damage <= 1) damage = 1;

            base.AttackResult(useHero, targetGuy, damage);
        }

    }
}
