using FootBallList.Interfaces;
using FootBallList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.ViewModels
{
    public class PlayerModel
    {
        public IEnumerable<Country> countries { get; set; }
        public Player player { get; set; }
        public IEnumerable<Team> teams { get; set; }

    }
}
