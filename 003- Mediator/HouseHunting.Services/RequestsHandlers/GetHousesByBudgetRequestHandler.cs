using HouseHunting.BIZ.Requests;
using HouseHunting.BIZ.Services;
using HouseHunting.Model;
using MediatR;

namespace HouseHunting.BIZ.RequestsHandlers
{
    public class GetHousesByBudgetRequestHandler : IRequestHandler<GetHousesByBudgetRequest, List<House>>
    {
        private readonly IHouseHuntingServices _services;

        public GetHousesByBudgetRequestHandler(IHouseHuntingServices services)
        {
            _services = services;
        }
        public async Task<List<House>> Handle(GetHousesByBudgetRequest request, CancellationToken cancellationToken)
        {
            return await _services.GetHousesAsync(request.budget);
        }
    }
}
