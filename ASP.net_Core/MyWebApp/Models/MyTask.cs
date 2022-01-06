using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class MyTask
    {
        public int ID { get; set; }
        public String Description { get; set; }
        
        public DateTime TargetDate { get; set; }
    }
}
