using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Item
{
    public interface IItem
    {
        public string GetName();

        public void ShowDetial();

        public IItem SetDropPercentage(int dropPercentage);
        public int GetDropPercentage();
    }
}
