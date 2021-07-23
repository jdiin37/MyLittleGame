using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public class JobA : IHeroJob
    {
        public string Name = "初心者";

        public int DefaultStr = 10;

        public int DefaultInt = 10;

        public int DefaultDefense = 2;

        public int DefaultLvUpExp = 200;

        public int DefaultLv = 1;

        public int LvUpAddStr = 2;

        public int LvUpAddInt = 2;

        public int LvUpAddDefense = 1;

        public int LvUpAddHp = 33;

        public int LvUpAddMp = 6;

        public List<ISkill> defaultSkills = new() { new FireBall() };


        public int GetDefense()
        {
            return this.DefaultDefense;
        }

        public int GetInt()
        {
            return this.DefaultInt;
        }

        public int GetLvUpAddDefense()
        {
            return this.LvUpAddDefense;
        }

        public int GetLvUpAddHp()
        {
            return this.LvUpAddHp;
        }

        public int GetLvUpAddInt()
        {
            return this.LvUpAddInt;
        }

        public int GetLvUpAddMp()
        {
            return this.LvUpAddMp;
        }

        public int GetLvUpAddStr()
        {
            return this.LvUpAddStr;
        }

        public string GetName()
        {
            return this.Name;
        }

        public List<ISkill> GetSkills()
        {
            return this.defaultSkills;
        }

        public int GetStr()
        {
            return this.DefaultStr;
        }
    }
}
