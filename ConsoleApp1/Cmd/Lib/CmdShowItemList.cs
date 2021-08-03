using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdShowItemList : ACmd
    {
        public CmdShowItemList()
        {
            this.name = "物品";
            this.excuteCode = "2";
        }

        public override void ExcuteCmd(IHero hero)
        {
            hero.ShowUseableItemList();
        }
    }
}
