using FootBallList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Interfaces
{
    public interface IPlayers
    {
        IEnumerable<Player> All { get; }
        Player Cteate(Player player);
        Player Update(Player player);
        Player Get(int playerId);
        void Delete(int playerId);
    }
}
