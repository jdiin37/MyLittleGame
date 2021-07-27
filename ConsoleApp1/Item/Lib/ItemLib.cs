using ConsoleApp1.Enum;
using ConsoleApp1.Item.WearableItem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Item.Lib
{
    public class ItemLib : IItemLib
    {
        public List<IItem> FindItemListByName(string[] itemNames)
        {
            return GetAllItemList().Where(x => itemNames.Contains(x.GetName())).ToList();
        }

        public List<IItem> GetAllItemList()
        {
            List<IItem> allItemsList = new List<IItem>
            {
                //Head
                new Wearabletem(new ItemProperty{ 
                name="咖波頭盔",addStr=5,addInt=0,addDefense=10,addHp=20,desc="傳說生物配戴的頭盔..",wearPart = ItemWearPart.Head}),
                new Wearabletem(new ItemProperty{
                name="普通鋼盔",addStr=0,addInt=0,addDefense=5,addHp=10,desc="也可以拿來當鍋子?..",wearPart = ItemWearPart.Head}),
                //Body
                new Wearabletem(new ItemProperty{
                name="咖波盔甲",addStr=8,addInt=4,addDefense=14,addHp=0,desc="傳說生物配戴的盔甲..",wearPart = ItemWearPart.Body}),
                //Weapon
                new Wearabletem(new ItemProperty{
                name="短刀",addStr=3,addInt=0,addDefense=5,addHp=0,desc="短刀一把",wearPart = ItemWearPart.Weapon}),
                new Wearabletem(new ItemProperty{
                name="咖波拳套",addStr=8,addInt=4,addDefense=14,addHp=0,desc="傳說生物配戴的拳套..",wearPart = ItemWearPart.Weapon}),
            };



            return allItemsList;
        }

        public IItem GetItemByName(string itemNames)
        {
            return GetAllItemList().FirstOrDefault(x => x.GetName() == itemNames);
        }
    }
}
