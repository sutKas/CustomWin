using CustomWin.Data;
using CustomWin.Data.Services;
using CustomWin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayersService _service;

        public PlayersController(IPlayersService service)
        {
            _service = service;
        }
       
        public IActionResult Index()
        {
            var data = _service.GetAllAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Profile,FirstName,LastName,Email")]Player player)
        {
            if (ModelState.IsValid)
            {
                return View(player);
            }
            await _service.AddAsync(player);
            return RedirectToAction(nameof(Index));
        }

        //get
        public async Task<IActionResult> Details(int id)
        {
            var playerDetails = await _service.GetByIdAsync(id);
            if (playerDetails == null) return View("Empty");
            return View(playerDetails);
        }
        //update
        public async Task<IActionResult> Edit(int id)
        {
            var playerDetails = await _service.GetByIdAsync(id);
            if (playerDetails == null) return View("Result not found");
            return View(playerDetails);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Profile,FirstName,LastName,Email")] Player player)
        {
            if (ModelState.IsValid)
            {
                return View(player);
            }
            await _service.UpadateAsync(id, player);
            return RedirectToAction(nameof(Index));
        }

        //delete

        public async Task<IActionResult> Delete(int id)
        {
            var playerDetails = await _service.GetByIdAsync(id);
            if (playerDetails == null) return View("Result not found");
            return View(playerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCon(int id)
        {
            var PlayerDetails = await _service.GetByIdAsync(id);
            if (PlayerDetails == null) return View("Result not found");
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }

}
