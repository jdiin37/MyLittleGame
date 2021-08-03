using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdReturnMainMenu : ACmd
    {

        public CmdReturnMainMenu()
        {
            this.name = "回主選單";
            this.excuteCode = "Exit";
        }

        public override void ExcuteCmd(IHero hero)
        {
            Console.WriteLine("確定要離開遊戲嗎? (Y/N)");
        }
    }
}
