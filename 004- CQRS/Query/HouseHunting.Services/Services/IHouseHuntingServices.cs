using HouseHunting.Query.Model;

namespace HouseHunting.Query.BIZ.Services
{
    public interface IHouseHuntingServices
    {
        Task<List<House>> GetHousesAsync();
        Task<List<House>> GetHousesAsync(float budget);
    }
}