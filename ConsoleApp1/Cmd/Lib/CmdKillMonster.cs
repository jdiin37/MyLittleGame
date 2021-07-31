﻿using ConsoleApp1.Battle;
using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdKillMonster : ICmd
    {
        private string name = "打怪";
        private string excuteCode = "K";
        private IBattle battle;

        public CmdKillMonster()
        {
            battle = new Battle.Battle();
        }

        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            battle.EncounterMonster(hero);
        }


        public string GetName()
        {
            return name;
        }
    }
}