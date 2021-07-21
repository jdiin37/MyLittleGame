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

        private bool isFinish = false;

        public bool IsFinish()
        {
            return isFinish;
        }

        public AdventureMeun(IHero hero)
        {
            this.hero = hero;
            pAdventure = new PAdventure();
        }


        public void ShowMenu()
        {
            Console.WriteLine("==冒險選單==");
            Console.WriteLine("[1] 查看狀態");
            Console.WriteLine("[2] 打怪");
            Console.WriteLine("[3] 吃飯");
            Console.WriteLine("[4] 喝飲料");
            Console.WriteLine("[9] 離開遊戲");

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
                EatSomthing();
            }
            else if (cmd == "4")
            {
                DrinkSomthing();
            }
            else if (cmd == "9")
            {
                ExitGame();
            }

        }

        private void EatSomthing()
        {
            int addHp = 50;
            Console.WriteLine(" 吃了 {0} ,補充 {1} 點 HP", "肉燥飯", addHp);
            hero.AddHp(addHp);
        }
        private void DrinkSomthing()
        {
            int addMp = 20;
            Console.WriteLine(" 喝了 {0} ,補充 {1} 點 MP", "寶礦力水得", addMp);
            hero.AddMp(addMp);
        }

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
