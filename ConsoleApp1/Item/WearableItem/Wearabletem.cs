using ConsoleApp1.Hero;
using System;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Item.WearableItem
{
    public class Wearabletem : IWearableItem
    {
        public int addDefense;

        public int addHp;

        public int addMp;

        public int addStr;

        public int addInt;

        public string name;

        public string desc;

        public int DropPercentage;

        public ItemWearPart WearPart;


        public Wearabletem(ItemProperty itemProperty)
        {
            this.addDefense = itemProperty.addDefense;
            this.addHp = itemProperty.addHp;
            this.addMp = itemProperty.addMp;
            this.addStr = itemProperty.addStr;
            this.addInt = itemProperty.addInt;
            this.name = itemProperty.name;
            this.desc = itemProperty.desc;
            this.WearPart = itemProperty.wearPart;
        }

        public string GetName()
        {
            return this.name;
        }

        public void ShowDetial()
        {
            Console.WriteLine(GetShowInfo());
        }

        private string GetShowInfo()
        {
            string showInfo = string.Empty;
            showInfo += string.Format("名稱: {0} ", name);

            if (addStr != 0)
            {
                string changeInfo = addStr > 0 ? "+" + addStr : "" + addStr;
                showInfo += string.Format("力量 {0} ", changeInfo);
            }
            if (addInt != 0)
            {
                string changeInfo = addInt > 0 ? "+" + addInt : "" + addInt;
                showInfo += string.Format("智力 {0} ", changeInfo);
            }
            if (addDefense != 0)
            {
                string changeInfo = addDefense > 0 ? "+" + addDefense : "" + addDefense;
                showInfo += string.Format("防禦 {0} ", changeInfo);
            }
            if (addHp != 0)
            {
                string changeInfo = addHp > 0 ? "+" + addHp : "" + addHp;
                showInfo += string.Format("HP {0} ", changeInfo);
            }
            if (addMp != 0)
            {
                string changeInfo = addMp > 0 ? "+" + addMp : "" + addMp;
                showInfo += string.Format("MP {0} ", changeInfo);
            }
            
            showInfo += string.Format("描述: {0} ", desc);
            

            return showInfo;
        }


        public void UnWearItem(IHero hero)
        {
            throw new NotImplementedException();
        }

        public void WearItem(IHero hero)
        {
            throw new NotImplementedException();
        }

        public int GetDropPercentage()
        {
            return this.DropPercentage;
        }

        public IItem SetDropPercentage(int dropPercentage)
        {
            this.DropPercentage = dropPercentage;
            return this;
        }

        public int GetAddStr()
        {
            return this.addStr;
        }

        public int GetAddInt()
        {
            return this.addInt;
        }

        public int GetAddDefense()
        {
            return this.addDefense;
        }

        public int GetAddHp()
        {
            return this.addHp;
        }

        public int GetAddMp()
        {
            return this.addMp;
        }

        public ItemWearPart GetWearPart()
        {
            return this.WearPart;
        }

    }
}
