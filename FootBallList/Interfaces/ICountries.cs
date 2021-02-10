using FootBallList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootBallList.Interfaces
{
    public interface ICountries
    {
        IEnumerable<Country> All { get; }
        Country Cteate(Country country);
        Country Update(Country country);
        Country Get(int countryId);
        void Delete(int countryId);
    }
}
