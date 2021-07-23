using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Process
{
    public class PTalkSomething
    {
        static Random Rnd = new Random();

        List<string> WordList = new List<string>
        {
            "聽說努力練功可以轉職成不同的職業?",
            "遇到打不過的怪物就逃跑吧...",
            "今天總是覺得哪裡怪怪的 QQ",
        };

        public void GetATalk()
        {
            int r = Rnd.Next(WordList.Count);           
            Console.WriteLine("\"{0}\"",WordList[r]);
        }
    }
}
