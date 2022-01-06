using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyWebApp.Data;
using MyWebApp.Models;

namespace MyWebApp.Pages.TaskPages
{
    public class CreateModel : PageModel
    {
        private readonly MyWebApp.Data.MyWebAppContext _context;

        public CreateModel(MyWebApp.Data.MyWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MyTask MyTask { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyTask.Add(MyTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
