using ConsoleApp1.Monster.Model;
using ConsoleApp1.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster.Lib
{
    public class MonsterLib : IMonsterLib
    {

        private List<IMonster> InitMonstersList()
        {
            List<IMonster> MonstersList = new List<IMonster>() {
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
            return MonstersList;
        }

        public List<IMonster> GetMonsterList()
        {
            List<IMonster> monstersList = InitMonstersList();

            return monstersList;
        }
    }
}
