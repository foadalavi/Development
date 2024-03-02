using HouseHunting.Model;
using MediatR;

namespace HouseHunting.BIZ.Requests
{
    public record GetAllHousesRequest : IRequest<List<House>>;
}
