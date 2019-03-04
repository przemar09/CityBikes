using CityBikes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Core.Repositories
{
    public interface IStationRepository : IRepository
    {
        Task<Station> GetAsync(Guid id);
        Task<IEnumerable<Station>> GetAllAsync();
        Task AddAsync(Station station);
        Task UpdateAsync(Station station);
        Task RemoveAsync(Guid id);
    }
}
