using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Models
{
    public class DBInitial
    {
        static public void Initial(DBContent content)
        {
            if (!content.Countries.Any())
            {
                content.Countries.AddRange(Countries().Select(c => c.Value));
                content.SaveChanges();
            }
            if (!content.Players.Any())
            {
                content.Players.AddRange(Players().Select(c => c.Value));
                content.SaveChanges();
            }
            if (!content.Teams.Any())
            {
                content.Teams.AddRange(Teams().Select(c => c.Value));
                content.SaveChanges();
            }

        }
        private static Dictionary<string, Country> DiCountry;
        private static Dictionary<string, Country> Countries()
        {
            if (DiCountry == null)
            {
                var list = new Country[]
                {
                    new Country { Name = "Россия" },
                    new Country { Name = "США"},
                    new Country { Name = "Италия"},
                };
                DiCountry = new Dictionary<string, Country>();
                foreach (Country el in list)
                {
                    DiCountry.Add(el.Name, el);
                }
            }
            return DiCountry;
        }

        private static Dictionary<string, Player> DiPlayer;
        public static Dictionary<string, Player> Players()
        {
            if (DiPlayer == null)
            {
                var list = new Player[]
                {
                    new Player { Name = "Имя1", Surname = "Фамилия", Sex = "М", Country = "Россия", Date = DateTime.Parse("1990-08-23"), Team = "Спартак" },
                    new Player { Name = "Имя2", Surname = "Фамилия", Sex = "М", Country = "Россия", Date = DateTime.Parse("1990-08-23"), Team = "Спартак" },
                    new Player { Name = "Имя3", Surname = "Фамилия", Sex = "М", Country = "Россия", Date = DateTime.Parse("1990-08-23"), Team = "Спартак" },

                };
                DiPlayer = new Dictionary<string, Player>();
                foreach (Player el in list)
                    DiPlayer.Add(el.Name, el);
            }
            return DiPlayer;
        }
        private static Dictionary<string, Team> DiTeam;
        private static Dictionary<string, Team> Teams()
        {
            if (DiCountry == null)
            {
                var list = new Team[]
                {
                    new Team { Name = "Спартак" },
                    new Team { Name = "Динамо"},
                    new Team { Name = "Локомотив"},
                };
                DiTeam = new Dictionary<string, Team>();
                foreach (Team el in list)
                {
                    DiTeam.Add(el.Name, el);
                }
            }
            return DiTeam;
        }
    }
}
