using System;
using CityBikes.Core.Domain;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Core.Repositories
{
    public interface IBikeRepository : IRepository
    {
        Task<Bike> GetAsync(Guid id);
        Task<IEnumerable<Bike>> GetAllAsync();
        Task AddAsync(Bike bike);
        Task UpdateAsync(Bike bike);
        Task RemoveAsync(Guid id);
    }
}
