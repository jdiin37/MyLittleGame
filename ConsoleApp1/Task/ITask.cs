
namespace ConsoleApp1.Task
{
    public interface ITask
    {
        public void StartTask();

        public void CompelteTask();

        public string GetName();

        public int GetStartLv();

        public bool IsCompleted();
    }
}
