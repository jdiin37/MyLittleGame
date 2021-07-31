using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System.Collections.Generic;

namespace ConsoleApp1.Map
{
    abstract public class AMap : IMap
    {
        public string name;
        public MapType mapType;
        public List<ICmd> cmdList;
        public string[] taskNameList;
        public string[] monsterNameList;

        private ITaskProvider taskProvider;

        public AMap(ITaskProvider taskProvider)
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



        abstract public string GetTalk();
    }
}
