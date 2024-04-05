using MediatR;

namespace Librarian.Application.Features.Member.Queries.GetAllMembers
{
    public record GetAllMembersRequest:IRequest<List<MemberDto>>;
}
