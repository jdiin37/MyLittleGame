using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public class HeroExpCalculater : IHeroExpCalculater
    {
        Dictionary<int,int> LvExpDic = new Dictionary<int, int>
        {
            { 1,100 },
            { 2,200 },
            { 3,400 },
            { 4,700 },
            { 5,1000 },
            { 6,1500 },
            { 7,2300 },
            { 8,3000 },
            { 9,3900 },
            { 10,5000 },
        };



        public int GetHeroLvUpExp(IHero hero)
        {
            return LvExpDic.ContainsKey(hero.GetLv()) ? LvExpDic[hero.GetLv()] : 99999999;
        }

    }
}
