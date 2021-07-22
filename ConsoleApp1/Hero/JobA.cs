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
        public string name = "初心者";

        public int defaultStr = 20;

        public int defaultInt = 10;

        public int defaultDefense = 15;

        public int defaultLvUpExp = 200;

        public int defaultLv = 1;

        public ISkill defaultSkill = new FireBall();
    }
}
