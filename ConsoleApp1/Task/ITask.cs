
using ConsoleApp1.Hero;
using ConsoleApp1.Task.Process;

namespace ConsoleApp1.Task
{
    public interface ITask
    {
        public void TaskStart(IHero hero);

        public void TaskCompleted(IHero hero);

        public string GetName();

        public int GetStartLv();

        public bool IsCompleted();

        public string GetTaskCode();
        public ITaskProcess GetTaskProcess();

    }
}
