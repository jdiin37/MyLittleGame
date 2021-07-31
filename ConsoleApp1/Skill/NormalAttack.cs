using ConsoleApp1.BaseInterface;

namespace ConsoleApp1.Skill
{
    class NormalAttack : ASkill
    {

        public NormalAttack()
        {
            Name = "普通攻擊";
            damageM = 1.2;
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
