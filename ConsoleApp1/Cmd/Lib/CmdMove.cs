using ConsoleApp1.Hero;
using ConsoleApp1.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdMove : ICmd
    {
        private string name = "移動";
        private string excuteCode = "5";
        private Dictionary<string, IMap> mapDic = new Dictionary<string, IMap>();
        private IMapProvider mapProvider;

        public CmdMove()
        {
            mapProvider = new MapProvider();
        }

        public string GetExcuteCode()
        {
            return excuteCode;
        }

        public void ExcuteCmd(IHero hero)
        {
            InitMapDic(hero);
            ShowMoveableMapList();
            ChooseMoveToMap(hero);
        }

        private void InitMapDic(IHero hero)
        {
            mapDic = new Dictionary<string, IMap>();
            var moveableMap = mapProvider.GetMoveableMapListByHero(hero);

            int index = 1;
            foreach(var map in moveableMap)
            {
                mapDic.Add(index.ToString(),map);
                index++;
            }

        }

        private void ShowMoveableMapList()
        {
            if (mapDic.Any())
            {
                Console.WriteLine(" [請選擇要去的地方~]");
            }
            foreach (var item in mapDic)
            {
                
                Console.WriteLine(" [{0}] {1} ---{2}", item.Key, item.Value.GetMapName(), item.Value.GetMapType());
            }
        }
        private void ChooseMoveToMap(IHero hero)
        {
            string cmd = Console.ReadLine();
            if (mapDic.ContainsKey(cmd))
            {
                hero.GoInMap(mapDic[cmd]);
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}
