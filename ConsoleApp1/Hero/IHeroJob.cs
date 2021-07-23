using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public interface IHeroJob
    {
        public int GetStr();
        public int GetInt();
        public int GetDefense();

        public string GetName();

        public List<ISkill> GetSkills();
    }
}
