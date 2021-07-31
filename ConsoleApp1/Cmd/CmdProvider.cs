using System.Collections.Generic;

namespace ConsoleApp1.Cmd
{
    public class CmdProvider : ICmdProvider
    {
        public List<ICmd> GetBaseCmdList()
        {
            List<ICmd> baseCmd = new List<ICmd>
            {
                new CmdShowHeroStatus(),
                new CmdShowItemList(),
                new CmdShowWearableItemList(),
                new CmdShowTaskList(),
                new CmdMove(),
                new CmdReturnMainMenu(),
            };

            return baseCmd;
        }
    }
}
