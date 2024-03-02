using HouseHunting.Query.Model;

namespace HouseHunting.Query.DAL
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

        public List<House> GetHouses()
        {
            return _houses;
        }

        public List<House> GetHouses(float budget)
        {
            return _houses.Where(t => t.Price <= budget).ToList();
        }

    }
}
