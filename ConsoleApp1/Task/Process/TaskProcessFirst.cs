using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Task.Process
{
    public class TaskProcessFirst : ITaskProcess
    {
        public string TaskMappingName;

        List<string> talkList = new List<string>()
            {
                " [故事開始了....]",
                " [你是....?]",
            };

        public TaskProcessFirst(string taskMappingName)
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

            hero.SetName(GetCustomHeroName());
            hero.ChangeJob(GetDefaultJob());
            ITask task = hero.GetAllAcceptTask().FirstOrDefault(x => x.GetName() == TaskMappingName);
            task.TaskCompleted(hero);
        }

        private string GetCustomHeroName()
        {
            Console.WriteLine(" [您好,請為您的英雄命名]");
            string heroName = Console.ReadLine();

            if (heroName != "")
            {
                Console.WriteLine(" [英雄名稱叫做 {0} 對嗎? (Y/N) ]", heroName);
                if (Console.ReadLine() == "Y")
                {
                    return heroName;
                }
            }

            return GetCustomHeroName();
        }

        private IHeroJob GetDefaultJob()
        {
            Console.WriteLine(" [您渴望力量嗎? (Y/N))]");
            string cmd = Console.ReadLine();
            if(cmd == "Y")
            {
                return new JobDarkKnight();
            }
            else
            {
                return new JobA();
            }
        }
    }
}
