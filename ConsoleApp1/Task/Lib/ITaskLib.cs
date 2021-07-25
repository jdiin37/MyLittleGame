using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task.Lib
{
    public interface ITaskLib
    {
        public List<ITask> GetAllTaskList();
    }
}
