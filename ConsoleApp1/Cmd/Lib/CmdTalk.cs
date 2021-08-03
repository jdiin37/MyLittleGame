using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdTalk : ACmd
    {

        public CmdTalk()
        {
            this.name = "找人聊天";
            this.excuteCode = "T";
        }

        public override void ExcuteCmd(IHero hero)
        {
            string talk = hero.GetMap().GetTalk();

            Console.WriteLine("\"{0}\"", talk);
            Console.ReadLine();
        }
    }
}
