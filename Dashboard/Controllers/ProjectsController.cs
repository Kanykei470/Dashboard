using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;
using Microsoft.Data.SqlClient;

namespace Dashboard.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly DashboardContext _context;

        public ProjectsController(DashboardContext context)
        {
            _context = context;
        }

        // GET: Projects
        
       public async Task<IActionResult> Index(int Id)
        {
            var pr= await _context.Projects.FromSqlRaw($"ViewProjects @Id={Id}").ToListAsync();
            
            return View(pr);
        }
    }
}
