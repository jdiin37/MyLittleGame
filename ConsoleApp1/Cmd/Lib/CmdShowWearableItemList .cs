using ConsoleApp1.Hero;

namespace ConsoleApp1.Cmd
{
    public class CmdShowWearableItemList : ACmd
    {
        public CmdShowWearableItemList()
        {
            this.name = "裝備";
            this.excuteCode = "3";
        }

        public override void ExcuteCmd(IHero hero)
        {
            hero.ShowWearableItemList();
        }

       
    }
}
