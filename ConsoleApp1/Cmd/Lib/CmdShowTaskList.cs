using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdShowTaskList : ICmd
    {
        private string name = "任務";
        private string excuteCode = "4";
        public string GetExcuteCode()
        {
            return excuteCode;
        }
        public void ExcuteCmd(IHero hero)
        {
            Console.WriteLine("[任務名稱 / 狀態]");
            foreach (var task in hero.GetAllAcceptTask())
            {
                Console.WriteLine(" {0} / {1}", task.GetName(), task.IsCompleted() ? "已完成" : "進行中");
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}
