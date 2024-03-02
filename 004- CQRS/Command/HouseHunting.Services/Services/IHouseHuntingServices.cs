using HouseHunting.Command.Model;

namespace HouseHunting.Command.BIZ.Services
{
    public interface IHouseHuntingServices
    {
        Task AddProperty(House itemToAdd);
        Task UpdateProperty(House itemToUpdate);
        Task DeleteProperty(int id);
    }
}