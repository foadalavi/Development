using HouseHunting.Command.BIZ.Requests;
using HouseHunting.Command.BIZ.Services;
using MediatR;

namespace HouseHunting.Command.BIZ.RequestHandlers
{
    public class DeleteHouseRequestHandler : IRequestHandler<DeleteHouseRequest, Unit>
    {
        private readonly IHouseHuntingServices _services;

        public DeleteHouseRequestHandler(IHouseHuntingServices services)
        {
            _services = services;
        }

        public async Task<Unit> Handle(DeleteHouseRequest request, CancellationToken cancellationToken)
        {
            await _services.DeleteProperty(request.id);
            return Unit.Value;
        }
    }
}
