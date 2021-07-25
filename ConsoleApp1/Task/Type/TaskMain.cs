

using ConsoleApp1.Task;
using ConsoleApp1.Task.Reward;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Task.Type
{
    public class TaskMain : ITask
    {
        public string TaskName;

        public int StartLv;

        public bool IsComplete = false;

        public List<string> TalkList;

        public object CompleteConditions;

        public IReward Reward;

        public TaskMain(string taskName,int startLv, List<string> talkList, IReward reward)
        {
            this.TaskName = taskName;
            this.StartLv = startLv;
            this.TalkList = talkList;
            this.Reward = reward;
        }

      

        public void CompelteTask()
        {
            this.IsComplete = true;
        }

        public string GetName()
        {
            return this.TaskName;
        }

        public int GetStartLv()
        {
            return this.StartLv;
        }

        public bool IsCompleted()
        {
            return this.IsComplete;
        }

        public void StartTask()
        {
            foreach (string talk in TalkList)
            {
                Console.WriteLine(talk);
                Console.ReadLine();
            }
        }
    }
}
