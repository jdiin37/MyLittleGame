using ConsoleApp1.Hero;
using ConsoleApp1.Task.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Task
{
    public class TaskProvider : ITaskProvider
    {
        ITaskLib TaskLib;
        List<ITask> allTaskList;

        public TaskProvider()
        {
            TaskLib = new TaskLib();
            allTaskList = TaskLib.GetAllTaskList();
        }

        public ITask GetFirstTask()
        {
            return allTaskList.Where(x => x.GetTaskCode() == "1").FirstOrDefault();

        }


        public ITask GetMainTaskByMap(IHero hero)
        {
            var heroAcceptTaskList = hero.GetAllAcceptTask().Select(x => x.GetName()).ToArray();
            var mapTaskNameList = hero.GetMap().GetTaskNameList();

            var tasks = allTaskList.Where(x => x.GetStartLv() <= hero.GetLv() && mapTaskNameList.Contains(x.GetName())).OrderBy(x=>x.GetStartLv()).ToList();

            foreach (var task in tasks)
            {
                if (!heroAcceptTaskList.Contains(task.GetName()))
                {
                    return task;
                }
            }

            return null;

        }

        public List<ITask> GetTaskListByMap(IHero hero)
        {
            
            var mapTaskNameList = hero.GetMap().GetTaskNameList();

            var tasks = allTaskList.Where(x => x.GetStartLv() <= hero.GetLv() && mapTaskNameList.Contains(x.GetName())).OrderBy(x => x.GetStartLv()).ToList();

           
            return tasks;
        }
    }
}
