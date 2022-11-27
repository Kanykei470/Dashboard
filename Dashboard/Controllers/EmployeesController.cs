using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DashboardContext _context;

        public EmployeesController(DashboardContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
             var dashboardContext = _context.Tasks.Include(t => t.DirectionNavigation).Include(t => t.EmployeeNavigation).Include(t => t.MilestoneNavigation).Include(t => t.ProjectNavigation);
            return View(await dashboardContext.ToListAsync());
        }

    }
}

