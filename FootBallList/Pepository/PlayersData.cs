using FootBallList.Interfaces;
using FootBallList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Pepository
{
    public class PlayersData : IPlayers
    {
        private readonly DBContent dBContent;

        public PlayersData(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Player> All => dBContent.Players;

        public Player Cteate(Player player)
        {
            dBContent.Add(player);
            dBContent.SaveChanges();
            return player;
        }

        public void Delete(int playerId)
        {
            dBContent.Remove(Get(playerId));
            dBContent.SaveChanges();
        }

        public Player Get(int playerId)
        {
           return dBContent.Players.Find(playerId);
        }

        public Player Update(Player player)
        {
            dBContent.Entry(player).State = EntityState.Modified;
            dBContent.SaveChanges();
            return player;
        }
    }
}
