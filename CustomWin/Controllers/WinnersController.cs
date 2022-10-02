using CustomWin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Controllers
{
    public class WinnersController : Controller
    {

        private readonly LottoDbContext _context;

        public WinnersController(LottoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var twinners = await _context.Winners.ToListAsync();
            return View(twinners);
        }
    }
}
