using ConsoleApp1.BaseInterface;
using ConsoleApp1.Enum;
using ConsoleApp1.Item;
using ConsoleApp1.Item.UseableItem;
using ConsoleApp1.Item.WearableItem;
using ConsoleApp1.Skill;
using ConsoleApp1.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hero
{
    class HeroA : IHero
    {
        public string Name = "英雄A";
        public int Lv = 1;
        public int Exp = 0;
        public int LvUpExp = 0;

        public int MaxHp = 300;
        public int Hp = 300;

        public int MaxMp = 50;
        public int Mp = 50;

        public int Str = 1;
        public int Int = 1;
        public int Defense = 1;

        public List<ISkill> SkillList = new List<ISkill>();
        public List<ITask> TaskList = new List<ITask>();
        public List<IItem> ItemList = new List<IItem>();

        public IWearableItem HeadItem = null;
        public IWearableItem BodyItem = null;
        public IWearableItem WeaponItem = null;

        public IHeroJob Job;
        public IHeroExpCalculater HeroExpCalculater;

        public HeroA()
        {
            HeroExpCalculater = new HeroExpCalculater();
            LvUpExp = HeroExpCalculater.GetHeroLvUpExp(this);
        }

        #region HP MP setter
        int IBaseHero.AddHp(int addHp)
        {
            this.Hp += addHp;
            if(this.Hp >= MaxHp) this.Hp = MaxHp;

            return this.Hp;
        }

        int IBaseHero.AddMp(int addMp)
        {
            this.Mp += addMp;
            if (this.Mp >= MaxMp)this.Mp = MaxMp;
            
            return this.Mp;
        }


        int IBaseHero.LoseHp(int loseHp)
        {
            this.Hp -= loseHp;
            if (this.Hp <= 0) this.Hp = 0;
            
            return this.Hp;
        }

        int IBaseHero.LoseMp(int loseMp)
        {
            this.Mp -= loseMp;
            if (this.Mp <= 0)this.Mp = 0;
            return this.Mp;
        }
        #endregion

        

        public string AddSkill(ISkill skill)
        {
            this.SkillList.Add(skill);
            Console.WriteLine(" [{0}] 已習得 {1} ", this.GetName(), skill.GetName());

            return "已習得" + skill.GetName();
        }

        public string[] ShowSkillList()
        {
            Console.WriteLine("[技能清單]");
            int index = 0;
            foreach (var skill in SkillList)
            {
                Console.WriteLine("{0}. {1}",++index, skill.GetName());
            }
            Console.WriteLine("請輸入正確名稱來使用技能.....");

            return this.SkillList.Select(x => x.GetName()).ToArray();
        }

        public void UseNormalAttack(IBaseHero targetGuy)
        {
            ISkill normalAttack = new NormalAttack();
            normalAttack.Attack(this, targetGuy);
        }

        void IHero.UseSkill(string skillName,IBaseHero targetGuy)
        {
            ISkill skill= this.SkillList.FirstOrDefault(x => x.GetName() == skillName);
            if (skill!=null)
            {
                if (this.CheckMp(skill.GetCostMp()))
                {
                    skill.Attack(this, targetGuy);
                }
                else
                {
                    Console.WriteLine("MP 不足");
                    return ;
                }
                
            }
            else
            {
                Console.WriteLine("您沒有 {0} ", skillName);
            }
        }

        int IBaseHero.GetInt()
        {
            return this.Int;
        }

        int IBaseHero.GetStr()
        {
            return this.Str;
        }

        int IBaseHero.GetDefense()
        {
            return this.Defense;
        }

        string IBaseHero.GetName()
        {
            return this.Name;
        }

        

        public bool CheckMp(int costMp)
        {
            return this.Mp >= costMp;
        }

        public bool SetName(string name)
        {
            this.Name = name;
            return true;
        }

        public string GetName()
        {
            return this.Name;
        }


        public int GetHp()
        {
            return this.Hp;
        }

        public int GetMp()
        {
            return this.Mp;
        }

        public void AddExp(int exp)
        {
            Console.WriteLine(" [{0}] 獲得 {1} 點經驗值",this.Name, exp);

            this.Exp += exp;

            IsLvUp();
        }


        private void IsLvUp()
        {
            while (this.Exp >= this.LvUpExp)
            {
                LvUp();
            }
        }

        private void LvUp()
        {
            this.Lv += 1;
            this.Str += Job.GetLvUpAddStr();
            this.Int += Job.GetLvUpAddInt();
            this.Defense += Job.GetLvUpAddDefense();
            this.MaxHp += Job.GetLvUpAddHp();
            this.MaxMp += Job.GetLvUpAddMp();
            Console.WriteLine(" [{0}] 等級提升為 {1}", this.Name, this.Lv);
            Console.WriteLine(" HP上限提升 {0} 點, MP上限提升 {1} 點", Job.GetLvUpAddHp(), Job.GetLvUpAddMp());
            Console.WriteLine(" 力量提升 {0} 點", Job.GetLvUpAddStr());
            Console.WriteLine(" 智力提升 {0} 點", Job.GetLvUpAddInt());
            Console.WriteLine(" 防禦提升 {0} 點", Job.GetLvUpAddDefense());

            this.LvUpExp = HeroExpCalculater.GetHeroLvUpExp(this);
        }

        public void ShowStatus()
        {
            Console.WriteLine(" ");
            Console.WriteLine("目前狀態 : ");
            Console.WriteLine("|Hp : {0}/{1} |Mp : {2}/{3} |職業 : {4}", this.Hp, this.MaxHp, this.Mp, this.MaxMp, this.Job.GetName());
            Console.WriteLine("|力量 : {0} |智力 : {1} |防禦 : {2}", this.Str, this.Int, this.Defense);
            Console.WriteLine("|Lv : {0} |Exp : {1}/{2}", this.Lv, this.Exp, this.LvUpExp);
        }

        public void ChangeJob(IHeroJob job)
        {
            this.Job = job;
            this.Str = job.GetStr();
            this.Int = job.GetInt();
            this.Defense = job.GetDefense();


            Console.WriteLine(" [{0}] 已轉職成 ={1}=",this.Name,job.GetName());

            foreach(var skill in job.GetSkills())
            {
                this.AddSkill(skill);
            }
        }

        public int GetLv()
        {
            return this.Lv;
        }

        public int GetExp()
        {
            return this.Exp;
        }

        public void AcceptTask(ITask task)
        {
            this.TaskList.Add(task);
            task.TaskStart(this);
        }


        public List<ITask> GetAllAcceptTask()
        {
            return this.TaskList;
        }

        public void AddItem(IItem item)
        {
            this.ItemList.Add(item);
        }

        public void ShowWearableItemList()
        {
            Console.WriteLine("[目前裝備]");
            Console.WriteLine("[頭部] {0}", this.HeadItem == null ? "-" : HeadItem.GetName());
            Console.WriteLine("[身體] {0}", this.BodyItem == null ? "-" : BodyItem.GetName());
            Console.WriteLine("[武器] {0}", this.WeaponItem == null ? "-" : WeaponItem.GetName());

            Console.WriteLine("[裝備清單]");
            int index = 0;
            Dictionary<string, string> itemDic = new Dictionary<string, string>();
            foreach (var item in ItemList.Where(x=> x.GetType().GetInterfaces().Contains(typeof(IWearableItem))))
            {
                Console.Write("[{0}]", ++index);
                item.ShowDetial();
                itemDic.Add(index.ToString(), item.GetName());
            }

            ChooseItem(itemDic);

        }

        private void ChooseItem(Dictionary<string, string> itemDic)
        {
            Console.WriteLine("請輸入要使用的裝備代碼");
            string itemKey = Console.ReadLine();
            if (itemDic.ContainsKey(itemKey))
            {
                Console.WriteLine("你選擇了 [{0}], 要裝備嗎 (Y/N)?", itemDic[itemKey]);
                string cmd = Console.ReadLine();
                if (cmd == "Y" || cmd == "y")
                {
                    IWearableItem wearItem = (IWearableItem)this.ItemList.FirstOrDefault(x => x.GetName() == itemDic[itemKey]);
                    if (wearItem.GetWearPart() == ItemWearPart.Head)
                    {
                        this.WaerHeadItem(wearItem);
                    }
                    else if (wearItem.GetWearPart() == ItemWearPart.Body)
                    {
                        this.WaerBodyItem(wearItem);
                    }
                    else if (wearItem.GetWearPart() == ItemWearPart.Weapon)
                    {
                        this.WaerWeaponItem(wearItem);
                    }
                }
            }
            else
            {
                Console.WriteLine("無此代碼");
            }
        }



        public void ShowUseableItemList()
        {
            Console.WriteLine("[物品清單]");
            int index = 0;
            foreach (var item in ItemList.Where(x => x.GetType().GetInterfaces().Contains(typeof(IUseableItem))))
            {
                Console.Write("[{0}]", ++index);
                item.ShowDetial();
            }
            Console.ReadLine();

        }


        public void WaerHeadItem(IWearableItem item)
        {
            this.HeadItem = item;
            Console.WriteLine("裝備了 {0}", item.GetName());
            refreshProperty();
        }

        public void WaerBodyItem(IWearableItem item)
        {
            this.BodyItem = item;
            Console.WriteLine("裝備了 {0}", item.GetName());
            refreshProperty();
        }

        public void WaerWeaponItem(IWearableItem item)
        {
            this.WeaponItem = item;
            Console.WriteLine("裝備了 {0}", item.GetName());
            refreshProperty();
        }

        private void refreshProperty()
        {
            int strAdd = (this.HeadItem == null ? 0 : this.HeadItem.GetAddStr()) +
                (this.BodyItem == null ? 0 : this.BodyItem.GetAddStr()) +
                (this.WeaponItem == null ? 0 : this.WeaponItem.GetAddStr());

            int intAdd = (this.HeadItem == null ? 0 : this.HeadItem.GetAddInt()) +
                (this.BodyItem == null ? 0 : this.BodyItem.GetAddInt()) +
                (this.WeaponItem == null ? 0 : this.WeaponItem.GetAddInt());

            int defenseAdd = (this.HeadItem == null ? 0 : this.HeadItem.GetAddDefense()) +
                (this.BodyItem == null ? 0 : this.BodyItem.GetAddDefense()) +
                (this.WeaponItem == null ? 0 : this.WeaponItem.GetAddDefense());

            int hpAdd = (this.HeadItem == null ? 0 : this.HeadItem.GetAddHp()) +
                (this.BodyItem == null ? 0 : this.BodyItem.GetAddHp()) +
                (this.WeaponItem == null ? 0 : this.WeaponItem.GetAddHp());

            int mpAdd = (this.HeadItem == null ? 0 : this.HeadItem.GetAddMp()) +
                (this.BodyItem == null ? 0 : this.BodyItem.GetAddMp()) +
                (this.WeaponItem == null ? 0 : this.WeaponItem.GetAddMp());





            this.Str += strAdd;
            this.Int += intAdd;
            this.Defense += defenseAdd;
            this.Hp += hpAdd;
            this.Mp += mpAdd;
        }

        public bool CheckHasItem(IItem item)
        {
            return this.ItemList.Any(x => x.GetName() == item.GetName());
        }
    }
}
