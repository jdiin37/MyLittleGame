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
    public class BattleMeun
    {

        IHero hero;
        IMonster targetGuy;

        bool isRunAway = false;

        public BattleMeun(IHero hero, IMonster targetGuy)
        {
            this.hero = hero;
            this.targetGuy = targetGuy;            
        }

        public bool IsBattleFinish()
        {
            return (isRunAway || hero.GetHp() <= 0 || !targetGuy.IsAlive());            
        }

        public void GetBattleReward()
        {
            if (!targetGuy.IsAlive())
            {
                GetMonsterExp();
            }
            else if(hero.GetHp() <= 0)
            {
                Console.WriteLine(" \"請再好好休息後再來吧..\"");
            }else if (isRunAway)
            {
                Console.WriteLine(" [{0}] 逃跑成功..",hero.GetName());
            }
        }

        private void GetMonsterExp()
        {
            hero.AddExp(targetGuy.GetExp());
        }

        public void ShowMenu()
        {
            hero.ShowStatus();
            Console.WriteLine("!====戰鬥選單====!");
            Console.WriteLine("[1] 使用普功");
            Console.WriteLine("[2] 使用技能");
            Console.WriteLine("[3] 逃跑");
            Console.WriteLine("!===============!");

            InputCmd();
        }

        private void InputCmd()
        {
            string cmd = Console.ReadLine();
            if (cmd == "1")
            {
                BattleWithNormalAttack();
            }
            else if (cmd == "2")
            {
                BattleWithSkill();
            }
            else if (cmd == "3")
            {
                RunAway();
            }
        }

        private void BattleWithNormalAttack()
        {

            hero.UseNormalAttack(targetGuy);
            if (targetGuy.IsAlive())
            {
                targetGuy.Attack(hero);
            }
        }

        private void BattleWithSkill()
        {
            hero.ShowSkillList();
            string skillName = Console.ReadLine();
            hero.UseSkill(skillName, targetGuy);

            if (targetGuy.IsAlive())
            {
                targetGuy.Attack(hero);
            }
        }

        private void RunAway()
        {
            isRunAway = true;
        }
    }
}
