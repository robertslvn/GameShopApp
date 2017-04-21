using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public interface IGameRepository
    {

        IEnumerable<Game> Games { get; }
        IEnumerable<Game> GamesOfTheWeek { get; }
        Game GetGameById(int gameId);
    }
}
