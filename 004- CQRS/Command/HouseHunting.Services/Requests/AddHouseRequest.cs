using HouseHunting.Command.Model;
using MediatR;

namespace HouseHunting.Command.BIZ.Requests
{
    public class AddHouseRequest : BaseHouseRequest, IRequest<Unit>
    {
        public AddHouseRequest()
        {

        }

        public AddHouseRequest(House item) : base(item)
        {
        }
    }
}
