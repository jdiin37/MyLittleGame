using ConsoleApp1.Task.Model;
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
        private static List<ITask> allTaskList;

        public TaskLib()
        {
            if (allTaskList == null)
            {
                InitTaskList();
            }
        }

        private void InitTaskList()
        {
            allTaskList = new List<ITask>();
            allTaskList.Add(InitTaskMain1());
            allTaskList.Add(InitTaskMain2());
        }

        private ITask InitTaskMain1()
        {
            TaskProperty taskProperty = new TaskProperty {
                TaskName = "故事開始了",
                StartLv = 1,
                TaskCode = "1"
            };

            IReward reward = new RewardNormal(100);
            ITaskProcess taskProcess = new TaskProcess1(taskProperty.TaskName);
            ITask newTaskMain = new TaskMain(taskProperty, taskProcess, reward);

            return newTaskMain;
        }

        private ITask InitTaskMain2()
        {
            TaskProperty taskProperty = new TaskProperty
            {
                TaskName = "幫助老人",
                StartLv = 1,
                TaskCode = "2"
            };
            IReward reward = new RewardNormal(500);
            ITaskProcess taskProcess = new TaskProcess2(taskProperty.TaskName);
            ITask newTaskMain = new TaskMain(taskProperty, taskProcess, reward);

            return newTaskMain;
        }

        

        public List<ITask> GetAllTaskList()
        {
            return allTaskList;
        }
    }
}
