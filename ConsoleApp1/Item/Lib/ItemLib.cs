using ConsoleApp1.Enum;
using ConsoleApp1.Item.WearableItem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Item.Lib
{
    public class ItemLib : IItemLib
    {

        private static List<IItem> allItemsList;

        public ItemLib()
        {
            if(allItemsList == null)
            {
                InitAllItemList();
            }
        }
        private void InitAllItemList()
        {
            allItemsList = new List<IItem>
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

                //normal Item
                new Item("老人的錢包","破破舊舊的..")
            };

        }

        public List<IItem> FindItemListByName(string[] itemNames)
        {
            return allItemsList.Where(x => itemNames.Contains(x.GetName())).ToList();
        }


        public IItem GetItemByName(string itemNames)
        {
            return allItemsList.FirstOrDefault(x => x.GetName() == itemNames);
        }

        public List<IItem> GetAllItemList()
        {
            return allItemsList;
        }
    }
}
