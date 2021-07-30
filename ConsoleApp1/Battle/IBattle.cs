using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Battle
{
    public interface IBattle
    {
        public void EncounterMonster(IHero hero);
    }
}
