using ConsoleApp1.Monster;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map.Lib
{
    public class MapLib : IMapLib
    {

        ITaskProvider taskProvider = new TaskProvider();
        IMonsterProvider monsterProvider = new MonsterProvider();
        private static List<IMap> allMapList;

        public MapLib()
        {
            if(allMapList == null)
            {
                InitMapList();
            }
        }

        private void InitMapList()
        {
            allMapList = new List<IMap>
            {
                new MapTown1(taskProvider),
                new MapField1(taskProvider)
            };
        }


        public List<IMap> GetAllMapList()
        {
            return allMapList;
        }
    }
}
