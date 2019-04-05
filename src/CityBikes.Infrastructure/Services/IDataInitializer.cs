using System.Threading.Tasks;

namespace CityBikes.Infrastructure.Services
{
    public interface IDataInitializer : IService
    {
        Task SeedAsync();
    }
}