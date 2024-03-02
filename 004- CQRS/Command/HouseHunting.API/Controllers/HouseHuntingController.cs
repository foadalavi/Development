using HouseHunting.Command.BIZ.Requests;
using HouseHunting.Command.BIZ.Services;
using HouseHunting.Command.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HouseHunting.Command.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseHuntingController : ControllerBase
    {
        private readonly ILogger<HouseHuntingController> _logger;
        private readonly IMediator _mediator;

        public HouseHuntingController(ILogger<HouseHuntingController> logger,IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("AddHouses")]
        public async Task<IActionResult> AddHouses(House itemToAdd)
        {
            return Ok(_mediator.Send(new AddHouseRequest(itemToAdd)));
        }

        [HttpPut("UpdateHouse")]
        public async Task<IActionResult> UpdateHouse(House itemToAdd)
        {
            return Ok(_mediator.Send(new UpdateHouseRequest(itemToAdd)));
        }

        [HttpDelete("DeleteHouse")]
        public async Task<IActionResult> DeleteHouse(int id)
        {
            return Ok(_mediator.Send(new DeleteHouseRequest(id)));
        }
    }
}
