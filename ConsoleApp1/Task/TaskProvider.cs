using ConsoleApp1.Hero;
using ConsoleApp1.Task.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    public class TaskProvider : ITaskProvider
    {
        ITaskLib TaskLib;
        List<ITask> allTaskList;

        public TaskProvider(ITaskLib taskLib)
        {
            TaskLib = taskLib;
            allTaskList = TaskLib.GetAllTaskList();
        }

        public ITask GetFirstTask()
        {
            return allTaskList.Where(x => x.GetStartLv() == 1).FirstOrDefault();

        }


        public ITask GetMainTaskByHero(IHero hero)
        {
            var heroCompleteTask = hero.GetAllAcceptTask().Where(x => x.IsCompleted()).Select(x => x.GetName()).ToArray();
            var tasks = allTaskList.Where(x => x.GetStartLv() <= hero.GetLv()).ToList();


            foreach (var task in tasks)
            {
                if (!heroCompleteTask.Contains(task.GetName()))
                {
                    return task;
                }
            }

            return null;

        }


    }
}
