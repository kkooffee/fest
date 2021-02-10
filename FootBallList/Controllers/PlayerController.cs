using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootBallList.Interfaces;
using FootBallList.Models;
using FootBallList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootBallList.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ICountries countries;
        private readonly IPlayers players;
        private readonly ITeams teams;
        private PlayerModel playerModel;

        public PlayerController(ICountries countries, IPlayers players, ITeams teams)
        {
            this.playerModel = new PlayerModel();
            this.countries = countries;
            this.players = players;
            this.teams = teams;
        }       
        [HttpGet]
        public IActionResult Create()
        {
            playerModel.countries = countries.All;
            playerModel.teams = teams.All;
            return View(playerModel);
        }
        [HttpGet("{id}")]
        [Route("/Player/Update")]
        public IActionResult Update(int id)
        {
            playerModel.player=players.Get(id);
            playerModel.countries = countries.All;
            playerModel.teams = teams.All;
            return View(playerModel);
        }
        [HttpPost]
        public IActionResult Create(PlayerModel pm)
        {
            var team = pm.player.Team;
            if (!teams.All.Any(c => c.Name.Equals(team, StringComparison.OrdinalIgnoreCase))) teams.Cteate(new Team { Name = team });
            players.Cteate(pm.player);
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        [Route("/Player/Update")]
        public IActionResult Update(PlayerModel pm)
        {
            
            players.Update(pm.player);
            return RedirectToAction("Index", "Home");          
        }

    }
}