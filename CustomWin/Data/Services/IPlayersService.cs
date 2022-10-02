using CustomWin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomWin.Data.Services
{
   public interface IPlayersService
    {
        IEnumerable<Player> GetAllAsync();
        Task<Player> GetByIdAsync(int id);
        Task AddAsync(Player player);

       Task <Player> UpadateAsync(int id, Player newPlayer);
        Task  DeleteAsync(int id);

    }
}
