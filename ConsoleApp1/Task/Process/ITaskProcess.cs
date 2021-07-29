using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task.Process
{
    public interface ITaskProcess
    {
        public void TaskStart(IHero hero);

        public void CheckTaskCompleted(IHero hero);
        
    }
}
