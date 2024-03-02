using MediatR;

namespace HouseHunting.Command.BIZ.Requests
{
    public record DeleteHouseRequest(int id) : IRequest<Unit>;
}
