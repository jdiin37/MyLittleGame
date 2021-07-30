using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map
{
    public interface IMap
    {
        public void SetMonster(List<IMonster> monsters);

       

        public string GetMapName();

        public MapType GetMapType();

        public Dictionary<string, ICmd> GetMapCmdList();

        public string GetTalk();

        public List<ITask> GetTaskList(IHero hero);
        public string[] GetTaskNameList();

        public string[] GetMonsterNameList();

    }
}
