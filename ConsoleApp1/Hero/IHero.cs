using ConsoleApp1.BaseInterface;
using ConsoleApp1.Item;
using ConsoleApp1.Item.WearableItem;
using ConsoleApp1.Map;
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

        public void ProcessTask(ITask task);

        public List<ITask> GetAllAcceptTask();

        public void AddItem(IItem item);
        public bool CheckHasItem(string itemName);

        public void ShowWearableItemList();
        public void ShowUseableItemList();

        public void WaerHeadItem(IWearableItem item);
        public void WaerBodyItem(IWearableItem item);
        public void WaerWeaponItem(IWearableItem item);

        public void GoInMap(IMap map);

        public IMap GetMap();

    }
}
