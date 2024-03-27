using MediatR;

namespace Librarian.Application.Features.Member.Commands.CreateMember
{
    public class CreateMemberRequest:IRequest<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
