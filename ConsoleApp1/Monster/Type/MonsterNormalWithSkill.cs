using ConsoleApp1.BaseInterface;
using ConsoleApp1.Item;
using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public class MonsterBoss : IMonster
    {
        public string Name;
        public int Lv;

        public int MaxHp;
        public int Hp;

        public int MaxMp;
        public int Mp;

        public int Str;
        public int Int;

        public int Defense;
        public int Exp;

        public List<ISkill> SkillList;
        List<IItem> DropItems = new List<IItem>();

        public MonsterBoss(MonsterProperty monsterProperty, List<ISkill> skillList)
        {
            Name = monsterProperty.Name;
            Lv = monsterProperty.Lv;
            MaxHp = monsterProperty.MaxHp;
            Hp = monsterProperty.MaxHp;
            MaxMp = monsterProperty.MaxMp;
            Mp = monsterProperty.MaxMp;
            Str = monsterProperty.Str;
            Int = monsterProperty.Int;
            Defense = monsterProperty.Defense;
            Exp = monsterProperty.Exp;
            SkillList = skillList;
        }

        #region property getter setter
        public int AddHp(int addHp)
        {
            this.Hp += addHp;
            if (this.Hp >= MaxHp) this.Hp = MaxHp;

            return this.Hp;
        }

        public int AddMp(int addMp)
        {
            this.Mp += addMp;
            if (this.Mp >= MaxMp) this.Mp = MaxMp;

            return this.Mp;
        }
        public int LoseHp(int loseHp)
        {
            this.Hp -= loseHp;
            if (this.Hp <= 0) this.Hp = 0;

            return this.Hp;
        }

        public int LoseMp(int loseMp)
        {
            this.Mp -= loseMp;
            if (this.Mp <= 0) this.Mp = 0;
            return this.Mp;
        }



        public int GetInt()
        {
            return this.Int;
        }

        public int GetStr()
        {
            return this.Str;
        }

        public int GetDefense()
        {
            return this.Defense;
        }

        public int GetExp()
        {
            return this.Exp;
        }
        #endregion


        public ISkill ChoseSkill()
        {
            Random rnd = new();
            int r = rnd.Next(SkillList.Count);
            return SkillList[r];
        }

        public void Attack(IBaseHero targetGuy)
        {
            ISkill normalAttack = ChoseSkill();
            normalAttack.Attack(this, targetGuy);
        }

        public string GetName()
        {
            return this.Name;
        }

        bool IMonster.IsAlive()
        {
            return this.Hp > 0;
        }

        public int GetHp()
        {
            return this.Hp;
        }

        public int GetMp()
        {
            return this.Mp;
        }

        public int GetLv()
        {
            return this.Lv;
        }

        public void GetStatus()
        {
            throw new NotImplementedException();
        }

        public List<IItem> GetDropItems()
        {
            List<IItem> dropItems = new List<IItem>();

            Random rnd = new Random();
            int rndNum = rnd.Next(1, 101);
            foreach (var item in DropItems)
            {
                if (item.GetDropPercentage() >= rndNum)
                {
                    dropItems.Add(item);
                }
            }

            return dropItems;
        }

        public void AddDropItem(IItem dropItem)
        {
            this.DropItems.Add(dropItem);
        }
    }
}
