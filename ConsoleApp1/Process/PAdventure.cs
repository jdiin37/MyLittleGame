using ConsoleApp1.Controller;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Process
{
    public class PAdventure
    {

        static Random rnd = new Random();
        IMonsterProvider MonsterProvider;


        public PAdventure()
        {
            this.MonsterProvider = new MonsterProvider();
        }

        public void EncounterMonster(IHero theHero)
        {
            IMonster monster = GetRandomMonster(theHero);
            Console.WriteLine("!!!!!! 遭遇到 {0} !!!!!!", monster.GetName());

            StartBattle(theHero, monster);
        }

        private void StartBattle(IHero hero,IMonster monster)
        {
            BattleMeun newBattle = new BattleMeun(hero, monster);
            while (!newBattle.IsBattleFinish())
            {
                newBattle.ShowMenu();
            }
            newBattle.GetBattleReward();
        }

        private IMonster GetRandomMonster(IHero theHero)
        {
            List<IMonster> MonstersList = MonsterProvider.GetMonstersFitHero(theHero);
            int r = rnd.Next(MonstersList.Count);
            return MonstersList[r];
        }

    }
}
