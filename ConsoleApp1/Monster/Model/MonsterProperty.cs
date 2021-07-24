using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Monster.Model
{
    public class MonsterProperty
    {
        public string Name { get; set; }
        public int Lv { get; set; }

        public int MaxHp { get; set; }

        public int MaxMp { get; set; }

        public int Str { get; set; }
        public int Int { get; set; }

        public int Defense { get; set; }
        public int Exp { get; set; }
    }
}
