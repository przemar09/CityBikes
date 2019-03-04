using CityBikes.Core.Domain;
using CityBikes.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Repositories
{
    public class InMemoryStationRepository : IStationRepository
    {
        private ISet<Station> _stations = new HashSet<Station>();

        public async Task AddAsync(Station station)
        {
            _stations.Add(station);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Station>> GetAllAsync()

            => await Task.FromResult(_stations);

        public async Task<Station> GetAsync(Guid id)

            => await Task.FromResult(_stations.FirstOrDefault(x => x.Id == id));

        public async Task RemoveAsync(Guid id)
        {
            var station = await GetAsync(id);
            _stations.Remove(station);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Station station)
        {
            await Task.CompletedTask;
        }
    }
}
