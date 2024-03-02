using HouseHunting.DAL;
using HouseHunting.Model;

namespace HouseHunting.BIZ.Services
{
    public class HouseHuntingServices : IHouseHuntingServices
    {
        private readonly IRepository _repository;

        public HouseHuntingServices(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<House>> GetHousesAsync()
        {
            var result = _repository.GetHouses();
            return await Task.FromResult(result);
        }

        public async Task<List<House>> GetHousesAsync(float budget)
        {
            var result = _repository.GetHouses(budget);
            return await Task.FromResult(result);
        }
    }
}
