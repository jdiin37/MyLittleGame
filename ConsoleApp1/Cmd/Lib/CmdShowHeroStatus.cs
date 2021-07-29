using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdShowHeroStatus : ICmd
    {
        private string name = "狀態";
        private string excuteCode = "1";
        public string GetExcuteCode()
        {
            return excuteCode;
        }
        public void ExcuteCmd(IHero hero)
        {
            hero.ShowStatus();
        }

        public string GetName()
        {
            return name;
        }
    }
}
