using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public class HeroFactory : IHeroFactory
    {
        
        public IHero CreateHero(string heroName, IHeroJob heroJob)
        {
            IHero newHero = new HeroA();
            newHero.SetName(heroName);
            newHero.ChangeJob(heroJob);
            return newHero;
        }

        public IHero CreateHero()
        {
            return new HeroA();
        }
    }
}
