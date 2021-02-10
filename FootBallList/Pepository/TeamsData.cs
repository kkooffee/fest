using FootBallList.Interfaces;
using FootBallList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Pepository
{
    public class TeamsData : ITeams
    {
        private readonly DBContent dBContent;

        public TeamsData(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Team> All => dBContent.Teams;

        public Team Cteate(Team team)
        {
            dBContent.Add(team);
            dBContent.SaveChanges();
            return team;
        }

        public void Delete(int teamId)
        {
            dBContent.Remove(Get(teamId));
            dBContent.SaveChanges();
        }

        public Team Get(int teamId)
        {
            return dBContent.Teams.Find(teamId);
        }

        public Team Update(Team team)
        {
            dBContent.Entry(team).State = EntityState.Modified;
            dBContent.SaveChanges();
            return team;
        }
    }
}
