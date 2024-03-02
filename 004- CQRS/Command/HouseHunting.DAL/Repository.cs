using HouseHunting.Command.Model;

namespace HouseHunting.Command.DAL
{
    public class Repository : IRepository
    {
        private readonly List<House> _houses;

        public Repository()
        {
            _houses = new List<House>()
            {
                new House()
                {
                    Id = 1,
                    City = "Amsterdam",
                    LivingArea = 140,
                    PlotArea = 210,
                    Price = 2500,
                    Rooms = 5
                },
                new House()
                {
                    Id = 2,
                    City = "New York",
                    LivingArea = 150,
                    PlotArea = 193,
                    Price = 3000,
                    Rooms = 4
                },
                new House()
                {
                    Id = 3,
                    City = "Berlin",
                    LivingArea = 130,
                    PlotArea = 207,
                    Price = 1500,
                    Rooms = 3
                },
                new House()
                {
                    Id = 4,
                    City = "Madrid",
                    LivingArea = 180,
                    PlotArea = 280,
                    Price = 2000,
                    Rooms = 6
                },
            };
        }

        public void AddProperty(House itemToAdd)
        {
            itemToAdd.Id = _houses.Max(t => t.Id) + 1;
            _houses.Add(itemToAdd);
        }

        public void DeleteProperty(int id)
        {
            _houses.Remove(_houses.Find(t => t.Id == id));
        }

        public void UpdateProperty(House itemToUpdate)
        {
            var item = _houses.Find(t => t.Id == itemToUpdate.Id);
            item.City = itemToUpdate.City;
            item.Price = itemToUpdate.Price;
            item.LivingArea = itemToUpdate.LivingArea;
            item.Rooms = itemToUpdate.Rooms;
            item.PlotArea = itemToUpdate.PlotArea;
        }
    }
}
