using MediatR;

namespace Librarian.Application.Features.Member.Queries.GetMemebrDetails
{
    public record GetMemberDetailsRequest(int Id):IRequest<MemberDetailsDto>;
}
