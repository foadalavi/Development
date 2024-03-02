using HouseHunting.Query.Model;

namespace HouseHunting.Query.DAL
{
    public interface IRepository
    {
        List<House> GetHouses(float budget);
        List<House> GetHouses();
    }
}