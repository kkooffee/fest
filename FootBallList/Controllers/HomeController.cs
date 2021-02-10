using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootBallList.Models;
using FootBallList.Interfaces;

namespace FootBallList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayers players;

        public HomeController(IPlayers players)
        {
            this.players = players;
        }

        public IActionResult Index()
        {
            var list = players.All;
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
