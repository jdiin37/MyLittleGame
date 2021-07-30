using ConsoleApp1.Hero;
using System.Collections.Generic;

namespace ConsoleApp1.Task
{
    public interface ITaskProvider
    {
        public ITask GetMainTaskByMap(IHero hero);
        public ITask GetFirstTask();

        public List<ITask> GetTaskListByMap(IHero hero);
    }
}
