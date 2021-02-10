using FootBallList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Interfaces
{
    public interface ITeams
    {
        IEnumerable<Team> All { get; }
        Team Cteate(Team team);
        Team Update(Team team);
        Team Get(int teamId);
        void Delete(int teamId);
    }
}
