using HouseHunting.Command.BIZ.Requests;
using HouseHunting.Command.BIZ.Services;
using HouseHunting.Command.Model;
using MediatR;

namespace HouseHunting.Command.BIZ.RequestHandlers
{
    public class AddHouseRequestHandler : IRequestHandler<AddHouseRequest, Unit>
    {
        private readonly IHouseHuntingServices _services;

        public AddHouseRequestHandler(IHouseHuntingServices services)
        {
            _services = services;
        }
        public async Task<Unit> Handle(AddHouseRequest request, CancellationToken cancellationToken)
        {
            //var item = new House
            //{
            //    Rooms = request.Rooms,
            //    City = request.City,
            //    LivingArea = request.LivingArea,
            //    PlotArea = request.PlotArea,
            //    Price = request.Price,
            //};
            //await _services.AddProperty(item);
            await _services.AddProperty(request.GetModel());
            return Unit.Value;
        }
    }
}
