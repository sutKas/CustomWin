using CustomWin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Controllers
{
    public class LotteriesController : Controller
    {
        private readonly LottoDbContext _context;

        public LotteriesController(LottoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tlotteries = await _context.Lotteries.ToListAsync();
            return View(tlotteries);
        }
    }
}
