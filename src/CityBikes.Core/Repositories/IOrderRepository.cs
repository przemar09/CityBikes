using CityBikes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Core.Repositories
{
    public interface IOrderRepository : IRepository
    {
        Task<Order> GetAsync(Guid id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task RemoveAsync(Guid id);
    }
}

