using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdShowHeroStatus : ACmd
    {
        public CmdShowHeroStatus()
        {
            this.name = "狀態";
            this.excuteCode = "1";
        }

        public override void ExcuteCmd(IHero hero)
        {
            hero.ShowStatus();
        }
    }
}
