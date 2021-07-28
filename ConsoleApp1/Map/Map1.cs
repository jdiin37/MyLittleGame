using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map
{
    public class Map1 : IMap
    {

        private string name = "場景1";

        public string GetMapName()
        {
            return this.name;
        }

        public void GoInMap(IHero hero)
        {
            throw new NotImplementedException();
        }

        public void SetMonster(List<IMonster> monsters)
        {
            throw new NotImplementedException();
        }
    }
}
