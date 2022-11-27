﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class DirectionsController : Controller
    {
        private readonly DashboardContext _context;

        public DirectionsController(DashboardContext context)
        {
            _context = context;
        }

        // GET: Directions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Directions.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Directions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Completion,Priority")] Direction direction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(direction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(direction);
        }
    }
}
