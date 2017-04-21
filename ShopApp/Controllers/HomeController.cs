using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public HomeController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GamesOfTheWeek = _gameRepository.GamesOfTheWeek
            };

            return View(homeViewModel);
        }

        public ViewResult IndexAfterRegister()
        {
            var homeViewModel = new HomeViewModel
            {
                GamesOfTheWeek = _gameRepository.GamesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
