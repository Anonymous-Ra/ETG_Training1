﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;
using MyWebApp.Models;

namespace MyWebApp.Pages.TaskPages
{
    public class IndexModel : PageModel
    {
        private readonly MyWebApp.Data.MyWebAppContext _context;

        public IndexModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

        public IList<MyTask> MyTask { get;set; }

        public async Task OnGetAsync()
        {
            MyTask = await _context.MyTask.ToListAsync();
        }
    }
}
