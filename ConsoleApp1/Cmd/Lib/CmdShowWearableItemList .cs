using ConsoleApp1.Hero;

namespace ConsoleApp1.Cmd
{
    public class CmdShowWearableItemList : ICmd
    {
        private string name = "裝備";
        private string excuteCode = "3";
        public string GetExcuteCode()
        {
            return excuteCode;
        }
        public void ExcuteCmd(IHero hero)
        {
            hero.ShowWearableItemList();
        }

        public string GetName()
        {
            return name;
        }
    }
}
