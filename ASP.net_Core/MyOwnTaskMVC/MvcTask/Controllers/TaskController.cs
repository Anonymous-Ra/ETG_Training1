using Microsoft.AspNetCore.Mvc;
using MvcTask.Data;
using MvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTask.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        List<MyTask> list;
        
        public IActionResult List()
        {
            list = new List<MyTask> { new MyTask{ID=1,Description="trng",Owner="shreyas"},
                new MyTask{ID=2,Description="test",Owner="trainer"} };
            return View(list);
        }
        public IActionResult Edit(int id)
        {
            MyTask t = list.FirstOrDefault(x => x.ID == id);
            return View(t);
        }
    

    }
}
