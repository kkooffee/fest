using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Models
{
    public class DBContent:DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Team> Teams { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Player> Players { set; get; }
    }
}
