using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdTalk : ICmd
    {
        private string name = "找人聊天";
        private string excuteCode = "T";
        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            string talk = hero.GetMap().GetTalk();

            Console.WriteLine("\"{0}\"", talk);
            Console.ReadLine();
        }


        public string GetName()
        {
            return name;
        }
    }
}
