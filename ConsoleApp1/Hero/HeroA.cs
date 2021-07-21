using ConsoleApp1.BaseInterface;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    class HeroA : IHero
    {
        public string Name = "英雄A";

        public int MaxHp = 300;
        public int Hp = 300;

        public int MaxMp = 50;
        public int Mp = 50;

        public int Str = 20;
        public int Int = 15;

        public int Defense = 10;

        public List<ISkill> SkillList = new List<ISkill>();
        #region HP MP setter
        int IBaseHero.AddHp(int addHp)
        {
            this.Hp += addHp;
            if(this.Hp >= MaxHp) this.Hp = MaxHp;

            return this.Hp;
        }

        int IBaseHero.AddMp(int addMp)
        {
            this.Mp += addMp;
            if (this.Mp >= MaxMp)this.Mp = MaxMp;
            
            return this.Mp;
        }


        int IBaseHero.LoseHp(int loseHp)
        {
            this.Hp -= loseHp;
            if (this.Hp <= 0) this.Hp = 0;
            
            return this.Hp;
        }

        int IBaseHero.LoseMp(int loseMp)
        {
            this.Mp -= loseMp;
            if (this.Mp <= 0)this.Mp = 0;
            return this.Mp;
        }
        #endregion

        

        public string AddSkill(ISkill skill)
        {
            this.SkillList.Add(skill);
            Console.WriteLine("已習得 {0}", skill.GetName());

            return "已習得" + skill.GetName();
        }

        public string[] ShowSkillList()
        {
            Console.WriteLine("----技能清單----");
            int index = 0;
            foreach (var skill in SkillList)
            {
                Console.WriteLine("{0}. {1}",++index, skill.GetName());
            }
            Console.WriteLine("--------------");

            return this.SkillList.Select(x => x.GetName()).ToArray();
        }


        void IHero.UseSkill(string skillName,IBaseHero targetGuy)
        {
            ISkill skill= this.SkillList.FirstOrDefault(x => x.GetName() == skillName);
            if (skill!=null)
            {
                if (!skill.Attack(this, targetGuy))
                {
                    ISkill normalAttack = new NormalAttack();
                    normalAttack.Attack(this, targetGuy);
                };
            }
            else
            {
                Console.WriteLine("您沒有 {0} ", skillName);
            }
        }

        int IBaseHero.GetInt()
        {
            return this.Int;
        }

        int IBaseHero.GetStr()
        {
            return this.Str;
        }

        int IBaseHero.GetDefense()
        {
            return this.Defense;
        }

        string IBaseHero.GetName()
        {
            return this.Name;
        }

        

        public bool CheckMp(int costMp)
        {
            return this.Mp >= costMp;
        }
    }
}
