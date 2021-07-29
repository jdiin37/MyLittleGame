using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdReviceTask : ICmd
    {
        private string name = "接收任務";
        private string excuteCode = "Q";
        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            

            var task = hero.GetMap().GetTask(hero);

            if(task == null)
            {
                Console.WriteLine(" [沒有任務]");
                return;
            }

            hero.AcceptTask(task);
        }


        public string GetName()
        {
            return name;
        }
    }
}
