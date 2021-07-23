﻿using ConsoleApp1.Hero;
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
        PHeroBehavior pHeroBehavior;
        AdventureMeun adventureMeun;
        IHero heroA;

        public bool IsExitGame = false;

        public MainMeun()
        {
            pHeroBehavior = new PHeroBehavior();
            heroA = new HeroA();
            
        }

        private void StartNewGame() {
            Console.WriteLine("開始新遊戲嗎? (Y/N)");

            if (Console.ReadLine() == "Y")
            {
                pHeroBehavior.StartNaming(heroA);
                pHeroBehavior.GetDefaultJob(heroA);

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
