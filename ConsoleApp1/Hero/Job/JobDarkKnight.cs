using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public class JobDarkKnight : IHeroJob
    {
        public string Name = "黑暗騎士";

        public int DefaultStr = 99;

        public int DefaultInt = 80;

        public int DefaultDefense = 40;

        public int DefaultLv = 1;

        public int LvUpAddStr = 8;

        public int LvUpAddInt = 7;

        public int LvUpAddDefense = 5;

        public int LvUpAddHp = 104;

        public int LvUpAddMp = 67;

        public List<ISkill> defaultSkills = new() { new StrongAttack(),new Blizzard() };


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
