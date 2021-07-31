﻿using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Map
{
    public class MapTown1 : IMap
    {

        private string name = "落雨鎮";
        private MapType mapType = MapType.Town;
        private List<ICmd> cmdList = new List<ICmd> { new CmdRest(),new CmdTalk(),new CmdReviceTask() };
        string[] taskNameList = new string[] { "幫助老人","河川上游"};
        string[] monsterNameList = new string[] { };

        private ITaskProvider taskProvider;

        public MapTown1(ITaskProvider taskProvider)
        {
            this.taskProvider = taskProvider;
        }

        public string GetMapName()
        {
            return this.name;
        }

        public MapType GetMapType()
        {
            return mapType;
        }

        public void SetMonster(string[] monsterNameList)
        {
            this.monsterNameList = monsterNameList;
        }

        public Dictionary<string, ICmd> GetMapCmdList()
        {
            Dictionary<string, ICmd> mapMenuDic = new Dictionary<string, ICmd>();
            foreach (var cmd in cmdList)
            {
                mapMenuDic.Add(cmd.GetExcuteCode(), cmd);
            }
            return mapMenuDic;
        }


        public string GetTalk()
        {
            Random Rnd = new Random();

            List<string> WordList = new List<string>
            {
                "這裡是落雨鎮,如果你要找工作的話,就去找那個老人吧",
                "聽說外頭有很多妖怪,你會害怕嗎?",
                "又在下雨了..",
            };

            int r = Rnd.Next(WordList.Count);
            return WordList[r];
        }


        public List<ITask> GetTaskList(IHero hero)
        {
            return taskProvider.GetTaskListByMap(hero);
        }

        public string[] GetTaskNameList()
        {
            return taskNameList;
        }

        public string[] GetMonsterNameList()
        {
            return this.monsterNameList;
        }
    }
}