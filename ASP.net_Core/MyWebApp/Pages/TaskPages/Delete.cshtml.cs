using System;
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
    public class DeleteModel : PageModel
    {
        private readonly MyWebApp.Data.MyWebAppContext _context;

        public DeleteModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyTask MyTask { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyTask = await _context.MyTask.FirstOrDefaultAsync(m => m.ID == id);

            if (MyTask == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyTask = await _context.MyTask.FindAsync(id);

            if (MyTask != null)
            {
                _context.MyTask.Remove(MyTask);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
