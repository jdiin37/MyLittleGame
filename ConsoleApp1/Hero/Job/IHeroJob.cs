using System.Collections.Generic;

namespace ConsoleApp1.Hero
{
    public interface IHeroJob
    {
        public int GetStr();
        public int GetInt();
        public int GetDefense();

        public string GetName();

        public List<ISkill> GetSkills();

        public int GetLvUpAddInt();

        public int GetLvUpAddStr();

        public int GetLvUpAddDefense();

        public int GetLvUpAddHp();

        public int GetLvUpAddMp();
    }
}
