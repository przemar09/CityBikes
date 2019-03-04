using CityBikes.Core.Domain;
using CityBikes.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private ISet<Order> _orders = new HashSet<Order>();

        public async Task AddAsync(Order order)
        {
            _orders.Add(order);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()

            => await Task.FromResult(_orders);

        public async Task<Order> GetAsync(Guid id)

            => await Task.FromResult(_orders.SingleOrDefault(x => x.Id == id));

        public async Task RemoveAsync(Guid id)
        {
            var order = await GetAsync(id);
            _orders.Remove(order);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Order order)
        {
            await Task.CompletedTask;
        }
    }
}
