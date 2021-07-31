using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Map
{
    public class MapField1 : IMap
    {

        private string name = "草原";
        private MapType mapType = MapType.Field;
        private List<ICmd> cmdList = new List<ICmd> { new CmdKillMonster()};
        string[] taskNameList = new string[] {};
        string[] monsterNameList = new string[] { "哥布林", "史萊姆", "狼人" };

        private ITaskProvider taskProvider;

        public MapField1(ITaskProvider taskProvider)
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
