using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    abstract public class ACmd : ICmd
    {

        public string name { get; set; }
        public string excuteCode { get; set; }

        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public string GetName()
        {
            return name;
        }
        abstract public void ExcuteCmd(IHero hero);
    }
}
