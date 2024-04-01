namespace Librarian.Application.Features.Member.Commands._Share
{
    public class BaseMemberRequest
    {
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
    }
}
