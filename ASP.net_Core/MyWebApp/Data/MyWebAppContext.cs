using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class MyWebAppContext : DbContext
    {
        public MyWebAppContext (DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp.Models.MyTask> MyTask { get; set; }
    }
}
