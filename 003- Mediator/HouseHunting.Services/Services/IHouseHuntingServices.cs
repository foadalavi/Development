using HouseHunting.Model;

namespace HouseHunting.BIZ.Services
{
    public interface IHouseHuntingServices
    {
        Task<List<House>> GetHousesAsync();
        Task<List<House>> GetHousesAsync(float budget);
    }
}