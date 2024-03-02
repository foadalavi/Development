using HouseHunting.Query.Model;
using MediatR;

namespace HouseHunting.Query.BIZ.Requests
{
    public record GetHousesListByBudget(float budget) : IRequest<List<House>>;
}
