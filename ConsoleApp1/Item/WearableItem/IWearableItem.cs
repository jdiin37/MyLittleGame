using ConsoleApp1.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Item.WearableItem
{
    public interface IWearableItem : IItem
    {
        public void WearItem(IHero hero);

        public void UnWearItem(IHero hero);

        public int GetAddStr();
        public int GetAddInt();
        public int GetAddDefense();
        public int GetAddHp();
        public int GetAddMp();

        public ItemWearPart GetWearPart();
    }
}
