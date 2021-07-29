using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Task.Process
{
    public class TaskProcess1 : ITaskProcess
    {
        public string TaskMappingName;

        List<string> talkList = new List<string>()
            {
                " [故事開始了....]",
                " [你是....?]",
            };

        public TaskProcess1(string taskMappingName)
        {
            TaskMappingName = taskMappingName;
        }

        public void CheckTaskCompleted(IHero hero)
        {
            ITask task = hero.GetAllAcceptTask().FirstOrDefault(x => x.GetName() == TaskMappingName);
            task.TaskCompleted(hero);
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

            this.CheckTaskCompleted(hero);
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
            Console.WriteLine(" [祝您好運 !!]");
            //string cmd = Console.ReadLine();
            //if(cmd == "Y")
            //{
            //    return new JobDarkKnight();
            //}
            //else
            //{
            //    return new JobA();
            //}

            return new JobA();
        }
    }
}
