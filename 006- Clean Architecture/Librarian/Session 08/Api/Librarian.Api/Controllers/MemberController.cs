using Librarian.Application.Features.Member.Commands.CreateMember;
using Librarian.Application.Features.Member.Commands.DeleteMember;
using Librarian.Application.Features.Member.Commands.UpdateMember;
using Librarian.Application.Features.Member.Queries.GetAllMembers;
using Librarian.Application.Features.Member.Queries.GetMemebrDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Librarian.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<MemberDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllMembersRequest());
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDetailsDto>> Get(int id)
        {
            var result = await _mediator.Send(new GetMemberDetailsRequest(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateMemberRequest item)
        {
            var response = await _mediator.Send(item);
            return CreatedAtAction(nameof(Post), new { id = response });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(UpdateMemberRequest item)
        {
            await _mediator.Send(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteMemberRequest(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
