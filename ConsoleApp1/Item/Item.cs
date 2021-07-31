using System;

namespace ConsoleApp1.Item
{
    public class Item : IItem
    {
        public string name;

        public string desc;

        public int DropPercentage;

        public Item(string name, string desc)
        {
            this.name = name;
            this.desc = desc;
        }

        public int GetDropPercentage()
        {
            return this.DropPercentage;
        }

        public string GetName()
        {
            return this.name;
        }

        public IItem SetDropPercentage(int dropPercentage)
        {
            this.DropPercentage = dropPercentage;
            return this;
        }

        public void ShowDetial()
        {
            Console.WriteLine(GetShowInfo());
        }

        private string GetShowInfo()
        {
            string showInfo = string.Empty;
            showInfo += string.Format("名稱: {0} ", name);
            showInfo += string.Format("描述: {0} ", desc);

            return showInfo;
        }
    }
}
