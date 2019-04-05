using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildMonitoring.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuildMonitoring.Controllers
{
    public class StudentsController:Controller
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
    }
}
