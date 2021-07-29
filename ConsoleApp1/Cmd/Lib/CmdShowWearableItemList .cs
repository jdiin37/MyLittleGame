using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdShowWearableItemList : ICmd
    {
        private string name = "裝備";
        private string excuteCode = "3";
        public string GetExcuteCode()
        {
            return excuteCode;
        }
        public void ExcuteCmd(IHero hero)
        {
            hero.ShowUseableItemList();
        }

        public string GetName()
        {
            return name;
        }
    }
}
