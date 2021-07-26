using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public interface IHeroFactory
    {
        public IHero CreateHero(string heroName,IHeroJob heroJob);

        public IHero CreateHero();
    }
}
