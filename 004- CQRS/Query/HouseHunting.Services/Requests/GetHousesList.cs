using HouseHunting.Query.Model;
using MediatR;

namespace HouseHunting.Query.BIZ.Requests
{
    public record GetHousesList() : IRequest<List<House>>;
}
