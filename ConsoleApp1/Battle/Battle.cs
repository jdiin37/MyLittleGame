﻿using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using ConsoleApp1.Monster.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Battle
{
    public class Battle : IBattle
    {
        readonly IMonsterProvider MonsterProvider;

        public Battle()
        {
            this.MonsterProvider = new MonsterProvider();
        }

        public void EncounterMonster(IHero hero)
        {
            IMonster monster = GetRandomMonster(hero);
            Console.WriteLine("!!!!!! 遭遇到 {0} !!!!!!", monster.GetName());

            StartBattle(hero, monster);
        }

        private IMonster GetRandomMonster(IHero theHero)
        {
            Random rnd = new Random();
            List<IMonster> MonstersList = MonsterProvider.GetMonstersFitHero(theHero);
            int r = rnd.Next(MonstersList.Count);
            return MonstersList[r];
        }

        private void StartBattle(IHero hero, IMonster monster)
        {
            //BattleMeun newBattle = new BattleMeun(hero, monster);
            //while (!newBattle.IsBattleFinish())
            //{
            //    newBattle.ShowMenu();
            //}
            //newBattle.GetBattleReward();
        }
    }
}
