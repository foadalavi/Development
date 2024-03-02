using HouseHunting.Command.Model;
using MediatR;

namespace HouseHunting.Command.BIZ.Requests
{
    public class BaseHouseRequest
    {
        public string City { get; set; }
        public float Price { get; set; }
        public int Rooms { get; set; }
        public int LivingArea { get; set; }
        public int PlotArea { get; set; }

        public BaseHouseRequest()
        {
            
        }

        public BaseHouseRequest(House item)
        {
            Rooms = item.Rooms;
            City = item.City;
            LivingArea = item.LivingArea;
            PlotArea = item.PlotArea;
            Price = item.Price;
        }

        public virtual House GetModel()
        {
            return new House
            {
                Rooms = Rooms,
                City = City,
                LivingArea = LivingArea,
                PlotArea = PlotArea,
                Price = Price
            };
        }
    }
}
