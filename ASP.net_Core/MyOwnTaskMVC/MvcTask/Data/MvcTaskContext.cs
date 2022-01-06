using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTask.Models;

namespace MvcTask.Data
{
    public class MvcTaskContext : DbContext
    {
        public MvcTaskContext (DbContextOptions<MvcTaskContext> options)
            : base(options)
        {
        }

        public DbSet<MvcTask.Models.MyTask> MyTask { get; set; }
    }
}
