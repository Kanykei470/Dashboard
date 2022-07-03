using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class TasksController : Controller
    {
        private readonly DashboardContext _context;

        public TasksController(DashboardContext context)
        {
            _context = context;
        }

        // GET: Tasks
        public async Task<IActionResult> Index(int Id)
        {
            var pr= await _context.Tasks.FromSqlRaw($"ViewTasks @Id={Id}").ToListAsync();
            
            return View(pr);
        }

        // GET: Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks
                .Include(t => t.DirectionNavigation)
                .Include(t => t.EmployeeNavigation)
                .Include(t => t.MilestoneNavigation)
                .Include(t => t.ProjectNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            ViewData["Direction"] = new SelectList(_context.Directions, "Id", "Id");
            ViewData["Employee"] = new SelectList(_context.Employees, "Id", "Id");
            ViewData["Milestone"] = new SelectList(_context.Milestones, "Id", "Id");
            ViewData["Project"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Milestone,Direction,Project,Employee,Completion,Priority,DateOfBegining,DateOfFinish")] Models.Task task)
        {
            if (ModelState.IsValid)
            {
                _context.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Direction"] = new SelectList(_context.Directions, "Id", "Id", task.Direction);
            ViewData["Employee"] = new SelectList(_context.Employees, "Id", "Id", task.Employee);
            ViewData["Milestone"] = new SelectList(_context.Milestones, "Id", "Id", task.Milestone);
            ViewData["Project"] = new SelectList(_context.Projects, "Id", "Id", task.Project);
            return View(task);
        }

        // GET: Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            ViewData["Direction"] = new SelectList(_context.Directions, "Id", "Id", task.Direction);
            ViewData["Employee"] = new SelectList(_context.Employees, "Id", "Id", task.Employee);
            ViewData["Milestone"] = new SelectList(_context.Milestones, "Id", "Id", task.Milestone);
            ViewData["Project"] = new SelectList(_context.Projects, "Id", "Id", task.Project);
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Milestone,Direction,Project,Employee,Completion,Priority,DateOfBegining,DateOfFinish")] Models.Task task)
        {
            if (id != task.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(task);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskExists(task.Id))
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
            ViewData["Direction"] = new SelectList(_context.Directions, "Id", "Id", task.Direction);
            ViewData["Employee"] = new SelectList(_context.Employees, "Id", "Id", task.Employee);
            ViewData["Milestone"] = new SelectList(_context.Milestones, "Id", "Id", task.Milestone);
            ViewData["Project"] = new SelectList(_context.Projects, "Id", "Id", task.Project);
            return View(task);
        }

        // GET: Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var task = await _context.Tasks
                .Include(t => t.DirectionNavigation)
                .Include(t => t.EmployeeNavigation)
                .Include(t => t.MilestoneNavigation)
                .Include(t => t.ProjectNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskExists(int id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
    }
}
