using HouseHunting.BIZ.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HouseHunting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseHuntingController : ControllerBase
    {
        private readonly ILogger<HouseHuntingController> _logger;
        private readonly IMediator _mediator;

        public HouseHuntingController(ILogger<HouseHuntingController> logger,IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetHouses")]
        public async Task<IActionResult> GetHouses()
        {
            return Ok(await _mediator.Send(new GetAllHousesRequest()));
        }

        [HttpGet("GetHousesByBudget")]
        public async Task<IActionResult> GetHousesByBudget(float budget)
        {
            return Ok(await _mediator.Send(new GetHousesByBudgetRequest(budget)));
        }
    }
}
