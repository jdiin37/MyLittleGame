using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaseInterface
{
    public interface IBaseHero
    {
        public string GetName();

        public int GetHp();
        public int GetMp();

        public int GetInt();

        public int GetStr();

        public int GetDefense();

        public int LoseHp(int loseHp);

        public int AddHp(int addHp);

        public int LoseMp(int loseMp);

        public int AddMp(int addMp);
    }
}
