using ConsoleApp1.BaseInterface;
using ConsoleApp1.Item;
using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Monster
{
    public class MonsterBoss : AMonster
    {
        public List<ISkill> SkillList;

        public MonsterBoss(MonsterProperty monsterProperty, List<ISkill> skillList) : base(monsterProperty)
        {
            this.SkillList = skillList;
        }

        private ISkill ChoseSkill()
        {
            Random rnd = new();
            int r = rnd.Next(SkillList.Count);
            return SkillList[r];
        }


        public override void Attack(IBaseHero targetGuy)
        {
            ISkill normalAttack = ChoseSkill();
            normalAttack.Attack(this, targetGuy);
        }
    }
}
