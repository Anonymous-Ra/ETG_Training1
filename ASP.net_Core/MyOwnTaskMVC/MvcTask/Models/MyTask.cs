using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTask.Models
{
    public class MyTask
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
    }
}
