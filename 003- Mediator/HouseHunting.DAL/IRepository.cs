using HouseHunting.Model;

namespace HouseHunting.DAL
{
    public interface IRepository
    {
        List<House> GetHouses(float budget);
        List<House> GetHouses();
    }
}