using CustomWin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Controllers
{
    public class SystemManagersController : Controller
    {
        private readonly LottoDbContext _context;

        public SystemManagersController(LottoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tSystemManager = await _context.SystemManagers.ToListAsync();
            return View(tSystemManager);
        }
    }
}
