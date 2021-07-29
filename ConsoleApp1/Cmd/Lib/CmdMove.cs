using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdMove : ICmd
    {
        private string name = "移動";
        private string excuteCode = "5";
        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            Console.WriteLine("[請選擇要去的地方~]");
            
        }


        public string GetName()
        {
            return name;
        }
    }
}
