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


        public PAdventure()
        {
            
        }

        public void EncounterMonster(IHero theHero)
        {
            IMonster monster = GetRandomMonster();
            Console.WriteLine("!!!!!! 遭遇到 {0} !!!!!!", monster.GetName());

            BattleMeun newBattle = new BattleMeun(theHero, monster);
            while (!newBattle.isBattleFinish())
            {
                newBattle.ShowMenu();
            }
        }

        private IMonster GetRandomMonster()
        {
            List<IMonster> MonstersList = GetAllMonster();
            int r = rnd.Next(MonstersList.Count);
            return MonstersList[r];
        }

        private List<IMonster> GetAllMonster()
        {
            List<IMonster> monstersList = new List<IMonster>();
            monstersList.Add(new Monster1());
            monstersList.Add(new Monster2());
            return monstersList;
        }
       
    }
}
