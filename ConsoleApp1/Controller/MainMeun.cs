using ConsoleApp1.Hero;
using ConsoleApp1.Map;
using ConsoleApp1.Process;
using ConsoleApp1.Task;
using ConsoleApp1.Task.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class MainMeun
    {
        AdventureMeun adventureMeun;
        IHero heroA;
        ITaskLib taskLib;
        ITaskProvider taskProvider;
        IHeroFactory heroFactory;
        public bool IsExitGame = false;

        public MainMeun()
        {
        }

        private void InitGame()
        {
            Console.WriteLine("資源載入中....");
            taskLib = new TaskLib();
            taskProvider = new TaskProvider(taskLib);
            heroFactory = new HeroFactory();

            Console.WriteLine("資源載入完成....");
            Console.ReadLine();

        }

        private void StartNewGame() {
            Console.WriteLine("開始新遊戲嗎? (Y/N)");



            if (Console.ReadLine() == "Y")
            {
                InitGame();

                heroA = heroFactory.CreateHero();
                heroA.AcceptTask(taskProvider.GetFirstTask());
                heroA.GoInMap(new Map1());

                adventureMeun = new AdventureMeun(heroA);
                while (!adventureMeun.IsFinish())
                {
                    adventureMeun.ShowMenu();
                }
            }

        }

        private void StartOldGame()
        {

        }

        private void StartSetting()
        {

        }

        public void ShowMenu()
        {
            Console.WriteLine("A Little Game");
            Console.WriteLine("~~~~~主選單~~~~~~");
            Console.WriteLine(" [1] 開始遊戲");
            Console.WriteLine(" [2] 再續前緣");
            Console.WriteLine(" [3] 設定");
            Console.WriteLine(" [4] 關於");
            Console.WriteLine(" [5] 離開遊戲");
            Console.WriteLine("~~~~~~~~~~~~~~~~");

            InputCmd();
        }

        private void InputCmd()
        {
            string cmd = Console.ReadLine();
            if(cmd == "1")
            {
                StartNewGame();
            }
            else if (cmd == "2")
            {
                StartOldGame();
            }
            else if (cmd == "3")
            {
                StartSetting();
            }
            else if (cmd == "4")
            {
                AboutGame();
            }
            else if (cmd == "5")
            {
                Exit();
            }
        }

        public void AboutGame()
        {
            Console.WriteLine("========================");
            Console.WriteLine(" 希望您能喜歡這個小遊戲~");
            Console.WriteLine("by 作者");
            Console.WriteLine("========================");
        }

        public void Exit()
        {
            IsExitGame = true;
            Console.WriteLine("關閉遊戲");
        }
    }
}
