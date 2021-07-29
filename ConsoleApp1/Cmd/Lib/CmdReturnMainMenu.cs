using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdReturnMainMenu : ICmd
    {
        private string name = "回主選單";
        private string excuteCode = "Exit";
        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            Console.WriteLine("確定要離開遊戲嗎? (Y/N)");

        }


        public string GetName()
        {
            return name;
        }
    }
}
