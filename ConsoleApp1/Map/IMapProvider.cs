using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Map
{
    public interface IMapProvider
    {
        public List<IMap> GetMoveableMapListByHero(IHero hero); 

    }
}
