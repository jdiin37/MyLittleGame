using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Map
{
    public class MapField1 : AMap
    {
        public MapField1(ITaskProvider taskProvider):base(taskProvider)
        {
            base.name = "草原";
            base.mapType = MapType.Field;
            base.cmdList = new List<ICmd> { new CmdKillMonster() };
            base.taskNameList = new string[] { };
            base.monsterNameList = new string[] { "哥布林" };
        }

        public override string GetTalk()
        {
            Random Rnd = new Random();

            List<string> WordList = new List<string>
            {

            };

            int r = Rnd.Next(WordList.Count);
            return WordList[r];
        }
    }
}
