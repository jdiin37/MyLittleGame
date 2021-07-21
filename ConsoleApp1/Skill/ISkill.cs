using ConsoleApp1.BaseInterface;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ISkill
    {
        public bool Attack(IBaseHero useHero,IBaseHero targetMoster);

        public string GetName();

        public int GetId();

        public int GetCostMp();
    }
}
