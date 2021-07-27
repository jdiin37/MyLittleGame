using ConsoleApp1.Enum;

namespace ConsoleApp1.Item.WearableItem
{
    public class ItemProperty
    {
        public int addDefense { get; set; }

        public int addHp { get; set; }

        public int addMp { get; set; }

        public int addStr { get; set; }

        public int addInt { get; set; }

        public string name { get; set; }

        public string desc { get; set; }

        public ItemWearPart wearPart { get; set; }
    }
}
