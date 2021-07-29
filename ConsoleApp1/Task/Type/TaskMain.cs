using ConsoleApp1.Hero;
using ConsoleApp1.Task.Model;
using ConsoleApp1.Task.Process;
using ConsoleApp1.Task.Reward;
using System;

namespace ConsoleApp1.Task.Type
{
    public class TaskMain : ITask
    {
        public string TaskName;

        public string TaskCode;

        public int StartLv;

        public bool IsComplete = false;

        public ITaskProcess TaskProcess;

        public IReward Reward;


        public TaskMain(TaskProperty taskProperty, ITaskProcess TaskProcess, IReward reward)
        {
            this.TaskName = taskProperty.TaskName;
            this.TaskCode = taskProperty.TaskCode;
            this.StartLv = taskProperty.StartLv;

            this.Reward = reward;
            this.TaskProcess = TaskProcess;
        }

      
        public void TaskCompleted(IHero hero)
        {
            this.IsComplete = true;
            Console.WriteLine(" [{0}] 已完成任務 {1}", hero.GetName(), this.GetName());
            hero.AddExp(Reward.GetRewardExp());
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

        public void TaskStart(IHero hero)
        {
            TaskProcess.TaskStart(hero);
        }

        public string GetTaskCode()
        {
            return TaskCode;
        }
    }
}
