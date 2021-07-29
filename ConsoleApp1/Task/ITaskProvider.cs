using ConsoleApp1.Hero;

namespace ConsoleApp1.Task
{
    public interface ITaskProvider
    {
        public ITask GetMainTaskByMap(IHero hero);
        public ITask GetFirstTask();

    }
}
