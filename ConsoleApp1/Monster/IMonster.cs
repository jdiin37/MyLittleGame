using ConsoleApp1.BaseInterface;
using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public interface IMonster:IBaseHero
    {
        public int GetExp();

        public bool IsAlive();

        public void Attack(IBaseHero targetGuy);
    }
}
