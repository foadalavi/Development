using HouseHunting.Command.Model;
using MediatR;

namespace HouseHunting.Command.BIZ.Requests
{
    public class UpdateHouseRequest : BaseHouseRequest, IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateHouseRequest()
        {

        }

        public UpdateHouseRequest(House item) : base(item)
        {
            Id = item.Id;
        }

        public override House GetModel()
        {
            var model= base.GetModel();
            model.Id = Id;
            return model;
        }
    }
}
