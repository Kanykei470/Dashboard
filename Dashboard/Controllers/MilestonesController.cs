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
    public class MilestonesController : Controller
    {
        private readonly DashboardContext _context;

        public MilestonesController(DashboardContext context)
        {
            _context = context;
        }

        // GET: Milestones
        public async Task<IActionResult> Index(int Id)
        {
            var pr = await _context.Milestones.FromSqlRaw($"ViewMilestones @Id={Id}").ToListAsync();
            return View(pr);
        }
    }
}
