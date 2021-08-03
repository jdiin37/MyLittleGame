using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdRest : ACmd
    {

        public CmdRest()
        {
            this.name = "休息";
            this.excuteCode = "R";
        }

        public override void ExcuteCmd(IHero hero)
        {
            hero.AddHp(9999);
            hero.AddMp(9999);
            Console.WriteLine(" 適當的休息過後, 您覺得精神甦醒 ");
        }
    }
}
