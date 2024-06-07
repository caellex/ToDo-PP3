using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_PP3
{
    public class ToDo
    {
        public string Task { get; private set; }
        public string Description { get; private set; }
        

        public ToDo()
        {

        }

        public ToDo(string task, string description)
        {
            Task = task;
            Description = description;
        }

        
    }
}
