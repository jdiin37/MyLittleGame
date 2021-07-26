

using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using ConsoleApp1.Task.Process;
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

        public ITaskProcess TaskProcess;

        public IReward Reward;

        public TaskMain(string taskName,int startLv, ITaskProcess TaskProcess, IReward reward)
        {
            this.TaskName = taskName;
            this.StartLv = startLv;
            this.Reward = reward;
            this.TaskProcess = TaskProcess;
        }

      
        public void TaskCompleted(IHero hero)
        {
            this.IsComplete = true;
            Console.WriteLine(" [{0}] 已完成 {1},獲得獎勵 {2} Exp", hero.GetName(), this.GetName(), Reward.GetRewardExp());
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
    }
}
