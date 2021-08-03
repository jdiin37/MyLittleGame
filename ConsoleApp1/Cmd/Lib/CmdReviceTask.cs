using ConsoleApp1.Hero;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdReviceTask : ACmd
    {
        private Dictionary<string, ITask> taskDic = new Dictionary<string, ITask>();

        public CmdReviceTask()
        {
            this.name = "接收任務";
            this.excuteCode = "Q";
        }

        private void InitTaskList(IHero hero)
        {
            taskDic = new Dictionary<string, ITask>();
            var taskList = hero.GetMap().GetTaskList(hero);

            int index = 1;
            foreach (var task in taskList)
            {
                taskDic.Add(index.ToString(), task);
                index++;
            }
        }

        private void ShowTaskList(IHero hero)
        {
            var heroAcceptTask = hero.GetAllAcceptTask();
            if (taskDic.Any())
            {
                Console.WriteLine(" [請輸入要接受/提交的任務代碼]");
            }
            foreach (var item in taskDic)
            {
                string status = "可接";
                var IngTask = heroAcceptTask.FirstOrDefault(x => x.GetName() == item.Value.GetName());
                if (IngTask != null)
                {
                    status = IngTask.IsCompleted() ? "已完成" : "進行中";
                }
                Console.WriteLine(" [{0}] {1} ---{2}", item.Key, item.Value.GetName(), status);
            }
        }

        private void ChooseTask(IHero hero)
        {
            string cmd = Console.ReadLine();
            if (taskDic.ContainsKey(cmd))
            {
                hero.ProcessTask(taskDic[cmd]);
            }
        }
    
        public override void ExcuteCmd(IHero hero)
        {
            InitTaskList(hero);
            ShowTaskList(hero);
            ChooseTask(hero);
        }
    }
}
