using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public interface IMonsterProvider
    {
        public List<IMonster> GetMonstersAll();

        public List<IMonster> GetMonstersFitHero(IHero hero);

        public List<IMonster> GetMonstersByMap(IHero hero);
    }
}
