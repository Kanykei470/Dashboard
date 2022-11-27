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
            var t = await _context.Tasks.FromSqlRaw($"ViewTasks @Id={Id}").ToListAsync();
            var d = await _context.Directions.FromSqlRaw("dbo.select_Direction").ToListAsync();
            var m = await _context.Milestones.FromSqlRaw("dbo.select_Milestones").ToListAsync();
            var p = await _context.Projects.FromSqlRaw("dbo.select_Projects").ToListAsync();
            var e = await _context.Employees.FromSqlRaw("dbo.select_Employees").ToListAsync();
            foreach (var tsk in t)
            {  
                foreach (var emp in e)
                {
                    if (tsk.Employee == emp.Id)
                    {
                        tsk.EmployeeNavigation.Name = emp.Name;
                    }
                }
                foreach (var dir in d)
                {
                    if (tsk.Direction == dir.Id)
                    {
                        tsk.DirectionNavigation.Name = dir.Name;
                    }
                }
                foreach (var milst in m)
                {
                    if (tsk.Milestone == milst.Id)
                    {
                        tsk.MilestoneNavigation.Name = milst.Name;
                    }
                }
                foreach (var dir in p)
                {
                    if (tsk.Project == dir.Id)
                    {
                        tsk.ProjectNavigation.Name = dir.Name;
                    }
                }
            }
            return View(t);
        }
    }
}
