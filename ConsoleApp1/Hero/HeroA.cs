﻿using ConsoleApp1.BaseInterface;
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
        public int Exp = 0;

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
            Console.WriteLine(" [{0}] 已習得 {1} ", this.GetName(), skill.GetName());

            return "已習得" + skill.GetName();
        }

        public string[] ShowSkillList()
        {
            Console.WriteLine("[技能清單]");
            int index = 0;
            foreach (var skill in SkillList)
            {
                Console.WriteLine("{0}. {1}",++index, skill.GetName());
            }
            Console.WriteLine("請輸入正確名稱來使用技能.....");

            return this.SkillList.Select(x => x.GetName()).ToArray();
        }

        public void UseNormalAttack(IBaseHero targetGuy)
        {
            ISkill normalAttack = new NormalAttack();
            normalAttack.Attack(this, targetGuy);
        }

        void IHero.UseSkill(string skillName,IBaseHero targetGuy)
        {
            ISkill skill= this.SkillList.FirstOrDefault(x => x.GetName() == skillName);
            if (skill!=null)
            {
                if (this.CheckMp(skill.GetCostMp()))
                {
                    skill.Attack(this, targetGuy);
                }
                else
                {
                    Console.WriteLine("MP 不足");
                    return ;
                }
                
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

        public bool SetName(string name)
        {
            this.Name = name;
            return true;
        }

        public string GetName()
        {
            return this.Name;
        }


        public int GetHp()
        {
            return this.Hp;
        }

        public int GetMp()
        {
            return this.Mp;
        }

        public void AddExp(int exp)
        {
            Console.WriteLine("獲得 {0} 點經驗值", exp);

            this.Exp += exp;
        }

        public void ShowStatus()
        {
            Console.WriteLine("目前狀態");
            Console.WriteLine("Hp : {0}",this.Hp);
            Console.WriteLine("Mp : {0}", this.Mp);
            Console.WriteLine("Exp : {0}", this.Exp);
        }
    }
}
