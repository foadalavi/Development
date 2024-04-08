namespace Librarian.Application.Features.Member.Queries.GetMemebrDetails
{
    public class MemberDetailsDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        public DateTime ModificationDate { get; set; } = DateTime.Now;
        public int ModifiedBy { get; set; }
    }
}