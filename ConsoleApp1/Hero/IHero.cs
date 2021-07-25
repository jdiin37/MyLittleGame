using ConsoleApp1.BaseInterface;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    public interface IHero:IBaseHero
    {

        public bool SetName(string name);

        public void ShowStatus();

        public bool CheckMp(int costMp);

        public string AddSkill(ISkill skill);
        public string[] ShowSkillList();

        public void UseSkill(string skillName, IBaseHero targetGuy);

        public void UseNormalAttack(IBaseHero targetGuy);


        public void AddExp(int exp);

        public void ChangeJob(IHeroJob job);

        public int GetExp();

        public void AcceptTask(ITask task);

        public List<ITask> GetAllAcceptTask();
    }
}
