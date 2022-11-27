using Dashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly DashboardContext _context;
       public HomeController(DashboardContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpPost]
        public IActionResult Upload(IFormFile formFile, decimal? id)
        {
             if (ModelState.IsValid)
            {
                String ext = Path.GetExtension(formFile.FileName);
                if (formFile.Length > 0)
                {
                    if (ext == ".xlsx")
                    {
                        var stream = formFile.OpenReadStream();
                        List<Task> personalchecks = new List<Task>();
                        try
                        {
                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (var package = new ExcelPackage(stream))
                            {
                                var worksheet = package.Workbook.Worksheets.First();
                                var columncount = worksheet.Dimension.Columns;
                                var rowcount = worksheet.Dimension.Rows;

                        
                                for (var row = 2; row <= rowcount; row++)
                                {
                                    try
                                    {
                                        var directions = Convert.ToInt32(worksheet.Cells[row, 1].Value);
                                        var project = Convert.ToInt32(worksheet.Cells[row, 2].Value);
                                        var milestone = Convert.ToInt32(worksheet.Cells[row, 3].Value);
                                        var task = worksheet.Cells[row, 4].Value?.ToString();
                                        var completion = Convert.ToByte(worksheet.Cells[row, 5].Value);
                                        var employee = Convert.ToInt32(worksheet.Cells[row, 6].Value);
                                        var dateofb = Convert.ToDateTime(worksheet.Cells[row, 7].Value);
                                        var dateoff = Convert.ToDateTime(worksheet.Cells[row, 8].Value);
                                        var priority = Convert.ToByte(worksheet.Cells[row, 9].Value);
                                        var t = new Task()
                                        {
                                            Direction=directions,
                                            Project=project,
                                            Milestone=milestone,
                                            Name=task,
                                            Completion=completion,
                                            Employee=employee,
                                            DateOfBegining=dateofb,
                                            DateOfFinish=dateoff,
                                            Priority=priority
                                        };

                                        DashboardContext modelContext = new DashboardContext();
                                        modelContext.Tasks.Add(t);
                                        modelContext.SaveChangesAsync();
                                        personalchecks.Add(t);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                            }    
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
               }
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        } 
        
    }
}