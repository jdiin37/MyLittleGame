using ConsoleApp1.Item.Lib;
using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Monster.Lib
{
    public class MonsterLib : IMonsterLib
    {

        private static List<IMonster> allMonsterList;

        IItemLib itemLib;
        public MonsterLib()
        {
            itemLib = new ItemLib();
            if (allMonsterList == null)
            {
                InitMonstersList();
                AddDropItemToMonster();
            }
        }

        private void InitMonstersList()
        {
            allMonsterList = new List<IMonster>() {
                new MonsterNormal(new MonsterProperty{
                    Name = "哥布林",Lv=1,MaxHp=100,MaxMp=50,Str=10,Int=5,Defense=0,Exp=50
                }),
                new MonsterNormal(new MonsterProperty{
                    Name = "史萊姆",Lv=2,MaxHp=100,MaxMp=50,Str=13,Int=5,Defense=0,Exp=80
                }),
                new MonsterNormal(new MonsterProperty{
                    Name = "狼人",Lv=4,MaxHp=220,MaxMp=50,Str=20,Int=5,Defense=0,Exp=200
                }),
                //-------Has Skill Monster
                new MonsterNormalWithSkill(new MonsterProperty{
                    Name = "小精靈",Lv=5,MaxHp=180,MaxMp=60,Str=19,Int=12,Defense=0,Exp=320
                },new List<ISkill>{new FireBall()}
                ),
                //--------Boss Monster
                new MonsterBoss(new MonsterProperty{
                    Name = "熊沙",Lv=10,MaxHp=500,MaxMp=60,Str=30,Int=12,Defense=10,Exp=700
                },new List<ISkill>{new Blizzard(),new StrongAttack()}
                )
            };
        }

        private void AddDropItemToMonster()
        {
            var monster = allMonsterList.Where(x => x.GetName() == "哥布林").FirstOrDefault();
            monster.AddDropItem(itemLib.GetItemByName("普通鋼盔").SetDropPercentage(100));
            monster.AddDropItem(itemLib.GetItemByName("短刀").SetDropPercentage(20));
            monster.AddDropItem(itemLib.GetItemByName("老人的錢包").SetDropPercentage(30));

            monster = allMonsterList.Where(x => x.GetName() == "史萊姆").FirstOrDefault();
            monster.AddDropItem(itemLib.GetItemByName("咖波頭盔").SetDropPercentage(10));
            monster.AddDropItem(itemLib.GetItemByName("短刀").SetDropPercentage(30));
            monster.AddDropItem(itemLib.GetItemByName("老人的錢包").SetDropPercentage(30));

            monster = allMonsterList.Where(x => x.GetName() == "狼人").FirstOrDefault();
            monster.AddDropItem(itemLib.GetItemByName("咖波盔甲").SetDropPercentage(10));

            monster = allMonsterList.Where(x => x.GetName() == "小精靈").FirstOrDefault();
            monster.AddDropItem(itemLib.GetItemByName("咖波拳套").SetDropPercentage(10));
        }

        public List<IMonster> GetMonsterList()
        {
            List<IMonster> monstersList = allMonsterList.ToList();
            return monstersList;
        }
    }
}
