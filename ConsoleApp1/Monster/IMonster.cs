using ConsoleApp1.BaseInterface;
using ConsoleApp1.Item;
using System.Collections.Generic;

namespace ConsoleApp1.Monster
{
    public interface IMonster:IBaseHero
    {
        public int GetExp();

        public void GetStatus();

        public bool IsAlive();

        public void Attack(IBaseHero targetGuy);

        public void AddDropItem(IItem dropItem);
        public List<IItem> GetDropItems();

        public IMonster ShallowCopy();
        

    }
}
