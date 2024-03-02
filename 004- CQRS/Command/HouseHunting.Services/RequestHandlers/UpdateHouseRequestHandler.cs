using HouseHunting.Command.BIZ.Requests;
using HouseHunting.Command.BIZ.Services;
using HouseHunting.Command.Model;
using MediatR;

namespace HouseHunting.Command.BIZ.RequestHandlers
{
    public class UpdateHouseRequestHandler : IRequestHandler<UpdateHouseRequest, Unit>
    {
        private readonly IHouseHuntingServices _services;

        public UpdateHouseRequestHandler(IHouseHuntingServices services)
        {
            _services = services;
        }
        public async Task<Unit> Handle(UpdateHouseRequest request, CancellationToken cancellationToken)
        {
            //var item = new House
            //{
            //    Id = request.Id,
            //    Rooms = request.Rooms,
            //    City = request.City,
            //    LivingArea = request.LivingArea,
            //    PlotArea = request.PlotArea,
            //    Price = request.Price,
            //};
            //await _services.UpdateProperty(item);
            await _services.UpdateProperty(request.GetModel());
            return Unit.Value;
        }
    }
}
