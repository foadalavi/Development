using HouseHunting.Command.Model;

namespace HouseHunting.Command.DAL
{
    public interface IRepository
    {
        void AddProperty(House itemToAdd);
        void UpdateProperty(House itemToUpdate);
        void DeleteProperty(int id);
    }
}