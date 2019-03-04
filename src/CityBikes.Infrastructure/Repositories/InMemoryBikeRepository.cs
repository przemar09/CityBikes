using CityBikes.Core;
using CityBikes.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Repositories
{
    public class InMemoryBikeRepository : IBikeRepository
    {
        private ISet<Bike> _bikes = new HashSet<Bike>();

        public async Task AddAsync(Bike bike)
        {
            _bikes.Add(bike);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Bike>> GetAllAsync()

            => await Task.FromResult(_bikes);

        public async Task<Bike> GetAsync(Guid id)

            => await Task.FromResult(_bikes.FirstOrDefault(x => x.Id == id));

        public async Task RemoveAsync(Guid id)
        {
            var bike = await GetAsync(id);
            _bikes.Remove(bike);
            await Task.CompletedTask;

        }

        public async Task UpdateAsync(Bike bike)
        {
            await Task.CompletedTask;
        }
    }
}
