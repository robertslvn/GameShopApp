using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;
using ShopApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopApp.Controllers
{
    public class GameController : Controller
    {

        private readonly IGameRepository _gameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GameController(IGameRepository gameRepository, ICategoryRepository categoryRepository)
        {
            _gameRepository = gameRepository;
            _categoryRepository = categoryRepository;

        }

        public ViewResult List(string category)
        {

            IEnumerable<Game> games;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                games = _gameRepository.Games.OrderBy(p => p.GameId);
                currentCategory = "All games";
            }
            else
            {
                games = _gameRepository.Games.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.GameId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new GamesListViewModel
            {
                Games = games,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetGameById(id);
            if (game == null)
                return NotFound();

            return View(game);
        }

    }
}
