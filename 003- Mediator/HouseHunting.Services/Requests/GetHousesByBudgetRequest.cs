using HouseHunting.Model;
using MediatR;

namespace HouseHunting.BIZ.Requests
{
    public record GetHousesByBudgetRequest(float budget):IRequest<List<House>>;
}
