using FootBallList.Interfaces;
using FootBallList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Pepository
{
    public class CountriesData : ICountries
    {
        private readonly DBContent dBContent;

        public CountriesData(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Country> All => dBContent.Countries;

        

        public Country Cteate(Country country)
        {
            dBContent.Add(country);
            dBContent.SaveChanges();
            return country;
        }

        public void Delete(int countryId)
        {
            dBContent.Remove(Get(countryId));
            dBContent.SaveChanges();
        }

        public Country Get(int countryId)
        {
            return dBContent.Countries.Find(countryId);
        }

        public Country Update(Country country)
        {
            dBContent.Entry(country).State = EntityState.Modified;
            dBContent.SaveChanges();
            return country;
        }
    }
}
