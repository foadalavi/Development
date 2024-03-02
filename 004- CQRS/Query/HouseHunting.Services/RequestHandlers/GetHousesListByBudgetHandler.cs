using HouseHunting.Query.BIZ.Requests;
using HouseHunting.Query.BIZ.Services;
using HouseHunting.Query.Model;
using MediatR;

namespace HouseHunting.Query.BIZ.RequestHandlers
{
    public class GetHousesListByBudgetHandler : IRequestHandler<GetHousesListByBudget, List<House>>
    {
        private readonly IHouseHuntingServices _services;

        public GetHousesListByBudgetHandler(IHouseHuntingServices services)
        {
            _services = services;
        }
        public async Task<List<House>> Handle(GetHousesListByBudget request, CancellationToken cancellationToken)
        {
            return await _services.GetHousesAsync(request.budget);
        }
    }
}
