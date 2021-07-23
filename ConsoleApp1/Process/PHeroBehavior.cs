using ConsoleApp1.Hero;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Process
{
    class PHeroBehavior
    {
        public void StartNaming(IHero theHero)
        {
            Console.WriteLine("您好,請為您的英雄命名");
            string heroName = Console.ReadLine();

            Console.WriteLine("英雄名稱叫做 {0} 對嗎? (Y/N) ", heroName);
            if (Console.ReadLine() == "Y")
            {
                theHero.SetName(heroName);
                Console.WriteLine(" [{0}] , 你好, 這是一個美好的世界~", heroName);
            }
            else
            {
                StartNaming(theHero);
            }
        }



        public void GetDefaultSkill(IHero theHero)
        {

            ISkill defaultSkill = new FireBall();

            theHero.AddSkill(defaultSkill);
            
        }

        public void GetDefaultJob(IHero hero)
        {

            IHeroJob heroJob;
            if (hero.GetName() == "咖波")
            {
                heroJob = new JobDarkKnight();
            }
            else
            {
                heroJob = new JobA();
            }

            HeroChangeJob(hero, heroJob);
        }


        public void HeroChangeJob(IHero theHero,IHeroJob job)
        {

            theHero.ChangeJob(job);

        }
    }
}
