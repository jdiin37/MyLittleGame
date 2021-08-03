using ConsoleApp1.Hero;
using ConsoleApp1.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cmd
{
    public class CmdMove : ACmd
    {
        private Dictionary<string, IMap> mapDic = new Dictionary<string, IMap>();
        private IMapProvider mapProvider;

        public CmdMove()
        {
            this.name = "移動";
            this.excuteCode = "5";
            this.mapProvider = new MapProvider();
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

        public override void ExcuteCmd(IHero hero)
        {
            InitMapDic(hero);
            ShowMoveableMapList();
            ChooseMoveToMap(hero);
        }
    }
}
