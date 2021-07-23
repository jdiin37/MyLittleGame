using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public class MonsterProvider : IMonsterProvider
    {
        public List<IMonster> GetMonstersAll()
        {
            List<IMonster> monstersList = new List<IMonster>();
            monstersList.Add(new Monster1());
            monstersList.Add(new Monster2());
            monstersList.Add(new MonsterBoss1());
            monstersList.Add(new Monster3());
            monstersList.Add(new Monster4());
            monstersList.Add(new Monster5());
            return monstersList;
            
        }

        public List<IMonster> GetMonstersFitHero(IHero hero)
        {
            List<IMonster> monstersList = GetMonstersAll();
            monstersList = monstersList.Where(x => x.GetLv() <= hero.GetLv()).ToList();
            return monstersList;
        }
    }
}
