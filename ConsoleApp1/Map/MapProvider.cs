using ConsoleApp1.Hero;
using ConsoleApp1.Map.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map
{
    public class MapProvider : IMapProvider
    {

        IMapLib mapLib;

        public MapProvider()
        {
            mapLib = new MapLib();
        }

        public List<IMap> GetMoveableMapListByHero(IHero hero)
        {
            var allMapList = mapLib.GetAllMapList();

            var moveableMap = allMapList.Where(x => x.GetMapName() != hero.GetMap().GetMapName()).ToList();

            return moveableMap;
        }
    }
}
