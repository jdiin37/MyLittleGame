using ConsoleApp1.BaseInterface;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    class MonsterBoss1 : IMonster
    {
        public string Name = "蔡英文";
        public int Lv = 10;

        public int MaxHp = 200;
        public int Hp = 200;

        public int MaxMp = 50;
        public int Mp = 50;

        public int Str = 100;
        public int Int = 5;

        public int Defense = 0;
        public int Exp = 700;

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

        #endregion

        public void UseSkill()
        {
            throw new NotImplementedException();
        }

        public void Attack(IBaseHero targetGuy)
        {
            ISkill normalAttack = new NormalAttack();
            normalAttack.Attack(this, targetGuy);
        }

        
    }
}
