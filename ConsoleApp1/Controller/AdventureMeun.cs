using ConsoleApp1.BaseInterface;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using ConsoleApp1.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class AdventureMeun
    {

        IHero hero;
        PAdventure pAdventure;
        PTalkSomething pTalkSomething;

        private bool isFinish = false;

        public bool IsFinish()
        {
            return isFinish;
        }

        public AdventureMeun(IHero hero)
        {
            this.hero = hero;
            pAdventure = new PAdventure();
            pTalkSomething = new PTalkSomething();
        }


        public void ShowMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" [{0}] 您想做什麼呢 ?", hero.GetName());
            Console.WriteLine(" [所在地] {0} ?", hero.GetMap().GetMapName());
            Console.WriteLine("@=====冒險選單=====@");
            Console.WriteLine(" [1] 查看狀態");
            Console.WriteLine(" [2] 打怪");
            Console.WriteLine(" [3] 休息");
            Console.WriteLine(" [4] 閒聊");
            Console.WriteLine(" [7] 物品清單");
            Console.WriteLine(" [8] 裝備清單");
            Console.WriteLine(" [9] 任務清單");
            Console.WriteLine(" [Exit] 離開遊戲");
            Console.WriteLine("@==================@");

            InputCmd();

        }

        public void InputCmd()
        {
            string cmd = Console.ReadLine();
            if (cmd == "1")
            {
                ShowHeroStatus();
            }
            else if (cmd == "2")
            {
                EncounterMonster();
            }
            else if (cmd == "3")
            {
                TakeBreak();
            }
            else if (cmd == "4")
            {
                TalkSomthing();
            }
            else if (cmd == "7")
            {
                ShowUseableItem();
            }
            else if (cmd == "8")
            {
                ShowWearableItem();
            }
            else if (cmd == "9")
            {
                ShowTaskList();
            }
            else if (cmd == "Exit")
            {
                ExitGame();
            }

        }

        private void ShowUseableItem()
        {
            hero.ShowUseableItemList();
        }

        private void ShowWearableItem()
        {
            hero.ShowWearableItemList();
        }

        private void ShowTaskList()
        {
            Console.WriteLine("--任務名稱 / 狀態--");
            foreach (var task in hero.GetAllAcceptTask())
            {
                Console.WriteLine("--{0} / {1}--", task.GetName(), task.IsCompleted()? "已完成" : "進行中");
            }
        }

        private void TalkSomthing()
        {
            pTalkSomething.GetATalk();
        }

        private void TakeBreak()
        {
            hero.AddHp(9999);
            hero.AddMp(9999);
            Console.WriteLine(" 適當的休息過後, 您覺得精神書醒 ");
        }
        //private void EatSomthing()
        //{
        //    int addHp = 50;
        //    Console.WriteLine(" 吃了 {0} ,補充 {1} 點 HP", "肉燥飯", addHp);
        //    hero.AddHp(addHp);
        //}
        //private void DrinkSomthing()
        //{
        //    int addMp = 20;
        //    Console.WriteLine(" 喝了 {0} ,補充 {1} 點 MP", "寶礦力水得", addMp);
        //    hero.AddMp(addMp);
        //}

        private void ShowHeroStatus()
        {
            hero.ShowStatus();
        }

        private void EncounterMonster()
        {
            pAdventure.EncounterMonster(hero);
        }

        private void ExitGame()
        {
            Console.WriteLine("確定要離開遊戲嗎? (Y/N)");

            if(Console.ReadLine() == "Y")
            {
                isFinish = true;
                Console.WriteLine("掰掰! 感謝您遊玩");
            }
        }
    }
}
