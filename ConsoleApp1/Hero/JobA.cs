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

        public int DefaultStr = 20;

        public int DefaultInt = 10;

        public int DefaultDefense = 15;

        public int DefaultLvUpExp = 200;

        public int DefaultLv = 1;

        public List<ISkill> defaultSkills = new() { new FireBall() };

        public int GetDefense()
        {
            return this.DefaultDefense;
        }

        public int GetInt()
        {
            return this.DefaultInt;
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
