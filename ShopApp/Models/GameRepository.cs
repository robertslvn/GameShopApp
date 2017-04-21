using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbContext;

        public GameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> Games
        {
            get
            {
                return _appDbContext.Games.Include(c => c.Category);
            }
        }

        public IEnumerable<Game> GamesOfTheWeek
        {
            get
            {
                return _appDbContext.Games.Include(c => c.Category).Where(p => p.IsGameOfTheWeek);
            }
        }

        public Game GetGameById(int GameId)
        {
            return _appDbContext.Games.FirstOrDefault(p => p.GameId == GameId);
        }
    }
}
