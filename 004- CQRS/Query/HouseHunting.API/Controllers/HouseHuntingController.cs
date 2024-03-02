using HouseHunting.Query.BIZ.Requests;
using HouseHunting.Query.BIZ.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HouseHunting.Query.API.Controllers
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

        [HttpGet("GetHouses")]
        public async Task<IActionResult> GetHouses()
        {
            //return Ok(await _services.GetHousesAsync());
            return Ok(_mediator.Send(new GetHousesList()).Result);
        }

        [HttpGet("GetHousesByBudget")]
        public async Task<IActionResult> GetHousesByBudget(float budget)
        {
            //return Ok(await _services.GetHousesAsync(budget));
            return Ok(_mediator.Send(new GetHousesListByBudget(budget)).Result);
        }
    }
}
