using ConsoleApp1.Task.Process;
using ConsoleApp1.Task.Reward;
using ConsoleApp1.Task.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task.Lib
{
    public class TaskLib : ITaskLib
    {



        private ITask InitTaskMainFirst()
        {
            string taskName = "故事開始了";
            IReward reward = new RewardNormal(100);
            ITaskProcess taskProcess = new TaskProcessFirst(taskName);
            TaskMain newTaskMain = new TaskMain(taskName, 1, taskProcess, reward);

            return newTaskMain;
        }

        private ITask InitTaskMain2()
        {
            string taskName = "我是誰";
            IReward reward = new RewardNormal(100);
            ITaskProcess taskProcess = new TaskProcessFirst(taskName);
            TaskMain newTaskMain = new TaskMain(taskName, 1, taskProcess, reward);

            return newTaskMain;
        }

        private ITask InitTaskMain3()
        {
            string taskName = "現在時間";
            IReward reward = new RewardNormal(100);
            ITaskProcess taskProcess = new TaskProcessFirst(taskName);
            TaskMain newTaskMain = new TaskMain(taskName, 1, taskProcess, reward);

            return newTaskMain;
        }

        private ITask InitTaskMain4()
        {
            string taskName = "開始冒險";
            IReward reward = new RewardNormal(100);
            ITaskProcess taskProcess = new TaskProcessFirst(taskName);
            TaskMain newTaskMain = new TaskMain(taskName, 1, taskProcess, reward);

            return newTaskMain;
        }

        public List<ITask> GetAllTaskList()
        {

            List<ITask> allTaskList = new List<ITask>();

            allTaskList.Add(InitTaskMainFirst());



            return allTaskList;
        }
    }
}
