using HouseHunting.Command.BIZ.Services;
using HouseHunting.Command.DAL;
using HouseHunting.Command.Model;

namespace HouseHunting.Command.Command.BIZ.Services
{
    public class HouseHuntingServices : IHouseHuntingServices
    {
        private readonly IRepository _repository;

        public HouseHuntingServices(IRepository repository)
        {
            _repository = repository;
        }

        public Task AddProperty(House itemToAdd)
        {
            _repository.AddProperty(itemToAdd);
            return Task.CompletedTask;
        }

        public Task UpdateProperty(House itemToUpdate)
        {
            _repository.UpdateProperty(itemToUpdate);
            return Task.CompletedTask;
        }
        public Task DeleteProperty(int id)
        {
            _repository.DeleteProperty(id);
            return Task.CompletedTask;
        }
    }
}
