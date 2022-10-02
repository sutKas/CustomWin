using CustomWin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Data.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly LottoDbContext _context;
        public PlayersService(LottoDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Player player)
        {
           await _context.Players.AddAsync(player);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Players.FirstOrDefaultAsync(n => n.Id == id);
            _context.Players.Remove(result);
            await _context.SaveChangesAsync();

        }

        public IEnumerable<Player> GetAll()
        {
            var result = _context.Players.ToList();
            return result;
        }

        public async Task<Player> GetByIdAsync(int id)
        {
            var result = await _context.Players.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Player> UpadateAsync(int id, Player newPlayer)
        {
            -context.update(newPlayer);
            await _context.SaveChangesAsync();
            return newPlayer;
        }
    }
}
