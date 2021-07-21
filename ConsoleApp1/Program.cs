using ConsoleApp1.Controller;
using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using ConsoleApp1.Skill;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!^___^!!!");

            MainMeun mainMeun = new();

            mainMeun.Start();



            //IHero heroA = new HeroA();
            //heroA.AddSkill(new FireBall());
            //heroA.ShowSkillList();

            //IMonster monster1 = new Monster1();
            //Console.WriteLine("遭遇到 {0}", monster1.GetName());
            //while (monster1.IsAlive())
            //{
            //    heroA.UseSkill("火球術", monster1);
            //}

            //IMonster monster2 = new Monster2();
            //Console.WriteLine("遭遇到 {0}", monster2.GetName());
            //while (monster2.IsAlive())
            //{
            //    heroA.UseSkill("火球術", monster2);
            //}

        }
    }
}
