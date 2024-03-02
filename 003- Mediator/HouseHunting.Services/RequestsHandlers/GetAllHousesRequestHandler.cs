using HouseHunting.BIZ.Requests;
using HouseHunting.BIZ.Services;
using HouseHunting.Model;
using MediatR;

namespace HouseHunting.BIZ.RequestsHandlers
{
    public class GetAllHousesRequestHandler : IRequestHandler<GetAllHousesRequest, List<House>>
    {
        private readonly IHouseHuntingServices _services;

        public GetAllHousesRequestHandler(IHouseHuntingServices services)
        {
            _services = services;
        }

        public async Task<List<House>> Handle(GetAllHousesRequest request, CancellationToken cancellationToken)
        {
            return await _services.GetHousesAsync();
        }
    }
}
