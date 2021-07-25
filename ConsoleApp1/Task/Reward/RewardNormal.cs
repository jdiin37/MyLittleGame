using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task.Reward
{
    public class RewardNormal : IReward
    {
        private int RewardExp;
        public RewardNormal(int rewardExp)
        {
            RewardExp = rewardExp;
        }

        public int GetRewardExp()
        {
            return this.RewardExp;
        }

        public int GetRewardItem()
        {
            throw new NotImplementedException();
        }
    }
}
