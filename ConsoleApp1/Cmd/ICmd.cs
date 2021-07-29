using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public interface ICmd
    {
        public string GetName();

        public void ExcuteCmd(IHero hero);

        public string GetExcuteCode();
    }
}
