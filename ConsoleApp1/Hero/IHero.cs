using ConsoleApp1.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    interface IHero:IBaseHero
    {

        public bool CheckMp(int costMp);

        public string AddSkill(ISkill skill);
        public string[] ShowSkillList();

        public void UseSkill(string skillName, IBaseHero targetGuy);

        
    }
}
