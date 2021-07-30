using ConsoleApp1.Hero;
using ConsoleApp1.Monster.Lib;
using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster
{
    public class MonsterProvider : IMonsterProvider
    {

        IMonsterLib MonsterLib;

        public MonsterProvider()
        {
            MonsterLib = new MonsterLib();
        }

        public List<IMonster> GetMonstersAll()
        {
            List<IMonster> initMonstersList = MonsterLib.GetMonsterList();
            return initMonstersList;
            
        }

        public List<IMonster> GetMonstersFitHero(IHero hero)
        {
            List<IMonster> monstersList = GetMonstersAll();
            monstersList = monstersList.Where(x => x.GetLv() <= hero.GetLv()).ToList();



            return monstersList;
        }
    }
}
