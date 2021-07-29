using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Task.Process
{
    public class TaskProcess2 : ITaskProcess
    {
        public string TaskMappingName;

        List<string> talkList = new List<string>()
            {
                " 老人:[你, 可以幫我到外頭找回我的錢包嗎?]",
                " 老人:[我會給你獎勵的]",
            };

        public TaskProcess2(string taskMappingName)
        {
            TaskMappingName = taskMappingName;
        }



        public void TaskStart(IHero hero)
        {
            foreach (string talk in talkList)
            {
                Console.WriteLine(talk);
                Console.ReadLine();
            }

        }

        public void CheckTaskCompleted(IHero hero)
        {
            ITask task = hero.GetAllAcceptTask().FirstOrDefault(x => x.GetName() == TaskMappingName);

            if (task == null) return;
             
            if (hero.CheckHasItem("老人的錢包"))
            {
                Console.WriteLine(" 老人:[感謝你你幫我找回錢包,這是說好的獎勵,拿去吧] ");
                task.TaskCompleted(hero);
            }
            else
            {
                Console.WriteLine(" 老人:[還沒找到錢包嗎?] ");
            }
        }

    }
}
