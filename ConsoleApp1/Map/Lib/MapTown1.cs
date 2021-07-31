using ConsoleApp1.Cmd;
using ConsoleApp1.Enum;
using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Map
{
    public class MapTown1 : AMap
    {

        public MapTown1(ITaskProvider taskProvider) : base(taskProvider)
        {
            base.name = "落雨鎮";
            base.mapType = MapType.Town;
            base.cmdList = new List<ICmd> { new CmdRest(), new CmdTalk(), new CmdReviceTask() };
            base.taskNameList = new string[] { "幫助老人", "河川上游" };
            base.monsterNameList = new string[] { };
        }

        public override string GetTalk()
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

    }
}
