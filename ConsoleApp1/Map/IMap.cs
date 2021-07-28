using ConsoleApp1.Hero;
using ConsoleApp1.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map
{
    public interface IMap
    {
        public void SetMonster(List<IMonster> monsters);

        public void GoInMap(IHero hero);

        public string GetMapName();

    }
}
