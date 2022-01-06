using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcTask.Data;
using MvcTask.Models;

namespace MvcTask.Controllers
{
    public class MyTasksController : Controller
    {
        private readonly MvcTaskContext _context;

        public MyTasksController(MvcTaskContext context)
        {
            _context = context;
        }
        
        // GET: MyTasks
        public async Task<IActionResult> Index()
        {
            TempData["time"] = DateTime.Now;
            return View(await _context.MyTask.ToListAsync());
        }

        // GET: MyTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            TempData["time"] = DateTime.Now;
            if (id == null)
            {
                return NotFound();
            }

            var myTask = await _context.MyTask
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myTask == null)
            {
                return NotFound();
            }

            return View(myTask);
        }

        // GET: MyTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,Owner")] MyTask myTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myTask);
        }
        
        // GET: MyTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myTask = await _context.MyTask.FindAsync(id);
            if (myTask == null)
            {
                return NotFound();
            }
            return View(myTask);
        }

        // POST: MyTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,Owner")] MyTask myTask)
        {
            if (id != myTask.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyTaskExists(myTask.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(myTask);
        }
        public IActionResult Search(string owner)
        {
            IEnumerable<MyTask> list = _context.MyTask.Where(x => x.Owner == owner);
            return View(list);
        }

        // GET: MyTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myTask = await _context.MyTask
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myTask == null)
            {
                return NotFound();
            }

            return View(myTask);
        }

        // POST: MyTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myTask = await _context.MyTask.FindAsync(id);
            _context.MyTask.Remove(myTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyTaskExists(int id)
        {
            return _context.MyTask.Any(e => e.ID == id);
        }
    }
}
