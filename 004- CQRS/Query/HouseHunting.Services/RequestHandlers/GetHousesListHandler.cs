using HouseHunting.Query.BIZ.Requests;
using HouseHunting.Query.BIZ.Services;
using HouseHunting.Query.Model;
using MediatR;

namespace HouseHunting.Query.BIZ.RequestHandlers
{
    public class GetHousesListHandler : IRequestHandler<GetHousesList, List<House>>
    {
        private readonly IHouseHuntingServices _services;

        public GetHousesListHandler(IHouseHuntingServices services)
        {
            _services = services;
        }

        public async Task<List<House>> Handle(GetHousesList request, CancellationToken cancellationToken)
        {
            // Do the job

            // Convert the data

            // Return the result

            return await _services.GetHousesAsync();
        }
    }
}
