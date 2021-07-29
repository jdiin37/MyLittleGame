using ConsoleApp1.BaseInterface;
using ConsoleApp1.Cmd;
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
        ICmdProvider cmdProvider;
        Dictionary<string, ICmd> baseMenuDic = new Dictionary<string, ICmd>();
        Dictionary<string, ICmd> mapMenuDic = new Dictionary<string, ICmd>();

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
            cmdProvider = new CmdProvider();

            foreach (var cmd in cmdProvider.GetBaseCmdList())
            {
                baseMenuDic.Add(cmd.GetExcuteCode(),cmd);
            }
        }


        public void ShowMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" [{0}] 您想做什麼呢 ?", hero.GetName());
            Console.WriteLine(" [所在地] {0} ", hero.GetMap().GetMapName());
            
            Console.WriteLine("@=====基本選單=====@");
            foreach(var item in baseMenuDic)
            {
                Console.WriteLine(" [{0}] {1}", item.Key, item.Value.GetName());
            }

            mapMenuDic = hero.GetMap().GetMapCmdList();
            Console.WriteLine("@=====地圖選單=====@");
            foreach (var item in mapMenuDic)
            {
                Console.WriteLine(" [{0}] {1}", item.Key, item.Value.GetName());
            }
            Console.WriteLine("@==================@");
            
            InputCmd();

        }

        public void InputCmd()
        {
            string cmd = Console.ReadLine();
            if (baseMenuDic.ContainsKey(cmd))
            {
                baseMenuDic[cmd].ExcuteCmd(hero);
            }

            if (mapMenuDic.ContainsKey(cmd))
            {
                mapMenuDic[cmd].ExcuteCmd(hero);
            }
        }


        private void TalkSomthing()
        {
            pTalkSomething.GetATalk();
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

        

        //private void EncounterMonster()
        //{
        //    pAdventure.EncounterMonster(hero);
        //}

        //private void ExitGame()
        //{
        //    Console.WriteLine("確定要離開遊戲嗎? (Y/N)");

        //    if(Console.ReadLine() == "Y")
        //    {
        //        isFinish = true;
        //        Console.WriteLine("掰掰! 感謝您遊玩");
        //    }
        //}
    }
}
