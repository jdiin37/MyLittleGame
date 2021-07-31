using ConsoleApp1.BaseInterface;
using ConsoleApp1.Item;
using ConsoleApp1.Item.Lib;
using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public class MonsterNormal : AMonster
    {

        public MonsterNormal(MonsterProperty monsterProperty) : base( monsterProperty) { }

        public override void Attack(IBaseHero targetGuy)
        {
            ISkill normalAttack = new NormalAttack();
            normalAttack.Attack(this, targetGuy);
        }
    }
}
