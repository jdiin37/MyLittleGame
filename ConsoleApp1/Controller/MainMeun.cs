using ConsoleApp1.Hero;
using ConsoleApp1.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class MainMeun
    {
        PHeroCreate pHeroCreate;
        AdventureMeun adventureMeun;
        IHero heroA;
        IHeroJob heroJob;

        public MainMeun()
        {
            pHeroCreate = new PHeroCreate();
            heroJob = new JobA();
            heroA = new HeroA();
            
        }

        public void Start() {
            Console.WriteLine("開始遊戲嗎? (Y/N)");

            if (Console.ReadLine() == "Y")
            {
                pHeroCreate.StartNaming(heroA);
                //pHeroCreate.GetDefaultSkill(heroA);
                pHeroCreate.HeroChangeJob(heroA,heroJob);

                adventureMeun = new AdventureMeun(heroA);
                while (!adventureMeun.IsFinish())
                {
                    adventureMeun.ShowMenu();
                }
            }
            else
            {
                Exit();
            }

        }



        public void Exit()
        {
            Console.WriteLine("關閉遊戲");
        }
    }
}
