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
            IReward reward = new RewardNormal(100);
            List<string> talkList = new List<string>()
            {
                " [故事開始了....]",
                " [你是....?]",
            };
            TaskMain newTaskMain = new TaskMain("故事開始了",1, talkList, reward);

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
