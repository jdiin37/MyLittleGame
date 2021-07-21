using ConsoleApp1.BaseInterface;
using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    interface IMonster:IBaseHero
    {
        public int GetExp();

        public bool IsAlive();
    }
}
