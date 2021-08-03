using ConsoleApp1.Battle;
using ConsoleApp1.Hero;

namespace ConsoleApp1.Cmd
{
    public class CmdKillMonster : ACmd
    {
        private IBattle battle;

        public CmdKillMonster()
        {
            this.name = "打怪";
            this.excuteCode = "K";
            battle = new Battle.Battle();
        }


        public override void ExcuteCmd(IHero hero)
        {
            battle.EncounterMonster(hero);
        }
    }
}
