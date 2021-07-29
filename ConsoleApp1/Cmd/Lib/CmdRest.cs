using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdRest : ICmd
    {
        private string name = "休息";
        private string excuteCode = "R";
        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            hero.AddHp(9999);
            hero.AddMp(9999);
            Console.WriteLine(" 適當的休息過後, 您覺得精神甦醒 ");
        }


        public string GetName()
        {
            return name;
        }
    }
}
