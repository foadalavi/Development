using MediatR;

namespace Librarian.Application.Features.Member.Commands.DeleteMember
{
    public record DeleteMemberRequest(int Id) : IRequest<Unit>;
}
